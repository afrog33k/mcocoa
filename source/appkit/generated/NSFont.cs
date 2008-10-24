// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSFont.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSControlGlyph = 0x00FFFFFF;
		public const int NSNullGlyph = 0x0;
	}

	public partial class Enums
	{
		public const int NSNativeShortGlyphPacking = 5;
	}

	public partial class Enums
	{
		public const int NSFontDefaultRenderingMode = 0;
		public const int NSFontAntialiasedRenderingMode = 1;
		public const int NSFontIntegerAdvancementsRenderingMode = 2;
		public const int NSFontAntialiasedIntegerAdvancementsRenderingMode = 3;
	}

	public partial class Enums
	{
		public const int NSOneByteGlyphPacking = 0;
		public const int NSJapaneseEUCGlyphPacking = 1;
		public const int NSAsciiWithDoubleByteEUCGlyphPacking = 2;
		public const int NSTwoByteGlyphPacking = 3;
		public const int NSFourByteGlyphPacking = 4;
	}

	public enum _NSGlyphRelation
	{
		NSGlyphBelow = 1,
		NSGlyphAbove = 2,
	}

	[Register]
	public partial class NSFont : NSObject
	{
		public NSFont() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFont(IntPtr instance) : base(instance)
		{
		}

		public NSFont(Untyped instance) : base(instance)
		{
		}

		public static new NSFont alloc()
		{
			return new NSFont(ms_class.Call("alloc"));
		}

		public new NSFont retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSFont fontWithNameSize(NSString fontName, float fontSize)
		{
			return ms_class.Call("fontWithName:size:", fontName, fontSize).To<NSFont>();
		}

		public static NSFont fontWithNameMatrix(NSString fontName, IntPtr fontMatrix)
		{
			return ms_class.Call("fontWithName:matrix:", fontName, fontMatrix).To<NSFont>();
		}

		public static NSFont fontWithDescriptorSize(NSFontDescriptor fontDescriptor, float fontSize)
		{
			return ms_class.Call("fontWithDescriptor:size:", fontDescriptor, fontSize).To<NSFont>();
		}

		public static NSFont fontWithDescriptorTextTransform(NSFontDescriptor fontDescriptor, NSAffineTransform textTransform)
		{
			return ms_class.Call("fontWithDescriptor:textTransform:", fontDescriptor, textTransform).To<NSFont>();
		}

		public static NSFont userFontOfSize(float fontSize)
		{
			return ms_class.Call("userFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont userFixedPitchFontOfSize(float fontSize)
		{
			return ms_class.Call("userFixedPitchFontOfSize:", fontSize).To<NSFont>();
		}

		public static void setUserFont(NSFont aFont)
		{
			Unused.Value = ms_class.Call("setUserFont:", aFont);
		}

		public static void setUserFixedPitchFont(NSFont aFont)
		{
			Unused.Value = ms_class.Call("setUserFixedPitchFont:", aFont);
		}

		public static NSFont systemFontOfSize(float fontSize)
		{
			return ms_class.Call("systemFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont boldSystemFontOfSize(float fontSize)
		{
			return ms_class.Call("boldSystemFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont labelFontOfSize(float fontSize)
		{
			return ms_class.Call("labelFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont titleBarFontOfSize(float fontSize)
		{
			return ms_class.Call("titleBarFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont menuFontOfSize(float fontSize)
		{
			return ms_class.Call("menuFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont menuBarFontOfSize(float fontSize)
		{
			return ms_class.Call("menuBarFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont messageFontOfSize(float fontSize)
		{
			return ms_class.Call("messageFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont paletteFontOfSize(float fontSize)
		{
			return ms_class.Call("paletteFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont toolTipsFontOfSize(float fontSize)
		{
			return ms_class.Call("toolTipsFontOfSize:", fontSize).To<NSFont>();
		}

		public static NSFont controlContentFontOfSize(float fontSize)
		{
			return ms_class.Call("controlContentFontOfSize:", fontSize).To<NSFont>();
		}

		public static float systemFontSize()
		{
			return ms_class.Call("systemFontSize").To<float>();
		}

		public static float smallSystemFontSize()
		{
			return ms_class.Call("smallSystemFontSize").To<float>();
		}

		public static float labelFontSize()
		{
			return ms_class.Call("labelFontSize").To<float>();
		}

		public static float systemFontSizeForControlSize(UInt32 controlSize)
		{
			return ms_class.Call("systemFontSizeForControlSize:", controlSize).To<float>();
		}

		public NSString fontName()
		{
			return Call("fontName").To<NSString>();
		}

		public float pointSize()
		{
			return Call("pointSize").To<float>();
		}

		public IntPtr matrix()
		{
			return Call("matrix").To<IntPtr>();
		}

		public NSString familyName()
		{
			return Call("familyName").To<NSString>();
		}

		public NSString displayName()
		{
			return Call("displayName").To<NSString>();
		}

		public NSFontDescriptor fontDescriptor()
		{
			return Call("fontDescriptor").To<NSFontDescriptor>();
		}

		public NSAffineTransform textTransform()
		{
			return Call("textTransform").To<NSAffineTransform>();
		}

		public UInt32 numberOfGlyphs()
		{
			return Call("numberOfGlyphs").To<UInt32>();
		}

		public UInt32 mostCompatibleStringEncoding()
		{
			return Call("mostCompatibleStringEncoding").To<UInt32>();
		}

		public UInt32 glyphWithName(NSString aName)
		{
			return Call("glyphWithName:", aName).To<UInt32>();
		}

		public NSCharacterSet coveredCharacterSet()
		{
			return Call("coveredCharacterSet").To<NSCharacterSet>();
		}

		public NSRect boundingRectForFont()
		{
			return Call("boundingRectForFont").To<NSRect>();
		}

		public NSSize maximumAdvancement()
		{
			return Call("maximumAdvancement").To<NSSize>();
		}

		public float ascender()
		{
			return Call("ascender").To<float>();
		}

		public float descender()
		{
			return Call("descender").To<float>();
		}

		public float leading()
		{
			return Call("leading").To<float>();
		}

		public float underlinePosition()
		{
			return Call("underlinePosition").To<float>();
		}

		public float underlineThickness()
		{
			return Call("underlineThickness").To<float>();
		}

		public float italicAngle()
		{
			return Call("italicAngle").To<float>();
		}

		public float capHeight()
		{
			return Call("capHeight").To<float>();
		}

		public float xHeight()
		{
			return Call("xHeight").To<float>();
		}

		public bool isFixedPitch()
		{
			return Call("isFixedPitch").To<bool>();
		}

		public NSRect boundingRectForGlyph(UInt32 aGlyph)
		{
			return Call("boundingRectForGlyph:", aGlyph).To<NSRect>();
		}

		public NSSize advancementForGlyph(UInt32 ag)
		{
			return Call("advancementForGlyph:", ag).To<NSSize>();
		}

		public void getBoundingRectsForGlyphsCount(IntPtr bounds, IntPtr glyphs, UInt32 glyphCount)
		{
			Unused.Value = Call("getBoundingRects:forGlyphs:count:", bounds, glyphs, glyphCount);
		}

		public void getAdvancementsForGlyphsCount(IntPtr advancements, IntPtr glyphs, UInt32 glyphCount)
		{
			Unused.Value = Call("getAdvancements:forGlyphs:count:", advancements, glyphs, glyphCount);
		}

		public void getAdvancementsForPackedGlyphsLength(IntPtr advancements, IntPtr packedGlyphs, UInt32 length)
		{
			Unused.Value = Call("getAdvancements:forPackedGlyphs:length:", advancements, packedGlyphs, length);
		}

		public void set()
		{
			Unused.Value = Call("set");
		}

		public void setInContext(NSGraphicsContext graphicsContext)
		{
			Unused.Value = Call("setInContext:", graphicsContext);
		}

		public NSFont printerFont()
		{
			return Call("printerFont").To<NSFont>();
		}

		public NSFont screenFont()
		{
			return Call("screenFont").To<NSFont>();
		}

		public NSFont screenFontWithRenderingMode(UInt32 renderingMode)
		{
			return Call("screenFontWithRenderingMode:", renderingMode).To<NSFont>();
		}

		public UInt32 renderingMode()
		{
			return Call("renderingMode").To<UInt32>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
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

		private static Class ms_class = new Class("NSFont");
	}

	public static class NSFontDeprecatedForNSFontCategory
	{
	}
}
