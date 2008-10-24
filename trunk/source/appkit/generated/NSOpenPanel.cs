// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSOpenPanel.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSOpenPanel : NSSavePanel
	{
		public NSOpenPanel() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOpenPanel(IntPtr instance) : base(instance)
		{
		}

		public NSOpenPanel(Untyped instance) : base(instance)
		{
		}

		public static new NSOpenPanel alloc()
		{
			return new NSOpenPanel(ms_class.Call("alloc"));
		}

		public new NSOpenPanel retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSOpenPanel openPanel()
		{
			return ms_class.Call("openPanel").To<NSOpenPanel>();
		}

		public NSArray URLs()
		{
			return Call("URLs").To<NSArray>();
		}

		public NSArray filenames()
		{
			return Call("filenames").To<NSArray>();
		}

		public bool resolvesAliases()
		{
			return Call("resolvesAliases").To<bool>();
		}

		public void setResolvesAliases(bool flag)
		{
			Unused.Value = Call("setResolvesAliases:", flag);
		}

		public bool canChooseDirectories()
		{
			return Call("canChooseDirectories").To<bool>();
		}

		public void setCanChooseDirectories(bool flag)
		{
			Unused.Value = Call("setCanChooseDirectories:", flag);
		}

		public bool allowsMultipleSelection()
		{
			return Call("allowsMultipleSelection").To<bool>();
		}

		public void setAllowsMultipleSelection(bool flag)
		{
			Unused.Value = Call("setAllowsMultipleSelection:", flag);
		}

		public bool canChooseFiles()
		{
			return Call("canChooseFiles").To<bool>();
		}

		public void setCanChooseFiles(bool flag)
		{
			Unused.Value = Call("setCanChooseFiles:", flag);
		}

		private static Class ms_class = new Class("NSOpenPanel");
	}

	public static class NSOpenPanelRuntimeForNSOpenPanelCategory
	{
		public static void beginSheetForDirectoryFileTypesModalForWindowModalDelegateDidEndSelectorContextInfo(this NSOpenPanel _instance, NSString path, NSString name, NSArray fileTypes, NSWindow docWindow, NSObject delegate_, Selector didEndSelector, IntPtr contextInfo)
		{
			Unused.Value = _instance.Call("beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:", path, name, fileTypes, docWindow, delegate_, didEndSelector, contextInfo);
		}

		public static void beginForDirectoryFileTypesModelessDelegateDidEndSelectorContextInfo(this NSOpenPanel _instance, NSString path, NSString name, NSArray fileTypes, NSObject delegate_, Selector didEndSelector, IntPtr contextInfo)
		{
			Unused.Value = _instance.Call("beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:", path, name, fileTypes, delegate_, didEndSelector, contextInfo);
		}

		public static Int32 runModalForDirectoryFileTypes(this NSOpenPanel _instance, NSString path, NSString name, NSArray fileTypes)
		{
			return _instance.Call("runModalForDirectory:file:types:", path, name, fileTypes).To<Int32>();
		}

		public static Int32 runModalForTypes(this NSOpenPanel _instance, NSArray fileTypes)
		{
			return _instance.Call("runModalForTypes:", fileTypes).To<Int32>();
		}
	}
}
