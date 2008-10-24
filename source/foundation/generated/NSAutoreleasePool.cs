// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSAutoreleasePool.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSAutoreleasePool : NSObject
	{
		public NSAutoreleasePool() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAutoreleasePool(IntPtr instance) : base(instance)
		{
		}

		public NSAutoreleasePool(Untyped instance) : base(instance)
		{
		}

		public static new NSAutoreleasePool alloc()
		{
			return new NSAutoreleasePool(ms_class.Call("alloc"));
		}

		public new NSAutoreleasePool retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void addObject(NSObject anObject)
		{
			Unused.Value = ms_class.Call("addObject:", anObject);
		}

		// skipping addObject: (it's already defined)

		public void drain()
		{
			Unused.Value = Call("drain");
		}

		private static Class ms_class = new Class("NSAutoreleasePool");
	}
}
