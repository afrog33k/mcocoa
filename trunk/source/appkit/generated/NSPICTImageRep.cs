// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPICTImageRep.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPICTImageRep : NSImageRep
	{
		public NSPICTImageRep() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPICTImageRep(IntPtr instance) : base(instance)
		{
		}

		public NSPICTImageRep(Untyped instance) : base(instance)
		{
		}

		public static new NSPICTImageRep alloc()
		{
			return new NSPICTImageRep(ms_class.Call("alloc"));
		}

		public new NSPICTImageRep retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject imageRepWithData(NSData pictData)
		{
			return ms_class.Call("imageRepWithData:", pictData).To<NSObject>();
		}

		public NSObject initWithData(NSData pictData)
		{
			return Call("initWithData:", pictData).To<NSObject>();
		}

		public NSData PICTRepresentation()
		{
			return Call("PICTRepresentation").To<NSData>();
		}

		public NSRect boundingBox()
		{
			return Call("boundingBox").To<NSRect>();
		}

		private static Class ms_class = new Class("NSPICTImageRep");
	}
}
