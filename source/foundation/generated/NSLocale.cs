// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSLocale.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSLocale : NSObject
	{
		public NSLocale() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSLocale(IntPtr instance) : base(instance)
		{
		}

		public NSLocale(Untyped instance) : base(instance)
		{
		}

		public static new NSLocale alloc()
		{
			return new NSLocale(ms_class.Call("alloc"));
		}

		public new NSLocale retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject objectForKey(NSObject key)
		{
			return Call("objectForKey:", key).To<NSObject>();
		}

		public NSString displayNameForKeyValue(NSObject key, NSObject value)
		{
			return Call("displayNameForKey:value:", key, value).To<NSString>();
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

		private static Class ms_class = new Class("NSLocale");
	}

	public static class NSExtendedLocaleForNSLocaleCategory
	{
		public static NSString localeIdentifier(this NSLocale _instance)
		{
			return _instance.Call("localeIdentifier").To<NSString>();
		}
	}

	public static class NSLocaleCreationForNSLocaleCategory
	{
		public static NSObject systemLocale(this NSLocale _instance)
		{
			return _instance.Call("systemLocale").To<NSObject>();
		}

		public static NSObject currentLocale(this NSLocale _instance)
		{
			return _instance.Call("currentLocale").To<NSObject>();
		}

		public static NSObject autoupdatingCurrentLocaleAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSLocale _instance)
		{
			return _instance.Call("autoupdatingCurrentLocaleAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSObject>();
		}

		public static NSObject initWithLocaleIdentifier(this NSLocale _instance, NSString string_)
		{
			return _instance.Call("initWithLocaleIdentifier:", string_).To<NSObject>();
		}
	}

	public static class NSLocaleGeneralInfoForNSLocaleCategory
	{
		public static NSArray availableLocaleIdentifiers(this NSLocale _instance)
		{
			return _instance.Call("availableLocaleIdentifiers").To<NSArray>();
		}

		public static NSArray ISOLanguageCodes(this NSLocale _instance)
		{
			return _instance.Call("ISOLanguageCodes").To<NSArray>();
		}

		public static NSArray ISOCountryCodes(this NSLocale _instance)
		{
			return _instance.Call("ISOCountryCodes").To<NSArray>();
		}

		public static NSArray ISOCurrencyCodes(this NSLocale _instance)
		{
			return _instance.Call("ISOCurrencyCodes").To<NSArray>();
		}

		public static NSArray commonISOCurrencyCodesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSLocale _instance)
		{
			return _instance.Call("commonISOCurrencyCodesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public static NSArray preferredLanguagesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSLocale _instance)
		{
			return _instance.Call("preferredLanguagesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public static NSDictionary componentsFromLocaleIdentifier(this NSLocale _instance, NSString string_)
		{
			return _instance.Call("componentsFromLocaleIdentifier:", string_).To<NSDictionary>();
		}

		public static NSString localeIdentifierFromComponents(this NSLocale _instance, NSDictionary dict)
		{
			return _instance.Call("localeIdentifierFromComponents:", dict).To<NSString>();
		}

		public static NSString canonicalLocaleIdentifierFromString(this NSLocale _instance, NSString string_)
		{
			return _instance.Call("canonicalLocaleIdentifierFromString:", string_).To<NSString>();
		}
	}
}
