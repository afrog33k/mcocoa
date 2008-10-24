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
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MCocoa
{ 
	public partial class NSApplication : NSResponder 
	{		
		static NSApplication()
		{
			// Make our app a foreground app (this is redundant if we were started via the
			// Finder or the open command, but important if we were started by directly
			// executing the launcher script).
			IntPtr psn = IntPtr.Zero;	
			GetCurrentProcess(ref psn);
			
			TransformProcessType(ref psn, 1);
			SetFrontProcess(ref psn);

			// Cocoa expects an NSAutoreleasePool to always be available so we need to
			// create one which we can use before we enter the main event loop.
			ms_startupPool = (NSObject) Native.Call("[[NSAutoreleasePool alloc] init]");
		}
		
		public NSApplication(string nibName) : base(Native.Call("[NSApplication sharedApplication]"))
		{		
			m_mainThread = Thread.CurrentThread;

			// Load our nib. This will instantiate all of the native objects and wire them together.
			// The C# objects will be created the first time a managed method is called.
			NSMutableDictionary dict = new NSMutableDictionary();					
			bool loaded = NSBundle.mainBundle().loadNibFileExternalNameTableWithZone(
				new NSString(nibName), dict, IntPtr.Zero);
							
			if (!loaded)
				throw new InvalidOperationException("Couldn't load " + nibName + ".");

			// We need an NSAutoreleasePool to do Native.Call, but we don't want to have one
			// hanging around while we're in the main event loop because that may hide bugs.
			// So, we'll instantiate a Native instance here and call Invoke later which can
			// be done without an NSAutoreleasePool.
			m_run = new Native(this, new Selector("run"));
			
#if DEBUG
			BeginInvoke(() => m_helper.Call("InitDebugMenu"));
#endif

			ms_startupPool.release();
			ms_startupPool = null;
		}
		        			
		public void run()
		{
			Ignore.Value = m_run.Invoke();
		}
		
		public NSWindow[] windows()
		{
			NSArray items = new NSArray(Call("windows"));

			NSWindow[] result = new NSWindow[items.count()];
			for (int i = 0; i < items.count(); ++i)
				result[i] = new NSWindow((IntPtr) items.objectAtIndex((uint) i));
				
			return result;					
		}
			
		public void BeginInvoke(Action action)
		{
			DBC.Pre(action != null, "action is null");

			m_helper.Add(action);
		}
		
		public void BeginInvoke(Action action, TimeSpan delay)
		{
			DBC.Pre(action != null, "action is null");
			DBC.Pre(delay >= TimeSpan.Zero, "delay is negative");

			m_helper.QueueDelayed(action, delay);
		}
				
		public bool InvokeRequired
		{
			get {return Thread.CurrentThread != m_mainThread;}
		}
									
		#region P/Invokes -----------------------------------------------------
		[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
		private static extern void GetCurrentProcess(ref IntPtr psn);
	
		[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
		private static extern void TransformProcessType(ref IntPtr psn, uint type);
	
		[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
		private static extern void SetFrontProcess(ref IntPtr psn);
		#endregion

		#region Fields --------------------------------------------------------
		private Native m_run;
		private AppHelper m_helper = new AppHelper();
		private Thread m_mainThread;

		private static NSObject ms_startupPool;
		#endregion
	}
}