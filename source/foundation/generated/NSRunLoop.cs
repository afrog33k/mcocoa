// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSRunLoop.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSRunLoop : NSObject
	{
		public NSRunLoop() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSRunLoop(IntPtr instance) : base(instance)
		{
		}

		public NSRunLoop(Untyped instance) : base(instance)
		{
		}

		public static new NSRunLoop alloc()
		{
			return new NSRunLoop(ms_class.Call("alloc"));
		}

		public new NSRunLoop retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSRunLoop currentRunLoop()
		{
			return ms_class.Call("currentRunLoop").To<NSRunLoop>();
		}

		public static NSRunLoop mainRunLoopAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return ms_class.Call("mainRunLoopAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSRunLoop>();
		}

		public NSString currentMode()
		{
			return Call("currentMode").To<NSString>();
		}

		public IntPtr getCFRunLoop()
		{
			return Call("getCFRunLoop").To<IntPtr>();
		}

		public void addTimerForMode(NSTimer timer, NSString mode)
		{
			Unused.Value = Call("addTimer:forMode:", timer, mode);
		}

		public void addPortForMode(NSPort aPort, NSString mode)
		{
			Unused.Value = Call("addPort:forMode:", aPort, mode);
		}

		public void removePortForMode(NSPort aPort, NSString mode)
		{
			Unused.Value = Call("removePort:forMode:", aPort, mode);
		}

		public NSDate limitDateForMode(NSString mode)
		{
			return Call("limitDateForMode:", mode).To<NSDate>();
		}

		public void acceptInputForModeBeforeDate(NSString mode, NSDate limitDate)
		{
			Unused.Value = Call("acceptInputForMode:beforeDate:", mode, limitDate);
		}

		private static Class ms_class = new Class("NSRunLoop");
	}

	public static class NSRunLoopConveniencesForNSRunLoopCategory
	{
		public static void run(this NSRunLoop _instance)
		{
			Unused.Value = _instance.Call("run");
		}

		public static void runUntilDate(this NSRunLoop _instance, NSDate limitDate)
		{
			Unused.Value = _instance.Call("runUntilDate:", limitDate);
		}

		public static bool runModeBeforeDate(this NSRunLoop _instance, NSString mode, NSDate limitDate)
		{
			return _instance.Call("runMode:beforeDate:", mode, limitDate).To<bool>();
		}
	}

	public static class NSDelayedPerformingForNSObjectCategory
	{
		public static void performSelectorWithObjectAfterDelayInModes(this NSObject _instance, Selector aSelector, NSObject anArgument, double delay, NSArray modes)
		{
			Unused.Value = _instance.Call("performSelector:withObject:afterDelay:inModes:", aSelector, anArgument, delay, modes);
		}

		public static void performSelectorWithObjectAfterDelay(this NSObject _instance, Selector aSelector, NSObject anArgument, double delay)
		{
			Unused.Value = _instance.Call("performSelector:withObject:afterDelay:", aSelector, anArgument, delay);
		}

		public static void cancelPreviousPerformRequestsWithTargetSelectorObject(this NSObject _instance, NSObject aTarget, Selector aSelector, NSObject anArgument)
		{
			Unused.Value = _instance.Call("cancelPreviousPerformRequestsWithTarget:selector:object:", aTarget, aSelector, anArgument);
		}

		public static void cancelPreviousPerformRequestsWithTarget(this NSObject _instance, NSObject aTarget)
		{
			Unused.Value = _instance.Call("cancelPreviousPerformRequestsWithTarget:", aTarget);
		}
	}

	public static class NSOrderedPerformForNSRunLoopCategory
	{
		public static void performSelectorTargetArgumentOrderModes(this NSRunLoop _instance, Selector aSelector, NSObject target, NSObject arg, UInt32 order, NSArray modes)
		{
			Unused.Value = _instance.Call("performSelector:target:argument:order:modes:", aSelector, target, arg, order, modes);
		}

		public static void cancelPerformSelectorTargetArgument(this NSRunLoop _instance, Selector aSelector, NSObject target, NSObject arg)
		{
			Unused.Value = _instance.Call("cancelPerformSelector:target:argument:", aSelector, target, arg);
		}

		public static void cancelPerformSelectorsWithTarget(this NSRunLoop _instance, NSObject target)
		{
			Unused.Value = _instance.Call("cancelPerformSelectorsWithTarget:", target);
		}
	}
}
