// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSImageRep.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSImageRepMatchesDevice = 0;
	}

	[Register]
	public partial class NSImageRep : NSObject
	{
		public NSImageRep() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSImageRep(IntPtr instance) : base(instance)
		{
		}

		public NSImageRep(Untyped instance) : base(instance)
		{
		}

		public static new NSImageRep alloc()
		{
			return new NSImageRep(ms_class.Call("alloc"));
		}

		public new NSImageRep retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool draw()
		{
			return Call("draw").To<bool>();
		}

		public bool drawAtPoint(NSPoint point)
		{
			return Call("drawAtPoint:", point).To<bool>();
		}

		public bool drawInRect(NSRect rect)
		{
			return Call("drawInRect:", rect).To<bool>();
		}

		public void setSize(NSSize aSize)
		{
			Unused.Value = Call("setSize:", aSize);
		}

		public NSSize size()
		{
			return Call("size").To<NSSize>();
		}

		public void setAlpha(bool flag)
		{
			Unused.Value = Call("setAlpha:", flag);
		}

		public bool hasAlpha()
		{
			return Call("hasAlpha").To<bool>();
		}

		public void setOpaque(bool flag)
		{
			Unused.Value = Call("setOpaque:", flag);
		}

		public bool isOpaque()
		{
			return Call("isOpaque").To<bool>();
		}

		public void setColorSpaceName(NSString string_)
		{
			Unused.Value = Call("setColorSpaceName:", string_);
		}

		public NSString colorSpaceName()
		{
			return Call("colorSpaceName").To<NSString>();
		}

		public void setBitsPerSample(Int32 anInt)
		{
			Unused.Value = Call("setBitsPerSample:", anInt);
		}

		public Int32 bitsPerSample()
		{
			return Call("bitsPerSample").To<Int32>();
		}

		public void setPixelsWide(Int32 anInt)
		{
			Unused.Value = Call("setPixelsWide:", anInt);
		}

		public Int32 pixelsWide()
		{
			return Call("pixelsWide").To<Int32>();
		}

		public void setPixelsHigh(Int32 anInt)
		{
			Unused.Value = Call("setPixelsHigh:", anInt);
		}

		public Int32 pixelsHigh()
		{
			return Call("pixelsHigh").To<Int32>();
		}

		public static void registerImageRepClass(Class imageRepClass)
		{
			Unused.Value = ms_class.Call("registerImageRepClass:", imageRepClass);
		}

		public static void unregisterImageRepClass(Class imageRepClass)
		{
			Unused.Value = ms_class.Call("unregisterImageRepClass:", imageRepClass);
		}

		public static NSArray registeredImageRepClasses()
		{
			return ms_class.Call("registeredImageRepClasses").To<NSArray>();
		}

		public static Class imageRepClassForFileType(NSString type)
		{
			return ms_class.Call("imageRepClassForFileType:", type).To<Class>();
		}

		public static Class imageRepClassForPasteboardType(NSString type)
		{
			return ms_class.Call("imageRepClassForPasteboardType:", type).To<Class>();
		}

		public static Class imageRepClassForType(NSString type)
		{
			return ms_class.Call("imageRepClassForType:", type).To<Class>();
		}

		public static Class imageRepClassForData(NSData data)
		{
			return ms_class.Call("imageRepClassForData:", data).To<Class>();
		}

		public static bool canInitWithData(NSData data)
		{
			return ms_class.Call("canInitWithData:", data).To<bool>();
		}

		public static NSArray imageUnfilteredFileTypes()
		{
			return ms_class.Call("imageUnfilteredFileTypes").To<NSArray>();
		}

		public static NSArray imageUnfilteredPasteboardTypes()
		{
			return ms_class.Call("imageUnfilteredPasteboardTypes").To<NSArray>();
		}

		public static NSArray imageFileTypes()
		{
			return ms_class.Call("imageFileTypes").To<NSArray>();
		}

		public static NSArray imagePasteboardTypes()
		{
			return ms_class.Call("imagePasteboardTypes").To<NSArray>();
		}

		public static NSArray imageUnfilteredTypes()
		{
			return ms_class.Call("imageUnfilteredTypes").To<NSArray>();
		}

		public static NSArray imageTypes()
		{
			return ms_class.Call("imageTypes").To<NSArray>();
		}

		public static bool canInitWithPasteboard(NSPasteboard pasteboard)
		{
			return ms_class.Call("canInitWithPasteboard:", pasteboard).To<bool>();
		}

		public static NSArray imageRepsWithContentsOfFile(NSString filename)
		{
			return ms_class.Call("imageRepsWithContentsOfFile:", filename).To<NSArray>();
		}

		public static NSObject imageRepWithContentsOfFile(NSString filename)
		{
			return ms_class.Call("imageRepWithContentsOfFile:", filename).To<NSObject>();
		}

		public static NSArray imageRepsWithContentsOfURL(NSURL url)
		{
			return ms_class.Call("imageRepsWithContentsOfURL:", url).To<NSArray>();
		}

		public static NSObject imageRepWithContentsOfURL(NSURL url)
		{
			return ms_class.Call("imageRepWithContentsOfURL:", url).To<NSObject>();
		}

		public static NSArray imageRepsWithPasteboard(NSPasteboard pasteboard)
		{
			return ms_class.Call("imageRepsWithPasteboard:", pasteboard).To<NSArray>();
		}

		public static NSObject imageRepWithPasteboard(NSPasteboard pasteboard)
		{
			return ms_class.Call("imageRepWithPasteboard:", pasteboard).To<NSObject>();
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

		private static Class ms_class = new Class("NSImageRep");
	}
}
