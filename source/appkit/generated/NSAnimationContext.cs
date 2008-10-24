// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSAnimationContext.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSAnimationContext : NSObject
	{
		public NSAnimationContext() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAnimationContext(IntPtr instance) : base(instance)
		{
		}

		public NSAnimationContext(Untyped instance) : base(instance)
		{
		}

		public static new NSAnimationContext alloc()
		{
			return new NSAnimationContext(ms_class.Call("alloc"));
		}

		public new NSAnimationContext retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void beginGrouping()
		{
			Unused.Value = ms_class.Call("beginGrouping");
		}

		public static void endGrouping()
		{
			Unused.Value = ms_class.Call("endGrouping");
		}

		public static NSAnimationContext currentContext()
		{
			return ms_class.Call("currentContext").To<NSAnimationContext>();
		}

		public void setDuration(double duration)
		{
			Unused.Value = Call("setDuration:", duration);
		}

		public double duration()
		{
			return Call("duration").To<double>();
		}

		private static Class ms_class = new Class("NSAnimationContext");
	}
}
