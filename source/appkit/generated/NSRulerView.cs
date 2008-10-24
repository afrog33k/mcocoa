// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSRulerView.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSHorizontalRuler = 0;
		public const int NSVerticalRuler = 1;
	}

	[Register]
	public partial class NSRulerView : NSView
	{
		public NSRulerView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSRulerView(IntPtr instance) : base(instance)
		{
		}

		public NSRulerView(Untyped instance) : base(instance)
		{
		}

		public static new NSRulerView alloc()
		{
			return new NSRulerView(ms_class.Call("alloc"));
		}

		public new NSRulerView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void registerUnitWithNameAbbreviationUnitToPointsConversionFactorStepUpCycleStepDownCycle(NSString unitName, NSString abbreviation, float conversionFactor, NSArray stepUpCycle, NSArray stepDownCycle)
		{
			Unused.Value = ms_class.Call("registerUnitWithName:abbreviation:unitToPointsConversionFactor:stepUpCycle:stepDownCycle:", unitName, abbreviation, conversionFactor, stepUpCycle, stepDownCycle);
		}

		public NSObject initWithScrollViewOrientation(NSScrollView scrollView, UInt32 orientation)
		{
			return Call("initWithScrollView:orientation:", scrollView, orientation).To<NSObject>();
		}

		public void setScrollView(NSScrollView scrollView)
		{
			Unused.Value = Call("setScrollView:", scrollView);
		}

		public NSScrollView scrollView()
		{
			return Call("scrollView").To<NSScrollView>();
		}

		public void setOrientation(UInt32 orientation)
		{
			Unused.Value = Call("setOrientation:", orientation);
		}

		public UInt32 orientation()
		{
			return Call("orientation").To<UInt32>();
		}

		public float baselineLocation()
		{
			return Call("baselineLocation").To<float>();
		}

		public float requiredThickness()
		{
			return Call("requiredThickness").To<float>();
		}

		public void setRuleThickness(float thickness)
		{
			Unused.Value = Call("setRuleThickness:", thickness);
		}

		public float ruleThickness()
		{
			return Call("ruleThickness").To<float>();
		}

		public void setReservedThicknessForMarkers(float thickness)
		{
			Unused.Value = Call("setReservedThicknessForMarkers:", thickness);
		}

		public float reservedThicknessForMarkers()
		{
			return Call("reservedThicknessForMarkers").To<float>();
		}

		public void setReservedThicknessForAccessoryView(float thickness)
		{
			Unused.Value = Call("setReservedThicknessForAccessoryView:", thickness);
		}

		public float reservedThicknessForAccessoryView()
		{
			return Call("reservedThicknessForAccessoryView").To<float>();
		}

		public void setMeasurementUnits(NSString unitName)
		{
			Unused.Value = Call("setMeasurementUnits:", unitName);
		}

		public NSString measurementUnits()
		{
			return Call("measurementUnits").To<NSString>();
		}

		public void setOriginOffset(float offset)
		{
			Unused.Value = Call("setOriginOffset:", offset);
		}

		public float originOffset()
		{
			return Call("originOffset").To<float>();
		}

		public void setClientView(NSView client)
		{
			Unused.Value = Call("setClientView:", client);
		}

		public NSView clientView()
		{
			return Call("clientView").To<NSView>();
		}

		public void setMarkers(NSArray markers)
		{
			Unused.Value = Call("setMarkers:", markers);
		}

		public void addMarker(NSRulerMarker marker)
		{
			Unused.Value = Call("addMarker:", marker);
		}

		public void removeMarker(NSRulerMarker marker)
		{
			Unused.Value = Call("removeMarker:", marker);
		}

		public NSArray markers()
		{
			return Call("markers").To<NSArray>();
		}

		public bool trackMarkerWithMouseEvent(NSRulerMarker marker, NSEvent event_)
		{
			return Call("trackMarker:withMouseEvent:", marker, event_).To<bool>();
		}

		public void setAccessoryView(NSView accessory)
		{
			Unused.Value = Call("setAccessoryView:", accessory);
		}

		public NSView accessoryView()
		{
			return Call("accessoryView").To<NSView>();
		}

		public void moveRulerlineFromLocationToLocation(float oldLocation, float newLocation)
		{
			Unused.Value = Call("moveRulerlineFromLocation:toLocation:", oldLocation, newLocation);
		}

		public void invalidateHashMarks()
		{
			Unused.Value = Call("invalidateHashMarks");
		}

		public void drawHashMarksAndLabelsInRect(NSRect rect)
		{
			Unused.Value = Call("drawHashMarksAndLabelsInRect:", rect);
		}

		public void drawMarkersInRect(NSRect rect)
		{
			Unused.Value = Call("drawMarkersInRect:", rect);
		}

		// skipping isFlipped (it's declared in a base class)

		private static Class ms_class = new Class("NSRulerView");
	}

	public static class NSRulerMarkerClientViewDelegationForNSViewCategory
	{
		public static bool rulerViewShouldMoveMarker(this NSView _instance, NSRulerView ruler, NSRulerMarker marker)
		{
			return _instance.Call("rulerView:shouldMoveMarker:", ruler, marker).To<bool>();
		}

		public static float rulerViewWillMoveMarkerToLocation(this NSView _instance, NSRulerView ruler, NSRulerMarker marker, float location)
		{
			return _instance.Call("rulerView:willMoveMarker:toLocation:", ruler, marker, location).To<float>();
		}

		public static void rulerViewDidMoveMarker(this NSView _instance, NSRulerView ruler, NSRulerMarker marker)
		{
			Unused.Value = _instance.Call("rulerView:didMoveMarker:", ruler, marker);
		}

		public static bool rulerViewShouldRemoveMarker(this NSView _instance, NSRulerView ruler, NSRulerMarker marker)
		{
			return _instance.Call("rulerView:shouldRemoveMarker:", ruler, marker).To<bool>();
		}

		public static void rulerViewDidRemoveMarker(this NSView _instance, NSRulerView ruler, NSRulerMarker marker)
		{
			Unused.Value = _instance.Call("rulerView:didRemoveMarker:", ruler, marker);
		}

		public static bool rulerViewShouldAddMarker(this NSView _instance, NSRulerView ruler, NSRulerMarker marker)
		{
			return _instance.Call("rulerView:shouldAddMarker:", ruler, marker).To<bool>();
		}

		public static float rulerViewWillAddMarkerAtLocation(this NSView _instance, NSRulerView ruler, NSRulerMarker marker, float location)
		{
			return _instance.Call("rulerView:willAddMarker:atLocation:", ruler, marker, location).To<float>();
		}

		public static void rulerViewDidAddMarker(this NSView _instance, NSRulerView ruler, NSRulerMarker marker)
		{
			Unused.Value = _instance.Call("rulerView:didAddMarker:", ruler, marker);
		}

		public static void rulerViewHandleMouseDown(this NSView _instance, NSRulerView ruler, NSEvent event_)
		{
			Unused.Value = _instance.Call("rulerView:handleMouseDown:", ruler, event_);
		}

		public static void rulerViewWillSetClientView(this NSView _instance, NSRulerView ruler, NSView newClient)
		{
			Unused.Value = _instance.Call("rulerView:willSetClientView:", ruler, newClient);
		}
	}
}
