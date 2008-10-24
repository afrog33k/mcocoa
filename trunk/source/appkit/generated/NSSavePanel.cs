// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSavePanel.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSFileHandlingPanelCancelButton = NSCancelButton;
		public const int NSFileHandlingPanelOKButton = NSOKButton;
	}

	[Register]
	public partial class NSSavePanel : NSPanel
	{
		public NSSavePanel() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSavePanel(IntPtr instance) : base(instance)
		{
		}

		public NSSavePanel(Untyped instance) : base(instance)
		{
		}

		public static new NSSavePanel alloc()
		{
			return new NSSavePanel(ms_class.Call("alloc"));
		}

		public new NSSavePanel retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSSavePanel savePanel()
		{
			return ms_class.Call("savePanel").To<NSSavePanel>();
		}

		public NSURL URL()
		{
			return Call("URL").To<NSURL>();
		}

		public NSString filename()
		{
			return Call("filename").To<NSString>();
		}

		public NSString directory()
		{
			return Call("directory").To<NSString>();
		}

		public void setDirectory(NSString path)
		{
			Unused.Value = Call("setDirectory:", path);
		}

		public NSString requiredFileType()
		{
			return Call("requiredFileType").To<NSString>();
		}

		public void setRequiredFileType(NSString type)
		{
			Unused.Value = Call("setRequiredFileType:", type);
		}

		public NSArray allowedFileTypes()
		{
			return Call("allowedFileTypes").To<NSArray>();
		}

		public void setAllowedFileTypes(NSArray types)
		{
			Unused.Value = Call("setAllowedFileTypes:", types);
		}

		public bool allowsOtherFileTypes()
		{
			return Call("allowsOtherFileTypes").To<bool>();
		}

		public void setAllowsOtherFileTypes(bool flag)
		{
			Unused.Value = Call("setAllowsOtherFileTypes:", flag);
		}

		public NSView accessoryView()
		{
			return Call("accessoryView").To<NSView>();
		}

		public void setAccessoryView(NSView view)
		{
			Unused.Value = Call("setAccessoryView:", view);
		}

		// skipping delegate (it's declared in a base class)

		// skipping setDelegate: (it's declared in a base class)

		public bool isExpanded()
		{
			return Call("isExpanded").To<bool>();
		}

		public bool canCreateDirectories()
		{
			return Call("canCreateDirectories").To<bool>();
		}

		public void setCanCreateDirectories(bool flag)
		{
			Unused.Value = Call("setCanCreateDirectories:", flag);
		}

		public bool canSelectHiddenExtension()
		{
			return Call("canSelectHiddenExtension").To<bool>();
		}

		public void setCanSelectHiddenExtension(bool flag)
		{
			Unused.Value = Call("setCanSelectHiddenExtension:", flag);
		}

		public bool isExtensionHidden()
		{
			return Call("isExtensionHidden").To<bool>();
		}

		public void setExtensionHidden(bool flag)
		{
			Unused.Value = Call("setExtensionHidden:", flag);
		}

		public bool treatsFilePackagesAsDirectories()
		{
			return Call("treatsFilePackagesAsDirectories").To<bool>();
		}

		public void setTreatsFilePackagesAsDirectories(bool flag)
		{
			Unused.Value = Call("setTreatsFilePackagesAsDirectories:", flag);
		}

		public NSString prompt()
		{
			return Call("prompt").To<NSString>();
		}

		public void setPrompt(NSString prompt)
		{
			Unused.Value = Call("setPrompt:", prompt);
		}

		// skipping title (it's declared in a base class)

		// skipping setTitle: (it's declared in a base class)

		public NSString nameFieldLabel()
		{
			return Call("nameFieldLabel").To<NSString>();
		}

		public void setNameFieldLabel(NSString label)
		{
			Unused.Value = Call("setNameFieldLabel:", label);
		}

		public NSString message()
		{
			return Call("message").To<NSString>();
		}

		public void setMessage(NSString message)
		{
			Unused.Value = Call("setMessage:", message);
		}

		public void validateVisibleColumns()
		{
			Unused.Value = Call("validateVisibleColumns");
		}

		public void selectText(NSObject sender)
		{
			Unused.Value = Call("selectText:", sender);
		}

		private static Class ms_class = new Class("NSSavePanel");
	}

	public static class NSSavePanelRuntimeForNSSavePanelCategory
	{
		public static void ok(this NSSavePanel _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("ok:", sender);
		}

		public static void cancel(this NSSavePanel _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("cancel:", sender);
		}

		public static void beginSheetForDirectoryFileModalForWindowModalDelegateDidEndSelectorContextInfo(this NSSavePanel _instance, NSString path, NSString name, NSWindow docWindow, NSObject delegate_, Selector didEndSelector, IntPtr contextInfo)
		{
			Unused.Value = _instance.Call("beginSheetForDirectory:file:modalForWindow:modalDelegate:didEndSelector:contextInfo:", path, name, docWindow, delegate_, didEndSelector, contextInfo);
		}

		public static Int32 runModalForDirectoryFile(this NSSavePanel _instance, NSString path, NSString name)
		{
			return _instance.Call("runModalForDirectory:file:", path, name).To<Int32>();
		}

		public static Int32 runModal(this NSSavePanel _instance)
		{
			return _instance.Call("runModal").To<Int32>();
		}
	}

	public static class NSSavePanelDelegateForNSObjectCategory
	{
		public static bool panelShouldShowFilename(this NSObject _instance, NSObject sender, NSString filename)
		{
			return _instance.Call("panel:shouldShowFilename:", sender, filename).To<bool>();
		}

		public static Int32 panelCompareFilenameWithCaseSensitive(this NSObject _instance, NSObject sender, NSString name1, NSString name2, bool caseSensitive)
		{
			return _instance.Call("panel:compareFilename:with:caseSensitive:", sender, name1, name2, caseSensitive).To<Int32>();
		}

		public static bool panelIsValidFilename(this NSObject _instance, NSObject sender, NSString filename)
		{
			return _instance.Call("panel:isValidFilename:", sender, filename).To<bool>();
		}

		public static NSString panelUserEnteredFilenameConfirmed(this NSObject _instance, NSObject sender, NSString filename, bool okFlag)
		{
			return _instance.Call("panel:userEnteredFilename:confirmed:", sender, filename, okFlag).To<NSString>();
		}

		public static void panelWillExpand(this NSObject _instance, NSObject sender, bool expanding)
		{
			Unused.Value = _instance.Call("panel:willExpand:", sender, expanding);
		}

		public static void panelDirectoryDidChange(this NSObject _instance, NSObject sender, NSString path)
		{
			Unused.Value = _instance.Call("panel:directoryDidChange:", sender, path);
		}

		public static void panelSelectionDidChange(this NSObject _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("panelSelectionDidChange:", sender);
		}
	}
}
