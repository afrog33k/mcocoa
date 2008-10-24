// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSAnimation.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSAnimationEaseInOut = 0;
		public const int NSAnimationEaseIn = 1;
		public const int NSAnimationEaseOut = 2;
		public const int NSAnimationLinear = 3;
	}

	public partial class Enums
	{
		public const int NSAnimationBlocking = 0;
		public const int NSAnimationNonblocking = 1;
		public const int NSAnimationNonblockingThreaded = 2;
	}

	[Register]
	public partial class NSAnimation : NSObject
	{
		public NSAnimation() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAnimation(IntPtr instance) : base(instance)
		{
		}

		public NSAnimation(Untyped instance) : base(instance)
		{
		}

		public static new NSAnimation alloc()
		{
			return new NSAnimation(ms_class.Call("alloc"));
		}

		public new NSAnimation retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithDurationAnimationCurve(double duration, UInt32 animationCurve)
		{
			return Call("initWithDuration:animationCurve:", duration, animationCurve).To<NSObject>();
		}

		public void startAnimation()
		{
			Unused.Value = Call("startAnimation");
		}

		public void stopAnimation()
		{
			Unused.Value = Call("stopAnimation");
		}

		public bool isAnimating()
		{
			return Call("isAnimating").To<bool>();
		}

		public float currentProgress()
		{
			return Call("currentProgress").To<float>();
		}

		public void setCurrentProgress(float progress)
		{
			Unused.Value = Call("setCurrentProgress:", progress);
		}

		public void setDuration(double duration)
		{
			Unused.Value = Call("setDuration:", duration);
		}

		public double duration()
		{
			return Call("duration").To<double>();
		}

		public UInt32 animationBlockingMode()
		{
			return Call("animationBlockingMode").To<UInt32>();
		}

		public void setAnimationBlockingMode(UInt32 animationBlockingMode)
		{
			Unused.Value = Call("setAnimationBlockingMode:", animationBlockingMode);
		}

		public void setFrameRate(float framesPerSecond)
		{
			Unused.Value = Call("setFrameRate:", framesPerSecond);
		}

		public float frameRate()
		{
			return Call("frameRate").To<float>();
		}

		public void setAnimationCurve(UInt32 curve)
		{
			Unused.Value = Call("setAnimationCurve:", curve);
		}

		public UInt32 animationCurve()
		{
			return Call("animationCurve").To<UInt32>();
		}

		public float currentValue()
		{
			return Call("currentValue").To<float>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public NSArray progressMarks()
		{
			return Call("progressMarks").To<NSArray>();
		}

		public void setProgressMarks(NSArray progressMarks)
		{
			Unused.Value = Call("setProgressMarks:", progressMarks);
		}

		public void addProgressMark(float progressMark)
		{
			Unused.Value = Call("addProgressMark:", progressMark);
		}

		public void removeProgressMark(float progressMark)
		{
			Unused.Value = Call("removeProgressMark:", progressMark);
		}

		public void startWhenAnimationReachesProgress(NSAnimation animation, float startProgress)
		{
			Unused.Value = Call("startWhenAnimation:reachesProgress:", animation, startProgress);
		}

		public void stopWhenAnimationReachesProgress(NSAnimation animation, float stopProgress)
		{
			Unused.Value = Call("stopWhenAnimation:reachesProgress:", animation, stopProgress);
		}

		public void clearStartAnimation()
		{
			Unused.Value = Call("clearStartAnimation");
		}

		public void clearStopAnimation()
		{
			Unused.Value = Call("clearStopAnimation");
		}

		public NSArray runLoopModesForAnimating()
		{
			return Call("runLoopModesForAnimating").To<NSArray>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSAnimation");
	}

	public static class NSAnimationDelegateForNSObjectCategory
	{
		public static bool animationShouldStart(this NSObject _instance, NSAnimation animation)
		{
			return _instance.Call("animationShouldStart:", animation).To<bool>();
		}

		public static void animationDidStop(this NSObject _instance, NSAnimation animation)
		{
			Unused.Value = _instance.Call("animationDidStop:", animation);
		}

		public static void animationDidEnd(this NSObject _instance, NSAnimation animation)
		{
			Unused.Value = _instance.Call("animationDidEnd:", animation);
		}

		public static float animationValueForProgress(this NSObject _instance, NSAnimation animation, float progress)
		{
			return _instance.Call("animation:valueForProgress:", animation, progress).To<float>();
		}

		public static void animationDidReachProgressMark(this NSObject _instance, NSAnimation animation, float progress)
		{
			Unused.Value = _instance.Call("animation:didReachProgressMark:", animation, progress);
		}
	}

	[Register]
	public partial class NSViewAnimation : NSAnimation
	{
		public NSViewAnimation() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSViewAnimation(IntPtr instance) : base(instance)
		{
		}

		public NSViewAnimation(Untyped instance) : base(instance)
		{
		}

		public static new NSViewAnimation alloc()
		{
			return new NSViewAnimation(ms_class.Call("alloc"));
		}

		public new NSViewAnimation retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithViewAnimations(NSArray viewAnimations)
		{
			return Call("initWithViewAnimations:", viewAnimations).To<NSObject>();
		}

		public NSArray viewAnimations()
		{
			return Call("viewAnimations").To<NSArray>();
		}

		public void setViewAnimations(NSArray viewAnimations)
		{
			Unused.Value = Call("setViewAnimations:", viewAnimations);
		}

		private static Class ms_class = new Class("NSViewAnimation");
	}
}
