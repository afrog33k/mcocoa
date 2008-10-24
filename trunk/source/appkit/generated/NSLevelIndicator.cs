// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSLevelIndicator.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSLevelIndicator : NSControl
	{
		public NSLevelIndicator() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSLevelIndicator(IntPtr instance) : base(instance)
		{
		}

		public NSLevelIndicator(Untyped instance) : base(instance)
		{
		}

		public static new NSLevelIndicator alloc()
		{
			return new NSLevelIndicator(ms_class.Call("alloc"));
		}

		public new NSLevelIndicator retain()
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

		public UInt32 tickMarkPosition()
		{
			return Call("tickMarkPosition").To<UInt32>();
		}

		public void setTickMarkPosition(UInt32 position)
		{
			Unused.Value = Call("setTickMarkPosition:", position);
		}

		public Int32 numberOfTickMarks()
		{
			return Call("numberOfTickMarks").To<Int32>();
		}

		public void setNumberOfTickMarks(Int32 count)
		{
			Unused.Value = Call("setNumberOfTickMarks:", count);
		}

		public Int32 numberOfMajorTickMarks()
		{
			return Call("numberOfMajorTickMarks").To<Int32>();
		}

		public void setNumberOfMajorTickMarks(Int32 count)
		{
			Unused.Value = Call("setNumberOfMajorTickMarks:", count);
		}

		public double tickMarkValueAtIndex(Int32 index)
		{
			return Call("tickMarkValueAtIndex:", index).To<double>();
		}

		public NSRect rectOfTickMarkAtIndex(Int32 index)
		{
			return Call("rectOfTickMarkAtIndex:", index).To<NSRect>();
		}

		private static Class ms_class = new Class("NSLevelIndicator");
	}
}
