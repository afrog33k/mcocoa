// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSGlyphGenerator.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSShowControlGlyphs = ( 1 << 0 );
		public const int NSShowInvisibleGlyphs = ( 1 << 1 );
		public const int NSWantsBidiLevels = ( 1 << 2 );
	}

	[Register]
	public partial class NSGlyphGenerator : NSObject
	{
		public NSGlyphGenerator() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSGlyphGenerator(IntPtr instance) : base(instance)
		{
		}

		public NSGlyphGenerator(Untyped instance) : base(instance)
		{
		}

		public static new NSGlyphGenerator alloc()
		{
			return new NSGlyphGenerator(ms_class.Call("alloc"));
		}

		public new NSGlyphGenerator retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void generateGlyphsForGlyphStorageDesiredNumberOfCharactersGlyphIndexCharacterIndex(NSObject glyphStorage, UInt32 nChars, IntPtr glyphIndex, IntPtr charIndex)
		{
			Unused.Value = Call("generateGlyphsForGlyphStorage:desiredNumberOfCharacters:glyphIndex:characterIndex:", glyphStorage, nChars, glyphIndex, charIndex);
		}

		public static NSObject sharedGlyphGenerator()
		{
			return ms_class.Call("sharedGlyphGenerator").To<NSObject>();
		}

		private static Class ms_class = new Class("NSGlyphGenerator");
	}
}
