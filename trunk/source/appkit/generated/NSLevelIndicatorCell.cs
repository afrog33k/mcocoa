// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSLevelIndicatorCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSRelevancyLevelIndicatorStyle = 0;
		public const int NSContinuousCapacityLevelIndicatorStyle = 1;
		public const int NSDiscreteCapacityLevelIndicatorStyle = 2;
		public const int NSRatingLevelIndicatorStyle = 3;
	}

	[Register]
	public partial class NSLevelIndicatorCell : NSActionCell
	{
		public NSLevelIndicatorCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSLevelIndicatorCell(IntPtr instance) : base(instance)
		{
		}

		public NSLevelIndicatorCell(Untyped instance) : base(instance)
		{
		}

		public static new NSLevelIndicatorCell alloc()
		{
			return new NSLevelIndicatorCell(ms_class.Call("alloc"));
		}

		public new NSLevelIndicatorCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithLevelIndicatorStyle(UInt32 levelIndicatorStyle)
		{
			return Call("initWithLevelIndicatorStyle:", levelIndicatorStyle).To<NSObject>();
		}

		public UInt32 levelIndicatorStyle()
		{
			return Call("levelIndicatorStyle").To<UInt32>();
		}

		public void setLevelIndicatorStyle(UInt32 levelIndicatorStyle)
		{
			Unused.Value = Call("setLevelIndicatorStyle:", levelIndicatorStyle);
		}

		public double minValue()
		{
			return Call("minValue").To<double>();
		}

		public void setMinValue(double minValue)
		{
			Unused.Value = Call("setMinValue:", minValue);
		}

		public double maxValue()
		{
			return Call("maxValue").To<double>();
		}

		public void setMaxValue(double maxValue)
		{
			Unused.Value = Call("setMaxValue:", maxValue);
		}

		public double warningValue()
		{
			return Call("warningValue").To<double>();
		}

		public void setWarningValue(double warningValue)
		{
			Unused.Value = Call("setWarningValue:", warningValue);
		}

		public double criticalValue()
		{
			return Call("criticalValue").To<double>();
		}

		public void setCriticalValue(double criticalValue)
		{
			Unused.Value = Call("setCriticalValue:", criticalValue);
		}

		public void setTickMarkPosition(UInt32 position)
		{
			Unused.Value = Call("setTickMarkPosition:", position);
		}

		public UInt32 tickMarkPosition()
		{
			return Call("tickMarkPosition").To<UInt32>();
		}

		public void setNumberOfTickMarks(Int32 count)
		{
			Unused.Value = Call("setNumberOfTickMarks:", count);
		}

		public Int32 numberOfTickMarks()
		{
			return Call("numberOfTickMarks").To<Int32>();
		}

		public void setNumberOfMajorTickMarks(Int32 count)
		{
			Unused.Value = Call("setNumberOfMajorTickMarks:", count);
		}

		public Int32 numberOfMajorTickMarks()
		{
			return Call("numberOfMajorTickMarks").To<Int32>();
		}

		public NSRect rectOfTickMarkAtIndex(Int32 index)
		{
			return Call("rectOfTickMarkAtIndex:", index).To<NSRect>();
		}

		public double tickMarkValueAtIndex(Int32 index)
		{
			return Call("tickMarkValueAtIndex:", index).To<double>();
		}

		// skipping setImage: (it's declared in a base class)

		private static Class ms_class = new Class("NSLevelIndicatorCell");
	}
}
