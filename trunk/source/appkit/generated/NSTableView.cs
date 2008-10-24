// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTableView.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTableViewDropOn = 0;
		public const int NSTableViewDropAbove = 1;
	}

	public partial class Enums
	{
		public const int NSTableViewNoColumnAutoresizing = 0;
		public const int NSTableViewUniformColumnAutoresizingStyle = 1;
		public const int NSTableViewSequentialColumnAutoresizingStyle = 2;
		public const int NSTableViewReverseSequentialColumnAutoresizingStyle = 3;
		public const int NSTableViewLastColumnOnlyAutoresizingStyle = 4;
		public const int NSTableViewFirstColumnOnlyAutoresizingStyle = 5;
	}

	public partial class Enums
	{
		public const int NSTableViewGridNone = 0;
		public const int NSTableViewSolidVerticalGridLineMask = 1 << 0;
		public const int NSTableViewSolidHorizontalGridLineMask = 1 << 1;
	}

	public partial class Enums
	{
		public const int NSTableViewSelectionHighlightStyleRegular = 0;
		public const int NSTableViewSelectionHighlightStyleSourceList = 1;
	}

	[Register]
	public partial class NSTableView : NSControl
	{
		public NSTableView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTableView(IntPtr instance) : base(instance)
		{
		}

		public NSTableView(Untyped instance) : base(instance)
		{
		}

		public static new NSTableView alloc()
		{
			return new NSTableView(ms_class.Call("alloc"));
		}

		public new NSTableView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setDataSource(NSObject aSource)
		{
			Unused.Value = Call("setDataSource:", aSource);
		}

		public NSObject dataSource()
		{
			return Call("dataSource").To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setHeaderView(NSTableHeaderView headerView)
		{
			Unused.Value = Call("setHeaderView:", headerView);
		}

		public NSTableHeaderView headerView()
		{
			return Call("headerView").To<NSTableHeaderView>();
		}

		public void setCornerView(NSView cornerView)
		{
			Unused.Value = Call("setCornerView:", cornerView);
		}

		public NSView cornerView()
		{
			return Call("cornerView").To<NSView>();
		}

		public void setAllowsColumnReordering(bool flag)
		{
			Unused.Value = Call("setAllowsColumnReordering:", flag);
		}

		public bool allowsColumnReordering()
		{
			return Call("allowsColumnReordering").To<bool>();
		}

		public void setAllowsColumnResizing(bool flag)
		{
			Unused.Value = Call("setAllowsColumnResizing:", flag);
		}

		public bool allowsColumnResizing()
		{
			return Call("allowsColumnResizing").To<bool>();
		}

		public void setColumnAutoresizingStyle(UInt32 style)
		{
			Unused.Value = Call("setColumnAutoresizingStyle:", style);
		}

		public UInt32 columnAutoresizingStyle()
		{
			return Call("columnAutoresizingStyle").To<UInt32>();
		}

		public void setGridStyleMask(UInt32 gridType)
		{
			Unused.Value = Call("setGridStyleMask:", gridType);
		}

		public UInt32 gridStyleMask()
		{
			return Call("gridStyleMask").To<UInt32>();
		}

		public void setIntercellSpacing(NSSize aSize)
		{
			Unused.Value = Call("setIntercellSpacing:", aSize);
		}

		public NSSize intercellSpacing()
		{
			return Call("intercellSpacing").To<NSSize>();
		}

		public void setUsesAlternatingRowBackgroundColors(bool useAlternatingRowColors)
		{
			Unused.Value = Call("setUsesAlternatingRowBackgroundColors:", useAlternatingRowColors);
		}

		public bool usesAlternatingRowBackgroundColors()
		{
			return Call("usesAlternatingRowBackgroundColors").To<bool>();
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setGridColor(NSColor color)
		{
			Unused.Value = Call("setGridColor:", color);
		}

		public NSColor gridColor()
		{
			return Call("gridColor").To<NSColor>();
		}

		public void setRowHeight(float rowHeight)
		{
			Unused.Value = Call("setRowHeight:", rowHeight);
		}

		public float rowHeight()
		{
			return Call("rowHeight").To<float>();
		}

		public void noteHeightOfRowsWithIndexesChanged(NSIndexSet indexSet)
		{
			Unused.Value = Call("noteHeightOfRowsWithIndexesChanged:", indexSet);
		}

		public NSArray tableColumns()
		{
			return Call("tableColumns").To<NSArray>();
		}

		public Int32 numberOfColumns()
		{
			return Call("numberOfColumns").To<Int32>();
		}

		public Int32 numberOfRows()
		{
			return Call("numberOfRows").To<Int32>();
		}

		public void addTableColumn(NSTableColumn column)
		{
			Unused.Value = Call("addTableColumn:", column);
		}

		public void removeTableColumn(NSTableColumn column)
		{
			Unused.Value = Call("removeTableColumn:", column);
		}

		public Int32 columnWithIdentifier(NSObject identifier)
		{
			return Call("columnWithIdentifier:", identifier).To<Int32>();
		}

		public NSTableColumn tableColumnWithIdentifier(NSObject identifier)
		{
			return Call("tableColumnWithIdentifier:", identifier).To<NSTableColumn>();
		}

		public void tile()
		{
			Unused.Value = Call("tile");
		}

		// skipping sizeToFit (it's declared in a base class)

		public void sizeLastColumnToFit()
		{
			Unused.Value = Call("sizeLastColumnToFit");
		}

		public void scrollRowToVisible(Int32 row)
		{
			Unused.Value = Call("scrollRowToVisible:", row);
		}

		public void scrollColumnToVisible(Int32 column)
		{
			Unused.Value = Call("scrollColumnToVisible:", column);
		}

		public void moveColumnToColumn(Int32 column, Int32 newIndex)
		{
			Unused.Value = Call("moveColumn:toColumn:", column, newIndex);
		}

		public void reloadData()
		{
			Unused.Value = Call("reloadData");
		}

		public void noteNumberOfRowsChanged()
		{
			Unused.Value = Call("noteNumberOfRowsChanged");
		}

		public Int32 editedColumn()
		{
			return Call("editedColumn").To<Int32>();
		}

		public Int32 editedRow()
		{
			return Call("editedRow").To<Int32>();
		}

		public Int32 clickedColumn()
		{
			return Call("clickedColumn").To<Int32>();
		}

		public Int32 clickedRow()
		{
			return Call("clickedRow").To<Int32>();
		}

		public void setDoubleAction(Selector aSelector)
		{
			Unused.Value = Call("setDoubleAction:", aSelector);
		}

		public Selector doubleAction()
		{
			return Call("doubleAction").To<Selector>();
		}

		public void setSortDescriptors(NSArray array)
		{
			Unused.Value = Call("setSortDescriptors:", array);
		}

		public NSArray sortDescriptors()
		{
			return Call("sortDescriptors").To<NSArray>();
		}

		public void setIndicatorImageInTableColumn(NSImage anImage, NSTableColumn tc)
		{
			Unused.Value = Call("setIndicatorImage:inTableColumn:", anImage, tc);
		}

		public NSImage indicatorImageInTableColumn(NSTableColumn tc)
		{
			return Call("indicatorImageInTableColumn:", tc).To<NSImage>();
		}

		public void setHighlightedTableColumn(NSTableColumn tc)
		{
			Unused.Value = Call("setHighlightedTableColumn:", tc);
		}

		public NSTableColumn highlightedTableColumn()
		{
			return Call("highlightedTableColumn").To<NSTableColumn>();
		}

		public void setVerticalMotionCanBeginDrag(bool flag)
		{
			Unused.Value = Call("setVerticalMotionCanBeginDrag:", flag);
		}

		public bool verticalMotionCanBeginDrag()
		{
			return Call("verticalMotionCanBeginDrag").To<bool>();
		}

		public bool canDragRowsWithIndexesAtPoint(NSIndexSet rowIndexes, NSPoint mouseDownPoint)
		{
			return Call("canDragRowsWithIndexes:atPoint:", rowIndexes, mouseDownPoint).To<bool>();
		}

		public NSImage dragImageForRowsWithIndexesTableColumnsEventOffset(NSIndexSet dragRows, NSArray tableColumns, NSEvent dragEvent, IntPtr dragImageOffset)
		{
			return Call("dragImageForRowsWithIndexes:tableColumns:event:offset:", dragRows, tableColumns, dragEvent, dragImageOffset).To<NSImage>();
		}

		public void setDraggingSourceOperationMaskForLocal(UInt32 mask, bool isLocal)
		{
			Unused.Value = Call("setDraggingSourceOperationMask:forLocal:", mask, isLocal);
		}

		public void setDropRowDropOperation(Int32 row, UInt32 op)
		{
			Unused.Value = Call("setDropRow:dropOperation:", row, op);
		}

		public void setAllowsMultipleSelection(bool flag)
		{
			Unused.Value = Call("setAllowsMultipleSelection:", flag);
		}

		public bool allowsMultipleSelection()
		{
			return Call("allowsMultipleSelection").To<bool>();
		}

		public void setAllowsEmptySelection(bool flag)
		{
			Unused.Value = Call("setAllowsEmptySelection:", flag);
		}

		public bool allowsEmptySelection()
		{
			return Call("allowsEmptySelection").To<bool>();
		}

		public void setAllowsColumnSelection(bool flag)
		{
			Unused.Value = Call("setAllowsColumnSelection:", flag);
		}

		public bool allowsColumnSelection()
		{
			return Call("allowsColumnSelection").To<bool>();
		}

		public void selectAll(NSObject sender)
		{
			Unused.Value = Call("selectAll:", sender);
		}

		public void deselectAll(NSObject sender)
		{
			Unused.Value = Call("deselectAll:", sender);
		}

		public void selectColumnIndexesByExtendingSelection(NSIndexSet indexes, bool extend)
		{
			Unused.Value = Call("selectColumnIndexes:byExtendingSelection:", indexes, extend);
		}

		public void selectRowIndexesByExtendingSelection(NSIndexSet indexes, bool extend)
		{
			Unused.Value = Call("selectRowIndexes:byExtendingSelection:", indexes, extend);
		}

		public NSIndexSet selectedColumnIndexes()
		{
			return Call("selectedColumnIndexes").To<NSIndexSet>();
		}

		public NSIndexSet selectedRowIndexes()
		{
			return Call("selectedRowIndexes").To<NSIndexSet>();
		}

		public void deselectColumn(Int32 column)
		{
			Unused.Value = Call("deselectColumn:", column);
		}

		public void deselectRow(Int32 row)
		{
			Unused.Value = Call("deselectRow:", row);
		}

		public Int32 selectedColumn()
		{
			return Call("selectedColumn").To<Int32>();
		}

		public Int32 selectedRow()
		{
			return Call("selectedRow").To<Int32>();
		}

		public bool isColumnSelected(Int32 column)
		{
			return Call("isColumnSelected:", column).To<bool>();
		}

		public bool isRowSelected(Int32 row)
		{
			return Call("isRowSelected:", row).To<bool>();
		}

		public Int32 numberOfSelectedColumns()
		{
			return Call("numberOfSelectedColumns").To<Int32>();
		}

		public Int32 numberOfSelectedRows()
		{
			return Call("numberOfSelectedRows").To<Int32>();
		}

		public bool allowsTypeSelect()
		{
			return Call("allowsTypeSelect").To<bool>();
		}

		public void setAllowsTypeSelect(bool value)
		{
			Unused.Value = Call("setAllowsTypeSelect:", value);
		}

		public Int32 selectionHighlightStyle()
		{
			return Call("selectionHighlightStyle").To<Int32>();
		}

		public void setSelectionHighlightStyle(Int32 selectionHighlightStyle)
		{
			Unused.Value = Call("setSelectionHighlightStyle:", selectionHighlightStyle);
		}

		public NSRect rectOfColumn(Int32 column)
		{
			return Call("rectOfColumn:", column).To<NSRect>();
		}

		public NSRect rectOfRow(Int32 row)
		{
			return Call("rectOfRow:", row).To<NSRect>();
		}

		public NSIndexSet columnIndexesInRect(NSRect rect)
		{
			return Call("columnIndexesInRect:", rect).To<NSIndexSet>();
		}

		public NSRange rowsInRect(NSRect rect)
		{
			return Call("rowsInRect:", rect).To<NSRange>();
		}

		public Int32 columnAtPoint(NSPoint point)
		{
			return Call("columnAtPoint:", point).To<Int32>();
		}

		public Int32 rowAtPoint(NSPoint point)
		{
			return Call("rowAtPoint:", point).To<Int32>();
		}

		public NSRect frameOfCellAtColumnRow(Int32 column, Int32 row)
		{
			return Call("frameOfCellAtColumn:row:", column, row).To<NSRect>();
		}

		public NSCell preparedCellAtColumnRow(Int32 column, Int32 row)
		{
			return Call("preparedCellAtColumn:row:", column, row).To<NSCell>();
		}

		public bool textShouldBeginEditing(NSText textObject)
		{
			return Call("textShouldBeginEditing:", textObject).To<bool>();
		}

		public bool textShouldEndEditing(NSText textObject)
		{
			return Call("textShouldEndEditing:", textObject).To<bool>();
		}

		public void textDidBeginEditing(NSNotification notification)
		{
			Unused.Value = Call("textDidBeginEditing:", notification);
		}

		public void textDidEndEditing(NSNotification notification)
		{
			Unused.Value = Call("textDidEndEditing:", notification);
		}

		public void textDidChange(NSNotification notification)
		{
			Unused.Value = Call("textDidChange:", notification);
		}

		public void setAutosaveName(NSString name)
		{
			Unused.Value = Call("setAutosaveName:", name);
		}

		public NSString autosaveName()
		{
			return Call("autosaveName").To<NSString>();
		}

		public void setAutosaveTableColumns(bool save)
		{
			Unused.Value = Call("setAutosaveTableColumns:", save);
		}

		public bool autosaveTableColumns()
		{
			return Call("autosaveTableColumns").To<bool>();
		}

		public void editColumnRowWithEventSelect(Int32 column, Int32 row, NSEvent theEvent, bool select_)
		{
			Unused.Value = Call("editColumn:row:withEvent:select:", column, row, theEvent, select_);
		}

		public void drawRowClipRect(Int32 row, NSRect clipRect)
		{
			Unused.Value = Call("drawRow:clipRect:", row, clipRect);
		}

		public void highlightSelectionInClipRect(NSRect clipRect)
		{
			Unused.Value = Call("highlightSelectionInClipRect:", clipRect);
		}

		public void drawGridInClipRect(NSRect clipRect)
		{
			Unused.Value = Call("drawGridInClipRect:", clipRect);
		}

		public void drawBackgroundInClipRect(NSRect clipRect)
		{
			Unused.Value = Call("drawBackgroundInClipRect:", clipRect);
		}

		#region NSUserInterfaceValidations Methods
		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}
		#endregion

		private static Class ms_class = new Class("NSTableView");
	}

	public static class NSTableViewDelegateForNSObjectCategory
	{
		public static void tableViewWillDisplayCellForTableColumnRow(this NSObject _instance, NSTableView tableView, NSObject cell, NSTableColumn tableColumn, Int32 row)
		{
			Unused.Value = _instance.Call("tableView:willDisplayCell:forTableColumn:row:", tableView, cell, tableColumn, row);
		}

		public static bool tableViewShouldEditTableColumnRow(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn, Int32 row)
		{
			return _instance.Call("tableView:shouldEditTableColumn:row:", tableView, tableColumn, row).To<bool>();
		}

		public static bool selectionShouldChangeInTableView(this NSObject _instance, NSTableView tableView)
		{
			return _instance.Call("selectionShouldChangeInTableView:", tableView).To<bool>();
		}

		public static bool tableViewShouldSelectRow(this NSObject _instance, NSTableView tableView, Int32 row)
		{
			return _instance.Call("tableView:shouldSelectRow:", tableView, row).To<bool>();
		}

		public static NSIndexSet tableViewSelectionIndexesForProposedSelection(this NSObject _instance, NSTableView tableView, NSIndexSet proposedSelectionIndexes)
		{
			return _instance.Call("tableView:selectionIndexesForProposedSelection:", tableView, proposedSelectionIndexes).To<NSIndexSet>();
		}

		public static bool tableViewShouldSelectTableColumn(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn)
		{
			return _instance.Call("tableView:shouldSelectTableColumn:", tableView, tableColumn).To<bool>();
		}

		public static void tableViewMouseDownInHeaderOfTableColumn(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn)
		{
			Unused.Value = _instance.Call("tableView:mouseDownInHeaderOfTableColumn:", tableView, tableColumn);
		}

		public static void tableViewDidClickTableColumn(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn)
		{
			Unused.Value = _instance.Call("tableView:didClickTableColumn:", tableView, tableColumn);
		}

		public static void tableViewDidDragTableColumn(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn)
		{
			Unused.Value = _instance.Call("tableView:didDragTableColumn:", tableView, tableColumn);
		}

		public static NSString tableViewToolTipForCellRectTableColumnRowMouseLocation(this NSObject _instance, NSTableView tableView, NSCell cell, IntPtr rect, NSTableColumn tableColumn, Int32 row, NSPoint mouseLocation)
		{
			return _instance.Call("tableView:toolTipForCell:rect:tableColumn:row:mouseLocation:", tableView, cell, rect, tableColumn, row, mouseLocation).To<NSString>();
		}

		public static float tableViewHeightOfRow(this NSObject _instance, NSTableView tableView, Int32 row)
		{
			return _instance.Call("tableView:heightOfRow:", tableView, row).To<float>();
		}

		public static NSString tableViewTypeSelectStringForTableColumnRow(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn, Int32 row)
		{
			return _instance.Call("tableView:typeSelectStringForTableColumn:row:", tableView, tableColumn, row).To<NSString>();
		}

		public static Int32 tableViewNextTypeSelectMatchFromRowToRowForString(this NSObject _instance, NSTableView tableView, Int32 startRow, Int32 endRow, NSString searchString)
		{
			return _instance.Call("tableView:nextTypeSelectMatchFromRow:toRow:forString:", tableView, startRow, endRow, searchString).To<Int32>();
		}

		public static bool tableViewShouldTypeSelectForEventWithCurrentSearchString(this NSObject _instance, NSTableView tableView, NSEvent event_, NSString searchString)
		{
			return _instance.Call("tableView:shouldTypeSelectForEvent:withCurrentSearchString:", tableView, event_, searchString).To<bool>();
		}

		public static bool tableViewShouldShowCellExpansionForTableColumnRow(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn, Int32 row)
		{
			return _instance.Call("tableView:shouldShowCellExpansionForTableColumn:row:", tableView, tableColumn, row).To<bool>();
		}

		public static bool tableViewShouldTrackCellForTableColumnRow(this NSObject _instance, NSTableView tableView, NSCell cell, NSTableColumn tableColumn, Int32 row)
		{
			return _instance.Call("tableView:shouldTrackCell:forTableColumn:row:", tableView, cell, tableColumn, row).To<bool>();
		}

		public static NSCell tableViewDataCellForTableColumnRow(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn, Int32 row)
		{
			return _instance.Call("tableView:dataCellForTableColumn:row:", tableView, tableColumn, row).To<NSCell>();
		}

		public static bool tableViewIsGroupRow(this NSObject _instance, NSTableView tableView, Int32 row)
		{
			return _instance.Call("tableView:isGroupRow:", tableView, row).To<bool>();
		}
	}

	public static class NSTableViewNotificationsForNSObjectCategory
	{
		public static void tableViewSelectionDidChange(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("tableViewSelectionDidChange:", notification);
		}

		public static void tableViewColumnDidMove(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("tableViewColumnDidMove:", notification);
		}

		public static void tableViewColumnDidResize(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("tableViewColumnDidResize:", notification);
		}

		public static void tableViewSelectionIsChanging(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("tableViewSelectionIsChanging:", notification);
		}
	}

	public static class NSTableDataSourceForNSObjectCategory
	{
		public static Int32 numberOfRowsInTableView(this NSObject _instance, NSTableView tableView)
		{
			return _instance.Call("numberOfRowsInTableView:", tableView).To<Int32>();
		}

		public static NSObject tableViewObjectValueForTableColumnRow(this NSObject _instance, NSTableView tableView, NSTableColumn tableColumn, Int32 row)
		{
			return _instance.Call("tableView:objectValueForTableColumn:row:", tableView, tableColumn, row).To<NSObject>();
		}

		public static void tableViewSetObjectValueForTableColumnRow(this NSObject _instance, NSTableView tableView, NSObject object_, NSTableColumn tableColumn, Int32 row)
		{
			Unused.Value = _instance.Call("tableView:setObjectValue:forTableColumn:row:", tableView, object_, tableColumn, row);
		}

		public static void tableViewSortDescriptorsDidChange(this NSObject _instance, NSTableView tableView, NSArray oldDescriptors)
		{
			Unused.Value = _instance.Call("tableView:sortDescriptorsDidChange:", tableView, oldDescriptors);
		}

		public static bool tableViewWriteRowsWithIndexesToPasteboard(this NSObject _instance, NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
		{
			return _instance.Call("tableView:writeRowsWithIndexes:toPasteboard:", tableView, rowIndexes, pboard).To<bool>();
		}

		public static UInt32 tableViewValidateDropProposedRowProposedDropOperation(this NSObject _instance, NSTableView tableView, NSObject info, Int32 row, UInt32 dropOperation)
		{
			return _instance.Call("tableView:validateDrop:proposedRow:proposedDropOperation:", tableView, info, row, dropOperation).To<UInt32>();
		}

		public static bool tableViewAcceptDropRowDropOperation(this NSObject _instance, NSTableView tableView, NSObject info, Int32 row, UInt32 dropOperation)
		{
			return _instance.Call("tableView:acceptDrop:row:dropOperation:", tableView, info, row, dropOperation).To<bool>();
		}

		public static NSArray tableViewNamesOfPromisedFilesDroppedAtDestinationForDraggedRowsWithIndexes(this NSObject _instance, NSTableView tableView, NSURL dropDestination, NSIndexSet indexSet)
		{
			return _instance.Call("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:", tableView, dropDestination, indexSet).To<NSArray>();
		}

		public static bool tableViewWriteRowsToPasteboard(this NSObject _instance, NSTableView tableView, NSArray rows, NSPasteboard pboard)
		{
			return _instance.Call("tableView:writeRows:toPasteboard:", tableView, rows, pboard).To<bool>();
		}
	}

	public static class NSDeprecatedForNSTableViewCategory
	{
		public static void setDrawsGrid(this NSTableView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setDrawsGrid:", flag);
		}

		public static bool drawsGrid(this NSTableView _instance)
		{
			return _instance.Call("drawsGrid").To<bool>();
		}

		public static void selectColumnByExtendingSelection(this NSTableView _instance, Int32 column, bool extend)
		{
			Unused.Value = _instance.Call("selectColumn:byExtendingSelection:", column, extend);
		}

		public static void selectRowByExtendingSelection(this NSTableView _instance, Int32 row, bool extend)
		{
			Unused.Value = _instance.Call("selectRow:byExtendingSelection:", row, extend);
		}

		public static NSEnumerator selectedColumnEnumerator(this NSTableView _instance)
		{
			return _instance.Call("selectedColumnEnumerator").To<NSEnumerator>();
		}

		public static NSEnumerator selectedRowEnumerator(this NSTableView _instance)
		{
			return _instance.Call("selectedRowEnumerator").To<NSEnumerator>();
		}

		public static NSImage dragImageForRowsEventDragImageOffset(this NSTableView _instance, NSArray dragRows, NSEvent dragEvent, IntPtr dragImageOffset)
		{
			return _instance.Call("dragImageForRows:event:dragImageOffset:", dragRows, dragEvent, dragImageOffset).To<NSImage>();
		}

		public static void setAutoresizesAllColumnsToFit(this NSTableView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAutoresizesAllColumnsToFit:", flag);
		}

		public static bool autoresizesAllColumnsToFit(this NSTableView _instance)
		{
			return _instance.Call("autoresizesAllColumnsToFit").To<bool>();
		}

		public static NSRange columnsInRect(this NSTableView _instance, NSRect rect)
		{
			return _instance.Call("columnsInRect:", rect).To<NSRange>();
		}
	}
}
