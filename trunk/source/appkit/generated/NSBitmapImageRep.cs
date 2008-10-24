// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSBitmapImageRep.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTIFFCompressionNone = 1;
		public const int NSTIFFCompressionCCITTFAX3 = 3;
		public const int NSTIFFCompressionCCITTFAX4 = 4;
		public const int NSTIFFCompressionLZW = 5;
		public const int NSTIFFCompressionJPEG = 6;
		public const int NSTIFFCompressionNEXT = 32766;
		public const int NSTIFFCompressionPackBits = 32773;
		public const int NSTIFFCompressionOldJPEG = 32865;
	}

	public partial class Enums
	{
		public const int NSTIFFFileType = 0;
		public const int NSBMPFileType = 1;
		public const int NSGIFFileType = 2;
		public const int NSJPEGFileType = 3;
		public const int NSPNGFileType = 4;
		public const int NSJPEG2000FileType = 5;
	}

	public partial class Enums
	{
		public const int NSImageRepLoadStatusUnknownType = -1;
		public const int NSImageRepLoadStatusReadingHeader = -2;
		public const int NSImageRepLoadStatusWillNeedAllData = -3;
		public const int NSImageRepLoadStatusInvalidData = -4;
		public const int NSImageRepLoadStatusUnexpectedEOF = -5;
		public const int NSImageRepLoadStatusCompleted = -6;
	}

	public partial class Enums
	{
		public const int NSAlphaFirstBitmapFormat = 1 << 0;
		public const int NSAlphaNonpremultipliedBitmapFormat = 1 << 1;
		public const int NSFloatingPointSamplesBitmapFormat = 1 << 2;
	}

	[Register]
	public partial class NSBitmapImageRep : NSImageRep
	{
		public NSBitmapImageRep() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSBitmapImageRep(IntPtr instance) : base(instance)
		{
		}

		public NSBitmapImageRep(Untyped instance) : base(instance)
		{
		}

		public static new NSBitmapImageRep alloc()
		{
			return new NSBitmapImageRep(ms_class.Call("alloc"));
		}

		public new NSBitmapImageRep retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithFocusedViewRect(NSRect rect)
		{
			return Call("initWithFocusedViewRect:", rect).To<NSObject>();
		}

		public NSObject initWithBitmapDataPlanesPixelsWidePixelsHighBitsPerSampleSamplesPerPixelHasAlphaIsPlanarColorSpaceNameBytesPerRowBitsPerPixel(IntPtr planes, Int32 width, Int32 height, Int32 bps, Int32 spp, bool alpha, bool isPlanar, NSString colorSpaceName, Int32 rBytes, Int32 pBits)
		{
			return Call("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:", planes, width, height, bps, spp, alpha, isPlanar, colorSpaceName, rBytes, pBits).To<NSObject>();
		}

		public NSObject initWithBitmapDataPlanesPixelsWidePixelsHighBitsPerSampleSamplesPerPixelHasAlphaIsPlanarColorSpaceNameBitmapFormatBytesPerRowBitsPerPixel(IntPtr planes, Int32 width, Int32 height, Int32 bps, Int32 spp, bool alpha, bool isPlanar, NSString colorSpaceName, UInt32 bitmapFormat, Int32 rBytes, Int32 pBits)
		{
			return Call("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:", planes, width, height, bps, spp, alpha, isPlanar, colorSpaceName, bitmapFormat, rBytes, pBits).To<NSObject>();
		}

		public NSObject initWithCGImage(IntPtr cgImage)
		{
			return Call("initWithCGImage:", cgImage).To<NSObject>();
		}

		public NSObject initWithCIImage(NSObject ciImage)
		{
			return Call("initWithCIImage:", ciImage).To<NSObject>();
		}

		public static NSArray imageRepsWithData(NSData data)
		{
			return ms_class.Call("imageRepsWithData:", data).To<NSArray>();
		}

		public static NSObject imageRepWithData(NSData data)
		{
			return ms_class.Call("imageRepWithData:", data).To<NSObject>();
		}

		public NSObject initWithData(NSData data)
		{
			return Call("initWithData:", data).To<NSObject>();
		}

		public IntPtr bitmapData()
		{
			return Call("bitmapData").To<IntPtr>();
		}

		public void getBitmapDataPlanes(IntPtr data)
		{
			Unused.Value = Call("getBitmapDataPlanes:", data);
		}

		public bool isPlanar()
		{
			return Call("isPlanar").To<bool>();
		}

		public Int32 samplesPerPixel()
		{
			return Call("samplesPerPixel").To<Int32>();
		}

		public Int32 bitsPerPixel()
		{
			return Call("bitsPerPixel").To<Int32>();
		}

		public Int32 bytesPerRow()
		{
			return Call("bytesPerRow").To<Int32>();
		}

		public Int32 bytesPerPlane()
		{
			return Call("bytesPerPlane").To<Int32>();
		}

		public Int32 numberOfPlanes()
		{
			return Call("numberOfPlanes").To<Int32>();
		}

		public UInt32 bitmapFormat()
		{
			return Call("bitmapFormat").To<UInt32>();
		}

		public void getCompressionFactor(IntPtr compression, IntPtr factor)
		{
			Unused.Value = Call("getCompression:factor:", compression, factor);
		}

		public void setCompressionFactor(UInt32 compression, float factor)
		{
			Unused.Value = Call("setCompression:factor:", compression, factor);
		}

		public NSData TIFFRepresentation()
		{
			return Call("TIFFRepresentation").To<NSData>();
		}

		public NSData TIFFRepresentationUsingCompressionFactor(UInt32 comp, float factor)
		{
			return Call("TIFFRepresentationUsingCompression:factor:", comp, factor).To<NSData>();
		}

		public static NSData TIFFRepresentationOfImageRepsInArray(NSArray array)
		{
			return ms_class.Call("TIFFRepresentationOfImageRepsInArray:", array).To<NSData>();
		}

		public static NSData TIFFRepresentationOfImageRepsInArrayUsingCompressionFactor(NSArray array, UInt32 comp, float factor)
		{
			return ms_class.Call("TIFFRepresentationOfImageRepsInArray:usingCompression:factor:", array, comp, factor).To<NSData>();
		}

		public static void getTIFFCompressionTypesCount(IntPtr list, IntPtr numTypes)
		{
			Unused.Value = ms_class.Call("getTIFFCompressionTypes:count:", list, numTypes);
		}

		public static NSString localizedNameForTIFFCompressionType(UInt32 compression)
		{
			return ms_class.Call("localizedNameForTIFFCompressionType:", compression).To<NSString>();
		}

		public bool canBeCompressedUsing(UInt32 compression)
		{
			return Call("canBeCompressedUsing:", compression).To<bool>();
		}

		public void colorizeByMappingGrayToColorBlackMappingWhiteMapping(float midPoint, NSColor midPointColor, NSColor shadowColor, NSColor lightColor)
		{
			Unused.Value = Call("colorizeByMappingGray:toColor:blackMapping:whiteMapping:", midPoint, midPointColor, shadowColor, lightColor);
		}

		public NSObject initForIncrementalLoad()
		{
			return Call("initForIncrementalLoad").To<NSObject>();
		}

		public Int32 incrementalLoadFromDataComplete(NSData data, bool complete)
		{
			return Call("incrementalLoadFromData:complete:", data, complete).To<Int32>();
		}

		public void setColorAtXY(NSColor color, Int32 x, Int32 y)
		{
			Unused.Value = Call("setColor:atX:y:", color, x, y);
		}

		public NSColor colorAtXY(Int32 x, Int32 y)
		{
			return Call("colorAtX:y:", x, y).To<NSColor>();
		}

		public void getPixelAtXY(IntPtr p, Int32 x, Int32 y)
		{
			Unused.Value = Call("getPixel:atX:y:", p, x, y);
		}

		public void setPixelAtXY(IntPtr p, Int32 x, Int32 y)
		{
			Unused.Value = Call("setPixel:atX:y:", p, x, y);
		}

		public IntPtr CGImage()
		{
			return Call("CGImage").To<IntPtr>();
		}

		private static Class ms_class = new Class("NSBitmapImageRep");
	}

	public static class NSBitmapImageFileTypeExtensionsForNSBitmapImageRepCategory
	{
		public static NSData representationOfImageRepsInArrayUsingTypeProperties(this NSBitmapImageRep _instance, NSArray imageReps, UInt32 storageType, NSDictionary properties)
		{
			return _instance.Call("representationOfImageRepsInArray:usingType:properties:", imageReps, storageType, properties).To<NSData>();
		}

		public static NSData representationUsingTypeProperties(this NSBitmapImageRep _instance, UInt32 storageType, NSDictionary properties)
		{
			return _instance.Call("representationUsingType:properties:", storageType, properties).To<NSData>();
		}

		public static void setPropertyWithValue(this NSBitmapImageRep _instance, NSString property, NSObject value)
		{
			Unused.Value = _instance.Call("setProperty:withValue:", property, value);
		}

		public static NSObject valueForProperty(this NSBitmapImageRep _instance, NSString property)
		{
			return _instance.Call("valueForProperty:", property).To<NSObject>();
		}
	}
}
