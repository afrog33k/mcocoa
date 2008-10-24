// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSClipView.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSClipView : NSView
	{
		public NSClipView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSClipView(IntPtr instance) : base(instance)
		{
		}

		public NSClipView(Untyped instance) : base(instance)
		{
		}

		public static new NSClipView alloc()
		{
			return new NSClipView(ms_class.Call("alloc"));
		}

		public new NSClipView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setDrawsBackground(bool flag)
		{
			Unused.Value = Call("setDrawsBackground:", flag);
		}

		public bool drawsBackground()
		{
			return Call("drawsBackground").To<bool>();
		}

		public void setDocumentView(NSView aView)
		{
			Unused.Value = Call("setDocumentView:", aView);
		}

		public NSObject documentView()
		{
			return Call("documentView").To<NSObject>();
		}

		public NSRect documentRect()
		{
			return Call("documentRect").To<NSRect>();
		}

		public void setDocumentCursor(NSCursor anObj)
		{
			Unused.Value = Call("setDocumentCursor:", anObj);
		}

		public NSCursor documentCursor()
		{
			return Call("documentCursor").To<NSCursor>();
		}

		public NSRect documentVisibleRect()
		{
			return Call("documentVisibleRect").To<NSRect>();
		}

		public void viewFrameChanged(NSNotification notification)
		{
			Unused.Value = Call("viewFrameChanged:", notification);
		}

		public void viewBoundsChanged(NSNotification notification)
		{
			Unused.Value = Call("viewBoundsChanged:", notification);
		}

		public void setCopiesOnScroll(bool flag)
		{
			Unused.Value = Call("setCopiesOnScroll:", flag);
		}

		public bool copiesOnScroll()
		{
			return Call("copiesOnScroll").To<bool>();
		}

		// skipping autoscroll: (it's declared in a base class)

		public NSPoint constrainScrollPoint(NSPoint newOrigin)
		{
			return Call("constrainScrollPoint:", newOrigin).To<NSPoint>();
		}

		public void scrollToPoint(NSPoint newOrigin)
		{
			Unused.Value = Call("scrollToPoint:", newOrigin);
		}

		private static Class ms_class = new Class("NSClipView");
	}

	public static class NSClipViewSuperviewForNSViewCategory
	{
		public static void reflectScrolledClipView(this NSView _instance, NSClipView aClipView)
		{
			Unused.Value = _instance.Call("reflectScrolledClipView:", aClipView);
		}

		public static void scrollClipViewToPoint(this NSView _instance, NSClipView aClipView, NSPoint aPoint)
		{
			Unused.Value = _instance.Call("scrollClipView:toPoint:", aClipView, aPoint);
		}
	}
}
