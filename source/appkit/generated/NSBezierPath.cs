// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSBezierPath.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSButtLineCapStyle = 0;
		public const int NSRoundLineCapStyle = 1;
		public const int NSSquareLineCapStyle = 2;
	}

	public partial class Enums
	{
		public const int NSMiterLineJoinStyle = 0;
		public const int NSRoundLineJoinStyle = 1;
		public const int NSBevelLineJoinStyle = 2;
	}

	public partial class Enums
	{
		public const int NSNonZeroWindingRule = 0;
		public const int NSEvenOddWindingRule = 1;
	}

	public partial class Enums
	{
		public const int NSMoveToBezierPathElement = 0;
		public const int NSLineToBezierPathElement = 1;
		public const int NSCurveToBezierPathElement = 2;
		public const int NSClosePathBezierPathElement = 3;
	}

	[Register]
	public partial class NSBezierPath : NSObject
	{
		public NSBezierPath() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSBezierPath(IntPtr instance) : base(instance)
		{
		}

		public NSBezierPath(Untyped instance) : base(instance)
		{
		}

		public static new NSBezierPath alloc()
		{
			return new NSBezierPath(ms_class.Call("alloc"));
		}

		public new NSBezierPath retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSBezierPath bezierPath()
		{
			return ms_class.Call("bezierPath").To<NSBezierPath>();
		}

		public static NSBezierPath bezierPathWithRect(NSRect rect)
		{
			return ms_class.Call("bezierPathWithRect:", rect).To<NSBezierPath>();
		}

		public static NSBezierPath bezierPathWithOvalInRect(NSRect rect)
		{
			return ms_class.Call("bezierPathWithOvalInRect:", rect).To<NSBezierPath>();
		}

		public static NSBezierPath bezierPathWithRoundedRectXRadiusYRadius(NSRect rect, float xRadius, float yRadius)
		{
			return ms_class.Call("bezierPathWithRoundedRect:xRadius:yRadius:", rect, xRadius, yRadius).To<NSBezierPath>();
		}

		public static void fillRect(NSRect rect)
		{
			Unused.Value = ms_class.Call("fillRect:", rect);
		}

		public static void strokeRect(NSRect rect)
		{
			Unused.Value = ms_class.Call("strokeRect:", rect);
		}

		public static void clipRect(NSRect rect)
		{
			Unused.Value = ms_class.Call("clipRect:", rect);
		}

		public static void strokeLineFromPointToPoint(NSPoint point1, NSPoint point2)
		{
			Unused.Value = ms_class.Call("strokeLineFromPoint:toPoint:", point1, point2);
		}

		public static void drawPackedGlyphsAtPoint(string packedGlyphs, NSPoint point)
		{
			Unused.Value = ms_class.Call("drawPackedGlyphs:atPoint:", packedGlyphs, point);
		}

		public static void setDefaultMiterLimit(float limit)
		{
			Unused.Value = ms_class.Call("setDefaultMiterLimit:", limit);
		}

		public static float defaultMiterLimit()
		{
			return ms_class.Call("defaultMiterLimit").To<float>();
		}

		public static void setDefaultFlatness(float flatness)
		{
			Unused.Value = ms_class.Call("setDefaultFlatness:", flatness);
		}

		public static float defaultFlatness()
		{
			return ms_class.Call("defaultFlatness").To<float>();
		}

		public static void setDefaultWindingRule(UInt32 windingRule)
		{
			Unused.Value = ms_class.Call("setDefaultWindingRule:", windingRule);
		}

		public static UInt32 defaultWindingRule()
		{
			return ms_class.Call("defaultWindingRule").To<UInt32>();
		}

		public static void setDefaultLineCapStyle(UInt32 lineCapStyle)
		{
			Unused.Value = ms_class.Call("setDefaultLineCapStyle:", lineCapStyle);
		}

		public static UInt32 defaultLineCapStyle()
		{
			return ms_class.Call("defaultLineCapStyle").To<UInt32>();
		}

		public static void setDefaultLineJoinStyle(UInt32 lineJoinStyle)
		{
			Unused.Value = ms_class.Call("setDefaultLineJoinStyle:", lineJoinStyle);
		}

		public static UInt32 defaultLineJoinStyle()
		{
			return ms_class.Call("defaultLineJoinStyle").To<UInt32>();
		}

		public static void setDefaultLineWidth(float lineWidth)
		{
			Unused.Value = ms_class.Call("setDefaultLineWidth:", lineWidth);
		}

		public static float defaultLineWidth()
		{
			return ms_class.Call("defaultLineWidth").To<float>();
		}

		public void moveToPoint(NSPoint point)
		{
			Unused.Value = Call("moveToPoint:", point);
		}

		public void lineToPoint(NSPoint point)
		{
			Unused.Value = Call("lineToPoint:", point);
		}

		public void curveToPointControlPoint1ControlPoint2(NSPoint endPoint, NSPoint controlPoint1, NSPoint controlPoint2)
		{
			Unused.Value = Call("curveToPoint:controlPoint1:controlPoint2:", endPoint, controlPoint1, controlPoint2);
		}

		public void closePath()
		{
			Unused.Value = Call("closePath");
		}

		public void removeAllPoints()
		{
			Unused.Value = Call("removeAllPoints");
		}

		public void relativeMoveToPoint(NSPoint point)
		{
			Unused.Value = Call("relativeMoveToPoint:", point);
		}

		public void relativeLineToPoint(NSPoint point)
		{
			Unused.Value = Call("relativeLineToPoint:", point);
		}

		public void relativeCurveToPointControlPoint1ControlPoint2(NSPoint endPoint, NSPoint controlPoint1, NSPoint controlPoint2)
		{
			Unused.Value = Call("relativeCurveToPoint:controlPoint1:controlPoint2:", endPoint, controlPoint1, controlPoint2);
		}

		public float lineWidth()
		{
			return Call("lineWidth").To<float>();
		}

		public void setLineWidth(float lineWidth)
		{
			Unused.Value = Call("setLineWidth:", lineWidth);
		}

		public UInt32 lineCapStyle()
		{
			return Call("lineCapStyle").To<UInt32>();
		}

		public void setLineCapStyle(UInt32 lineCapStyle)
		{
			Unused.Value = Call("setLineCapStyle:", lineCapStyle);
		}

		public UInt32 lineJoinStyle()
		{
			return Call("lineJoinStyle").To<UInt32>();
		}

		public void setLineJoinStyle(UInt32 lineJoinStyle)
		{
			Unused.Value = Call("setLineJoinStyle:", lineJoinStyle);
		}

		public UInt32 windingRule()
		{
			return Call("windingRule").To<UInt32>();
		}

		public void setWindingRule(UInt32 windingRule)
		{
			Unused.Value = Call("setWindingRule:", windingRule);
		}

		public float miterLimit()
		{
			return Call("miterLimit").To<float>();
		}

		public void setMiterLimit(float miterLimit)
		{
			Unused.Value = Call("setMiterLimit:", miterLimit);
		}

		public float flatness()
		{
			return Call("flatness").To<float>();
		}

		public void setFlatness(float flatness)
		{
			Unused.Value = Call("setFlatness:", flatness);
		}

		public void getLineDashCountPhase(IntPtr pattern, IntPtr count, IntPtr phase)
		{
			Unused.Value = Call("getLineDash:count:phase:", pattern, count, phase);
		}

		public void setLineDashCountPhase(IntPtr pattern, Int32 count, float phase)
		{
			Unused.Value = Call("setLineDash:count:phase:", pattern, count, phase);
		}

		public void stroke()
		{
			Unused.Value = Call("stroke");
		}

		public void fill()
		{
			Unused.Value = Call("fill");
		}

		public void addClip()
		{
			Unused.Value = Call("addClip");
		}

		public void setClip()
		{
			Unused.Value = Call("setClip");
		}

		public NSBezierPath bezierPathByFlatteningPath()
		{
			return Call("bezierPathByFlatteningPath").To<NSBezierPath>();
		}

		public NSBezierPath bezierPathByReversingPath()
		{
			return Call("bezierPathByReversingPath").To<NSBezierPath>();
		}

		public void transformUsingAffineTransform(NSAffineTransform transform)
		{
			Unused.Value = Call("transformUsingAffineTransform:", transform);
		}

		public bool isEmpty()
		{
			return Call("isEmpty").To<bool>();
		}

		public NSPoint currentPoint()
		{
			return Call("currentPoint").To<NSPoint>();
		}

		public NSRect controlPointBounds()
		{
			return Call("controlPointBounds").To<NSRect>();
		}

		public NSRect bounds()
		{
			return Call("bounds").To<NSRect>();
		}

		public Int32 elementCount()
		{
			return Call("elementCount").To<Int32>();
		}

		public UInt32 elementAtIndexAssociatedPoints(Int32 index, IntPtr points)
		{
			return Call("elementAtIndex:associatedPoints:", index, points).To<UInt32>();
		}

		public UInt32 elementAtIndex(Int32 index)
		{
			return Call("elementAtIndex:", index).To<UInt32>();
		}

		public void setAssociatedPointsAtIndex(IntPtr points, Int32 index)
		{
			Unused.Value = Call("setAssociatedPoints:atIndex:", points, index);
		}

		public void appendBezierPath(NSBezierPath path)
		{
			Unused.Value = Call("appendBezierPath:", path);
		}

		public void appendBezierPathWithRect(NSRect rect)
		{
			Unused.Value = Call("appendBezierPathWithRect:", rect);
		}

		public void appendBezierPathWithPointsCount(IntPtr points, Int32 count)
		{
			Unused.Value = Call("appendBezierPathWithPoints:count:", points, count);
		}

		public void appendBezierPathWithOvalInRect(NSRect rect)
		{
			Unused.Value = Call("appendBezierPathWithOvalInRect:", rect);
		}

		public void appendBezierPathWithArcWithCenterRadiusStartAngleEndAngleClockwise(NSPoint center, float radius, float startAngle, float endAngle, bool clockwise)
		{
			Unused.Value = Call("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:", center, radius, startAngle, endAngle, clockwise);
		}

		public void appendBezierPathWithArcWithCenterRadiusStartAngleEndAngle(NSPoint center, float radius, float startAngle, float endAngle)
		{
			Unused.Value = Call("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:", center, radius, startAngle, endAngle);
		}

		public void appendBezierPathWithArcFromPointToPointRadius(NSPoint point1, NSPoint point2, float radius)
		{
			Unused.Value = Call("appendBezierPathWithArcFromPoint:toPoint:radius:", point1, point2, radius);
		}

		public void appendBezierPathWithGlyphInFont(UInt32 glyph, NSFont font)
		{
			Unused.Value = Call("appendBezierPathWithGlyph:inFont:", glyph, font);
		}

		public void appendBezierPathWithGlyphsCountInFont(IntPtr glyphs, Int32 count, NSFont font)
		{
			Unused.Value = Call("appendBezierPathWithGlyphs:count:inFont:", glyphs, count, font);
		}

		public void appendBezierPathWithPackedGlyphs(string packedGlyphs)
		{
			Unused.Value = Call("appendBezierPathWithPackedGlyphs:", packedGlyphs);
		}

		public void appendBezierPathWithRoundedRectXRadiusYRadius(NSRect rect, float xRadius, float yRadius)
		{
			Unused.Value = Call("appendBezierPathWithRoundedRect:xRadius:yRadius:", rect, xRadius, yRadius);
		}

		public bool containsPoint(NSPoint point)
		{
			return Call("containsPoint:", point).To<bool>();
		}

		public bool cachesBezierPath()
		{
			return Call("cachesBezierPath").To<bool>();
		}

		public void setCachesBezierPath(bool flag)
		{
			Unused.Value = Call("setCachesBezierPath:", flag);
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

		private static Class ms_class = new Class("NSBezierPath");
	}
}
