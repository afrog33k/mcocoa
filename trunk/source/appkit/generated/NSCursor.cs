// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSCursor.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSCursor : NSObject
	{
		public NSCursor() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCursor(IntPtr instance) : base(instance)
		{
		}

		public NSCursor(Untyped instance) : base(instance)
		{
		}

		public static new NSCursor alloc()
		{
			return new NSCursor(ms_class.Call("alloc"));
		}

		public new NSCursor retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSCursor currentCursor()
		{
			return ms_class.Call("currentCursor").To<NSCursor>();
		}

		public static NSCursor arrowCursor()
		{
			return ms_class.Call("arrowCursor").To<NSCursor>();
		}

		public static NSCursor IBeamCursor()
		{
			return ms_class.Call("IBeamCursor").To<NSCursor>();
		}

		public static NSCursor pointingHandCursor()
		{
			return ms_class.Call("pointingHandCursor").To<NSCursor>();
		}

		public static NSCursor closedHandCursor()
		{
			return ms_class.Call("closedHandCursor").To<NSCursor>();
		}

		public static NSCursor openHandCursor()
		{
			return ms_class.Call("openHandCursor").To<NSCursor>();
		}

		public static NSCursor resizeLeftCursor()
		{
			return ms_class.Call("resizeLeftCursor").To<NSCursor>();
		}

		public static NSCursor resizeRightCursor()
		{
			return ms_class.Call("resizeRightCursor").To<NSCursor>();
		}

		public static NSCursor resizeLeftRightCursor()
		{
			return ms_class.Call("resizeLeftRightCursor").To<NSCursor>();
		}

		public static NSCursor resizeUpCursor()
		{
			return ms_class.Call("resizeUpCursor").To<NSCursor>();
		}

		public static NSCursor resizeDownCursor()
		{
			return ms_class.Call("resizeDownCursor").To<NSCursor>();
		}

		public static NSCursor resizeUpDownCursor()
		{
			return ms_class.Call("resizeUpDownCursor").To<NSCursor>();
		}

		public static NSCursor crosshairCursor()
		{
			return ms_class.Call("crosshairCursor").To<NSCursor>();
		}

		public static NSCursor disappearingItemCursor()
		{
			return ms_class.Call("disappearingItemCursor").To<NSCursor>();
		}

		public NSObject initWithImageHotSpot(NSImage newImage, NSPoint aPoint)
		{
			return Call("initWithImage:hotSpot:", newImage, aPoint).To<NSObject>();
		}

		public NSObject initWithImageForegroundColorHintBackgroundColorHintHotSpot(NSImage newImage, NSColor fg, NSColor bg, NSPoint hotSpot)
		{
			return Call("initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:", newImage, fg, bg, hotSpot).To<NSObject>();
		}

		public static void hide()
		{
			Unused.Value = ms_class.Call("hide");
		}

		public static void unhide()
		{
			Unused.Value = ms_class.Call("unhide");
		}

		public static void setHiddenUntilMouseMoves(bool flag)
		{
			Unused.Value = ms_class.Call("setHiddenUntilMouseMoves:", flag);
		}

		public static void pop()
		{
			Unused.Value = ms_class.Call("pop");
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public NSPoint hotSpot()
		{
			return Call("hotSpot").To<NSPoint>();
		}

		public void push()
		{
			Unused.Value = Call("push");
		}

		// skipping pop (it's already defined)

		public void set()
		{
			Unused.Value = Call("set");
		}

		public void setOnMouseExited(bool flag)
		{
			Unused.Value = Call("setOnMouseExited:", flag);
		}

		public void setOnMouseEntered(bool flag)
		{
			Unused.Value = Call("setOnMouseEntered:", flag);
		}

		public bool isSetOnMouseExited()
		{
			return Call("isSetOnMouseExited").To<bool>();
		}

		public bool isSetOnMouseEntered()
		{
			return Call("isSetOnMouseEntered").To<bool>();
		}

		public void mouseEntered(NSEvent theEvent)
		{
			Unused.Value = Call("mouseEntered:", theEvent);
		}

		public void mouseExited(NSEvent theEvent)
		{
			Unused.Value = Call("mouseExited:", theEvent);
		}

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

		private static Class ms_class = new Class("NSCursor");
	}
}
