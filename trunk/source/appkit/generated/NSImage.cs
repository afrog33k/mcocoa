// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSImage.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSImageLoadStatusCompleted = 0;
		public const int NSImageLoadStatusCancelled = 1;
		public const int NSImageLoadStatusInvalidData = 2;
		public const int NSImageLoadStatusUnexpectedEOF = 3;
		public const int NSImageLoadStatusReadError = 4;
	}

	public partial class Enums
	{
		public const int NSImageCacheDefault = 0;
		public const int NSImageCacheAlways = 1;
		public const int NSImageCacheBySize = 2;
		public const int NSImageCacheNever = 3;
	}

	[Register]
	public partial class NSImage : NSObject
	{
		public NSImage() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSImage(IntPtr instance) : base(instance)
		{
		}

		public NSImage(Untyped instance) : base(instance)
		{
		}

		public static new NSImage alloc()
		{
			return new NSImage(ms_class.Call("alloc"));
		}

		public new NSImage retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject imageNamed(NSString name)
		{
			return ms_class.Call("imageNamed:", name).To<NSObject>();
		}

		public NSObject initWithSize(NSSize aSize)
		{
			return Call("initWithSize:", aSize).To<NSObject>();
		}

		public NSObject initWithData(NSData data)
		{
			return Call("initWithData:", data).To<NSObject>();
		}

		public NSObject initWithContentsOfFile(NSString fileName)
		{
			return Call("initWithContentsOfFile:", fileName).To<NSObject>();
		}

		public NSObject initWithContentsOfURL(NSURL url)
		{
			return Call("initWithContentsOfURL:", url).To<NSObject>();
		}

		public NSObject initByReferencingFile(NSString fileName)
		{
			return Call("initByReferencingFile:", fileName).To<NSObject>();
		}

		public NSObject initByReferencingURL(NSURL url)
		{
			return Call("initByReferencingURL:", url).To<NSObject>();
		}

		public NSObject initWithIconRef(IntPtr iconRef)
		{
			return Call("initWithIconRef:", iconRef).To<NSObject>();
		}

		public NSObject initWithPasteboard(NSPasteboard pasteboard)
		{
			return Call("initWithPasteboard:", pasteboard).To<NSObject>();
		}

		public void setSize(NSSize aSize)
		{
			Unused.Value = Call("setSize:", aSize);
		}

		public NSSize size()
		{
			return Call("size").To<NSSize>();
		}

		public bool setName(NSString string_)
		{
			return Call("setName:", string_).To<bool>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public void setScalesWhenResized(bool flag)
		{
			Unused.Value = Call("setScalesWhenResized:", flag);
		}

		public bool scalesWhenResized()
		{
			return Call("scalesWhenResized").To<bool>();
		}

		public void setDataRetained(bool flag)
		{
			Unused.Value = Call("setDataRetained:", flag);
		}

		public bool isDataRetained()
		{
			return Call("isDataRetained").To<bool>();
		}

		public void setCachedSeparately(bool flag)
		{
			Unused.Value = Call("setCachedSeparately:", flag);
		}

		public bool isCachedSeparately()
		{
			return Call("isCachedSeparately").To<bool>();
		}

		public void setCacheDepthMatchesImageDepth(bool flag)
		{
			Unused.Value = Call("setCacheDepthMatchesImageDepth:", flag);
		}

		public bool cacheDepthMatchesImageDepth()
		{
			return Call("cacheDepthMatchesImageDepth").To<bool>();
		}

		public void setBackgroundColor(NSColor aColor)
		{
			Unused.Value = Call("setBackgroundColor:", aColor);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setUsesEPSOnResolutionMismatch(bool flag)
		{
			Unused.Value = Call("setUsesEPSOnResolutionMismatch:", flag);
		}

		public bool usesEPSOnResolutionMismatch()
		{
			return Call("usesEPSOnResolutionMismatch").To<bool>();
		}

		public void setPrefersColorMatch(bool flag)
		{
			Unused.Value = Call("setPrefersColorMatch:", flag);
		}

		public bool prefersColorMatch()
		{
			return Call("prefersColorMatch").To<bool>();
		}

		public void setMatchesOnMultipleResolution(bool flag)
		{
			Unused.Value = Call("setMatchesOnMultipleResolution:", flag);
		}

		public bool matchesOnMultipleResolution()
		{
			return Call("matchesOnMultipleResolution").To<bool>();
		}

		public void dissolveToPointFraction(NSPoint point, float aFloat)
		{
			Unused.Value = Call("dissolveToPoint:fraction:", point, aFloat);
		}

		public void dissolveToPointFromRectFraction(NSPoint point, NSRect rect, float aFloat)
		{
			Unused.Value = Call("dissolveToPoint:fromRect:fraction:", point, rect, aFloat);
		}

		public void compositeToPointOperation(NSPoint point, UInt32 op)
		{
			Unused.Value = Call("compositeToPoint:operation:", point, op);
		}

		public void compositeToPointFromRectOperation(NSPoint point, NSRect rect, UInt32 op)
		{
			Unused.Value = Call("compositeToPoint:fromRect:operation:", point, rect, op);
		}

		public void compositeToPointOperationFraction(NSPoint point, UInt32 op, float delta)
		{
			Unused.Value = Call("compositeToPoint:operation:fraction:", point, op, delta);
		}

		public void compositeToPointFromRectOperationFraction(NSPoint point, NSRect rect, UInt32 op, float delta)
		{
			Unused.Value = Call("compositeToPoint:fromRect:operation:fraction:", point, rect, op, delta);
		}

		public void drawAtPointFromRectOperationFraction(NSPoint point, NSRect fromRect, UInt32 op, float delta)
		{
			Unused.Value = Call("drawAtPoint:fromRect:operation:fraction:", point, fromRect, op, delta);
		}

		public void drawInRectFromRectOperationFraction(NSRect rect, NSRect fromRect, UInt32 op, float delta)
		{
			Unused.Value = Call("drawInRect:fromRect:operation:fraction:", rect, fromRect, op, delta);
		}

		public bool drawRepresentationInRect(NSImageRep imageRep, NSRect rect)
		{
			return Call("drawRepresentation:inRect:", imageRep, rect).To<bool>();
		}

		public void recache()
		{
			Unused.Value = Call("recache");
		}

		public NSData TIFFRepresentation()
		{
			return Call("TIFFRepresentation").To<NSData>();
		}

		public NSData TIFFRepresentationUsingCompressionFactor(UInt32 comp, float aFloat)
		{
			return Call("TIFFRepresentationUsingCompression:factor:", comp, aFloat).To<NSData>();
		}

		public NSArray representations()
		{
			return Call("representations").To<NSArray>();
		}

		public void addRepresentations(NSArray imageReps)
		{
			Unused.Value = Call("addRepresentations:", imageReps);
		}

		public void addRepresentation(NSImageRep imageRep)
		{
			Unused.Value = Call("addRepresentation:", imageRep);
		}

		public void removeRepresentation(NSImageRep imageRep)
		{
			Unused.Value = Call("removeRepresentation:", imageRep);
		}

		public bool isValid()
		{
			return Call("isValid").To<bool>();
		}

		public void lockFocus()
		{
			Unused.Value = Call("lockFocus");
		}

		public void lockFocusOnRepresentation(NSImageRep imageRepresentation)
		{
			Unused.Value = Call("lockFocusOnRepresentation:", imageRepresentation);
		}

		public void unlockFocus()
		{
			Unused.Value = Call("unlockFocus");
		}

		public NSImageRep bestRepresentationForDevice(NSDictionary deviceDescription)
		{
			return Call("bestRepresentationForDevice:", deviceDescription).To<NSImageRep>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
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

		public static NSArray imageTypes()
		{
			return ms_class.Call("imageTypes").To<NSArray>();
		}

		public static NSArray imageUnfilteredTypes()
		{
			return ms_class.Call("imageUnfilteredTypes").To<NSArray>();
		}

		public static bool canInitWithPasteboard(NSPasteboard pasteboard)
		{
			return ms_class.Call("canInitWithPasteboard:", pasteboard).To<bool>();
		}

		public void setFlipped(bool flag)
		{
			Unused.Value = Call("setFlipped:", flag);
		}

		public bool isFlipped()
		{
			return Call("isFlipped").To<bool>();
		}

		public void cancelIncrementalLoad()
		{
			Unused.Value = Call("cancelIncrementalLoad");
		}

		public void setCacheMode(UInt32 mode)
		{
			Unused.Value = Call("setCacheMode:", mode);
		}

		public UInt32 cacheMode()
		{
			return Call("cacheMode").To<UInt32>();
		}

		public NSRect alignmentRect()
		{
			return Call("alignmentRect").To<NSRect>();
		}

		public void setAlignmentRect(NSRect rect)
		{
			Unused.Value = Call("setAlignmentRect:", rect);
		}

		public bool isTemplate()
		{
			return Call("isTemplate").To<bool>();
		}

		public void setTemplate(bool isTemplate)
		{
			Unused.Value = Call("setTemplate:", isTemplate);
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

		private static Class ms_class = new Class("NSImage");
	}

	public static class NSImageDelegateForNSObjectCategory
	{
		public static NSImage imageDidNotDrawInRect(this NSObject _instance, NSObject sender, NSRect aRect)
		{
			return _instance.Call("imageDidNotDraw:inRect:", sender, aRect).To<NSImage>();
		}

		public static void imageWillLoadRepresentation(this NSObject _instance, NSImage image, NSImageRep rep)
		{
			Unused.Value = _instance.Call("image:willLoadRepresentation:", image, rep);
		}

		public static void imageDidLoadRepresentationHeader(this NSObject _instance, NSImage image, NSImageRep rep)
		{
			Unused.Value = _instance.Call("image:didLoadRepresentationHeader:", image, rep);
		}

		public static void imageDidLoadPartOfRepresentationWithValidRows(this NSObject _instance, NSImage image, NSImageRep rep, Int32 rows)
		{
			Unused.Value = _instance.Call("image:didLoadPartOfRepresentation:withValidRows:", image, rep, rows);
		}

		public static void imageDidLoadRepresentationWithStatus(this NSObject _instance, NSImage image, NSImageRep rep, UInt32 status)
		{
			Unused.Value = _instance.Call("image:didLoadRepresentation:withStatus:", image, rep, status);
		}
	}

	public static class NSBundleImageExtensionForNSBundleCategory
	{
		public static NSString pathForImageResource(this NSBundle _instance, NSString name)
		{
			return _instance.Call("pathForImageResource:", name).To<NSString>();
		}
	}
}
