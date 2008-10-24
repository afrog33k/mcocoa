// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScanner.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSScanner : NSObject
	{
		public NSScanner() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScanner(IntPtr instance) : base(instance)
		{
		}

		public NSScanner(Untyped instance) : base(instance)
		{
		}

		public static new NSScanner alloc()
		{
			return new NSScanner(ms_class.Call("alloc"));
		}

		public new NSScanner retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString string_()
		{
			return Call("string").To<NSString>();
		}

		public UInt32 scanLocation()
		{
			return Call("scanLocation").To<UInt32>();
		}

		public void setScanLocation(UInt32 pos)
		{
			Unused.Value = Call("setScanLocation:", pos);
		}

		public void setCharactersToBeSkipped(NSCharacterSet set_)
		{
			Unused.Value = Call("setCharactersToBeSkipped:", set_);
		}

		public void setCaseSensitive(bool flag)
		{
			Unused.Value = Call("setCaseSensitive:", flag);
		}

		public void setLocale(NSObject locale)
		{
			Unused.Value = Call("setLocale:", locale);
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSScanner");
	}

	public static class NSExtendedScannerForNSScannerCategory
	{
		public static NSCharacterSet charactersToBeSkipped(this NSScanner _instance)
		{
			return _instance.Call("charactersToBeSkipped").To<NSCharacterSet>();
		}

		public static bool caseSensitive(this NSScanner _instance)
		{
			return _instance.Call("caseSensitive").To<bool>();
		}

		public static NSObject locale(this NSScanner _instance)
		{
			return _instance.Call("locale").To<NSObject>();
		}

		public static bool scanInt(this NSScanner _instance, IntPtr value)
		{
			return _instance.Call("scanInt:", value).To<bool>();
		}

		public static bool scanInteger(this NSScanner _instance, IntPtr value)
		{
			return _instance.Call("scanInteger:", value).To<bool>();
		}

		public static bool scanHexLongLong(this NSScanner _instance, IntPtr result)
		{
			return _instance.Call("scanHexLongLong:", result).To<bool>();
		}

		public static bool scanHexFloat(this NSScanner _instance, IntPtr result)
		{
			return _instance.Call("scanHexFloat:", result).To<bool>();
		}

		public static bool scanHexDouble(this NSScanner _instance, IntPtr result)
		{
			return _instance.Call("scanHexDouble:", result).To<bool>();
		}

		public static bool scanHexInt(this NSScanner _instance, IntPtr value)
		{
			return _instance.Call("scanHexInt:", value).To<bool>();
		}

		public static bool scanLongLong(this NSScanner _instance, IntPtr value)
		{
			return _instance.Call("scanLongLong:", value).To<bool>();
		}

		public static bool scanFloat(this NSScanner _instance, IntPtr value)
		{
			return _instance.Call("scanFloat:", value).To<bool>();
		}

		public static bool scanDouble(this NSScanner _instance, IntPtr value)
		{
			return _instance.Call("scanDouble:", value).To<bool>();
		}

		public static bool scanStringIntoString(this NSScanner _instance, NSString string_, IntPtr value)
		{
			return _instance.Call("scanString:intoString:", string_, value).To<bool>();
		}

		public static bool scanCharactersFromSetIntoString(this NSScanner _instance, NSCharacterSet set_, IntPtr value)
		{
			return _instance.Call("scanCharactersFromSet:intoString:", set_, value).To<bool>();
		}

		public static bool scanUpToStringIntoString(this NSScanner _instance, NSString string_, IntPtr value)
		{
			return _instance.Call("scanUpToString:intoString:", string_, value).To<bool>();
		}

		public static bool scanUpToCharactersFromSetIntoString(this NSScanner _instance, NSCharacterSet set_, IntPtr value)
		{
			return _instance.Call("scanUpToCharactersFromSet:intoString:", set_, value).To<bool>();
		}

		public static bool isAtEnd(this NSScanner _instance)
		{
			return _instance.Call("isAtEnd").To<bool>();
		}

		public static NSObject initWithString(this NSScanner _instance, NSString string_)
		{
			return _instance.Call("initWithString:", string_).To<NSObject>();
		}

		public static NSObject scannerWithString(this NSScanner _instance, NSString string_)
		{
			return _instance.Call("scannerWithString:", string_).To<NSObject>();
		}

		public static NSObject localizedScannerWithString(this NSScanner _instance, NSString string_)
		{
			return _instance.Call("localizedScannerWithString:", string_).To<NSObject>();
		}
	}
}
