// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSQuickDrawView.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSQuickDrawView : NSView
	{
		public NSQuickDrawView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSQuickDrawView(IntPtr instance) : base(instance)
		{
		}

		public NSQuickDrawView(Untyped instance) : base(instance)
		{
		}

		public static new NSQuickDrawView alloc()
		{
			return new NSQuickDrawView(ms_class.Call("alloc"));
		}

		public new NSQuickDrawView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public IntPtr qdPort()
		{
			return Call("qdPort").To<IntPtr>();
		}

		private static Class ms_class = new Class("NSQuickDrawView");
	}
}
