// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSTimeZone.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTimeZoneNameStyleStandard = 0;
		public const int NSTimeZoneNameStyleShortStandard = 1;
		public const int NSTimeZoneNameStyleDaylightSaving = 2;
		public const int NSTimeZoneNameStyleShortDaylightSaving = 3;
	}

	[Register]
	public partial class NSTimeZone : NSObject
	{
		public NSTimeZone() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTimeZone(IntPtr instance) : base(instance)
		{
		}

		public NSTimeZone(Untyped instance) : base(instance)
		{
		}

		public static new NSTimeZone alloc()
		{
			return new NSTimeZone(ms_class.Call("alloc"));
		}

		public new NSTimeZone retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public NSData data()
		{
			return Call("data").To<NSData>();
		}

		public Int32 secondsFromGMTForDate(NSDate aDate)
		{
			return Call("secondsFromGMTForDate:", aDate).To<Int32>();
		}

		public NSString abbreviationForDate(NSDate aDate)
		{
			return Call("abbreviationForDate:", aDate).To<NSString>();
		}

		public bool isDaylightSavingTimeForDate(NSDate aDate)
		{
			return Call("isDaylightSavingTimeForDate:", aDate).To<bool>();
		}

		public double daylightSavingTimeOffsetForDateAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSDate aDate)
		{
			return Call("daylightSavingTimeOffsetForDate:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", aDate).To<double>();
		}

		public NSDate nextDaylightSavingTimeTransitionAfterDateAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSDate aDate)
		{
			return Call("nextDaylightSavingTimeTransitionAfterDate:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", aDate).To<NSDate>();
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

		private static Class ms_class = new Class("NSTimeZone");
	}

	public static class NSExtendedTimeZoneForNSTimeZoneCategory
	{
		public static NSTimeZone systemTimeZone(this NSTimeZone _instance)
		{
			return _instance.Call("systemTimeZone").To<NSTimeZone>();
		}

		public static void resetSystemTimeZone(this NSTimeZone _instance)
		{
			Unused.Value = _instance.Call("resetSystemTimeZone");
		}

		public static NSTimeZone defaultTimeZone(this NSTimeZone _instance)
		{
			return _instance.Call("defaultTimeZone").To<NSTimeZone>();
		}

		public static void setDefaultTimeZone(this NSTimeZone _instance, NSTimeZone aTimeZone)
		{
			Unused.Value = _instance.Call("setDefaultTimeZone:", aTimeZone);
		}

		public static NSTimeZone localTimeZone(this NSTimeZone _instance)
		{
			return _instance.Call("localTimeZone").To<NSTimeZone>();
		}

		public static NSArray knownTimeZoneNames(this NSTimeZone _instance)
		{
			return _instance.Call("knownTimeZoneNames").To<NSArray>();
		}

		public static NSDictionary abbreviationDictionary(this NSTimeZone _instance)
		{
			return _instance.Call("abbreviationDictionary").To<NSDictionary>();
		}

		public static Int32 secondsFromGMT(this NSTimeZone _instance)
		{
			return _instance.Call("secondsFromGMT").To<Int32>();
		}

		public static NSString abbreviation(this NSTimeZone _instance)
		{
			return _instance.Call("abbreviation").To<NSString>();
		}

		public static bool isDaylightSavingTime(this NSTimeZone _instance)
		{
			return _instance.Call("isDaylightSavingTime").To<bool>();
		}

		public static double daylightSavingTimeOffsetAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSTimeZone _instance)
		{
			return _instance.Call("daylightSavingTimeOffsetAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<double>();
		}

		public static NSDate nextDaylightSavingTimeTransitionAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSTimeZone _instance)
		{
			return _instance.Call("nextDaylightSavingTimeTransitionAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSDate>();
		}

		// skipping description (it's already defined)

		public static bool isEqualToTimeZone(this NSTimeZone _instance, NSTimeZone aTimeZone)
		{
			return _instance.Call("isEqualToTimeZone:", aTimeZone).To<bool>();
		}

		public static NSString localizedNameLocaleAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSTimeZone _instance, Int32 style, NSLocale locale)
		{
			return _instance.Call("localizedName:locale:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", style, locale).To<NSString>();
		}
	}

	public static class NSTimeZoneCreationForNSTimeZoneCategory
	{
		public static NSObject timeZoneWithName(this NSTimeZone _instance, NSString tzName)
		{
			return _instance.Call("timeZoneWithName:", tzName).To<NSObject>();
		}

		public static NSObject timeZoneWithNameData(this NSTimeZone _instance, NSString tzName, NSData aData)
		{
			return _instance.Call("timeZoneWithName:data:", tzName, aData).To<NSObject>();
		}

		public static NSObject initWithName(this NSTimeZone _instance, NSString tzName)
		{
			return _instance.Call("initWithName:", tzName).To<NSObject>();
		}

		public static NSObject initWithNameData(this NSTimeZone _instance, NSString tzName, NSData aData)
		{
			return _instance.Call("initWithName:data:", tzName, aData).To<NSObject>();
		}

		public static NSObject timeZoneForSecondsFromGMT(this NSTimeZone _instance, Int32 seconds)
		{
			return _instance.Call("timeZoneForSecondsFromGMT:", seconds).To<NSObject>();
		}

		public static NSObject timeZoneWithAbbreviation(this NSTimeZone _instance, NSString abbreviation)
		{
			return _instance.Call("timeZoneWithAbbreviation:", abbreviation).To<NSObject>();
		}
	}
}
