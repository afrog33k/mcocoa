// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSGlyphInfo.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSIdentityMappingCharacterCollection = 0;
		public const int NSAdobeCNS1CharacterCollection = 1;
		public const int NSAdobeGB1CharacterCollection = 2;
		public const int NSAdobeJapan1CharacterCollection = 3;
		public const int NSAdobeJapan2CharacterCollection = 4;
		public const int NSAdobeKorea1CharacterCollection = 5;
	}

	[Register]
	public partial class NSGlyphInfo : NSObject
	{
		public NSGlyphInfo() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSGlyphInfo(IntPtr instance) : base(instance)
		{
		}

		public NSGlyphInfo(Untyped instance) : base(instance)
		{
		}

		public static new NSGlyphInfo alloc()
		{
			return new NSGlyphInfo(ms_class.Call("alloc"));
		}

		public new NSGlyphInfo retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSGlyphInfo glyphInfoWithGlyphNameForFontBaseString(NSString glyphName, NSFont font, NSString theString)
		{
			return ms_class.Call("glyphInfoWithGlyphName:forFont:baseString:", glyphName, font, theString).To<NSGlyphInfo>();
		}

		public static NSGlyphInfo glyphInfoWithGlyphForFontBaseString(UInt32 glyph, NSFont font, NSString theString)
		{
			return ms_class.Call("glyphInfoWithGlyph:forFont:baseString:", glyph, font, theString).To<NSGlyphInfo>();
		}

		public static NSGlyphInfo glyphInfoWithCharacterIdentifierCollectionBaseString(UInt32 cid, UInt32 characterCollection, NSString theString)
		{
			return ms_class.Call("glyphInfoWithCharacterIdentifier:collection:baseString:", cid, characterCollection, theString).To<NSGlyphInfo>();
		}

		public NSString glyphName()
		{
			return Call("glyphName").To<NSString>();
		}

		public UInt32 characterIdentifier()
		{
			return Call("characterIdentifier").To<UInt32>();
		}

		public UInt32 characterCollection()
		{
			return Call("characterCollection").To<UInt32>();
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

		private static Class ms_class = new Class("NSGlyphInfo");
	}
}
