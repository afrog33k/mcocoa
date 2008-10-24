// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSGradient.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSGradientDrawsBeforeStartingLocation = ( 1 << 0 );
		public const int NSGradientDrawsAfterEndingLocation = ( 1 << 1 );
	}

	[Register]
	public partial class NSGradient : NSObject
	{
		public NSGradient() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSGradient(IntPtr instance) : base(instance)
		{
		}

		public NSGradient(Untyped instance) : base(instance)
		{
		}

		public static new NSGradient alloc()
		{
			return new NSGradient(ms_class.Call("alloc"));
		}

		public new NSGradient retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithStartingColorEndingColor(NSColor startingColor, NSColor endingColor)
		{
			return Call("initWithStartingColor:endingColor:", startingColor, endingColor).To<NSObject>();
		}

		public NSObject initWithColors(NSArray colorArray)
		{
			return Call("initWithColors:", colorArray).To<NSObject>();
		}

		// skipping initWithColorsAndLocations: because it is variadic

		public NSObject initWithColorsAtLocationsColorSpace(NSArray colorArray, IntPtr locations, NSColorSpace colorSpace)
		{
			return Call("initWithColors:atLocations:colorSpace:", colorArray, locations, colorSpace).To<NSObject>();
		}

		public void drawFromPointToPointOptions(NSPoint startingPoint, NSPoint endingPoint, UInt32 options)
		{
			Unused.Value = Call("drawFromPoint:toPoint:options:", startingPoint, endingPoint, options);
		}

		public void drawInRectAngle(NSRect rect, float angle)
		{
			Unused.Value = Call("drawInRect:angle:", rect, angle);
		}

		public void drawInBezierPathAngle(NSBezierPath path, float angle)
		{
			Unused.Value = Call("drawInBezierPath:angle:", path, angle);
		}

		public void drawFromCenterRadiusToCenterRadiusOptions(NSPoint startCenter, float startRadius, NSPoint endCenter, float endRadius, UInt32 options)
		{
			Unused.Value = Call("drawFromCenter:radius:toCenter:radius:options:", startCenter, startRadius, endCenter, endRadius, options);
		}

		public void drawInRectRelativeCenterPosition(NSRect rect, NSPoint relativeCenterPosition)
		{
			Unused.Value = Call("drawInRect:relativeCenterPosition:", rect, relativeCenterPosition);
		}

		public void drawInBezierPathRelativeCenterPosition(NSBezierPath path, NSPoint relativeCenterPosition)
		{
			Unused.Value = Call("drawInBezierPath:relativeCenterPosition:", path, relativeCenterPosition);
		}

		public NSColorSpace colorSpace()
		{
			return Call("colorSpace").To<NSColorSpace>();
		}

		public Int32 numberOfColorStops()
		{
			return Call("numberOfColorStops").To<Int32>();
		}

		public void getColorLocationAtIndex(IntPtr color, IntPtr location, Int32 index)
		{
			Unused.Value = Call("getColor:location:atIndex:", color, location, index);
		}

		public NSColor interpolatedColorAtLocation(float location)
		{
			return Call("interpolatedColorAtLocation:", location).To<NSColor>();
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

		private static Class ms_class = new Class("NSGradient");
	}
}
