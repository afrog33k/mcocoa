// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSScreen.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSScreen : NSObject
	{
		public NSScreen() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScreen(IntPtr instance) : base(instance)
		{
		}

		public NSScreen(Untyped instance) : base(instance)
		{
		}

		public static new NSScreen alloc()
		{
			return new NSScreen(ms_class.Call("alloc"));
		}

		public new NSScreen retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSArray screens()
		{
			return ms_class.Call("screens").To<NSArray>();
		}

		public static NSScreen mainScreen()
		{
			return ms_class.Call("mainScreen").To<NSScreen>();
		}

		public static NSScreen deepestScreen()
		{
			return ms_class.Call("deepestScreen").To<NSScreen>();
		}

		public Int32 depth()
		{
			return Call("depth").To<Int32>();
		}

		public NSRect frame()
		{
			return Call("frame").To<NSRect>();
		}

		public NSRect visibleFrame()
		{
			return Call("visibleFrame").To<NSRect>();
		}

		public NSDictionary deviceDescription()
		{
			return Call("deviceDescription").To<NSDictionary>();
		}

		public IntPtr supportedWindowDepths()
		{
			return Call("supportedWindowDepths").To<IntPtr>();
		}

		public float userSpaceScaleFactor()
		{
			return Call("userSpaceScaleFactor").To<float>();
		}

		private static Class ms_class = new Class("NSScreen");
	}
}
