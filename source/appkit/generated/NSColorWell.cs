// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSColorWell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSColorWell : NSControl
	{
		public NSColorWell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSColorWell(IntPtr instance) : base(instance)
		{
		}

		public NSColorWell(Untyped instance) : base(instance)
		{
		}

		public static new NSColorWell alloc()
		{
			return new NSColorWell(ms_class.Call("alloc"));
		}

		public new NSColorWell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void deactivate()
		{
			Unused.Value = Call("deactivate");
		}

		public void activate(bool exclusive)
		{
			Unused.Value = Call("activate:", exclusive);
		}

		public bool isActive()
		{
			return Call("isActive").To<bool>();
		}

		public void drawWellInside(NSRect insideRect)
		{
			Unused.Value = Call("drawWellInside:", insideRect);
		}

		public bool isBordered()
		{
			return Call("isBordered").To<bool>();
		}

		public void setBordered(bool flag)
		{
			Unused.Value = Call("setBordered:", flag);
		}

		public void takeColorFrom(NSObject sender)
		{
			Unused.Value = Call("takeColorFrom:", sender);
		}

		public void setColor(NSColor color)
		{
			Unused.Value = Call("setColor:", color);
		}

		public NSColor color()
		{
			return Call("color").To<NSColor>();
		}

		private static Class ms_class = new Class("NSColorWell");
	}
}
