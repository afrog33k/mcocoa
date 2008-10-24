// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSCIImageRep.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSCIImageRep : NSImageRep
	{
		public NSCIImageRep() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCIImageRep(IntPtr instance) : base(instance)
		{
		}

		public NSCIImageRep(Untyped instance) : base(instance)
		{
		}

		public static new NSCIImageRep alloc()
		{
			return new NSCIImageRep(ms_class.Call("alloc"));
		}

		public new NSCIImageRep retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject imageRepWithCIImage(NSObject image)
		{
			return ms_class.Call("imageRepWithCIImage:", image).To<NSObject>();
		}

		public NSObject initWithCIImage(NSObject image)
		{
			return Call("initWithCIImage:", image).To<NSObject>();
		}

		public NSObject CIImage()
		{
			return Call("CIImage").To<NSObject>();
		}

		private static Class ms_class = new Class("NSCIImageRep");
	}

	public static class NSAppKitAdditionsForCIImageCategory
	{
		public static NSObject initWithBitmapImageRep(this CIImage _instance, NSBitmapImageRep bitmapImageRep)
		{
			return _instance.Call("initWithBitmapImageRep:", bitmapImageRep).To<NSObject>();
		}

		public static void drawInRectFromRectOperationFraction(this CIImage _instance, NSRect rect, NSRect fromRect, UInt32 op, float delta)
		{
			Unused.Value = _instance.Call("drawInRect:fromRect:operation:fraction:", rect, fromRect, op, delta);
		}

		public static void drawAtPointFromRectOperationFraction(this CIImage _instance, NSPoint point, NSRect fromRect, UInt32 op, float delta)
		{
			Unused.Value = _instance.Call("drawAtPoint:fromRect:operation:fraction:", point, fromRect, op, delta);
		}
	}
}
