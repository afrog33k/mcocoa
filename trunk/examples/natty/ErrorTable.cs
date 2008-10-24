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

[ExportClass("ErrorTable", "NSTableView")]
internal sealed class ErrorTable : NSTableView
{
	public ErrorTable(IntPtr instance) : base(instance)
	{
	}
			
	public ErrorTable(Untyped instance) : base(instance)
	{
	}
			
	#region Overrides
	[OverrideMethod("mouseDown:")]		
	public void MouseDown(NSEvent evt)
	{
		if (evt.ClickCount == 2)
			DoOpen();
		else
			SuperCall("mouseDown:", evt);
	}

	[OverrideMethod("keyDown:")]		
	public void KeyDown(NSEvent evt)
	{
		if (evt.KeyCode == NSEvent.NSTabFunctionKey)
		{
			int row = SelectedRow;
			
			if ((evt.Modifiers & ModifierFlags.Shift) == ModifierFlags.Shift)
				--row;
			else
				++row;
				
			if (row >= 0 && row < NumberOfRows)
				SelectedRow = row;
		}
		else if (evt.KeyCode == NSEvent.NSReturnFunctionKey || evt.KeyCode == NSEvent.NSEnterFunctionKey)
		{
			DoOpen();
		}
		else
		{
			SuperCall("keyDown:", evt);
		}
	}
	#endregion	
	
	private void DoOpen()
	{
		NSIndexSet indexes = SelectedRowIndexes;
		
		int index = indexes.FirstIndex;
		while (index != NSRange.NSNotFound)
		{
			DataSource.Call("openFile:", index);
			index = indexes.IndexGreaterThanIndex(index);
		}
	}
}

