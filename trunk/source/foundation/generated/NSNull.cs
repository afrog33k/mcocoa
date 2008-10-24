// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSNull.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSNull : NSObject
	{
		public NSNull() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNull(IntPtr instance) : base(instance)
		{
		}

		public NSNull(Untyped instance) : base(instance)
		{
		}

		public static new NSNull alloc()
		{
			return new NSNull(ms_class.Call("alloc"));
		}

		public new NSNull retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSNull null_()
		{
			return ms_class.Call("null").To<NSNull>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSCoding Methods
		public void encodeWithCoder(NSCoder aCoder)
		{
			Unused.Value = Call("encodeWithCoder:", aCoder);
		}

		public NSObject initWithCoder(NSCoder aDecoder)
		{
			return Call("initWithCoder:", aDecoder).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSNull");
	}
}
