// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSComparisonPredicate.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSCaseInsensitivePredicateOption = 0x01;
		public const int NSDiacriticInsensitivePredicateOption = 0x02;
	}

	public partial class Enums
	{
		public const int NSDirectPredicateModifier = 0;
		public const int NSAllPredicateModifier = 1;
		public const int NSAnyPredicateModifier = 2;
	}

	public partial class Enums
	{
		public const int NSLessThanPredicateOperatorType = 0;
		public const int NSLessThanOrEqualToPredicateOperatorType = 1;
		public const int NSGreaterThanPredicateOperatorType = 2;
		public const int NSGreaterThanOrEqualToPredicateOperatorType = 3;
		public const int NSEqualToPredicateOperatorType = 4;
		public const int NSNotEqualToPredicateOperatorType = 5;
		public const int NSMatchesPredicateOperatorType = 6;
		public const int NSLikePredicateOperatorType = 7;
		public const int NSBeginsWithPredicateOperatorType = 8;
		public const int NSEndsWithPredicateOperatorType = 9;
		public const int NSInPredicateOperatorType = 10;
		public const int NSCustomSelectorPredicateOperatorType = 11;
		public const int NSContainsPredicateOperatorType = 99;
		public const int NSBetweenPredicateOperatorType = 100;
	}

	[Register]
	public partial class NSComparisonPredicate : NSPredicate
	{
		public NSComparisonPredicate() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSComparisonPredicate(IntPtr instance) : base(instance)
		{
		}

		public NSComparisonPredicate(Untyped instance) : base(instance)
		{
		}

		public static new NSComparisonPredicate alloc()
		{
			return new NSComparisonPredicate(ms_class.Call("alloc"));
		}

		public new NSComparisonPredicate retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSPredicate predicateWithLeftExpressionRightExpressionModifierTypeOptions(NSExpression lhs, NSExpression rhs, UInt32 modifier, UInt32 type, UInt32 options)
		{
			return ms_class.Call("predicateWithLeftExpression:rightExpression:modifier:type:options:", lhs, rhs, modifier, type, options).To<NSPredicate>();
		}

		public static NSPredicate predicateWithLeftExpressionRightExpressionCustomSelector(NSExpression lhs, NSExpression rhs, Selector selector)
		{
			return ms_class.Call("predicateWithLeftExpression:rightExpression:customSelector:", lhs, rhs, selector).To<NSPredicate>();
		}

		public NSObject initWithLeftExpressionRightExpressionModifierTypeOptions(NSExpression lhs, NSExpression rhs, UInt32 modifier, UInt32 type, UInt32 options)
		{
			return Call("initWithLeftExpression:rightExpression:modifier:type:options:", lhs, rhs, modifier, type, options).To<NSObject>();
		}

		public NSObject initWithLeftExpressionRightExpressionCustomSelector(NSExpression lhs, NSExpression rhs, Selector selector)
		{
			return Call("initWithLeftExpression:rightExpression:customSelector:", lhs, rhs, selector).To<NSObject>();
		}

		public UInt32 predicateOperatorType()
		{
			return Call("predicateOperatorType").To<UInt32>();
		}

		public UInt32 comparisonPredicateModifier()
		{
			return Call("comparisonPredicateModifier").To<UInt32>();
		}

		public NSExpression leftExpression()
		{
			return Call("leftExpression").To<NSExpression>();
		}

		public NSExpression rightExpression()
		{
			return Call("rightExpression").To<NSExpression>();
		}

		public Selector customSelector()
		{
			return Call("customSelector").To<Selector>();
		}

		public UInt32 options()
		{
			return Call("options").To<UInt32>();
		}

		private static Class ms_class = new Class("NSComparisonPredicate");
	}
}
