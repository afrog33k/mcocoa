// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPredicate.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPredicate : NSObject
	{
		public NSPredicate() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPredicate(IntPtr instance) : base(instance)
		{
		}

		public NSPredicate(Untyped instance) : base(instance)
		{
		}

		public static new NSPredicate alloc()
		{
			return new NSPredicate(ms_class.Call("alloc"));
		}

		public new NSPredicate retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSPredicate predicateWithFormatArgumentArray(NSString predicateFormat, NSArray arguments)
		{
			return ms_class.Call("predicateWithFormat:argumentArray:", predicateFormat, arguments).To<NSPredicate>();
		}

		// skipping predicateWithFormat: because it is variadic

		public static NSPredicate predicateWithFormatArguments(NSString predicateFormat, IntPtr argList)
		{
			return ms_class.Call("predicateWithFormat:arguments:", predicateFormat, argList).To<NSPredicate>();
		}

		public static NSPredicate predicateWithValue(bool value)
		{
			return ms_class.Call("predicateWithValue:", value).To<NSPredicate>();
		}

		public NSString predicateFormat()
		{
			return Call("predicateFormat").To<NSString>();
		}

		public NSPredicate predicateWithSubstitutionVariables(NSDictionary variables)
		{
			return Call("predicateWithSubstitutionVariables:", variables).To<NSPredicate>();
		}

		public bool evaluateWithObject(NSObject object_)
		{
			return Call("evaluateWithObject:", object_).To<bool>();
		}

		public bool evaluateWithObjectSubstitutionVariables(NSObject object_, NSDictionary bindings)
		{
			return Call("evaluateWithObject:substitutionVariables:", object_, bindings).To<bool>();
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

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSPredicate");
	}

	public static class NSPredicateSupportForNSArrayCategory
	{
		public static NSArray filteredArrayUsingPredicate(this NSArray _instance, NSPredicate predicate)
		{
			return _instance.Call("filteredArrayUsingPredicate:", predicate).To<NSArray>();
		}
	}

	public static class NSPredicateSupportForNSMutableArrayCategory
	{
		public static void filterUsingPredicate(this NSMutableArray _instance, NSPredicate predicate)
		{
			Unused.Value = _instance.Call("filterUsingPredicate:", predicate);
		}
	}

	public static class NSPredicateSupportForNSSetCategory
	{
		public static NSSet filteredSetUsingPredicate(this NSSet _instance, NSPredicate predicate)
		{
			return _instance.Call("filteredSetUsingPredicate:", predicate).To<NSSet>();
		}
	}

	public static class NSPredicateSupportForNSMutableSetCategory
	{
		public static void filterUsingPredicate(this NSMutableSet _instance, NSPredicate predicate)
		{
			Unused.Value = _instance.Call("filterUsingPredicate:", predicate);
		}
	}
}
