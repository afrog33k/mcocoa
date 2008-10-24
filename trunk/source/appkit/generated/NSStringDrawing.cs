// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSStringDrawing.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSStringDrawingTruncatesLastVisibleLine = ( 1 << 5 );
		public const int NSStringDrawingUsesLineFragmentOrigin = ( 1 << 0 );
		public const int NSStringDrawingUsesFontLeading = ( 1 << 1 );
		public const int NSStringDrawingDisableScreenFontSubstitution = ( 1 << 2 );
		public const int NSStringDrawingUsesDeviceMetrics = ( 1 << 3 );
		public const int NSStringDrawingOneShot = ( 1 << 4 );
	}

	public static class NSStringDrawingForNSStringCategory
	{
		public static NSSize sizeWithAttributes(this NSString _instance, NSDictionary attrs)
		{
			return _instance.Call("sizeWithAttributes:", attrs).To<NSSize>();
		}

		public static void drawAtPointWithAttributes(this NSString _instance, NSPoint point, NSDictionary attrs)
		{
			Unused.Value = _instance.Call("drawAtPoint:withAttributes:", point, attrs);
		}

		public static void drawInRectWithAttributes(this NSString _instance, NSRect rect, NSDictionary attrs)
		{
			Unused.Value = _instance.Call("drawInRect:withAttributes:", rect, attrs);
		}
	}

	public static class NSStringDrawingForNSAttributedStringCategory
	{
		public static NSSize size(this NSAttributedString _instance)
		{
			return _instance.Call("size").To<NSSize>();
		}

		public static void drawAtPoint(this NSAttributedString _instance, NSPoint point)
		{
			Unused.Value = _instance.Call("drawAtPoint:", point);
		}

		public static void drawInRect(this NSAttributedString _instance, NSRect rect)
		{
			Unused.Value = _instance.Call("drawInRect:", rect);
		}
	}

	public static class NSExtendedStringDrawingForNSStringCategory
	{
		public static void drawWithRectOptionsAttributes(this NSString _instance, NSRect rect, Int32 options, NSDictionary attributes)
		{
			Unused.Value = _instance.Call("drawWithRect:options:attributes:", rect, options, attributes);
		}

		public static NSRect boundingRectWithSizeOptionsAttributes(this NSString _instance, NSSize size, Int32 options, NSDictionary attributes)
		{
			return _instance.Call("boundingRectWithSize:options:attributes:", size, options, attributes).To<NSRect>();
		}
	}

	public static class NSExtendedStringDrawingForNSAttributedStringCategory
	{
		public static void drawWithRectOptions(this NSAttributedString _instance, NSRect rect, Int32 options)
		{
			Unused.Value = _instance.Call("drawWithRect:options:", rect, options);
		}

		public static NSRect boundingRectWithSizeOptions(this NSAttributedString _instance, NSSize size, Int32 options)
		{
			return _instance.Call("boundingRectWithSize:options:", size, options).To<NSRect>();
		}
	}
}
