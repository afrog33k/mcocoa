// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSAnyType = 0;
		public const int NSIntType = 1;
		public const int NSPositiveIntType = 2;
		public const int NSFloatType = 3;
		public const int NSPositiveFloatType = 4;
		public const int NSDoubleType = 6;
		public const int NSPositiveDoubleType = 7;
	}

	public partial class Enums
	{
		public const int NSNullCellType = 0;
		public const int NSTextCellType = 1;
		public const int NSImageCellType = 2;
	}

	public partial class Enums
	{
		public const int NSCellDisabled = 0;
		public const int NSCellState = 1;
		public const int NSPushInCell = 2;
		public const int NSCellEditable = 3;
		public const int NSChangeGrayCell = 4;
		public const int NSCellHighlighted = 5;
		public const int NSCellLightsByContents = 6;
		public const int NSCellLightsByGray = 7;
		public const int NSChangeBackgroundCell = 8;
		public const int NSCellLightsByBackground = 9;
		public const int NSCellIsBordered = 10;
		public const int NSCellHasOverlappingImage = 11;
		public const int NSCellHasImageHorizontal = 12;
		public const int NSCellHasImageOnLeftOrBottom = 13;
		public const int NSCellChangesContents = 14;
		public const int NSCellIsInsetButton = 15;
		public const int NSCellAllowsMixedState = 16;
	}

	public partial class Enums
	{
		public const int NSNoImage = 0;
		public const int NSImageOnly = 1;
		public const int NSImageLeft = 2;
		public const int NSImageRight = 3;
		public const int NSImageBelow = 4;
		public const int NSImageAbove = 5;
		public const int NSImageOverlaps = 6;
	}

	public partial class Enums
	{
		public const int NSScaleProportionally = 0;
		public const int NSScaleToFit = 1;
		public const int NSScaleNone = 2;
	}

	public partial class Enums
	{
		public const int NSImageScaleProportionallyDown = 0;
		public const int NSImageScaleAxesIndependently = 1;
		public const int NSImageScaleNone = 2;
		public const int NSImageScaleProportionallyUpOrDown = 3;
	}

	public partial class Enums
	{
		public const int NSMixedState = -1;
		public const int NSOffState = 0;
		public const int NSOnState = 1;
	}

	public partial class Enums
	{
		public const int NSNoCellMask = 0;
		public const int NSContentsCellMask = 1;
		public const int NSPushInCellMask = 2;
		public const int NSChangeGrayCellMask = 4;
		public const int NSChangeBackgroundCellMask = 8;
	}

	public partial class Enums
	{
		public const int NSDefaultControlTint = 0;
		public const int NSBlueControlTint = 1;
		public const int NSGraphiteControlTint = 6;
		public const int NSClearControlTint = 7;
	}

	public partial class Enums
	{
		public const int NSRegularControlSize = 0;
		public const int NSSmallControlSize = 1;
		public const int NSMiniControlSize = 2;
	}

	public partial class Enums
	{
		public const int NSCellHitNone = 0;
		public const int NSCellHitContentArea = 1 << 0;
		public const int NSCellHitEditableTextArea = 1 << 1;
		public const int NSCellHitTrackableArea = 1 << 2;
	}

	public partial class Enums
	{
		public const int NSBackgroundStyleLight = 0;
		public const int NSBackgroundStyleDark = 1;
		public const int NSBackgroundStyleRaised = 2;
		public const int NSBackgroundStyleLowered = 3;
	}

	[Register]
	public partial class NSCell : NSObject
	{
		public NSCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCell(IntPtr instance) : base(instance)
		{
		}

		public NSCell(Untyped instance) : base(instance)
		{
		}

		public static new NSCell alloc()
		{
			return new NSCell(ms_class.Call("alloc"));
		}

		public new NSCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static bool prefersTrackingUntilMouseUp()
		{
			return ms_class.Call("prefersTrackingUntilMouseUp").To<bool>();
		}

		public NSObject initTextCell(NSString aString)
		{
			return Call("initTextCell:", aString).To<NSObject>();
		}

		public NSObject initImageCell(NSImage image)
		{
			return Call("initImageCell:", image).To<NSObject>();
		}

		public NSView controlView()
		{
			return Call("controlView").To<NSView>();
		}

		public void setControlView(NSView view)
		{
			Unused.Value = Call("setControlView:", view);
		}

		public UInt32 type()
		{
			return Call("type").To<UInt32>();
		}

		public void setType(UInt32 aType)
		{
			Unused.Value = Call("setType:", aType);
		}

		public Int32 state()
		{
			return Call("state").To<Int32>();
		}

		public void setState(Int32 value)
		{
			Unused.Value = Call("setState:", value);
		}

		public NSObject target()
		{
			return Call("target").To<NSObject>();
		}

		public void setTarget(NSObject anObject)
		{
			Unused.Value = Call("setTarget:", anObject);
		}

		public Selector action()
		{
			return Call("action").To<Selector>();
		}

		public void setAction(Selector aSelector)
		{
			Unused.Value = Call("setAction:", aSelector);
		}

		public Int32 tag()
		{
			return Call("tag").To<Int32>();
		}

		public void setTag(Int32 anInt)
		{
			Unused.Value = Call("setTag:", anInt);
		}

		public NSString title()
		{
			return Call("title").To<NSString>();
		}

		public void setTitle(NSString aString)
		{
			Unused.Value = Call("setTitle:", aString);
		}

		public bool isOpaque()
		{
			return Call("isOpaque").To<bool>();
		}

		public bool isEnabled()
		{
			return Call("isEnabled").To<bool>();
		}

		public void setEnabled(bool flag)
		{
			Unused.Value = Call("setEnabled:", flag);
		}

		public Int32 sendActionOn(Int32 mask)
		{
			return Call("sendActionOn:", mask).To<Int32>();
		}

		public bool isContinuous()
		{
			return Call("isContinuous").To<bool>();
		}

		public void setContinuous(bool flag)
		{
			Unused.Value = Call("setContinuous:", flag);
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public void setEditable(bool flag)
		{
			Unused.Value = Call("setEditable:", flag);
		}

		public bool isSelectable()
		{
			return Call("isSelectable").To<bool>();
		}

		public void setSelectable(bool flag)
		{
			Unused.Value = Call("setSelectable:", flag);
		}

		public bool isBordered()
		{
			return Call("isBordered").To<bool>();
		}

		public void setBordered(bool flag)
		{
			Unused.Value = Call("setBordered:", flag);
		}

		public bool isBezeled()
		{
			return Call("isBezeled").To<bool>();
		}

		public void setBezeled(bool flag)
		{
			Unused.Value = Call("setBezeled:", flag);
		}

		public bool isScrollable()
		{
			return Call("isScrollable").To<bool>();
		}

		public void setScrollable(bool flag)
		{
			Unused.Value = Call("setScrollable:", flag);
		}

		public bool isHighlighted()
		{
			return Call("isHighlighted").To<bool>();
		}

		public void setHighlighted(bool flag)
		{
			Unused.Value = Call("setHighlighted:", flag);
		}

		public UInt32 alignment()
		{
			return Call("alignment").To<UInt32>();
		}

		public void setAlignment(UInt32 mode)
		{
			Unused.Value = Call("setAlignment:", mode);
		}

		public bool wraps()
		{
			return Call("wraps").To<bool>();
		}

		public void setWraps(bool flag)
		{
			Unused.Value = Call("setWraps:", flag);
		}

		public NSFont font()
		{
			return Call("font").To<NSFont>();
		}

		public void setFont(NSFont fontObj)
		{
			Unused.Value = Call("setFont:", fontObj);
		}

		public Int32 entryType()
		{
			return Call("entryType").To<Int32>();
		}

		public void setEntryType(Int32 aType)
		{
			Unused.Value = Call("setEntryType:", aType);
		}

		public bool isEntryAcceptable(NSString aString)
		{
			return Call("isEntryAcceptable:", aString).To<bool>();
		}

		public void setFloatingPointFormatLeftRight(bool autoRange, UInt32 leftDigits, UInt32 rightDigits)
		{
			Unused.Value = Call("setFloatingPointFormat:left:right:", autoRange, leftDigits, rightDigits);
		}

		public NSString keyEquivalent()
		{
			return Call("keyEquivalent").To<NSString>();
		}

		public void setFormatter(NSFormatter newFormatter)
		{
			Unused.Value = Call("setFormatter:", newFormatter);
		}

		public NSObject formatter()
		{
			return Call("formatter").To<NSObject>();
		}

		public NSObject objectValue()
		{
			return Call("objectValue").To<NSObject>();
		}

		public void setObjectValue(NSObject obj)
		{
			Unused.Value = Call("setObjectValue:", obj);
		}

		public bool hasValidObjectValue()
		{
			return Call("hasValidObjectValue").To<bool>();
		}

		public NSString stringValue()
		{
			return Call("stringValue").To<NSString>();
		}

		public void setStringValue(NSString aString)
		{
			Unused.Value = Call("setStringValue:", aString);
		}

		public Int32 compare(NSObject otherCell)
		{
			return Call("compare:", otherCell).To<Int32>();
		}

		public UInt32 intValue()
		{
			return Call("intValue").To<UInt32>();
		}

		public void setIntValue(UInt32 anInt)
		{
			Unused.Value = Call("setIntValue:", anInt);
		}

		public float floatValue()
		{
			return Call("floatValue").To<float>();
		}

		public void setFloatValue(float aFloat)
		{
			Unused.Value = Call("setFloatValue:", aFloat);
		}

		public double doubleValue()
		{
			return Call("doubleValue").To<double>();
		}

		public void setDoubleValue(double aDouble)
		{
			Unused.Value = Call("setDoubleValue:", aDouble);
		}

		public void takeIntValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeIntValueFrom:", sender);
		}

		public void takeFloatValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeFloatValueFrom:", sender);
		}

		public void takeDoubleValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeDoubleValueFrom:", sender);
		}

		public void takeStringValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeStringValueFrom:", sender);
		}

		public void takeObjectValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeObjectValueFrom:", sender);
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public void setImage(NSImage image)
		{
			Unused.Value = Call("setImage:", image);
		}

		public void setControlTint(UInt32 controlTint)
		{
			Unused.Value = Call("setControlTint:", controlTint);
		}

		public UInt32 controlTint()
		{
			return Call("controlTint").To<UInt32>();
		}

		public void setControlSize(UInt32 size)
		{
			Unused.Value = Call("setControlSize:", size);
		}

		public UInt32 controlSize()
		{
			return Call("controlSize").To<UInt32>();
		}

		public NSObject representedObject()
		{
			return Call("representedObject").To<NSObject>();
		}

		public void setRepresentedObject(NSObject anObject)
		{
			Unused.Value = Call("setRepresentedObject:", anObject);
		}

		public Int32 cellAttribute(UInt32 aParameter)
		{
			return Call("cellAttribute:", aParameter).To<Int32>();
		}

		public void setCellAttributeTo(UInt32 aParameter, Int32 value)
		{
			Unused.Value = Call("setCellAttribute:to:", aParameter, value);
		}

		public NSRect imageRectForBounds(NSRect theRect)
		{
			return Call("imageRectForBounds:", theRect).To<NSRect>();
		}

		public NSRect titleRectForBounds(NSRect theRect)
		{
			return Call("titleRectForBounds:", theRect).To<NSRect>();
		}

		public NSRect drawingRectForBounds(NSRect theRect)
		{
			return Call("drawingRectForBounds:", theRect).To<NSRect>();
		}

		public NSSize cellSize()
		{
			return Call("cellSize").To<NSSize>();
		}

		public NSSize cellSizeForBounds(NSRect aRect)
		{
			return Call("cellSizeForBounds:", aRect).To<NSSize>();
		}

		public NSColor highlightColorWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			return Call("highlightColorWithFrame:inView:", cellFrame, controlView).To<NSColor>();
		}

		public void calcDrawInfo(NSRect aRect)
		{
			Unused.Value = Call("calcDrawInfo:", aRect);
		}

		public NSText setUpFieldEditorAttributes(NSText textObj)
		{
			return Call("setUpFieldEditorAttributes:", textObj).To<NSText>();
		}

		public void drawInteriorWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("drawInteriorWithFrame:inView:", cellFrame, controlView);
		}

		public void drawWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("drawWithFrame:inView:", cellFrame, controlView);
		}

		public void highlightWithFrameInView(bool flag, NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("highlight:withFrame:inView:", flag, cellFrame, controlView);
		}

		public Int32 mouseDownFlags()
		{
			return Call("mouseDownFlags").To<Int32>();
		}

		public void getPeriodicDelayInterval(IntPtr delay, IntPtr interval)
		{
			Unused.Value = Call("getPeriodicDelay:interval:", delay, interval);
		}

		public bool startTrackingAtInView(NSPoint startPoint, NSView controlView)
		{
			return Call("startTrackingAt:inView:", startPoint, controlView).To<bool>();
		}

		public bool continueTrackingAtInView(NSPoint lastPoint, NSPoint currentPoint, NSView controlView)
		{
			return Call("continueTracking:at:inView:", lastPoint, currentPoint, controlView).To<bool>();
		}

		public void stopTrackingAtInViewMouseIsUp(NSPoint lastPoint, NSPoint stopPoint, NSView controlView, bool flag)
		{
			Unused.Value = Call("stopTracking:at:inView:mouseIsUp:", lastPoint, stopPoint, controlView, flag);
		}

		public bool trackMouseInRectOfViewUntilMouseUp(NSEvent theEvent, NSRect cellFrame, NSView controlView, bool flag)
		{
			return Call("trackMouse:inRect:ofView:untilMouseUp:", theEvent, cellFrame, controlView, flag).To<bool>();
		}

		public void editWithFrameInViewEditorDelegateEvent(NSRect aRect, NSView controlView, NSText textObj, NSObject anObject, NSEvent theEvent)
		{
			Unused.Value = Call("editWithFrame:inView:editor:delegate:event:", aRect, controlView, textObj, anObject, theEvent);
		}

		public void selectWithFrameInViewEditorDelegateStartLength(NSRect aRect, NSView controlView, NSText textObj, NSObject anObject, Int32 selStart, Int32 selLength)
		{
			Unused.Value = Call("selectWithFrame:inView:editor:delegate:start:length:", aRect, controlView, textObj, anObject, selStart, selLength);
		}

		public void endEditing(NSText textObj)
		{
			Unused.Value = Call("endEditing:", textObj);
		}

		public void resetCursorRectInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("resetCursorRect:inView:", cellFrame, controlView);
		}

		public void setMenu(NSMenu aMenu)
		{
			Unused.Value = Call("setMenu:", aMenu);
		}

		public NSMenu menu()
		{
			return Call("menu").To<NSMenu>();
		}

		public NSMenu menuForEventInRectOfView(NSEvent event_, NSRect cellFrame, NSView view)
		{
			return Call("menuForEvent:inRect:ofView:", event_, cellFrame, view).To<NSMenu>();
		}

		public static NSMenu defaultMenu()
		{
			return ms_class.Call("defaultMenu").To<NSMenu>();
		}

		public void setSendsActionOnEndEditing(bool flag)
		{
			Unused.Value = Call("setSendsActionOnEndEditing:", flag);
		}

		public bool sendsActionOnEndEditing()
		{
			return Call("sendsActionOnEndEditing").To<bool>();
		}

		public Int32 baseWritingDirection()
		{
			return Call("baseWritingDirection").To<Int32>();
		}

		public void setBaseWritingDirection(Int32 writingDirection)
		{
			Unused.Value = Call("setBaseWritingDirection:", writingDirection);
		}

		public void setLineBreakMode(UInt32 mode)
		{
			Unused.Value = Call("setLineBreakMode:", mode);
		}

		public UInt32 lineBreakMode()
		{
			return Call("lineBreakMode").To<UInt32>();
		}

		public void setAllowsUndo(bool allowsUndo)
		{
			Unused.Value = Call("setAllowsUndo:", allowsUndo);
		}

		public bool allowsUndo()
		{
			return Call("allowsUndo").To<bool>();
		}

		public Int32 integerValue()
		{
			return Call("integerValue").To<Int32>();
		}

		public void setIntegerValue(Int32 anInteger)
		{
			Unused.Value = Call("setIntegerValue:", anInteger);
		}

		public void takeIntegerValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeIntegerValueFrom:", sender);
		}

		public bool truncatesLastVisibleLineAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("truncatesLastVisibleLineAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<bool>();
		}

		public void setTruncatesLastVisibleLineAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(bool flag)
		{
			Unused.Value = Call("setTruncatesLastVisibleLine:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", flag);
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

		private static Class ms_class = new Class("NSCell");
	}

	public static class NSKeyboardUIForNSCellCategory
	{
		public static void setRefusesFirstResponder(this NSCell _instance, bool flag)
		{
			Unused.Value = _instance.Call("setRefusesFirstResponder:", flag);
		}

		public static bool refusesFirstResponder(this NSCell _instance)
		{
			return _instance.Call("refusesFirstResponder").To<bool>();
		}

		public static bool acceptsFirstResponder(this NSCell _instance)
		{
			return _instance.Call("acceptsFirstResponder").To<bool>();
		}

		public static void setShowsFirstResponder(this NSCell _instance, bool showFR)
		{
			Unused.Value = _instance.Call("setShowsFirstResponder:", showFR);
		}

		public static bool showsFirstResponder(this NSCell _instance)
		{
			return _instance.Call("showsFirstResponder").To<bool>();
		}

		public static void setMnemonicLocation(this NSCell _instance, UInt32 location)
		{
			Unused.Value = _instance.Call("setMnemonicLocation:", location);
		}

		public static UInt32 mnemonicLocation(this NSCell _instance)
		{
			return _instance.Call("mnemonicLocation").To<UInt32>();
		}

		public static NSString mnemonic(this NSCell _instance)
		{
			return _instance.Call("mnemonic").To<NSString>();
		}

		public static void setTitleWithMnemonic(this NSCell _instance, NSString stringWithAmpersand)
		{
			Unused.Value = _instance.Call("setTitleWithMnemonic:", stringWithAmpersand);
		}

		public static void performClick(this NSCell _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("performClick:", sender);
		}

		public static void setFocusRingType(this NSCell _instance, UInt32 focusRingType)
		{
			Unused.Value = _instance.Call("setFocusRingType:", focusRingType);
		}

		public static UInt32 focusRingType(this NSCell _instance)
		{
			return _instance.Call("focusRingType").To<UInt32>();
		}

		public static UInt32 defaultFocusRingType(this NSCell _instance)
		{
			return _instance.Call("defaultFocusRingType").To<UInt32>();
		}

		public static bool wantsNotificationForMarkedText(this NSCell _instance)
		{
			return _instance.Call("wantsNotificationForMarkedText").To<bool>();
		}
	}

	public static class NSCellAttributedStringMethodsForNSCellCategory
	{
		public static NSAttributedString attributedStringValue(this NSCell _instance)
		{
			return _instance.Call("attributedStringValue").To<NSAttributedString>();
		}

		public static void setAttributedStringValue(this NSCell _instance, NSAttributedString obj)
		{
			Unused.Value = _instance.Call("setAttributedStringValue:", obj);
		}

		public static bool allowsEditingTextAttributes(this NSCell _instance)
		{
			return _instance.Call("allowsEditingTextAttributes").To<bool>();
		}

		public static void setAllowsEditingTextAttributes(this NSCell _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAllowsEditingTextAttributes:", flag);
		}

		public static bool importsGraphics(this NSCell _instance)
		{
			return _instance.Call("importsGraphics").To<bool>();
		}

		public static void setImportsGraphics(this NSCell _instance, bool flag)
		{
			Unused.Value = _instance.Call("setImportsGraphics:", flag);
		}
	}

	public static class NSCellMixedStateForNSCellCategory
	{
		public static void setAllowsMixedState(this NSCell _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAllowsMixedState:", flag);
		}

		public static bool allowsMixedState(this NSCell _instance)
		{
			return _instance.Call("allowsMixedState").To<bool>();
		}

		public static Int32 nextState(this NSCell _instance)
		{
			return _instance.Call("nextState").To<Int32>();
		}

		public static void setNextState(this NSCell _instance)
		{
			Unused.Value = _instance.Call("setNextState");
		}
	}

	public static class NSCellHitTestForNSCellCategory
	{
		public static UInt32 hitTestForEventInRectOfView(this NSCell _instance, NSEvent event_, NSRect cellFrame, NSView controlView)
		{
			return _instance.Call("hitTestForEvent:inRect:ofView:", event_, cellFrame, controlView).To<UInt32>();
		}
	}

	public static class NSCellExpansionForNSCellCategory
	{
		public static NSRect expansionFrameWithFrameInView(this NSCell _instance, NSRect cellFrame, NSView view)
		{
			return _instance.Call("expansionFrameWithFrame:inView:", cellFrame, view).To<NSRect>();
		}

		public static void drawWithExpansionFrameInView(this NSCell _instance, NSRect cellFrame, NSView view)
		{
			Unused.Value = _instance.Call("drawWithExpansionFrame:inView:", cellFrame, view);
		}
	}

	public static class NSCellBackgroundStyleForNSCellCategory
	{
		public static Int32 backgroundStyle(this NSCell _instance)
		{
			return _instance.Call("backgroundStyle").To<Int32>();
		}

		public static void setBackgroundStyle(this NSCell _instance, Int32 style)
		{
			Unused.Value = _instance.Call("setBackgroundStyle:", style);
		}

		public static Int32 interiorBackgroundStyle(this NSCell _instance)
		{
			return _instance.Call("interiorBackgroundStyle").To<Int32>();
		}
	}
}
