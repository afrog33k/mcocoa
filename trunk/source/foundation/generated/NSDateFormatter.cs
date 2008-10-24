// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSDateFormatter.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSDateFormatterNoStyle = 0;
		public const int NSDateFormatterShortStyle = 1;
		public const int NSDateFormatterMediumStyle = 2;
		public const int NSDateFormatterLongStyle = 3;
		public const int NSDateFormatterFullStyle = 4;
	}

	public partial class Enums
	{
		public const int NSDateFormatterBehaviorDefault = 0;
		public const int NSDateFormatterBehavior10_0 = 1000;
		public const int NSDateFormatterBehavior10_4 = 1040;
	}

	[Register]
	public partial class NSDateFormatter : NSFormatter
	{
		public NSDateFormatter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDateFormatter(IntPtr instance) : base(instance)
		{
		}

		public NSDateFormatter(Untyped instance) : base(instance)
		{
		}

		public static new NSDateFormatter alloc()
		{
			return new NSDateFormatter(ms_class.Call("alloc"));
		}

		public new NSDateFormatter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public bool getObjectValueForStringRangeError(IntPtr obj, NSString string_, IntPtr rangep, IntPtr error)
		{
			return Call("getObjectValue:forString:range:error:", obj, string_, rangep, error).To<bool>();
		}

		public NSString stringFromDate(NSDate date)
		{
			return Call("stringFromDate:", date).To<NSString>();
		}

		public NSDate dateFromString(NSString string_)
		{
			return Call("dateFromString:", string_).To<NSDate>();
		}

		public NSString dateFormat()
		{
			return Call("dateFormat").To<NSString>();
		}

		public UInt32 dateStyle()
		{
			return Call("dateStyle").To<UInt32>();
		}

		public void setDateStyle(UInt32 style)
		{
			Unused.Value = Call("setDateStyle:", style);
		}

		public UInt32 timeStyle()
		{
			return Call("timeStyle").To<UInt32>();
		}

		public void setTimeStyle(UInt32 style)
		{
			Unused.Value = Call("setTimeStyle:", style);
		}

		public NSLocale locale()
		{
			return Call("locale").To<NSLocale>();
		}

		public void setLocale(NSLocale locale)
		{
			Unused.Value = Call("setLocale:", locale);
		}

		public bool generatesCalendarDates()
		{
			return Call("generatesCalendarDates").To<bool>();
		}

		public void setGeneratesCalendarDates(bool b)
		{
			Unused.Value = Call("setGeneratesCalendarDates:", b);
		}

		public UInt32 formatterBehavior()
		{
			return Call("formatterBehavior").To<UInt32>();
		}

		public void setFormatterBehavior(UInt32 behavior)
		{
			Unused.Value = Call("setFormatterBehavior:", behavior);
		}

		public static UInt32 defaultFormatterBehavior()
		{
			return ms_class.Call("defaultFormatterBehavior").To<UInt32>();
		}

		public static void setDefaultFormatterBehavior(UInt32 behavior)
		{
			Unused.Value = ms_class.Call("setDefaultFormatterBehavior:", behavior);
		}

		public void setDateFormat(NSString string_)
		{
			Unused.Value = Call("setDateFormat:", string_);
		}

		public NSTimeZone timeZone()
		{
			return Call("timeZone").To<NSTimeZone>();
		}

		public void setTimeZone(NSTimeZone tz)
		{
			Unused.Value = Call("setTimeZone:", tz);
		}

		public NSCalendar calendar()
		{
			return Call("calendar").To<NSCalendar>();
		}

		public void setCalendar(NSCalendar calendar)
		{
			Unused.Value = Call("setCalendar:", calendar);
		}

		public bool isLenient()
		{
			return Call("isLenient").To<bool>();
		}

		public void setLenient(bool b)
		{
			Unused.Value = Call("setLenient:", b);
		}

		public NSDate twoDigitStartDate()
		{
			return Call("twoDigitStartDate").To<NSDate>();
		}

		public void setTwoDigitStartDate(NSDate date)
		{
			Unused.Value = Call("setTwoDigitStartDate:", date);
		}

		public NSDate defaultDate()
		{
			return Call("defaultDate").To<NSDate>();
		}

		public void setDefaultDate(NSDate date)
		{
			Unused.Value = Call("setDefaultDate:", date);
		}

		public NSArray eraSymbols()
		{
			return Call("eraSymbols").To<NSArray>();
		}

		public void setEraSymbols(NSArray array)
		{
			Unused.Value = Call("setEraSymbols:", array);
		}

		public NSArray monthSymbols()
		{
			return Call("monthSymbols").To<NSArray>();
		}

		public void setMonthSymbols(NSArray array)
		{
			Unused.Value = Call("setMonthSymbols:", array);
		}

		public NSArray shortMonthSymbols()
		{
			return Call("shortMonthSymbols").To<NSArray>();
		}

		public void setShortMonthSymbols(NSArray array)
		{
			Unused.Value = Call("setShortMonthSymbols:", array);
		}

		public NSArray weekdaySymbols()
		{
			return Call("weekdaySymbols").To<NSArray>();
		}

		public void setWeekdaySymbols(NSArray array)
		{
			Unused.Value = Call("setWeekdaySymbols:", array);
		}

		public NSArray shortWeekdaySymbols()
		{
			return Call("shortWeekdaySymbols").To<NSArray>();
		}

		public void setShortWeekdaySymbols(NSArray array)
		{
			Unused.Value = Call("setShortWeekdaySymbols:", array);
		}

		public NSString AMSymbol()
		{
			return Call("AMSymbol").To<NSString>();
		}

		public void setAMSymbol(NSString string_)
		{
			Unused.Value = Call("setAMSymbol:", string_);
		}

		public NSString PMSymbol()
		{
			return Call("PMSymbol").To<NSString>();
		}

		public void setPMSymbol(NSString string_)
		{
			Unused.Value = Call("setPMSymbol:", string_);
		}

		public NSArray longEraSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("longEraSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setLongEraSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setLongEraSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray veryShortMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("veryShortMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setVeryShortMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setVeryShortMonthSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray standaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("standaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setStandaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setStandaloneMonthSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray shortStandaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("shortStandaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setShortStandaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setShortStandaloneMonthSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray veryShortStandaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("veryShortStandaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setVeryShortStandaloneMonthSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setVeryShortStandaloneMonthSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray veryShortWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("veryShortWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setVeryShortWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setVeryShortWeekdaySymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray standaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("standaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setStandaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setStandaloneWeekdaySymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray shortStandaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("shortStandaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setShortStandaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setShortStandaloneWeekdaySymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray veryShortStandaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("veryShortStandaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setVeryShortStandaloneWeekdaySymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setVeryShortStandaloneWeekdaySymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray quarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("quarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setQuarterSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray shortQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("shortQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setShortQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setShortQuarterSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray standaloneQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("standaloneQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setStandaloneQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setStandaloneQuarterSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSArray shortStandaloneQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("shortStandaloneQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void setShortStandaloneQuarterSymbolsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSArray array)
		{
			Unused.Value = Call("setShortStandaloneQuarterSymbols:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", array);
		}

		public NSDate gregorianStartDateAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("gregorianStartDateAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSDate>();
		}

		public void setGregorianStartDateAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSDate date)
		{
			Unused.Value = Call("setGregorianStartDate:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", date);
		}

		private static Class ms_class = new Class("NSDateFormatter");
	}

	public static class NSDateFormatterCompatibilityForNSDateFormatterCategory
	{
		public static NSObject initWithDateFormatAllowNaturalLanguage(this NSDateFormatter _instance, NSString format, bool flag)
		{
			return _instance.Call("initWithDateFormat:allowNaturalLanguage:", format, flag).To<NSObject>();
		}

		public static bool allowsNaturalLanguage(this NSDateFormatter _instance)
		{
			return _instance.Call("allowsNaturalLanguage").To<bool>();
		}
	}
}
