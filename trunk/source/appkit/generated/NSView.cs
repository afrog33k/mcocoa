// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSView.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSViewNotSizable = 0;
		public const int NSViewMinXMargin = 1;
		public const int NSViewWidthSizable = 2;
		public const int NSViewMaxXMargin = 4;
		public const int NSViewMinYMargin = 8;
		public const int NSViewHeightSizable = 16;
		public const int NSViewMaxYMargin = 32;
	}

	public partial class Enums
	{
		public const int NSNoBorder = 0;
		public const int NSLineBorder = 1;
		public const int NSBezelBorder = 2;
		public const int NSGrooveBorder = 3;
	}

	[Register]
	public partial class NSView : NSResponder
	{
		public NSView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSView(IntPtr instance) : base(instance)
		{
		}

		public NSView(Untyped instance) : base(instance)
		{
		}

		public static new NSView alloc()
		{
			return new NSView(ms_class.Call("alloc"));
		}

		public new NSView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithFrame(NSRect frameRect)
		{
			return Call("initWithFrame:", frameRect).To<NSObject>();
		}

		public NSWindow window()
		{
			return Call("window").To<NSWindow>();
		}

		public NSView superview()
		{
			return Call("superview").To<NSView>();
		}

		// skipping subviews because there is a hand-written version

		public bool isDescendantOf(NSView aView)
		{
			return Call("isDescendantOf:", aView).To<bool>();
		}

		public NSView ancestorSharedWithView(NSView aView)
		{
			return Call("ancestorSharedWithView:", aView).To<NSView>();
		}

		public NSView opaqueAncestor()
		{
			return Call("opaqueAncestor").To<NSView>();
		}

		public void setHidden(bool flag)
		{
			Unused.Value = Call("setHidden:", flag);
		}

		public bool isHidden()
		{
			return Call("isHidden").To<bool>();
		}

		public bool isHiddenOrHasHiddenAncestor()
		{
			return Call("isHiddenOrHasHiddenAncestor").To<bool>();
		}

		public void getRectsBeingDrawnCount(IntPtr rects, IntPtr count)
		{
			Unused.Value = Call("getRectsBeingDrawn:count:", rects, count);
		}

		public bool needsToDrawRect(NSRect aRect)
		{
			return Call("needsToDrawRect:", aRect).To<bool>();
		}

		public bool wantsDefaultClipping()
		{
			return Call("wantsDefaultClipping").To<bool>();
		}

		public void viewDidHide()
		{
			Unused.Value = Call("viewDidHide");
		}

		public void viewDidUnhide()
		{
			Unused.Value = Call("viewDidUnhide");
		}

		// skipping setSubviews: because there is a hand-written version

		public void addSubview(NSView aView)
		{
			Unused.Value = Call("addSubview:", aView);
		}

		public void addSubviewPositionedRelativeTo(NSView aView, Int32 place, NSView otherView)
		{
			Unused.Value = Call("addSubview:positioned:relativeTo:", aView, place, otherView);
		}

		// skipping sortSubviewsUsingFunction:context: because it has a function pointer

		public void viewWillMoveToWindow(NSWindow newWindow)
		{
			Unused.Value = Call("viewWillMoveToWindow:", newWindow);
		}

		public void viewDidMoveToWindow()
		{
			Unused.Value = Call("viewDidMoveToWindow");
		}

		public void viewWillMoveToSuperview(NSView newSuperview)
		{
			Unused.Value = Call("viewWillMoveToSuperview:", newSuperview);
		}

		public void viewDidMoveToSuperview()
		{
			Unused.Value = Call("viewDidMoveToSuperview");
		}

		public void didAddSubview(NSView subview)
		{
			Unused.Value = Call("didAddSubview:", subview);
		}

		public void willRemoveSubview(NSView subview)
		{
			Unused.Value = Call("willRemoveSubview:", subview);
		}

		public void removeFromSuperview()
		{
			Unused.Value = Call("removeFromSuperview");
		}

		public void replaceSubviewWith(NSView oldView, NSView newView)
		{
			Unused.Value = Call("replaceSubview:with:", oldView, newView);
		}

		public void removeFromSuperviewWithoutNeedingDisplay()
		{
			Unused.Value = Call("removeFromSuperviewWithoutNeedingDisplay");
		}

		public void setPostsFrameChangedNotifications(bool flag)
		{
			Unused.Value = Call("setPostsFrameChangedNotifications:", flag);
		}

		public bool postsFrameChangedNotifications()
		{
			return Call("postsFrameChangedNotifications").To<bool>();
		}

		public void resizeSubviewsWithOldSize(NSSize oldSize)
		{
			Unused.Value = Call("resizeSubviewsWithOldSize:", oldSize);
		}

		public void resizeWithOldSuperviewSize(NSSize oldSize)
		{
			Unused.Value = Call("resizeWithOldSuperviewSize:", oldSize);
		}

		public void setAutoresizesSubviews(bool flag)
		{
			Unused.Value = Call("setAutoresizesSubviews:", flag);
		}

		public bool autoresizesSubviews()
		{
			return Call("autoresizesSubviews").To<bool>();
		}

		public void setAutoresizingMask(UInt32 mask)
		{
			Unused.Value = Call("setAutoresizingMask:", mask);
		}

		public UInt32 autoresizingMask()
		{
			return Call("autoresizingMask").To<UInt32>();
		}

		public void setFrameOrigin(NSPoint newOrigin)
		{
			Unused.Value = Call("setFrameOrigin:", newOrigin);
		}

		public void setFrameSize(NSSize newSize)
		{
			Unused.Value = Call("setFrameSize:", newSize);
		}

		public void setFrame(NSRect frameRect)
		{
			Unused.Value = Call("setFrame:", frameRect);
		}

		public NSRect frame()
		{
			return Call("frame").To<NSRect>();
		}

		public void setFrameRotation(float angle)
		{
			Unused.Value = Call("setFrameRotation:", angle);
		}

		public float frameRotation()
		{
			return Call("frameRotation").To<float>();
		}

		public void setFrameCenterRotation(float angle)
		{
			Unused.Value = Call("setFrameCenterRotation:", angle);
		}

		public float frameCenterRotation()
		{
			return Call("frameCenterRotation").To<float>();
		}

		public void setBoundsOrigin(NSPoint newOrigin)
		{
			Unused.Value = Call("setBoundsOrigin:", newOrigin);
		}

		public void setBoundsSize(NSSize newSize)
		{
			Unused.Value = Call("setBoundsSize:", newSize);
		}

		public void setBoundsRotation(float angle)
		{
			Unused.Value = Call("setBoundsRotation:", angle);
		}

		public float boundsRotation()
		{
			return Call("boundsRotation").To<float>();
		}

		public void translateOriginToPoint(NSPoint translation)
		{
			Unused.Value = Call("translateOriginToPoint:", translation);
		}

		public void scaleUnitSquareToSize(NSSize newUnitSize)
		{
			Unused.Value = Call("scaleUnitSquareToSize:", newUnitSize);
		}

		public void rotateByAngle(float angle)
		{
			Unused.Value = Call("rotateByAngle:", angle);
		}

		public void setBounds(NSRect aRect)
		{
			Unused.Value = Call("setBounds:", aRect);
		}

		public NSRect bounds()
		{
			return Call("bounds").To<NSRect>();
		}

		public bool isFlipped()
		{
			return Call("isFlipped").To<bool>();
		}

		public bool isRotatedFromBase()
		{
			return Call("isRotatedFromBase").To<bool>();
		}

		public bool isRotatedOrScaledFromBase()
		{
			return Call("isRotatedOrScaledFromBase").To<bool>();
		}

		public bool isOpaque()
		{
			return Call("isOpaque").To<bool>();
		}

		public NSPoint convertPointFromView(NSPoint aPoint, NSView aView)
		{
			return Call("convertPoint:fromView:", aPoint, aView).To<NSPoint>();
		}

		public NSPoint convertPointToView(NSPoint aPoint, NSView aView)
		{
			return Call("convertPoint:toView:", aPoint, aView).To<NSPoint>();
		}

		public NSSize convertSizeFromView(NSSize aSize, NSView aView)
		{
			return Call("convertSize:fromView:", aSize, aView).To<NSSize>();
		}

		public NSSize convertSizeToView(NSSize aSize, NSView aView)
		{
			return Call("convertSize:toView:", aSize, aView).To<NSSize>();
		}

		public NSRect convertRectFromView(NSRect aRect, NSView aView)
		{
			return Call("convertRect:fromView:", aRect, aView).To<NSRect>();
		}

		public NSRect convertRectToView(NSRect aRect, NSView aView)
		{
			return Call("convertRect:toView:", aRect, aView).To<NSRect>();
		}

		public NSRect centerScanRect(NSRect aRect)
		{
			return Call("centerScanRect:", aRect).To<NSRect>();
		}

		public NSPoint convertPointToBase(NSPoint aPoint)
		{
			return Call("convertPointToBase:", aPoint).To<NSPoint>();
		}

		public NSPoint convertPointFromBase(NSPoint aPoint)
		{
			return Call("convertPointFromBase:", aPoint).To<NSPoint>();
		}

		public NSSize convertSizeToBase(NSSize aSize)
		{
			return Call("convertSizeToBase:", aSize).To<NSSize>();
		}

		public NSSize convertSizeFromBase(NSSize aSize)
		{
			return Call("convertSizeFromBase:", aSize).To<NSSize>();
		}

		public NSRect convertRectToBase(NSRect aRect)
		{
			return Call("convertRectToBase:", aRect).To<NSRect>();
		}

		public NSRect convertRectFromBase(NSRect aRect)
		{
			return Call("convertRectFromBase:", aRect).To<NSRect>();
		}

		public bool canDraw()
		{
			return Call("canDraw").To<bool>();
		}

		public void setNeedsDisplay(bool flag)
		{
			Unused.Value = Call("setNeedsDisplay:", flag);
		}

		public void setNeedsDisplayInRect(NSRect invalidRect)
		{
			Unused.Value = Call("setNeedsDisplayInRect:", invalidRect);
		}

		public bool needsDisplay()
		{
			return Call("needsDisplay").To<bool>();
		}

		public void lockFocus()
		{
			Unused.Value = Call("lockFocus");
		}

		public void unlockFocus()
		{
			Unused.Value = Call("unlockFocus");
		}

		public bool lockFocusIfCanDraw()
		{
			return Call("lockFocusIfCanDraw").To<bool>();
		}

		public bool lockFocusIfCanDrawInContext(NSGraphicsContext context)
		{
			return Call("lockFocusIfCanDrawInContext:", context).To<bool>();
		}

		public static NSView focusView()
		{
			return ms_class.Call("focusView").To<NSView>();
		}

		public NSRect visibleRect()
		{
			return Call("visibleRect").To<NSRect>();
		}

		public void display()
		{
			Unused.Value = Call("display");
		}

		public void displayIfNeeded()
		{
			Unused.Value = Call("displayIfNeeded");
		}

		public void displayIfNeededIgnoringOpacity()
		{
			Unused.Value = Call("displayIfNeededIgnoringOpacity");
		}

		public void displayRect(NSRect rect)
		{
			Unused.Value = Call("displayRect:", rect);
		}

		public void displayIfNeededInRect(NSRect rect)
		{
			Unused.Value = Call("displayIfNeededInRect:", rect);
		}

		public void displayRectIgnoringOpacity(NSRect rect)
		{
			Unused.Value = Call("displayRectIgnoringOpacity:", rect);
		}

		public void displayIfNeededInRectIgnoringOpacity(NSRect rect)
		{
			Unused.Value = Call("displayIfNeededInRectIgnoringOpacity:", rect);
		}

		public void drawRect(NSRect rect)
		{
			Unused.Value = Call("drawRect:", rect);
		}

		public void displayRectIgnoringOpacityInContext(NSRect aRect, NSGraphicsContext context)
		{
			Unused.Value = Call("displayRectIgnoringOpacity:inContext:", aRect, context);
		}

		public NSBitmapImageRep bitmapImageRepForCachingDisplayInRect(NSRect rect)
		{
			return Call("bitmapImageRepForCachingDisplayInRect:", rect).To<NSBitmapImageRep>();
		}

		public void cacheDisplayInRectToBitmapImageRep(NSRect rect, NSBitmapImageRep bitmapImageRep)
		{
			Unused.Value = Call("cacheDisplayInRect:toBitmapImageRep:", rect, bitmapImageRep);
		}

		public void viewWillDraw()
		{
			Unused.Value = Call("viewWillDraw");
		}

		public Int32 gState()
		{
			return Call("gState").To<Int32>();
		}

		public void allocateGState()
		{
			Unused.Value = Call("allocateGState");
		}

		public void releaseGState()
		{
			Unused.Value = Call("releaseGState");
		}

		public void setUpGState()
		{
			Unused.Value = Call("setUpGState");
		}

		public void renewGState()
		{
			Unused.Value = Call("renewGState");
		}

		public void scrollPoint(NSPoint aPoint)
		{
			Unused.Value = Call("scrollPoint:", aPoint);
		}

		public bool scrollRectToVisible(NSRect aRect)
		{
			return Call("scrollRectToVisible:", aRect).To<bool>();
		}

		public bool autoscroll(NSEvent theEvent)
		{
			return Call("autoscroll:", theEvent).To<bool>();
		}

		public NSRect adjustScroll(NSRect newVisible)
		{
			return Call("adjustScroll:", newVisible).To<NSRect>();
		}

		public void scrollRectBy(NSRect aRect, NSSize delta)
		{
			Unused.Value = Call("scrollRect:by:", aRect, delta);
		}

		public void translateRectsNeedingDisplayInRectBy(NSRect clipRect, NSSize delta)
		{
			Unused.Value = Call("translateRectsNeedingDisplayInRect:by:", clipRect, delta);
		}

		public NSView hitTest(NSPoint aPoint)
		{
			return Call("hitTest:", aPoint).To<NSView>();
		}

		public bool mouseInRect(NSPoint aPoint, NSRect aRect)
		{
			return Call("mouse:inRect:", aPoint, aRect).To<bool>();
		}

		public NSObject viewWithTag(Int32 aTag)
		{
			return Call("viewWithTag:", aTag).To<NSObject>();
		}

		public Int32 tag()
		{
			return Call("tag").To<Int32>();
		}

		// skipping performKeyEquivalent: (it's declared in a base class)

		public bool acceptsFirstMouse(NSEvent theEvent)
		{
			return Call("acceptsFirstMouse:", theEvent).To<bool>();
		}

		public bool shouldDelayWindowOrderingForEvent(NSEvent theEvent)
		{
			return Call("shouldDelayWindowOrderingForEvent:", theEvent).To<bool>();
		}

		public bool needsPanelToBecomeKey()
		{
			return Call("needsPanelToBecomeKey").To<bool>();
		}

		public bool mouseDownCanMoveWindow()
		{
			return Call("mouseDownCanMoveWindow").To<bool>();
		}

		public void addCursorRectCursor(NSRect aRect, NSCursor anObj)
		{
			Unused.Value = Call("addCursorRect:cursor:", aRect, anObj);
		}

		public void removeCursorRectCursor(NSRect aRect, NSCursor anObj)
		{
			Unused.Value = Call("removeCursorRect:cursor:", aRect, anObj);
		}

		public void discardCursorRects()
		{
			Unused.Value = Call("discardCursorRects");
		}

		public void resetCursorRects()
		{
			Unused.Value = Call("resetCursorRects");
		}

		public Int32 addTrackingRectOwnerUserDataAssumeInside(NSRect aRect, NSObject anObject, IntPtr data, bool flag)
		{
			return Call("addTrackingRect:owner:userData:assumeInside:", aRect, anObject, data, flag).To<Int32>();
		}

		public void removeTrackingRect(Int32 tag)
		{
			Unused.Value = Call("removeTrackingRect:", tag);
		}

		public void setWantsLayer(bool flag)
		{
			Unused.Value = Call("setWantsLayer:", flag);
		}

		public bool wantsLayer()
		{
			return Call("wantsLayer").To<bool>();
		}

		public void setLayer(IntPtr newLayer)
		{
			Unused.Value = Call("setLayer:", newLayer);
		}

		public IntPtr layer()
		{
			return Call("layer").To<IntPtr>();
		}

		public void setAlphaValue(float viewAlpha)
		{
			Unused.Value = Call("setAlphaValue:", viewAlpha);
		}

		public float alphaValue()
		{
			return Call("alphaValue").To<float>();
		}

		public void setBackgroundFilters(NSArray filters)
		{
			Unused.Value = Call("setBackgroundFilters:", filters);
		}

		public NSArray backgroundFilters()
		{
			return Call("backgroundFilters").To<NSArray>();
		}

		public void setCompositingFilter(IntPtr filter)
		{
			Unused.Value = Call("setCompositingFilter:", filter);
		}

		public IntPtr compositingFilter()
		{
			return Call("compositingFilter").To<IntPtr>();
		}

		public void setContentFilters(NSArray filters)
		{
			Unused.Value = Call("setContentFilters:", filters);
		}

		public NSArray contentFilters()
		{
			return Call("contentFilters").To<NSArray>();
		}

		public void setShadow(NSShadow shadow)
		{
			Unused.Value = Call("setShadow:", shadow);
		}

		public NSShadow shadow()
		{
			return Call("shadow").To<NSShadow>();
		}

		public void addTrackingArea(NSTrackingArea trackingArea)
		{
			Unused.Value = Call("addTrackingArea:", trackingArea);
		}

		public void removeTrackingArea(NSTrackingArea trackingArea)
		{
			Unused.Value = Call("removeTrackingArea:", trackingArea);
		}

		public NSArray trackingAreas()
		{
			return Call("trackingAreas").To<NSArray>();
		}

		public void updateTrackingAreas()
		{
			Unused.Value = Call("updateTrackingAreas");
		}

		public bool shouldDrawColor()
		{
			return Call("shouldDrawColor").To<bool>();
		}

		public void setPostsBoundsChangedNotifications(bool flag)
		{
			Unused.Value = Call("setPostsBoundsChangedNotifications:", flag);
		}

		public bool postsBoundsChangedNotifications()
		{
			return Call("postsBoundsChangedNotifications").To<bool>();
		}

		public NSScrollView enclosingScrollView()
		{
			return Call("enclosingScrollView").To<NSScrollView>();
		}

		public NSMenu menuForEvent(NSEvent event_)
		{
			return Call("menuForEvent:", event_).To<NSMenu>();
		}

		public static NSMenu defaultMenu()
		{
			return ms_class.Call("defaultMenu").To<NSMenu>();
		}

		public void setToolTip(NSString string_)
		{
			Unused.Value = Call("setToolTip:", string_);
		}

		public NSString toolTip()
		{
			return Call("toolTip").To<NSString>();
		}

		public Int32 addToolTipRectOwnerUserData(NSRect aRect, NSObject anObject, IntPtr data)
		{
			return Call("addToolTipRect:owner:userData:", aRect, anObject, data).To<Int32>();
		}

		public void removeToolTip(Int32 tag)
		{
			Unused.Value = Call("removeToolTip:", tag);
		}

		public void removeAllToolTips()
		{
			Unused.Value = Call("removeAllToolTips");
		}

		public void viewWillStartLiveResize()
		{
			Unused.Value = Call("viewWillStartLiveResize");
		}

		public void viewDidEndLiveResize()
		{
			Unused.Value = Call("viewDidEndLiveResize");
		}

		public bool inLiveResize()
		{
			return Call("inLiveResize").To<bool>();
		}

		public bool preservesContentDuringLiveResize()
		{
			return Call("preservesContentDuringLiveResize").To<bool>();
		}

		public NSRect rectPreservedDuringLiveResize()
		{
			return Call("rectPreservedDuringLiveResize").To<NSRect>();
		}

		public void getRectsExposedDuringLiveResizeCount(IntPtr exposedRects, IntPtr count)
		{
			Unused.Value = Call("getRectsExposedDuringLiveResize:count:", exposedRects, count);
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

		private static Class ms_class = new Class("NSView");
	}

	public static class NSToolTipOwnerForNSObjectCategory
	{
		public static NSString viewStringForToolTipPointUserData(this NSObject _instance, NSView view, Int32 tag, NSPoint point, IntPtr data)
		{
			return _instance.Call("view:stringForToolTip:point:userData:", view, tag, point, data).To<NSString>();
		}
	}

	public static class NSKeyboardUIForNSViewCategory
	{
		public static bool performMnemonic(this NSView _instance, NSString theString)
		{
			return _instance.Call("performMnemonic:", theString).To<bool>();
		}

		public static void setNextKeyView(this NSView _instance, NSView next)
		{
			Unused.Value = _instance.Call("setNextKeyView:", next);
		}

		public static NSView nextKeyView(this NSView _instance)
		{
			return _instance.Call("nextKeyView").To<NSView>();
		}

		public static NSView previousKeyView(this NSView _instance)
		{
			return _instance.Call("previousKeyView").To<NSView>();
		}

		public static NSView nextValidKeyView(this NSView _instance)
		{
			return _instance.Call("nextValidKeyView").To<NSView>();
		}

		public static NSView previousValidKeyView(this NSView _instance)
		{
			return _instance.Call("previousValidKeyView").To<NSView>();
		}

		public static bool canBecomeKeyView(this NSView _instance)
		{
			return _instance.Call("canBecomeKeyView").To<bool>();
		}

		public static void setKeyboardFocusRingNeedsDisplayInRect(this NSView _instance, NSRect rect)
		{
			Unused.Value = _instance.Call("setKeyboardFocusRingNeedsDisplayInRect:", rect);
		}

		public static void setFocusRingType(this NSView _instance, UInt32 focusRingType)
		{
			Unused.Value = _instance.Call("setFocusRingType:", focusRingType);
		}

		public static UInt32 focusRingType(this NSView _instance)
		{
			return _instance.Call("focusRingType").To<UInt32>();
		}

		public static UInt32 defaultFocusRingType(this NSView _instance)
		{
			return _instance.Call("defaultFocusRingType").To<UInt32>();
		}
	}

	public static class NSPrintingForNSViewCategory
	{
		public static void writeEPSInsideRectToPasteboard(this NSView _instance, NSRect rect, NSPasteboard pasteboard)
		{
			Unused.Value = _instance.Call("writeEPSInsideRect:toPasteboard:", rect, pasteboard);
		}

		public static NSData dataWithEPSInsideRect(this NSView _instance, NSRect rect)
		{
			return _instance.Call("dataWithEPSInsideRect:", rect).To<NSData>();
		}

		public static void writePDFInsideRectToPasteboard(this NSView _instance, NSRect rect, NSPasteboard pasteboard)
		{
			Unused.Value = _instance.Call("writePDFInsideRect:toPasteboard:", rect, pasteboard);
		}

		public static NSData dataWithPDFInsideRect(this NSView _instance, NSRect rect)
		{
			return _instance.Call("dataWithPDFInsideRect:", rect).To<NSData>();
		}

		public static void print(this NSView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("print:", sender);
		}

		public static bool knowsPageRange(this NSView _instance, IntPtr range)
		{
			return _instance.Call("knowsPageRange:", range).To<bool>();
		}

		public static float heightAdjustLimit(this NSView _instance)
		{
			return _instance.Call("heightAdjustLimit").To<float>();
		}

		public static float widthAdjustLimit(this NSView _instance)
		{
			return _instance.Call("widthAdjustLimit").To<float>();
		}

		public static void adjustPageWidthNewLeftRightLimit(this NSView _instance, IntPtr newRight, float oldLeft, float oldRight, float rightLimit)
		{
			Unused.Value = _instance.Call("adjustPageWidthNew:left:right:limit:", newRight, oldLeft, oldRight, rightLimit);
		}

		public static void adjustPageHeightNewTopBottomLimit(this NSView _instance, IntPtr newBottom, float oldTop, float oldBottom, float bottomLimit)
		{
			Unused.Value = _instance.Call("adjustPageHeightNew:top:bottom:limit:", newBottom, oldTop, oldBottom, bottomLimit);
		}

		public static NSRect rectForPage(this NSView _instance, Int32 page)
		{
			return _instance.Call("rectForPage:", page).To<NSRect>();
		}

		public static NSPoint locationOfPrintRect(this NSView _instance, NSRect aRect)
		{
			return _instance.Call("locationOfPrintRect:", aRect).To<NSPoint>();
		}

		public static void drawPageBorderWithSize(this NSView _instance, NSSize borderSize)
		{
			Unused.Value = _instance.Call("drawPageBorderWithSize:", borderSize);
		}

		public static NSAttributedString pageHeader(this NSView _instance)
		{
			return _instance.Call("pageHeader").To<NSAttributedString>();
		}

		public static NSAttributedString pageFooter(this NSView _instance)
		{
			return _instance.Call("pageFooter").To<NSAttributedString>();
		}

		public static void drawSheetBorderWithSize(this NSView _instance, NSSize borderSize)
		{
			Unused.Value = _instance.Call("drawSheetBorderWithSize:", borderSize);
		}

		public static NSString printJobTitle(this NSView _instance)
		{
			return _instance.Call("printJobTitle").To<NSString>();
		}

		public static void beginDocument(this NSView _instance)
		{
			Unused.Value = _instance.Call("beginDocument");
		}

		public static void endDocument(this NSView _instance)
		{
			Unused.Value = _instance.Call("endDocument");
		}

		public static void beginPageInRectAtPlacement(this NSView _instance, NSRect aRect, NSPoint location)
		{
			Unused.Value = _instance.Call("beginPageInRect:atPlacement:", aRect, location);
		}

		public static void endPage(this NSView _instance)
		{
			Unused.Value = _instance.Call("endPage");
		}
	}

	public static class NSDragForNSViewCategory
	{
		public static void dragImageAtOffsetEventPasteboardSourceSlideBack(this NSView _instance, NSImage anImage, NSPoint viewLocation, NSSize initialOffset, NSEvent event_, NSPasteboard pboard, NSObject sourceObj, bool slideFlag)
		{
			Unused.Value = _instance.Call("dragImage:at:offset:event:pasteboard:source:slideBack:", anImage, viewLocation, initialOffset, event_, pboard, sourceObj, slideFlag);
		}

		public static NSArray registeredDraggedTypes(this NSView _instance)
		{
			return _instance.Call("registeredDraggedTypes").To<NSArray>();
		}

		public static void registerForDraggedTypes(this NSView _instance, NSArray newTypes)
		{
			Unused.Value = _instance.Call("registerForDraggedTypes:", newTypes);
		}

		public static void unregisterDraggedTypes(this NSView _instance)
		{
			Unused.Value = _instance.Call("unregisterDraggedTypes");
		}

		public static bool dragFileFromRectSlideBackEvent(this NSView _instance, NSString filename, NSRect rect, bool aFlag, NSEvent event_)
		{
			return _instance.Call("dragFile:fromRect:slideBack:event:", filename, rect, aFlag, event_).To<bool>();
		}

		public static bool dragPromisedFilesOfTypesFromRectSourceSlideBackEvent(this NSView _instance, NSArray typeArray, NSRect rect, NSObject sourceObject, bool aFlag, NSEvent event_)
		{
			return _instance.Call("dragPromisedFilesOfTypes:fromRect:source:slideBack:event:", typeArray, rect, sourceObject, aFlag, event_).To<bool>();
		}
	}

	public static class NSFullScreenModeForNSViewCategory
	{
		public static bool enterFullScreenModeWithOptions(this NSView _instance, NSScreen screen, NSDictionary options)
		{
			return _instance.Call("enterFullScreenMode:withOptions:", screen, options).To<bool>();
		}

		public static void exitFullScreenModeWithOptions(this NSView _instance, NSDictionary options)
		{
			Unused.Value = _instance.Call("exitFullScreenModeWithOptions:", options);
		}

		public static bool isInFullScreenMode(this NSView _instance)
		{
			return _instance.Call("isInFullScreenMode").To<bool>();
		}
	}
}
