// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSMenuItem.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSMenuItem : NSObject
	{
		public NSMenuItem() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMenuItem(IntPtr instance) : base(instance)
		{
		}

		public NSMenuItem(Untyped instance) : base(instance)
		{
		}

		public static new NSMenuItem alloc()
		{
			return new NSMenuItem(ms_class.Call("alloc"));
		}

		public new NSMenuItem retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void setUsesUserKeyEquivalents(bool flag)
		{
			Unused.Value = ms_class.Call("setUsesUserKeyEquivalents:", flag);
		}

		public static bool usesUserKeyEquivalents()
		{
			return ms_class.Call("usesUserKeyEquivalents").To<bool>();
		}

		public static NSMenuItem separatorItem()
		{
			return ms_class.Call("separatorItem").To<NSMenuItem>();
		}

		public NSObject initWithTitleActionKeyEquivalent(NSString aString, Selector aSelector, NSString charCode)
		{
			return Call("initWithTitle:action:keyEquivalent:", aString, aSelector, charCode).To<NSObject>();
		}

		public void setMenu(NSMenu menu)
		{
			Unused.Value = Call("setMenu:", menu);
		}

		public NSMenu menu()
		{
			return Call("menu").To<NSMenu>();
		}

		public bool hasSubmenu()
		{
			return Call("hasSubmenu").To<bool>();
		}

		public void setSubmenu(NSMenu submenu)
		{
			Unused.Value = Call("setSubmenu:", submenu);
		}

		public NSMenu submenu()
		{
			return Call("submenu").To<NSMenu>();
		}

		public void setTitle(NSString aString)
		{
			Unused.Value = Call("setTitle:", aString);
		}

		public NSString title()
		{
			return Call("title").To<NSString>();
		}

		public void setAttributedTitle(NSAttributedString string_)
		{
			Unused.Value = Call("setAttributedTitle:", string_);
		}

		public NSAttributedString attributedTitle()
		{
			return Call("attributedTitle").To<NSAttributedString>();
		}

		public bool isSeparatorItem()
		{
			return Call("isSeparatorItem").To<bool>();
		}

		public void setKeyEquivalent(NSString aKeyEquivalent)
		{
			Unused.Value = Call("setKeyEquivalent:", aKeyEquivalent);
		}

		public NSString keyEquivalent()
		{
			return Call("keyEquivalent").To<NSString>();
		}

		public void setKeyEquivalentModifierMask(UInt32 mask)
		{
			Unused.Value = Call("setKeyEquivalentModifierMask:", mask);
		}

		public UInt32 keyEquivalentModifierMask()
		{
			return Call("keyEquivalentModifierMask").To<UInt32>();
		}

		public NSString userKeyEquivalent()
		{
			return Call("userKeyEquivalent").To<NSString>();
		}

		public void setMnemonicLocation(UInt32 location)
		{
			Unused.Value = Call("setMnemonicLocation:", location);
		}

		public UInt32 mnemonicLocation()
		{
			return Call("mnemonicLocation").To<UInt32>();
		}

		public NSString mnemonic()
		{
			return Call("mnemonic").To<NSString>();
		}

		public void setTitleWithMnemonic(NSString stringWithAmpersand)
		{
			Unused.Value = Call("setTitleWithMnemonic:", stringWithAmpersand);
		}

		public void setImage(NSImage menuImage)
		{
			Unused.Value = Call("setImage:", menuImage);
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public void setState(Int32 state)
		{
			Unused.Value = Call("setState:", state);
		}

		public Int32 state()
		{
			return Call("state").To<Int32>();
		}

		public void setOnStateImage(NSImage image)
		{
			Unused.Value = Call("setOnStateImage:", image);
		}

		public NSImage onStateImage()
		{
			return Call("onStateImage").To<NSImage>();
		}

		public void setOffStateImage(NSImage image)
		{
			Unused.Value = Call("setOffStateImage:", image);
		}

		public NSImage offStateImage()
		{
			return Call("offStateImage").To<NSImage>();
		}

		public void setMixedStateImage(NSImage image)
		{
			Unused.Value = Call("setMixedStateImage:", image);
		}

		public NSImage mixedStateImage()
		{
			return Call("mixedStateImage").To<NSImage>();
		}

		public void setEnabled(bool flag)
		{
			Unused.Value = Call("setEnabled:", flag);
		}

		public bool isEnabled()
		{
			return Call("isEnabled").To<bool>();
		}

		public void setAlternate(bool isAlternate)
		{
			Unused.Value = Call("setAlternate:", isAlternate);
		}

		public bool isAlternate()
		{
			return Call("isAlternate").To<bool>();
		}

		public void setIndentationLevel(Int32 indentationLevel)
		{
			Unused.Value = Call("setIndentationLevel:", indentationLevel);
		}

		public Int32 indentationLevel()
		{
			return Call("indentationLevel").To<Int32>();
		}

		public void setTarget(NSObject anObject)
		{
			Unused.Value = Call("setTarget:", anObject);
		}

		public NSObject target()
		{
			return Call("target").To<NSObject>();
		}

		public void setAction(Selector aSelector)
		{
			Unused.Value = Call("setAction:", aSelector);
		}

		public Selector action()
		{
			return Call("action").To<Selector>();
		}

		public void setTag(Int32 anInt)
		{
			Unused.Value = Call("setTag:", anInt);
		}

		public Int32 tag()
		{
			return Call("tag").To<Int32>();
		}

		public void setRepresentedObject(NSObject anObject)
		{
			Unused.Value = Call("setRepresentedObject:", anObject);
		}

		public NSObject representedObject()
		{
			return Call("representedObject").To<NSObject>();
		}

		public void setView(NSView view)
		{
			Unused.Value = Call("setView:", view);
		}

		public NSView view()
		{
			return Call("view").To<NSView>();
		}

		public bool isHighlighted()
		{
			return Call("isHighlighted").To<bool>();
		}

		public void setHidden(bool hidden)
		{
			Unused.Value = Call("setHidden:", hidden);
		}

		public bool isHidden()
		{
			return Call("isHidden").To<bool>();
		}

		public bool isHiddenOrHasHiddenAncestor()
		{
			return Call("isHiddenOrHasHiddenAncestor").To<bool>();
		}

		public void setToolTip(NSString toolTip)
		{
			Unused.Value = Call("setToolTip:", toolTip);
		}

		public NSString toolTip()
		{
			return Call("toolTip").To<NSString>();
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

		#region NSValidatedUserInterfaceItem Methods

		#endregion

		private static Class ms_class = new Class("NSMenuItem");
	}

	public static class NSViewEnclosingMenuItemForNSViewCategory
	{
		public static NSMenuItem enclosingMenuItem(this NSView _instance)
		{
			return _instance.Call("enclosingMenuItem").To<NSMenuItem>();
		}
	}
}
