// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSAttributedString.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSUnderlineStyleNone = 0x00;
		public const int NSUnderlineStyleSingle = 0x01;
		public const int NSUnderlineStyleThick = 0x02;
		public const int NSUnderlineStyleDouble = 0x09;
	}

	public partial class Enums
	{
		public const int NSUnderlinePatternSolid = 0x0000;
		public const int NSUnderlinePatternDot = 0x0100;
		public const int NSUnderlinePatternDash = 0x0200;
		public const int NSUnderlinePatternDashDot = 0x0300;
		public const int NSUnderlinePatternDashDotDot = 0x0400;
	}

	public partial class Enums
	{
		public const int NSSpellingStateSpellingFlag = ( 1 << 0 );
		public const int NSSpellingStateGrammarFlag = ( 1 << 1 );
	}

	public partial class Enums
	{
		public const int NSNoUnderlineStyle = 0;
		public const int NSSingleUnderlineStyle = 1;
	}

	public static class NSAttributedStringKitAdditionsForNSAttributedStringCategory
	{
		public static NSDictionary fontAttributesInRange(this NSAttributedString _instance, NSRange range)
		{
			return _instance.Call("fontAttributesInRange:", range).To<NSDictionary>();
		}

		public static NSDictionary rulerAttributesInRange(this NSAttributedString _instance, NSRange range)
		{
			return _instance.Call("rulerAttributesInRange:", range).To<NSDictionary>();
		}

		public static bool containsAttachments(this NSAttributedString _instance)
		{
			return _instance.Call("containsAttachments").To<bool>();
		}

		public static UInt32 lineBreakBeforeIndexWithinRange(this NSAttributedString _instance, UInt32 location, NSRange aRange)
		{
			return _instance.Call("lineBreakBeforeIndex:withinRange:", location, aRange).To<UInt32>();
		}

		public static UInt32 lineBreakByHyphenatingBeforeIndexWithinRange(this NSAttributedString _instance, UInt32 location, NSRange aRange)
		{
			return _instance.Call("lineBreakByHyphenatingBeforeIndex:withinRange:", location, aRange).To<UInt32>();
		}

		public static NSRange doubleClickAtIndex(this NSAttributedString _instance, UInt32 location)
		{
			return _instance.Call("doubleClickAtIndex:", location).To<NSRange>();
		}

		public static UInt32 nextWordFromIndexForward(this NSAttributedString _instance, UInt32 location, bool isForward)
		{
			return _instance.Call("nextWordFromIndex:forward:", location, isForward).To<UInt32>();
		}

		public static NSURL URLAtIndexEffectiveRange(this NSAttributedString _instance, UInt32 location, IntPtr effectiveRange)
		{
			return _instance.Call("URLAtIndex:effectiveRange:", location, effectiveRange).To<NSURL>();
		}

		public static NSArray textTypes(this NSAttributedString _instance)
		{
			return _instance.Call("textTypes").To<NSArray>();
		}

		public static NSArray textUnfilteredTypes(this NSAttributedString _instance)
		{
			return _instance.Call("textUnfilteredTypes").To<NSArray>();
		}

		public static NSRange rangeOfTextBlockAtIndex(this NSAttributedString _instance, NSTextBlock block, UInt32 location)
		{
			return _instance.Call("rangeOfTextBlock:atIndex:", block, location).To<NSRange>();
		}

		public static NSRange rangeOfTextTableAtIndex(this NSAttributedString _instance, NSTextTable table, UInt32 location)
		{
			return _instance.Call("rangeOfTextTable:atIndex:", table, location).To<NSRange>();
		}

		public static NSRange rangeOfTextListAtIndex(this NSAttributedString _instance, NSTextList list, UInt32 location)
		{
			return _instance.Call("rangeOfTextList:atIndex:", list, location).To<NSRange>();
		}

		public static Int32 itemNumberInTextListAtIndex(this NSAttributedString _instance, NSTextList list, UInt32 location)
		{
			return _instance.Call("itemNumberInTextList:atIndex:", list, location).To<Int32>();
		}

		public static NSObject initWithURLOptionsDocumentAttributesError(this NSAttributedString _instance, NSURL url, NSDictionary options, IntPtr dict, IntPtr error)
		{
			return _instance.Call("initWithURL:options:documentAttributes:error:", url, options, dict, error).To<NSObject>();
		}

		public static NSObject initWithDataOptionsDocumentAttributesError(this NSAttributedString _instance, NSData data, NSDictionary options, IntPtr dict, IntPtr error)
		{
			return _instance.Call("initWithData:options:documentAttributes:error:", data, options, dict, error).To<NSObject>();
		}

		public static NSObject initWithPathDocumentAttributes(this NSAttributedString _instance, NSString path, IntPtr dict)
		{
			return _instance.Call("initWithPath:documentAttributes:", path, dict).To<NSObject>();
		}

		public static NSObject initWithURLDocumentAttributes(this NSAttributedString _instance, NSURL url, IntPtr dict)
		{
			return _instance.Call("initWithURL:documentAttributes:", url, dict).To<NSObject>();
		}

		public static NSObject initWithRTFDocumentAttributes(this NSAttributedString _instance, NSData data, IntPtr dict)
		{
			return _instance.Call("initWithRTF:documentAttributes:", data, dict).To<NSObject>();
		}

		public static NSObject initWithRTFDDocumentAttributes(this NSAttributedString _instance, NSData data, IntPtr dict)
		{
			return _instance.Call("initWithRTFD:documentAttributes:", data, dict).To<NSObject>();
		}

		public static NSObject initWithHTMLDocumentAttributes(this NSAttributedString _instance, NSData data, IntPtr dict)
		{
			return _instance.Call("initWithHTML:documentAttributes:", data, dict).To<NSObject>();
		}

		public static NSObject initWithHTMLBaseURLDocumentAttributes(this NSAttributedString _instance, NSData data, NSURL base_, IntPtr dict)
		{
			return _instance.Call("initWithHTML:baseURL:documentAttributes:", data, base_, dict).To<NSObject>();
		}

		public static NSObject initWithDocFormatDocumentAttributes(this NSAttributedString _instance, NSData data, IntPtr dict)
		{
			return _instance.Call("initWithDocFormat:documentAttributes:", data, dict).To<NSObject>();
		}

		public static NSObject initWithHTMLOptionsDocumentAttributes(this NSAttributedString _instance, NSData data, NSDictionary options, IntPtr dict)
		{
			return _instance.Call("initWithHTML:options:documentAttributes:", data, options, dict).To<NSObject>();
		}

		public static NSObject initWithRTFDFileWrapperDocumentAttributes(this NSAttributedString _instance, NSFileWrapper wrapper, IntPtr dict)
		{
			return _instance.Call("initWithRTFDFileWrapper:documentAttributes:", wrapper, dict).To<NSObject>();
		}

		public static NSData dataFromRangeDocumentAttributesError(this NSAttributedString _instance, NSRange range, NSDictionary dict, IntPtr error)
		{
			return _instance.Call("dataFromRange:documentAttributes:error:", range, dict, error).To<NSData>();
		}

		public static NSFileWrapper fileWrapperFromRangeDocumentAttributesError(this NSAttributedString _instance, NSRange range, NSDictionary dict, IntPtr error)
		{
			return _instance.Call("fileWrapperFromRange:documentAttributes:error:", range, dict, error).To<NSFileWrapper>();
		}

		public static NSData RTFFromRangeDocumentAttributes(this NSAttributedString _instance, NSRange range, NSDictionary dict)
		{
			return _instance.Call("RTFFromRange:documentAttributes:", range, dict).To<NSData>();
		}

		public static NSData RTFDFromRangeDocumentAttributes(this NSAttributedString _instance, NSRange range, NSDictionary dict)
		{
			return _instance.Call("RTFDFromRange:documentAttributes:", range, dict).To<NSData>();
		}

		public static NSFileWrapper RTFDFileWrapperFromRangeDocumentAttributes(this NSAttributedString _instance, NSRange range, NSDictionary dict)
		{
			return _instance.Call("RTFDFileWrapperFromRange:documentAttributes:", range, dict).To<NSFileWrapper>();
		}

		public static NSData docFormatFromRangeDocumentAttributes(this NSAttributedString _instance, NSRange range, NSDictionary dict)
		{
			return _instance.Call("docFormatFromRange:documentAttributes:", range, dict).To<NSData>();
		}
	}

	public static class NSDeprecatedKitAdditionsForNSAttributedStringCategory
	{
		public static NSArray textFileTypes(this NSAttributedString _instance)
		{
			return _instance.Call("textFileTypes").To<NSArray>();
		}

		public static NSArray textPasteboardTypes(this NSAttributedString _instance)
		{
			return _instance.Call("textPasteboardTypes").To<NSArray>();
		}

		public static NSArray textUnfilteredFileTypes(this NSAttributedString _instance)
		{
			return _instance.Call("textUnfilteredFileTypes").To<NSArray>();
		}

		public static NSArray textUnfilteredPasteboardTypes(this NSAttributedString _instance)
		{
			return _instance.Call("textUnfilteredPasteboardTypes").To<NSArray>();
		}
	}

	public static class NSMutableAttributedStringKitAdditionsForNSMutableAttributedStringCategory
	{
		public static bool readFromURLOptionsDocumentAttributesError(this NSMutableAttributedString _instance, NSURL url, NSDictionary opts, IntPtr dict, IntPtr error)
		{
			return _instance.Call("readFromURL:options:documentAttributes:error:", url, opts, dict, error).To<bool>();
		}

		public static bool readFromDataOptionsDocumentAttributesError(this NSMutableAttributedString _instance, NSData data, NSDictionary opts, IntPtr dict, IntPtr error)
		{
			return _instance.Call("readFromData:options:documentAttributes:error:", data, opts, dict, error).To<bool>();
		}

		public static bool readFromURLOptionsDocumentAttributes(this NSMutableAttributedString _instance, NSURL url, NSDictionary options, IntPtr dict)
		{
			return _instance.Call("readFromURL:options:documentAttributes:", url, options, dict).To<bool>();
		}

		public static bool readFromDataOptionsDocumentAttributes(this NSMutableAttributedString _instance, NSData data, NSDictionary options, IntPtr dict)
		{
			return _instance.Call("readFromData:options:documentAttributes:", data, options, dict).To<bool>();
		}

		public static void superscriptRange(this NSMutableAttributedString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("superscriptRange:", range);
		}

		public static void subscriptRange(this NSMutableAttributedString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("subscriptRange:", range);
		}

		public static void unscriptRange(this NSMutableAttributedString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("unscriptRange:", range);
		}

		public static void applyFontTraitsRange(this NSMutableAttributedString _instance, UInt32 traitMask, NSRange range)
		{
			Unused.Value = _instance.Call("applyFontTraits:range:", traitMask, range);
		}

		public static void setAlignmentRange(this NSMutableAttributedString _instance, UInt32 alignment, NSRange range)
		{
			Unused.Value = _instance.Call("setAlignment:range:", alignment, range);
		}

		public static void setBaseWritingDirectionRange(this NSMutableAttributedString _instance, Int32 writingDirection, NSRange range)
		{
			Unused.Value = _instance.Call("setBaseWritingDirection:range:", writingDirection, range);
		}

		public static void fixAttributesInRange(this NSMutableAttributedString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("fixAttributesInRange:", range);
		}

		public static void fixFontAttributeInRange(this NSMutableAttributedString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("fixFontAttributeInRange:", range);
		}

		public static void fixParagraphStyleAttributeInRange(this NSMutableAttributedString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("fixParagraphStyleAttributeInRange:", range);
		}

		public static void fixAttachmentAttributeInRange(this NSMutableAttributedString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("fixAttachmentAttributeInRange:", range);
		}
	}
}
