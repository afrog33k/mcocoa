// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSATSTypesetter.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSATSTypesetter : NSTypesetter
	{
		public NSATSTypesetter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSATSTypesetter(IntPtr instance) : base(instance)
		{
		}

		public NSATSTypesetter(Untyped instance) : base(instance)
		{
		}

		public static new NSATSTypesetter alloc()
		{
			return new NSATSTypesetter(ms_class.Call("alloc"));
		}

		public new NSATSTypesetter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject sharedTypesetter()
		{
			return ms_class.Call("sharedTypesetter").To<NSObject>();
		}

		private static Class ms_class = new Class("NSATSTypesetter");
	}

	public static class NSPantherCompatibilityForNSATSTypesetterCategory
	{
	}

	public static class NSPrimitiveInterfaceForNSATSTypesetterCategory
	{
		public static bool usesFontLeading(this NSATSTypesetter _instance)
		{
			return _instance.Call("usesFontLeading").To<bool>();
		}

		public static void setUsesFontLeading(this NSATSTypesetter _instance, bool flag)
		{
			Unused.Value = _instance.Call("setUsesFontLeading:", flag);
		}

		public static Int32 typesetterBehavior(this NSATSTypesetter _instance)
		{
			return _instance.Call("typesetterBehavior").To<Int32>();
		}

		public static void setTypesetterBehavior(this NSATSTypesetter _instance, Int32 behavior)
		{
			Unused.Value = _instance.Call("setTypesetterBehavior:", behavior);
		}

		public static float hyphenationFactor(this NSATSTypesetter _instance)
		{
			return _instance.Call("hyphenationFactor").To<float>();
		}

		public static void setHyphenationFactor(this NSATSTypesetter _instance, float factor)
		{
			Unused.Value = _instance.Call("setHyphenationFactor:", factor);
		}

		public static float lineFragmentPadding(this NSATSTypesetter _instance)
		{
			return _instance.Call("lineFragmentPadding").To<float>();
		}

		public static void setLineFragmentPadding(this NSATSTypesetter _instance, float padding)
		{
			Unused.Value = _instance.Call("setLineFragmentPadding:", padding);
		}

		public static NSFont substituteFontForFont(this NSATSTypesetter _instance, NSFont originalFont)
		{
			return _instance.Call("substituteFontForFont:", originalFont).To<NSFont>();
		}

		public static NSTextTab textTabForGlyphLocationWritingDirectionMaxLocation(this NSATSTypesetter _instance, float glyphLocation, Int32 direction, float maxLocation)
		{
			return _instance.Call("textTabForGlyphLocation:writingDirection:maxLocation:", glyphLocation, direction, maxLocation).To<NSTextTab>();
		}

		public static bool bidiProcessingEnabled(this NSATSTypesetter _instance)
		{
			return _instance.Call("bidiProcessingEnabled").To<bool>();
		}

		public static void setBidiProcessingEnabled(this NSATSTypesetter _instance, bool flag)
		{
			Unused.Value = _instance.Call("setBidiProcessingEnabled:", flag);
		}

		public static void setAttributedString(this NSATSTypesetter _instance, NSAttributedString attrString)
		{
			Unused.Value = _instance.Call("setAttributedString:", attrString);
		}

		public static NSAttributedString attributedString(this NSATSTypesetter _instance)
		{
			return _instance.Call("attributedString").To<NSAttributedString>();
		}

		public static void setParagraphGlyphRangeSeparatorGlyphRange(this NSATSTypesetter _instance, NSRange paragraphRange, NSRange paragraphSeparatorRange)
		{
			Unused.Value = _instance.Call("setParagraphGlyphRange:separatorGlyphRange:", paragraphRange, paragraphSeparatorRange);
		}

		public static NSRange paragraphGlyphRange(this NSATSTypesetter _instance)
		{
			return _instance.Call("paragraphGlyphRange").To<NSRange>();
		}

		public static NSRange paragraphSeparatorGlyphRange(this NSATSTypesetter _instance)
		{
			return _instance.Call("paragraphSeparatorGlyphRange").To<NSRange>();
		}

		public static UInt32 layoutParagraphAtPoint(this NSATSTypesetter _instance, IntPtr lineFragmentOrigin)
		{
			return _instance.Call("layoutParagraphAtPoint:", lineFragmentOrigin).To<UInt32>();
		}

		public static float lineSpacingAfterGlyphAtIndexWithProposedLineFragmentRect(this NSATSTypesetter _instance, UInt32 glyphIndex, NSRect rect)
		{
			return _instance.Call("lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:", glyphIndex, rect).To<float>();
		}

		public static float paragraphSpacingBeforeGlyphAtIndexWithProposedLineFragmentRect(this NSATSTypesetter _instance, UInt32 glyphIndex, NSRect rect)
		{
			return _instance.Call("paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:", glyphIndex, rect).To<float>();
		}

		public static float paragraphSpacingAfterGlyphAtIndexWithProposedLineFragmentRect(this NSATSTypesetter _instance, UInt32 glyphIndex, NSRect rect)
		{
			return _instance.Call("paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:", glyphIndex, rect).To<float>();
		}

		public static NSLayoutManager layoutManager(this NSATSTypesetter _instance)
		{
			return _instance.Call("layoutManager").To<NSLayoutManager>();
		}

		public static NSTextContainer currentTextContainer(this NSATSTypesetter _instance)
		{
			return _instance.Call("currentTextContainer").To<NSTextContainer>();
		}

		public static void setHardInvalidationForGlyphRange(this NSATSTypesetter _instance, bool flag, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setHardInvalidation:forGlyphRange:", flag, glyphRange);
		}

		public static void getLineFragmentRectUsedRectForParagraphSeparatorGlyphRangeAtProposedOrigin(this NSATSTypesetter _instance, IntPtr lineFragmentRect, IntPtr lineFragmentUsedRect, NSRange paragraphSeparatorGlyphRange, NSPoint lineOrigin)
		{
			Unused.Value = _instance.Call("getLineFragmentRect:usedRect:forParagraphSeparatorGlyphRange:atProposedOrigin:", lineFragmentRect, lineFragmentUsedRect, paragraphSeparatorGlyphRange, lineOrigin);
		}
	}

	public static class NSLayoutPhaseInterfaceForNSATSTypesetterCategory
	{
		public static void willSetLineFragmentRectForGlyphRangeUsedRectBaselineOffset(this NSATSTypesetter _instance, IntPtr lineRect, NSRange glyphRange, IntPtr usedRect, IntPtr baselineOffset)
		{
			Unused.Value = _instance.Call("willSetLineFragmentRect:forGlyphRange:usedRect:baselineOffset:", lineRect, glyphRange, usedRect, baselineOffset);
		}

		public static bool shouldBreakLineByWordBeforeCharacterAtIndex(this NSATSTypesetter _instance, UInt32 charIndex)
		{
			return _instance.Call("shouldBreakLineByWordBeforeCharacterAtIndex:", charIndex).To<bool>();
		}

		public static bool shouldBreakLineByHyphenatingBeforeCharacterAtIndex(this NSATSTypesetter _instance, UInt32 charIndex)
		{
			return _instance.Call("shouldBreakLineByHyphenatingBeforeCharacterAtIndex:", charIndex).To<bool>();
		}

		public static float hyphenationFactorForGlyphAtIndex(this NSATSTypesetter _instance, UInt32 glyphIndex)
		{
			return _instance.Call("hyphenationFactorForGlyphAtIndex:", glyphIndex).To<float>();
		}

		public static UInt32 hyphenCharacterForGlyphAtIndex(this NSATSTypesetter _instance, UInt32 glyphIndex)
		{
			return _instance.Call("hyphenCharacterForGlyphAtIndex:", glyphIndex).To<UInt32>();
		}

		public static NSRect boundingBoxForControlGlyphAtIndexForTextContainerProposedLineFragmentGlyphPositionCharacterIndex(this NSATSTypesetter _instance, UInt32 glyphIndex, NSTextContainer textContainer, NSRect proposedRect, NSPoint glyphPosition, UInt32 charIndex)
		{
			return _instance.Call("boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:", glyphIndex, textContainer, proposedRect, glyphPosition, charIndex).To<NSRect>();
		}
	}

	public static class NSGlyphStorageInterfaceForNSATSTypesetterCategory
	{
		public static NSRange characterRangeForGlyphRangeActualGlyphRange(this NSATSTypesetter _instance, NSRange glyphRange, IntPtr actualGlyphRange)
		{
			return _instance.Call("characterRangeForGlyphRange:actualGlyphRange:", glyphRange, actualGlyphRange).To<NSRange>();
		}

		public static NSRange glyphRangeForCharacterRangeActualCharacterRange(this NSATSTypesetter _instance, NSRange charRange, IntPtr actualCharRange)
		{
			return _instance.Call("glyphRangeForCharacterRange:actualCharacterRange:", charRange, actualCharRange).To<NSRange>();
		}

		public static UInt32 getGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBits(this NSATSTypesetter _instance, NSRange glyphsRange, IntPtr glyphBuffer, IntPtr charIndexBuffer, IntPtr inscribeBuffer, IntPtr elasticBuffer)
		{
			return _instance.Call("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:", glyphsRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer).To<UInt32>();
		}

		public static void setLineFragmentRectForGlyphRangeUsedRectBaselineOffset(this NSATSTypesetter _instance, NSRect fragmentRect, NSRange glyphRange, NSRect usedRect, float baselineOffset)
		{
			Unused.Value = _instance.Call("setLineFragmentRect:forGlyphRange:usedRect:baselineOffset:", fragmentRect, glyphRange, usedRect, baselineOffset);
		}

		public static void substituteGlyphsInRangeWithGlyphs(this NSATSTypesetter _instance, NSRange glyphRange, IntPtr glyphs)
		{
			Unused.Value = _instance.Call("substituteGlyphsInRange:withGlyphs:", glyphRange, glyphs);
		}

		public static void insertGlyphAtGlyphIndexCharacterIndex(this NSATSTypesetter _instance, UInt32 glyph, UInt32 glyphIndex, UInt32 characterIndex)
		{
			Unused.Value = _instance.Call("insertGlyph:atGlyphIndex:characterIndex:", glyph, glyphIndex, characterIndex);
		}

		public static void deleteGlyphsInRange(this NSATSTypesetter _instance, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("deleteGlyphsInRange:", glyphRange);
		}

		public static void setNotShownAttributeForGlyphRange(this NSATSTypesetter _instance, bool flag, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setNotShownAttribute:forGlyphRange:", flag, glyphRange);
		}

		public static void setDrawsOutsideLineFragmentForGlyphRange(this NSATSTypesetter _instance, bool flag, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setDrawsOutsideLineFragment:forGlyphRange:", flag, glyphRange);
		}

		public static void setLocationWithAdvancementsForStartOfGlyphRange(this NSATSTypesetter _instance, NSPoint location, IntPtr advancements, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setLocation:withAdvancements:forStartOfGlyphRange:", location, advancements, glyphRange);
		}

		public static void setAttachmentSizeForGlyphRange(this NSATSTypesetter _instance, NSSize attachmentSize, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setAttachmentSize:forGlyphRange:", attachmentSize, glyphRange);
		}

		public static void setBidiLevelsForGlyphRange(this NSATSTypesetter _instance, IntPtr levels, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setBidiLevels:forGlyphRange:", levels, glyphRange);
		}
	}
}
