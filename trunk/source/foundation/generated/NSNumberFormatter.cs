// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSNumberFormatter.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNumberFormatterNoStyle = 0;
		public const int NSNumberFormatterDecimalStyle = 1;
		public const int NSNumberFormatterCurrencyStyle = 2;
		public const int NSNumberFormatterPercentStyle = 3;
		public const int NSNumberFormatterScientificStyle = 4;
		public const int NSNumberFormatterSpellOutStyle = 5;
	}

	public partial class Enums
	{
		public const int NSNumberFormatterBehaviorDefault = 0;
		public const int NSNumberFormatterBehavior10_0 = 1000;
		public const int NSNumberFormatterBehavior10_4 = 1040;
	}

	public partial class Enums
	{
		public const int NSNumberFormatterPadBeforePrefix = 0;
		public const int NSNumberFormatterPadAfterPrefix = 1;
		public const int NSNumberFormatterPadBeforeSuffix = 2;
		public const int NSNumberFormatterPadAfterSuffix = 3;
	}

	public partial class Enums
	{
		public const int NSNumberFormatterRoundCeiling = 0;
		public const int NSNumberFormatterRoundFloor = 1;
		public const int NSNumberFormatterRoundDown = 2;
		public const int NSNumberFormatterRoundUp = 3;
		public const int NSNumberFormatterRoundHalfEven = 4;
		public const int NSNumberFormatterRoundHalfDown = 5;
		public const int NSNumberFormatterRoundHalfUp = 6;
	}

	[Register]
	public partial class NSNumberFormatter : NSFormatter
	{
		public NSNumberFormatter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNumberFormatter(IntPtr instance) : base(instance)
		{
		}

		public NSNumberFormatter(Untyped instance) : base(instance)
		{
		}

		public static new NSNumberFormatter alloc()
		{
			return new NSNumberFormatter(ms_class.Call("alloc"));
		}

		public new NSNumberFormatter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public bool getObjectValueForStringRangeError(IntPtr obj, NSString string_, IntPtr rangep, IntPtr error)
		{
			return Call("getObjectValue:forString:range:error:", obj, string_, rangep, error).To<bool>();
		}

		public NSString stringFromNumber(NSNumber number)
		{
			return Call("stringFromNumber:", number).To<NSString>();
		}

		public NSNumber numberFromString(NSString string_)
		{
			return Call("numberFromString:", string_).To<NSNumber>();
		}

		public UInt32 numberStyle()
		{
			return Call("numberStyle").To<UInt32>();
		}

		public void setNumberStyle(UInt32 style)
		{
			Unused.Value = Call("setNumberStyle:", style);
		}

		public NSLocale locale()
		{
			return Call("locale").To<NSLocale>();
		}

		public void setLocale(NSLocale locale)
		{
			Unused.Value = Call("setLocale:", locale);
		}

		public bool generatesDecimalNumbers()
		{
			return Call("generatesDecimalNumbers").To<bool>();
		}

		public void setGeneratesDecimalNumbers(bool b)
		{
			Unused.Value = Call("setGeneratesDecimalNumbers:", b);
		}

		public UInt32 formatterBehavior()
		{
			return Call("formatterBehavior").To<UInt32>();
		}

		public void setFormatterBehavior(UInt32 behavior)
		{
			Unused.Value = Call("setFormatterBehavior:", behavior);
		}

		public static UInt32 defaultFormatterBehavior()
		{
			return ms_class.Call("defaultFormatterBehavior").To<UInt32>();
		}

		public static void setDefaultFormatterBehavior(UInt32 behavior)
		{
			Unused.Value = ms_class.Call("setDefaultFormatterBehavior:", behavior);
		}

		public NSString negativeFormat()
		{
			return Call("negativeFormat").To<NSString>();
		}

		public void setNegativeFormat(NSString format)
		{
			Unused.Value = Call("setNegativeFormat:", format);
		}

		public NSDictionary textAttributesForNegativeValues()
		{
			return Call("textAttributesForNegativeValues").To<NSDictionary>();
		}

		public void setTextAttributesForNegativeValues(NSDictionary newAttributes)
		{
			Unused.Value = Call("setTextAttributesForNegativeValues:", newAttributes);
		}

		public NSString positiveFormat()
		{
			return Call("positiveFormat").To<NSString>();
		}

		public void setPositiveFormat(NSString format)
		{
			Unused.Value = Call("setPositiveFormat:", format);
		}

		public NSDictionary textAttributesForPositiveValues()
		{
			return Call("textAttributesForPositiveValues").To<NSDictionary>();
		}

		public void setTextAttributesForPositiveValues(NSDictionary newAttributes)
		{
			Unused.Value = Call("setTextAttributesForPositiveValues:", newAttributes);
		}

		public bool allowsFloats()
		{
			return Call("allowsFloats").To<bool>();
		}

		public void setAllowsFloats(bool flag)
		{
			Unused.Value = Call("setAllowsFloats:", flag);
		}

		public NSString decimalSeparator()
		{
			return Call("decimalSeparator").To<NSString>();
		}

		public void setDecimalSeparator(NSString string_)
		{
			Unused.Value = Call("setDecimalSeparator:", string_);
		}

		public bool alwaysShowsDecimalSeparator()
		{
			return Call("alwaysShowsDecimalSeparator").To<bool>();
		}

		public void setAlwaysShowsDecimalSeparator(bool b)
		{
			Unused.Value = Call("setAlwaysShowsDecimalSeparator:", b);
		}

		public NSString currencyDecimalSeparator()
		{
			return Call("currencyDecimalSeparator").To<NSString>();
		}

		public void setCurrencyDecimalSeparator(NSString string_)
		{
			Unused.Value = Call("setCurrencyDecimalSeparator:", string_);
		}

		public bool usesGroupingSeparator()
		{
			return Call("usesGroupingSeparator").To<bool>();
		}

		public void setUsesGroupingSeparator(bool b)
		{
			Unused.Value = Call("setUsesGroupingSeparator:", b);
		}

		public NSString groupingSeparator()
		{
			return Call("groupingSeparator").To<NSString>();
		}

		public void setGroupingSeparator(NSString string_)
		{
			Unused.Value = Call("setGroupingSeparator:", string_);
		}

		public NSString zeroSymbol()
		{
			return Call("zeroSymbol").To<NSString>();
		}

		public void setZeroSymbol(NSString string_)
		{
			Unused.Value = Call("setZeroSymbol:", string_);
		}

		public NSDictionary textAttributesForZero()
		{
			return Call("textAttributesForZero").To<NSDictionary>();
		}

		public void setTextAttributesForZero(NSDictionary newAttributes)
		{
			Unused.Value = Call("setTextAttributesForZero:", newAttributes);
		}

		public NSString nilSymbol()
		{
			return Call("nilSymbol").To<NSString>();
		}

		public void setNilSymbol(NSString string_)
		{
			Unused.Value = Call("setNilSymbol:", string_);
		}

		public NSDictionary textAttributesForNil()
		{
			return Call("textAttributesForNil").To<NSDictionary>();
		}

		public void setTextAttributesForNil(NSDictionary newAttributes)
		{
			Unused.Value = Call("setTextAttributesForNil:", newAttributes);
		}

		public NSString notANumberSymbol()
		{
			return Call("notANumberSymbol").To<NSString>();
		}

		public void setNotANumberSymbol(NSString string_)
		{
			Unused.Value = Call("setNotANumberSymbol:", string_);
		}

		public NSDictionary textAttributesForNotANumber()
		{
			return Call("textAttributesForNotANumber").To<NSDictionary>();
		}

		public void setTextAttributesForNotANumber(NSDictionary newAttributes)
		{
			Unused.Value = Call("setTextAttributesForNotANumber:", newAttributes);
		}

		public NSString positiveInfinitySymbol()
		{
			return Call("positiveInfinitySymbol").To<NSString>();
		}

		public void setPositiveInfinitySymbol(NSString string_)
		{
			Unused.Value = Call("setPositiveInfinitySymbol:", string_);
		}

		public NSDictionary textAttributesForPositiveInfinity()
		{
			return Call("textAttributesForPositiveInfinity").To<NSDictionary>();
		}

		public void setTextAttributesForPositiveInfinity(NSDictionary newAttributes)
		{
			Unused.Value = Call("setTextAttributesForPositiveInfinity:", newAttributes);
		}

		public NSString negativeInfinitySymbol()
		{
			return Call("negativeInfinitySymbol").To<NSString>();
		}

		public void setNegativeInfinitySymbol(NSString string_)
		{
			Unused.Value = Call("setNegativeInfinitySymbol:", string_);
		}

		public NSDictionary textAttributesForNegativeInfinity()
		{
			return Call("textAttributesForNegativeInfinity").To<NSDictionary>();
		}

		public void setTextAttributesForNegativeInfinity(NSDictionary newAttributes)
		{
			Unused.Value = Call("setTextAttributesForNegativeInfinity:", newAttributes);
		}

		public NSString positivePrefix()
		{
			return Call("positivePrefix").To<NSString>();
		}

		public void setPositivePrefix(NSString string_)
		{
			Unused.Value = Call("setPositivePrefix:", string_);
		}

		public NSString positiveSuffix()
		{
			return Call("positiveSuffix").To<NSString>();
		}

		public void setPositiveSuffix(NSString string_)
		{
			Unused.Value = Call("setPositiveSuffix:", string_);
		}

		public NSString negativePrefix()
		{
			return Call("negativePrefix").To<NSString>();
		}

		public void setNegativePrefix(NSString string_)
		{
			Unused.Value = Call("setNegativePrefix:", string_);
		}

		public NSString negativeSuffix()
		{
			return Call("negativeSuffix").To<NSString>();
		}

		public void setNegativeSuffix(NSString string_)
		{
			Unused.Value = Call("setNegativeSuffix:", string_);
		}

		public NSString currencyCode()
		{
			return Call("currencyCode").To<NSString>();
		}

		public void setCurrencyCode(NSString string_)
		{
			Unused.Value = Call("setCurrencyCode:", string_);
		}

		public NSString currencySymbol()
		{
			return Call("currencySymbol").To<NSString>();
		}

		public void setCurrencySymbol(NSString string_)
		{
			Unused.Value = Call("setCurrencySymbol:", string_);
		}

		public NSString internationalCurrencySymbol()
		{
			return Call("internationalCurrencySymbol").To<NSString>();
		}

		public void setInternationalCurrencySymbol(NSString string_)
		{
			Unused.Value = Call("setInternationalCurrencySymbol:", string_);
		}

		public NSString percentSymbol()
		{
			return Call("percentSymbol").To<NSString>();
		}

		public void setPercentSymbol(NSString string_)
		{
			Unused.Value = Call("setPercentSymbol:", string_);
		}

		public NSString perMillSymbol()
		{
			return Call("perMillSymbol").To<NSString>();
		}

		public void setPerMillSymbol(NSString string_)
		{
			Unused.Value = Call("setPerMillSymbol:", string_);
		}

		public NSString minusSign()
		{
			return Call("minusSign").To<NSString>();
		}

		public void setMinusSign(NSString string_)
		{
			Unused.Value = Call("setMinusSign:", string_);
		}

		public NSString plusSign()
		{
			return Call("plusSign").To<NSString>();
		}

		public void setPlusSign(NSString string_)
		{
			Unused.Value = Call("setPlusSign:", string_);
		}

		public NSString exponentSymbol()
		{
			return Call("exponentSymbol").To<NSString>();
		}

		public void setExponentSymbol(NSString string_)
		{
			Unused.Value = Call("setExponentSymbol:", string_);
		}

		public UInt32 groupingSize()
		{
			return Call("groupingSize").To<UInt32>();
		}

		public void setGroupingSize(UInt32 number)
		{
			Unused.Value = Call("setGroupingSize:", number);
		}

		public UInt32 secondaryGroupingSize()
		{
			return Call("secondaryGroupingSize").To<UInt32>();
		}

		public void setSecondaryGroupingSize(UInt32 number)
		{
			Unused.Value = Call("setSecondaryGroupingSize:", number);
		}

		public NSNumber multiplier()
		{
			return Call("multiplier").To<NSNumber>();
		}

		public void setMultiplier(NSNumber number)
		{
			Unused.Value = Call("setMultiplier:", number);
		}

		public UInt32 formatWidth()
		{
			return Call("formatWidth").To<UInt32>();
		}

		public void setFormatWidth(UInt32 number)
		{
			Unused.Value = Call("setFormatWidth:", number);
		}

		public NSString paddingCharacter()
		{
			return Call("paddingCharacter").To<NSString>();
		}

		public void setPaddingCharacter(NSString string_)
		{
			Unused.Value = Call("setPaddingCharacter:", string_);
		}

		public UInt32 paddingPosition()
		{
			return Call("paddingPosition").To<UInt32>();
		}

		public void setPaddingPosition(UInt32 position)
		{
			Unused.Value = Call("setPaddingPosition:", position);
		}

		public UInt32 roundingMode()
		{
			return Call("roundingMode").To<UInt32>();
		}

		public void setRoundingMode(UInt32 mode)
		{
			Unused.Value = Call("setRoundingMode:", mode);
		}

		public NSNumber roundingIncrement()
		{
			return Call("roundingIncrement").To<NSNumber>();
		}

		public void setRoundingIncrement(NSNumber number)
		{
			Unused.Value = Call("setRoundingIncrement:", number);
		}

		public UInt32 minimumIntegerDigits()
		{
			return Call("minimumIntegerDigits").To<UInt32>();
		}

		public void setMinimumIntegerDigits(UInt32 number)
		{
			Unused.Value = Call("setMinimumIntegerDigits:", number);
		}

		public UInt32 maximumIntegerDigits()
		{
			return Call("maximumIntegerDigits").To<UInt32>();
		}

		public void setMaximumIntegerDigits(UInt32 number)
		{
			Unused.Value = Call("setMaximumIntegerDigits:", number);
		}

		public UInt32 minimumFractionDigits()
		{
			return Call("minimumFractionDigits").To<UInt32>();
		}

		public void setMinimumFractionDigits(UInt32 number)
		{
			Unused.Value = Call("setMinimumFractionDigits:", number);
		}

		public UInt32 maximumFractionDigits()
		{
			return Call("maximumFractionDigits").To<UInt32>();
		}

		public void setMaximumFractionDigits(UInt32 number)
		{
			Unused.Value = Call("setMaximumFractionDigits:", number);
		}

		public NSNumber minimum()
		{
			return Call("minimum").To<NSNumber>();
		}

		public void setMinimum(NSNumber number)
		{
			Unused.Value = Call("setMinimum:", number);
		}

		public NSNumber maximum()
		{
			return Call("maximum").To<NSNumber>();
		}

		public void setMaximum(NSNumber number)
		{
			Unused.Value = Call("setMaximum:", number);
		}

		public NSString currencyGroupingSeparatorAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("currencyGroupingSeparatorAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSString>();
		}

		public void setCurrencyGroupingSeparatorAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSString string_)
		{
			Unused.Value = Call("setCurrencyGroupingSeparator:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", string_);
		}

		public bool isLenientAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("isLenientAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<bool>();
		}

		public void setLenientAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(bool b)
		{
			Unused.Value = Call("setLenient:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", b);
		}

		public bool usesSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("usesSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<bool>();
		}

		public void setUsesSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(bool b)
		{
			Unused.Value = Call("setUsesSignificantDigits:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", b);
		}

		public UInt32 minimumSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("minimumSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<UInt32>();
		}

		public void setMinimumSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(UInt32 number)
		{
			Unused.Value = Call("setMinimumSignificantDigits:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", number);
		}

		public UInt32 maximumSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("maximumSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<UInt32>();
		}

		public void setMaximumSignificantDigitsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(UInt32 number)
		{
			Unused.Value = Call("setMaximumSignificantDigits:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", number);
		}

		public bool isPartialStringValidationEnabledAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("isPartialStringValidationEnabledAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<bool>();
		}

		public void setPartialStringValidationEnabledAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(bool b)
		{
			Unused.Value = Call("setPartialStringValidationEnabled:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", b);
		}

		private static Class ms_class = new Class("NSNumberFormatter");
	}

	public static class NSNumberFormatterCompatibilityForNSNumberFormatterCategory
	{
		public static bool hasThousandSeparators(this NSNumberFormatter _instance)
		{
			return _instance.Call("hasThousandSeparators").To<bool>();
		}

		public static void setHasThousandSeparators(this NSNumberFormatter _instance, bool flag)
		{
			Unused.Value = _instance.Call("setHasThousandSeparators:", flag);
		}

		public static NSString thousandSeparator(this NSNumberFormatter _instance)
		{
			return _instance.Call("thousandSeparator").To<NSString>();
		}

		public static void setThousandSeparator(this NSNumberFormatter _instance, NSString newSeparator)
		{
			Unused.Value = _instance.Call("setThousandSeparator:", newSeparator);
		}

		public static bool localizesFormat(this NSNumberFormatter _instance)
		{
			return _instance.Call("localizesFormat").To<bool>();
		}

		public static void setLocalizesFormat(this NSNumberFormatter _instance, bool flag)
		{
			Unused.Value = _instance.Call("setLocalizesFormat:", flag);
		}

		public static NSString format(this NSNumberFormatter _instance)
		{
			return _instance.Call("format").To<NSString>();
		}

		public static void setFormat(this NSNumberFormatter _instance, NSString string_)
		{
			Unused.Value = _instance.Call("setFormat:", string_);
		}

		public static NSAttributedString attributedStringForZero(this NSNumberFormatter _instance)
		{
			return _instance.Call("attributedStringForZero").To<NSAttributedString>();
		}

		public static void setAttributedStringForZero(this NSNumberFormatter _instance, NSAttributedString newAttributedString)
		{
			Unused.Value = _instance.Call("setAttributedStringForZero:", newAttributedString);
		}

		public static NSAttributedString attributedStringForNil(this NSNumberFormatter _instance)
		{
			return _instance.Call("attributedStringForNil").To<NSAttributedString>();
		}

		public static void setAttributedStringForNil(this NSNumberFormatter _instance, NSAttributedString newAttributedString)
		{
			Unused.Value = _instance.Call("setAttributedStringForNil:", newAttributedString);
		}

		public static NSAttributedString attributedStringForNotANumber(this NSNumberFormatter _instance)
		{
			return _instance.Call("attributedStringForNotANumber").To<NSAttributedString>();
		}

		public static void setAttributedStringForNotANumber(this NSNumberFormatter _instance, NSAttributedString newAttributedString)
		{
			Unused.Value = _instance.Call("setAttributedStringForNotANumber:", newAttributedString);
		}

		public static NSDecimalNumberHandler roundingBehavior(this NSNumberFormatter _instance)
		{
			return _instance.Call("roundingBehavior").To<NSDecimalNumberHandler>();
		}

		public static void setRoundingBehavior(this NSNumberFormatter _instance, NSDecimalNumberHandler newRoundingBehavior)
		{
			Unused.Value = _instance.Call("setRoundingBehavior:", newRoundingBehavior);
		}

		public static NSDecimalNumber minimum(this NSNumberFormatter _instance)
		{
			return _instance.Call("minimum").To<NSDecimalNumber>();
		}

		public static void setMinimum(this NSNumberFormatter _instance, NSDecimalNumber aMinimum)
		{
			Unused.Value = _instance.Call("setMinimum:", aMinimum);
		}

		public static NSDecimalNumber maximum(this NSNumberFormatter _instance)
		{
			return _instance.Call("maximum").To<NSDecimalNumber>();
		}

		public static void setMaximum(this NSNumberFormatter _instance, NSDecimalNumber aMaximum)
		{
			Unused.Value = _instance.Call("setMaximum:", aMaximum);
		}
	}
}
