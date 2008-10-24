// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDatePicker.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSDatePicker : NSControl
	{
		public NSDatePicker() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDatePicker(IntPtr instance) : base(instance)
		{
		}

		public NSDatePicker(Untyped instance) : base(instance)
		{
		}

		public static new NSDatePicker alloc()
		{
			return new NSDatePicker(ms_class.Call("alloc"));
		}

		public new NSDatePicker retain()
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

		public bool isBezeled()
		{
			return Call("isBezeled").To<bool>();
		}

		public void setBezeled(bool flag)
		{
			Unused.Value = Call("setBezeled:", flag);
		}

		public bool isBordered()
		{
			return Call("isBordered").To<bool>();
		}

		public void setBordered(bool flag)
		{
			Unused.Value = Call("setBordered:", flag);
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

		private static Class ms_class = new Class("NSDatePicker");
	}
}
