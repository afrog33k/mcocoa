// Copyright (C) 2009 Jesse Jones
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

using MCocoa;
using MObjc;
using MObjc.Helpers;
using System;
using System.Runtime.InteropServices;

internal static class Program
{
	public static void Main(string[] args)
	{
		// NSObjects cannot be created until this is set. It should be set after all
		// assemblies which contain exported or registered mobjc types have been
		// loaded.
		Registrar.CanInit = true;
		
		// If this is set then mobjc will save stack traces for all NSObjects. The Dump
		// Objects command in the Debug menu can be used to print the stack traces
		// for all outstanding objects (normally you'd use the Debug menu to force a
		// garbage collection before doing this).
//		NSObject.SaveStackTraces = true;
		
		// mcocoa will load the foundation and appkit frameworks automatically but
		// we need to explicitly load QuartzComposer. To do this we can p/invoke a
		// function it (or any frameworks it depends upon) exports.
		NSAvailableWindowDepths();
		
		// Pretty much all cocoa objects require that an autorelease pool is active.
		// One will be created each time through the main event loop, but we
		// haven't entered the main event loop so we need to create a pool so that
		// we can create the app.
		var pool = NSAutoreleasePool.Create();
		
		// Creates the application object. Note that there are also Create overloads
		// which can be used to create a custom NSApplication or to extend the 
		// Debug menu.
		NSApplication app = NSApplication.Create("MainMenu.nib");
			
		// If everything is OK then clear our autorelease pool and enter the main
		// event loop. Note that run will not return: if you want to hook into process
		// exit use AppDelegate.applicationWillTerminate.
		pool.release();
		app.run();
	}
	
	#region P/Invokes
	[DllImport("/System/Library/Frameworks/Quartz.framework/Quartz")]
	private static extern IntPtr NSAvailableWindowDepths();
	#endregion
}
