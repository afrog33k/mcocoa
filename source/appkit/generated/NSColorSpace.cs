// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSColorSpace.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSUnknownColorSpaceModel = -1;
		public const int NSGrayColorSpaceModel = 0;
		public const int NSRGBColorSpaceModel = 1;
		public const int NSCMYKColorSpaceModel = 2;
		public const int NSLABColorSpaceModel = 3;
		public const int NSDeviceNColorSpaceModel = 4;
		public const int NSIndexedColorSpaceModel = 5;
		public const int NSPatternColorSpaceModel = 6;
	}

	[Register]
	public partial class NSColorSpace : NSObject
	{
		public NSColorSpace() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSColorSpace(IntPtr instance) : base(instance)
		{
		}

		public NSColorSpace(Untyped instance) : base(instance)
		{
		}

		public static new NSColorSpace alloc()
		{
			return new NSColorSpace(ms_class.Call("alloc"));
		}

		public new NSColorSpace retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithICCProfileData(NSData iccData)
		{
			return Call("initWithICCProfileData:", iccData).To<NSObject>();
		}

		public NSData ICCProfileData()
		{
			return Call("ICCProfileData").To<NSData>();
		}

		public NSObject initWithColorSyncProfile(IntPtr prof)
		{
			return Call("initWithColorSyncProfile:", prof).To<NSObject>();
		}

		public IntPtr colorSyncProfile()
		{
			return Call("colorSyncProfile").To<IntPtr>();
		}

		public NSObject initWithCGColorSpace(IntPtr cgColorSpace)
		{
			return Call("initWithCGColorSpace:", cgColorSpace).To<NSObject>();
		}

		public IntPtr CGColorSpace()
		{
			return Call("CGColorSpace").To<IntPtr>();
		}

		public Int32 numberOfColorComponents()
		{
			return Call("numberOfColorComponents").To<Int32>();
		}

		public Int32 colorSpaceModel()
		{
			return Call("colorSpaceModel").To<Int32>();
		}

		public NSString localizedName()
		{
			return Call("localizedName").To<NSString>();
		}

		public static NSColorSpace genericRGBColorSpace()
		{
			return ms_class.Call("genericRGBColorSpace").To<NSColorSpace>();
		}

		public static NSColorSpace genericGrayColorSpace()
		{
			return ms_class.Call("genericGrayColorSpace").To<NSColorSpace>();
		}

		public static NSColorSpace genericCMYKColorSpace()
		{
			return ms_class.Call("genericCMYKColorSpace").To<NSColorSpace>();
		}

		public static NSColorSpace deviceRGBColorSpace()
		{
			return ms_class.Call("deviceRGBColorSpace").To<NSColorSpace>();
		}

		public static NSColorSpace deviceGrayColorSpace()
		{
			return ms_class.Call("deviceGrayColorSpace").To<NSColorSpace>();
		}

		public static NSColorSpace deviceCMYKColorSpace()
		{
			return ms_class.Call("deviceCMYKColorSpace").To<NSColorSpace>();
		}

		public static NSColorSpace sRGBColorSpace()
		{
			return ms_class.Call("sRGBColorSpace").To<NSColorSpace>();
		}

		public static NSColorSpace adobeRGB1998ColorSpace()
		{
			return ms_class.Call("adobeRGB1998ColorSpace").To<NSColorSpace>();
		}

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

		private static Class ms_class = new Class("NSColorSpace");
	}
}
