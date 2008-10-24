// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSCalendarDate.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSCalendarDate : NSDate
	{
		public NSCalendarDate() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCalendarDate(IntPtr instance) : base(instance)
		{
		}

		public NSCalendarDate(Untyped instance) : base(instance)
		{
		}

		public static new NSCalendarDate alloc()
		{
			return new NSCalendarDate(ms_class.Call("alloc"));
		}

		public new NSCalendarDate retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject dateWithYearMonthDayHourMinuteSecondTimeZone(Int32 year, UInt32 month, UInt32 day, UInt32 hour, UInt32 minute, UInt32 second, NSTimeZone aTimeZone)
		{
			return ms_class.Call("dateWithYear:month:day:hour:minute:second:timeZone:", year, month, day, hour, minute, second, aTimeZone).To<NSObject>();
		}

		public static NSObject dateWithStringCalendarFormat(NSString description, NSString format)
		{
			return ms_class.Call("dateWithString:calendarFormat:", description, format).To<NSObject>();
		}

		public static NSObject dateWithStringCalendarFormatLocale(NSString description, NSString format, NSObject locale)
		{
			return ms_class.Call("dateWithString:calendarFormat:locale:", description, format, locale).To<NSObject>();
		}

		public static NSObject calendarDate()
		{
			return ms_class.Call("calendarDate").To<NSObject>();
		}

		public NSObject initWithYearMonthDayHourMinuteSecondTimeZone(Int32 year, UInt32 month, UInt32 day, UInt32 hour, UInt32 minute, UInt32 second, NSTimeZone aTimeZone)
		{
			return Call("initWithYear:month:day:hour:minute:second:timeZone:", year, month, day, hour, minute, second, aTimeZone).To<NSObject>();
		}

		public NSObject initWithString(NSString description)
		{
			return Call("initWithString:", description).To<NSObject>();
		}

		public NSObject initWithStringCalendarFormat(NSString description, NSString format)
		{
			return Call("initWithString:calendarFormat:", description, format).To<NSObject>();
		}

		public NSObject initWithStringCalendarFormatLocale(NSString description, NSString format, NSObject locale)
		{
			return Call("initWithString:calendarFormat:locale:", description, format, locale).To<NSObject>();
		}

		public NSTimeZone timeZone()
		{
			return Call("timeZone").To<NSTimeZone>();
		}

		public void setTimeZone(NSTimeZone aTimeZone)
		{
			Unused.Value = Call("setTimeZone:", aTimeZone);
		}

		public NSString calendarFormat()
		{
			return Call("calendarFormat").To<NSString>();
		}

		public void setCalendarFormat(NSString format)
		{
			Unused.Value = Call("setCalendarFormat:", format);
		}

		public Int32 yearOfCommonEra()
		{
			return Call("yearOfCommonEra").To<Int32>();
		}

		public Int32 monthOfYear()
		{
			return Call("monthOfYear").To<Int32>();
		}

		public Int32 dayOfMonth()
		{
			return Call("dayOfMonth").To<Int32>();
		}

		public Int32 dayOfWeek()
		{
			return Call("dayOfWeek").To<Int32>();
		}

		public Int32 dayOfYear()
		{
			return Call("dayOfYear").To<Int32>();
		}

		public Int32 dayOfCommonEra()
		{
			return Call("dayOfCommonEra").To<Int32>();
		}

		public Int32 hourOfDay()
		{
			return Call("hourOfDay").To<Int32>();
		}

		public Int32 minuteOfHour()
		{
			return Call("minuteOfHour").To<Int32>();
		}

		public Int32 secondOfMinute()
		{
			return Call("secondOfMinute").To<Int32>();
		}

		public NSCalendarDate dateByAddingYearsMonthsDaysHoursMinutesSeconds(Int32 year, Int32 month, Int32 day, Int32 hour, Int32 minute, Int32 second)
		{
			return Call("dateByAddingYears:months:days:hours:minutes:seconds:", year, month, day, hour, minute, second).To<NSCalendarDate>();
		}

		public void yearsMonthsDaysHoursMinutesSecondsSinceDate(IntPtr yp, IntPtr mop, IntPtr dp, IntPtr hp, IntPtr mip, IntPtr sp, NSCalendarDate date)
		{
			Unused.Value = Call("years:months:days:hours:minutes:seconds:sinceDate:", yp, mop, dp, hp, mip, sp, date);
		}

		// skipping description (it's already defined)

		public NSString descriptionWithLocale(NSObject locale)
		{
			return Call("descriptionWithLocale:", locale).To<NSString>();
		}

		public NSString descriptionWithCalendarFormat(NSString format)
		{
			return Call("descriptionWithCalendarFormat:", format).To<NSString>();
		}

		public NSString descriptionWithCalendarFormatLocale(NSString format, NSObject locale)
		{
			return Call("descriptionWithCalendarFormat:locale:", format, locale).To<NSString>();
		}

		private static Class ms_class = new Class("NSCalendarDate");
	}

	public static class NSCalendarDateExtrasForNSDateCategory
	{
		public static NSObject dateWithString(this NSDate _instance, NSString aString)
		{
			return _instance.Call("dateWithString:", aString).To<NSObject>();
		}

		public static NSObject initWithString(this NSDate _instance, NSString description)
		{
			return _instance.Call("initWithString:", description).To<NSObject>();
		}

		public static NSCalendarDate dateWithCalendarFormatTimeZone(this NSDate _instance, NSString format, NSTimeZone aTimeZone)
		{
			return _instance.Call("dateWithCalendarFormat:timeZone:", format, aTimeZone).To<NSCalendarDate>();
		}

		public static NSString descriptionWithLocale(this NSDate _instance, NSObject locale)
		{
			return _instance.Call("descriptionWithLocale:", locale).To<NSString>();
		}

		public static NSString descriptionWithCalendarFormatTimeZoneLocale(this NSDate _instance, NSString format, NSTimeZone aTimeZone, NSObject locale)
		{
			return _instance.Call("descriptionWithCalendarFormat:timeZone:locale:", format, aTimeZone, locale).To<NSString>();
		}
	}

	public static class NSNaturalLangageForNSDateCategory
	{
	}
}
