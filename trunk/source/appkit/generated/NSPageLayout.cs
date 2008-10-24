// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPageLayout.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPageLayout : NSObject
	{
		public NSPageLayout() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPageLayout(IntPtr instance) : base(instance)
		{
		}

		public NSPageLayout(Untyped instance) : base(instance)
		{
		}

		public static new NSPageLayout alloc()
		{
			return new NSPageLayout(ms_class.Call("alloc"));
		}

		public new NSPageLayout retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSPageLayout pageLayout()
		{
			return ms_class.Call("pageLayout").To<NSPageLayout>();
		}

		public void addAccessoryController(NSViewController accessoryController)
		{
			Unused.Value = Call("addAccessoryController:", accessoryController);
		}

		public void removeAccessoryController(NSViewController accessoryController)
		{
			Unused.Value = Call("removeAccessoryController:", accessoryController);
		}

		public NSArray accessoryControllers()
		{
			return Call("accessoryControllers").To<NSArray>();
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

		private static Class ms_class = new Class("NSPageLayout");
	}

	public static class NSDeprecatedForNSPageLayoutCategory
	{
		public static void setAccessoryView(this NSPageLayout _instance, NSView accessoryView)
		{
			Unused.Value = _instance.Call("setAccessoryView:", accessoryView);
		}

		public static NSView accessoryView(this NSPageLayout _instance)
		{
			return _instance.Call("accessoryView").To<NSView>();
		}

		public static void readPrintInfo(this NSPageLayout _instance)
		{
			Unused.Value = _instance.Call("readPrintInfo");
		}

		public static void writePrintInfo(this NSPageLayout _instance)
		{
			Unused.Value = _instance.Call("writePrintInfo");
		}
	}

	public static class NSPageLayoutPanelForNSApplicationCategory
	{
		public static void runPageLayout(this NSApplication _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("runPageLayout:", sender);
		}
	}
}
