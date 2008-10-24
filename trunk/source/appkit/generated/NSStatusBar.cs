// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSStatusBar.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSStatusBar : NSObject
	{
		public NSStatusBar() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSStatusBar(IntPtr instance) : base(instance)
		{
		}

		public NSStatusBar(Untyped instance) : base(instance)
		{
		}

		public static new NSStatusBar alloc()
		{
			return new NSStatusBar(ms_class.Call("alloc"));
		}

		public new NSStatusBar retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSStatusBar systemStatusBar()
		{
			return ms_class.Call("systemStatusBar").To<NSStatusBar>();
		}

		public NSStatusItem statusItemWithLength(float length)
		{
			return Call("statusItemWithLength:", length).To<NSStatusItem>();
		}

		public void removeStatusItem(NSStatusItem item)
		{
			Unused.Value = Call("removeStatusItem:", item);
		}

		public bool isVertical()
		{
			return Call("isVertical").To<bool>();
		}

		public float thickness()
		{
			return Call("thickness").To<float>();
		}

		private static Class ms_class = new Class("NSStatusBar");
	}
}
