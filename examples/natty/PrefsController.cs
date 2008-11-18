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

[ExportClass("PrefsController", "NSObject", IVars = "panel owner editor ignored")]
internal sealed class PrefsController : NSObject
{
	private PrefsController(IntPtr instance) : base(instance) 	
	{
		m_owner = new IVar<NSObject>(this, "owner");
		m_panel = new IVar<NSWindow>(this, "panel");
		m_editor = new IVar<NSTextField>(this, "editor");
		m_ignored = new IVar<NSTextField>(this, "ignored");
	}
 
	public void awakeFromNib()
	{
		m_panel.Value.setDelegate(this);

		NSObject defaults = NSUserDefaultsController.sharedUserDefaultsController();
		NSDictionary options = NSDictionary.dictionaryWithObjectForKey(NSNumber.Create(true), NSString.Create("NSContinuouslyUpdatesValue"));

		string path = "values.editor";
		m_editor.Value.bindToObjectWithKeyPathOptions("value", defaults, path, options);

		NSDocument doc = m_owner.Value.Call("document").To<NSDocument>();
		path = "values." + doc.fileURL().absoluteString() + "-ignored";
		m_ignored.Value.bindToObjectWithKeyPathOptions("value", defaults, path, options);
    }
    
    public void windowWillClose(NSNotification notify)
    {    	
    	m_owner.Value.Call("rebuildTargets");
    }
		
	private IVar<NSObject> m_owner;
	private IVar<NSWindow> m_panel;
	private IVar<NSTextField> m_editor;
	private IVar<NSTextField> m_ignored;
}
