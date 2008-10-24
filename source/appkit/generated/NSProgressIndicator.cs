// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSProgressIndicator.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSProgressIndicatorPreferredThickness = 14;
		public const int NSProgressIndicatorPreferredSmallThickness = 10;
		public const int NSProgressIndicatorPreferredLargeThickness = 18;
		public const int NSProgressIndicatorPreferredAquaThickness = 12;
	}

	public partial class Enums
	{
		public const int NSProgressIndicatorBarStyle = 0;
		public const int NSProgressIndicatorSpinningStyle = 1;
	}

	[Register]
	public partial class NSProgressIndicator : NSView
	{
		public NSProgressIndicator() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSProgressIndicator(IntPtr instance) : base(instance)
		{
		}

		public NSProgressIndicator(Untyped instance) : base(instance)
		{
		}

		public static new NSProgressIndicator alloc()
		{
			return new NSProgressIndicator(ms_class.Call("alloc"));
		}

		public new NSProgressIndicator retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool isIndeterminate()
		{
			return Call("isIndeterminate").To<bool>();
		}

		public void setIndeterminate(bool flag)
		{
			Unused.Value = Call("setIndeterminate:", flag);
		}

		public bool isBezeled()
		{
			return Call("isBezeled").To<bool>();
		}

		public void setBezeled(bool flag)
		{
			Unused.Value = Call("setBezeled:", flag);
		}

		public UInt32 controlTint()
		{
			return Call("controlTint").To<UInt32>();
		}

		public void setControlTint(UInt32 tint)
		{
			Unused.Value = Call("setControlTint:", tint);
		}

		public UInt32 controlSize()
		{
			return Call("controlSize").To<UInt32>();
		}

		public void setControlSize(UInt32 size)
		{
			Unused.Value = Call("setControlSize:", size);
		}

		public double doubleValue()
		{
			return Call("doubleValue").To<double>();
		}

		public void setDoubleValue(double doubleValue)
		{
			Unused.Value = Call("setDoubleValue:", doubleValue);
		}

		public void incrementBy(double delta)
		{
			Unused.Value = Call("incrementBy:", delta);
		}

		public double minValue()
		{
			return Call("minValue").To<double>();
		}

		public double maxValue()
		{
			return Call("maxValue").To<double>();
		}

		public void setMinValue(double newMinimum)
		{
			Unused.Value = Call("setMinValue:", newMinimum);
		}

		public void setMaxValue(double newMaximum)
		{
			Unused.Value = Call("setMaxValue:", newMaximum);
		}

		public double animationDelay()
		{
			return Call("animationDelay").To<double>();
		}

		public void setAnimationDelay(double delay)
		{
			Unused.Value = Call("setAnimationDelay:", delay);
		}

		public bool usesThreadedAnimation()
		{
			return Call("usesThreadedAnimation").To<bool>();
		}

		public void setUsesThreadedAnimation(bool threadedAnimation)
		{
			Unused.Value = Call("setUsesThreadedAnimation:", threadedAnimation);
		}

		public void startAnimation(NSObject sender)
		{
			Unused.Value = Call("startAnimation:", sender);
		}

		public void stopAnimation(NSObject sender)
		{
			Unused.Value = Call("stopAnimation:", sender);
		}

		public void animate(NSObject sender)
		{
			Unused.Value = Call("animate:", sender);
		}

		public void setStyle(UInt32 style)
		{
			Unused.Value = Call("setStyle:", style);
		}

		public UInt32 style()
		{
			return Call("style").To<UInt32>();
		}

		public void sizeToFit()
		{
			Unused.Value = Call("sizeToFit");
		}

		public bool isDisplayedWhenStopped()
		{
			return Call("isDisplayedWhenStopped").To<bool>();
		}

		public void setDisplayedWhenStopped(bool isDisplayed)
		{
			Unused.Value = Call("setDisplayedWhenStopped:", isDisplayed);
		}

		private static Class ms_class = new Class("NSProgressIndicator");
	}
}
