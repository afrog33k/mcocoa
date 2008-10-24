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

using Cocoa3;
using Objc3;
using System;
using System.Collections.Generic;

[ExportClass("FlagsController", "NSObject", IVars = "sheet")]
internal sealed class FlagsController : NSObject
{
	private FlagsController(IntPtr instance) : base(instance) 
	{
		m_sheet = new IVar<NSWindow>(this, "sheet");
	}
						
	public void Open(Document doc, NSWindow window)
	{
		m_doc = doc;
		m_flags = new Dictionary<string, int>(m_doc.Flags);
		
		NSView[] views = m_sheet.Value.ContentView.Subviews;
		for (int i = 0; i < views.Length; ++i)
		{
			if (views[i].RespondsTo(new Selector("title")))
			{
				string title = new NSString(views[i].Call("title")).ToString();
				if (m_flags.ContainsKey(title))
					views[i].Call("setState:", m_flags[title]);
			}
		}

		m_sheet.Value.Delegate = this;
		NSApplication.Shared.BeginSheet(m_sheet.Value, window, this);
    }

	#region Action Handlers
	[NewMethod("toggle:")]		
	public void Toggle(NSButton sender)
	{
		m_flags[sender.Title] = sender.State;
    }

	[NewMethod("flagsOK:")]		
	public void FlagsOK(NSObject sender)
	{
		foreach (KeyValuePair<string, int> entry in m_flags)
			m_doc.Flags[entry.Key] = entry.Value;
		m_flags.Clear();
			
		NSApplication.Shared.EndSheet(m_sheet.Value);
		m_sheet.Value.OrderOut();
    }

	[NewMethod("flagsCancel:")]		
	public void FlagsCancel(NSObject sender)
	{
		NSApplication.Shared.EndSheet(m_sheet.Value);
		m_sheet.Value.OrderOut();
   	}
	#endregion
		
	private IVar<NSWindow> m_sheet;
	private Document m_doc;
	private Dictionary<string, int> m_flags = new Dictionary<string, int>();
}
