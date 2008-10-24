// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSToolbarItem.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSToolbarItemVisibilityPriorityStandard = 0;
		public const int NSToolbarItemVisibilityPriorityLow = -1000;
		public const int NSToolbarItemVisibilityPriorityHigh = 1000;
		public const int NSToolbarItemVisibilityPriorityUser = 2000;
	}

	[Register]
	public partial class NSToolbarItem : NSObject
	{
		public NSToolbarItem() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSToolbarItem(IntPtr instance) : base(instance)
		{
		}

		public NSToolbarItem(Untyped instance) : base(instance)
		{
		}

		public static new NSToolbarItem alloc()
		{
			return new NSToolbarItem(ms_class.Call("alloc"));
		}

		public new NSToolbarItem retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithItemIdentifier(NSString itemIdentifier)
		{
			return Call("initWithItemIdentifier:", itemIdentifier).To<NSObject>();
		}

		public NSString itemIdentifier()
		{
			return Call("itemIdentifier").To<NSString>();
		}

		public NSToolbar toolbar()
		{
			return Call("toolbar").To<NSToolbar>();
		}

		public void setLabel(NSString label)
		{
			Unused.Value = Call("setLabel:", label);
		}

		public NSString label()
		{
			return Call("label").To<NSString>();
		}

		public void setPaletteLabel(NSString paletteLabel)
		{
			Unused.Value = Call("setPaletteLabel:", paletteLabel);
		}

		public NSString paletteLabel()
		{
			return Call("paletteLabel").To<NSString>();
		}

		public void setToolTip(NSString toolTip)
		{
			Unused.Value = Call("setToolTip:", toolTip);
		}

		public NSString toolTip()
		{
			return Call("toolTip").To<NSString>();
		}

		public void setMenuFormRepresentation(NSMenuItem menuItem)
		{
			Unused.Value = Call("setMenuFormRepresentation:", menuItem);
		}

		public NSMenuItem menuFormRepresentation()
		{
			return Call("menuFormRepresentation").To<NSMenuItem>();
		}

		public void setTag(Int32 tag)
		{
			Unused.Value = Call("setTag:", tag);
		}

		public Int32 tag()
		{
			return Call("tag").To<Int32>();
		}

		public void setTarget(NSObject target)
		{
			Unused.Value = Call("setTarget:", target);
		}

		public NSObject target()
		{
			return Call("target").To<NSObject>();
		}

		public void setAction(Selector action)
		{
			Unused.Value = Call("setAction:", action);
		}

		public Selector action()
		{
			return Call("action").To<Selector>();
		}

		public void setEnabled(bool enabled)
		{
			Unused.Value = Call("setEnabled:", enabled);
		}

		public bool isEnabled()
		{
			return Call("isEnabled").To<bool>();
		}

		public void setImage(NSImage image)
		{
			Unused.Value = Call("setImage:", image);
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public void setView(NSView view)
		{
			Unused.Value = Call("setView:", view);
		}

		public NSView view()
		{
			return Call("view").To<NSView>();
		}

		public void setMinSize(NSSize size)
		{
			Unused.Value = Call("setMinSize:", size);
		}

		public NSSize minSize()
		{
			return Call("minSize").To<NSSize>();
		}

		public void setMaxSize(NSSize size)
		{
			Unused.Value = Call("setMaxSize:", size);
		}

		public NSSize maxSize()
		{
			return Call("maxSize").To<NSSize>();
		}

		public void setVisibilityPriority(Int32 visibilityPriority)
		{
			Unused.Value = Call("setVisibilityPriority:", visibilityPriority);
		}

		public Int32 visibilityPriority()
		{
			return Call("visibilityPriority").To<Int32>();
		}

		public void validate()
		{
			Unused.Value = Call("validate");
		}

		public void setAutovalidates(bool resistance)
		{
			Unused.Value = Call("setAutovalidates:", resistance);
		}

		public bool autovalidates()
		{
			return Call("autovalidates").To<bool>();
		}

		public bool allowsDuplicatesInToolbar()
		{
			return Call("allowsDuplicatesInToolbar").To<bool>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSValidatedUserInterfaceItem Methods

		#endregion

		private static Class ms_class = new Class("NSToolbarItem");
	}

	public static class NSToolbarItemValidationForNSObjectCategory
	{
		public static bool validateToolbarItem(this NSObject _instance, NSToolbarItem theItem)
		{
			return _instance.Call("validateToolbarItem:", theItem).To<bool>();
		}
	}
}
