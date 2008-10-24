// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSMenu.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSMenu : NSObject
	{
		public NSMenu() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMenu(IntPtr instance) : base(instance)
		{
		}

		public NSMenu(Untyped instance) : base(instance)
		{
		}

		public static new NSMenu alloc()
		{
			return new NSMenu(ms_class.Call("alloc"));
		}

		public new NSMenu retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void setMenuZone(IntPtr aZone)
		{
			Unused.Value = ms_class.Call("setMenuZone:", aZone);
		}

		public static IntPtr menuZone()
		{
			return ms_class.Call("menuZone").To<IntPtr>();
		}

		public static void popUpContextMenuWithEventForView(NSMenu menu, NSEvent event_, NSView view)
		{
			Unused.Value = ms_class.Call("popUpContextMenu:withEvent:forView:", menu, event_, view);
		}

		public static void popUpContextMenuWithEventForViewWithFont(NSMenu menu, NSEvent event_, NSView view, NSFont font)
		{
			Unused.Value = ms_class.Call("popUpContextMenu:withEvent:forView:withFont:", menu, event_, view, font);
		}

		public static void setMenuBarVisible(bool visible)
		{
			Unused.Value = ms_class.Call("setMenuBarVisible:", visible);
		}

		public static bool menuBarVisible()
		{
			return ms_class.Call("menuBarVisible").To<bool>();
		}

		public NSObject initWithTitle(NSString aTitle)
		{
			return Call("initWithTitle:", aTitle).To<NSObject>();
		}

		public void setTitle(NSString aString)
		{
			Unused.Value = Call("setTitle:", aString);
		}

		public NSString title()
		{
			return Call("title").To<NSString>();
		}

		public void setSupermenu(NSMenu supermenu)
		{
			Unused.Value = Call("setSupermenu:", supermenu);
		}

		public NSMenu supermenu()
		{
			return Call("supermenu").To<NSMenu>();
		}

		public void insertItemAtIndex(NSMenuItem newItem, Int32 index)
		{
			Unused.Value = Call("insertItem:atIndex:", newItem, index);
		}

		public void addItem(NSMenuItem newItem)
		{
			Unused.Value = Call("addItem:", newItem);
		}

		public NSMenuItem insertItemWithTitleActionKeyEquivalentAtIndex(NSString aString, Selector aSelector, NSString charCode, Int32 index)
		{
			return Call("insertItemWithTitle:action:keyEquivalent:atIndex:", aString, aSelector, charCode, index).To<NSMenuItem>();
		}

		public NSMenuItem addItemWithTitleActionKeyEquivalent(NSString aString, Selector aSelector, NSString charCode)
		{
			return Call("addItemWithTitle:action:keyEquivalent:", aString, aSelector, charCode).To<NSMenuItem>();
		}

		public void removeItemAtIndex(Int32 index)
		{
			Unused.Value = Call("removeItemAtIndex:", index);
		}

		public void removeItem(NSMenuItem item)
		{
			Unused.Value = Call("removeItem:", item);
		}

		public void setSubmenuForItem(NSMenu aMenu, NSMenuItem anItem)
		{
			Unused.Value = Call("setSubmenu:forItem:", aMenu, anItem);
		}

		public NSArray itemArray()
		{
			return Call("itemArray").To<NSArray>();
		}

		public Int32 numberOfItems()
		{
			return Call("numberOfItems").To<Int32>();
		}

		public Int32 indexOfItem(NSMenuItem index)
		{
			return Call("indexOfItem:", index).To<Int32>();
		}

		public Int32 indexOfItemWithTitle(NSString aTitle)
		{
			return Call("indexOfItemWithTitle:", aTitle).To<Int32>();
		}

		public Int32 indexOfItemWithTag(Int32 aTag)
		{
			return Call("indexOfItemWithTag:", aTag).To<Int32>();
		}

		public Int32 indexOfItemWithRepresentedObject(NSObject object_)
		{
			return Call("indexOfItemWithRepresentedObject:", object_).To<Int32>();
		}

		public Int32 indexOfItemWithSubmenu(NSMenu submenu)
		{
			return Call("indexOfItemWithSubmenu:", submenu).To<Int32>();
		}

		public Int32 indexOfItemWithTargetAndAction(NSObject target, Selector actionSelector)
		{
			return Call("indexOfItemWithTarget:andAction:", target, actionSelector).To<Int32>();
		}

		public NSMenuItem itemAtIndex(Int32 index)
		{
			return Call("itemAtIndex:", index).To<NSMenuItem>();
		}

		public NSMenuItem itemWithTitle(NSString aTitle)
		{
			return Call("itemWithTitle:", aTitle).To<NSMenuItem>();
		}

		public NSMenuItem itemWithTag(Int32 tag)
		{
			return Call("itemWithTag:", tag).To<NSMenuItem>();
		}

		public void setAutoenablesItems(bool flag)
		{
			Unused.Value = Call("setAutoenablesItems:", flag);
		}

		public bool autoenablesItems()
		{
			return Call("autoenablesItems").To<bool>();
		}

		public bool performKeyEquivalent(NSEvent theEvent)
		{
			return Call("performKeyEquivalent:", theEvent).To<bool>();
		}

		public void update()
		{
			Unused.Value = Call("update");
		}

		public void setMenuChangedMessagesEnabled(bool flag)
		{
			Unused.Value = Call("setMenuChangedMessagesEnabled:", flag);
		}

		public bool menuChangedMessagesEnabled()
		{
			return Call("menuChangedMessagesEnabled").To<bool>();
		}

		public void itemChanged(NSMenuItem item)
		{
			Unused.Value = Call("itemChanged:", item);
		}

		public void helpRequested(NSEvent eventPtr)
		{
			Unused.Value = Call("helpRequested:", eventPtr);
		}

		public void setMenuRepresentation(NSObject menuRep)
		{
			Unused.Value = Call("setMenuRepresentation:", menuRep);
		}

		public NSObject menuRepresentation()
		{
			return Call("menuRepresentation").To<NSObject>();
		}

		public void setContextMenuRepresentation(NSObject menuRep)
		{
			Unused.Value = Call("setContextMenuRepresentation:", menuRep);
		}

		public NSObject contextMenuRepresentation()
		{
			return Call("contextMenuRepresentation").To<NSObject>();
		}

		public void setTearOffMenuRepresentation(NSObject menuRep)
		{
			Unused.Value = Call("setTearOffMenuRepresentation:", menuRep);
		}

		public NSObject tearOffMenuRepresentation()
		{
			return Call("tearOffMenuRepresentation").To<NSObject>();
		}

		public bool isTornOff()
		{
			return Call("isTornOff").To<bool>();
		}

		public NSMenu attachedMenu()
		{
			return Call("attachedMenu").To<NSMenu>();
		}

		public bool isAttached()
		{
			return Call("isAttached").To<bool>();
		}

		public void sizeToFit()
		{
			Unused.Value = Call("sizeToFit");
		}

		public NSPoint locationForSubmenu(NSMenu aSubmenu)
		{
			return Call("locationForSubmenu:", aSubmenu).To<NSPoint>();
		}

		public void performActionForItemAtIndex(Int32 index)
		{
			Unused.Value = Call("performActionForItemAtIndex:", index);
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public float menuBarHeight()
		{
			return Call("menuBarHeight").To<float>();
		}

		public void cancelTracking()
		{
			Unused.Value = Call("cancelTracking");
		}

		public NSMenuItem highlightedItem()
		{
			return Call("highlightedItem").To<NSMenuItem>();
		}

		public void setShowsStateColumn(bool showsState)
		{
			Unused.Value = Call("setShowsStateColumn:", showsState);
		}

		public bool showsStateColumn()
		{
			return Call("showsStateColumn").To<bool>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSMenu");
	}

	public static class NSSubmenuActionForNSMenuCategory
	{
		public static void submenuAction(this NSMenu _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("submenuAction:", sender);
		}
	}

	public static class NSMenuValidationForNSObjectCategory
	{
		public static bool validateMenuItem(this NSObject _instance, NSMenuItem menuItem)
		{
			return _instance.Call("validateMenuItem:", menuItem).To<bool>();
		}
	}

	public static class NSMenuDelegateForNSObjectCategory
	{
		public static void menuNeedsUpdate(this NSObject _instance, NSMenu menu)
		{
			Unused.Value = _instance.Call("menuNeedsUpdate:", menu);
		}

		public static Int32 numberOfItemsInMenu(this NSObject _instance, NSMenu menu)
		{
			return _instance.Call("numberOfItemsInMenu:", menu).To<Int32>();
		}

		public static bool menuUpdateItemAtIndexShouldCancel(this NSObject _instance, NSMenu menu, NSMenuItem item, Int32 index, bool shouldCancel)
		{
			return _instance.Call("menu:updateItem:atIndex:shouldCancel:", menu, item, index, shouldCancel).To<bool>();
		}

		public static bool menuHasKeyEquivalentForEventTargetAction(this NSObject _instance, NSMenu menu, NSEvent event_, IntPtr target, IntPtr action)
		{
			return _instance.Call("menuHasKeyEquivalent:forEvent:target:action:", menu, event_, target, action).To<bool>();
		}

		public static void menuWillOpen(this NSObject _instance, NSMenu menu)
		{
			Unused.Value = _instance.Call("menuWillOpen:", menu);
		}

		public static void menuDidClose(this NSObject _instance, NSMenu menu)
		{
			Unused.Value = _instance.Call("menuDidClose:", menu);
		}

		public static void menuWillHighlightItem(this NSObject _instance, NSMenu menu, NSMenuItem item)
		{
			Unused.Value = _instance.Call("menu:willHighlightItem:", menu, item);
		}
	}
}
