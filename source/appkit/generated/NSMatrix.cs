// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSMatrix.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSRadioModeMatrix = 0;
		public const int NSHighlightModeMatrix = 1;
		public const int NSListModeMatrix = 2;
		public const int NSTrackModeMatrix = 3;
	}

	[Register]
	public partial class NSMatrix : NSControl
	{
		public NSMatrix() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMatrix(IntPtr instance) : base(instance)
		{
		}

		public NSMatrix(Untyped instance) : base(instance)
		{
		}

		public static new NSMatrix alloc()
		{
			return new NSMatrix(ms_class.Call("alloc"));
		}

		public new NSMatrix retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping initWithFrame: (it's declared in a base class)

		public NSObject initWithFrameModePrototypeNumberOfRowsNumberOfColumns(NSRect frameRect, UInt32 aMode, NSCell aCell, Int32 rowsHigh, Int32 colsWide)
		{
			return Call("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:", frameRect, aMode, aCell, rowsHigh, colsWide).To<NSObject>();
		}

		public NSObject initWithFrameModeCellClassNumberOfRowsNumberOfColumns(NSRect frameRect, UInt32 aMode, Class factoryId, Int32 rowsHigh, Int32 colsWide)
		{
			return Call("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:", frameRect, aMode, factoryId, rowsHigh, colsWide).To<NSObject>();
		}

		// skipping setCellClass: (it's declared in a base class)

		// skipping cellClass (it's declared in a base class)

		public NSObject prototype()
		{
			return Call("prototype").To<NSObject>();
		}

		public void setPrototype(NSCell aCell)
		{
			Unused.Value = Call("setPrototype:", aCell);
		}

		public NSCell makeCellAtRowColumn(Int32 row, Int32 col)
		{
			return Call("makeCellAtRow:column:", row, col).To<NSCell>();
		}

		public UInt32 mode()
		{
			return Call("mode").To<UInt32>();
		}

		public void setMode(UInt32 aMode)
		{
			Unused.Value = Call("setMode:", aMode);
		}

		public void setAllowsEmptySelection(bool flag)
		{
			Unused.Value = Call("setAllowsEmptySelection:", flag);
		}

		public bool allowsEmptySelection()
		{
			return Call("allowsEmptySelection").To<bool>();
		}

		public void sendActionToForAllCells(Selector aSelector, NSObject anObject, bool flag)
		{
			Unused.Value = Call("sendAction:to:forAllCells:", aSelector, anObject, flag);
		}

		public NSArray cells()
		{
			return Call("cells").To<NSArray>();
		}

		public void sortUsingSelector(Selector comparator)
		{
			Unused.Value = Call("sortUsingSelector:", comparator);
		}

		// skipping sortUsingFunction:context: because it has a function pointer

		// skipping selectedCell (it's declared in a base class)

		public NSArray selectedCells()
		{
			return Call("selectedCells").To<NSArray>();
		}

		public Int32 selectedRow()
		{
			return Call("selectedRow").To<Int32>();
		}

		public Int32 selectedColumn()
		{
			return Call("selectedColumn").To<Int32>();
		}

		public void setSelectionByRect(bool flag)
		{
			Unused.Value = Call("setSelectionByRect:", flag);
		}

		public bool isSelectionByRect()
		{
			return Call("isSelectionByRect").To<bool>();
		}

		public void setSelectionFromToAnchorHighlight(Int32 startPos, Int32 endPos, Int32 anchorPos, bool lit)
		{
			Unused.Value = Call("setSelectionFrom:to:anchor:highlight:", startPos, endPos, anchorPos, lit);
		}

		public void deselectSelectedCell()
		{
			Unused.Value = Call("deselectSelectedCell");
		}

		public void deselectAllCells()
		{
			Unused.Value = Call("deselectAllCells");
		}

		public void selectCellAtRowColumn(Int32 row, Int32 col)
		{
			Unused.Value = Call("selectCellAtRow:column:", row, col);
		}

		public void selectAll(NSObject sender)
		{
			Unused.Value = Call("selectAll:", sender);
		}

		public bool selectCellWithTag(Int32 anInt)
		{
			return Call("selectCellWithTag:", anInt).To<bool>();
		}

		public NSSize cellSize()
		{
			return Call("cellSize").To<NSSize>();
		}

		public void setCellSize(NSSize aSize)
		{
			Unused.Value = Call("setCellSize:", aSize);
		}

		public NSSize intercellSpacing()
		{
			return Call("intercellSpacing").To<NSSize>();
		}

		public void setIntercellSpacing(NSSize aSize)
		{
			Unused.Value = Call("setIntercellSpacing:", aSize);
		}

		public void setScrollable(bool flag)
		{
			Unused.Value = Call("setScrollable:", flag);
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setCellBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setCellBackgroundColor:", color);
		}

		public NSColor cellBackgroundColor()
		{
			return Call("cellBackgroundColor").To<NSColor>();
		}

		public void setDrawsCellBackground(bool flag)
		{
			Unused.Value = Call("setDrawsCellBackground:", flag);
		}

		public bool drawsCellBackground()
		{
			return Call("drawsCellBackground").To<bool>();
		}

		public void setDrawsBackground(bool flag)
		{
			Unused.Value = Call("setDrawsBackground:", flag);
		}

		public bool drawsBackground()
		{
			return Call("drawsBackground").To<bool>();
		}

		public void setStateAtRowColumn(Int32 value, Int32 row, Int32 col)
		{
			Unused.Value = Call("setState:atRow:column:", value, row, col);
		}

		public void getNumberOfRowsColumns(IntPtr rowCount, IntPtr colCount)
		{
			Unused.Value = Call("getNumberOfRows:columns:", rowCount, colCount);
		}

		public Int32 numberOfRows()
		{
			return Call("numberOfRows").To<Int32>();
		}

		public Int32 numberOfColumns()
		{
			return Call("numberOfColumns").To<Int32>();
		}

		public NSObject cellAtRowColumn(Int32 row, Int32 col)
		{
			return Call("cellAtRow:column:", row, col).To<NSObject>();
		}

		public NSRect cellFrameAtRowColumn(Int32 row, Int32 col)
		{
			return Call("cellFrameAtRow:column:", row, col).To<NSRect>();
		}

		public bool getRowColumnOfCell(IntPtr row, IntPtr col, NSCell aCell)
		{
			return Call("getRow:column:ofCell:", row, col, aCell).To<bool>();
		}

		public bool getRowColumnForPoint(IntPtr row, IntPtr col, NSPoint aPoint)
		{
			return Call("getRow:column:forPoint:", row, col, aPoint).To<bool>();
		}

		public void renewRowsColumns(Int32 newRows, Int32 newCols)
		{
			Unused.Value = Call("renewRows:columns:", newRows, newCols);
		}

		public void putCellAtRowColumn(NSCell newCell, Int32 row, Int32 col)
		{
			Unused.Value = Call("putCell:atRow:column:", newCell, row, col);
		}

		public void addRow()
		{
			Unused.Value = Call("addRow");
		}

		public void addRowWithCells(NSArray newCells)
		{
			Unused.Value = Call("addRowWithCells:", newCells);
		}

		public void insertRow(Int32 row)
		{
			Unused.Value = Call("insertRow:", row);
		}

		public void insertRowWithCells(Int32 row, NSArray newCells)
		{
			Unused.Value = Call("insertRow:withCells:", row, newCells);
		}

		public void removeRow(Int32 row)
		{
			Unused.Value = Call("removeRow:", row);
		}

		public void addColumn()
		{
			Unused.Value = Call("addColumn");
		}

		public void addColumnWithCells(NSArray newCells)
		{
			Unused.Value = Call("addColumnWithCells:", newCells);
		}

		public void insertColumn(Int32 column)
		{
			Unused.Value = Call("insertColumn:", column);
		}

		public void insertColumnWithCells(Int32 column, NSArray newCells)
		{
			Unused.Value = Call("insertColumn:withCells:", column, newCells);
		}

		public void removeColumn(Int32 col)
		{
			Unused.Value = Call("removeColumn:", col);
		}

		public NSObject cellWithTag(Int32 anInt)
		{
			return Call("cellWithTag:", anInt).To<NSObject>();
		}

		public Selector doubleAction()
		{
			return Call("doubleAction").To<Selector>();
		}

		public void setDoubleAction(Selector aSelector)
		{
			Unused.Value = Call("setDoubleAction:", aSelector);
		}

		public void setAutosizesCells(bool flag)
		{
			Unused.Value = Call("setAutosizesCells:", flag);
		}

		public bool autosizesCells()
		{
			return Call("autosizesCells").To<bool>();
		}

		public void sizeToCells()
		{
			Unused.Value = Call("sizeToCells");
		}

		public void setValidateSize(bool flag)
		{
			Unused.Value = Call("setValidateSize:", flag);
		}

		public void drawCellAtRowColumn(Int32 row, Int32 col)
		{
			Unused.Value = Call("drawCellAtRow:column:", row, col);
		}

		public void highlightCellAtRowColumn(bool flag, Int32 row, Int32 col)
		{
			Unused.Value = Call("highlightCell:atRow:column:", flag, row, col);
		}

		public void setAutoscroll(bool flag)
		{
			Unused.Value = Call("setAutoscroll:", flag);
		}

		public bool isAutoscroll()
		{
			return Call("isAutoscroll").To<bool>();
		}

		public void scrollCellToVisibleAtRowColumn(Int32 row, Int32 col)
		{
			Unused.Value = Call("scrollCellToVisibleAtRow:column:", row, col);
		}

		public Int32 mouseDownFlags()
		{
			return Call("mouseDownFlags").To<Int32>();
		}

		// skipping mouseDown: (it's declared in a base class)

		// skipping performKeyEquivalent: (it's declared in a base class)

		public bool sendAction()
		{
			return Call("sendAction").To<bool>();
		}

		public void sendDoubleAction()
		{
			Unused.Value = Call("sendDoubleAction");
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
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

		public void selectText(NSObject sender)
		{
			Unused.Value = Call("selectText:", sender);
		}

		public NSObject selectTextAtRowColumn(Int32 row, Int32 col)
		{
			return Call("selectTextAtRow:column:", row, col).To<NSObject>();
		}

		// skipping acceptsFirstMouse: (it's declared in a base class)

		// skipping resetCursorRects (it's declared in a base class)

		public void setToolTipForCell(NSString toolTipString, NSCell cell)
		{
			Unused.Value = Call("setToolTip:forCell:", toolTipString, cell);
		}

		public NSString toolTipForCell(NSCell cell)
		{
			return Call("toolTipForCell:", cell).To<NSString>();
		}

		#region NSUserInterfaceValidations Methods
		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}
		#endregion

		private static Class ms_class = new Class("NSMatrix");
	}

	public static class NSKeyboardUIForNSMatrixCategory
	{
		public static void setTabKeyTraversesCells(this NSMatrix _instance, bool flag)
		{
			Unused.Value = _instance.Call("setTabKeyTraversesCells:", flag);
		}

		public static bool tabKeyTraversesCells(this NSMatrix _instance)
		{
			return _instance.Call("tabKeyTraversesCells").To<bool>();
		}

		public static void setKeyCell(this NSMatrix _instance, NSCell keyCell)
		{
			Unused.Value = _instance.Call("setKeyCell:", keyCell);
		}

		public static NSObject keyCell(this NSMatrix _instance)
		{
			return _instance.Call("keyCell").To<NSObject>();
		}
	}
}
