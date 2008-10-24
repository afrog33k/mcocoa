// machine generated on 10/24/2008 3:54:08 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSWindowScripting.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSScriptingForNSWindowCategory
	{
		public static bool hasCloseBox(this NSWindow _instance)
		{
			return _instance.Call("hasCloseBox").To<bool>();
		}

		public static bool hasTitleBar(this NSWindow _instance)
		{
			return _instance.Call("hasTitleBar").To<bool>();
		}

		public static bool isFloatingPanel(this NSWindow _instance)
		{
			return _instance.Call("isFloatingPanel").To<bool>();
		}

		public static bool isMiniaturizable(this NSWindow _instance)
		{
			return _instance.Call("isMiniaturizable").To<bool>();
		}

		public static bool isModalPanel(this NSWindow _instance)
		{
			return _instance.Call("isModalPanel").To<bool>();
		}

		public static bool isResizable(this NSWindow _instance)
		{
			return _instance.Call("isResizable").To<bool>();
		}

		public static bool isZoomable(this NSWindow _instance)
		{
			return _instance.Call("isZoomable").To<bool>();
		}

		public static Int32 orderedIndex(this NSWindow _instance)
		{
			return _instance.Call("orderedIndex").To<Int32>();
		}

		public static void setIsMiniaturized(this NSWindow _instance, bool flag)
		{
			Unused.Value = _instance.Call("setIsMiniaturized:", flag);
		}

		public static void setIsVisible(this NSWindow _instance, bool flag)
		{
			Unused.Value = _instance.Call("setIsVisible:", flag);
		}

		public static void setIsZoomed(this NSWindow _instance, bool flag)
		{
			Unused.Value = _instance.Call("setIsZoomed:", flag);
		}

		public static void setOrderedIndex(this NSWindow _instance, Int32 index)
		{
			Unused.Value = _instance.Call("setOrderedIndex:", index);
		}

		public static NSObject handleCloseScriptCommand(this NSWindow _instance, NSCloseCommand command)
		{
			return _instance.Call("handleCloseScriptCommand:", command).To<NSObject>();
		}

		public static NSObject handlePrintScriptCommand(this NSWindow _instance, NSScriptCommand command)
		{
			return _instance.Call("handlePrintScriptCommand:", command).To<NSObject>();
		}

		public static NSObject handleSaveScriptCommand(this NSWindow _instance, NSScriptCommand command)
		{
			return _instance.Call("handleSaveScriptCommand:", command).To<NSObject>();
		}
	}
}
