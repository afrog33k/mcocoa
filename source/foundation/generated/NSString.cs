// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSString.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSCaseInsensitiveSearch = 1;
		public const int NSLiteralSearch = 2;
		public const int NSBackwardsSearch = 4;
		public const int NSAnchoredSearch = 8;
		public const int NSNumericSearch = 64;
		public const int NSDiacriticInsensitiveSearch = 128;
		public const int NSWidthInsensitiveSearch = 256;
		public const int NSForcedOrderingSearch = 512;
	}

	public partial class Enums
	{
		public const int NSASCIIStringEncoding = 1;
		public const int NSNEXTSTEPStringEncoding = 2;
		public const int NSJapaneseEUCStringEncoding = 3;
		public const int NSUTF8StringEncoding = 4;
		public const int NSISOLatin1StringEncoding = 5;
		public const int NSSymbolStringEncoding = 6;
		public const int NSNonLossyASCIIStringEncoding = 7;
		public const int NSShiftJISStringEncoding = 8;
		public const int NSISOLatin2StringEncoding = 9;
		public const int NSUnicodeStringEncoding = 10;
		public const int NSWindowsCP1251StringEncoding = 11;
		public const int NSWindowsCP1252StringEncoding = 12;
		public const int NSWindowsCP1253StringEncoding = 13;
		public const int NSWindowsCP1254StringEncoding = 14;
		public const int NSWindowsCP1250StringEncoding = 15;
		public const int NSISO2022JPStringEncoding = 21;
		public const int NSMacOSRomanStringEncoding = 30;
		public const int NSUTF16StringEncoding = NSUnicodeStringEncoding;
		public const uint NSUTF16BigEndianStringEncoding = 0x90000100;
		public const uint NSUTF16LittleEndianStringEncoding = 0x94000100;
		public const uint NSUTF32StringEncoding = 0x8c000100;
		public const uint NSUTF32BigEndianStringEncoding = 0x98000100;
		public const uint NSUTF32LittleEndianStringEncoding = 0x9c000100;
	}

	public partial class Enums
	{
		public const int NSStringEncodingConversionAllowLossy = 1;
		public const int NSStringEncodingConversionExternalRepresentation = 2;
	}

	public partial class Enums
	{
		public const int NSProprietaryStringEncoding = 65536;
	}

	[Register]
	public partial class NSString : NSObject
	{
		public NSString() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSString(IntPtr instance) : base(instance)
		{
		}

		public NSString(Untyped instance) : base(instance)
		{
		}

		public static new NSString alloc()
		{
			return new NSString(ms_class.Call("alloc"));
		}

		public new NSString retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 length()
		{
			return Call("length").To<UInt32>();
		}

		public char characterAtIndex(UInt32 index)
		{
			return Call("characterAtIndex:", index).To<char>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSMutableCopying Methods
		public NSObject mutableCopyWithZone(IntPtr zone)
		{
			return Call("mutableCopyWithZone:", zone).To<NSObject>();
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

		private static Class ms_class = new Class("NSString");
	}

	public static class NSStringExtensionMethodsForNSStringCategory
	{
		public static void getCharacters(this NSString _instance, IntPtr buffer)
		{
			Unused.Value = _instance.Call("getCharacters:", buffer);
		}

		// skipping getCharacters:range: because there is a hand-written version

		public static NSString substringFromIndex(this NSString _instance, UInt32 from_)
		{
			return _instance.Call("substringFromIndex:", from_).To<NSString>();
		}

		public static NSString substringToIndex(this NSString _instance, UInt32 to)
		{
			return _instance.Call("substringToIndex:", to).To<NSString>();
		}

		public static NSString substringWithRange(this NSString _instance, NSRange range)
		{
			return _instance.Call("substringWithRange:", range).To<NSString>();
		}

		public static Int32 compare(this NSString _instance, NSString string_)
		{
			return _instance.Call("compare:", string_).To<Int32>();
		}

		public static Int32 compareOptions(this NSString _instance, NSString string_, UInt32 mask)
		{
			return _instance.Call("compare:options:", string_, mask).To<Int32>();
		}

		public static Int32 compareOptionsRange(this NSString _instance, NSString string_, UInt32 mask, NSRange compareRange)
		{
			return _instance.Call("compare:options:range:", string_, mask, compareRange).To<Int32>();
		}

		public static Int32 compareOptionsRangeLocale(this NSString _instance, NSString string_, UInt32 mask, NSRange compareRange, NSObject locale)
		{
			return _instance.Call("compare:options:range:locale:", string_, mask, compareRange, locale).To<Int32>();
		}

		public static Int32 caseInsensitiveCompare(this NSString _instance, NSString string_)
		{
			return _instance.Call("caseInsensitiveCompare:", string_).To<Int32>();
		}

		public static Int32 localizedCompare(this NSString _instance, NSString string_)
		{
			return _instance.Call("localizedCompare:", string_).To<Int32>();
		}

		public static Int32 localizedCaseInsensitiveCompare(this NSString _instance, NSString string_)
		{
			return _instance.Call("localizedCaseInsensitiveCompare:", string_).To<Int32>();
		}

		public static bool isEqualToString(this NSString _instance, NSString aString)
		{
			return _instance.Call("isEqualToString:", aString).To<bool>();
		}

		public static bool hasPrefix(this NSString _instance, NSString aString)
		{
			return _instance.Call("hasPrefix:", aString).To<bool>();
		}

		public static bool hasSuffix(this NSString _instance, NSString aString)
		{
			return _instance.Call("hasSuffix:", aString).To<bool>();
		}

		public static NSRange rangeOfString(this NSString _instance, NSString aString)
		{
			return _instance.Call("rangeOfString:", aString).To<NSRange>();
		}

		public static NSRange rangeOfStringOptions(this NSString _instance, NSString aString, UInt32 mask)
		{
			return _instance.Call("rangeOfString:options:", aString, mask).To<NSRange>();
		}

		public static NSRange rangeOfStringOptionsRange(this NSString _instance, NSString aString, UInt32 mask, NSRange searchRange)
		{
			return _instance.Call("rangeOfString:options:range:", aString, mask, searchRange).To<NSRange>();
		}

		public static NSRange rangeOfStringOptionsRangeLocale(this NSString _instance, NSString aString, UInt32 mask, NSRange searchRange, NSLocale locale)
		{
			return _instance.Call("rangeOfString:options:range:locale:", aString, mask, searchRange, locale).To<NSRange>();
		}

		public static NSRange rangeOfCharacterFromSet(this NSString _instance, NSCharacterSet aSet)
		{
			return _instance.Call("rangeOfCharacterFromSet:", aSet).To<NSRange>();
		}

		public static NSRange rangeOfCharacterFromSetOptions(this NSString _instance, NSCharacterSet aSet, UInt32 mask)
		{
			return _instance.Call("rangeOfCharacterFromSet:options:", aSet, mask).To<NSRange>();
		}

		public static NSRange rangeOfCharacterFromSetOptionsRange(this NSString _instance, NSCharacterSet aSet, UInt32 mask, NSRange searchRange)
		{
			return _instance.Call("rangeOfCharacterFromSet:options:range:", aSet, mask, searchRange).To<NSRange>();
		}

		public static NSRange rangeOfComposedCharacterSequenceAtIndex(this NSString _instance, UInt32 index)
		{
			return _instance.Call("rangeOfComposedCharacterSequenceAtIndex:", index).To<NSRange>();
		}

		public static NSRange rangeOfComposedCharacterSequencesForRange(this NSString _instance, NSRange range)
		{
			return _instance.Call("rangeOfComposedCharacterSequencesForRange:", range).To<NSRange>();
		}

		public static NSString stringByAppendingString(this NSString _instance, NSString aString)
		{
			return _instance.Call("stringByAppendingString:", aString).To<NSString>();
		}

		// skipping stringByAppendingFormat: because it is variadic

		public static double doubleValue(this NSString _instance)
		{
			return _instance.Call("doubleValue").To<double>();
		}

		public static float floatValue(this NSString _instance)
		{
			return _instance.Call("floatValue").To<float>();
		}

		public static Int32 intValue(this NSString _instance)
		{
			return _instance.Call("intValue").To<Int32>();
		}

		public static Int32 integerValue(this NSString _instance)
		{
			return _instance.Call("integerValue").To<Int32>();
		}

		public static Int64 longLongValue(this NSString _instance)
		{
			return _instance.Call("longLongValue").To<Int64>();
		}

		public static bool boolValue(this NSString _instance)
		{
			return _instance.Call("boolValue").To<bool>();
		}

		public static NSArray componentsSeparatedByString(this NSString _instance, NSString separator)
		{
			return _instance.Call("componentsSeparatedByString:", separator).To<NSArray>();
		}

		public static NSArray componentsSeparatedByCharactersInSet(this NSString _instance, NSCharacterSet separator)
		{
			return _instance.Call("componentsSeparatedByCharactersInSet:", separator).To<NSArray>();
		}

		public static NSString commonPrefixWithStringOptions(this NSString _instance, NSString aString, UInt32 mask)
		{
			return _instance.Call("commonPrefixWithString:options:", aString, mask).To<NSString>();
		}

		public static NSString uppercaseString(this NSString _instance)
		{
			return _instance.Call("uppercaseString").To<NSString>();
		}

		public static NSString lowercaseString(this NSString _instance)
		{
			return _instance.Call("lowercaseString").To<NSString>();
		}

		public static NSString capitalizedString(this NSString _instance)
		{
			return _instance.Call("capitalizedString").To<NSString>();
		}

		public static NSString stringByTrimmingCharactersInSet(this NSString _instance, NSCharacterSet set_)
		{
			return _instance.Call("stringByTrimmingCharactersInSet:", set_).To<NSString>();
		}

		public static NSString stringByPaddingToLengthWithStringStartingAtIndex(this NSString _instance, UInt32 newLength, NSString padString, UInt32 padIndex)
		{
			return _instance.Call("stringByPaddingToLength:withString:startingAtIndex:", newLength, padString, padIndex).To<NSString>();
		}

		public static void getLineStartEndContentsEndForRange(this NSString _instance, IntPtr startPtr, IntPtr lineEndPtr, IntPtr contentsEndPtr, NSRange range)
		{
			Unused.Value = _instance.Call("getLineStart:end:contentsEnd:forRange:", startPtr, lineEndPtr, contentsEndPtr, range);
		}

		public static NSRange lineRangeForRange(this NSString _instance, NSRange range)
		{
			return _instance.Call("lineRangeForRange:", range).To<NSRange>();
		}

		public static void getParagraphStartEndContentsEndForRange(this NSString _instance, IntPtr startPtr, IntPtr parEndPtr, IntPtr contentsEndPtr, NSRange range)
		{
			Unused.Value = _instance.Call("getParagraphStart:end:contentsEnd:forRange:", startPtr, parEndPtr, contentsEndPtr, range);
		}

		public static NSRange paragraphRangeForRange(this NSString _instance, NSRange range)
		{
			return _instance.Call("paragraphRangeForRange:", range).To<NSRange>();
		}

		// skipping description (it's already defined)

		public static UInt32 hash(this NSString _instance)
		{
			return _instance.Call("hash").To<UInt32>();
		}

		public static UInt32 fastestEncoding(this NSString _instance)
		{
			return _instance.Call("fastestEncoding").To<UInt32>();
		}

		public static UInt32 smallestEncoding(this NSString _instance)
		{
			return _instance.Call("smallestEncoding").To<UInt32>();
		}

		public static NSData dataUsingEncodingAllowLossyConversion(this NSString _instance, UInt32 encoding, bool lossy)
		{
			return _instance.Call("dataUsingEncoding:allowLossyConversion:", encoding, lossy).To<NSData>();
		}

		public static NSData dataUsingEncoding(this NSString _instance, UInt32 encoding)
		{
			return _instance.Call("dataUsingEncoding:", encoding).To<NSData>();
		}

		public static bool canBeConvertedToEncoding(this NSString _instance, UInt32 encoding)
		{
			return _instance.Call("canBeConvertedToEncoding:", encoding).To<bool>();
		}

		public static string cStringUsingEncoding(this NSString _instance, UInt32 encoding)
		{
			return _instance.Call("cStringUsingEncoding:", encoding).To<string>();
		}

		public static bool getCStringMaxLengthEncoding(this NSString _instance, IntPtr buffer, UInt32 maxBufferCount, UInt32 encoding)
		{
			return _instance.Call("getCString:maxLength:encoding:", buffer, maxBufferCount, encoding).To<bool>();
		}

		public static bool getBytesMaxLengthUsedLengthEncodingOptionsRangeRemainingRange(this NSString _instance, IntPtr buffer, UInt32 maxBufferCount, IntPtr usedBufferCount, UInt32 encoding, UInt32 options, NSRange range, IntPtr leftover)
		{
			return _instance.Call("getBytes:maxLength:usedLength:encoding:options:range:remainingRange:", buffer, maxBufferCount, usedBufferCount, encoding, options, range, leftover).To<bool>();
		}

		public static UInt32 maximumLengthOfBytesUsingEncoding(this NSString _instance, UInt32 enc)
		{
			return _instance.Call("maximumLengthOfBytesUsingEncoding:", enc).To<UInt32>();
		}

		public static UInt32 lengthOfBytesUsingEncoding(this NSString _instance, UInt32 enc)
		{
			return _instance.Call("lengthOfBytesUsingEncoding:", enc).To<UInt32>();
		}

		public static NSString decomposedStringWithCanonicalMapping(this NSString _instance)
		{
			return _instance.Call("decomposedStringWithCanonicalMapping").To<NSString>();
		}

		public static NSString precomposedStringWithCanonicalMapping(this NSString _instance)
		{
			return _instance.Call("precomposedStringWithCanonicalMapping").To<NSString>();
		}

		public static NSString decomposedStringWithCompatibilityMapping(this NSString _instance)
		{
			return _instance.Call("decomposedStringWithCompatibilityMapping").To<NSString>();
		}

		public static NSString precomposedStringWithCompatibilityMapping(this NSString _instance)
		{
			return _instance.Call("precomposedStringWithCompatibilityMapping").To<NSString>();
		}

		public static NSString stringByFoldingWithOptionsLocale(this NSString _instance, UInt32 options, NSLocale locale)
		{
			return _instance.Call("stringByFoldingWithOptions:locale:", options, locale).To<NSString>();
		}

		public static NSString stringByReplacingOccurrencesOfStringWithStringOptionsRange(this NSString _instance, NSString target, NSString replacement, UInt32 options, NSRange searchRange)
		{
			return _instance.Call("stringByReplacingOccurrencesOfString:withString:options:range:", target, replacement, options, searchRange).To<NSString>();
		}

		public static NSString stringByReplacingOccurrencesOfStringWithString(this NSString _instance, NSString target, NSString replacement)
		{
			return _instance.Call("stringByReplacingOccurrencesOfString:withString:", target, replacement).To<NSString>();
		}

		public static NSString stringByReplacingCharactersInRangeWithString(this NSString _instance, NSRange range, NSString replacement)
		{
			return _instance.Call("stringByReplacingCharactersInRange:withString:", range, replacement).To<NSString>();
		}

		public static string UTF8String(this NSString _instance)
		{
			return _instance.Call("UTF8String").To<string>();
		}

		public static UInt32 defaultCStringEncoding(this NSString _instance)
		{
			return _instance.Call("defaultCStringEncoding").To<UInt32>();
		}

		public static IntPtr availableStringEncodings(this NSString _instance)
		{
			return _instance.Call("availableStringEncodings").To<IntPtr>();
		}

		public static NSString localizedNameOfStringEncoding(this NSString _instance, UInt32 encoding)
		{
			return _instance.Call("localizedNameOfStringEncoding:", encoding).To<NSString>();
		}

		// skipping init (it's already defined)

		public static NSObject initWithCharactersNoCopyLengthFreeWhenDone(this NSString _instance, IntPtr characters, UInt32 length, bool freeBuffer)
		{
			return _instance.Call("initWithCharactersNoCopy:length:freeWhenDone:", characters, length, freeBuffer).To<NSObject>();
		}

		public static NSObject initWithCharactersLength(this NSString _instance, string characters, UInt32 length)
		{
			return _instance.Call("initWithCharacters:length:", characters, length).To<NSObject>();
		}

		public static NSObject initWithUTF8String(this NSString _instance, string nullTerminatedCString)
		{
			return _instance.Call("initWithUTF8String:", nullTerminatedCString).To<NSObject>();
		}

		public static NSObject initWithString(this NSString _instance, NSString aString)
		{
			return _instance.Call("initWithString:", aString).To<NSObject>();
		}

		// skipping initWithFormat: because it is variadic

		public static NSObject initWithFormatArguments(this NSString _instance, NSString format, IntPtr argList)
		{
			return _instance.Call("initWithFormat:arguments:", format, argList).To<NSObject>();
		}

		// skipping initWithFormat:locale: because it is variadic

		public static NSObject initWithFormatLocaleArguments(this NSString _instance, NSString format, NSObject locale, IntPtr argList)
		{
			return _instance.Call("initWithFormat:locale:arguments:", format, locale, argList).To<NSObject>();
		}

		public static NSObject initWithDataEncoding(this NSString _instance, NSData data, UInt32 encoding)
		{
			return _instance.Call("initWithData:encoding:", data, encoding).To<NSObject>();
		}

		public static NSObject initWithBytesLengthEncoding(this NSString _instance, IntPtr bytes, UInt32 len, UInt32 encoding)
		{
			return _instance.Call("initWithBytes:length:encoding:", bytes, len, encoding).To<NSObject>();
		}

		public static NSObject initWithBytesNoCopyLengthEncodingFreeWhenDone(this NSString _instance, IntPtr bytes, UInt32 len, UInt32 encoding, bool freeBuffer)
		{
			return _instance.Call("initWithBytesNoCopy:length:encoding:freeWhenDone:", bytes, len, encoding, freeBuffer).To<NSObject>();
		}

		public static NSObject string_(this NSString _instance)
		{
			return _instance.Call("string").To<NSObject>();
		}

		public static NSObject stringWithString(this NSString _instance, NSString string_)
		{
			return _instance.Call("stringWithString:", string_).To<NSObject>();
		}

		public static NSObject stringWithCharactersLength(this NSString _instance, string characters, UInt32 length)
		{
			return _instance.Call("stringWithCharacters:length:", characters, length).To<NSObject>();
		}

		public static NSObject stringWithUTF8String(this NSString _instance, string nullTerminatedCString)
		{
			return _instance.Call("stringWithUTF8String:", nullTerminatedCString).To<NSObject>();
		}

		// skipping stringWithFormat: because it is variadic

		// skipping localizedStringWithFormat: because it is variadic

		public static NSObject initWithCStringEncoding(this NSString _instance, string nullTerminatedCString, UInt32 encoding)
		{
			return _instance.Call("initWithCString:encoding:", nullTerminatedCString, encoding).To<NSObject>();
		}

		public static NSObject stringWithCStringEncoding(this NSString _instance, string cString, UInt32 enc)
		{
			return _instance.Call("stringWithCString:encoding:", cString, enc).To<NSObject>();
		}

		public static NSObject initWithContentsOfURLEncodingError(this NSString _instance, NSURL url, UInt32 enc, IntPtr error)
		{
			return _instance.Call("initWithContentsOfURL:encoding:error:", url, enc, error).To<NSObject>();
		}

		public static NSObject initWithContentsOfFileEncodingError(this NSString _instance, NSString path, UInt32 enc, IntPtr error)
		{
			return _instance.Call("initWithContentsOfFile:encoding:error:", path, enc, error).To<NSObject>();
		}

		public static NSObject stringWithContentsOfURLEncodingError(this NSString _instance, NSURL url, UInt32 enc, IntPtr error)
		{
			return _instance.Call("stringWithContentsOfURL:encoding:error:", url, enc, error).To<NSObject>();
		}

		public static NSObject stringWithContentsOfFileEncodingError(this NSString _instance, NSString path, UInt32 enc, IntPtr error)
		{
			return _instance.Call("stringWithContentsOfFile:encoding:error:", path, enc, error).To<NSObject>();
		}

		public static NSObject initWithContentsOfURLUsedEncodingError(this NSString _instance, NSURL url, IntPtr enc, IntPtr error)
		{
			return _instance.Call("initWithContentsOfURL:usedEncoding:error:", url, enc, error).To<NSObject>();
		}

		public static NSObject initWithContentsOfFileUsedEncodingError(this NSString _instance, NSString path, IntPtr enc, IntPtr error)
		{
			return _instance.Call("initWithContentsOfFile:usedEncoding:error:", path, enc, error).To<NSObject>();
		}

		public static NSObject stringWithContentsOfURLUsedEncodingError(this NSString _instance, NSURL url, IntPtr enc, IntPtr error)
		{
			return _instance.Call("stringWithContentsOfURL:usedEncoding:error:", url, enc, error).To<NSObject>();
		}

		public static NSObject stringWithContentsOfFileUsedEncodingError(this NSString _instance, NSString path, IntPtr enc, IntPtr error)
		{
			return _instance.Call("stringWithContentsOfFile:usedEncoding:error:", path, enc, error).To<NSObject>();
		}

		public static bool writeToURLAtomicallyEncodingError(this NSString _instance, NSURL url, bool useAuxiliaryFile, UInt32 enc, IntPtr error)
		{
			return _instance.Call("writeToURL:atomically:encoding:error:", url, useAuxiliaryFile, enc, error).To<bool>();
		}

		public static bool writeToFileAtomicallyEncodingError(this NSString _instance, NSString path, bool useAuxiliaryFile, UInt32 enc, IntPtr error)
		{
			return _instance.Call("writeToFile:atomically:encoding:error:", path, useAuxiliaryFile, enc, error).To<bool>();
		}
	}

	[Register]
	public partial class NSMutableString : NSString
	{
		public NSMutableString() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableString(IntPtr instance) : base(instance)
		{
		}

		public NSMutableString(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableString alloc()
		{
			return new NSMutableString(ms_class.Call("alloc"));
		}

		public new NSMutableString retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void replaceCharactersInRangeWithString(NSRange range, NSString aString)
		{
			Unused.Value = Call("replaceCharactersInRange:withString:", range, aString);
		}

		private static Class ms_class = new Class("NSMutableString");
	}

	public static class NSMutableStringExtensionMethodsForNSMutableStringCategory
	{
		public static void insertStringAtIndex(this NSMutableString _instance, NSString aString, UInt32 loc)
		{
			Unused.Value = _instance.Call("insertString:atIndex:", aString, loc);
		}

		public static void deleteCharactersInRange(this NSMutableString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("deleteCharactersInRange:", range);
		}

		public static void appendString(this NSMutableString _instance, NSString aString)
		{
			Unused.Value = _instance.Call("appendString:", aString);
		}

		// skipping appendFormat: because it is variadic

		public static void setString(this NSMutableString _instance, NSString aString)
		{
			Unused.Value = _instance.Call("setString:", aString);
		}

		public static NSObject initWithCapacity(this NSMutableString _instance, UInt32 capacity)
		{
			return _instance.Call("initWithCapacity:", capacity).To<NSObject>();
		}

		public static NSObject stringWithCapacity(this NSMutableString _instance, UInt32 capacity)
		{
			return _instance.Call("stringWithCapacity:", capacity).To<NSObject>();
		}

		public static UInt32 replaceOccurrencesOfStringWithStringOptionsRange(this NSMutableString _instance, NSString target, NSString replacement, UInt32 options, NSRange searchRange)
		{
			return _instance.Call("replaceOccurrencesOfString:withString:options:range:", target, replacement, options, searchRange).To<UInt32>();
		}
	}

	public static class NSExtendedStringPropertyListParsingForNSStringCategory
	{
		public static NSObject propertyList(this NSString _instance)
		{
			return _instance.Call("propertyList").To<NSObject>();
		}

		public static NSDictionary propertyListFromStringsFileFormat(this NSString _instance)
		{
			return _instance.Call("propertyListFromStringsFileFormat").To<NSDictionary>();
		}
	}

	public static class NSStringDeprecatedForNSStringCategory
	{
	}

	[Register]
	public partial class NSSimpleCString : NSString
	{
		public NSSimpleCString() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSimpleCString(IntPtr instance) : base(instance)
		{
		}

		public NSSimpleCString(Untyped instance) : base(instance)
		{
		}

		public static new NSSimpleCString alloc()
		{
			return new NSSimpleCString(ms_class.Call("alloc"));
		}

		public new NSSimpleCString retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSSimpleCString");
	}

	[Register]
	public partial class NSConstantString : NSSimpleCString
	{
		public NSConstantString() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSConstantString(IntPtr instance) : base(instance)
		{
		}

		public NSConstantString(Untyped instance) : base(instance)
		{
		}

		public static new NSConstantString alloc()
		{
			return new NSConstantString(ms_class.Call("alloc"));
		}

		public new NSConstantString retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSConstantString");
	}
}
