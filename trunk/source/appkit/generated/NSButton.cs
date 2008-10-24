// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSButton.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSButton : NSControl
	{
		public NSButton() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSButton(IntPtr instance) : base(instance)
		{
		}

		public NSButton(Untyped instance) : base(instance)
		{
		}

		public static new NSButton alloc()
		{
			return new NSButton(ms_class.Call("alloc"));
		}

		public new NSButton retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString title()
		{
			return Call("title").To<NSString>();
		}

		public void setTitle(NSString aString)
		{
			Unused.Value = Call("setTitle:", aString);
		}

		public NSString alternateTitle()
		{
			return Call("alternateTitle").To<NSString>();
		}

		public void setAlternateTitle(NSString aString)
		{
			Unused.Value = Call("setAlternateTitle:", aString);
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public void setImage(NSImage image)
		{
			Unused.Value = Call("setImage:", image);
		}

		public NSImage alternateImage()
		{
			return Call("alternateImage").To<NSImage>();
		}

		public void setAlternateImage(NSImage image)
		{
			Unused.Value = Call("setAlternateImage:", image);
		}

		public UInt32 imagePosition()
		{
			return Call("imagePosition").To<UInt32>();
		}

		public void setImagePosition(UInt32 aPosition)
		{
			Unused.Value = Call("setImagePosition:", aPosition);
		}

		public void setButtonType(UInt32 aType)
		{
			Unused.Value = Call("setButtonType:", aType);
		}

		public Int32 state()
		{
			return Call("state").To<Int32>();
		}

		public void setState(Int32 value)
		{
			Unused.Value = Call("setState:", value);
		}

		public bool isBordered()
		{
			return Call("isBordered").To<bool>();
		}

		public void setBordered(bool flag)
		{
			Unused.Value = Call("setBordered:", flag);
		}

		public bool isTransparent()
		{
			return Call("isTransparent").To<bool>();
		}

		public void setTransparent(bool flag)
		{
			Unused.Value = Call("setTransparent:", flag);
		}

		public void setPeriodicDelayInterval(float delay, float interval)
		{
			Unused.Value = Call("setPeriodicDelay:interval:", delay, interval);
		}

		public void getPeriodicDelayInterval(IntPtr delay, IntPtr interval)
		{
			Unused.Value = Call("getPeriodicDelay:interval:", delay, interval);
		}

		public NSString keyEquivalent()
		{
			return Call("keyEquivalent").To<NSString>();
		}

		public void setKeyEquivalent(NSString charCode)
		{
			Unused.Value = Call("setKeyEquivalent:", charCode);
		}

		public UInt32 keyEquivalentModifierMask()
		{
			return Call("keyEquivalentModifierMask").To<UInt32>();
		}

		public void setKeyEquivalentModifierMask(UInt32 mask)
		{
			Unused.Value = Call("setKeyEquivalentModifierMask:", mask);
		}

		public void highlight(bool flag)
		{
			Unused.Value = Call("highlight:", flag);
		}

		// skipping performKeyEquivalent: (it's declared in a base class)

		#region NSUserInterfaceValidations Methods
		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}
		#endregion

		private static Class ms_class = new Class("NSButton");
	}

	public static class NSKeyboardUIForNSButtonCategory
	{
		public static void setTitleWithMnemonic(this NSButton _instance, NSString stringWithAmpersand)
		{
			Unused.Value = _instance.Call("setTitleWithMnemonic:", stringWithAmpersand);
		}
	}

	public static class NSButtonAttributedStringMethodsForNSButtonCategory
	{
		public static NSAttributedString attributedTitle(this NSButton _instance)
		{
			return _instance.Call("attributedTitle").To<NSAttributedString>();
		}

		public static void setAttributedTitle(this NSButton _instance, NSAttributedString aString)
		{
			Unused.Value = _instance.Call("setAttributedTitle:", aString);
		}

		public static NSAttributedString attributedAlternateTitle(this NSButton _instance)
		{
			return _instance.Call("attributedAlternateTitle").To<NSAttributedString>();
		}

		public static void setAttributedAlternateTitle(this NSButton _instance, NSAttributedString obj)
		{
			Unused.Value = _instance.Call("setAttributedAlternateTitle:", obj);
		}
	}

	public static class NSButtonBezelStylesForNSButtonCategory
	{
		public static void setBezelStyle(this NSButton _instance, UInt32 bezelStyle)
		{
			Unused.Value = _instance.Call("setBezelStyle:", bezelStyle);
		}

		public static UInt32 bezelStyle(this NSButton _instance)
		{
			return _instance.Call("bezelStyle").To<UInt32>();
		}
	}

	public static class NSButtonMixedStateForNSButtonCategory
	{
		public static void setAllowsMixedState(this NSButton _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAllowsMixedState:", flag);
		}

		public static bool allowsMixedState(this NSButton _instance)
		{
			return _instance.Call("allowsMixedState").To<bool>();
		}

		public static void setNextState(this NSButton _instance)
		{
			Unused.Value = _instance.Call("setNextState");
		}
	}

	public static class NSButtonBorderForNSButtonCategory
	{
		public static void setShowsBorderOnlyWhileMouseInside(this NSButton _instance, bool show)
		{
			Unused.Value = _instance.Call("setShowsBorderOnlyWhileMouseInside:", show);
		}

		public static bool showsBorderOnlyWhileMouseInside(this NSButton _instance)
		{
			return _instance.Call("showsBorderOnlyWhileMouseInside").To<bool>();
		}
	}

	public static class NSButtonSoundExtensionsForNSButtonCategory
	{
		public static void setSound(this NSButton _instance, NSSound aSound)
		{
			Unused.Value = _instance.Call("setSound:", aSound);
		}

		public static NSSound sound(this NSButton _instance)
		{
			return _instance.Call("sound").To<NSSound>();
		}
	}
}
