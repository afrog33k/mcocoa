// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSEPSImageRep.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSEPSImageRep : NSImageRep
	{
		public NSEPSImageRep() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSEPSImageRep(IntPtr instance) : base(instance)
		{
		}

		public NSEPSImageRep(Untyped instance) : base(instance)
		{
		}

		public static new NSEPSImageRep alloc()
		{
			return new NSEPSImageRep(ms_class.Call("alloc"));
		}

		public new NSEPSImageRep retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject imageRepWithData(NSData epsData)
		{
			return ms_class.Call("imageRepWithData:", epsData).To<NSObject>();
		}

		public NSObject initWithData(NSData epsData)
		{
			return Call("initWithData:", epsData).To<NSObject>();
		}

		public void prepareGState()
		{
			Unused.Value = Call("prepareGState");
		}

		public NSData EPSRepresentation()
		{
			return Call("EPSRepresentation").To<NSData>();
		}

		public NSRect boundingBox()
		{
			return Call("boundingBox").To<NSRect>();
		}

		private static Class ms_class = new Class("NSEPSImageRep");
	}
}
