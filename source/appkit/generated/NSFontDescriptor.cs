// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSFontDescriptor.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSFontUnknownClass = 0 << 28;
		public const int NSFontOldStyleSerifsClass = 1 << 28;
		public const int NSFontTransitionalSerifsClass = 2 << 28;
		public const int NSFontModernSerifsClass = 3 << 28;
		public const int NSFontClarendonSerifsClass = 4 << 28;
		public const int NSFontSlabSerifsClass = 5 << 28;
		public const int NSFontFreeformSerifsClass = 7 << 28;
		public const int NSFontSansSerifClass = 8 << 28;
		public const int NSFontOrnamentalsClass = 9 << 28;
		public const int NSFontScriptsClass = 10 << 28;
		public const int NSFontSymbolicClass = 12 << 28;
	}

	public partial class Enums
	{
		public const uint NSFontFamilyClassMask = 0xF0000000;
	}

	public partial class Enums
	{
		public const int NSFontItalicTrait = ( 1 << 0 );
		public const int NSFontBoldTrait = ( 1 << 1 );
		public const int NSFontExpandedTrait = ( 1 << 5 );
		public const int NSFontCondensedTrait = ( 1 << 6 );
		public const int NSFontMonoSpaceTrait = ( 1 << 10 );
		public const int NSFontVerticalTrait = ( 1 << 11 );
		public const int NSFontUIOptimizedTrait = ( 1 << 12 );
	}

	[Register]
	public partial class NSFontDescriptor : NSObject
	{
		public NSFontDescriptor() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFontDescriptor(IntPtr instance) : base(instance)
		{
		}

		public NSFontDescriptor(Untyped instance) : base(instance)
		{
		}

		public static new NSFontDescriptor alloc()
		{
			return new NSFontDescriptor(ms_class.Call("alloc"));
		}

		public new NSFontDescriptor retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString postscriptName()
		{
			return Call("postscriptName").To<NSString>();
		}

		public float pointSize()
		{
			return Call("pointSize").To<float>();
		}

		public NSAffineTransform matrix()
		{
			return Call("matrix").To<NSAffineTransform>();
		}

		public UInt32 symbolicTraits()
		{
			return Call("symbolicTraits").To<UInt32>();
		}

		public NSObject objectForKey(NSString anAttribute)
		{
			return Call("objectForKey:", anAttribute).To<NSObject>();
		}

		public NSDictionary fontAttributes()
		{
			return Call("fontAttributes").To<NSDictionary>();
		}

		public static NSFontDescriptor fontDescriptorWithFontAttributes(NSDictionary attributes)
		{
			return ms_class.Call("fontDescriptorWithFontAttributes:", attributes).To<NSFontDescriptor>();
		}

		public static NSFontDescriptor fontDescriptorWithNameSize(NSString fontName, float size)
		{
			return ms_class.Call("fontDescriptorWithName:size:", fontName, size).To<NSFontDescriptor>();
		}

		public static NSFontDescriptor fontDescriptorWithNameMatrix(NSString fontName, NSAffineTransform matrix)
		{
			return ms_class.Call("fontDescriptorWithName:matrix:", fontName, matrix).To<NSFontDescriptor>();
		}

		public NSObject initWithFontAttributes(NSDictionary attributes)
		{
			return Call("initWithFontAttributes:", attributes).To<NSObject>();
		}

		public NSArray matchingFontDescriptorsWithMandatoryKeys(NSSet mandatoryKeys)
		{
			return Call("matchingFontDescriptorsWithMandatoryKeys:", mandatoryKeys).To<NSArray>();
		}

		public NSFontDescriptor matchingFontDescriptorWithMandatoryKeysAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSSet mandatoryKeys)
		{
			return Call("matchingFontDescriptorWithMandatoryKeys:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", mandatoryKeys).To<NSFontDescriptor>();
		}

		public NSFontDescriptor fontDescriptorByAddingAttributes(NSDictionary attributes)
		{
			return Call("fontDescriptorByAddingAttributes:", attributes).To<NSFontDescriptor>();
		}

		public NSFontDescriptor fontDescriptorWithSymbolicTraits(UInt32 symbolicTraits)
		{
			return Call("fontDescriptorWithSymbolicTraits:", symbolicTraits).To<NSFontDescriptor>();
		}

		public NSFontDescriptor fontDescriptorWithSize(float newPointSize)
		{
			return Call("fontDescriptorWithSize:", newPointSize).To<NSFontDescriptor>();
		}

		public NSFontDescriptor fontDescriptorWithMatrix(NSAffineTransform matrix)
		{
			return Call("fontDescriptorWithMatrix:", matrix).To<NSFontDescriptor>();
		}

		public NSFontDescriptor fontDescriptorWithFace(NSString newFace)
		{
			return Call("fontDescriptorWithFace:", newFace).To<NSFontDescriptor>();
		}

		public NSFontDescriptor fontDescriptorWithFamily(NSString newFamily)
		{
			return Call("fontDescriptorWithFamily:", newFamily).To<NSFontDescriptor>();
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

		private static Class ms_class = new Class("NSFontDescriptor");
	}
}
