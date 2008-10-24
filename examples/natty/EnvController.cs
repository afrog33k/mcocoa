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

[ExportClass("EnvController", "NSObject", IVars = "sheet table")]
internal sealed class EnvController : NSObject
{
	private EnvController(IntPtr instance) : base(instance) 
	{
		m_sheet = new IVar<NSWindow>(this, "sheet");
		m_table = new IVar<NSTableView>(this, "table");
	}
						
	public void Open(Document doc, NSWindow window)
	{
		m_doc = doc;
		m_vars = new List<KeyValuePair<string, string>>(m_doc.Variables);

		m_sheet.Value.Delegate = this;
		m_table.Value.DataSource = this;
		NSApplication.Shared.BeginSheet(m_sheet.Value, window, this);
    }

	#region Action Handlers
	[NewMethod("envOK:")]		
	public void EnvOK(NSObject sender)
	{
		NSApplication.Shared.EndSheet(m_sheet.Value);
		m_sheet.Value.OrderOut();
		
		m_doc.Variables.Clear();
		m_doc.Variables.AddRange(m_vars);
    }

	[NewMethod("envCancel:")]		
	public void EnvCancel(NSObject sender)
	{
		NSApplication.Shared.EndSheet(m_sheet.Value);
		m_sheet.Value.OrderOut();
   	}
	#endregion
	
	#region Data Source
	[NewMethod("numberOfRowsInTableView:")]		
	public int NumberOfRows(NSTableView table)
	{
		return m_vars.Count;
	}

	[NewMethod("tableView:objectValueForTableColumn:row:")]		
	public NSObject GetCell(NSTableView table, NSTableColumn column, int row)
	{
		KeyValuePair<string, string> entry = m_vars[row];
	
		if (column.Identifier == "1")
			return new NSString(entry.Key);
		else 
			return new NSString(entry.Value);
	}

	[NewMethod("tableView:setObjectValue:forTableColumn:row:")]		
	public void SetCell(NSTableView table, NSObject v, NSTableColumn column, int row)
	{
		DBC.Pre(column.Identifier == "2", "id is {0}", column.Identifier);
		
		string key = m_vars[row].Key;
		string value = new NSString(v).ToString();
		
		m_vars[row] = new KeyValuePair<string, string>(key, value);
	}
	#endregion
	
	private IVar<NSWindow> m_sheet;
	private IVar<NSTableView> m_table;
	private Document m_doc;
	private List<KeyValuePair<string, string>> m_vars = new List<KeyValuePair<string, string>>();
}
