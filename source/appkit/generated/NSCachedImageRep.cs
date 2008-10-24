// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSCachedImageRep.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSCachedImageRep : NSImageRep
	{
		public NSCachedImageRep() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCachedImageRep(IntPtr instance) : base(instance)
		{
		}

		public NSCachedImageRep(Untyped instance) : base(instance)
		{
		}

		public static new NSCachedImageRep alloc()
		{
			return new NSCachedImageRep(ms_class.Call("alloc"));
		}

		public new NSCachedImageRep retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithWindowRect(NSWindow win, NSRect rect)
		{
			return Call("initWithWindow:rect:", win, rect).To<NSObject>();
		}

		public NSObject initWithSizeDepthSeparateAlpha(NSSize size, Int32 depth, bool flag, bool alpha)
		{
			return Call("initWithSize:depth:separate:alpha:", size, depth, flag, alpha).To<NSObject>();
		}

		public NSWindow window()
		{
			return Call("window").To<NSWindow>();
		}

		public NSRect rect()
		{
			return Call("rect").To<NSRect>();
		}

		private static Class ms_class = new Class("NSCachedImageRep");
	}
}
