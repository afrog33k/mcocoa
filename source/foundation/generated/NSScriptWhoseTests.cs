// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptWhoseTests.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSEqualToComparison = 0;
		public const int NSLessThanOrEqualToComparison = 1;
		public const int NSLessThanComparison = 2;
		public const int NSGreaterThanOrEqualToComparison = 3;
		public const int NSGreaterThanComparison = 4;
		public const int NSBeginsWithComparison = 5;
		public const int NSEndsWithComparison = 6;
		public const int NSContainsComparison = 7;
	}

	[Register]
	public partial class NSScriptWhoseTest : NSObject
	{
		public NSScriptWhoseTest() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScriptWhoseTest(IntPtr instance) : base(instance)
		{
		}

		public NSScriptWhoseTest(Untyped instance) : base(instance)
		{
		}

		public static new NSScriptWhoseTest alloc()
		{
			return new NSScriptWhoseTest(ms_class.Call("alloc"));
		}

		public new NSScriptWhoseTest retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool isTrue()
		{
			return Call("isTrue").To<bool>();
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

		private static Class ms_class = new Class("NSScriptWhoseTest");
	}

	[Register]
	public partial class NSLogicalTest : NSScriptWhoseTest
	{
		public NSLogicalTest() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSLogicalTest(IntPtr instance) : base(instance)
		{
		}

		public NSLogicalTest(Untyped instance) : base(instance)
		{
		}

		public static new NSLogicalTest alloc()
		{
			return new NSLogicalTest(ms_class.Call("alloc"));
		}

		public new NSLogicalTest retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initAndTestWithTests(NSArray subTests)
		{
			return Call("initAndTestWithTests:", subTests).To<NSObject>();
		}

		public NSObject initOrTestWithTests(NSArray subTests)
		{
			return Call("initOrTestWithTests:", subTests).To<NSObject>();
		}

		public NSObject initNotTestWithTest(NSScriptWhoseTest subTest)
		{
			return Call("initNotTestWithTest:", subTest).To<NSObject>();
		}

		private static Class ms_class = new Class("NSLogicalTest");
	}

	[Register]
	public partial class NSSpecifierTest : NSScriptWhoseTest
	{
		public NSSpecifierTest() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSpecifierTest(IntPtr instance) : base(instance)
		{
		}

		public NSSpecifierTest(Untyped instance) : base(instance)
		{
		}

		public static new NSSpecifierTest alloc()
		{
			return new NSSpecifierTest(ms_class.Call("alloc"));
		}

		public new NSSpecifierTest retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithObjectSpecifierComparisonOperatorTestObject(NSScriptObjectSpecifier obj1, UInt32 compOp, NSObject obj2)
		{
			return Call("initWithObjectSpecifier:comparisonOperator:testObject:", obj1, compOp, obj2).To<NSObject>();
		}

		private static Class ms_class = new Class("NSSpecifierTest");
	}

	public static class NSComparisonMethodsForNSObjectCategory
	{
		public static bool isEqualTo(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("isEqualTo:", object_).To<bool>();
		}

		public static bool isLessThanOrEqualTo(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("isLessThanOrEqualTo:", object_).To<bool>();
		}

		public static bool isLessThan(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("isLessThan:", object_).To<bool>();
		}

		public static bool isGreaterThanOrEqualTo(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("isGreaterThanOrEqualTo:", object_).To<bool>();
		}

		public static bool isGreaterThan(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("isGreaterThan:", object_).To<bool>();
		}

		public static bool isNotEqualTo(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("isNotEqualTo:", object_).To<bool>();
		}

		public static bool doesContain(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("doesContain:", object_).To<bool>();
		}

		public static bool isLike(this NSObject _instance, NSString object_)
		{
			return _instance.Call("isLike:", object_).To<bool>();
		}

		public static bool isCaseInsensitiveLike(this NSObject _instance, NSString object_)
		{
			return _instance.Call("isCaseInsensitiveLike:", object_).To<bool>();
		}
	}

	public static class NSScriptingComparisonMethodsForNSObjectCategory
	{
		public static bool scriptingIsEqualTo(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("scriptingIsEqualTo:", object_).To<bool>();
		}

		public static bool scriptingIsLessThanOrEqualTo(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("scriptingIsLessThanOrEqualTo:", object_).To<bool>();
		}

		public static bool scriptingIsLessThan(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("scriptingIsLessThan:", object_).To<bool>();
		}

		public static bool scriptingIsGreaterThanOrEqualTo(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("scriptingIsGreaterThanOrEqualTo:", object_).To<bool>();
		}

		public static bool scriptingIsGreaterThan(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("scriptingIsGreaterThan:", object_).To<bool>();
		}

		public static bool scriptingBeginsWith(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("scriptingBeginsWith:", object_).To<bool>();
		}

		public static bool scriptingEndsWith(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("scriptingEndsWith:", object_).To<bool>();
		}

		public static bool scriptingContains(this NSObject _instance, NSObject object_)
		{
			return _instance.Call("scriptingContains:", object_).To<bool>();
		}
	}
}
