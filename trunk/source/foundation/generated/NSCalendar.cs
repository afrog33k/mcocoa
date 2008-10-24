// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSCalendar.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSEraCalendarUnit = (1 << 1);
		public const int NSYearCalendarUnit = (1 << 2);
		public const int NSMonthCalendarUnit = (1 << 3);
		public const int NSDayCalendarUnit = (1 << 4);
		public const int NSHourCalendarUnit = (1 << 5);
		public const int NSMinuteCalendarUnit = (1 << 6);
		public const int NSSecondCalendarUnit = (1 << 7);
		public const int NSWeekCalendarUnit = (1 << 8);
		public const int NSWeekdayCalendarUnit = (1 << 9);
		public const int NSWeekdayOrdinalCalendarUnit = (1 << 10);
	}

	public partial class Enums
	{
		public const int NSWrapCalendarComponents = (1 << 0);
	}

	public partial class Enums
	{
		public const int NSUndefinedDateComponent = int.MaxValue;
	}

	[Register]
	public partial class NSCalendar : NSObject
	{
		public NSCalendar() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCalendar(IntPtr instance) : base(instance)
		{
		}

		public NSCalendar(Untyped instance) : base(instance)
		{
		}

		public static new NSCalendar alloc()
		{
			return new NSCalendar(ms_class.Call("alloc"));
		}

		public new NSCalendar retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject currentCalendar()
		{
			return ms_class.Call("currentCalendar").To<NSObject>();
		}

		public static NSObject autoupdatingCurrentCalendarAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return ms_class.Call("autoupdatingCurrentCalendarAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSObject>();
		}

		public NSObject initWithCalendarIdentifier(NSString ident)
		{
			return Call("initWithCalendarIdentifier:", ident).To<NSObject>();
		}

		public NSString calendarIdentifier()
		{
			return Call("calendarIdentifier").To<NSString>();
		}

		public void setLocale(NSLocale locale)
		{
			Unused.Value = Call("setLocale:", locale);
		}

		public NSLocale locale()
		{
			return Call("locale").To<NSLocale>();
		}

		public void setTimeZone(NSTimeZone tz)
		{
			Unused.Value = Call("setTimeZone:", tz);
		}

		public NSTimeZone timeZone()
		{
			return Call("timeZone").To<NSTimeZone>();
		}

		public void setFirstWeekday(UInt32 weekday)
		{
			Unused.Value = Call("setFirstWeekday:", weekday);
		}

		public UInt32 firstWeekday()
		{
			return Call("firstWeekday").To<UInt32>();
		}

		public void setMinimumDaysInFirstWeek(UInt32 mdw)
		{
			Unused.Value = Call("setMinimumDaysInFirstWeek:", mdw);
		}

		public UInt32 minimumDaysInFirstWeek()
		{
			return Call("minimumDaysInFirstWeek").To<UInt32>();
		}

		public NSRange minimumRangeOfUnit(UInt32 unit)
		{
			return Call("minimumRangeOfUnit:", unit).To<NSRange>();
		}

		public NSRange maximumRangeOfUnit(UInt32 unit)
		{
			return Call("maximumRangeOfUnit:", unit).To<NSRange>();
		}

		public NSRange rangeOfUnitInUnitForDate(UInt32 smaller, UInt32 larger, NSDate date)
		{
			return Call("rangeOfUnit:inUnit:forDate:", smaller, larger, date).To<NSRange>();
		}

		public UInt32 ordinalityOfUnitInUnitForDate(UInt32 smaller, UInt32 larger, NSDate date)
		{
			return Call("ordinalityOfUnit:inUnit:forDate:", smaller, larger, date).To<UInt32>();
		}

		public bool rangeOfUnitStartDateIntervalForDateAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(UInt32 unit, IntPtr datep, IntPtr tip, NSDate date)
		{
			return Call("rangeOfUnit:startDate:interval:forDate:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", unit, datep, tip, date).To<bool>();
		}

		public NSDate dateFromComponents(NSDateComponents comps)
		{
			return Call("dateFromComponents:", comps).To<NSDate>();
		}

		public NSDateComponents componentsFromDate(UInt32 unitFlags, NSDate date)
		{
			return Call("components:fromDate:", unitFlags, date).To<NSDateComponents>();
		}

		public NSDate dateByAddingComponentsToDateOptions(NSDateComponents comps, NSDate date, UInt32 opts)
		{
			return Call("dateByAddingComponents:toDate:options:", comps, date, opts).To<NSDate>();
		}

		public NSDateComponents componentsFromDateToDateOptions(UInt32 unitFlags, NSDate startingDate, NSDate resultDate, UInt32 opts)
		{
			return Call("components:fromDate:toDate:options:", unitFlags, startingDate, resultDate, opts).To<NSDateComponents>();
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

		private static Class ms_class = new Class("NSCalendar");
	}

	[Register]
	public partial class NSDateComponents : NSObject
	{
		public NSDateComponents() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDateComponents(IntPtr instance) : base(instance)
		{
		}

		public NSDateComponents(Untyped instance) : base(instance)
		{
		}

		public static new NSDateComponents alloc()
		{
			return new NSDateComponents(ms_class.Call("alloc"));
		}

		public new NSDateComponents retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public Int32 era()
		{
			return Call("era").To<Int32>();
		}

		public Int32 year()
		{
			return Call("year").To<Int32>();
		}

		public Int32 month()
		{
			return Call("month").To<Int32>();
		}

		public Int32 day()
		{
			return Call("day").To<Int32>();
		}

		public Int32 hour()
		{
			return Call("hour").To<Int32>();
		}

		public Int32 minute()
		{
			return Call("minute").To<Int32>();
		}

		public Int32 second()
		{
			return Call("second").To<Int32>();
		}

		public Int32 week()
		{
			return Call("week").To<Int32>();
		}

		public Int32 weekday()
		{
			return Call("weekday").To<Int32>();
		}

		public Int32 weekdayOrdinal()
		{
			return Call("weekdayOrdinal").To<Int32>();
		}

		public void setEra(Int32 v)
		{
			Unused.Value = Call("setEra:", v);
		}

		public void setYear(Int32 v)
		{
			Unused.Value = Call("setYear:", v);
		}

		public void setMonth(Int32 v)
		{
			Unused.Value = Call("setMonth:", v);
		}

		public void setDay(Int32 v)
		{
			Unused.Value = Call("setDay:", v);
		}

		public void setHour(Int32 v)
		{
			Unused.Value = Call("setHour:", v);
		}

		public void setMinute(Int32 v)
		{
			Unused.Value = Call("setMinute:", v);
		}

		public void setSecond(Int32 v)
		{
			Unused.Value = Call("setSecond:", v);
		}

		public void setWeek(Int32 v)
		{
			Unused.Value = Call("setWeek:", v);
		}

		public void setWeekday(Int32 v)
		{
			Unused.Value = Call("setWeekday:", v);
		}

		public void setWeekdayOrdinal(Int32 v)
		{
			Unused.Value = Call("setWeekdayOrdinal:", v);
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

		private static Class ms_class = new Class("NSDateComponents");
	}
}
