// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSDate.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSDate : NSObject
	{
		public NSDate() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDate(IntPtr instance) : base(instance)
		{
		}

		public NSDate(Untyped instance) : base(instance)
		{
		}

		public static new NSDate alloc()
		{
			return new NSDate(ms_class.Call("alloc"));
		}

		public new NSDate retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public double timeIntervalSinceReferenceDate()
		{
			return Call("timeIntervalSinceReferenceDate").To<double>();
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

		private static Class ms_class = new Class("NSDate");
	}

	public static class NSExtendedDateForNSDateCategory
	{
		public static double timeIntervalSinceDate(this NSDate _instance, NSDate anotherDate)
		{
			return _instance.Call("timeIntervalSinceDate:", anotherDate).To<double>();
		}

		public static double timeIntervalSinceNow(this NSDate _instance)
		{
			return _instance.Call("timeIntervalSinceNow").To<double>();
		}

		public static double timeIntervalSince1970(this NSDate _instance)
		{
			return _instance.Call("timeIntervalSince1970").To<double>();
		}

		public static NSObject addTimeInterval(this NSDate _instance, double seconds)
		{
			return _instance.Call("addTimeInterval:", seconds).To<NSObject>();
		}

		public static NSDate earlierDate(this NSDate _instance, NSDate anotherDate)
		{
			return _instance.Call("earlierDate:", anotherDate).To<NSDate>();
		}

		public static NSDate laterDate(this NSDate _instance, NSDate anotherDate)
		{
			return _instance.Call("laterDate:", anotherDate).To<NSDate>();
		}

		public static Int32 compare(this NSDate _instance, NSDate other)
		{
			return _instance.Call("compare:", other).To<Int32>();
		}

		// skipping description (it's already defined)

		public static bool isEqualToDate(this NSDate _instance, NSDate otherDate)
		{
			return _instance.Call("isEqualToDate:", otherDate).To<bool>();
		}

		public static double timeIntervalSinceReferenceDate(this NSDate _instance)
		{
			return _instance.Call("timeIntervalSinceReferenceDate").To<double>();
		}
	}

	public static class NSDateCreationForNSDateCategory
	{
		public static NSObject date(this NSDate _instance)
		{
			return _instance.Call("date").To<NSObject>();
		}

		public static NSObject dateWithTimeIntervalSinceNow(this NSDate _instance, double secs)
		{
			return _instance.Call("dateWithTimeIntervalSinceNow:", secs).To<NSObject>();
		}

		public static NSObject dateWithTimeIntervalSinceReferenceDate(this NSDate _instance, double secs)
		{
			return _instance.Call("dateWithTimeIntervalSinceReferenceDate:", secs).To<NSObject>();
		}

		public static NSObject dateWithTimeIntervalSince1970(this NSDate _instance, double secs)
		{
			return _instance.Call("dateWithTimeIntervalSince1970:", secs).To<NSObject>();
		}

		public static NSObject distantFuture(this NSDate _instance)
		{
			return _instance.Call("distantFuture").To<NSObject>();
		}

		public static NSObject distantPast(this NSDate _instance)
		{
			return _instance.Call("distantPast").To<NSObject>();
		}

		// skipping init (it's already defined)

		public static NSObject initWithTimeIntervalSinceReferenceDate(this NSDate _instance, double secsToBeAdded)
		{
			return _instance.Call("initWithTimeIntervalSinceReferenceDate:", secsToBeAdded).To<NSObject>();
		}

		public static NSObject initWithTimeIntervalSinceDate(this NSDate _instance, double secsToBeAdded, NSDate anotherDate)
		{
			return _instance.Call("initWithTimeInterval:sinceDate:", secsToBeAdded, anotherDate).To<NSObject>();
		}

		public static NSObject initWithTimeIntervalSinceNow(this NSDate _instance, double secsToBeAddedToNow)
		{
			return _instance.Call("initWithTimeIntervalSinceNow:", secsToBeAddedToNow).To<NSObject>();
		}
	}
}
