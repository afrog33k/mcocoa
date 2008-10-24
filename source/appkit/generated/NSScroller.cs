// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSScroller.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSScrollerArrowsMaxEnd = 0;
		public const int NSScrollerArrowsMinEnd = 1;
		public const int NSScrollerArrowsDefaultSetting = 0;
		public const int NSScrollerArrowsNone = 2;
	}

	public partial class Enums
	{
		public const int NSNoScrollerParts = 0;
		public const int NSOnlyScrollerArrows = 1;
		public const int NSAllScrollerParts = 2;
	}

	public partial class Enums
	{
		public const int NSScrollerNoPart = 0;
		public const int NSScrollerDecrementPage = 1;
		public const int NSScrollerKnob = 2;
		public const int NSScrollerIncrementPage = 3;
		public const int NSScrollerDecrementLine = 4;
		public const int NSScrollerIncrementLine = 5;
		public const int NSScrollerKnobSlot = 6;
	}

	public partial class Enums
	{
		public const int NSScrollerIncrementArrow = 0;
		public const int NSScrollerDecrementArrow = 1;
	}

	[Register]
	public partial class NSScroller : NSControl
	{
		public NSScroller() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScroller(IntPtr instance) : base(instance)
		{
		}

		public NSScroller(Untyped instance) : base(instance)
		{
		}

		public static new NSScroller alloc()
		{
			return new NSScroller(ms_class.Call("alloc"));
		}

		public new NSScroller retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static float scrollerWidth()
		{
			return ms_class.Call("scrollerWidth").To<float>();
		}

		public static float scrollerWidthForControlSize(UInt32 controlSize)
		{
			return ms_class.Call("scrollerWidthForControlSize:", controlSize).To<float>();
		}

		public void drawParts()
		{
			Unused.Value = Call("drawParts");
		}

		public NSRect rectForPart(UInt32 partCode)
		{
			return Call("rectForPart:", partCode).To<NSRect>();
		}

		public void checkSpaceForParts()
		{
			Unused.Value = Call("checkSpaceForParts");
		}

		public UInt32 usableParts()
		{
			return Call("usableParts").To<UInt32>();
		}

		public void setArrowsPosition(UInt32 where_)
		{
			Unused.Value = Call("setArrowsPosition:", where_);
		}

		public UInt32 arrowsPosition()
		{
			return Call("arrowsPosition").To<UInt32>();
		}

		public void setControlTint(UInt32 controlTint)
		{
			Unused.Value = Call("setControlTint:", controlTint);
		}

		public UInt32 controlTint()
		{
			return Call("controlTint").To<UInt32>();
		}

		public void setControlSize(UInt32 controlSize)
		{
			Unused.Value = Call("setControlSize:", controlSize);
		}

		public UInt32 controlSize()
		{
			return Call("controlSize").To<UInt32>();
		}

		public void drawArrowHighlight(UInt32 whichArrow, bool flag)
		{
			Unused.Value = Call("drawArrow:highlight:", whichArrow, flag);
		}

		public void drawKnob()
		{
			Unused.Value = Call("drawKnob");
		}

		public void drawKnobSlotInRectHighlight(NSRect slotRect, bool flag)
		{
			Unused.Value = Call("drawKnobSlotInRect:highlight:", slotRect, flag);
		}

		public void highlight(bool flag)
		{
			Unused.Value = Call("highlight:", flag);
		}

		public UInt32 testPart(NSPoint thePoint)
		{
			return Call("testPart:", thePoint).To<UInt32>();
		}

		public void trackKnob(NSEvent theEvent)
		{
			Unused.Value = Call("trackKnob:", theEvent);
		}

		public void trackScrollButtons(NSEvent theEvent)
		{
			Unused.Value = Call("trackScrollButtons:", theEvent);
		}

		public UInt32 hitPart()
		{
			return Call("hitPart").To<UInt32>();
		}

		public float knobProportion()
		{
			return Call("knobProportion").To<float>();
		}

		public void setKnobProportion(float proportion)
		{
			Unused.Value = Call("setKnobProportion:", proportion);
		}

		private static Class ms_class = new Class("NSScroller");
	}

	public static class NSDeprecatedForNSScrollerCategory
	{
		public static void setFloatValueKnobProportion(this NSScroller _instance, float aFloat, float proportion)
		{
			Unused.Value = _instance.Call("setFloatValue:knobProportion:", aFloat, proportion);
		}
	}
}
