// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSMenuView.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSMenuView : NSView
	{
		public NSMenuView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMenuView(IntPtr instance) : base(instance)
		{
		}

		public NSMenuView(Untyped instance) : base(instance)
		{
		}

		public static new NSMenuView alloc()
		{
			return new NSMenuView(ms_class.Call("alloc"));
		}

		public new NSMenuView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static float menuBarHeight()
		{
			return ms_class.Call("menuBarHeight").To<float>();
		}

		// skipping initWithFrame: (it's declared in a base class)

		public NSObject initAsTearOff()
		{
			return Call("initAsTearOff").To<NSObject>();
		}

		// skipping setMenu: (it's declared in a base class)

		// skipping menu (it's declared in a base class)

		public void itemChanged(NSNotification notification)
		{
			Unused.Value = Call("itemChanged:", notification);
		}

		public void itemAdded(NSNotification notification)
		{
			Unused.Value = Call("itemAdded:", notification);
		}

		public void itemRemoved(NSNotification notification)
		{
			Unused.Value = Call("itemRemoved:", notification);
		}

		public void update()
		{
			Unused.Value = Call("update");
		}

		public void setHorizontal(bool flag)
		{
			Unused.Value = Call("setHorizontal:", flag);
		}

		public bool isHorizontal()
		{
			return Call("isHorizontal").To<bool>();
		}

		public void setFont(NSFont font)
		{
			Unused.Value = Call("setFont:", font);
		}

		public NSFont font()
		{
			return Call("font").To<NSFont>();
		}

		public NSRect innerRect()
		{
			return Call("innerRect").To<NSRect>();
		}

		public NSRect rectOfItemAtIndex(Int32 index)
		{
			return Call("rectOfItemAtIndex:", index).To<NSRect>();
		}

		public Int32 indexOfItemAtPoint(NSPoint point)
		{
			return Call("indexOfItemAtPoint:", point).To<Int32>();
		}

		public void setNeedsDisplayForItemAtIndex(Int32 index)
		{
			Unused.Value = Call("setNeedsDisplayForItemAtIndex:", index);
		}

		public void setHighlightedItemIndex(Int32 index)
		{
			Unused.Value = Call("setHighlightedItemIndex:", index);
		}

		public Int32 highlightedItemIndex()
		{
			return Call("highlightedItemIndex").To<Int32>();
		}

		public float stateImageOffset()
		{
			return Call("stateImageOffset").To<float>();
		}

		public float stateImageWidth()
		{
			return Call("stateImageWidth").To<float>();
		}

		public float imageAndTitleOffset()
		{
			return Call("imageAndTitleOffset").To<float>();
		}

		public float imageAndTitleWidth()
		{
			return Call("imageAndTitleWidth").To<float>();
		}

		public float keyEquivalentOffset()
		{
			return Call("keyEquivalentOffset").To<float>();
		}

		public float keyEquivalentWidth()
		{
			return Call("keyEquivalentWidth").To<float>();
		}

		public void setMenuItemCellForItemAtIndex(NSMenuItemCell cell, Int32 index)
		{
			Unused.Value = Call("setMenuItemCell:forItemAtIndex:", cell, index);
		}

		public NSMenuItemCell menuItemCellForItemAtIndex(Int32 index)
		{
			return Call("menuItemCellForItemAtIndex:", index).To<NSMenuItemCell>();
		}

		public NSMenuView attachedMenuView()
		{
			return Call("attachedMenuView").To<NSMenuView>();
		}

		public void setNeedsSizing(bool flag)
		{
			Unused.Value = Call("setNeedsSizing:", flag);
		}

		public bool needsSizing()
		{
			return Call("needsSizing").To<bool>();
		}

		public void sizeToFit()
		{
			Unused.Value = Call("sizeToFit");
		}

		public NSMenu attachedMenu()
		{
			return Call("attachedMenu").To<NSMenu>();
		}

		public bool isAttached()
		{
			return Call("isAttached").To<bool>();
		}

		public bool isTornOff()
		{
			return Call("isTornOff").To<bool>();
		}

		public NSPoint locationForSubmenu(NSMenu aSubmenu)
		{
			return Call("locationForSubmenu:", aSubmenu).To<NSPoint>();
		}

		public void setWindowFrameForAttachingToRectOnScreenPreferredEdgePopUpSelectedItem(NSRect screenRect, NSScreen screen, UInt32 edge, Int32 selectedItemIndex)
		{
			Unused.Value = Call("setWindowFrameForAttachingToRect:onScreen:preferredEdge:popUpSelectedItem:", screenRect, screen, edge, selectedItemIndex);
		}

		public void detachSubmenu()
		{
			Unused.Value = Call("detachSubmenu");
		}

		public void attachSubmenuForItemAtIndex(Int32 index)
		{
			Unused.Value = Call("attachSubmenuForItemAtIndex:", index);
		}

		public void performActionWithHighlightingForItemAtIndex(Int32 index)
		{
			Unused.Value = Call("performActionWithHighlightingForItemAtIndex:", index);
		}

		public bool trackWithEvent(NSEvent event_)
		{
			return Call("trackWithEvent:", event_).To<bool>();
		}

		public float horizontalEdgePadding()
		{
			return Call("horizontalEdgePadding").To<float>();
		}

		public void setHorizontalEdgePadding(float pad)
		{
			Unused.Value = Call("setHorizontalEdgePadding:", pad);
		}

		private static Class ms_class = new Class("NSMenuView");
	}
}
