// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPrintPanel.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSPrintPanelShowsCopies = 0x01;
		public const int NSPrintPanelShowsPageRange = 0x02;
		public const int NSPrintPanelShowsPaperSize = 0x04;
		public const int NSPrintPanelShowsOrientation = 0x08;
		public const int NSPrintPanelShowsScaling = 0x10;
		public const int NSPrintPanelShowsPageSetupAccessory = 0x100;
		public const int NSPrintPanelShowsPreview = 0x20000;
	}

	[Register]
	public partial class NSPrintPanel : NSObject
	{
		public NSPrintPanel() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPrintPanel(IntPtr instance) : base(instance)
		{
		}

		public NSPrintPanel(Untyped instance) : base(instance)
		{
		}

		public static new NSPrintPanel alloc()
		{
			return new NSPrintPanel(ms_class.Call("alloc"));
		}

		public new NSPrintPanel retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSPrintPanel printPanel()
		{
			return ms_class.Call("printPanel").To<NSPrintPanel>();
		}

		public void addAccessoryController(NSObject accessoryController)
		{
			Unused.Value = Call("addAccessoryController:", accessoryController);
		}

		public void removeAccessoryController(NSObject accessoryController)
		{
			Unused.Value = Call("removeAccessoryController:", accessoryController);
		}

		public NSArray accessoryControllers()
		{
			return Call("accessoryControllers").To<NSArray>();
		}

		public void setOptions(Int32 options)
		{
			Unused.Value = Call("setOptions:", options);
		}

		public Int32 options()
		{
			return Call("options").To<Int32>();
		}

		public void setDefaultButtonTitle(NSString defaultButtonTitle)
		{
			Unused.Value = Call("setDefaultButtonTitle:", defaultButtonTitle);
		}

		public NSString defaultButtonTitle()
		{
			return Call("defaultButtonTitle").To<NSString>();
		}

		public void setHelpAnchor(NSString helpAnchor)
		{
			Unused.Value = Call("setHelpAnchor:", helpAnchor);
		}

		public NSString helpAnchor()
		{
			return Call("helpAnchor").To<NSString>();
		}

		public void setJobStyleHint(NSString hint)
		{
			Unused.Value = Call("setJobStyleHint:", hint);
		}

		public NSString jobStyleHint()
		{
			return Call("jobStyleHint").To<NSString>();
		}

		public void beginSheetWithPrintInfoModalForWindowDelegateDidEndSelectorContextInfo(NSPrintInfo printInfo, NSWindow docWindow, NSObject delegate_, Selector didEndSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("beginSheetWithPrintInfo:modalForWindow:delegate:didEndSelector:contextInfo:", printInfo, docWindow, delegate_, didEndSelector, contextInfo);
		}

		public Int32 runModalWithPrintInfo(NSPrintInfo printInfo)
		{
			return Call("runModalWithPrintInfo:", printInfo).To<Int32>();
		}

		public Int32 runModal()
		{
			return Call("runModal").To<Int32>();
		}

		public NSPrintInfo printInfo()
		{
			return Call("printInfo").To<NSPrintInfo>();
		}

		private static Class ms_class = new Class("NSPrintPanel");
	}

	public static class NSDeprecatedForNSPrintPanelCategory
	{
		public static void setAccessoryView(this NSPrintPanel _instance, NSView accessoryView)
		{
			Unused.Value = _instance.Call("setAccessoryView:", accessoryView);
		}

		public static NSView accessoryView(this NSPrintPanel _instance)
		{
			return _instance.Call("accessoryView").To<NSView>();
		}

		public static void updateFromPrintInfo(this NSPrintPanel _instance)
		{
			Unused.Value = _instance.Call("updateFromPrintInfo");
		}

		public static void finalWritePrintInfo(this NSPrintPanel _instance)
		{
			Unused.Value = _instance.Call("finalWritePrintInfo");
		}
	}
}
