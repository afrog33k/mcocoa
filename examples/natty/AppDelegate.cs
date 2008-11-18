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

using MCocoa;
using MObjc;
using System;
using System.IO;
using System.Runtime.InteropServices;

// http://developer.apple.com/documentation/Cocoa/Reference/ApplicationKit/Classes/NSApplication_Class/Reference/Reference.html#//apple_ref/doc/uid/20000012-BAJFJIIB
[ExportClass("AppDelegate", "NSObject")]
internal sealed class AppDelegate : NSObject
{
	private AppDelegate(IntPtr instance) : base(instance)
	{
		NSMutableDictionary dict = NSMutableDictionary.Create();
		dict.setObjectForKey(NSString.Create("all"), NSString.Create("defaultTarget"));
		dict.setObjectForKey(NSString.Create("install uninstall"), NSString.Create("ignoredTargets"));
		dict.setObjectForKey(NSString.Create("bbedit {0}:{1}"), NSString.Create("editor"));

		NSUserDefaults defaults = NSUserDefaults.standardUserDefaults();
		defaults.registerDefaults(dict);
	}
	
	public void applicationDidFinishLaunching(NSObject notification)
	{		
		NSDocumentController controller = NSDocumentController.sharedDocumentController();
		controller.openDocument(this);
	}
}
