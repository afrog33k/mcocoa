// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSliderCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTickMarkBelow = 0;
		public const int NSTickMarkAbove = 1;
		public const int NSTickMarkLeft = NSTickMarkAbove;
		public const int NSTickMarkRight = NSTickMarkBelow;
	}

	public partial class Enums
	{
		public const int NSLinearSlider = 0;
		public const int NSCircularSlider = 1;
	}

	[Register]
	public partial class NSSliderCell : NSActionCell
	{
		public NSSliderCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSliderCell(IntPtr instance) : base(instance)
		{
		}

		public NSSliderCell(Untyped instance) : base(instance)
		{
		}

		public static new NSSliderCell alloc()
		{
			return new NSSliderCell(ms_class.Call("alloc"));
		}

		public new NSSliderCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping prefersTrackingUntilMouseUp (it's declared in a base class)

		public double minValue()
		{
			return Call("minValue").To<double>();
		}

		public void setMinValue(double aDouble)
		{
			Unused.Value = Call("setMinValue:", aDouble);
		}

		public double maxValue()
		{
			return Call("maxValue").To<double>();
		}

		public void setMaxValue(double aDouble)
		{
			Unused.Value = Call("setMaxValue:", aDouble);
		}

		public void setAltIncrementValue(double incValue)
		{
			Unused.Value = Call("setAltIncrementValue:", incValue);
		}

		public double altIncrementValue()
		{
			return Call("altIncrementValue").To<double>();
		}

		public Int32 isVertical()
		{
			return Call("isVertical").To<Int32>();
		}

		public void setTitleColor(NSColor newColor)
		{
			Unused.Value = Call("setTitleColor:", newColor);
		}

		public NSColor titleColor()
		{
			return Call("titleColor").To<NSColor>();
		}

		public void setTitleFont(NSFont fontObj)
		{
			Unused.Value = Call("setTitleFont:", fontObj);
		}

		public NSFont titleFont()
		{
			return Call("titleFont").To<NSFont>();
		}

		// skipping title (it's declared in a base class)

		// skipping setTitle: (it's declared in a base class)

		public void setTitleCell(NSCell aCell)
		{
			Unused.Value = Call("setTitleCell:", aCell);
		}

		public NSObject titleCell()
		{
			return Call("titleCell").To<NSObject>();
		}

		public void setKnobThickness(float aFloat)
		{
			Unused.Value = Call("setKnobThickness:", aFloat);
		}

		public float knobThickness()
		{
			return Call("knobThickness").To<float>();
		}

		public NSRect knobRectFlipped(bool flipped)
		{
			return Call("knobRectFlipped:", flipped).To<NSRect>();
		}

		public void drawKnob(NSRect knobRect)
		{
			Unused.Value = Call("drawKnob:", knobRect);
		}

		public void drawKnob()
		{
			Unused.Value = Call("drawKnob");
		}

		public void drawBarInsideFlipped(NSRect aRect, bool flipped)
		{
			Unused.Value = Call("drawBarInside:flipped:", aRect, flipped);
		}

		public NSRect trackRect()
		{
			return Call("trackRect").To<NSRect>();
		}

		public void setSliderType(UInt32 sliderType)
		{
			Unused.Value = Call("setSliderType:", sliderType);
		}

		public UInt32 sliderType()
		{
			return Call("sliderType").To<UInt32>();
		}

		private static Class ms_class = new Class("NSSliderCell");
	}

	public static class NSTickMarkSupportForNSSliderCellCategory
	{
		public static void setNumberOfTickMarks(this NSSliderCell _instance, Int32 count)
		{
			Unused.Value = _instance.Call("setNumberOfTickMarks:", count);
		}

		public static Int32 numberOfTickMarks(this NSSliderCell _instance)
		{
			return _instance.Call("numberOfTickMarks").To<Int32>();
		}

		public static void setTickMarkPosition(this NSSliderCell _instance, UInt32 position)
		{
			Unused.Value = _instance.Call("setTickMarkPosition:", position);
		}

		public static UInt32 tickMarkPosition(this NSSliderCell _instance)
		{
			return _instance.Call("tickMarkPosition").To<UInt32>();
		}

		public static void setAllowsTickMarkValuesOnly(this NSSliderCell _instance, bool yorn)
		{
			Unused.Value = _instance.Call("setAllowsTickMarkValuesOnly:", yorn);
		}

		public static bool allowsTickMarkValuesOnly(this NSSliderCell _instance)
		{
			return _instance.Call("allowsTickMarkValuesOnly").To<bool>();
		}

		public static double tickMarkValueAtIndex(this NSSliderCell _instance, Int32 index)
		{
			return _instance.Call("tickMarkValueAtIndex:", index).To<double>();
		}

		public static NSRect rectOfTickMarkAtIndex(this NSSliderCell _instance, Int32 index)
		{
			return _instance.Call("rectOfTickMarkAtIndex:", index).To<NSRect>();
		}

		public static Int32 indexOfTickMarkAtPoint(this NSSliderCell _instance, NSPoint point)
		{
			return _instance.Call("indexOfTickMarkAtPoint:", point).To<Int32>();
		}

		public static double closestTickMarkValueToValue(this NSSliderCell _instance, double value)
		{
			return _instance.Call("closestTickMarkValueToValue:", value).To<double>();
		}
	}
}
