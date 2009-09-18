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

[ExportClass("AppController", "NSObject", Outlets = "tableView view")]
internal sealed class AppController : NSObject
{
	public AppController(IntPtr instance) : base(instance)
	{
	}
	
	protected override void OnDealloc()
	{
		m_data.release();
		m_data = null;
		
		base.OnDealloc();
	}
	
	public void awakeFromNib()
	{
		m_tableView = this["tableView"].To<NSTableView>();
		m_view = this["view"].To<NSView>();

		NSString path = NSBundle.mainBundle().pathForResource_ofType(NSString.Create("Chart"), NSString.Create("qtz"));
		bool loaded = m_view.Call("loadCompositionFromFile:", path).To<bool>();
		if (!loaded)
			throw new System.IO.FileNotFoundException(string.Format("Couldn't load '{0:D}'", path));
		
		DoAppendData("Palo Alto", 2);
		DoAppendData("Cupertino", 1);
		DoAppendData("Menlo Park", 4);
		DoAppendData("Mountain View", 8);
		DoAppendData("San Francisco", 7);
		DoAppendData("Los Altos", 3);
		
		m_tableView.reloadData();
		DoUpdateChart();
	}
	
	#region Actions and NSTableDataSource Methods
	public void addEntry(NSObject sender)
	{
		DoAppendData("Untitled", 0);
		
		m_tableView.reloadData();
		DoUpdateChart();
		
		uint row = m_data.count() - 1;
		var indexes = NSIndexSet.indexSetWithIndex(row);
		m_tableView.selectRowIndexes_byExtendingSelection(indexes, false);
		
		m_tableView.editColumn_row_withEvent_select(
			m_tableView.columnWithIdentifier(DataKeyLabel), (int) row, null, false);
	}
	
	public void removeEntry(NSObject sender)
	{
		int row = m_tableView.selectedRow();
		if (row < 0 || m_tableView.editedRow() == row)
			return;
		
		m_data.removeObjectAtIndex((uint) row);
		
		m_tableView.reloadData();
		DoUpdateChart();
	}
	
	public int numberOfRowsInTableView(NSTableView table)
	{
		return (int) m_data.count();
	}
	
	public NSObject tableView_objectValueForTableColumn_row(NSTableView table, NSTableColumn col, int row)
	{
		NSDictionary dict = m_data.objectAtIndex((uint) row).To<NSDictionary>();
		return dict.objectForKey(col.identifier());
	}
	
	public void tableView_setObjectValue_forTableColumn_row(NSTableView table, NSObject value, NSTableColumn col, int row)
	{
		NSMutableDictionary dict = m_data.objectAtIndex((uint) row).To<NSMutableDictionary>();
		dict.setObject_forKey(value, col.identifier());
		
		DoUpdateChart();
	}
	#endregion
	
	#region Private Methods
	private void DoUpdateChart()
	{
		m_view.Call("setValue:forInputKey:", m_data, ParameterKeyData);
		
		float max = 0.0f;
		for (uint i = 0; i < m_data.count(); ++i)
		{
			var dict = m_data.objectAtIndex(i).To<NSDictionary>();
			var value = dict.objectForKey(DataKeyValue).To<NSNumber>().floatValue();
			if (value > max)
				max = value;
		}
		m_view.Call("setValue:forInputKey:", NSNumber.numberWithFloat(max > 0.0 ? 1.0f / max : 1.0f), ParameterKeyScale);
	}
	
	private void DoAppendData(string label, int data)
	{
		var dict = NSMutableDictionary.Create();
		dict.setObject_forKey(NSString.Create(label), DataKeyLabel);
		dict.setObject_forKey(NSNumber.numberWithInt(data), DataKeyValue);
		
		m_data.addObject(dict);
	}
	#endregion
	
	#region Fields
	private readonly NSString DataKeyLabel = NSString.Create("label").Retain();
	private readonly NSString DataKeyValue = NSString.Create("value").Retain();
	private readonly NSString ParameterKeyData = NSString.Create("Data").Retain();
	private readonly NSString ParameterKeyScale = NSString.Create("Scale").Retain();
	
	private NSTableView m_tableView;
	private NSView m_view;
	private NSMutableArray m_data = NSMutableArray.Create().Retain();
	#endregion
}
