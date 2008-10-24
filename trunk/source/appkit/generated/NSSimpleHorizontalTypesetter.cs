// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSimpleHorizontalTypesetter.h

using MObjc;
using System;

namespace MCocoa
{
	public enum NSLayoutStatus
	{
		NSLayoutNotDone = 0,
		NSLayoutDone,
		NSLayoutCantFit,
		NSLayoutOutOfGlyphs,
	}

	public enum NSGlyphLayoutMode
	{
		NSGlyphLayoutAtAPoint = 0,
		NSGlyphLayoutAgainstAPoint,
		NSGlyphLayoutWithPrevious,
	}

	public enum NSLayoutDirection
	{
		NSLayoutLeftToRight = 0,
		NSLayoutRightToLeft,
	}

	[Register]
	public partial class NSSimpleHorizontalTypesetter : NSTypesetter
	{
		public NSSimpleHorizontalTypesetter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSimpleHorizontalTypesetter(IntPtr instance) : base(instance)
		{
		}

		public NSSimpleHorizontalTypesetter(Untyped instance) : base(instance)
		{
		}

		public static new NSSimpleHorizontalTypesetter alloc()
		{
			return new NSSimpleHorizontalTypesetter(ms_class.Call("alloc"));
		}

		public new NSSimpleHorizontalTypesetter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject sharedInstance()
		{
			return ms_class.Call("sharedInstance").To<NSObject>();
		}

		public NSLayoutManager currentLayoutManager()
		{
			return Call("currentLayoutManager").To<NSLayoutManager>();
		}

		public NSTextContainer currentContainer()
		{
			return Call("currentContainer").To<NSTextContainer>();
		}

		// skipping currentParagraphStyle (it's declared in a base class)

		public NSTextStorage currentTextStorage()
		{
			return Call("currentTextStorage").To<NSTextStorage>();
		}

		public NSTypesetterGlyphInfo baseOfTypesetterGlyphInfo()
		{
			return Call("baseOfTypesetterGlyphInfo").To<NSTypesetterGlyphInfo>();
		}

		public UInt32 sizeOfTypesetterGlyphInfo()
		{
			return Call("sizeOfTypesetterGlyphInfo").To<UInt32>();
		}

		public UInt32 capacityOfTypesetterGlyphInfo()
		{
			return Call("capacityOfTypesetterGlyphInfo").To<UInt32>();
		}

		public UInt32 firstGlyphIndexOfCurrentLineFragment()
		{
			return Call("firstGlyphIndexOfCurrentLineFragment").To<UInt32>();
		}

		// skipping layoutGlyphsInLayoutManager:startingAtGlyphIndex:maxNumberOfLineFragments:nextGlyphIndex: (it's declared in a base class)

		public NSLayoutStatus layoutGlyphsInHorizontalLineFragmentBaseline(IntPtr lineFragmentRect, IntPtr baseline)
		{
			return Call("layoutGlyphsInHorizontalLineFragment:baseline:", lineFragmentRect, baseline).To<NSLayoutStatus>();
		}

		public void clearGlyphCache()
		{
			Unused.Value = Call("clearGlyphCache");
		}

		public void fillAttributesCache()
		{
			Unused.Value = Call("fillAttributesCache");
		}

		public void clearAttributesCache()
		{
			Unused.Value = Call("clearAttributesCache");
		}

		public UInt32 growGlyphCachesFillGlyphInfo(UInt32 desiredCapacity, bool fillGlyphInfo)
		{
			return Call("growGlyphCaches:fillGlyphInfo:", desiredCapacity, fillGlyphInfo).To<UInt32>();
		}

		public void updateCurGlyphOffset()
		{
			Unused.Value = Call("updateCurGlyphOffset");
		}

		public void insertGlyphAtGlyphIndexCharacterIndex(UInt32 glyph, UInt32 glyphIndex, UInt32 charIndex)
		{
			Unused.Value = Call("insertGlyph:atGlyphIndex:characterIndex:", glyph, glyphIndex, charIndex);
		}

		public NSLayoutStatus layoutControlGlyphForLineFragment(NSRect lineFrag)
		{
			return Call("layoutControlGlyphForLineFragment:", lineFrag).To<NSLayoutStatus>();
		}

		public void layoutTab()
		{
			Unused.Value = Call("layoutTab");
		}

		public void breakLineAtIndex(UInt32 location)
		{
			Unused.Value = Call("breakLineAtIndex:", location);
		}

		public UInt32 glyphIndexToBreakLineByHyphenatingWordAtIndex(UInt32 charIndex)
		{
			return Call("glyphIndexToBreakLineByHyphenatingWordAtIndex:", charIndex).To<UInt32>();
		}

		public UInt32 glyphIndexToBreakLineByWordWrappingAtIndex(UInt32 charIndex)
		{
			return Call("glyphIndexToBreakLineByWordWrappingAtIndex:", charIndex).To<UInt32>();
		}

		// skipping layoutTab (it's already defined)

		// skipping layoutControlGlyphForLineFragment: (it's already defined)

		public void fullJustifyLineAtGlyphIndex(UInt32 glyphIndexForLineBreak)
		{
			Unused.Value = Call("fullJustifyLineAtGlyphIndex:", glyphIndexForLineBreak);
		}

		private static Class ms_class = new Class("NSSimpleHorizontalTypesetter");
	}

	public static class NSTypesetterSubclassExtensionsForNSSimpleHorizontalTypesetterCategory
	{
		public static void typesetterLaidOneGlyph(this NSSimpleHorizontalTypesetter _instance, NSTypesetterGlyphInfo gl)
		{
			Unused.Value = _instance.Call("typesetterLaidOneGlyph:", gl);
		}

		public static void willSetLineFragmentRectForGlyphRangeUsedRect(this NSSimpleHorizontalTypesetter _instance, IntPtr aRect, NSRange aRange, IntPtr bRect)
		{
			Unused.Value = _instance.Call("willSetLineFragmentRect:forGlyphRange:usedRect:", aRect, aRange, bRect);
		}
	}
}
