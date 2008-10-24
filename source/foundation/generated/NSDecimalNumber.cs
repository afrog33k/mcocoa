// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSDecimalNumber.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSDecimalNumber : NSNumber
	{
		public NSDecimalNumber() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDecimalNumber(IntPtr instance) : base(instance)
		{
		}

		public NSDecimalNumber(Untyped instance) : base(instance)
		{
		}

		public static new NSDecimalNumber alloc()
		{
			return new NSDecimalNumber(ms_class.Call("alloc"));
		}

		public new NSDecimalNumber retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithMantissaExponentIsNegative(UInt64 mantissa, UInt32 exponent, bool flag)
		{
			return Call("initWithMantissa:exponent:isNegative:", mantissa, exponent, flag).To<NSObject>();
		}

		public NSObject initWithDecimal(NSDecimal dcm)
		{
			return Call("initWithDecimal:", dcm).To<NSObject>();
		}

		public NSObject initWithString(NSString numberValue)
		{
			return Call("initWithString:", numberValue).To<NSObject>();
		}

		public NSObject initWithStringLocale(NSString numberValue, NSObject locale)
		{
			return Call("initWithString:locale:", numberValue, locale).To<NSObject>();
		}

		// skipping descriptionWithLocale: (it's declared in a base class)

		public NSDecimal decimalValue()
		{
			return Call("decimalValue").To<NSDecimal>();
		}

		public static NSDecimalNumber decimalNumberWithMantissaExponentIsNegative(UInt64 mantissa, UInt32 exponent, bool flag)
		{
			return ms_class.Call("decimalNumberWithMantissa:exponent:isNegative:", mantissa, exponent, flag).To<NSDecimalNumber>();
		}

		public static NSDecimalNumber decimalNumberWithDecimal(NSDecimal dcm)
		{
			return ms_class.Call("decimalNumberWithDecimal:", dcm).To<NSDecimalNumber>();
		}

		public static NSDecimalNumber decimalNumberWithString(NSString numberValue)
		{
			return ms_class.Call("decimalNumberWithString:", numberValue).To<NSDecimalNumber>();
		}

		public static NSDecimalNumber decimalNumberWithStringLocale(NSString numberValue, NSObject locale)
		{
			return ms_class.Call("decimalNumberWithString:locale:", numberValue, locale).To<NSDecimalNumber>();
		}

		public static NSDecimalNumber zero()
		{
			return ms_class.Call("zero").To<NSDecimalNumber>();
		}

		public static NSDecimalNumber one()
		{
			return ms_class.Call("one").To<NSDecimalNumber>();
		}

		public static NSDecimalNumber minimumDecimalNumber()
		{
			return ms_class.Call("minimumDecimalNumber").To<NSDecimalNumber>();
		}

		public static NSDecimalNumber maximumDecimalNumber()
		{
			return ms_class.Call("maximumDecimalNumber").To<NSDecimalNumber>();
		}

		public static NSDecimalNumber notANumber()
		{
			return ms_class.Call("notANumber").To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByAdding(NSDecimalNumber decimalNumber)
		{
			return Call("decimalNumberByAdding:", decimalNumber).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByAddingWithBehavior(NSDecimalNumber decimalNumber, NSObject behavior)
		{
			return Call("decimalNumberByAdding:withBehavior:", decimalNumber, behavior).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberBySubtracting(NSDecimalNumber decimalNumber)
		{
			return Call("decimalNumberBySubtracting:", decimalNumber).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberBySubtractingWithBehavior(NSDecimalNumber decimalNumber, NSObject behavior)
		{
			return Call("decimalNumberBySubtracting:withBehavior:", decimalNumber, behavior).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByMultiplyingBy(NSDecimalNumber decimalNumber)
		{
			return Call("decimalNumberByMultiplyingBy:", decimalNumber).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByMultiplyingByWithBehavior(NSDecimalNumber decimalNumber, NSObject behavior)
		{
			return Call("decimalNumberByMultiplyingBy:withBehavior:", decimalNumber, behavior).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByDividingBy(NSDecimalNumber decimalNumber)
		{
			return Call("decimalNumberByDividingBy:", decimalNumber).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByDividingByWithBehavior(NSDecimalNumber decimalNumber, NSObject behavior)
		{
			return Call("decimalNumberByDividingBy:withBehavior:", decimalNumber, behavior).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByRaisingToPower(UInt32 power)
		{
			return Call("decimalNumberByRaisingToPower:", power).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByRaisingToPowerWithBehavior(UInt32 power, NSObject behavior)
		{
			return Call("decimalNumberByRaisingToPower:withBehavior:", power, behavior).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByMultiplyingByPowerOf10(UInt32 power)
		{
			return Call("decimalNumberByMultiplyingByPowerOf10:", power).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByMultiplyingByPowerOf10WithBehavior(UInt32 power, NSObject behavior)
		{
			return Call("decimalNumberByMultiplyingByPowerOf10:withBehavior:", power, behavior).To<NSDecimalNumber>();
		}

		public NSDecimalNumber decimalNumberByRoundingAccordingToBehavior(NSObject behavior)
		{
			return Call("decimalNumberByRoundingAccordingToBehavior:", behavior).To<NSDecimalNumber>();
		}

		// skipping compare: (it's declared in a base class)

		public static void setDefaultBehavior(NSObject behavior)
		{
			Unused.Value = ms_class.Call("setDefaultBehavior:", behavior);
		}

		public static NSObject defaultBehavior()
		{
			return ms_class.Call("defaultBehavior").To<NSObject>();
		}

		// skipping objCType (it's declared in a base class)

		// skipping doubleValue (it's declared in a base class)

		private static Class ms_class = new Class("NSDecimalNumber");
	}

	[Register]
	public partial class NSDecimalNumberHandler : NSObject
	{
		public NSDecimalNumberHandler() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDecimalNumberHandler(IntPtr instance) : base(instance)
		{
		}

		public NSDecimalNumberHandler(Untyped instance) : base(instance)
		{
		}

		public static new NSDecimalNumberHandler alloc()
		{
			return new NSDecimalNumberHandler(ms_class.Call("alloc"));
		}

		public new NSDecimalNumberHandler retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject defaultDecimalNumberHandler()
		{
			return ms_class.Call("defaultDecimalNumberHandler").To<NSObject>();
		}

		public NSObject initWithRoundingModeScaleRaiseOnExactnessRaiseOnOverflowRaiseOnUnderflowRaiseOnDivideByZero(UInt32 roundingMode, UInt32 scale, bool exact, bool overflow, bool underflow, bool divideByZero)
		{
			return Call("initWithRoundingMode:scale:raiseOnExactness:raiseOnOverflow:raiseOnUnderflow:raiseOnDivideByZero:", roundingMode, scale, exact, overflow, underflow, divideByZero).To<NSObject>();
		}

		public static NSObject decimalNumberHandlerWithRoundingModeScaleRaiseOnExactnessRaiseOnOverflowRaiseOnUnderflowRaiseOnDivideByZero(UInt32 roundingMode, UInt32 scale, bool exact, bool overflow, bool underflow, bool divideByZero)
		{
			return ms_class.Call("decimalNumberHandlerWithRoundingMode:scale:raiseOnExactness:raiseOnOverflow:raiseOnUnderflow:raiseOnDivideByZero:", roundingMode, scale, exact, overflow, underflow, divideByZero).To<NSObject>();
		}

		#region NSDecimalNumberBehaviors Methods
		public UInt32 roundingMode()
		{
			return Call("roundingMode").To<UInt32>();
		}

		public UInt32 scale()
		{
			return Call("scale").To<UInt32>();
		}

		public NSDecimalNumber exceptionDuringOperationErrorLeftOperandRightOperand(Selector operation, UInt32 error, NSDecimalNumber leftOperand, NSDecimalNumber rightOperand)
		{
			return Call("exceptionDuringOperation:error:leftOperand:rightOperand:", operation, error, leftOperand, rightOperand).To<NSDecimalNumber>();
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

		private static Class ms_class = new Class("NSDecimalNumberHandler");
	}

	public static class NSDecimalNumberExtensionsForNSNumberCategory
	{
		public static NSDecimal decimalValue(this NSNumber _instance)
		{
			return _instance.Call("decimalValue").To<NSDecimal>();
		}
	}

	public static class NSDecimalNumberScanningForNSScannerCategory
	{
		public static bool scanDecimal(this NSScanner _instance, NSDecimal dcm)
		{
			return _instance.Call("scanDecimal:", dcm).To<bool>();
		}
	}
}
