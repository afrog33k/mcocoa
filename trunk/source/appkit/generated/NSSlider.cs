// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSlider.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSlider : NSControl
	{
		public NSSlider() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSlider(IntPtr instance) : base(instance)
		{
		}

		public NSSlider(Untyped instance) : base(instance)
		{
		}

		public static new NSSlider alloc()
		{
			return new NSSlider(ms_class.Call("alloc"));
		}

		public new NSSlider retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

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

		public void setTitleCell(NSCell aCell)
		{
			Unused.Value = Call("setTitleCell:", aCell);
		}

		public NSObject titleCell()
		{
			return Call("titleCell").To<NSObject>();
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

		public NSString title()
		{
			return Call("title").To<NSString>();
		}

		public void setTitle(NSString aString)
		{
			Unused.Value = Call("setTitle:", aString);
		}

		public void setKnobThickness(float aFloat)
		{
			Unused.Value = Call("setKnobThickness:", aFloat);
		}

		public float knobThickness()
		{
			return Call("knobThickness").To<float>();
		}

		public void setImage(NSImage backgroundImage)
		{
			Unused.Value = Call("setImage:", backgroundImage);
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public Int32 isVertical()
		{
			return Call("isVertical").To<Int32>();
		}

		// skipping acceptsFirstMouse: (it's declared in a base class)

		private static Class ms_class = new Class("NSSlider");
	}

	public static class NSTickMarkSupportForNSSliderCategory
	{
		public static void setNumberOfTickMarks(this NSSlider _instance, Int32 count)
		{
			Unused.Value = _instance.Call("setNumberOfTickMarks:", count);
		}

		public static Int32 numberOfTickMarks(this NSSlider _instance)
		{
			return _instance.Call("numberOfTickMarks").To<Int32>();
		}

		public static void setTickMarkPosition(this NSSlider _instance, UInt32 position)
		{
			Unused.Value = _instance.Call("setTickMarkPosition:", position);
		}

		public static UInt32 tickMarkPosition(this NSSlider _instance)
		{
			return _instance.Call("tickMarkPosition").To<UInt32>();
		}

		public static void setAllowsTickMarkValuesOnly(this NSSlider _instance, bool yorn)
		{
			Unused.Value = _instance.Call("setAllowsTickMarkValuesOnly:", yorn);
		}

		public static bool allowsTickMarkValuesOnly(this NSSlider _instance)
		{
			return _instance.Call("allowsTickMarkValuesOnly").To<bool>();
		}

		public static double tickMarkValueAtIndex(this NSSlider _instance, Int32 index)
		{
			return _instance.Call("tickMarkValueAtIndex:", index).To<double>();
		}

		public static NSRect rectOfTickMarkAtIndex(this NSSlider _instance, Int32 index)
		{
			return _instance.Call("rectOfTickMarkAtIndex:", index).To<NSRect>();
		}

		public static Int32 indexOfTickMarkAtPoint(this NSSlider _instance, NSPoint point)
		{
			return _instance.Call("indexOfTickMarkAtPoint:", point).To<Int32>();
		}

		public static double closestTickMarkValueToValue(this NSSlider _instance, double value)
		{
			return _instance.Call("closestTickMarkValueToValue:", value).To<double>();
		}
	}
}
