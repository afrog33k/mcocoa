// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTypesetter.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTypesetterZeroAdvancementAction = ( 1 << 0 );
		public const int NSTypesetterWhitespaceAction = ( 1 << 1 );
		public const int NSTypesetterHorizontalTabAction = ( 1 << 2 );
		public const int NSTypesetterLineBreakAction = ( 1 << 3 );
		public const int NSTypesetterParagraphBreakAction = ( 1 << 4 );
		public const int NSTypesetterContainerBreakAction = ( 1 << 5 );
	}

	[Register]
	public partial class NSTypesetter : NSObject
	{
		public NSTypesetter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTypesetter(IntPtr instance) : base(instance)
		{
		}

		public NSTypesetter(Untyped instance) : base(instance)
		{
		}

		public static new NSTypesetter alloc()
		{
			return new NSTypesetter(ms_class.Call("alloc"));
		}

		public new NSTypesetter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool usesFontLeading()
		{
			return Call("usesFontLeading").To<bool>();
		}

		public void setUsesFontLeading(bool flag)
		{
			Unused.Value = Call("setUsesFontLeading:", flag);
		}

		public Int32 typesetterBehavior()
		{
			return Call("typesetterBehavior").To<Int32>();
		}

		public void setTypesetterBehavior(Int32 behavior)
		{
			Unused.Value = Call("setTypesetterBehavior:", behavior);
		}

		public float hyphenationFactor()
		{
			return Call("hyphenationFactor").To<float>();
		}

		public void setHyphenationFactor(float factor)
		{
			Unused.Value = Call("setHyphenationFactor:", factor);
		}

		public float lineFragmentPadding()
		{
			return Call("lineFragmentPadding").To<float>();
		}

		public void setLineFragmentPadding(float padding)
		{
			Unused.Value = Call("setLineFragmentPadding:", padding);
		}

		public NSFont substituteFontForFont(NSFont originalFont)
		{
			return Call("substituteFontForFont:", originalFont).To<NSFont>();
		}

		public NSTextTab textTabForGlyphLocationWritingDirectionMaxLocation(float glyphLocation, Int32 direction, float maxLocation)
		{
			return Call("textTabForGlyphLocation:writingDirection:maxLocation:", glyphLocation, direction, maxLocation).To<NSTextTab>();
		}

		public bool bidiProcessingEnabled()
		{
			return Call("bidiProcessingEnabled").To<bool>();
		}

		public void setBidiProcessingEnabled(bool flag)
		{
			Unused.Value = Call("setBidiProcessingEnabled:", flag);
		}

		public void setAttributedString(NSAttributedString attrString)
		{
			Unused.Value = Call("setAttributedString:", attrString);
		}

		public NSAttributedString attributedString()
		{
			return Call("attributedString").To<NSAttributedString>();
		}

		public void setParagraphGlyphRangeSeparatorGlyphRange(NSRange paragraphRange, NSRange paragraphSeparatorRange)
		{
			Unused.Value = Call("setParagraphGlyphRange:separatorGlyphRange:", paragraphRange, paragraphSeparatorRange);
		}

		public NSRange paragraphGlyphRange()
		{
			return Call("paragraphGlyphRange").To<NSRange>();
		}

		public NSRange paragraphSeparatorGlyphRange()
		{
			return Call("paragraphSeparatorGlyphRange").To<NSRange>();
		}

		public NSRange paragraphCharacterRange()
		{
			return Call("paragraphCharacterRange").To<NSRange>();
		}

		public NSRange paragraphSeparatorCharacterRange()
		{
			return Call("paragraphSeparatorCharacterRange").To<NSRange>();
		}

		public UInt32 layoutParagraphAtPoint(IntPtr lineFragmentOrigin)
		{
			return Call("layoutParagraphAtPoint:", lineFragmentOrigin).To<UInt32>();
		}

		public void beginParagraph()
		{
			Unused.Value = Call("beginParagraph");
		}

		public void endParagraph()
		{
			Unused.Value = Call("endParagraph");
		}

		public void beginLineWithGlyphAtIndex(UInt32 glyphIndex)
		{
			Unused.Value = Call("beginLineWithGlyphAtIndex:", glyphIndex);
		}

		public void endLineWithGlyphRange(NSRange lineGlyphRange)
		{
			Unused.Value = Call("endLineWithGlyphRange:", lineGlyphRange);
		}

		public float lineSpacingAfterGlyphAtIndexWithProposedLineFragmentRect(UInt32 glyphIndex, NSRect rect)
		{
			return Call("lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:", glyphIndex, rect).To<float>();
		}

		public float paragraphSpacingBeforeGlyphAtIndexWithProposedLineFragmentRect(UInt32 glyphIndex, NSRect rect)
		{
			return Call("paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:", glyphIndex, rect).To<float>();
		}

		public float paragraphSpacingAfterGlyphAtIndexWithProposedLineFragmentRect(UInt32 glyphIndex, NSRect rect)
		{
			return Call("paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:", glyphIndex, rect).To<float>();
		}

		public void getLineFragmentRectUsedRectForParagraphSeparatorGlyphRangeAtProposedOrigin(IntPtr lineFragmentRect, IntPtr lineFragmentUsedRect, NSRange paragraphSeparatorGlyphRange, NSPoint lineOrigin)
		{
			Unused.Value = Call("getLineFragmentRect:usedRect:forParagraphSeparatorGlyphRange:atProposedOrigin:", lineFragmentRect, lineFragmentUsedRect, paragraphSeparatorGlyphRange, lineOrigin);
		}

		public NSDictionary attributesForExtraLineFragment()
		{
			return Call("attributesForExtraLineFragment").To<NSDictionary>();
		}

		public UInt32 actionForControlCharacterAtIndex(UInt32 charIndex)
		{
			return Call("actionForControlCharacterAtIndex:", charIndex).To<UInt32>();
		}

		public NSLayoutManager layoutManager()
		{
			return Call("layoutManager").To<NSLayoutManager>();
		}

		public NSArray textContainers()
		{
			return Call("textContainers").To<NSArray>();
		}

		public NSTextContainer currentTextContainer()
		{
			return Call("currentTextContainer").To<NSTextContainer>();
		}

		public NSParagraphStyle currentParagraphStyle()
		{
			return Call("currentParagraphStyle").To<NSParagraphStyle>();
		}

		public void setHardInvalidationForGlyphRange(bool flag, NSRange glyphRange)
		{
			Unused.Value = Call("setHardInvalidation:forGlyphRange:", flag, glyphRange);
		}

		public void layoutGlyphsInLayoutManagerStartingAtGlyphIndexMaxNumberOfLineFragmentsNextGlyphIndex(NSLayoutManager layoutManager, UInt32 startGlyphIndex, UInt32 maxNumLines, IntPtr nextGlyph)
		{
			Unused.Value = Call("layoutGlyphsInLayoutManager:startingAtGlyphIndex:maxNumberOfLineFragments:nextGlyphIndex:", layoutManager, startGlyphIndex, maxNumLines, nextGlyph);
		}

		public NSRange layoutCharactersInRangeForLayoutManagerMaximumNumberOfLineFragmentsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSRange characterRange, NSLayoutManager layoutManager, UInt32 maxNumLines)
		{
			return Call("layoutCharactersInRange:forLayoutManager:maximumNumberOfLineFragments:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", characterRange, layoutManager, maxNumLines).To<NSRange>();
		}

		public static NSSize printingAdjustmentInLayoutManagerForNominallySpacedGlyphRangePackedGlyphsCount(NSLayoutManager layoutMgr, NSRange nominallySpacedGlyphsRange, IntPtr packedGlyphs, UInt32 packedGlyphsCount)
		{
			return ms_class.Call("printingAdjustmentInLayoutManager:forNominallySpacedGlyphRange:packedGlyphs:count:", layoutMgr, nominallySpacedGlyphsRange, packedGlyphs, packedGlyphsCount).To<NSSize>();
		}

		public float baselineOffsetInLayoutManagerGlyphIndex(NSLayoutManager layoutMgr, UInt32 glyphIndex)
		{
			return Call("baselineOffsetInLayoutManager:glyphIndex:", layoutMgr, glyphIndex).To<float>();
		}

		public static NSObject sharedSystemTypesetter()
		{
			return ms_class.Call("sharedSystemTypesetter").To<NSObject>();
		}

		public static NSObject sharedSystemTypesetterForBehavior(Int32 theBehavior)
		{
			return ms_class.Call("sharedSystemTypesetterForBehavior:", theBehavior).To<NSObject>();
		}

		public static Int32 defaultTypesetterBehavior()
		{
			return ms_class.Call("defaultTypesetterBehavior").To<Int32>();
		}

		private static Class ms_class = new Class("NSTypesetter");
	}

	public static class NSLayoutPhaseInterfaceForNSTypesetterCategory
	{
		public static void willSetLineFragmentRectForGlyphRangeUsedRectBaselineOffset(this NSTypesetter _instance, IntPtr lineRect, NSRange glyphRange, IntPtr usedRect, IntPtr baselineOffset)
		{
			Unused.Value = _instance.Call("willSetLineFragmentRect:forGlyphRange:usedRect:baselineOffset:", lineRect, glyphRange, usedRect, baselineOffset);
		}

		public static bool shouldBreakLineByWordBeforeCharacterAtIndex(this NSTypesetter _instance, UInt32 charIndex)
		{
			return _instance.Call("shouldBreakLineByWordBeforeCharacterAtIndex:", charIndex).To<bool>();
		}

		public static bool shouldBreakLineByHyphenatingBeforeCharacterAtIndex(this NSTypesetter _instance, UInt32 charIndex)
		{
			return _instance.Call("shouldBreakLineByHyphenatingBeforeCharacterAtIndex:", charIndex).To<bool>();
		}

		public static float hyphenationFactorForGlyphAtIndex(this NSTypesetter _instance, UInt32 glyphIndex)
		{
			return _instance.Call("hyphenationFactorForGlyphAtIndex:", glyphIndex).To<float>();
		}

		public static UInt32 hyphenCharacterForGlyphAtIndex(this NSTypesetter _instance, UInt32 glyphIndex)
		{
			return _instance.Call("hyphenCharacterForGlyphAtIndex:", glyphIndex).To<UInt32>();
		}

		public static NSRect boundingBoxForControlGlyphAtIndexForTextContainerProposedLineFragmentGlyphPositionCharacterIndex(this NSTypesetter _instance, UInt32 glyphIndex, NSTextContainer textContainer, NSRect proposedRect, NSPoint glyphPosition, UInt32 charIndex)
		{
			return _instance.Call("boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:", glyphIndex, textContainer, proposedRect, glyphPosition, charIndex).To<NSRect>();
		}
	}

	public static class NSGlyphStorageInterfaceForNSTypesetterCategory
	{
		public static NSRange characterRangeForGlyphRangeActualGlyphRange(this NSTypesetter _instance, NSRange glyphRange, IntPtr actualGlyphRange)
		{
			return _instance.Call("characterRangeForGlyphRange:actualGlyphRange:", glyphRange, actualGlyphRange).To<NSRange>();
		}

		public static NSRange glyphRangeForCharacterRangeActualCharacterRange(this NSTypesetter _instance, NSRange charRange, IntPtr actualCharRange)
		{
			return _instance.Call("glyphRangeForCharacterRange:actualCharacterRange:", charRange, actualCharRange).To<NSRange>();
		}

		public static UInt32 getGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBitsBidiLevels(this NSTypesetter _instance, NSRange glyphsRange, IntPtr glyphBuffer, IntPtr charIndexBuffer, IntPtr inscribeBuffer, IntPtr elasticBuffer, IntPtr bidiLevelBuffer)
		{
			return _instance.Call("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:", glyphsRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer, bidiLevelBuffer).To<UInt32>();
		}

		public static void getLineFragmentRectUsedRectRemainingRectForStartingGlyphAtIndexProposedRectLineSpacingParagraphSpacingBeforeParagraphSpacingAfter(this NSTypesetter _instance, IntPtr lineFragmentRect, IntPtr lineFragmentUsedRect, IntPtr remainingRect, UInt32 startingGlyphIndex, NSRect proposedRect, float lineSpacing, float paragraphSpacingBefore, float paragraphSpacingAfter)
		{
			Unused.Value = _instance.Call("getLineFragmentRect:usedRect:remainingRect:forStartingGlyphAtIndex:proposedRect:lineSpacing:paragraphSpacingBefore:paragraphSpacingAfter:", lineFragmentRect, lineFragmentUsedRect, remainingRect, startingGlyphIndex, proposedRect, lineSpacing, paragraphSpacingBefore, paragraphSpacingAfter);
		}

		public static void setLineFragmentRectForGlyphRangeUsedRectBaselineOffset(this NSTypesetter _instance, NSRect fragmentRect, NSRange glyphRange, NSRect usedRect, float baselineOffset)
		{
			Unused.Value = _instance.Call("setLineFragmentRect:forGlyphRange:usedRect:baselineOffset:", fragmentRect, glyphRange, usedRect, baselineOffset);
		}

		public static void substituteGlyphsInRangeWithGlyphs(this NSTypesetter _instance, NSRange glyphRange, IntPtr glyphs)
		{
			Unused.Value = _instance.Call("substituteGlyphsInRange:withGlyphs:", glyphRange, glyphs);
		}

		public static void insertGlyphAtGlyphIndexCharacterIndex(this NSTypesetter _instance, UInt32 glyph, UInt32 glyphIndex, UInt32 characterIndex)
		{
			Unused.Value = _instance.Call("insertGlyph:atGlyphIndex:characterIndex:", glyph, glyphIndex, characterIndex);
		}

		public static void deleteGlyphsInRange(this NSTypesetter _instance, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("deleteGlyphsInRange:", glyphRange);
		}

		public static void setNotShownAttributeForGlyphRange(this NSTypesetter _instance, bool flag, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setNotShownAttribute:forGlyphRange:", flag, glyphRange);
		}

		public static void setDrawsOutsideLineFragmentForGlyphRange(this NSTypesetter _instance, bool flag, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setDrawsOutsideLineFragment:forGlyphRange:", flag, glyphRange);
		}

		public static void setLocationWithAdvancementsForStartOfGlyphRange(this NSTypesetter _instance, NSPoint location, IntPtr advancements, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setLocation:withAdvancements:forStartOfGlyphRange:", location, advancements, glyphRange);
		}

		public static void setAttachmentSizeForGlyphRange(this NSTypesetter _instance, NSSize attachmentSize, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setAttachmentSize:forGlyphRange:", attachmentSize, glyphRange);
		}

		public static void setBidiLevelsForGlyphRange(this NSTypesetter _instance, IntPtr levels, NSRange glyphRange)
		{
			Unused.Value = _instance.Call("setBidiLevels:forGlyphRange:", levels, glyphRange);
		}
	}
}
