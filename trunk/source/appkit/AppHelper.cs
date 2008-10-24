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
using System.Collections.Generic;
using System.Threading;

namespace MCocoa
{
	// Handles BeginInvoke and the Debug menu.
	[ExportClass("AppHelper", "NSObject")]
	internal sealed class AppHelper : NSObject
	{
		public AppHelper() : base(Native.Call("[[AppHelper alloc] init]"))
		{
			m_thread = new Thread(this.DoThread);
			m_thread.IsBackground = true;
			m_thread.Start();
		}
		
		public void Add(Action action)
		{
			lock (m_lock)
			{
				m_actions.Add(action);
	            Monitor.PulseAll(m_lock);
			}
		}
		
		public void QueueDelayed(Action action, TimeSpan delay)
		{
			int id = m_actionID++;
			m_delayedActions.Add(id, action);
			
			Call("performSelector:withObject:afterDelay:", 
				new Selector("OnDelayedAction:"),
				new NSNumber(id),
				delay.TotalSeconds);
		}
		
		[NewMethod("OnDelayedAction:")]		
		public void OnDelayedAction(NSNumber id)
		{
			Action action = m_delayedActions[id.intValue()];
			m_delayedActions.Remove(id.intValue());

			try
			{
				action();
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("Ignoring BeginInvoke exception:");	// TODO: this kind of sucks, however appkit doesn't do any better if we let the exception escape
				Console.Error.WriteLine(e.Message);
				Console.Error.WriteLine(e.StackTrace);
			}
		}
		
		#region Event Handlers ------------------------------------------------
#if DEBUG
		[NewMethod("InitDebugMenu")]		
		public void InitDebugMenu()
		{
			NSMenu debugMenu = new NSMenu("Debug");
			debugMenu.addItem(new NSMenuItem("Collect Garbage", "CollectGarbage:", this));
			debugMenu.addItem(new NSMenuItem("Dump Objects", "DumpObjects:", this));
			debugMenu.addItem(new NSMenuItem("Dump Windows", "DumpWindows:", this));
			
			NSMenuItem debugItem = new NSMenuItem("Debug");
			debugItem.setSubmenu(debugMenu);
			
			NSApplication.sharedApplication().mainMenu().addItem(debugItem);
		}

		[DisableRule("P1017", "ExplicitGC")]
		[NewMethod("CollectGarbage:")]		
		public void CollectGarbage(NSObject sender)
		{
			Unused.Arg(sender);
			
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
		
		[NewMethod("DumpObjects:")]		
		public void DumpObjects(NSObject sender)
		{
			Unused.Arg(sender);
			
			CollectGarbage(null);

			List<string> lines = new List<string>();			
			foreach (NSObject o in NSObject.Snapshot())
			{
				lines.Add(o.ToString("G", null));
			}
			
			lines.Sort();
			foreach (string line in lines)
				Console.WriteLine(line);
			Console.WriteLine(" ");
		}
		
		[NewMethod("DumpWindows:")]		
		public void DumpWindows(NSObject sender)
		{
			Unused.Arg(sender);
			
			for (int i = 0; i < NSApplication.sharedApplication().windows().Length; ++i)
			{
				int indent = 0;
				DoDump(NSApplication.sharedApplication().windows()[i], ref indent);
				Console.WriteLine(" ");
			}
		}
#endif	// DEBUG

		[NewMethod("Execute:")]		
		public void Execute(NSObject arg)
		{
			Unused.Arg(arg);
			
			List<Action> actions;

			lock (m_lock)
			{
				actions = new List<Action>(m_actions);
				m_actions.Clear();
				m_pendingExecute = false;
			}
						
			foreach (Action action in actions)
			{
				try
				{
					action();
				}
				catch (Exception e)
				{
					Console.Error.WriteLine("Ignoring BeginInvoke exception:");	// TODO: this kind of sucks, however appkit doesn't do any better if we let the exception escape
					Console.Error.WriteLine(e.Message);
					Console.Error.WriteLine(e.StackTrace);
				}
			}
		}
		#endregion
		
		#region Private Methods	 ----------------------------------------------
#if DEBUG
		private void DoDump(NSResponder o, ref int indent)
		{
			if (!o.nextResponder().IsNil())
				DoDump(o.nextResponder(), ref indent);
				
			if (o.nextResponder().IsNil())
				DoDump1(NSApplication.sharedApplication(), ref indent);

			DoDump1(o, ref indent);
		}

		private void DoDump1(NSResponder o, ref int indent)
		{
			Console.Write("{0}{1}", new string(' ', 3*indent), o);
					
			List<string> extras = new List<string>();
			if ((IntPtr) o == (IntPtr) NSApplication.sharedApplication().keyWindow())
				extras.Add("key");
			if ((IntPtr) o == (IntPtr) NSApplication.sharedApplication().mainWindow())
				extras.Add("main");
			if (o.respondsToSelector(new Selector("isVisible")))
				if (!(bool) o.Call("isVisible"))
					extras.Add("hidden");
					
			if (extras.Count > 0)
				Console.Write(" [{0}]", string.Join(", ", extras.ToArray()));
			Console.WriteLine();

			if (o.respondsToSelector(new Selector("delegate")))
			{
				NSObject d = (NSObject) o.Call("delegate");
				if (!NSObject.IsNullOrNil(d))
				{
					Console.WriteLine("{0}{1}", new string(' ', 3*indent), d);
				}
			}
			++indent;
		}
#endif	// DEBUG
		
		private void DoThread()
		{
			Selector selector = new Selector("Execute:");		
			NSObject pool = (NSObject) Native.Call("[[NSAutoreleasePool alloc] init]");
			Unused.Value = pool;		// shut compiler up

			while (true)
			{
				lock (m_lock)
				{
					while (m_actions.Count == 0)
					{
						Ignore.Value = Monitor.Wait(m_lock);
					}
					
					if (!m_pendingExecute)
					{
						performSelectorOnMainThreadWithObjectWaitUntilDone(selector, this, false);
						m_pendingExecute = true;
					}
				}
			}			
		}
		#endregion
		
		#region Fields -------------------------------------------------------
	    private readonly object m_lock = new object();
		private List<Action> m_actions = new List<Action>();
		private bool m_pendingExecute;
		private Thread m_thread;
		private int m_actionID;
		private Dictionary<int, Action> m_delayedActions = new Dictionary<int, Action>();
		#endregion
	}
}
