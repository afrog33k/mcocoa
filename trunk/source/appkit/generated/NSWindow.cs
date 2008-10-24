// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSWindow.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSBorderlessWindowMask = 0;
		public const int NSTitledWindowMask = 1 << 0;
		public const int NSClosableWindowMask = 1 << 1;
		public const int NSMiniaturizableWindowMask = 1 << 2;
		public const int NSResizableWindowMask = 1 << 3;
	}

	public partial class Enums
	{
		public const int NSTexturedBackgroundWindowMask = 1 << 8;
	}

	public partial class Enums
	{
		public const int NSUnscaledWindowMask = 1 << 11;
	}

	public partial class Enums
	{
		public const int NSUnifiedTitleAndToolbarWindowMask = 1 << 12;
	}

	public partial class Enums
	{
		public const int NSDisplayWindowRunLoopOrdering = 600000;
		public const int NSResetCursorRectsRunLoopOrdering = 700000;
	}

	public partial class Enums
	{
		public const int NSWindowSharingNone = 0;
		public const int NSWindowSharingReadOnly = 1;
		public const int NSWindowSharingReadWrite = 2;
	}

	public partial class Enums
	{
		public const int NSWindowBackingLocationDefault = 0;
		public const int NSWindowBackingLocationVideoMemory = 1;
		public const int NSWindowBackingLocationMainMemory = 2;
	}

	public partial class Enums
	{
		public const int NSWindowCollectionBehaviorDefault = 0;
		public const int NSWindowCollectionBehaviorCanJoinAllSpaces = 1 << 0;
		public const int NSWindowCollectionBehaviorMoveToActiveSpace = 1 << 1;
	}

	public partial class Enums
	{
		public const int NSDirectSelection = 0;
		public const int NSSelectingNext = 1;
		public const int NSSelectingPrevious = 2;
	}

	public partial class Enums
	{
		public const int NSWindowCloseButton = 0;
		public const int NSWindowMiniaturizeButton = 1;
		public const int NSWindowZoomButton = 2;
		public const int NSWindowToolbarButton = 3;
		public const int NSWindowDocumentIconButton = 4;
	}

	[Register]
	public partial class NSWindow : NSResponder
	{
		public NSWindow() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSWindow(IntPtr instance) : base(instance)
		{
		}

		public NSWindow(Untyped instance) : base(instance)
		{
		}

		public static new NSWindow alloc()
		{
			return new NSWindow(ms_class.Call("alloc"));
		}

		public new NSWindow retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSRect frameRectForContentRectStyleMask(NSRect cRect, UInt32 aStyle)
		{
			return ms_class.Call("frameRectForContentRect:styleMask:", cRect, aStyle).To<NSRect>();
		}

		public static NSRect contentRectForFrameRectStyleMask(NSRect fRect, UInt32 aStyle)
		{
			return ms_class.Call("contentRectForFrameRect:styleMask:", fRect, aStyle).To<NSRect>();
		}

		public static float minFrameWidthWithTitleStyleMask(NSString aTitle, UInt32 aStyle)
		{
			return ms_class.Call("minFrameWidthWithTitle:styleMask:", aTitle, aStyle).To<float>();
		}

		public static Int32 defaultDepthLimit()
		{
			return ms_class.Call("defaultDepthLimit").To<Int32>();
		}

		public NSRect frameRectForContentRect(NSRect contentRect)
		{
			return Call("frameRectForContentRect:", contentRect).To<NSRect>();
		}

		public NSRect contentRectForFrameRect(NSRect frameRect)
		{
			return Call("contentRectForFrameRect:", frameRect).To<NSRect>();
		}

		public NSObject initWithContentRectStyleMaskBackingDefer(NSRect contentRect, UInt32 aStyle, UInt32 bufferingType, bool flag)
		{
			return Call("initWithContentRect:styleMask:backing:defer:", contentRect, aStyle, bufferingType, flag).To<NSObject>();
		}

		public NSObject initWithContentRectStyleMaskBackingDeferScreen(NSRect contentRect, UInt32 aStyle, UInt32 bufferingType, bool flag, NSScreen screen)
		{
			return Call("initWithContentRect:styleMask:backing:defer:screen:", contentRect, aStyle, bufferingType, flag, screen).To<NSObject>();
		}

		public NSString title()
		{
			return Call("title").To<NSString>();
		}

		public void setTitle(NSString aString)
		{
			Unused.Value = Call("setTitle:", aString);
		}

		public void setRepresentedURL(NSURL url)
		{
			Unused.Value = Call("setRepresentedURL:", url);
		}

		public NSURL representedURL()
		{
			return Call("representedURL").To<NSURL>();
		}

		public NSString representedFilename()
		{
			return Call("representedFilename").To<NSString>();
		}

		public void setRepresentedFilename(NSString aString)
		{
			Unused.Value = Call("setRepresentedFilename:", aString);
		}

		public void setTitleWithRepresentedFilename(NSString filename)
		{
			Unused.Value = Call("setTitleWithRepresentedFilename:", filename);
		}

		public void setExcludedFromWindowsMenu(bool flag)
		{
			Unused.Value = Call("setExcludedFromWindowsMenu:", flag);
		}

		public bool isExcludedFromWindowsMenu()
		{
			return Call("isExcludedFromWindowsMenu").To<bool>();
		}

		public void setContentView(NSView aView)
		{
			Unused.Value = Call("setContentView:", aView);
		}

		public NSObject contentView()
		{
			return Call("contentView").To<NSObject>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public Int32 windowNumber()
		{
			return Call("windowNumber").To<Int32>();
		}

		public UInt32 styleMask()
		{
			return Call("styleMask").To<UInt32>();
		}

		public NSText fieldEditorForObject(bool createFlag, NSObject anObject)
		{
			return Call("fieldEditor:forObject:", createFlag, anObject).To<NSText>();
		}

		public void endEditingFor(NSObject anObject)
		{
			Unused.Value = Call("endEditingFor:", anObject);
		}

		public NSRect constrainFrameRectToScreen(NSRect frameRect, NSScreen screen)
		{
			return Call("constrainFrameRect:toScreen:", frameRect, screen).To<NSRect>();
		}

		public void setFrameDisplay(NSRect frameRect, bool flag)
		{
			Unused.Value = Call("setFrame:display:", frameRect, flag);
		}

		public void setContentSize(NSSize aSize)
		{
			Unused.Value = Call("setContentSize:", aSize);
		}

		public void setFrameOrigin(NSPoint aPoint)
		{
			Unused.Value = Call("setFrameOrigin:", aPoint);
		}

		public void setFrameTopLeftPoint(NSPoint aPoint)
		{
			Unused.Value = Call("setFrameTopLeftPoint:", aPoint);
		}

		public NSPoint cascadeTopLeftFromPoint(NSPoint topLeftPoint)
		{
			return Call("cascadeTopLeftFromPoint:", topLeftPoint).To<NSPoint>();
		}

		public NSRect frame()
		{
			return Call("frame").To<NSRect>();
		}

		public double animationResizeTime(NSRect newFrame)
		{
			return Call("animationResizeTime:", newFrame).To<double>();
		}

		public void setFrameDisplayAnimate(NSRect frameRect, bool displayFlag, bool animateFlag)
		{
			Unused.Value = Call("setFrame:display:animate:", frameRect, displayFlag, animateFlag);
		}

		public void setShowsResizeIndicator(bool show)
		{
			Unused.Value = Call("setShowsResizeIndicator:", show);
		}

		public bool showsResizeIndicator()
		{
			return Call("showsResizeIndicator").To<bool>();
		}

		public void setResizeIncrements(NSSize increments)
		{
			Unused.Value = Call("setResizeIncrements:", increments);
		}

		public NSSize resizeIncrements()
		{
			return Call("resizeIncrements").To<NSSize>();
		}

		public void setAspectRatio(NSSize ratio)
		{
			Unused.Value = Call("setAspectRatio:", ratio);
		}

		public NSSize aspectRatio()
		{
			return Call("aspectRatio").To<NSSize>();
		}

		public void setContentResizeIncrements(NSSize increments)
		{
			Unused.Value = Call("setContentResizeIncrements:", increments);
		}

		public NSSize contentResizeIncrements()
		{
			return Call("contentResizeIncrements").To<NSSize>();
		}

		public void setContentAspectRatio(NSSize ratio)
		{
			Unused.Value = Call("setContentAspectRatio:", ratio);
		}

		public NSSize contentAspectRatio()
		{
			return Call("contentAspectRatio").To<NSSize>();
		}

		public void useOptimizedDrawing(bool flag)
		{
			Unused.Value = Call("useOptimizedDrawing:", flag);
		}

		public void disableFlushWindow()
		{
			Unused.Value = Call("disableFlushWindow");
		}

		public void enableFlushWindow()
		{
			Unused.Value = Call("enableFlushWindow");
		}

		public bool isFlushWindowDisabled()
		{
			return Call("isFlushWindowDisabled").To<bool>();
		}

		public void flushWindow()
		{
			Unused.Value = Call("flushWindow");
		}

		public void flushWindowIfNeeded()
		{
			Unused.Value = Call("flushWindowIfNeeded");
		}

		public void setViewsNeedDisplay(bool flag)
		{
			Unused.Value = Call("setViewsNeedDisplay:", flag);
		}

		public bool viewsNeedDisplay()
		{
			return Call("viewsNeedDisplay").To<bool>();
		}

		public void displayIfNeeded()
		{
			Unused.Value = Call("displayIfNeeded");
		}

		public void display()
		{
			Unused.Value = Call("display");
		}

		public void setAutodisplay(bool flag)
		{
			Unused.Value = Call("setAutodisplay:", flag);
		}

		public bool isAutodisplay()
		{
			return Call("isAutodisplay").To<bool>();
		}

		public bool preservesContentDuringLiveResize()
		{
			return Call("preservesContentDuringLiveResize").To<bool>();
		}

		public void setPreservesContentDuringLiveResize(bool flag)
		{
			Unused.Value = Call("setPreservesContentDuringLiveResize:", flag);
		}

		public void update()
		{
			Unused.Value = Call("update");
		}

		public bool makeFirstResponder(NSResponder aResponder)
		{
			return Call("makeFirstResponder:", aResponder).To<bool>();
		}

		public NSResponder firstResponder()
		{
			return Call("firstResponder").To<NSResponder>();
		}

		public Int32 resizeFlags()
		{
			return Call("resizeFlags").To<Int32>();
		}

		// skipping keyDown: (it's declared in a base class)

		public void close()
		{
			Unused.Value = Call("close");
		}

		public void setReleasedWhenClosed(bool flag)
		{
			Unused.Value = Call("setReleasedWhenClosed:", flag);
		}

		public bool isReleasedWhenClosed()
		{
			return Call("isReleasedWhenClosed").To<bool>();
		}

		public void miniaturize(NSObject sender)
		{
			Unused.Value = Call("miniaturize:", sender);
		}

		public void deminiaturize(NSObject sender)
		{
			Unused.Value = Call("deminiaturize:", sender);
		}

		public bool isZoomed()
		{
			return Call("isZoomed").To<bool>();
		}

		public void zoom(NSObject sender)
		{
			Unused.Value = Call("zoom:", sender);
		}

		public bool isMiniaturized()
		{
			return Call("isMiniaturized").To<bool>();
		}

		// skipping tryToPerform:with: (it's declared in a base class)

		// skipping validRequestorForSendType:returnType: (it's declared in a base class)

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setContentBorderThicknessForEdge(float thickness, UInt32 edge)
		{
			Unused.Value = Call("setContentBorderThickness:forEdge:", thickness, edge);
		}

		public float contentBorderThicknessForEdge(UInt32 edge)
		{
			return Call("contentBorderThicknessForEdge:", edge).To<float>();
		}

		public void setAutorecalculatesContentBorderThicknessForEdge(bool flag, UInt32 edge)
		{
			Unused.Value = Call("setAutorecalculatesContentBorderThickness:forEdge:", flag, edge);
		}

		public bool autorecalculatesContentBorderThicknessForEdge(UInt32 edge)
		{
			return Call("autorecalculatesContentBorderThicknessForEdge:", edge).To<bool>();
		}

		public void setMovableByWindowBackground(bool flag)
		{
			Unused.Value = Call("setMovableByWindowBackground:", flag);
		}

		public bool isMovableByWindowBackground()
		{
			return Call("isMovableByWindowBackground").To<bool>();
		}

		public void setHidesOnDeactivate(bool flag)
		{
			Unused.Value = Call("setHidesOnDeactivate:", flag);
		}

		public bool hidesOnDeactivate()
		{
			return Call("hidesOnDeactivate").To<bool>();
		}

		public void setCanHide(bool flag)
		{
			Unused.Value = Call("setCanHide:", flag);
		}

		public bool canHide()
		{
			return Call("canHide").To<bool>();
		}

		public void center()
		{
			Unused.Value = Call("center");
		}

		public void makeKeyAndOrderFront(NSObject sender)
		{
			Unused.Value = Call("makeKeyAndOrderFront:", sender);
		}

		public void orderFront(NSObject sender)
		{
			Unused.Value = Call("orderFront:", sender);
		}

		public void orderBack(NSObject sender)
		{
			Unused.Value = Call("orderBack:", sender);
		}

		public void orderOut(NSObject sender)
		{
			Unused.Value = Call("orderOut:", sender);
		}

		public void orderWindowRelativeTo(Int32 place, Int32 otherWin)
		{
			Unused.Value = Call("orderWindow:relativeTo:", place, otherWin);
		}

		public void orderFrontRegardless()
		{
			Unused.Value = Call("orderFrontRegardless");
		}

		public void setMiniwindowImage(NSImage image)
		{
			Unused.Value = Call("setMiniwindowImage:", image);
		}

		public void setMiniwindowTitle(NSString title)
		{
			Unused.Value = Call("setMiniwindowTitle:", title);
		}

		public NSImage miniwindowImage()
		{
			return Call("miniwindowImage").To<NSImage>();
		}

		public NSString miniwindowTitle()
		{
			return Call("miniwindowTitle").To<NSString>();
		}

		public NSDockTile dockTile()
		{
			return Call("dockTile").To<NSDockTile>();
		}

		public void setDocumentEdited(bool flag)
		{
			Unused.Value = Call("setDocumentEdited:", flag);
		}

		public bool isDocumentEdited()
		{
			return Call("isDocumentEdited").To<bool>();
		}

		public bool isVisible()
		{
			return Call("isVisible").To<bool>();
		}

		public bool isKeyWindow()
		{
			return Call("isKeyWindow").To<bool>();
		}

		public bool isMainWindow()
		{
			return Call("isMainWindow").To<bool>();
		}

		public bool canBecomeKeyWindow()
		{
			return Call("canBecomeKeyWindow").To<bool>();
		}

		public bool canBecomeMainWindow()
		{
			return Call("canBecomeMainWindow").To<bool>();
		}

		public void makeKeyWindow()
		{
			Unused.Value = Call("makeKeyWindow");
		}

		public void makeMainWindow()
		{
			Unused.Value = Call("makeMainWindow");
		}

		public void becomeKeyWindow()
		{
			Unused.Value = Call("becomeKeyWindow");
		}

		public void resignKeyWindow()
		{
			Unused.Value = Call("resignKeyWindow");
		}

		public void becomeMainWindow()
		{
			Unused.Value = Call("becomeMainWindow");
		}

		public void resignMainWindow()
		{
			Unused.Value = Call("resignMainWindow");
		}

		public bool worksWhenModal()
		{
			return Call("worksWhenModal").To<bool>();
		}

		public NSPoint convertBaseToScreen(NSPoint aPoint)
		{
			return Call("convertBaseToScreen:", aPoint).To<NSPoint>();
		}

		public NSPoint convertScreenToBase(NSPoint aPoint)
		{
			return Call("convertScreenToBase:", aPoint).To<NSPoint>();
		}

		public void performClose(NSObject sender)
		{
			Unused.Value = Call("performClose:", sender);
		}

		public void performMiniaturize(NSObject sender)
		{
			Unused.Value = Call("performMiniaturize:", sender);
		}

		public void performZoom(NSObject sender)
		{
			Unused.Value = Call("performZoom:", sender);
		}

		public Int32 gState()
		{
			return Call("gState").To<Int32>();
		}

		public void setOneShot(bool flag)
		{
			Unused.Value = Call("setOneShot:", flag);
		}

		public bool isOneShot()
		{
			return Call("isOneShot").To<bool>();
		}

		public NSData dataWithEPSInsideRect(NSRect rect)
		{
			return Call("dataWithEPSInsideRect:", rect).To<NSData>();
		}

		public NSData dataWithPDFInsideRect(NSRect rect)
		{
			return Call("dataWithPDFInsideRect:", rect).To<NSData>();
		}

		public void print(NSObject sender)
		{
			Unused.Value = Call("print:", sender);
		}

		public void disableCursorRects()
		{
			Unused.Value = Call("disableCursorRects");
		}

		public void enableCursorRects()
		{
			Unused.Value = Call("enableCursorRects");
		}

		public void discardCursorRects()
		{
			Unused.Value = Call("discardCursorRects");
		}

		public bool areCursorRectsEnabled()
		{
			return Call("areCursorRectsEnabled").To<bool>();
		}

		public void invalidateCursorRectsForView(NSView aView)
		{
			Unused.Value = Call("invalidateCursorRectsForView:", aView);
		}

		public void resetCursorRects()
		{
			Unused.Value = Call("resetCursorRects");
		}

		public void setAllowsToolTipsWhenApplicationIsInactive(bool allowWhenInactive)
		{
			Unused.Value = Call("setAllowsToolTipsWhenApplicationIsInactive:", allowWhenInactive);
		}

		public bool allowsToolTipsWhenApplicationIsInactive()
		{
			return Call("allowsToolTipsWhenApplicationIsInactive").To<bool>();
		}

		public void setBackingType(UInt32 bufferingType)
		{
			Unused.Value = Call("setBackingType:", bufferingType);
		}

		public UInt32 backingType()
		{
			return Call("backingType").To<UInt32>();
		}

		public void setLevel(Int32 newLevel)
		{
			Unused.Value = Call("setLevel:", newLevel);
		}

		public Int32 level()
		{
			return Call("level").To<Int32>();
		}

		public void setDepthLimit(Int32 limit)
		{
			Unused.Value = Call("setDepthLimit:", limit);
		}

		public Int32 depthLimit()
		{
			return Call("depthLimit").To<Int32>();
		}

		public void setDynamicDepthLimit(bool flag)
		{
			Unused.Value = Call("setDynamicDepthLimit:", flag);
		}

		public bool hasDynamicDepthLimit()
		{
			return Call("hasDynamicDepthLimit").To<bool>();
		}

		public NSScreen screen()
		{
			return Call("screen").To<NSScreen>();
		}

		public NSScreen deepestScreen()
		{
			return Call("deepestScreen").To<NSScreen>();
		}

		public bool canStoreColor()
		{
			return Call("canStoreColor").To<bool>();
		}

		public void setHasShadow(bool hasShadow)
		{
			Unused.Value = Call("setHasShadow:", hasShadow);
		}

		public bool hasShadow()
		{
			return Call("hasShadow").To<bool>();
		}

		public void invalidateShadow()
		{
			Unused.Value = Call("invalidateShadow");
		}

		public void setAlphaValue(float windowAlpha)
		{
			Unused.Value = Call("setAlphaValue:", windowAlpha);
		}

		public float alphaValue()
		{
			return Call("alphaValue").To<float>();
		}

		public void setOpaque(bool isOpaque)
		{
			Unused.Value = Call("setOpaque:", isOpaque);
		}

		public bool isOpaque()
		{
			return Call("isOpaque").To<bool>();
		}

		public void setSharingType(UInt32 type)
		{
			Unused.Value = Call("setSharingType:", type);
		}

		public UInt32 sharingType()
		{
			return Call("sharingType").To<UInt32>();
		}

		public void setPreferredBackingLocation(UInt32 backingLocation)
		{
			Unused.Value = Call("setPreferredBackingLocation:", backingLocation);
		}

		public UInt32 preferredBackingLocation()
		{
			return Call("preferredBackingLocation").To<UInt32>();
		}

		public UInt32 backingLocation()
		{
			return Call("backingLocation").To<UInt32>();
		}

		public bool displaysWhenScreenProfileChanges()
		{
			return Call("displaysWhenScreenProfileChanges").To<bool>();
		}

		public void setDisplaysWhenScreenProfileChanges(bool flag)
		{
			Unused.Value = Call("setDisplaysWhenScreenProfileChanges:", flag);
		}

		public void disableScreenUpdatesUntilFlush()
		{
			Unused.Value = Call("disableScreenUpdatesUntilFlush");
		}

		public bool canBecomeVisibleWithoutLogin()
		{
			return Call("canBecomeVisibleWithoutLogin").To<bool>();
		}

		public void setCanBecomeVisibleWithoutLogin(bool flag)
		{
			Unused.Value = Call("setCanBecomeVisibleWithoutLogin:", flag);
		}

		public void setCollectionBehavior(UInt32 behavior)
		{
			Unused.Value = Call("setCollectionBehavior:", behavior);
		}

		public UInt32 collectionBehavior()
		{
			return Call("collectionBehavior").To<UInt32>();
		}

		public bool canBeVisibleOnAllSpacesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER_BUT_DEPRECATED()
		{
			return Call("canBeVisibleOnAllSpacesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER_BUT_DEPRECATED").To<bool>();
		}

		public void setCanBeVisibleOnAllSpacesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER_BUT_DEPRECATED(bool flag)
		{
			Unused.Value = Call("setCanBeVisibleOnAllSpaces:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER_BUT_DEPRECATED", flag);
		}

		public NSString stringWithSavedFrame()
		{
			return Call("stringWithSavedFrame").To<NSString>();
		}

		public void setFrameFromString(NSString string_)
		{
			Unused.Value = Call("setFrameFromString:", string_);
		}

		public void saveFrameUsingName(NSString name)
		{
			Unused.Value = Call("saveFrameUsingName:", name);
		}

		public bool setFrameUsingNameForce(NSString name, bool force)
		{
			return Call("setFrameUsingName:force:", name, force).To<bool>();
		}

		public bool setFrameUsingName(NSString name)
		{
			return Call("setFrameUsingName:", name).To<bool>();
		}

		public bool setFrameAutosaveName(NSString name)
		{
			return Call("setFrameAutosaveName:", name).To<bool>();
		}

		public NSString frameAutosaveName()
		{
			return Call("frameAutosaveName").To<NSString>();
		}

		public static void removeFrameUsingName(NSString name)
		{
			Unused.Value = ms_class.Call("removeFrameUsingName:", name);
		}

		public void cacheImageInRect(NSRect aRect)
		{
			Unused.Value = Call("cacheImageInRect:", aRect);
		}

		public void restoreCachedImage()
		{
			Unused.Value = Call("restoreCachedImage");
		}

		public void discardCachedImage()
		{
			Unused.Value = Call("discardCachedImage");
		}

		public NSSize minSize()
		{
			return Call("minSize").To<NSSize>();
		}

		public NSSize maxSize()
		{
			return Call("maxSize").To<NSSize>();
		}

		public void setMinSize(NSSize size)
		{
			Unused.Value = Call("setMinSize:", size);
		}

		public void setMaxSize(NSSize size)
		{
			Unused.Value = Call("setMaxSize:", size);
		}

		public NSSize contentMinSize()
		{
			return Call("contentMinSize").To<NSSize>();
		}

		public NSSize contentMaxSize()
		{
			return Call("contentMaxSize").To<NSSize>();
		}

		public void setContentMinSize(NSSize size)
		{
			Unused.Value = Call("setContentMinSize:", size);
		}

		public void setContentMaxSize(NSSize size)
		{
			Unused.Value = Call("setContentMaxSize:", size);
		}

		public NSEvent nextEventMatchingMask(UInt32 mask)
		{
			return Call("nextEventMatchingMask:", mask).To<NSEvent>();
		}

		public NSEvent nextEventMatchingMaskUntilDateInModeDequeue(UInt32 mask, NSDate expiration, NSString mode, bool deqFlag)
		{
			return Call("nextEventMatchingMask:untilDate:inMode:dequeue:", mask, expiration, mode, deqFlag).To<NSEvent>();
		}

		public void discardEventsMatchingMaskBeforeEvent(UInt32 mask, NSEvent lastEvent)
		{
			Unused.Value = Call("discardEventsMatchingMask:beforeEvent:", mask, lastEvent);
		}

		public void postEventAtStart(NSEvent event_, bool flag)
		{
			Unused.Value = Call("postEvent:atStart:", event_, flag);
		}

		public NSEvent currentEvent()
		{
			return Call("currentEvent").To<NSEvent>();
		}

		public void setAcceptsMouseMovedEvents(bool flag)
		{
			Unused.Value = Call("setAcceptsMouseMovedEvents:", flag);
		}

		public bool acceptsMouseMovedEvents()
		{
			return Call("acceptsMouseMovedEvents").To<bool>();
		}

		public void setIgnoresMouseEvents(bool flag)
		{
			Unused.Value = Call("setIgnoresMouseEvents:", flag);
		}

		public bool ignoresMouseEvents()
		{
			return Call("ignoresMouseEvents").To<bool>();
		}

		public NSDictionary deviceDescription()
		{
			return Call("deviceDescription").To<NSDictionary>();
		}

		public void sendEvent(NSEvent theEvent)
		{
			Unused.Value = Call("sendEvent:", theEvent);
		}

		public NSPoint mouseLocationOutsideOfEventStream()
		{
			return Call("mouseLocationOutsideOfEventStream").To<NSPoint>();
		}

		public static void menuChanged(NSMenu menu)
		{
			Unused.Value = ms_class.Call("menuChanged:", menu);
		}

		public NSObject windowController()
		{
			return Call("windowController").To<NSObject>();
		}

		public void setWindowController(NSWindowController windowController)
		{
			Unused.Value = Call("setWindowController:", windowController);
		}

		public bool isSheet()
		{
			return Call("isSheet").To<bool>();
		}

		public NSWindow attachedSheet()
		{
			return Call("attachedSheet").To<NSWindow>();
		}

		public static NSButton standardWindowButtonForStyleMask(UInt32 b, UInt32 styleMask)
		{
			return ms_class.Call("standardWindowButton:forStyleMask:", b, styleMask).To<NSButton>();
		}

		public NSButton standardWindowButton(UInt32 b)
		{
			return Call("standardWindowButton:", b).To<NSButton>();
		}

		public void addChildWindowOrdered(NSWindow childWin, Int32 place)
		{
			Unused.Value = Call("addChildWindow:ordered:", childWin, place);
		}

		public void removeChildWindow(NSWindow childWin)
		{
			Unused.Value = Call("removeChildWindow:", childWin);
		}

		public NSArray childWindows()
		{
			return Call("childWindows").To<NSArray>();
		}

		public NSWindow parentWindow()
		{
			return Call("parentWindow").To<NSWindow>();
		}

		public void setParentWindow(NSWindow window)
		{
			Unused.Value = Call("setParentWindow:", window);
		}

		public NSGraphicsContext graphicsContext()
		{
			return Call("graphicsContext").To<NSGraphicsContext>();
		}

		public float userSpaceScaleFactor()
		{
			return Call("userSpaceScaleFactor").To<float>();
		}

		#region NSAnimatablePropertyContainer Methods
		public NSObject animator()
		{
			return Call("animator").To<NSObject>();
		}

		public NSDictionary animations()
		{
			return Call("animations").To<NSDictionary>();
		}

		public void setAnimations(NSDictionary dict)
		{
			Unused.Value = Call("setAnimations:", dict);
		}

		public NSObject animationForKey(NSString key)
		{
			return Call("animationForKey:", key).To<NSObject>();
		}

		public static NSObject defaultAnimationForKey(NSString key)
		{
			return ms_class.Call("defaultAnimationForKey:", key).To<NSObject>();
		}
		#endregion

		#region NSUserInterfaceValidations Methods
		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}
		#endregion

		private static Class ms_class = new Class("NSWindow");
	}

	public static class NSKeyboardUIForNSWindowCategory
	{
		public static void setInitialFirstResponder(this NSWindow _instance, NSView view)
		{
			Unused.Value = _instance.Call("setInitialFirstResponder:", view);
		}

		public static NSView initialFirstResponder(this NSWindow _instance)
		{
			return _instance.Call("initialFirstResponder").To<NSView>();
		}

		public static void selectNextKeyView(this NSWindow _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("selectNextKeyView:", sender);
		}

		public static void selectPreviousKeyView(this NSWindow _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("selectPreviousKeyView:", sender);
		}

		public static void selectKeyViewFollowingView(this NSWindow _instance, NSView aView)
		{
			Unused.Value = _instance.Call("selectKeyViewFollowingView:", aView);
		}

		public static void selectKeyViewPrecedingView(this NSWindow _instance, NSView aView)
		{
			Unused.Value = _instance.Call("selectKeyViewPrecedingView:", aView);
		}

		public static UInt32 keyViewSelectionDirection(this NSWindow _instance)
		{
			return _instance.Call("keyViewSelectionDirection").To<UInt32>();
		}

		public static void setDefaultButtonCell(this NSWindow _instance, NSButtonCell defButt)
		{
			Unused.Value = _instance.Call("setDefaultButtonCell:", defButt);
		}

		public static NSButtonCell defaultButtonCell(this NSWindow _instance)
		{
			return _instance.Call("defaultButtonCell").To<NSButtonCell>();
		}

		public static void disableKeyEquivalentForDefaultButtonCell(this NSWindow _instance)
		{
			Unused.Value = _instance.Call("disableKeyEquivalentForDefaultButtonCell");
		}

		public static void enableKeyEquivalentForDefaultButtonCell(this NSWindow _instance)
		{
			Unused.Value = _instance.Call("enableKeyEquivalentForDefaultButtonCell");
		}

		public static void setAutorecalculatesKeyViewLoop(this NSWindow _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAutorecalculatesKeyViewLoop:", flag);
		}

		public static bool autorecalculatesKeyViewLoop(this NSWindow _instance)
		{
			return _instance.Call("autorecalculatesKeyViewLoop").To<bool>();
		}

		public static void recalculateKeyViewLoop(this NSWindow _instance)
		{
			Unused.Value = _instance.Call("recalculateKeyViewLoop");
		}
	}

	public static class NSToolbarSupportForNSWindowCategory
	{
		public static void setToolbar(this NSWindow _instance, NSToolbar toolbar)
		{
			Unused.Value = _instance.Call("setToolbar:", toolbar);
		}

		public static NSToolbar toolbar(this NSWindow _instance)
		{
			return _instance.Call("toolbar").To<NSToolbar>();
		}

		public static void toggleToolbarShown(this NSWindow _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("toggleToolbarShown:", sender);
		}

		public static void runToolbarCustomizationPalette(this NSWindow _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("runToolbarCustomizationPalette:", sender);
		}

		public static void setShowsToolbarButton(this NSWindow _instance, bool show)
		{
			Unused.Value = _instance.Call("setShowsToolbarButton:", show);
		}

		public static bool showsToolbarButton(this NSWindow _instance)
		{
			return _instance.Call("showsToolbarButton").To<bool>();
		}
	}

	public static class NSDragForNSWindowCategory
	{
		public static void dragImageAtOffsetEventPasteboardSourceSlideBack(this NSWindow _instance, NSImage anImage, NSPoint baseLocation, NSSize initialOffset, NSEvent event_, NSPasteboard pboard, NSObject sourceObj, bool slideFlag)
		{
			Unused.Value = _instance.Call("dragImage:at:offset:event:pasteboard:source:slideBack:", anImage, baseLocation, initialOffset, event_, pboard, sourceObj, slideFlag);
		}

		public static void registerForDraggedTypes(this NSWindow _instance, NSArray newTypes)
		{
			Unused.Value = _instance.Call("registerForDraggedTypes:", newTypes);
		}

		public static void unregisterDraggedTypes(this NSWindow _instance)
		{
			Unused.Value = _instance.Call("unregisterDraggedTypes");
		}
	}

	public static class NSCarbonExtensionsForNSWindowCategory
	{
		public static NSWindow initWithWindowRef(this NSWindow _instance, IntPtr windowRef)
		{
			return _instance.Call("initWithWindowRef:", windowRef).To<NSWindow>();
		}

		public static IntPtr windowRef(this NSWindow _instance)
		{
			return _instance.Call("windowRef").To<IntPtr>();
		}
	}

	public static class NSWindowNotificationsForNSObjectCategory
	{
		public static void windowDidResize(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidResize:", notification);
		}

		public static void windowDidExpose(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidExpose:", notification);
		}

		public static void windowWillMove(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowWillMove:", notification);
		}

		public static void windowDidMove(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidMove:", notification);
		}

		public static void windowDidBecomeKey(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidBecomeKey:", notification);
		}

		public static void windowDidResignKey(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidResignKey:", notification);
		}

		public static void windowDidBecomeMain(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidBecomeMain:", notification);
		}

		public static void windowDidResignMain(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidResignMain:", notification);
		}

		public static void windowWillClose(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowWillClose:", notification);
		}

		public static void windowWillMiniaturize(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowWillMiniaturize:", notification);
		}

		public static void windowDidMiniaturize(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidMiniaturize:", notification);
		}

		public static void windowDidDeminiaturize(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidDeminiaturize:", notification);
		}

		public static void windowDidUpdate(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidUpdate:", notification);
		}

		public static void windowDidChangeScreen(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidChangeScreen:", notification);
		}

		public static void windowDidChangeScreenProfile(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidChangeScreenProfile:", notification);
		}

		public static void windowWillBeginSheet(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowWillBeginSheet:", notification);
		}

		public static void windowDidEndSheet(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("windowDidEndSheet:", notification);
		}
	}

	public static class NSWindowDelegateForNSObjectCategory
	{
		public static bool windowShouldClose(this NSObject _instance, NSObject sender)
		{
			return _instance.Call("windowShouldClose:", sender).To<bool>();
		}

		public static NSObject windowWillReturnFieldEditorToObject(this NSObject _instance, NSWindow sender, NSObject client)
		{
			return _instance.Call("windowWillReturnFieldEditor:toObject:", sender, client).To<NSObject>();
		}

		public static NSSize windowWillResizeToSize(this NSObject _instance, NSWindow sender, NSSize frameSize)
		{
			return _instance.Call("windowWillResize:toSize:", sender, frameSize).To<NSSize>();
		}

		public static NSRect windowWillUseStandardFrameDefaultFrame(this NSObject _instance, NSWindow window, NSRect newFrame)
		{
			return _instance.Call("windowWillUseStandardFrame:defaultFrame:", window, newFrame).To<NSRect>();
		}

		public static bool windowShouldZoomToFrame(this NSObject _instance, NSWindow window, NSRect newFrame)
		{
			return _instance.Call("windowShouldZoom:toFrame:", window, newFrame).To<bool>();
		}

		public static NSUndoManager windowWillReturnUndoManager(this NSObject _instance, NSWindow window)
		{
			return _instance.Call("windowWillReturnUndoManager:", window).To<NSUndoManager>();
		}

		public static NSRect windowWillPositionSheetUsingRect(this NSObject _instance, NSWindow window, NSWindow sheet, NSRect rect)
		{
			return _instance.Call("window:willPositionSheet:usingRect:", window, sheet, rect).To<NSRect>();
		}

		public static bool windowShouldPopUpDocumentPathMenu(this NSObject _instance, NSWindow window, NSMenu menu)
		{
			return _instance.Call("window:shouldPopUpDocumentPathMenu:", window, menu).To<bool>();
		}

		public static bool windowShouldDragDocumentWithEventFromWithPasteboard(this NSObject _instance, NSWindow window, NSEvent event_, NSPoint dragImageLocation, NSPasteboard pasteboard)
		{
			return _instance.Call("window:shouldDragDocumentWithEvent:from:withPasteboard:", window, event_, dragImageLocation, pasteboard).To<bool>();
		}
	}
}
