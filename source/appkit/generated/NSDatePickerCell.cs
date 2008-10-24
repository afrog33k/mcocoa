// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDatePickerCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTextFieldAndStepperDatePickerStyle = 0;
		public const int NSClockAndCalendarDatePickerStyle = 1;
		public const int NSTextFieldDatePickerStyle = 2;
	}

	public partial class Enums
	{
		public const int NSSingleDateMode = 0;
		public const int NSRangeDateMode = 1;
	}

	public partial class Enums
	{
		public const int NSHourMinuteDatePickerElementFlag = 0x000c;
		public const int NSHourMinuteSecondDatePickerElementFlag = 0x000e;
		public const int NSTimeZoneDatePickerElementFlag = 0x0010;
		public const int NSYearMonthDatePickerElementFlag = 0x00c0;
		public const int NSYearMonthDayDatePickerElementFlag = 0x00e0;
		public const int NSEraDatePickerElementFlag = 0x0100;
	}

	[Register]
	public partial class NSDatePickerCell : NSActionCell
	{
		public NSDatePickerCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDatePickerCell(IntPtr instance) : base(instance)
		{
		}

		public NSDatePickerCell(Untyped instance) : base(instance)
		{
		}

		public static new NSDatePickerCell alloc()
		{
			return new NSDatePickerCell(ms_class.Call("alloc"));
		}

		public new NSDatePickerCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 datePickerStyle()
		{
			return Call("datePickerStyle").To<UInt32>();
		}

		public void setDatePickerStyle(UInt32 newStyle)
		{
			Unused.Value = Call("setDatePickerStyle:", newStyle);
		}

		public bool drawsBackground()
		{
			return Call("drawsBackground").To<bool>();
		}

		public void setDrawsBackground(bool flag)
		{
			Unused.Value = Call("setDrawsBackground:", flag);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor textColor()
		{
			return Call("textColor").To<NSColor>();
		}

		public void setTextColor(NSColor color)
		{
			Unused.Value = Call("setTextColor:", color);
		}

		public UInt32 datePickerMode()
		{
			return Call("datePickerMode").To<UInt32>();
		}

		public void setDatePickerMode(UInt32 newMode)
		{
			Unused.Value = Call("setDatePickerMode:", newMode);
		}

		public UInt32 datePickerElements()
		{
			return Call("datePickerElements").To<UInt32>();
		}

		public void setDatePickerElements(UInt32 elementFlags)
		{
			Unused.Value = Call("setDatePickerElements:", elementFlags);
		}

		public NSCalendar calendar()
		{
			return Call("calendar").To<NSCalendar>();
		}

		public void setCalendar(NSCalendar newCalendar)
		{
			Unused.Value = Call("setCalendar:", newCalendar);
		}

		public NSLocale locale()
		{
			return Call("locale").To<NSLocale>();
		}

		public void setLocale(NSLocale newLocale)
		{
			Unused.Value = Call("setLocale:", newLocale);
		}

		public NSTimeZone timeZone()
		{
			return Call("timeZone").To<NSTimeZone>();
		}

		public void setTimeZone(NSTimeZone newTimeZone)
		{
			Unused.Value = Call("setTimeZone:", newTimeZone);
		}

		public NSDate dateValue()
		{
			return Call("dateValue").To<NSDate>();
		}

		public void setDateValue(NSDate newStartDate)
		{
			Unused.Value = Call("setDateValue:", newStartDate);
		}

		public double timeInterval()
		{
			return Call("timeInterval").To<double>();
		}

		public void setTimeInterval(double newTimeInterval)
		{
			Unused.Value = Call("setTimeInterval:", newTimeInterval);
		}

		public NSDate minDate()
		{
			return Call("minDate").To<NSDate>();
		}

		public void setMinDate(NSDate date)
		{
			Unused.Value = Call("setMinDate:", date);
		}

		public NSDate maxDate()
		{
			return Call("maxDate").To<NSDate>();
		}

		public void setMaxDate(NSDate date)
		{
			Unused.Value = Call("setMaxDate:", date);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		private static Class ms_class = new Class("NSDatePickerCell");
	}

	public static class NSDatePickerCellDelegateForNSObjectCategory
	{
		public static void datePickerCellValidateProposedDateValueTimeInterval(this NSObject _instance, NSDatePickerCell aDatePickerCell, IntPtr proposedDateValue, IntPtr proposedTimeInterval)
		{
			Unused.Value = _instance.Call("datePickerCell:validateProposedDateValue:timeInterval:", aDatePickerCell, proposedDateValue, proposedTimeInterval);
		}
	}
}
