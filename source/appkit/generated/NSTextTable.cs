// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextTable.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTextBlockAbsoluteValueType = 0;
		public const int NSTextBlockPercentageValueType = 1;
	}

	public partial class Enums
	{
		public const int NSTextBlockWidth = 0;
		public const int NSTextBlockMinimumWidth = 1;
		public const int NSTextBlockMaximumWidth = 2;
		public const int NSTextBlockHeight = 4;
		public const int NSTextBlockMinimumHeight = 5;
		public const int NSTextBlockMaximumHeight = 6;
	}

	public partial class Enums
	{
		public const int NSTextBlockPadding = -1;
		public const int NSTextBlockBorder = 0;
		public const int NSTextBlockMargin = 1;
	}

	public partial class Enums
	{
		public const int NSTextBlockTopAlignment = 0;
		public const int NSTextBlockMiddleAlignment = 1;
		public const int NSTextBlockBottomAlignment = 2;
		public const int NSTextBlockBaselineAlignment = 3;
	}

	public partial class Enums
	{
		public const int NSTextTableAutomaticLayoutAlgorithm = 0;
		public const int NSTextTableFixedLayoutAlgorithm = 1;
	}

	[Register]
	public partial class NSTextBlock : NSObject
	{
		public NSTextBlock() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextBlock(IntPtr instance) : base(instance)
		{
		}

		public NSTextBlock(Untyped instance) : base(instance)
		{
		}

		public static new NSTextBlock alloc()
		{
			return new NSTextBlock(ms_class.Call("alloc"));
		}

		public new NSTextBlock retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public void setValueTypeForDimension(float val, UInt32 type, UInt32 dimension)
		{
			Unused.Value = Call("setValue:type:forDimension:", val, type, dimension);
		}

		public float valueForDimension(UInt32 dimension)
		{
			return Call("valueForDimension:", dimension).To<float>();
		}

		public UInt32 valueTypeForDimension(UInt32 dimension)
		{
			return Call("valueTypeForDimension:", dimension).To<UInt32>();
		}

		public void setContentWidthType(float val, UInt32 type)
		{
			Unused.Value = Call("setContentWidth:type:", val, type);
		}

		public float contentWidth()
		{
			return Call("contentWidth").To<float>();
		}

		public UInt32 contentWidthValueType()
		{
			return Call("contentWidthValueType").To<UInt32>();
		}

		public void setWidthTypeForLayerEdge(float val, UInt32 type, Int32 layer, UInt32 edge)
		{
			Unused.Value = Call("setWidth:type:forLayer:edge:", val, type, layer, edge);
		}

		public void setWidthTypeForLayer(float val, UInt32 type, Int32 layer)
		{
			Unused.Value = Call("setWidth:type:forLayer:", val, type, layer);
		}

		public float widthForLayerEdge(Int32 layer, UInt32 edge)
		{
			return Call("widthForLayer:edge:", layer, edge).To<float>();
		}

		public UInt32 widthValueTypeForLayerEdge(Int32 layer, UInt32 edge)
		{
			return Call("widthValueTypeForLayer:edge:", layer, edge).To<UInt32>();
		}

		public void setVerticalAlignment(UInt32 alignment)
		{
			Unused.Value = Call("setVerticalAlignment:", alignment);
		}

		public UInt32 verticalAlignment()
		{
			return Call("verticalAlignment").To<UInt32>();
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setBorderColorForEdge(NSColor color, UInt32 edge)
		{
			Unused.Value = Call("setBorderColor:forEdge:", color, edge);
		}

		public void setBorderColor(NSColor color)
		{
			Unused.Value = Call("setBorderColor:", color);
		}

		public NSColor borderColorForEdge(UInt32 edge)
		{
			return Call("borderColorForEdge:", edge).To<NSColor>();
		}

		public NSRect rectForLayoutAtPointInRectTextContainerCharacterRange(NSPoint startingPoint, NSRect rect, NSTextContainer textContainer, NSRange charRange)
		{
			return Call("rectForLayoutAtPoint:inRect:textContainer:characterRange:", startingPoint, rect, textContainer, charRange).To<NSRect>();
		}

		public NSRect boundsRectForContentRectInRectTextContainerCharacterRange(NSRect contentRect, NSRect rect, NSTextContainer textContainer, NSRange charRange)
		{
			return Call("boundsRectForContentRect:inRect:textContainer:characterRange:", contentRect, rect, textContainer, charRange).To<NSRect>();
		}

		public void drawBackgroundWithFrameInViewCharacterRangeLayoutManager(NSRect frameRect, NSView controlView, NSRange charRange, NSLayoutManager layoutManager)
		{
			Unused.Value = Call("drawBackgroundWithFrame:inView:characterRange:layoutManager:", frameRect, controlView, charRange, layoutManager);
		}

		#region NSCoding Methods
		public void encodeWithCoder(NSCoder aCoder)
		{
			Unused.Value = Call("encodeWithCoder:", aCoder);
		}

		public NSObject initWithCoder(NSCoder aDecoder)
		{
			return Call("initWithCoder:", aDecoder).To<NSObject>();
		}
		#endregion

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSTextBlock");
	}

	[Register]
	public partial class NSTextTableBlock : NSTextBlock
	{
		public NSTextTableBlock() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextTableBlock(IntPtr instance) : base(instance)
		{
		}

		public NSTextTableBlock(Untyped instance) : base(instance)
		{
		}

		public static new NSTextTableBlock alloc()
		{
			return new NSTextTableBlock(ms_class.Call("alloc"));
		}

		public new NSTextTableBlock retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithTableStartingRowRowSpanStartingColumnColumnSpan(NSTextTable table, Int32 row, Int32 rowSpan, Int32 col, Int32 colSpan)
		{
			return Call("initWithTable:startingRow:rowSpan:startingColumn:columnSpan:", table, row, rowSpan, col, colSpan).To<NSObject>();
		}

		public NSTextTable table()
		{
			return Call("table").To<NSTextTable>();
		}

		public Int32 startingRow()
		{
			return Call("startingRow").To<Int32>();
		}

		public Int32 rowSpan()
		{
			return Call("rowSpan").To<Int32>();
		}

		public Int32 startingColumn()
		{
			return Call("startingColumn").To<Int32>();
		}

		public Int32 columnSpan()
		{
			return Call("columnSpan").To<Int32>();
		}

		private static Class ms_class = new Class("NSTextTableBlock");
	}

	[Register]
	public partial class NSTextTable : NSTextBlock
	{
		public NSTextTable() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextTable(IntPtr instance) : base(instance)
		{
		}

		public NSTextTable(Untyped instance) : base(instance)
		{
		}

		public static new NSTextTable alloc()
		{
			return new NSTextTable(ms_class.Call("alloc"));
		}

		public new NSTextTable retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 numberOfColumns()
		{
			return Call("numberOfColumns").To<UInt32>();
		}

		public void setNumberOfColumns(UInt32 numCols)
		{
			Unused.Value = Call("setNumberOfColumns:", numCols);
		}

		public UInt32 layoutAlgorithm()
		{
			return Call("layoutAlgorithm").To<UInt32>();
		}

		public void setLayoutAlgorithm(UInt32 algorithm)
		{
			Unused.Value = Call("setLayoutAlgorithm:", algorithm);
		}

		public bool collapsesBorders()
		{
			return Call("collapsesBorders").To<bool>();
		}

		public void setCollapsesBorders(bool flag)
		{
			Unused.Value = Call("setCollapsesBorders:", flag);
		}

		public bool hidesEmptyCells()
		{
			return Call("hidesEmptyCells").To<bool>();
		}

		public void setHidesEmptyCells(bool flag)
		{
			Unused.Value = Call("setHidesEmptyCells:", flag);
		}

		public NSRect rectForBlockLayoutAtPointInRectTextContainerCharacterRange(NSTextTableBlock block, NSPoint startingPoint, NSRect rect, NSTextContainer textContainer, NSRange charRange)
		{
			return Call("rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:", block, startingPoint, rect, textContainer, charRange).To<NSRect>();
		}

		public NSRect boundsRectForBlockContentRectInRectTextContainerCharacterRange(NSTextTableBlock block, NSRect contentRect, NSRect rect, NSTextContainer textContainer, NSRange charRange)
		{
			return Call("boundsRectForBlock:contentRect:inRect:textContainer:characterRange:", block, contentRect, rect, textContainer, charRange).To<NSRect>();
		}

		public void drawBackgroundForBlockWithFrameInViewCharacterRangeLayoutManager(NSTextTableBlock block, NSRect frameRect, NSView controlView, NSRange charRange, NSLayoutManager layoutManager)
		{
			Unused.Value = Call("drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:", block, frameRect, controlView, charRange, layoutManager);
		}

		private static Class ms_class = new Class("NSTextTable");
	}
}
