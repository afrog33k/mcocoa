// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSGeometry.h

using MObjc;
using System;

namespace MCocoa
{
	public enum NSRectEdge
	{
		NSMinXEdge = 0,
		NSMinYEdge = 1,
		NSMaxXEdge = 2,
		NSMaxYEdge = 3,
	}

	public static class NSValueGeometryExtensionsForNSValueCategory
	{
		public static NSValue valueWithPoint(this NSValue _instance, NSPoint point)
		{
			return _instance.Call("valueWithPoint:", point).To<NSValue>();
		}

		public static NSValue valueWithSize(this NSValue _instance, NSSize size)
		{
			return _instance.Call("valueWithSize:", size).To<NSValue>();
		}

		public static NSValue valueWithRect(this NSValue _instance, NSRect rect)
		{
			return _instance.Call("valueWithRect:", rect).To<NSValue>();
		}

		public static NSPoint pointValue(this NSValue _instance)
		{
			return _instance.Call("pointValue").To<NSPoint>();
		}

		public static NSSize sizeValue(this NSValue _instance)
		{
			return _instance.Call("sizeValue").To<NSSize>();
		}

		public static NSRect rectValue(this NSValue _instance)
		{
			return _instance.Call("rectValue").To<NSRect>();
		}
	}

	public static class NSGeometryCodingForNSCoderCategory
	{
		public static void encodePoint(this NSCoder _instance, NSPoint point)
		{
			Unused.Value = _instance.Call("encodePoint:", point);
		}

		public static NSPoint decodePoint(this NSCoder _instance)
		{
			return _instance.Call("decodePoint").To<NSPoint>();
		}

		public static void encodeSize(this NSCoder _instance, NSSize size)
		{
			Unused.Value = _instance.Call("encodeSize:", size);
		}

		public static NSSize decodeSize(this NSCoder _instance)
		{
			return _instance.Call("decodeSize").To<NSSize>();
		}

		public static void encodeRect(this NSCoder _instance, NSRect rect)
		{
			Unused.Value = _instance.Call("encodeRect:", rect);
		}

		public static NSRect decodeRect(this NSCoder _instance)
		{
			return _instance.Call("decodeRect").To<NSRect>();
		}
	}
}
