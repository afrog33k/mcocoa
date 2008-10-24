// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSStepper.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSStepper : NSControl
	{
		public NSStepper() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSStepper(IntPtr instance) : base(instance)
		{
		}

		public NSStepper(Untyped instance) : base(instance)
		{
		}

		public static new NSStepper alloc()
		{
			return new NSStepper(ms_class.Call("alloc"));
		}

		public new NSStepper retain()
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

		public double increment()
		{
			return Call("increment").To<double>();
		}

		public void setIncrement(double increment)
		{
			Unused.Value = Call("setIncrement:", increment);
		}

		public bool valueWraps()
		{
			return Call("valueWraps").To<bool>();
		}

		public void setValueWraps(bool valueWraps)
		{
			Unused.Value = Call("setValueWraps:", valueWraps);
		}

		public bool autorepeat()
		{
			return Call("autorepeat").To<bool>();
		}

		public void setAutorepeat(bool autorepeat)
		{
			Unused.Value = Call("setAutorepeat:", autorepeat);
		}

		private static Class ms_class = new Class("NSStepper");
	}
}
