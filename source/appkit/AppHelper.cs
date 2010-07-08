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
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace MCocoa
{
	// Handles BeginInvoke and the Debug menu.
	[ExportClass("AppHelper", "NSObject")]
	internal sealed class AppHelper : NSObject
	{
		public AppHelper(IntPtr instance) : base(instance)
		{
#if DEBUG		
			Contract.Assert(!ms_created, "AppHelper should be created only once");
			ms_created = true;
			
			NSNotificationCenter.defaultCenter().addObserver_selector_name_object(
				this, "terminating:", Externs.NSApplicationWillTerminateNotification, null);
#endif
		}
		
		public static AppHelper Create()
		{
			AppHelper result = new AppHelper(NSObject.AllocAndInitInstance("AppHelper"));
			
			result.m_thread = new Thread(result.DoThread);
			result.m_thread.Name = "AppHelper";
			result.m_thread.IsBackground = true;
			result.m_thread.Start();
			
			return result;
		}
		
#if DEBUG		
		// NSApplication.Invoke won't return so we need to rely on this notification.
		public void terminating(NSNotification notification)
		{
			string[] names = BlockCookie.InUse();
			if (names != null)
			{
				string nl = string.Join(", ", names);
				Console.Error.WriteLine("Free needs to be called on the following BlockCookies: {0}.", nl);
				
				// Users may not see an exception thrown during app exit so we'll pop
				// up an alert instead.
				NSString title = NSString.Create("Not all BlockCookies were freed.");
				NSString message = NSString.Create(nl);
				Unused.Value = Functions.NSRunAlertPanel(title, message);
			}
		}
#endif
		
		[ThreadModel(ThreadModel.Concurrent)]
		public void Add(Action action)
		{
			lock (m_lock)
			{
				m_actions.Add(action);
				Monitor.PulseAll(m_lock);
			}
		}
		
		[ThreadModel(ThreadModel.Concurrent)]
		public void QueueDelayed(Action action, TimeSpan delay)
		{
			int id;
			lock (m_lock)
			{
				id = m_actionID++;
				m_delayedActions.Add(id, action);
			}
			
			Unused.Value = Call("performSelector:withObject:afterDelay:",
				new Selector("onDelayedAction:"),
				NSNumber.Create(id),
				delay.TotalSeconds);
		}
		
		public void onDelayedAction(NSNumber id)
		{
			Action action = null;
			lock (m_lock)
			{
				action = m_delayedActions[id.intValue()];
				Unused.Value = m_delayedActions.Remove(id.intValue());
			}
			
			try
			{
				action();
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("Ignoring BeginInvoke exception: ");	// TODO: this kind of sucks, however appkit doesn't do any better if we let the exception escape
				Console.Error.WriteLine("{0}", e);
			}
		}
		
		#region Event Handlers
#if DEBUG
		internal NSMenu InitDebugMenu()
		{
			NSMenu debugMenu = DoGetDebugMenu();
			debugMenu.addItem(NSMenuItem.Create("Collect Garbage", "collectGarbage:", this));
			debugMenu.addItem(NSMenuItem.Create("Dump Objects", "dumpObjects:", this));
			debugMenu.addItem(NSMenuItem.Create("Dump Windows", "dumpWindows:", this));
			
			return debugMenu;
		}
		
		public void collectGarbage(NSObject sender)
		{
			//  TODO: for some reason objects hang around if we do this only once
			// or do not do the sleep...
			for (int i = 0; i < 4; ++i)
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
				Thread.Sleep(250);
			}
		}
		
		public void dumpObjects(NSObject sender)
		{
			collectGarbage(null);
			
			List<string> lines = new List<string>();
			foreach (NSObject o in NSObject.Snapshot())
			{
				lines.Add(o.ToString("S", null));
			}
			
			lines.Sort();
			foreach (string line in lines)
				Console.WriteLine(line);
			Console.WriteLine(" ");
		}
		
		public void dumpWindows(NSObject sender)
		{
			Unused.Value = sender;
			for (int i = 0; i < NSApplication.sharedApplication().windows().Length; ++i)
			{
				int indent = 0;
				DoDump(NSApplication.sharedApplication().windows()[i], ref indent);
				Console.WriteLine(" ");
			}
		}
#endif	// DEBUG
	
		public void execute(NSObject arg)
		{
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
					Console.Error.WriteLine("{0}", e);
				}
			}
		}
		#endregion
		
		#region Private Methods
#if DEBUG
		private NSMenu DoGetDebugMenu()
		{
			NSMenu debugMenu = null;
			
			NSMenuItem debugItem = NSApplication.sharedApplication().mainMenu().itemWithTitle(NSString.Create("Debug"));
			if (!NSObject.IsNullOrNil(debugItem))
			{
				debugMenu = debugItem.submenu();
				debugMenu.addItem(NSMenuItem.separatorItem());
			}
			
			if (NSObject.IsNullOrNil(debugItem))
			{
				debugMenu = NSMenu.Create("Debug");
				
				debugItem = NSMenuItem.Create("Debug");
				debugItem.setSubmenu(debugMenu);
				
				NSApplication.sharedApplication().mainMenu().addItem(debugItem);
			}
			
			return debugMenu;
		}
		
		private void DoDump(NSResponder o, ref int indent)
		{
			if (NSObject.IsNullOrNil(o))
			{
				DoDump1(NSApplication.sharedApplication(), ref indent);
			}
			else
			{
				DoDump(o.nextResponder(), ref indent);
				DoDump1(o, ref indent);
			}
		}
		
		private void DoDump1(NSResponder o, ref int indent)
		{
			Console.Write("{0}{1}", new string(' ', 3*indent), o);
			
			List<string> extras = new List<string>();
			if (o == NSApplication.sharedApplication().keyWindow())
				extras.Add("key");
			if (o == NSApplication.sharedApplication().mainWindow())
				extras.Add("main");
			if (o.respondsToSelector("isVisible"))
				if ((sbyte) o.Call("isVisible") == 0)
					extras.Add("hidden");
					
			if (extras.Count > 0)
				Console.Write(" [{0}]", string.Join(", ", extras.ToArray()));
				
			Console.WriteLine();
			
			if (o.respondsToSelector("delegate"))
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
		
		[ThreadModel(ThreadModel.SingleThread)]
		private void DoThread()
		{
			Selector selector = new Selector("execute:");
			NSObject pool = (NSObject) new Class("NSAutoreleasePool").Call("alloc").Call("init");
			Unused.Value = pool;		// shut compiler up
			
			while (true)
			{
				lock (m_lock)
				{
					while (m_actions.Count == 0)
					{
						Unused.Value = Monitor.Wait(m_lock);
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
		
		#region Fields
		private Thread m_thread;
		private readonly object m_lock = new object();
			private List<Action> m_actions = new List<Action>();
			private int m_actionID;
			private Dictionary<int, Action> m_delayedActions = new Dictionary<int, Action>();
			private bool m_pendingExecute;
			
#if DEBUG		
		private static bool ms_created;
#endif
		#endregion
	}
}
