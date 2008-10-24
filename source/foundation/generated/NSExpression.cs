// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSExpression.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSConstantValueExpressionType = 0;
		public const int NSEvaluatedObjectExpressionType = 1;
		public const int NSVariableExpressionType = 2;
		public const int NSKeyPathExpressionType = 3;
		public const int NSFunctionExpressionType = 4;
		public const int NSUnionSetExpressionType = 5;
		public const int NSIntersectSetExpressionType = 6;
		public const int NSMinusSetExpressionType = 7;
		public const int NSSubqueryExpressionType = 13;
		public const int NSAggregateExpressionType = 14;
	}

	[Register]
	public partial class NSExpression : NSObject
	{
		public NSExpression() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSExpression(IntPtr instance) : base(instance)
		{
		}

		public NSExpression(Untyped instance) : base(instance)
		{
		}

		public static new NSExpression alloc()
		{
			return new NSExpression(ms_class.Call("alloc"));
		}

		public new NSExpression retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSExpression expressionForConstantValue(NSObject obj)
		{
			return ms_class.Call("expressionForConstantValue:", obj).To<NSExpression>();
		}

		public static NSExpression expressionForEvaluatedObject()
		{
			return ms_class.Call("expressionForEvaluatedObject").To<NSExpression>();
		}

		public static NSExpression expressionForVariable(NSString string_)
		{
			return ms_class.Call("expressionForVariable:", string_).To<NSExpression>();
		}

		public static NSExpression expressionForKeyPath(NSString keyPath)
		{
			return ms_class.Call("expressionForKeyPath:", keyPath).To<NSExpression>();
		}

		public static NSExpression expressionForFunctionArguments(NSString name, NSArray parameters)
		{
			return ms_class.Call("expressionForFunction:arguments:", name, parameters).To<NSExpression>();
		}

		public static NSExpression expressionForAggregate(NSArray subexpressions)
		{
			return ms_class.Call("expressionForAggregate:", subexpressions).To<NSExpression>();
		}

		public static NSExpression expressionForUnionSetWith(NSExpression left, NSExpression right)
		{
			return ms_class.Call("expressionForUnionSet:with:", left, right).To<NSExpression>();
		}

		public static NSExpression expressionForIntersectSetWith(NSExpression left, NSExpression right)
		{
			return ms_class.Call("expressionForIntersectSet:with:", left, right).To<NSExpression>();
		}

		public static NSExpression expressionForMinusSetWith(NSExpression left, NSExpression right)
		{
			return ms_class.Call("expressionForMinusSet:with:", left, right).To<NSExpression>();
		}

		public static NSExpression expressionForSubqueryUsingIteratorVariablePredicate(NSExpression expression, NSString variable, NSObject predicate)
		{
			return ms_class.Call("expressionForSubquery:usingIteratorVariable:predicate:", expression, variable, predicate).To<NSExpression>();
		}

		public static NSExpression expressionForFunctionSelectorNameArguments(NSExpression target, NSString name, NSArray parameters)
		{
			return ms_class.Call("expressionForFunction:selectorName:arguments:", target, name, parameters).To<NSExpression>();
		}

		public NSObject initWithExpressionType(UInt32 type)
		{
			return Call("initWithExpressionType:", type).To<NSObject>();
		}

		public UInt32 expressionType()
		{
			return Call("expressionType").To<UInt32>();
		}

		public NSObject constantValue()
		{
			return Call("constantValue").To<NSObject>();
		}

		public NSString keyPath()
		{
			return Call("keyPath").To<NSString>();
		}

		public NSString function()
		{
			return Call("function").To<NSString>();
		}

		public NSString variable()
		{
			return Call("variable").To<NSString>();
		}

		public NSExpression operand()
		{
			return Call("operand").To<NSExpression>();
		}

		public NSArray arguments()
		{
			return Call("arguments").To<NSArray>();
		}

		public NSObject collection()
		{
			return Call("collection").To<NSObject>();
		}

		public NSPredicate predicate()
		{
			return Call("predicate").To<NSPredicate>();
		}

		public NSExpression leftExpression()
		{
			return Call("leftExpression").To<NSExpression>();
		}

		public NSExpression rightExpression()
		{
			return Call("rightExpression").To<NSExpression>();
		}

		public NSObject expressionValueWithObjectContext(NSObject object_, NSMutableDictionary context)
		{
			return Call("expressionValueWithObject:context:", object_, context).To<NSObject>();
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

		private static Class ms_class = new Class("NSExpression");
	}
}
