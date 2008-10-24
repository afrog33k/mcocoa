// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSTimer.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSTimer : NSObject
	{
		public NSTimer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTimer(IntPtr instance) : base(instance)
		{
		}

		public NSTimer(Untyped instance) : base(instance)
		{
		}

		public static new NSTimer alloc()
		{
			return new NSTimer(ms_class.Call("alloc"));
		}

		public new NSTimer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSTimer timerWithTimeIntervalInvocationRepeats(double ti, NSInvocation invocation, bool yesOrNo)
		{
			return ms_class.Call("timerWithTimeInterval:invocation:repeats:", ti, invocation, yesOrNo).To<NSTimer>();
		}

		public static NSTimer scheduledTimerWithTimeIntervalInvocationRepeats(double ti, NSInvocation invocation, bool yesOrNo)
		{
			return ms_class.Call("scheduledTimerWithTimeInterval:invocation:repeats:", ti, invocation, yesOrNo).To<NSTimer>();
		}

		public static NSTimer timerWithTimeIntervalTargetSelectorUserInfoRepeats(double ti, NSObject aTarget, Selector aSelector, NSObject userInfo, bool yesOrNo)
		{
			return ms_class.Call("timerWithTimeInterval:target:selector:userInfo:repeats:", ti, aTarget, aSelector, userInfo, yesOrNo).To<NSTimer>();
		}

		public static NSTimer scheduledTimerWithTimeIntervalTargetSelectorUserInfoRepeats(double ti, NSObject aTarget, Selector aSelector, NSObject userInfo, bool yesOrNo)
		{
			return ms_class.Call("scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:", ti, aTarget, aSelector, userInfo, yesOrNo).To<NSTimer>();
		}

		public NSObject initWithFireDateIntervalTargetSelectorUserInfoRepeats(NSDate date, double ti, NSObject t, Selector s, NSObject ui, bool rep)
		{
			return Call("initWithFireDate:interval:target:selector:userInfo:repeats:", date, ti, t, s, ui, rep).To<NSObject>();
		}

		public void fire()
		{
			Unused.Value = Call("fire");
		}

		public NSDate fireDate()
		{
			return Call("fireDate").To<NSDate>();
		}

		public void setFireDate(NSDate date)
		{
			Unused.Value = Call("setFireDate:", date);
		}

		public double timeInterval()
		{
			return Call("timeInterval").To<double>();
		}

		public void invalidate()
		{
			Unused.Value = Call("invalidate");
		}

		public bool isValid()
		{
			return Call("isValid").To<bool>();
		}

		public NSObject userInfo()
		{
			return Call("userInfo").To<NSObject>();
		}

		private static Class ms_class = new Class("NSTimer");
	}
}
