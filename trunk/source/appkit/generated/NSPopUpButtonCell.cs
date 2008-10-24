// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPopUpButtonCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSPopUpNoArrow = 0;
		public const int NSPopUpArrowAtCenter = 1;
		public const int NSPopUpArrowAtBottom = 2;
	}

	[Register]
	public partial class NSPopUpButtonCell : NSMenuItemCell
	{
		public NSPopUpButtonCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPopUpButtonCell(IntPtr instance) : base(instance)
		{
		}

		public NSPopUpButtonCell(Untyped instance) : base(instance)
		{
		}

		public static new NSPopUpButtonCell alloc()
		{
			return new NSPopUpButtonCell(ms_class.Call("alloc"));
		}

		public new NSPopUpButtonCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initTextCellPullsDown(NSString stringValue, bool pullDown)
		{
			return Call("initTextCell:pullsDown:", stringValue, pullDown).To<NSObject>();
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

		public void setUsesItemFromMenu(bool flag)
		{
			Unused.Value = Call("setUsesItemFromMenu:", flag);
		}

		public bool usesItemFromMenu()
		{
			return Call("usesItemFromMenu").To<bool>();
		}

		public void setAltersStateOfSelectedItem(bool flag)
		{
			Unused.Value = Call("setAltersStateOfSelectedItem:", flag);
		}

		public bool altersStateOfSelectedItem()
		{
			return Call("altersStateOfSelectedItem").To<bool>();
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

		public void attachPopUpWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("attachPopUpWithFrame:inView:", cellFrame, controlView);
		}

		public void dismissPopUp()
		{
			Unused.Value = Call("dismissPopUp");
		}

		public void performClickWithFrameInView(NSRect frame, NSView controlView)
		{
			Unused.Value = Call("performClickWithFrame:inView:", frame, controlView);
		}

		public UInt32 arrowPosition()
		{
			return Call("arrowPosition").To<UInt32>();
		}

		public void setArrowPosition(UInt32 position)
		{
			Unused.Value = Call("setArrowPosition:", position);
		}

		// skipping objectValue (it's declared in a base class)

		// skipping setObjectValue: (it's declared in a base class)

		private static Class ms_class = new Class("NSPopUpButtonCell");
	}
}
