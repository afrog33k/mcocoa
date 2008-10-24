// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTabView.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTopTabsBezelBorder = 0;
		public const int NSLeftTabsBezelBorder = 1;
		public const int NSBottomTabsBezelBorder = 2;
		public const int NSRightTabsBezelBorder = 3;
		public const int NSNoTabsBezelBorder = 4;
		public const int NSNoTabsLineBorder = 5;
		public const int NSNoTabsNoBorder = 6;
	}

	[Register]
	public partial class NSTabView : NSView
	{
		public NSTabView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTabView(IntPtr instance) : base(instance)
		{
		}

		public NSTabView(Untyped instance) : base(instance)
		{
		}

		public static new NSTabView alloc()
		{
			return new NSTabView(ms_class.Call("alloc"));
		}

		public new NSTabView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void selectTabViewItem(NSTabViewItem tabViewItem)
		{
			Unused.Value = Call("selectTabViewItem:", tabViewItem);
		}

		public void selectTabViewItemAtIndex(Int32 index)
		{
			Unused.Value = Call("selectTabViewItemAtIndex:", index);
		}

		public void selectTabViewItemWithIdentifier(NSObject identifier)
		{
			Unused.Value = Call("selectTabViewItemWithIdentifier:", identifier);
		}

		public void takeSelectedTabViewItemFromSender(NSObject sender)
		{
			Unused.Value = Call("takeSelectedTabViewItemFromSender:", sender);
		}

		public void selectFirstTabViewItem(NSObject sender)
		{
			Unused.Value = Call("selectFirstTabViewItem:", sender);
		}

		public void selectLastTabViewItem(NSObject sender)
		{
			Unused.Value = Call("selectLastTabViewItem:", sender);
		}

		public void selectNextTabViewItem(NSObject sender)
		{
			Unused.Value = Call("selectNextTabViewItem:", sender);
		}

		public void selectPreviousTabViewItem(NSObject sender)
		{
			Unused.Value = Call("selectPreviousTabViewItem:", sender);
		}

		public NSTabViewItem selectedTabViewItem()
		{
			return Call("selectedTabViewItem").To<NSTabViewItem>();
		}

		public NSFont font()
		{
			return Call("font").To<NSFont>();
		}

		public UInt32 tabViewType()
		{
			return Call("tabViewType").To<UInt32>();
		}

		public NSArray tabViewItems()
		{
			return Call("tabViewItems").To<NSArray>();
		}

		public bool allowsTruncatedLabels()
		{
			return Call("allowsTruncatedLabels").To<bool>();
		}

		public NSSize minimumSize()
		{
			return Call("minimumSize").To<NSSize>();
		}

		public bool drawsBackground()
		{
			return Call("drawsBackground").To<bool>();
		}

		public UInt32 controlTint()
		{
			return Call("controlTint").To<UInt32>();
		}

		public UInt32 controlSize()
		{
			return Call("controlSize").To<UInt32>();
		}

		public void setFont(NSFont font)
		{
			Unused.Value = Call("setFont:", font);
		}

		public void setTabViewType(UInt32 tabViewType)
		{
			Unused.Value = Call("setTabViewType:", tabViewType);
		}

		public void setAllowsTruncatedLabels(bool allowTruncatedLabels)
		{
			Unused.Value = Call("setAllowsTruncatedLabels:", allowTruncatedLabels);
		}

		public void setDrawsBackground(bool flag)
		{
			Unused.Value = Call("setDrawsBackground:", flag);
		}

		public void setControlTint(UInt32 controlTint)
		{
			Unused.Value = Call("setControlTint:", controlTint);
		}

		public void setControlSize(UInt32 controlSize)
		{
			Unused.Value = Call("setControlSize:", controlSize);
		}

		public void addTabViewItem(NSTabViewItem tabViewItem)
		{
			Unused.Value = Call("addTabViewItem:", tabViewItem);
		}

		public void insertTabViewItemAtIndex(NSTabViewItem tabViewItem, Int32 index)
		{
			Unused.Value = Call("insertTabViewItem:atIndex:", tabViewItem, index);
		}

		public void removeTabViewItem(NSTabViewItem tabViewItem)
		{
			Unused.Value = Call("removeTabViewItem:", tabViewItem);
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public NSTabViewItem tabViewItemAtPoint(NSPoint point)
		{
			return Call("tabViewItemAtPoint:", point).To<NSTabViewItem>();
		}

		public NSRect contentRect()
		{
			return Call("contentRect").To<NSRect>();
		}

		public Int32 numberOfTabViewItems()
		{
			return Call("numberOfTabViewItems").To<Int32>();
		}

		public Int32 indexOfTabViewItem(NSTabViewItem tabViewItem)
		{
			return Call("indexOfTabViewItem:", tabViewItem).To<Int32>();
		}

		public NSTabViewItem tabViewItemAtIndex(Int32 index)
		{
			return Call("tabViewItemAtIndex:", index).To<NSTabViewItem>();
		}

		public Int32 indexOfTabViewItemWithIdentifier(NSObject identifier)
		{
			return Call("indexOfTabViewItemWithIdentifier:", identifier).To<Int32>();
		}

		private static Class ms_class = new Class("NSTabView");
	}

	public static class NSTabViewDelegateForNSObjectCategory
	{
		public static bool tabViewShouldSelectTabViewItem(this NSObject _instance, NSTabView tabView, NSTabViewItem tabViewItem)
		{
			return _instance.Call("tabView:shouldSelectTabViewItem:", tabView, tabViewItem).To<bool>();
		}

		public static void tabViewWillSelectTabViewItem(this NSObject _instance, NSTabView tabView, NSTabViewItem tabViewItem)
		{
			Unused.Value = _instance.Call("tabView:willSelectTabViewItem:", tabView, tabViewItem);
		}

		public static void tabViewDidSelectTabViewItem(this NSObject _instance, NSTabView tabView, NSTabViewItem tabViewItem)
		{
			Unused.Value = _instance.Call("tabView:didSelectTabViewItem:", tabView, tabViewItem);
		}

		public static void tabViewDidChangeNumberOfTabViewItems(this NSObject _instance, NSTabView TabView)
		{
			Unused.Value = _instance.Call("tabViewDidChangeNumberOfTabViewItems:", TabView);
		}
	}
}
