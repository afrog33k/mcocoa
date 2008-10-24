// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSEvent.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSLeftMouseDown = 1;
		public const int NSLeftMouseUp = 2;
		public const int NSRightMouseDown = 3;
		public const int NSRightMouseUp = 4;
		public const int NSMouseMoved = 5;
		public const int NSLeftMouseDragged = 6;
		public const int NSRightMouseDragged = 7;
		public const int NSMouseEntered = 8;
		public const int NSMouseExited = 9;
		public const int NSKeyDown = 10;
		public const int NSKeyUp = 11;
		public const int NSFlagsChanged = 12;
		public const int NSAppKitDefined = 13;
		public const int NSSystemDefined = 14;
		public const int NSApplicationDefined = 15;
		public const int NSPeriodic = 16;
		public const int NSCursorUpdate = 17;
		public const int NSScrollWheel = 22;
		public const int NSTabletPoint = 23;
		public const int NSTabletProximity = 24;
		public const int NSOtherMouseDown = 25;
		public const int NSOtherMouseUp = 26;
		public const int NSOtherMouseDragged = 27;
	}

	public partial class Enums
	{
		public const int NSLeftMouseDownMask = 1 << NSLeftMouseDown;
		public const int NSLeftMouseUpMask = 1 << NSLeftMouseUp;
		public const int NSRightMouseDownMask = 1 << NSRightMouseDown;
		public const int NSRightMouseUpMask = 1 << NSRightMouseUp;
		public const int NSMouseMovedMask = 1 << NSMouseMoved;
		public const int NSLeftMouseDraggedMask = 1 << NSLeftMouseDragged;
		public const int NSRightMouseDraggedMask = 1 << NSRightMouseDragged;
		public const int NSMouseEnteredMask = 1 << NSMouseEntered;
		public const int NSMouseExitedMask = 1 << NSMouseExited;
		public const int NSKeyDownMask = 1 << NSKeyDown;
		public const int NSKeyUpMask = 1 << NSKeyUp;
		public const int NSFlagsChangedMask = 1 << NSFlagsChanged;
		public const int NSAppKitDefinedMask = 1 << NSAppKitDefined;
		public const int NSSystemDefinedMask = 1 << NSSystemDefined;
		public const int NSApplicationDefinedMask = 1 << NSApplicationDefined;
		public const int NSPeriodicMask = 1 << NSPeriodic;
		public const int NSCursorUpdateMask = 1 << NSCursorUpdate;
		public const int NSScrollWheelMask = 1 << NSScrollWheel;
		public const int NSTabletPointMask = 1 << NSTabletPoint;
		public const int NSTabletProximityMask = 1 << NSTabletProximity;
		public const int NSOtherMouseDownMask = 1 << NSOtherMouseDown;
		public const int NSOtherMouseUpMask = 1 << NSOtherMouseUp;
		public const int NSOtherMouseDraggedMask = 1 << NSOtherMouseDragged;
		public const uint NSAnyEventMask = uint.MaxValue;
	}

	public partial class Enums
	{
		public const int NSAlphaShiftKeyMask = 1 << 16;
		public const int NSShiftKeyMask = 1 << 17;
		public const int NSControlKeyMask = 1 << 18;
		public const int NSAlternateKeyMask = 1 << 19;
		public const int NSCommandKeyMask = 1 << 20;
		public const int NSNumericPadKeyMask = 1 << 21;
		public const int NSHelpKeyMask = 1 << 22;
		public const int NSFunctionKeyMask = 1 << 23;
		public const uint NSDeviceIndependentModifierFlagsMask = 0xffff0000;
	}

	public partial class Enums
	{
		public const int NSUnknownPointingDevice = 0;
		public const int NSPenPointingDevice = 1;
		public const int NSCursorPointingDevice = 2;
		public const int NSEraserPointingDevice = 3;
	}

	public partial class Enums
	{
		public const int NSPenTipMask = 0x0001;
		public const int NSPenLowerSideMask = 0x0002;
		public const int NSPenUpperSideMask = 0x0004;
	}

	public partial class Enums
	{
		public const int NSUpArrowFunctionKey = 0xF700;
		public const int NSDownArrowFunctionKey = 0xF701;
		public const int NSLeftArrowFunctionKey = 0xF702;
		public const int NSRightArrowFunctionKey = 0xF703;
		public const int NSF1FunctionKey = 0xF704;
		public const int NSF2FunctionKey = 0xF705;
		public const int NSF3FunctionKey = 0xF706;
		public const int NSF4FunctionKey = 0xF707;
		public const int NSF5FunctionKey = 0xF708;
		public const int NSF6FunctionKey = 0xF709;
		public const int NSF7FunctionKey = 0xF70A;
		public const int NSF8FunctionKey = 0xF70B;
		public const int NSF9FunctionKey = 0xF70C;
		public const int NSF10FunctionKey = 0xF70D;
		public const int NSF11FunctionKey = 0xF70E;
		public const int NSF12FunctionKey = 0xF70F;
		public const int NSF13FunctionKey = 0xF710;
		public const int NSF14FunctionKey = 0xF711;
		public const int NSF15FunctionKey = 0xF712;
		public const int NSF16FunctionKey = 0xF713;
		public const int NSF17FunctionKey = 0xF714;
		public const int NSF18FunctionKey = 0xF715;
		public const int NSF19FunctionKey = 0xF716;
		public const int NSF20FunctionKey = 0xF717;
		public const int NSF21FunctionKey = 0xF718;
		public const int NSF22FunctionKey = 0xF719;
		public const int NSF23FunctionKey = 0xF71A;
		public const int NSF24FunctionKey = 0xF71B;
		public const int NSF25FunctionKey = 0xF71C;
		public const int NSF26FunctionKey = 0xF71D;
		public const int NSF27FunctionKey = 0xF71E;
		public const int NSF28FunctionKey = 0xF71F;
		public const int NSF29FunctionKey = 0xF720;
		public const int NSF30FunctionKey = 0xF721;
		public const int NSF31FunctionKey = 0xF722;
		public const int NSF32FunctionKey = 0xF723;
		public const int NSF33FunctionKey = 0xF724;
		public const int NSF34FunctionKey = 0xF725;
		public const int NSF35FunctionKey = 0xF726;
		public const int NSInsertFunctionKey = 0xF727;
		public const int NSDeleteFunctionKey = 0xF728;
		public const int NSHomeFunctionKey = 0xF729;
		public const int NSBeginFunctionKey = 0xF72A;
		public const int NSEndFunctionKey = 0xF72B;
		public const int NSPageUpFunctionKey = 0xF72C;
		public const int NSPageDownFunctionKey = 0xF72D;
		public const int NSPrintScreenFunctionKey = 0xF72E;
		public const int NSScrollLockFunctionKey = 0xF72F;
		public const int NSPauseFunctionKey = 0xF730;
		public const int NSSysReqFunctionKey = 0xF731;
		public const int NSBreakFunctionKey = 0xF732;
		public const int NSResetFunctionKey = 0xF733;
		public const int NSStopFunctionKey = 0xF734;
		public const int NSMenuFunctionKey = 0xF735;
		public const int NSUserFunctionKey = 0xF736;
		public const int NSSystemFunctionKey = 0xF737;
		public const int NSPrintFunctionKey = 0xF738;
		public const int NSClearLineFunctionKey = 0xF739;
		public const int NSClearDisplayFunctionKey = 0xF73A;
		public const int NSInsertLineFunctionKey = 0xF73B;
		public const int NSDeleteLineFunctionKey = 0xF73C;
		public const int NSInsertCharFunctionKey = 0xF73D;
		public const int NSDeleteCharFunctionKey = 0xF73E;
		public const int NSPrevFunctionKey = 0xF73F;
		public const int NSNextFunctionKey = 0xF740;
		public const int NSSelectFunctionKey = 0xF741;
		public const int NSExecuteFunctionKey = 0xF742;
		public const int NSUndoFunctionKey = 0xF743;
		public const int NSRedoFunctionKey = 0xF744;
		public const int NSFindFunctionKey = 0xF745;
		public const int NSHelpFunctionKey = 0xF746;
		public const int NSModeSwitchFunctionKey = 0xF747;
	}

	public partial class Enums
	{
		public const int NSWindowExposedEventType = 0;
		public const int NSApplicationActivatedEventType = 1;
		public const int NSApplicationDeactivatedEventType = 2;
		public const int NSWindowMovedEventType = 4;
		public const int NSScreenChangedEventType = 8;
		public const int NSAWTEventType = 16;
	}

	public partial class Enums
	{
		public const int NSPowerOffEventType = 1;
	}

	public partial class Enums
	{
		public const int NSMouseEventSubtype = 0;
		public const int NSTabletPointEventSubtype = 1;
		public const int NSTabletProximityEventSubtype = 2;
	}

	[Register]
	public partial class NSEvent : NSObject
	{
		public NSEvent() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSEvent(IntPtr instance) : base(instance)
		{
		}

		public NSEvent(Untyped instance) : base(instance)
		{
		}

		public static new NSEvent alloc()
		{
			return new NSEvent(ms_class.Call("alloc"));
		}

		public new NSEvent retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 type()
		{
			return Call("type").To<UInt32>();
		}

		public UInt32 modifierFlags()
		{
			return Call("modifierFlags").To<UInt32>();
		}

		public double timestamp()
		{
			return Call("timestamp").To<double>();
		}

		public NSWindow window()
		{
			return Call("window").To<NSWindow>();
		}

		public Int32 windowNumber()
		{
			return Call("windowNumber").To<Int32>();
		}

		public NSGraphicsContext context()
		{
			return Call("context").To<NSGraphicsContext>();
		}

		public Int32 clickCount()
		{
			return Call("clickCount").To<Int32>();
		}

		public Int32 buttonNumber()
		{
			return Call("buttonNumber").To<Int32>();
		}

		public Int32 eventNumber()
		{
			return Call("eventNumber").To<Int32>();
		}

		public float pressure()
		{
			return Call("pressure").To<float>();
		}

		public NSPoint locationInWindow()
		{
			return Call("locationInWindow").To<NSPoint>();
		}

		public float deltaX()
		{
			return Call("deltaX").To<float>();
		}

		public float deltaY()
		{
			return Call("deltaY").To<float>();
		}

		public float deltaZ()
		{
			return Call("deltaZ").To<float>();
		}

		public NSString characters()
		{
			return Call("characters").To<NSString>();
		}

		public NSString charactersIgnoringModifiers()
		{
			return Call("charactersIgnoringModifiers").To<NSString>();
		}

		public bool isARepeat()
		{
			return Call("isARepeat").To<bool>();
		}

		public UInt16 keyCode()
		{
			return Call("keyCode").To<UInt16>();
		}

		public Int32 trackingNumber()
		{
			return Call("trackingNumber").To<Int32>();
		}

		public IntPtr userData()
		{
			return Call("userData").To<IntPtr>();
		}

		public NSTrackingArea trackingArea()
		{
			return Call("trackingArea").To<NSTrackingArea>();
		}

		public UInt32 subtype()
		{
			return Call("subtype").To<UInt32>();
		}

		public Int32 data1()
		{
			return Call("data1").To<Int32>();
		}

		public Int32 data2()
		{
			return Call("data2").To<Int32>();
		}

		public IntPtr eventRef()
		{
			return Call("eventRef").To<IntPtr>();
		}

		public static NSEvent eventWithEventRef(IntPtr eventRef)
		{
			return ms_class.Call("eventWithEventRef:", eventRef).To<NSEvent>();
		}

		public IntPtr CGEvent()
		{
			return Call("CGEvent").To<IntPtr>();
		}

		public static NSEvent eventWithCGEvent(IntPtr cgEvent)
		{
			return ms_class.Call("eventWithCGEvent:", cgEvent).To<NSEvent>();
		}

		public static void setMouseCoalescingEnabled(bool flag)
		{
			Unused.Value = ms_class.Call("setMouseCoalescingEnabled:", flag);
		}

		public static bool isMouseCoalescingEnabled()
		{
			return ms_class.Call("isMouseCoalescingEnabled").To<bool>();
		}

		public UInt32 deviceID()
		{
			return Call("deviceID").To<UInt32>();
		}

		public Int32 absoluteX()
		{
			return Call("absoluteX").To<Int32>();
		}

		public Int32 absoluteY()
		{
			return Call("absoluteY").To<Int32>();
		}

		public Int32 absoluteZ()
		{
			return Call("absoluteZ").To<Int32>();
		}

		public UInt32 buttonMask()
		{
			return Call("buttonMask").To<UInt32>();
		}

		public NSPoint tilt()
		{
			return Call("tilt").To<NSPoint>();
		}

		public float rotation()
		{
			return Call("rotation").To<float>();
		}

		public float tangentialPressure()
		{
			return Call("tangentialPressure").To<float>();
		}

		public NSObject vendorDefined()
		{
			return Call("vendorDefined").To<NSObject>();
		}

		public UInt32 vendorID()
		{
			return Call("vendorID").To<UInt32>();
		}

		public UInt32 tabletID()
		{
			return Call("tabletID").To<UInt32>();
		}

		public UInt32 pointingDeviceID()
		{
			return Call("pointingDeviceID").To<UInt32>();
		}

		public UInt32 systemTabletID()
		{
			return Call("systemTabletID").To<UInt32>();
		}

		public UInt32 vendorPointingDeviceType()
		{
			return Call("vendorPointingDeviceType").To<UInt32>();
		}

		public UInt32 pointingDeviceSerialNumber()
		{
			return Call("pointingDeviceSerialNumber").To<UInt32>();
		}

		public UInt64 uniqueID()
		{
			return Call("uniqueID").To<UInt64>();
		}

		public UInt32 capabilityMask()
		{
			return Call("capabilityMask").To<UInt32>();
		}

		public UInt32 pointingDeviceType()
		{
			return Call("pointingDeviceType").To<UInt32>();
		}

		public bool isEnteringProximity()
		{
			return Call("isEnteringProximity").To<bool>();
		}

		public static void startPeriodicEventsAfterDelayWithPeriod(double delay, double period)
		{
			Unused.Value = ms_class.Call("startPeriodicEventsAfterDelay:withPeriod:", delay, period);
		}

		public static void stopPeriodicEvents()
		{
			Unused.Value = ms_class.Call("stopPeriodicEvents");
		}

		public static NSEvent mouseEventWithTypeLocationModifierFlagsTimestampWindowNumberContextEventNumberClickCountPressure(UInt32 type, NSPoint location, UInt32 flags, double time, Int32 wNum, NSGraphicsContext context, Int32 eNum, Int32 cNum, float pressure)
		{
			return ms_class.Call("mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:", type, location, flags, time, wNum, context, eNum, cNum, pressure).To<NSEvent>();
		}

		public static NSEvent keyEventWithTypeLocationModifierFlagsTimestampWindowNumberContextCharactersCharactersIgnoringModifiersIsARepeatKeyCode(UInt32 type, NSPoint location, UInt32 flags, double time, Int32 wNum, NSGraphicsContext context, NSString keys, NSString ukeys, bool flag, UInt16 code)
		{
			return ms_class.Call("keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:", type, location, flags, time, wNum, context, keys, ukeys, flag, code).To<NSEvent>();
		}

		public static NSEvent enterExitEventWithTypeLocationModifierFlagsTimestampWindowNumberContextEventNumberTrackingNumberUserData(UInt32 type, NSPoint location, UInt32 flags, double time, Int32 wNum, NSGraphicsContext context, Int32 eNum, Int32 tNum, IntPtr data)
		{
			return ms_class.Call("enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:", type, location, flags, time, wNum, context, eNum, tNum, data).To<NSEvent>();
		}

		public static NSEvent otherEventWithTypeLocationModifierFlagsTimestampWindowNumberContextSubtypeData1Data2(UInt32 type, NSPoint location, UInt32 flags, double time, Int32 wNum, NSGraphicsContext context, UInt32 subtype, Int32 d1, Int32 d2)
		{
			return ms_class.Call("otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:", type, location, flags, time, wNum, context, subtype, d1, d2).To<NSEvent>();
		}

		public static NSPoint mouseLocation()
		{
			return ms_class.Call("mouseLocation").To<NSPoint>();
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

		private static Class ms_class = new Class("NSEvent");
	}
}
