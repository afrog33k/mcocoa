// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSToolbar.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSToolbarDisplayModeDefault = 0;
		public const int NSToolbarDisplayModeIconAndLabel = 1;
		public const int NSToolbarDisplayModeIconOnly = 2;
		public const int NSToolbarDisplayModeLabelOnly = 3;
	}

	public partial class Enums
	{
		public const int NSToolbarSizeModeDefault = 0;
		public const int NSToolbarSizeModeRegular = 1;
		public const int NSToolbarSizeModeSmall = 2;
	}

	[Register]
	public partial class NSToolbar : NSObject
	{
		public NSToolbar() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSToolbar(IntPtr instance) : base(instance)
		{
		}

		public NSToolbar(Untyped instance) : base(instance)
		{
		}

		public static new NSToolbar alloc()
		{
			return new NSToolbar(ms_class.Call("alloc"));
		}

		public new NSToolbar retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithIdentifier(NSString identifier)
		{
			return Call("initWithIdentifier:", identifier).To<NSObject>();
		}

		public void insertItemWithItemIdentifierAtIndex(NSString itemIdentifier, Int32 index)
		{
			Unused.Value = Call("insertItemWithItemIdentifier:atIndex:", itemIdentifier, index);
		}

		public void removeItemAtIndex(Int32 index)
		{
			Unused.Value = Call("removeItemAtIndex:", index);
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setVisible(bool shown)
		{
			Unused.Value = Call("setVisible:", shown);
		}

		public bool isVisible()
		{
			return Call("isVisible").To<bool>();
		}

		public void runCustomizationPalette(NSObject sender)
		{
			Unused.Value = Call("runCustomizationPalette:", sender);
		}

		public bool customizationPaletteIsRunning()
		{
			return Call("customizationPaletteIsRunning").To<bool>();
		}

		public void setDisplayMode(UInt32 displayMode)
		{
			Unused.Value = Call("setDisplayMode:", displayMode);
		}

		public UInt32 displayMode()
		{
			return Call("displayMode").To<UInt32>();
		}

		public void setSelectedItemIdentifier(NSString itemIdentifier)
		{
			Unused.Value = Call("setSelectedItemIdentifier:", itemIdentifier);
		}

		public NSString selectedItemIdentifier()
		{
			return Call("selectedItemIdentifier").To<NSString>();
		}

		public void setSizeMode(UInt32 sizeMode)
		{
			Unused.Value = Call("setSizeMode:", sizeMode);
		}

		public UInt32 sizeMode()
		{
			return Call("sizeMode").To<UInt32>();
		}

		public void setShowsBaselineSeparator(bool flag)
		{
			Unused.Value = Call("setShowsBaselineSeparator:", flag);
		}

		public bool showsBaselineSeparator()
		{
			return Call("showsBaselineSeparator").To<bool>();
		}

		public void setAllowsUserCustomization(bool allowCustomization)
		{
			Unused.Value = Call("setAllowsUserCustomization:", allowCustomization);
		}

		public bool allowsUserCustomization()
		{
			return Call("allowsUserCustomization").To<bool>();
		}

		public NSString identifier()
		{
			return Call("identifier").To<NSString>();
		}

		public NSArray items()
		{
			return Call("items").To<NSArray>();
		}

		public NSArray visibleItems()
		{
			return Call("visibleItems").To<NSArray>();
		}

		public void setAutosavesConfiguration(bool flag)
		{
			Unused.Value = Call("setAutosavesConfiguration:", flag);
		}

		public bool autosavesConfiguration()
		{
			return Call("autosavesConfiguration").To<bool>();
		}

		public void setConfigurationFromDictionary(NSDictionary configDict)
		{
			Unused.Value = Call("setConfigurationFromDictionary:", configDict);
		}

		public NSDictionary configurationDictionary()
		{
			return Call("configurationDictionary").To<NSDictionary>();
		}

		public void validateVisibleItems()
		{
			Unused.Value = Call("validateVisibleItems");
		}

		private static Class ms_class = new Class("NSToolbar");
	}

	public static class NSToolbarDelegateForNSObjectCategory
	{
		public static NSToolbarItem toolbarItemForItemIdentifierWillBeInsertedIntoToolbar(this NSObject _instance, NSToolbar toolbar, NSString itemIdentifier, bool flag)
		{
			return _instance.Call("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:", toolbar, itemIdentifier, flag).To<NSToolbarItem>();
		}

		public static NSArray toolbarDefaultItemIdentifiers(this NSObject _instance, NSToolbar toolbar)
		{
			return _instance.Call("toolbarDefaultItemIdentifiers:", toolbar).To<NSArray>();
		}

		public static NSArray toolbarAllowedItemIdentifiers(this NSObject _instance, NSToolbar toolbar)
		{
			return _instance.Call("toolbarAllowedItemIdentifiers:", toolbar).To<NSArray>();
		}

		public static NSArray toolbarSelectableItemIdentifiers(this NSObject _instance, NSToolbar toolbar)
		{
			return _instance.Call("toolbarSelectableItemIdentifiers:", toolbar).To<NSArray>();
		}
	}

	public static class NSToolbarNotificationsForNSObjectCategory
	{
		public static void toolbarWillAddItem(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("toolbarWillAddItem:", notification);
		}

		public static void toolbarDidRemoveItem(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("toolbarDidRemoveItem:", notification);
		}
	}
}
