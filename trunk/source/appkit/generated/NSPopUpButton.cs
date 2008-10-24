// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPopUpButton.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPopUpButton : NSButton
	{
		public NSPopUpButton() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPopUpButton(IntPtr instance) : base(instance)
		{
		}

		public NSPopUpButton(Untyped instance) : base(instance)
		{
		}

		public static new NSPopUpButton alloc()
		{
			return new NSPopUpButton(ms_class.Call("alloc"));
		}

		public new NSPopUpButton retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithFramePullsDown(NSRect buttonFrame, bool flag)
		{
			return Call("initWithFrame:pullsDown:", buttonFrame, flag).To<NSObject>();
		}

		// skipping setMenu: (it's declared in a base class)

		// skipping menu (it's declared in a base class)

		public void setPullsDown(bool flag)
		{
			Unused.Value = Call("setPullsDown:", flag);
		}

		public bool pullsDown()
		{
			return Call("pullsDown").To<bool>();
		}

		public void setAutoenablesItems(bool flag)
		{
			Unused.Value = Call("setAutoenablesItems:", flag);
		}

		public bool autoenablesItems()
		{
			return Call("autoenablesItems").To<bool>();
		}

		public void setPreferredEdge(UInt32 edge)
		{
			Unused.Value = Call("setPreferredEdge:", edge);
		}

		public UInt32 preferredEdge()
		{
			return Call("preferredEdge").To<UInt32>();
		}

		public void addItemWithTitle(NSString title)
		{
			Unused.Value = Call("addItemWithTitle:", title);
		}

		public void addItemsWithTitles(NSArray itemTitles)
		{
			Unused.Value = Call("addItemsWithTitles:", itemTitles);
		}

		public void insertItemWithTitleAtIndex(NSString title, Int32 index)
		{
			Unused.Value = Call("insertItemWithTitle:atIndex:", title, index);
		}

		public void removeItemWithTitle(NSString title)
		{
			Unused.Value = Call("removeItemWithTitle:", title);
		}

		public void removeItemAtIndex(Int32 index)
		{
			Unused.Value = Call("removeItemAtIndex:", index);
		}

		public void removeAllItems()
		{
			Unused.Value = Call("removeAllItems");
		}

		public NSArray itemArray()
		{
			return Call("itemArray").To<NSArray>();
		}

		public Int32 numberOfItems()
		{
			return Call("numberOfItems").To<Int32>();
		}

		public Int32 indexOfItem(NSMenuItem item)
		{
			return Call("indexOfItem:", item).To<Int32>();
		}

		public Int32 indexOfItemWithTitle(NSString title)
		{
			return Call("indexOfItemWithTitle:", title).To<Int32>();
		}

		public Int32 indexOfItemWithTag(Int32 tag)
		{
			return Call("indexOfItemWithTag:", tag).To<Int32>();
		}

		public Int32 indexOfItemWithRepresentedObject(NSObject obj)
		{
			return Call("indexOfItemWithRepresentedObject:", obj).To<Int32>();
		}

		public Int32 indexOfItemWithTargetAndAction(NSObject target, Selector actionSelector)
		{
			return Call("indexOfItemWithTarget:andAction:", target, actionSelector).To<Int32>();
		}

		public NSMenuItem itemAtIndex(Int32 index)
		{
			return Call("itemAtIndex:", index).To<NSMenuItem>();
		}

		public NSMenuItem itemWithTitle(NSString title)
		{
			return Call("itemWithTitle:", title).To<NSMenuItem>();
		}

		public NSMenuItem lastItem()
		{
			return Call("lastItem").To<NSMenuItem>();
		}

		public void selectItem(NSMenuItem item)
		{
			Unused.Value = Call("selectItem:", item);
		}

		public void selectItemAtIndex(Int32 index)
		{
			Unused.Value = Call("selectItemAtIndex:", index);
		}

		public void selectItemWithTitle(NSString title)
		{
			Unused.Value = Call("selectItemWithTitle:", title);
		}

		public bool selectItemWithTag(Int32 tag)
		{
			return Call("selectItemWithTag:", tag).To<bool>();
		}

		// skipping setTitle: (it's declared in a base class)

		public NSMenuItem selectedItem()
		{
			return Call("selectedItem").To<NSMenuItem>();
		}

		public Int32 indexOfSelectedItem()
		{
			return Call("indexOfSelectedItem").To<Int32>();
		}

		public void synchronizeTitleAndSelectedItem()
		{
			Unused.Value = Call("synchronizeTitleAndSelectedItem");
		}

		public NSString itemTitleAtIndex(Int32 index)
		{
			return Call("itemTitleAtIndex:", index).To<NSString>();
		}

		public NSArray itemTitles()
		{
			return Call("itemTitles").To<NSArray>();
		}

		public NSString titleOfSelectedItem()
		{
			return Call("titleOfSelectedItem").To<NSString>();
		}

		private static Class ms_class = new Class("NSPopUpButton");
	}
}
