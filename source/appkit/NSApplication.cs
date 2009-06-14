// Copyright (C) 2008 Jesse Jones
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using MObjc;
using MObjc.Helpers;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MCocoa
{
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/documentation/Cocoa/Reference/ApplicationKit/Classes/nsapplication_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSApplication : NSResponder
	{
		static NSApplication()
		{
			// Make our app a foreground app (this is redundant if we were started via the
			// Finder or the open command, but important if we were started by directly
			// executing the launcher script).
			var psn = new ProcessSerialNumber();
			psn.highLongOfPSN = 0;
			psn.lowLongOfPSN = kCurrentProcess;
			
			int err = TransformProcessType(ref psn, kProcessTransformToForegroundApplication);
			if (err != 0)
				throw new InvalidOperationException("TransformProcessType returned " + err + ".");
			
			err = SetFrontProcess(ref psn);
			if (err != 0)
				throw new InvalidOperationException("SetFrontProcess returned " + err + ".");
			
			// Cocoa expects an NSAutoreleasePool to always be available so we need to
			// create one which we can use before we enter the main event loop.
			ms_startupPool = NSAutoreleasePool.Create();
		}
		
		/// <summary>Helper used to create an NSApplication subclass.</summary>
		/// <param name = "appClass">The name of the subclass, e.g. "MyApplication".</param>
		/// <param name = "nibName">The name of a nib file, e.g. "MainMenu.nib".</param>
		/// <param name = "extendDebugMenu">Used to add custom items to the debug menu. May be null.</param>
		public static NSApplication Create(string appClass, string nibName, Action<NSMenu> extendDebugMenu)
		{
			NSApplication app = new Class(appClass).Call("sharedApplication").To<NSApplication>();
			
			ms_mainThread = Thread.CurrentThread;
			
			// Load our nib. This will instantiate all of the native objects and wire them together.
			// The C# objects will be created the first time a managed method is called.
			NSMutableDictionary dict = NSMutableDictionary.Create();
			bool loaded = NSBundle.mainBundle().loadNibFile_externalNameTable_withZone_i(
				NSString.Create(nibName), dict, IntPtr.Zero);
			
			if (!loaded)
				throw new InvalidOperationException("Couldn't load " + nibName + ".");
			
			// We need an NSAutoreleasePool to do Native.Call, but we don't want to have one
			// hanging around while we're in the main event loop because that may hide bugs.
			// So, we'll instantiate a Native instance here and call Invoke later which can
			// be done without an NSAutoreleasePool.
			ms_run = new Native(app, new Selector("run"));
			
			ms_helper = AppHelper.Create();
#if DEBUG
			app.BeginInvoke(() => DoInitDebugMenu(extendDebugMenu));
#endif
			
			ms_startupPool.release();
			ms_startupPool = null;
			
			return app;
		}
		
		/// <summary>Helper used to create an NSApplication.</summary>
		/// <param name = "nibName">The name of a nib file, e.g. "MainMenu.nib".</param>
		/// <param name = "extendDebugMenu">Used to add custom items to the debug menu. May be null.</param>
		public static NSApplication Create(string nibName, Action<NSMenu> extendDebugMenu)
		{
			return Create("NSApplication", nibName, extendDebugMenu);
		}
		
		/// <summary>Helper used to create an NSApplication.</summary>
		/// <param name = "nibName">The name of a nib file, e.g. "MainMenu.nib".</param>
		public static NSApplication Create(string nibName)
		{
			return Create(nibName, null);
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static NSApplication sharedApplication()
		{
			IntPtr exception_ = IntPtr.Zero;
			IntPtr result_ = DirectCalls.Callp(ms_class, new Selector("sharedApplication"), ref exception_);
			if (exception_ != IntPtr.Zero)
				CocoaException.Raise(exception_);
			
			return result_.To<NSApplication>();
		}
		
		/// <exclude/>
		public void run()
		{
			Unused.Value = ms_run.Invoke();
		}
		
		/// <exclude/>
		[Pure]
		public NSWindow[] windows()
		{
			NSArray items = (NSArray) Call("windows");
			
			NSWindow[] result = new NSWindow[items.count()];
			for (int i = 0; i < items.count(); ++i)
				result[i] = items.objectAtIndex((uint) i).To<NSWindow>();
				
			return result;
		}
		
		/// <summary>Queues up the action so that it can be executed later on the main thread.</summary>
		/// <remarks>If the action throws an exception it will be logged to stderr and ignored.</remarks>
		[ThreadModel(ThreadModel.Concurrent)]
		public void BeginInvoke(Action action)
		{
			Contract.Requires(action != null, "action is null");
			
			ms_helper.Add(action);
		}
		
		/// <summary>Queues up the action so that it can be executed later on the main thread.</summary>
		/// <param name = "action">The delegate to call.</param>
		/// <param name = "delay">The amount of time to wait before calling the action.</param>
		/// <remarks>If the action throws an exception it will be logged to stderr and ignored.</remarks>
		[ThreadModel(ThreadModel.Concurrent)]
		public void BeginInvoke(Action action, TimeSpan delay)
		{
			Contract.Requires(action != null, "action is null");
			Contract.Requires(delay >= TimeSpan.Zero, "delay is negative");
			
			ms_helper.QueueDelayed(action, delay);
		}
		
		/// <summary>Returns true if the current thread is not the main thread.</summary>
		/// <remarks>Most of appkit and a lot of foundation is not thread safe (see
		/// <a href = "http://developer.apple.com/documentation/Cocoa/Conceptual/Multithreading/ThreadSafetySummary/ThreadSafetySummary.html">Apple's docs</a>
		/// for details) so you can use this method to figure out if you need to use BeginInvoke.</remarks>
		[ThreadModel(ThreadModel.Concurrent)]
		public bool InvokeRequired
		{
			get {return Thread.CurrentThread != ms_mainThread;}
		}
		
		#region Private Methods
#if DEBUG
		private static void DoInitDebugMenu(Action<NSMenu> extendDebugMenu)
		{
			NSMenu menu = ms_helper.InitDebugMenu();
			if (extendDebugMenu != null)
				extendDebugMenu(menu);
		}
#endif
		#endregion
		
		#region P/Invokes
		private const uint kCurrentProcess = 2;
		private const uint kProcessTransformToForegroundApplication = 1;
		
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		private struct ProcessSerialNumber
		{
			public uint highLongOfPSN;
			public uint lowLongOfPSN;
		}
		
		[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
		private static extern int TransformProcessType(ref ProcessSerialNumber psn, uint type);
		
		[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
		private static extern short SetFrontProcess(ref ProcessSerialNumber psn);
		#endregion
		
		#region Fields
		private static Native ms_run;						// we're not an exported class so mobjc may create new instances of our class even for the same id thus our data should be static
		private static AppHelper ms_helper;
		private static Thread ms_mainThread;
		
		private static NSObject ms_startupPool;
		#endregion
	}
}
