// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSBrowser.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSBrowserNoColumnResizing = 0;
		public const int NSBrowserAutoColumnResizing = 1;
		public const int NSBrowserUserColumnResizing = 2;
	}

	public partial class Enums
	{
		public const int NSBrowserDropOn = 0;
		public const int NSBrowserDropAbove = 1;
	}

	[Register]
	public partial class NSBrowser : NSControl
	{
		public NSBrowser() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSBrowser(IntPtr instance) : base(instance)
		{
		}

		public NSBrowser(Untyped instance) : base(instance)
		{
		}

		public static new NSBrowser alloc()
		{
			return new NSBrowser(ms_class.Call("alloc"));
		}

		public new NSBrowser retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping cellClass (it's declared in a base class)

		public void loadColumnZero()
		{
			Unused.Value = Call("loadColumnZero");
		}

		public bool isLoaded()
		{
			return Call("isLoaded").To<bool>();
		}

		public void setDoubleAction(Selector aSelector)
		{
			Unused.Value = Call("setDoubleAction:", aSelector);
		}

		public Selector doubleAction()
		{
			return Call("doubleAction").To<Selector>();
		}

		public void setMatrixClass(Class factoryId)
		{
			Unused.Value = Call("setMatrixClass:", factoryId);
		}

		public Class matrixClass()
		{
			return Call("matrixClass").To<Class>();
		}

		// skipping setCellClass: (it's declared in a base class)

		public void setCellPrototype(NSCell aCell)
		{
			Unused.Value = Call("setCellPrototype:", aCell);
		}

		public NSObject cellPrototype()
		{
			return Call("cellPrototype").To<NSObject>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setReusesColumns(bool flag)
		{
			Unused.Value = Call("setReusesColumns:", flag);
		}

		public bool reusesColumns()
		{
			return Call("reusesColumns").To<bool>();
		}

		public void setHasHorizontalScroller(bool flag)
		{
			Unused.Value = Call("setHasHorizontalScroller:", flag);
		}

		public bool hasHorizontalScroller()
		{
			return Call("hasHorizontalScroller").To<bool>();
		}

		public void setSeparatesColumns(bool flag)
		{
			Unused.Value = Call("setSeparatesColumns:", flag);
		}

		public bool separatesColumns()
		{
			return Call("separatesColumns").To<bool>();
		}

		public void setTitled(bool flag)
		{
			Unused.Value = Call("setTitled:", flag);
		}

		public bool isTitled()
		{
			return Call("isTitled").To<bool>();
		}

		public void setMinColumnWidth(float columnWidth)
		{
			Unused.Value = Call("setMinColumnWidth:", columnWidth);
		}

		public float minColumnWidth()
		{
			return Call("minColumnWidth").To<float>();
		}

		public void setMaxVisibleColumns(Int32 columnCount)
		{
			Unused.Value = Call("setMaxVisibleColumns:", columnCount);
		}

		public Int32 maxVisibleColumns()
		{
			return Call("maxVisibleColumns").To<Int32>();
		}

		public void setAllowsMultipleSelection(bool flag)
		{
			Unused.Value = Call("setAllowsMultipleSelection:", flag);
		}

		public bool allowsMultipleSelection()
		{
			return Call("allowsMultipleSelection").To<bool>();
		}

		public void setAllowsBranchSelection(bool flag)
		{
			Unused.Value = Call("setAllowsBranchSelection:", flag);
		}

		public bool allowsBranchSelection()
		{
			return Call("allowsBranchSelection").To<bool>();
		}

		public void setAllowsEmptySelection(bool flag)
		{
			Unused.Value = Call("setAllowsEmptySelection:", flag);
		}

		public bool allowsEmptySelection()
		{
			return Call("allowsEmptySelection").To<bool>();
		}

		public void setTakesTitleFromPreviousColumn(bool flag)
		{
			Unused.Value = Call("setTakesTitleFromPreviousColumn:", flag);
		}

		public bool takesTitleFromPreviousColumn()
		{
			return Call("takesTitleFromPreviousColumn").To<bool>();
		}

		public void setAcceptsArrowKeys(bool flag)
		{
			Unused.Value = Call("setAcceptsArrowKeys:", flag);
		}

		public bool acceptsArrowKeys()
		{
			return Call("acceptsArrowKeys").To<bool>();
		}

		public void setSendsActionOnArrowKeys(bool flag)
		{
			Unused.Value = Call("setSendsActionOnArrowKeys:", flag);
		}

		public bool sendsActionOnArrowKeys()
		{
			return Call("sendsActionOnArrowKeys").To<bool>();
		}

		public void setTitleOfColumn(NSString aString, Int32 column)
		{
			Unused.Value = Call("setTitle:ofColumn:", aString, column);
		}

		public NSString titleOfColumn(Int32 column)
		{
			return Call("titleOfColumn:", column).To<NSString>();
		}

		public void setPathSeparator(NSString newString)
		{
			Unused.Value = Call("setPathSeparator:", newString);
		}

		public NSString pathSeparator()
		{
			return Call("pathSeparator").To<NSString>();
		}

		public bool setPath(NSString path)
		{
			return Call("setPath:", path).To<bool>();
		}

		public NSString path()
		{
			return Call("path").To<NSString>();
		}

		public NSString pathToColumn(Int32 column)
		{
			return Call("pathToColumn:", column).To<NSString>();
		}

		public Int32 selectedColumn()
		{
			return Call("selectedColumn").To<Int32>();
		}

		// skipping selectedCell (it's declared in a base class)

		public NSObject selectedCellInColumn(Int32 column)
		{
			return Call("selectedCellInColumn:", column).To<NSObject>();
		}

		public NSArray selectedCells()
		{
			return Call("selectedCells").To<NSArray>();
		}

		public void selectRowInColumn(Int32 row, Int32 column)
		{
			Unused.Value = Call("selectRow:inColumn:", row, column);
		}

		public Int32 selectedRowInColumn(Int32 column)
		{
			return Call("selectedRowInColumn:", column).To<Int32>();
		}

		public void selectRowIndexesInColumn(NSIndexSet indexes, Int32 column)
		{
			Unused.Value = Call("selectRowIndexes:inColumn:", indexes, column);
		}

		public NSIndexSet selectedRowIndexesInColumn(Int32 column)
		{
			return Call("selectedRowIndexesInColumn:", column).To<NSIndexSet>();
		}

		public void reloadColumn(Int32 column)
		{
			Unused.Value = Call("reloadColumn:", column);
		}

		public void validateVisibleColumns()
		{
			Unused.Value = Call("validateVisibleColumns");
		}

		public void scrollColumnsRightBy(Int32 shiftAmount)
		{
			Unused.Value = Call("scrollColumnsRightBy:", shiftAmount);
		}

		public void scrollColumnsLeftBy(Int32 shiftAmount)
		{
			Unused.Value = Call("scrollColumnsLeftBy:", shiftAmount);
		}

		public void scrollColumnToVisible(Int32 column)
		{
			Unused.Value = Call("scrollColumnToVisible:", column);
		}

		public void setLastColumn(Int32 column)
		{
			Unused.Value = Call("setLastColumn:", column);
		}

		public Int32 lastColumn()
		{
			return Call("lastColumn").To<Int32>();
		}

		public void addColumn()
		{
			Unused.Value = Call("addColumn");
		}

		public Int32 numberOfVisibleColumns()
		{
			return Call("numberOfVisibleColumns").To<Int32>();
		}

		public Int32 firstVisibleColumn()
		{
			return Call("firstVisibleColumn").To<Int32>();
		}

		public Int32 lastVisibleColumn()
		{
			return Call("lastVisibleColumn").To<Int32>();
		}

		public Int32 columnOfMatrix(NSMatrix matrix)
		{
			return Call("columnOfMatrix:", matrix).To<Int32>();
		}

		public NSMatrix matrixInColumn(Int32 column)
		{
			return Call("matrixInColumn:", column).To<NSMatrix>();
		}

		public NSObject loadedCellAtRowColumn(Int32 row, Int32 col)
		{
			return Call("loadedCellAtRow:column:", row, col).To<NSObject>();
		}

		public void selectAll(NSObject sender)
		{
			Unused.Value = Call("selectAll:", sender);
		}

		public void tile()
		{
			Unused.Value = Call("tile");
		}

		public void doClick(NSObject sender)
		{
			Unused.Value = Call("doClick:", sender);
		}

		public void doDoubleClick(NSObject sender)
		{
			Unused.Value = Call("doDoubleClick:", sender);
		}

		public bool sendAction()
		{
			return Call("sendAction").To<bool>();
		}

		public NSRect titleFrameOfColumn(Int32 column)
		{
			return Call("titleFrameOfColumn:", column).To<NSRect>();
		}

		public void drawTitleOfColumnInRect(Int32 column, NSRect aRect)
		{
			Unused.Value = Call("drawTitleOfColumn:inRect:", column, aRect);
		}

		public float titleHeight()
		{
			return Call("titleHeight").To<float>();
		}

		public NSRect frameOfColumn(Int32 column)
		{
			return Call("frameOfColumn:", column).To<NSRect>();
		}

		public NSRect frameOfInsideOfColumn(Int32 column)
		{
			return Call("frameOfInsideOfColumn:", column).To<NSRect>();
		}

		public float columnWidthForColumnContentWidth(float columnContentWidth)
		{
			return Call("columnWidthForColumnContentWidth:", columnContentWidth).To<float>();
		}

		public float columnContentWidthForColumnWidth(float columnWidth)
		{
			return Call("columnContentWidthForColumnWidth:", columnWidth).To<float>();
		}

		public void setColumnResizingType(UInt32 columnResizingType)
		{
			Unused.Value = Call("setColumnResizingType:", columnResizingType);
		}

		public UInt32 columnResizingType()
		{
			return Call("columnResizingType").To<UInt32>();
		}

		public void setPrefersAllColumnUserResizing(bool prefersAllColumnResizing)
		{
			Unused.Value = Call("setPrefersAllColumnUserResizing:", prefersAllColumnResizing);
		}

		public bool prefersAllColumnUserResizing()
		{
			return Call("prefersAllColumnUserResizing").To<bool>();
		}

		public void setWidthOfColumn(float columnWidth, Int32 columnIndex)
		{
			Unused.Value = Call("setWidth:ofColumn:", columnWidth, columnIndex);
		}

		public float widthOfColumn(Int32 column)
		{
			return Call("widthOfColumn:", column).To<float>();
		}

		public void setColumnsAutosaveName(NSString name)
		{
			Unused.Value = Call("setColumnsAutosaveName:", name);
		}

		public NSString columnsAutosaveName()
		{
			return Call("columnsAutosaveName").To<NSString>();
		}

		public static void removeSavedColumnsWithAutosaveName(NSString name)
		{
			Unused.Value = ms_class.Call("removeSavedColumnsWithAutosaveName:", name);
		}

		public bool canDragRowsWithIndexesInColumnWithEvent(NSIndexSet rowIndexes, Int32 column, NSEvent event_)
		{
			return Call("canDragRowsWithIndexes:inColumn:withEvent:", rowIndexes, column, event_).To<bool>();
		}

		public NSImage draggingImageForRowsWithIndexesInColumnWithEventOffset(NSIndexSet rowIndexes, Int32 column, NSEvent event_, IntPtr dragImageOffset)
		{
			return Call("draggingImageForRowsWithIndexes:inColumn:withEvent:offset:", rowIndexes, column, event_, dragImageOffset).To<NSImage>();
		}

		public void setDraggingSourceOperationMaskForLocal(UInt32 mask, bool isLocal)
		{
			Unused.Value = Call("setDraggingSourceOperationMask:forLocal:", mask, isLocal);
		}

		public bool allowsTypeSelect()
		{
			return Call("allowsTypeSelect").To<bool>();
		}

		public void setAllowsTypeSelect(bool value)
		{
			Unused.Value = Call("setAllowsTypeSelect:", value);
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void displayColumn(Int32 column)
		{
			Unused.Value = Call("displayColumn:", column);
		}

		public void displayAllColumns()
		{
			Unused.Value = Call("displayAllColumns");
		}

		public void scrollViaScroller(NSScroller sender)
		{
			Unused.Value = Call("scrollViaScroller:", sender);
		}

		public void updateScroller()
		{
			Unused.Value = Call("updateScroller");
		}

		private static Class ms_class = new Class("NSBrowser");
	}

	public static class NSBrowserDelegateForNSObjectCategory
	{
		public static Int32 browserNumberOfRowsInColumn(this NSObject _instance, NSBrowser sender, Int32 column)
		{
			return _instance.Call("browser:numberOfRowsInColumn:", sender, column).To<Int32>();
		}

		public static void browserCreateRowsForColumnInMatrix(this NSObject _instance, NSBrowser sender, Int32 column, NSMatrix matrix)
		{
			Unused.Value = _instance.Call("browser:createRowsForColumn:inMatrix:", sender, column, matrix);
		}

		public static void browserWillDisplayCellAtRowColumn(this NSObject _instance, NSBrowser sender, NSObject cell, Int32 row, Int32 column)
		{
			Unused.Value = _instance.Call("browser:willDisplayCell:atRow:column:", sender, cell, row, column);
		}

		public static NSString browserTitleOfColumn(this NSObject _instance, NSBrowser sender, Int32 column)
		{
			return _instance.Call("browser:titleOfColumn:", sender, column).To<NSString>();
		}

		public static bool browserSelectCellWithStringInColumn(this NSObject _instance, NSBrowser sender, NSString title, Int32 column)
		{
			return _instance.Call("browser:selectCellWithString:inColumn:", sender, title, column).To<bool>();
		}

		public static bool browserSelectRowInColumn(this NSObject _instance, NSBrowser sender, Int32 row, Int32 column)
		{
			return _instance.Call("browser:selectRow:inColumn:", sender, row, column).To<bool>();
		}

		public static bool browserIsColumnValid(this NSObject _instance, NSBrowser sender, Int32 column)
		{
			return _instance.Call("browser:isColumnValid:", sender, column).To<bool>();
		}

		public static void browserWillScroll(this NSObject _instance, NSBrowser sender)
		{
			Unused.Value = _instance.Call("browserWillScroll:", sender);
		}

		public static void browserDidScroll(this NSObject _instance, NSBrowser sender)
		{
			Unused.Value = _instance.Call("browserDidScroll:", sender);
		}

		public static float browserShouldSizeColumnForUserResizeToWidth(this NSObject _instance, NSBrowser browser, Int32 columnIndex, bool forUserResize, float suggestedWidth)
		{
			return _instance.Call("browser:shouldSizeColumn:forUserResize:toWidth:", browser, columnIndex, forUserResize, suggestedWidth).To<float>();
		}

		public static float browserSizeToFitWidthOfColumn(this NSObject _instance, NSBrowser browser, Int32 columnIndex)
		{
			return _instance.Call("browser:sizeToFitWidthOfColumn:", browser, columnIndex).To<float>();
		}

		public static void browserColumnConfigurationDidChange(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("browserColumnConfigurationDidChange:", notification);
		}

		public static bool browserShouldShowCellExpansionForRowColumn(this NSObject _instance, NSBrowser browser, Int32 row, Int32 column)
		{
			return _instance.Call("browser:shouldShowCellExpansionForRow:column:", browser, row, column).To<bool>();
		}

		public static bool browserWriteRowsWithIndexesInColumnToPasteboard(this NSObject _instance, NSBrowser browser, NSIndexSet rowIndexes, Int32 column, NSPasteboard pasteboard)
		{
			return _instance.Call("browser:writeRowsWithIndexes:inColumn:toPasteboard:", browser, rowIndexes, column, pasteboard).To<bool>();
		}

		public static NSArray browserNamesOfPromisedFilesDroppedAtDestinationForDraggedRowsWithIndexesInColumn(this NSObject _instance, NSBrowser browser, NSURL dropDestination, NSIndexSet rowIndexes, Int32 column)
		{
			return _instance.Call("browser:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:inColumn:", browser, dropDestination, rowIndexes, column).To<NSArray>();
		}

		public static bool browserCanDragRowsWithIndexesInColumnWithEvent(this NSObject _instance, NSBrowser browser, NSIndexSet rowIndexes, Int32 column, NSEvent event_)
		{
			return _instance.Call("browser:canDragRowsWithIndexes:inColumn:withEvent:", browser, rowIndexes, column, event_).To<bool>();
		}

		public static NSImage browserDraggingImageForRowsWithIndexesInColumnWithEventOffset(this NSObject _instance, NSBrowser browser, NSIndexSet rowIndexes, Int32 column, NSEvent event_, IntPtr dragImageOffset)
		{
			return _instance.Call("browser:draggingImageForRowsWithIndexes:inColumn:withEvent:offset:", browser, rowIndexes, column, event_, dragImageOffset).To<NSImage>();
		}

		public static UInt32 browserValidateDropProposedRowColumnDropOperation(this NSObject _instance, NSBrowser browser, NSObject info, IntPtr row, IntPtr column, IntPtr dropOperation)
		{
			return _instance.Call("browser:validateDrop:proposedRow:column:dropOperation:", browser, info, row, column, dropOperation).To<UInt32>();
		}

		public static bool browserAcceptDropAtRowColumnDropOperation(this NSObject _instance, NSBrowser browser, NSObject info, Int32 row, Int32 column, UInt32 dropOperation)
		{
			return _instance.Call("browser:acceptDrop:atRow:column:dropOperation:", browser, info, row, column, dropOperation).To<bool>();
		}

		public static NSString browserTypeSelectStringForRowInColumn(this NSObject _instance, NSBrowser browser, Int32 row, Int32 column)
		{
			return _instance.Call("browser:typeSelectStringForRow:inColumn:", browser, row, column).To<NSString>();
		}

		public static bool browserShouldTypeSelectForEventWithCurrentSearchString(this NSObject _instance, NSBrowser browser, NSEvent event_, NSString searchString)
		{
			return _instance.Call("browser:shouldTypeSelectForEvent:withCurrentSearchString:", browser, event_, searchString).To<bool>();
		}

		public static Int32 browserNextTypeSelectMatchFromRowToRowInColumnForString(this NSObject _instance, NSBrowser browser, Int32 startRow, Int32 endRow, Int32 column, NSString searchString)
		{
			return _instance.Call("browser:nextTypeSelectMatchFromRow:toRow:inColumn:forString:", browser, startRow, endRow, column, searchString).To<Int32>();
		}
	}
}
