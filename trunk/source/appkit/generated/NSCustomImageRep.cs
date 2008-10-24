// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSCustomImageRep.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSCustomImageRep : NSImageRep
	{
		public NSCustomImageRep() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCustomImageRep(IntPtr instance) : base(instance)
		{
		}

		public NSCustomImageRep(Untyped instance) : base(instance)
		{
		}

		public static new NSCustomImageRep alloc()
		{
			return new NSCustomImageRep(ms_class.Call("alloc"));
		}

		public new NSCustomImageRep retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithDrawSelectorDelegate(Selector aMethod, NSObject anObject)
		{
			return Call("initWithDrawSelector:delegate:", aMethod, anObject).To<NSObject>();
		}

		public Selector drawSelector()
		{
			return Call("drawSelector").To<Selector>();
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		private static Class ms_class = new Class("NSCustomImageRep");
	}
}
