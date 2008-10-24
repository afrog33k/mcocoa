// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPrintOperation.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSDescendingPageOrder = -1;
		public const int NSSpecialPageOrder = 0;
		public const int NSAscendingPageOrder = 1;
		public const int NSUnknownPageOrder = 2;
	}

	[Register]
	public partial class NSPrintOperation : NSObject
	{
		public NSPrintOperation() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPrintOperation(IntPtr instance) : base(instance)
		{
		}

		public NSPrintOperation(Untyped instance) : base(instance)
		{
		}

		public static new NSPrintOperation alloc()
		{
			return new NSPrintOperation(ms_class.Call("alloc"));
		}

		public new NSPrintOperation retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSPrintOperation printOperationWithViewPrintInfo(NSView view, NSPrintInfo printInfo)
		{
			return ms_class.Call("printOperationWithView:printInfo:", view, printInfo).To<NSPrintOperation>();
		}

		public static NSPrintOperation PDFOperationWithViewInsideRectToDataPrintInfo(NSView view, NSRect rect, NSMutableData data, NSPrintInfo printInfo)
		{
			return ms_class.Call("PDFOperationWithView:insideRect:toData:printInfo:", view, rect, data, printInfo).To<NSPrintOperation>();
		}

		public static NSPrintOperation PDFOperationWithViewInsideRectToPathPrintInfo(NSView view, NSRect rect, NSString path, NSPrintInfo printInfo)
		{
			return ms_class.Call("PDFOperationWithView:insideRect:toPath:printInfo:", view, rect, path, printInfo).To<NSPrintOperation>();
		}

		public static NSPrintOperation EPSOperationWithViewInsideRectToDataPrintInfo(NSView view, NSRect rect, NSMutableData data, NSPrintInfo printInfo)
		{
			return ms_class.Call("EPSOperationWithView:insideRect:toData:printInfo:", view, rect, data, printInfo).To<NSPrintOperation>();
		}

		public static NSPrintOperation EPSOperationWithViewInsideRectToPathPrintInfo(NSView view, NSRect rect, NSString path, NSPrintInfo printInfo)
		{
			return ms_class.Call("EPSOperationWithView:insideRect:toPath:printInfo:", view, rect, path, printInfo).To<NSPrintOperation>();
		}

		public static NSPrintOperation printOperationWithView(NSView view)
		{
			return ms_class.Call("printOperationWithView:", view).To<NSPrintOperation>();
		}

		public static NSPrintOperation PDFOperationWithViewInsideRectToData(NSView view, NSRect rect, NSMutableData data)
		{
			return ms_class.Call("PDFOperationWithView:insideRect:toData:", view, rect, data).To<NSPrintOperation>();
		}

		public static NSPrintOperation EPSOperationWithViewInsideRectToData(NSView view, NSRect rect, NSMutableData data)
		{
			return ms_class.Call("EPSOperationWithView:insideRect:toData:", view, rect, data).To<NSPrintOperation>();
		}

		public static NSPrintOperation currentOperation()
		{
			return ms_class.Call("currentOperation").To<NSPrintOperation>();
		}

		public static void setCurrentOperation(NSPrintOperation operation)
		{
			Unused.Value = ms_class.Call("setCurrentOperation:", operation);
		}

		public bool isCopyingOperation()
		{
			return Call("isCopyingOperation").To<bool>();
		}

		public void setJobTitle(NSString jobTitle)
		{
			Unused.Value = Call("setJobTitle:", jobTitle);
		}

		public NSString jobTitle()
		{
			return Call("jobTitle").To<NSString>();
		}

		public void setShowsPrintPanel(bool flag)
		{
			Unused.Value = Call("setShowsPrintPanel:", flag);
		}

		public bool showsPrintPanel()
		{
			return Call("showsPrintPanel").To<bool>();
		}

		public void setShowsProgressPanel(bool flag)
		{
			Unused.Value = Call("setShowsProgressPanel:", flag);
		}

		public bool showsProgressPanel()
		{
			return Call("showsProgressPanel").To<bool>();
		}

		public void setPrintPanel(NSPrintPanel panel)
		{
			Unused.Value = Call("setPrintPanel:", panel);
		}

		public NSPrintPanel printPanel()
		{
			return Call("printPanel").To<NSPrintPanel>();
		}

		public void setCanSpawnSeparateThread(bool canSpawnSeparateThread)
		{
			Unused.Value = Call("setCanSpawnSeparateThread:", canSpawnSeparateThread);
		}

		public bool canSpawnSeparateThread()
		{
			return Call("canSpawnSeparateThread").To<bool>();
		}

		public void setPageOrder(Int32 pageOrder)
		{
			Unused.Value = Call("setPageOrder:", pageOrder);
		}

		public Int32 pageOrder()
		{
			return Call("pageOrder").To<Int32>();
		}

		public void runOperationModalForWindowDelegateDidRunSelectorContextInfo(NSWindow docWindow, NSObject delegate_, Selector didRunSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("runOperationModalForWindow:delegate:didRunSelector:contextInfo:", docWindow, delegate_, didRunSelector, contextInfo);
		}

		public bool runOperation()
		{
			return Call("runOperation").To<bool>();
		}

		public NSView view()
		{
			return Call("view").To<NSView>();
		}

		public NSPrintInfo printInfo()
		{
			return Call("printInfo").To<NSPrintInfo>();
		}

		public void setPrintInfo(NSPrintInfo printInfo)
		{
			Unused.Value = Call("setPrintInfo:", printInfo);
		}

		public NSGraphicsContext context()
		{
			return Call("context").To<NSGraphicsContext>();
		}

		public NSRange pageRange()
		{
			return Call("pageRange").To<NSRange>();
		}

		public Int32 currentPage()
		{
			return Call("currentPage").To<Int32>();
		}

		public NSGraphicsContext createContext()
		{
			return Call("createContext").To<NSGraphicsContext>();
		}

		public void destroyContext()
		{
			Unused.Value = Call("destroyContext");
		}

		public bool deliverResult()
		{
			return Call("deliverResult").To<bool>();
		}

		public void cleanUpOperation()
		{
			Unused.Value = Call("cleanUpOperation");
		}

		private static Class ms_class = new Class("NSPrintOperation");
	}

	public static class NSDeprecatedForNSPrintOperationCategory
	{
		public static void setAccessoryView(this NSPrintOperation _instance, NSView view)
		{
			Unused.Value = _instance.Call("setAccessoryView:", view);
		}

		public static NSView accessoryView(this NSPrintOperation _instance)
		{
			return _instance.Call("accessoryView").To<NSView>();
		}

		public static void setJobStyleHint(this NSPrintOperation _instance, NSString hint)
		{
			Unused.Value = _instance.Call("setJobStyleHint:", hint);
		}

		public static NSString jobStyleHint(this NSPrintOperation _instance)
		{
			return _instance.Call("jobStyleHint").To<NSString>();
		}

		public static void setShowPanels(this NSPrintOperation _instance, bool flag)
		{
			Unused.Value = _instance.Call("setShowPanels:", flag);
		}

		public static bool showPanels(this NSPrintOperation _instance)
		{
			return _instance.Call("showPanels").To<bool>();
		}
	}
}
