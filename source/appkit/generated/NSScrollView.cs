// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSScrollView.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSScrollView : NSView
	{
		public NSScrollView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScrollView(IntPtr instance) : base(instance)
		{
		}

		public NSScrollView(Untyped instance) : base(instance)
		{
		}

		public static new NSScrollView alloc()
		{
			return new NSScrollView(ms_class.Call("alloc"));
		}

		public new NSScrollView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSSize frameSizeForContentSizeHasHorizontalScrollerHasVerticalScrollerBorderType(NSSize cSize, bool hFlag, bool vFlag, UInt32 aType)
		{
			return ms_class.Call("frameSizeForContentSize:hasHorizontalScroller:hasVerticalScroller:borderType:", cSize, hFlag, vFlag, aType).To<NSSize>();
		}

		public static NSSize contentSizeForFrameSizeHasHorizontalScrollerHasVerticalScrollerBorderType(NSSize fSize, bool hFlag, bool vFlag, UInt32 aType)
		{
			return ms_class.Call("contentSizeForFrameSize:hasHorizontalScroller:hasVerticalScroller:borderType:", fSize, hFlag, vFlag, aType).To<NSSize>();
		}

		public NSRect documentVisibleRect()
		{
			return Call("documentVisibleRect").To<NSRect>();
		}

		public NSSize contentSize()
		{
			return Call("contentSize").To<NSSize>();
		}

		public void setDocumentView(NSView aView)
		{
			Unused.Value = Call("setDocumentView:", aView);
		}

		public NSObject documentView()
		{
			return Call("documentView").To<NSObject>();
		}

		public void setContentView(NSClipView contentView)
		{
			Unused.Value = Call("setContentView:", contentView);
		}

		public NSClipView contentView()
		{
			return Call("contentView").To<NSClipView>();
		}

		public void setDocumentCursor(NSCursor anObj)
		{
			Unused.Value = Call("setDocumentCursor:", anObj);
		}

		public NSCursor documentCursor()
		{
			return Call("documentCursor").To<NSCursor>();
		}

		public void setBorderType(UInt32 aType)
		{
			Unused.Value = Call("setBorderType:", aType);
		}

		public UInt32 borderType()
		{
			return Call("borderType").To<UInt32>();
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

		public void setHasVerticalScroller(bool flag)
		{
			Unused.Value = Call("setHasVerticalScroller:", flag);
		}

		public bool hasVerticalScroller()
		{
			return Call("hasVerticalScroller").To<bool>();
		}

		public void setHasHorizontalScroller(bool flag)
		{
			Unused.Value = Call("setHasHorizontalScroller:", flag);
		}

		public bool hasHorizontalScroller()
		{
			return Call("hasHorizontalScroller").To<bool>();
		}

		public void setVerticalScroller(NSScroller anObject)
		{
			Unused.Value = Call("setVerticalScroller:", anObject);
		}

		public NSScroller verticalScroller()
		{
			return Call("verticalScroller").To<NSScroller>();
		}

		public void setHorizontalScroller(NSScroller anObject)
		{
			Unused.Value = Call("setHorizontalScroller:", anObject);
		}

		public NSScroller horizontalScroller()
		{
			return Call("horizontalScroller").To<NSScroller>();
		}

		public bool autohidesScrollers()
		{
			return Call("autohidesScrollers").To<bool>();
		}

		public void setAutohidesScrollers(bool flag)
		{
			Unused.Value = Call("setAutohidesScrollers:", flag);
		}

		public void setHorizontalLineScroll(float value)
		{
			Unused.Value = Call("setHorizontalLineScroll:", value);
		}

		public void setVerticalLineScroll(float value)
		{
			Unused.Value = Call("setVerticalLineScroll:", value);
		}

		public void setLineScroll(float value)
		{
			Unused.Value = Call("setLineScroll:", value);
		}

		public float horizontalLineScroll()
		{
			return Call("horizontalLineScroll").To<float>();
		}

		public float verticalLineScroll()
		{
			return Call("verticalLineScroll").To<float>();
		}

		public float lineScroll()
		{
			return Call("lineScroll").To<float>();
		}

		public void setHorizontalPageScroll(float value)
		{
			Unused.Value = Call("setHorizontalPageScroll:", value);
		}

		public void setVerticalPageScroll(float value)
		{
			Unused.Value = Call("setVerticalPageScroll:", value);
		}

		public void setPageScroll(float value)
		{
			Unused.Value = Call("setPageScroll:", value);
		}

		public float horizontalPageScroll()
		{
			return Call("horizontalPageScroll").To<float>();
		}

		public float verticalPageScroll()
		{
			return Call("verticalPageScroll").To<float>();
		}

		public float pageScroll()
		{
			return Call("pageScroll").To<float>();
		}

		public void setScrollsDynamically(bool flag)
		{
			Unused.Value = Call("setScrollsDynamically:", flag);
		}

		public bool scrollsDynamically()
		{
			return Call("scrollsDynamically").To<bool>();
		}

		public void tile()
		{
			Unused.Value = Call("tile");
		}

		public void reflectScrolledClipView(NSClipView cView)
		{
			Unused.Value = Call("reflectScrolledClipView:", cView);
		}

		// skipping scrollWheel: (it's declared in a base class)

		private static Class ms_class = new Class("NSScrollView");
	}

	public static class NSRulerSupportForNSScrollViewCategory
	{
		public static void setRulerViewClass(this NSScrollView _instance, Class rulerViewClass)
		{
			Unused.Value = _instance.Call("setRulerViewClass:", rulerViewClass);
		}

		public static Class rulerViewClass(this NSScrollView _instance)
		{
			return _instance.Call("rulerViewClass").To<Class>();
		}

		public static void setRulersVisible(this NSScrollView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setRulersVisible:", flag);
		}

		public static bool rulersVisible(this NSScrollView _instance)
		{
			return _instance.Call("rulersVisible").To<bool>();
		}

		public static void setHasHorizontalRuler(this NSScrollView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setHasHorizontalRuler:", flag);
		}

		public static bool hasHorizontalRuler(this NSScrollView _instance)
		{
			return _instance.Call("hasHorizontalRuler").To<bool>();
		}

		public static void setHasVerticalRuler(this NSScrollView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setHasVerticalRuler:", flag);
		}

		public static bool hasVerticalRuler(this NSScrollView _instance)
		{
			return _instance.Call("hasVerticalRuler").To<bool>();
		}

		public static void setHorizontalRulerView(this NSScrollView _instance, NSRulerView ruler)
		{
			Unused.Value = _instance.Call("setHorizontalRulerView:", ruler);
		}

		public static NSRulerView horizontalRulerView(this NSScrollView _instance)
		{
			return _instance.Call("horizontalRulerView").To<NSRulerView>();
		}

		public static void setVerticalRulerView(this NSScrollView _instance, NSRulerView ruler)
		{
			Unused.Value = _instance.Call("setVerticalRulerView:", ruler);
		}

		public static NSRulerView verticalRulerView(this NSScrollView _instance)
		{
			return _instance.Call("verticalRulerView").To<NSRulerView>();
		}
	}
}
