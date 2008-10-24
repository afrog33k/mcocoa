// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSButtonCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSMomentaryLightButton = 0;
		public const int NSPushOnPushOffButton = 1;
		public const int NSToggleButton = 2;
		public const int NSSwitchButton = 3;
		public const int NSRadioButton = 4;
		public const int NSMomentaryChangeButton = 5;
		public const int NSOnOffButton = 6;
		public const int NSMomentaryPushInButton = 7;
		public const int NSMomentaryPushButton = 0;
		public const int NSMomentaryLight = 7;
	}

	public partial class Enums
	{
		public const int NSRoundedBezelStyle = 1;
		public const int NSRegularSquareBezelStyle = 2;
		public const int NSThickSquareBezelStyle = 3;
		public const int NSThickerSquareBezelStyle = 4;
		public const int NSDisclosureBezelStyle = 5;
		public const int NSShadowlessSquareBezelStyle = 6;
		public const int NSCircularBezelStyle = 7;
		public const int NSTexturedSquareBezelStyle = 8;
		public const int NSHelpButtonBezelStyle = 9;
		public const int NSSmallSquareBezelStyle = 10;
		public const int NSTexturedRoundedBezelStyle = 11;
		public const int NSRoundRectBezelStyle = 12;
		public const int NSRecessedBezelStyle = 13;
		public const int NSRoundedDisclosureBezelStyle = 14;
		public const int NSSmallIconButtonBezelStyle = 2;
	}

	public partial class Enums
	{
		public const int NSGradientNone = 0;
		public const int NSGradientConcaveWeak = 1;
		public const int NSGradientConcaveStrong = 2;
		public const int NSGradientConvexWeak = 3;
		public const int NSGradientConvexStrong = 4;
	}

	[Register]
	public partial class NSButtonCell : NSActionCell
	{
		public NSButtonCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSButtonCell(IntPtr instance) : base(instance)
		{
		}

		public NSButtonCell(Untyped instance) : base(instance)
		{
		}

		public static new NSButtonCell alloc()
		{
			return new NSButtonCell(ms_class.Call("alloc"));
		}

		public new NSButtonCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping title (it's declared in a base class)

		// skipping setTitle: (it's declared in a base class)

		public NSString alternateTitle()
		{
			return Call("alternateTitle").To<NSString>();
		}

		public void setAlternateTitle(NSString aString)
		{
			Unused.Value = Call("setAlternateTitle:", aString);
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

		public UInt32 imageScaling()
		{
			return Call("imageScaling").To<UInt32>();
		}

		public void setImageScaling(UInt32 scaling)
		{
			Unused.Value = Call("setImageScaling:", scaling);
		}

		public Int32 highlightsBy()
		{
			return Call("highlightsBy").To<Int32>();
		}

		public void setHighlightsBy(Int32 aType)
		{
			Unused.Value = Call("setHighlightsBy:", aType);
		}

		public Int32 showsStateBy()
		{
			return Call("showsStateBy").To<Int32>();
		}

		public void setShowsStateBy(Int32 aType)
		{
			Unused.Value = Call("setShowsStateBy:", aType);
		}

		public void setButtonType(UInt32 aType)
		{
			Unused.Value = Call("setButtonType:", aType);
		}

		// skipping isOpaque (it's declared in a base class)

		// skipping setFont: (it's declared in a base class)

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

		// skipping getPeriodicDelay:interval: (it's declared in a base class)

		// skipping keyEquivalent (it's declared in a base class)

		public void setKeyEquivalent(NSString aKeyEquivalent)
		{
			Unused.Value = Call("setKeyEquivalent:", aKeyEquivalent);
		}

		public UInt32 keyEquivalentModifierMask()
		{
			return Call("keyEquivalentModifierMask").To<UInt32>();
		}

		public void setKeyEquivalentModifierMask(UInt32 mask)
		{
			Unused.Value = Call("setKeyEquivalentModifierMask:", mask);
		}

		public NSFont keyEquivalentFont()
		{
			return Call("keyEquivalentFont").To<NSFont>();
		}

		public void setKeyEquivalentFont(NSFont fontObj)
		{
			Unused.Value = Call("setKeyEquivalentFont:", fontObj);
		}

		public void setKeyEquivalentFontSize(NSString fontName, float fontSize)
		{
			Unused.Value = Call("setKeyEquivalentFont:size:", fontName, fontSize);
		}

		public void performClick(NSObject sender)
		{
			Unused.Value = Call("performClick:", sender);
		}

		public void drawImageWithFrameInView(NSImage image, NSRect frame, NSView controlView)
		{
			Unused.Value = Call("drawImage:withFrame:inView:", image, frame, controlView);
		}

		public NSRect drawTitleWithFrameInView(NSAttributedString title, NSRect frame, NSView controlView)
		{
			return Call("drawTitle:withFrame:inView:", title, frame, controlView).To<NSRect>();
		}

		public void drawBezelWithFrameInView(NSRect frame, NSView controlView)
		{
			Unused.Value = Call("drawBezelWithFrame:inView:", frame, controlView);
		}

		private static Class ms_class = new Class("NSButtonCell");
	}

	public static class NSKeyboardUIForNSButtonCellCategory
	{
		public static void setTitleWithMnemonic(this NSButtonCell _instance, NSString stringWithAmpersand)
		{
			Unused.Value = _instance.Call("setTitleWithMnemonic:", stringWithAmpersand);
		}

		public static void setAlternateTitleWithMnemonic(this NSButtonCell _instance, NSString stringWithAmpersand)
		{
			Unused.Value = _instance.Call("setAlternateTitleWithMnemonic:", stringWithAmpersand);
		}

		public static void setAlternateMnemonicLocation(this NSButtonCell _instance, UInt32 location)
		{
			Unused.Value = _instance.Call("setAlternateMnemonicLocation:", location);
		}

		public static UInt32 alternateMnemonicLocation(this NSButtonCell _instance)
		{
			return _instance.Call("alternateMnemonicLocation").To<UInt32>();
		}

		public static NSString alternateMnemonic(this NSButtonCell _instance)
		{
			return _instance.Call("alternateMnemonic").To<NSString>();
		}
	}

	public static class NSButtonCellExtensionsForNSButtonCellCategory
	{
		public static UInt32 gradientType(this NSButtonCell _instance)
		{
			return _instance.Call("gradientType").To<UInt32>();
		}

		public static void setGradientType(this NSButtonCell _instance, UInt32 type)
		{
			Unused.Value = _instance.Call("setGradientType:", type);
		}

		public static void setImageDimsWhenDisabled(this NSButtonCell _instance, bool flag)
		{
			Unused.Value = _instance.Call("setImageDimsWhenDisabled:", flag);
		}

		public static bool imageDimsWhenDisabled(this NSButtonCell _instance)
		{
			return _instance.Call("imageDimsWhenDisabled").To<bool>();
		}

		public static void setShowsBorderOnlyWhileMouseInside(this NSButtonCell _instance, bool show)
		{
			Unused.Value = _instance.Call("setShowsBorderOnlyWhileMouseInside:", show);
		}

		public static bool showsBorderOnlyWhileMouseInside(this NSButtonCell _instance)
		{
			return _instance.Call("showsBorderOnlyWhileMouseInside").To<bool>();
		}

		public static void mouseEntered(this NSButtonCell _instance, NSEvent event_)
		{
			Unused.Value = _instance.Call("mouseEntered:", event_);
		}

		public static void mouseExited(this NSButtonCell _instance, NSEvent event_)
		{
			Unused.Value = _instance.Call("mouseExited:", event_);
		}

		public static NSColor backgroundColor(this NSButtonCell _instance)
		{
			return _instance.Call("backgroundColor").To<NSColor>();
		}

		public static void setBackgroundColor(this NSButtonCell _instance, NSColor color)
		{
			Unused.Value = _instance.Call("setBackgroundColor:", color);
		}
	}

	public static class NSButtonCellAttributedStringMethodsForNSButtonCellCategory
	{
		public static NSAttributedString attributedTitle(this NSButtonCell _instance)
		{
			return _instance.Call("attributedTitle").To<NSAttributedString>();
		}

		public static void setAttributedTitle(this NSButtonCell _instance, NSAttributedString obj)
		{
			Unused.Value = _instance.Call("setAttributedTitle:", obj);
		}

		public static NSAttributedString attributedAlternateTitle(this NSButtonCell _instance)
		{
			return _instance.Call("attributedAlternateTitle").To<NSAttributedString>();
		}

		public static void setAttributedAlternateTitle(this NSButtonCell _instance, NSAttributedString obj)
		{
			Unused.Value = _instance.Call("setAttributedAlternateTitle:", obj);
		}
	}

	public static class NSButtonCellBezelStylesForNSButtonCellCategory
	{
		public static void setBezelStyle(this NSButtonCell _instance, UInt32 bezelStyle)
		{
			Unused.Value = _instance.Call("setBezelStyle:", bezelStyle);
		}

		public static UInt32 bezelStyle(this NSButtonCell _instance)
		{
			return _instance.Call("bezelStyle").To<UInt32>();
		}
	}

	public static class NSButtonCellSoundExtensionsForNSButtonCellCategory
	{
		public static void setSound(this NSButtonCell _instance, NSSound aSound)
		{
			Unused.Value = _instance.Call("setSound:", aSound);
		}

		public static NSSound sound(this NSButtonCell _instance)
		{
			return _instance.Call("sound").To<NSSound>();
		}
	}
}
