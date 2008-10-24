// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSColorPanel.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNoModeColorPanel = -1;
		public const int NSGrayModeColorPanel = 0;
		public const int NSRGBModeColorPanel = 1;
		public const int NSCMYKModeColorPanel = 2;
		public const int NSHSBModeColorPanel = 3;
		public const int NSCustomPaletteModeColorPanel = 4;
		public const int NSColorListModeColorPanel = 5;
		public const int NSWheelModeColorPanel = 6;
		public const int NSCrayonModeColorPanel = 7;
	}

	public partial class Enums
	{
		public const int NSColorPanelGrayModeMask = 0x00000001;
		public const int NSColorPanelRGBModeMask = 0x00000002;
		public const int NSColorPanelCMYKModeMask = 0x00000004;
		public const int NSColorPanelHSBModeMask = 0x00000008;
		public const int NSColorPanelCustomPaletteModeMask = 0x00000010;
		public const int NSColorPanelColorListModeMask = 0x00000020;
		public const int NSColorPanelWheelModeMask = 0x00000040;
		public const int NSColorPanelCrayonModeMask = 0x00000080;
		public const int NSColorPanelAllModesMask = 0x0000ffff;
	}

	[Register]
	public partial class NSColorPanel : NSPanel
	{
		public NSColorPanel() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSColorPanel(IntPtr instance) : base(instance)
		{
		}

		public NSColorPanel(Untyped instance) : base(instance)
		{
		}

		public static new NSColorPanel alloc()
		{
			return new NSColorPanel(ms_class.Call("alloc"));
		}

		public new NSColorPanel retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSColorPanel sharedColorPanel()
		{
			return ms_class.Call("sharedColorPanel").To<NSColorPanel>();
		}

		public static bool sharedColorPanelExists()
		{
			return ms_class.Call("sharedColorPanelExists").To<bool>();
		}

		public static bool dragColorWithEventFromView(NSColor color, NSEvent theEvent, NSView sourceView)
		{
			return ms_class.Call("dragColor:withEvent:fromView:", color, theEvent, sourceView).To<bool>();
		}

		public static void setPickerMask(UInt32 mask)
		{
			Unused.Value = ms_class.Call("setPickerMask:", mask);
		}

		public static void setPickerMode(Int32 mode)
		{
			Unused.Value = ms_class.Call("setPickerMode:", mode);
		}

		public void setAccessoryView(NSView aView)
		{
			Unused.Value = Call("setAccessoryView:", aView);
		}

		public NSView accessoryView()
		{
			return Call("accessoryView").To<NSView>();
		}

		public void setContinuous(bool flag)
		{
			Unused.Value = Call("setContinuous:", flag);
		}

		public bool isContinuous()
		{
			return Call("isContinuous").To<bool>();
		}

		public void setShowsAlpha(bool flag)
		{
			Unused.Value = Call("setShowsAlpha:", flag);
		}

		public bool showsAlpha()
		{
			return Call("showsAlpha").To<bool>();
		}

		public void setMode(Int32 mode)
		{
			Unused.Value = Call("setMode:", mode);
		}

		public Int32 mode()
		{
			return Call("mode").To<Int32>();
		}

		public void setColor(NSColor color)
		{
			Unused.Value = Call("setColor:", color);
		}

		public NSColor color()
		{
			return Call("color").To<NSColor>();
		}

		public float alpha()
		{
			return Call("alpha").To<float>();
		}

		public void setAction(Selector aSelector)
		{
			Unused.Value = Call("setAction:", aSelector);
		}

		public void setTarget(NSObject anObject)
		{
			Unused.Value = Call("setTarget:", anObject);
		}

		public void attachColorList(NSColorList colorList)
		{
			Unused.Value = Call("attachColorList:", colorList);
		}

		public void detachColorList(NSColorList colorList)
		{
			Unused.Value = Call("detachColorList:", colorList);
		}

		private static Class ms_class = new Class("NSColorPanel");
	}

	public static class NSColorPanelForNSApplicationCategory
	{
		public static void orderFrontColorPanel(this NSApplication _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("orderFrontColorPanel:", sender);
		}
	}

	public static class NSColorPanelResponderMethodForNSObjectCategory
	{
		public static void changeColor(this NSObject _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("changeColor:", sender);
		}
	}
}
