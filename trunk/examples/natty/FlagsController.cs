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
using System.Collections.Generic;

[ExportClass("FlagsController", "NSObject", Outlets = "sheet")]
internal sealed class FlagsController : NSObject
{
	private FlagsController(IntPtr instance) : base(instance) 
	{
		m_sheet = new IBOutlet<NSWindow>(this, "sheet");
	}
						
	public void Open(Document doc, NSWindow window)
	{
		m_doc = doc;
		m_flags = new Dictionary<string, int>(m_doc.Flags);
		
		NSView[] views = m_sheet.Value.contentView().subviews();
		for (int i = 0; i < views.Length; ++i)
		{
			if (views[i].respondsToSelector("title"))
			{
				string title = views[i].Call("title").To<NSString>().ToString();
				if (m_flags.ContainsKey(title))
					views[i].Call("setState:", m_flags[title]);
			}
		}

		m_sheet.Value.setDelegate(this);
		NSApplication.sharedApplication().beginSheet_modalForWindow_modalDelegate_didEndSelector_contextInfo(m_sheet.Value, window, this, null, IntPtr.Zero);
    }

	#region Action Handlers
	public void toggle(NSButton sender)
	{
		m_flags[sender.title().ToString()] = sender.state();
    }

	public void flagsOK(NSObject sender)
	{
		foreach (KeyValuePair<string, int> entry in m_flags)
			m_doc.Flags[entry.Key] = entry.Value;
		m_flags.Clear();
			
		NSApplication.sharedApplication().endSheet(m_sheet.Value);
		m_sheet.Value.orderOut(this);
    }

	public void flagsCancel(NSObject sender)
	{
		NSApplication.sharedApplication().endSheet(m_sheet.Value);
		m_sheet.Value.orderOut(this);
   	}
	#endregion
		
	private IBOutlet<NSWindow> m_sheet;
	private Document m_doc;
	private Dictionary<string, int> m_flags = new Dictionary<string, int>();
}
