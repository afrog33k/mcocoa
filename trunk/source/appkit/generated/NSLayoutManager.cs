// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSLayoutManager.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSGlyphAttributeSoft = 0;
		public const int NSGlyphAttributeElastic = 1;
		public const int NSGlyphAttributeBidiLevel = 2;
		public const int NSGlyphAttributeInscribe = 5;
	}

	public partial class Enums
	{
		public const int NSGlyphInscribeBase = 0;
		public const int NSGlyphInscribeBelow = 1;
		public const int NSGlyphInscribeAbove = 2;
		public const int NSGlyphInscribeOverstrike = 3;
		public const int NSGlyphInscribeOverBelow = 4;
	}

	public partial class Enums
	{
		public const int NSTypesetterLatestBehavior = -1;
		public const int NSTypesetterOriginalBehavior = 0;
		public const int NSTypesetterBehavior_10_2_WithCompatibility = 1;
		public const int NSTypesetterBehavior_10_2 = 2;
		public const int NSTypesetterBehavior_10_3 = 3;
		public const int NSTypesetterBehavior_10_4 = 4;
	}

	[Register]
	public partial class NSLayoutManager : NSObject
	{
		public NSLayoutManager() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSLayoutManager(IntPtr instance) : base(instance)
		{
		}

		public NSLayoutManager(Untyped instance) : base(instance)
		{
		}

		public static new NSLayoutManager alloc()
		{
			return new NSLayoutManager(ms_class.Call("alloc"));
		}

		public new NSLayoutManager retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public NSTextStorage textStorage()
		{
			return Call("textStorage").To<NSTextStorage>();
		}

		public void setTextStorage(NSTextStorage textStorage)
		{
			Unused.Value = Call("setTextStorage:", textStorage);
		}

		public NSAttributedString attributedString()
		{
			return Call("attributedString").To<NSAttributedString>();
		}

		public void replaceTextStorage(NSTextStorage newTextStorage)
		{
			Unused.Value = Call("replaceTextStorage:", newTextStorage);
		}

		public NSGlyphGenerator glyphGenerator()
		{
			return Call("glyphGenerator").To<NSGlyphGenerator>();
		}

		public void setGlyphGenerator(NSGlyphGenerator glyphGenerator)
		{
			Unused.Value = Call("setGlyphGenerator:", glyphGenerator);
		}

		public NSTypesetter typesetter()
		{
			return Call("typesetter").To<NSTypesetter>();
		}

		public void setTypesetter(NSTypesetter typesetter)
		{
			Unused.Value = Call("setTypesetter:", typesetter);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSArray textContainers()
		{
			return Call("textContainers").To<NSArray>();
		}

		public void addTextContainer(NSTextContainer container)
		{
			Unused.Value = Call("addTextContainer:", container);
		}

		public void insertTextContainerAtIndex(NSTextContainer container, UInt32 index)
		{
			Unused.Value = Call("insertTextContainer:atIndex:", container, index);
		}

		public void removeTextContainerAtIndex(UInt32 index)
		{
			Unused.Value = Call("removeTextContainerAtIndex:", index);
		}

		public void textContainerChangedGeometry(NSTextContainer container)
		{
			Unused.Value = Call("textContainerChangedGeometry:", container);
		}

		public void textContainerChangedTextView(NSTextContainer container)
		{
			Unused.Value = Call("textContainerChangedTextView:", container);
		}

		public void setBackgroundLayoutEnabled(bool flag)
		{
			Unused.Value = Call("setBackgroundLayoutEnabled:", flag);
		}

		public bool backgroundLayoutEnabled()
		{
			return Call("backgroundLayoutEnabled").To<bool>();
		}

		public void setUsesScreenFonts(bool flag)
		{
			Unused.Value = Call("setUsesScreenFonts:", flag);
		}

		public bool usesScreenFonts()
		{
			return Call("usesScreenFonts").To<bool>();
		}

		public void setShowsInvisibleCharacters(bool flag)
		{
			Unused.Value = Call("setShowsInvisibleCharacters:", flag);
		}

		public bool showsInvisibleCharacters()
		{
			return Call("showsInvisibleCharacters").To<bool>();
		}

		public void setShowsControlCharacters(bool flag)
		{
			Unused.Value = Call("setShowsControlCharacters:", flag);
		}

		public bool showsControlCharacters()
		{
			return Call("showsControlCharacters").To<bool>();
		}

		public void setHyphenationFactor(float factor)
		{
			Unused.Value = Call("setHyphenationFactor:", factor);
		}

		public float hyphenationFactor()
		{
			return Call("hyphenationFactor").To<float>();
		}

		public void setDefaultAttachmentScaling(UInt32 scaling)
		{
			Unused.Value = Call("setDefaultAttachmentScaling:", scaling);
		}

		public UInt32 defaultAttachmentScaling()
		{
			return Call("defaultAttachmentScaling").To<UInt32>();
		}

		public void setTypesetterBehavior(Int32 theBehavior)
		{
			Unused.Value = Call("setTypesetterBehavior:", theBehavior);
		}

		public Int32 typesetterBehavior()
		{
			return Call("typesetterBehavior").To<Int32>();
		}

		public UInt32 layoutOptions()
		{
			return Call("layoutOptions").To<UInt32>();
		}

		public void setAllowsNonContiguousLayout(bool flag)
		{
			Unused.Value = Call("setAllowsNonContiguousLayout:", flag);
		}

		public bool allowsNonContiguousLayout()
		{
			return Call("allowsNonContiguousLayout").To<bool>();
		}

		public bool hasNonContiguousLayout()
		{
			return Call("hasNonContiguousLayout").To<bool>();
		}

		public void invalidateGlyphsForCharacterRangeChangeInLengthActualCharacterRange(NSRange charRange, Int32 delta, IntPtr actualCharRange)
		{
			Unused.Value = Call("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:", charRange, delta, actualCharRange);
		}

		public void invalidateLayoutForCharacterRangeActualCharacterRange(NSRange charRange, IntPtr actualCharRange)
		{
			Unused.Value = Call("invalidateLayoutForCharacterRange:actualCharacterRange:", charRange, actualCharRange);
		}

		public void invalidateLayoutForCharacterRangeIsSoftActualCharacterRange(NSRange charRange, bool flag, IntPtr actualCharRange)
		{
			Unused.Value = Call("invalidateLayoutForCharacterRange:isSoft:actualCharacterRange:", charRange, flag, actualCharRange);
		}

		public void invalidateDisplayForCharacterRange(NSRange charRange)
		{
			Unused.Value = Call("invalidateDisplayForCharacterRange:", charRange);
		}

		public void invalidateDisplayForGlyphRange(NSRange glyphRange)
		{
			Unused.Value = Call("invalidateDisplayForGlyphRange:", glyphRange);
		}

		public void textStorageEditedRangeChangeInLengthInvalidatedRange(NSTextStorage str, UInt32 editedMask, NSRange newCharRange, Int32 delta, NSRange invalidatedCharRange)
		{
			Unused.Value = Call("textStorage:edited:range:changeInLength:invalidatedRange:", str, editedMask, newCharRange, delta, invalidatedCharRange);
		}

		public void ensureGlyphsForCharacterRange(NSRange charRange)
		{
			Unused.Value = Call("ensureGlyphsForCharacterRange:", charRange);
		}

		public void ensureGlyphsForGlyphRange(NSRange glyphRange)
		{
			Unused.Value = Call("ensureGlyphsForGlyphRange:", glyphRange);
		}

		public void ensureLayoutForCharacterRange(NSRange charRange)
		{
			Unused.Value = Call("ensureLayoutForCharacterRange:", charRange);
		}

		public void ensureLayoutForGlyphRange(NSRange glyphRange)
		{
			Unused.Value = Call("ensureLayoutForGlyphRange:", glyphRange);
		}

		public void ensureLayoutForTextContainer(NSTextContainer container)
		{
			Unused.Value = Call("ensureLayoutForTextContainer:", container);
		}

		public void ensureLayoutForBoundingRectInTextContainer(NSRect bounds, NSTextContainer container)
		{
			Unused.Value = Call("ensureLayoutForBoundingRect:inTextContainer:", bounds, container);
		}

		public void insertGlyphsLengthForStartingGlyphAtIndexCharacterIndex(IntPtr glyphs, UInt32 length, UInt32 glyphIndex, UInt32 charIndex)
		{
			Unused.Value = Call("insertGlyphs:length:forStartingGlyphAtIndex:characterIndex:", glyphs, length, glyphIndex, charIndex);
		}

		public void insertGlyphAtGlyphIndexCharacterIndex(UInt32 glyph, UInt32 glyphIndex, UInt32 charIndex)
		{
			Unused.Value = Call("insertGlyph:atGlyphIndex:characterIndex:", glyph, glyphIndex, charIndex);
		}

		public void replaceGlyphAtIndexWithGlyph(UInt32 glyphIndex, UInt32 newGlyph)
		{
			Unused.Value = Call("replaceGlyphAtIndex:withGlyph:", glyphIndex, newGlyph);
		}

		public void deleteGlyphsInRange(NSRange glyphRange)
		{
			Unused.Value = Call("deleteGlyphsInRange:", glyphRange);
		}

		public void setCharacterIndexForGlyphAtIndex(UInt32 charIndex, UInt32 glyphIndex)
		{
			Unused.Value = Call("setCharacterIndex:forGlyphAtIndex:", charIndex, glyphIndex);
		}

		public void setIntAttributeValueForGlyphAtIndex(Int32 attributeTag, Int32 val, UInt32 glyphIndex)
		{
			Unused.Value = Call("setIntAttribute:value:forGlyphAtIndex:", attributeTag, val, glyphIndex);
		}

		public void invalidateGlyphsOnLayoutInvalidationForGlyphRange(NSRange glyphRange)
		{
			Unused.Value = Call("invalidateGlyphsOnLayoutInvalidationForGlyphRange:", glyphRange);
		}

		public UInt32 numberOfGlyphs()
		{
			return Call("numberOfGlyphs").To<UInt32>();
		}

		public UInt32 glyphAtIndexIsValidIndex(UInt32 glyphIndex, IntPtr isValidIndex)
		{
			return Call("glyphAtIndex:isValidIndex:", glyphIndex, isValidIndex).To<UInt32>();
		}

		public UInt32 glyphAtIndex(UInt32 glyphIndex)
		{
			return Call("glyphAtIndex:", glyphIndex).To<UInt32>();
		}

		public bool isValidGlyphIndex(UInt32 glyphIndex)
		{
			return Call("isValidGlyphIndex:", glyphIndex).To<bool>();
		}

		public UInt32 characterIndexForGlyphAtIndex(UInt32 glyphIndex)
		{
			return Call("characterIndexForGlyphAtIndex:", glyphIndex).To<UInt32>();
		}

		public UInt32 glyphIndexForCharacterAtIndex(UInt32 charIndex)
		{
			return Call("glyphIndexForCharacterAtIndex:", charIndex).To<UInt32>();
		}

		public Int32 intAttributeForGlyphAtIndex(Int32 attributeTag, UInt32 glyphIndex)
		{
			return Call("intAttribute:forGlyphAtIndex:", attributeTag, glyphIndex).To<Int32>();
		}

		public UInt32 getGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBits(NSRange glyphRange, IntPtr glyphBuffer, IntPtr charIndexBuffer, IntPtr inscribeBuffer, IntPtr elasticBuffer)
		{
			return Call("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:", glyphRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer).To<UInt32>();
		}

		public UInt32 getGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBitsBidiLevels(NSRange glyphRange, IntPtr glyphBuffer, IntPtr charIndexBuffer, IntPtr inscribeBuffer, IntPtr elasticBuffer, IntPtr bidiLevelBuffer)
		{
			return Call("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:", glyphRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer, bidiLevelBuffer).To<UInt32>();
		}

		public UInt32 getGlyphsRange(IntPtr glyphArray, NSRange glyphRange)
		{
			return Call("getGlyphs:range:", glyphArray, glyphRange).To<UInt32>();
		}

		public void setTextContainerForGlyphRange(NSTextContainer container, NSRange glyphRange)
		{
			Unused.Value = Call("setTextContainer:forGlyphRange:", container, glyphRange);
		}

		public void setLineFragmentRectForGlyphRangeUsedRect(NSRect fragmentRect, NSRange glyphRange, NSRect usedRect)
		{
			Unused.Value = Call("setLineFragmentRect:forGlyphRange:usedRect:", fragmentRect, glyphRange, usedRect);
		}

		public void setExtraLineFragmentRectUsedRectTextContainer(NSRect fragmentRect, NSRect usedRect, NSTextContainer container)
		{
			Unused.Value = Call("setExtraLineFragmentRect:usedRect:textContainer:", fragmentRect, usedRect, container);
		}

		public void setLocationForStartOfGlyphRange(NSPoint location, NSRange glyphRange)
		{
			Unused.Value = Call("setLocation:forStartOfGlyphRange:", location, glyphRange);
		}

		public void setLocationsStartingGlyphIndexesCountForGlyphRange(IntPtr locations, IntPtr glyphIndexes, UInt32 count, NSRange glyphRange)
		{
			Unused.Value = Call("setLocations:startingGlyphIndexes:count:forGlyphRange:", locations, glyphIndexes, count, glyphRange);
		}

		public void setNotShownAttributeForGlyphAtIndex(bool flag, UInt32 glyphIndex)
		{
			Unused.Value = Call("setNotShownAttribute:forGlyphAtIndex:", flag, glyphIndex);
		}

		public void setDrawsOutsideLineFragmentForGlyphAtIndex(bool flag, UInt32 glyphIndex)
		{
			Unused.Value = Call("setDrawsOutsideLineFragment:forGlyphAtIndex:", flag, glyphIndex);
		}

		public void setAttachmentSizeForGlyphRange(NSSize attachmentSize, NSRange glyphRange)
		{
			Unused.Value = Call("setAttachmentSize:forGlyphRange:", attachmentSize, glyphRange);
		}

		public void getFirstUnlaidCharacterIndexGlyphIndex(IntPtr charIndex, IntPtr glyphIndex)
		{
			Unused.Value = Call("getFirstUnlaidCharacterIndex:glyphIndex:", charIndex, glyphIndex);
		}

		public UInt32 firstUnlaidCharacterIndex()
		{
			return Call("firstUnlaidCharacterIndex").To<UInt32>();
		}

		public UInt32 firstUnlaidGlyphIndex()
		{
			return Call("firstUnlaidGlyphIndex").To<UInt32>();
		}

		public NSTextContainer textContainerForGlyphAtIndexEffectiveRange(UInt32 glyphIndex, IntPtr effectiveGlyphRange)
		{
			return Call("textContainerForGlyphAtIndex:effectiveRange:", glyphIndex, effectiveGlyphRange).To<NSTextContainer>();
		}

		public NSRect usedRectForTextContainer(NSTextContainer container)
		{
			return Call("usedRectForTextContainer:", container).To<NSRect>();
		}

		public NSRect lineFragmentRectForGlyphAtIndexEffectiveRange(UInt32 glyphIndex, IntPtr effectiveGlyphRange)
		{
			return Call("lineFragmentRectForGlyphAtIndex:effectiveRange:", glyphIndex, effectiveGlyphRange).To<NSRect>();
		}

		public NSRect lineFragmentUsedRectForGlyphAtIndexEffectiveRange(UInt32 glyphIndex, IntPtr effectiveGlyphRange)
		{
			return Call("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:", glyphIndex, effectiveGlyphRange).To<NSRect>();
		}

		public NSRect lineFragmentRectForGlyphAtIndexEffectiveRangeWithoutAdditionalLayout(UInt32 glyphIndex, IntPtr effectiveGlyphRange, bool flag)
		{
			return Call("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:", glyphIndex, effectiveGlyphRange, flag).To<NSRect>();
		}

		public NSRect lineFragmentUsedRectForGlyphAtIndexEffectiveRangeWithoutAdditionalLayout(UInt32 glyphIndex, IntPtr effectiveGlyphRange, bool flag)
		{
			return Call("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:", glyphIndex, effectiveGlyphRange, flag).To<NSRect>();
		}

		public NSTextContainer textContainerForGlyphAtIndexEffectiveRangeWithoutAdditionalLayout(UInt32 glyphIndex, IntPtr effectiveGlyphRange, bool flag)
		{
			return Call("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:", glyphIndex, effectiveGlyphRange, flag).To<NSTextContainer>();
		}

		public NSRect extraLineFragmentRect()
		{
			return Call("extraLineFragmentRect").To<NSRect>();
		}

		public NSRect extraLineFragmentUsedRect()
		{
			return Call("extraLineFragmentUsedRect").To<NSRect>();
		}

		public NSTextContainer extraLineFragmentTextContainer()
		{
			return Call("extraLineFragmentTextContainer").To<NSTextContainer>();
		}

		public NSPoint locationForGlyphAtIndex(UInt32 glyphIndex)
		{
			return Call("locationForGlyphAtIndex:", glyphIndex).To<NSPoint>();
		}

		public bool notShownAttributeForGlyphAtIndex(UInt32 glyphIndex)
		{
			return Call("notShownAttributeForGlyphAtIndex:", glyphIndex).To<bool>();
		}

		public bool drawsOutsideLineFragmentForGlyphAtIndex(UInt32 glyphIndex)
		{
			return Call("drawsOutsideLineFragmentForGlyphAtIndex:", glyphIndex).To<bool>();
		}

		public NSSize attachmentSizeForGlyphAtIndex(UInt32 glyphIndex)
		{
			return Call("attachmentSizeForGlyphAtIndex:", glyphIndex).To<NSSize>();
		}

		public void setLayoutRectForTextBlockGlyphRange(NSRect rect, NSTextBlock block, NSRange glyphRange)
		{
			Unused.Value = Call("setLayoutRect:forTextBlock:glyphRange:", rect, block, glyphRange);
		}

		public void setBoundsRectForTextBlockGlyphRange(NSRect rect, NSTextBlock block, NSRange glyphRange)
		{
			Unused.Value = Call("setBoundsRect:forTextBlock:glyphRange:", rect, block, glyphRange);
		}

		public NSRect layoutRectForTextBlockGlyphRange(NSTextBlock block, NSRange glyphRange)
		{
			return Call("layoutRectForTextBlock:glyphRange:", block, glyphRange).To<NSRect>();
		}

		public NSRect boundsRectForTextBlockGlyphRange(NSTextBlock block, NSRange glyphRange)
		{
			return Call("boundsRectForTextBlock:glyphRange:", block, glyphRange).To<NSRect>();
		}

		public NSRect layoutRectForTextBlockAtIndexEffectiveRange(NSTextBlock block, UInt32 glyphIndex, IntPtr effectiveGlyphRange)
		{
			return Call("layoutRectForTextBlock:atIndex:effectiveRange:", block, glyphIndex, effectiveGlyphRange).To<NSRect>();
		}

		public NSRect boundsRectForTextBlockAtIndexEffectiveRange(NSTextBlock block, UInt32 glyphIndex, IntPtr effectiveGlyphRange)
		{
			return Call("boundsRectForTextBlock:atIndex:effectiveRange:", block, glyphIndex, effectiveGlyphRange).To<NSRect>();
		}

		public NSRange glyphRangeForCharacterRangeActualCharacterRange(NSRange charRange, IntPtr actualCharRange)
		{
			return Call("glyphRangeForCharacterRange:actualCharacterRange:", charRange, actualCharRange).To<NSRange>();
		}

		public NSRange characterRangeForGlyphRangeActualGlyphRange(NSRange glyphRange, IntPtr actualGlyphRange)
		{
			return Call("characterRangeForGlyphRange:actualGlyphRange:", glyphRange, actualGlyphRange).To<NSRange>();
		}

		public NSRange glyphRangeForTextContainer(NSTextContainer container)
		{
			return Call("glyphRangeForTextContainer:", container).To<NSRange>();
		}

		public NSRange rangeOfNominallySpacedGlyphsContainingIndex(UInt32 glyphIndex)
		{
			return Call("rangeOfNominallySpacedGlyphsContainingIndex:", glyphIndex).To<NSRange>();
		}

		public IntPtr rectArrayForCharacterRangeWithinSelectedCharacterRangeInTextContainerRectCount(NSRange charRange, NSRange selCharRange, NSTextContainer container, IntPtr rectCount)
		{
			return Call("rectArrayForCharacterRange:withinSelectedCharacterRange:inTextContainer:rectCount:", charRange, selCharRange, container, rectCount).To<IntPtr>();
		}

		public IntPtr rectArrayForGlyphRangeWithinSelectedGlyphRangeInTextContainerRectCount(NSRange glyphRange, NSRange selGlyphRange, NSTextContainer container, IntPtr rectCount)
		{
			return Call("rectArrayForGlyphRange:withinSelectedGlyphRange:inTextContainer:rectCount:", glyphRange, selGlyphRange, container, rectCount).To<IntPtr>();
		}

		public NSRect boundingRectForGlyphRangeInTextContainer(NSRange glyphRange, NSTextContainer container)
		{
			return Call("boundingRectForGlyphRange:inTextContainer:", glyphRange, container).To<NSRect>();
		}

		public NSRange glyphRangeForBoundingRectInTextContainer(NSRect bounds, NSTextContainer container)
		{
			return Call("glyphRangeForBoundingRect:inTextContainer:", bounds, container).To<NSRange>();
		}

		public NSRange glyphRangeForBoundingRectWithoutAdditionalLayoutInTextContainer(NSRect bounds, NSTextContainer container)
		{
			return Call("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:", bounds, container).To<NSRange>();
		}

		public UInt32 glyphIndexForPointInTextContainerFractionOfDistanceThroughGlyph(NSPoint point, NSTextContainer container, IntPtr partialFraction)
		{
			return Call("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:", point, container, partialFraction).To<UInt32>();
		}

		public UInt32 glyphIndexForPointInTextContainer(NSPoint point, NSTextContainer container)
		{
			return Call("glyphIndexForPoint:inTextContainer:", point, container).To<UInt32>();
		}

		public float fractionOfDistanceThroughGlyphForPointInTextContainer(NSPoint point, NSTextContainer container)
		{
			return Call("fractionOfDistanceThroughGlyphForPoint:inTextContainer:", point, container).To<float>();
		}

		public UInt32 getLineFragmentInsertionPointsForCharacterAtIndexAlternatePositionsInDisplayOrderPositionsCharacterIndexes(UInt32 charIndex, bool aFlag, bool dFlag, IntPtr positions, IntPtr charIndexes)
		{
			return Call("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:", charIndex, aFlag, dFlag, positions, charIndexes).To<UInt32>();
		}

		public NSDictionary temporaryAttributesAtCharacterIndexEffectiveRange(UInt32 charIndex, IntPtr effectiveCharRange)
		{
			return Call("temporaryAttributesAtCharacterIndex:effectiveRange:", charIndex, effectiveCharRange).To<NSDictionary>();
		}

		public void setTemporaryAttributesForCharacterRange(NSDictionary attrs, NSRange charRange)
		{
			Unused.Value = Call("setTemporaryAttributes:forCharacterRange:", attrs, charRange);
		}

		public void addTemporaryAttributesForCharacterRange(NSDictionary attrs, NSRange charRange)
		{
			Unused.Value = Call("addTemporaryAttributes:forCharacterRange:", attrs, charRange);
		}

		public void removeTemporaryAttributeForCharacterRange(NSString attrName, NSRange charRange)
		{
			Unused.Value = Call("removeTemporaryAttribute:forCharacterRange:", attrName, charRange);
		}

		public NSObject temporaryAttributeAtCharacterIndexEffectiveRange(NSString attrName, UInt32 location, IntPtr range)
		{
			return Call("temporaryAttribute:atCharacterIndex:effectiveRange:", attrName, location, range).To<NSObject>();
		}

		public NSObject temporaryAttributeAtCharacterIndexLongestEffectiveRangeInRange(NSString attrName, UInt32 location, IntPtr range, NSRange rangeLimit)
		{
			return Call("temporaryAttribute:atCharacterIndex:longestEffectiveRange:inRange:", attrName, location, range, rangeLimit).To<NSObject>();
		}

		public NSDictionary temporaryAttributesAtCharacterIndexLongestEffectiveRangeInRange(UInt32 location, IntPtr range, NSRange rangeLimit)
		{
			return Call("temporaryAttributesAtCharacterIndex:longestEffectiveRange:inRange:", location, range, rangeLimit).To<NSDictionary>();
		}

		public void addTemporaryAttributeValueForCharacterRange(NSString attrName, NSObject value, NSRange charRange)
		{
			Unused.Value = Call("addTemporaryAttribute:value:forCharacterRange:", attrName, value, charRange);
		}

		public NSFont substituteFontForFont(NSFont originalFont)
		{
			return Call("substituteFontForFont:", originalFont).To<NSFont>();
		}

		public float defaultLineHeightForFont(NSFont theFont)
		{
			return Call("defaultLineHeightForFont:", theFont).To<float>();
		}

		public float defaultBaselineOffsetForFont(NSFont theFont)
		{
			return Call("defaultBaselineOffsetForFont:", theFont).To<float>();
		}

		public bool usesFontLeading()
		{
			return Call("usesFontLeading").To<bool>();
		}

		public void setUsesFontLeading(bool flag)
		{
			Unused.Value = Call("setUsesFontLeading:", flag);
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

		#region NSGlyphStorage Methods



		#endregion

		private static Class ms_class = new Class("NSLayoutManager");
	}

	public static class NSTextViewSupportForNSLayoutManagerCategory
	{
		public static NSArray rulerMarkersForTextViewParagraphStyleRuler(this NSLayoutManager _instance, NSTextView view, NSParagraphStyle style, NSRulerView ruler)
		{
			return _instance.Call("rulerMarkersForTextView:paragraphStyle:ruler:", view, style, ruler).To<NSArray>();
		}

		public static NSView rulerAccessoryViewForTextViewParagraphStyleRulerEnabled(this NSLayoutManager _instance, NSTextView view, NSParagraphStyle style, NSRulerView ruler, bool isEnabled)
		{
			return _instance.Call("rulerAccessoryViewForTextView:paragraphStyle:ruler:enabled:", view, style, ruler, isEnabled).To<NSView>();
		}

		public static bool layoutManagerOwnsFirstResponderInWindow(this NSLayoutManager _instance, NSWindow window)
		{
			return _instance.Call("layoutManagerOwnsFirstResponderInWindow:", window).To<bool>();
		}

		public static NSTextView firstTextView(this NSLayoutManager _instance)
		{
			return _instance.Call("firstTextView").To<NSTextView>();
		}

		public static NSTextView textViewForBeginningOfSelection(this NSLayoutManager _instance)
		{
			return _instance.Call("textViewForBeginningOfSelection").To<NSTextView>();
		}

		public static void drawBackgroundForGlyphRangeAtPoint(this NSLayoutManager _instance, NSRange glyphsToShow, NSPoint origin)
		{
			Unused.Value = _instance.Call("drawBackgroundForGlyphRange:atPoint:", glyphsToShow, origin);
		}

		public static void drawGlyphsForGlyphRangeAtPoint(this NSLayoutManager _instance, NSRange glyphsToShow, NSPoint origin)
		{
			Unused.Value = _instance.Call("drawGlyphsForGlyphRange:atPoint:", glyphsToShow, origin);
		}

		public static void showPackedGlyphsLengthGlyphRangeAtPointFontColorPrintingAdjustment(this NSLayoutManager _instance, IntPtr glyphs, UInt32 glyphLen, NSRange glyphRange, NSPoint point, NSFont font, NSColor color, NSSize printingAdjustment)
		{
			Unused.Value = _instance.Call("showPackedGlyphs:length:glyphRange:atPoint:font:color:printingAdjustment:", glyphs, glyphLen, glyphRange, point, font, color, printingAdjustment);
		}

		public static void showAttachmentCellInRectCharacterIndex(this NSLayoutManager _instance, NSCell cell, NSRect rect, UInt32 attachmentIndex)
		{
			Unused.Value = _instance.Call("showAttachmentCell:inRect:characterIndex:", cell, rect, attachmentIndex);
		}

		public static void drawUnderlineForGlyphRangeUnderlineTypeBaselineOffsetLineFragmentRectLineFragmentGlyphRangeContainerOrigin(this NSLayoutManager _instance, NSRange glyphRange, Int32 underlineVal, float baselineOffset, NSRect lineRect, NSRange lineGlyphRange, NSPoint containerOrigin)
		{
			Unused.Value = _instance.Call("drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:", glyphRange, underlineVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
		}

		public static void underlineGlyphRangeUnderlineTypeLineFragmentRectLineFragmentGlyphRangeContainerOrigin(this NSLayoutManager _instance, NSRange glyphRange, Int32 underlineVal, NSRect lineRect, NSRange lineGlyphRange, NSPoint containerOrigin)
		{
			Unused.Value = _instance.Call("underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:", glyphRange, underlineVal, lineRect, lineGlyphRange, containerOrigin);
		}

		public static void drawStrikethroughForGlyphRangeStrikethroughTypeBaselineOffsetLineFragmentRectLineFragmentGlyphRangeContainerOrigin(this NSLayoutManager _instance, NSRange glyphRange, Int32 strikethroughVal, float baselineOffset, NSRect lineRect, NSRange lineGlyphRange, NSPoint containerOrigin)
		{
			Unused.Value = _instance.Call("drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:", glyphRange, strikethroughVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
		}

		public static void strikethroughGlyphRangeStrikethroughTypeLineFragmentRectLineFragmentGlyphRangeContainerOrigin(this NSLayoutManager _instance, NSRange glyphRange, Int32 strikethroughVal, NSRect lineRect, NSRange lineGlyphRange, NSPoint containerOrigin)
		{
			Unused.Value = _instance.Call("strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:", glyphRange, strikethroughVal, lineRect, lineGlyphRange, containerOrigin);
		}
	}

	public static class NSLayoutManagerDelegateForNSObjectCategory
	{
		public static void layoutManagerDidInvalidateLayout(this NSObject _instance, NSLayoutManager sender)
		{
			Unused.Value = _instance.Call("layoutManagerDidInvalidateLayout:", sender);
		}

		public static void layoutManagerDidCompleteLayoutForTextContainerAtEnd(this NSObject _instance, NSLayoutManager layoutManager, NSTextContainer textContainer, bool layoutFinishedFlag)
		{
			Unused.Value = _instance.Call("layoutManager:didCompleteLayoutForTextContainer:atEnd:", layoutManager, textContainer, layoutFinishedFlag);
		}

		public static NSDictionary layoutManagerShouldUseTemporaryAttributesForDrawingToScreenAtCharacterIndexEffectiveRange(this NSObject _instance, NSLayoutManager layoutManager, NSDictionary attrs, bool toScreen, UInt32 charIndex, IntPtr effectiveCharRange)
		{
			return _instance.Call("layoutManager:shouldUseTemporaryAttributes:forDrawingToScreen:atCharacterIndex:effectiveRange:", layoutManager, attrs, toScreen, charIndex, effectiveCharRange).To<NSDictionary>();
		}
	}
}
