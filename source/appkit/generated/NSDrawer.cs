// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDrawer.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSDrawerClosedState = 0;
		public const int NSDrawerOpeningState = 1;
		public const int NSDrawerOpenState = 2;
		public const int NSDrawerClosingState = 3;
	}

	[Register]
	public partial class NSDrawer : NSResponder
	{
		public NSDrawer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDrawer(IntPtr instance) : base(instance)
		{
		}

		public NSDrawer(Untyped instance) : base(instance)
		{
		}

		public static new NSDrawer alloc()
		{
			return new NSDrawer(ms_class.Call("alloc"));
		}

		public new NSDrawer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContentSizePreferredEdge(NSSize contentSize, UInt32 edge)
		{
			return Call("initWithContentSize:preferredEdge:", contentSize, edge).To<NSObject>();
		}

		public void setParentWindow(NSWindow parent)
		{
			Unused.Value = Call("setParentWindow:", parent);
		}

		public NSWindow parentWindow()
		{
			return Call("parentWindow").To<NSWindow>();
		}

		public void setContentView(NSView aView)
		{
			Unused.Value = Call("setContentView:", aView);
		}

		public NSView contentView()
		{
			return Call("contentView").To<NSView>();
		}

		public void setPreferredEdge(UInt32 edge)
		{
			Unused.Value = Call("setPreferredEdge:", edge);
		}

		public UInt32 preferredEdge()
		{
			return Call("preferredEdge").To<UInt32>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void open()
		{
			Unused.Value = Call("open");
		}

		public void openOnEdge(UInt32 edge)
		{
			Unused.Value = Call("openOnEdge:", edge);
		}

		public void close()
		{
			Unused.Value = Call("close");
		}

		public void open(NSObject sender)
		{
			Unused.Value = Call("open:", sender);
		}

		public void close(NSObject sender)
		{
			Unused.Value = Call("close:", sender);
		}

		public void toggle(NSObject sender)
		{
			Unused.Value = Call("toggle:", sender);
		}

		public Int32 state()
		{
			return Call("state").To<Int32>();
		}

		public UInt32 edge()
		{
			return Call("edge").To<UInt32>();
		}

		public void setContentSize(NSSize size)
		{
			Unused.Value = Call("setContentSize:", size);
		}

		public NSSize contentSize()
		{
			return Call("contentSize").To<NSSize>();
		}

		public void setMinContentSize(NSSize size)
		{
			Unused.Value = Call("setMinContentSize:", size);
		}

		public NSSize minContentSize()
		{
			return Call("minContentSize").To<NSSize>();
		}

		public void setMaxContentSize(NSSize size)
		{
			Unused.Value = Call("setMaxContentSize:", size);
		}

		public NSSize maxContentSize()
		{
			return Call("maxContentSize").To<NSSize>();
		}

		public void setLeadingOffset(float offset)
		{
			Unused.Value = Call("setLeadingOffset:", offset);
		}

		public float leadingOffset()
		{
			return Call("leadingOffset").To<float>();
		}

		public void setTrailingOffset(float offset)
		{
			Unused.Value = Call("setTrailingOffset:", offset);
		}

		public float trailingOffset()
		{
			return Call("trailingOffset").To<float>();
		}

		private static Class ms_class = new Class("NSDrawer");
	}

	public static class DrawersForNSWindowCategory
	{
		public static NSArray drawers(this NSWindow _instance)
		{
			return _instance.Call("drawers").To<NSArray>();
		}
	}

	public static class NSDrawerNotificationsForNSObjectCategory
	{
		public static void drawerWillOpen(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("drawerWillOpen:", notification);
		}

		public static void drawerDidOpen(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("drawerDidOpen:", notification);
		}

		public static void drawerWillClose(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("drawerWillClose:", notification);
		}

		public static void drawerDidClose(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("drawerDidClose:", notification);
		}
	}

	public static class NSDrawerDelegateForNSObjectCategory
	{
		public static bool drawerShouldOpen(this NSObject _instance, NSDrawer sender)
		{
			return _instance.Call("drawerShouldOpen:", sender).To<bool>();
		}

		public static bool drawerShouldClose(this NSObject _instance, NSDrawer sender)
		{
			return _instance.Call("drawerShouldClose:", sender).To<bool>();
		}

		public static NSSize drawerWillResizeContentsToSize(this NSObject _instance, NSDrawer sender, NSSize contentSize)
		{
			return _instance.Call("drawerWillResizeContents:toSize:", sender, contentSize).To<NSSize>();
		}
	}
}
