// machine generated on 10/24/2008 3:54:08 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSWindowController.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSWindowController : NSResponder
	{
		public NSWindowController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSWindowController(IntPtr instance) : base(instance)
		{
		}

		public NSWindowController(Untyped instance) : base(instance)
		{
		}

		public static new NSWindowController alloc()
		{
			return new NSWindowController(ms_class.Call("alloc"));
		}

		public new NSWindowController retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithWindow(NSWindow window)
		{
			return Call("initWithWindow:", window).To<NSObject>();
		}

		public NSObject initWithWindowNibName(NSString windowNibName)
		{
			return Call("initWithWindowNibName:", windowNibName).To<NSObject>();
		}

		public NSObject initWithWindowNibNameOwner(NSString windowNibName, NSObject owner)
		{
			return Call("initWithWindowNibName:owner:", windowNibName, owner).To<NSObject>();
		}

		public NSObject initWithWindowNibPathOwner(NSString windowNibPath, NSObject owner)
		{
			return Call("initWithWindowNibPath:owner:", windowNibPath, owner).To<NSObject>();
		}

		public NSString windowNibName()
		{
			return Call("windowNibName").To<NSString>();
		}

		public NSString windowNibPath()
		{
			return Call("windowNibPath").To<NSString>();
		}

		public NSObject owner()
		{
			return Call("owner").To<NSObject>();
		}

		public void setWindowFrameAutosaveName(NSString name)
		{
			Unused.Value = Call("setWindowFrameAutosaveName:", name);
		}

		public NSString windowFrameAutosaveName()
		{
			return Call("windowFrameAutosaveName").To<NSString>();
		}

		public void setShouldCascadeWindows(bool flag)
		{
			Unused.Value = Call("setShouldCascadeWindows:", flag);
		}

		public bool shouldCascadeWindows()
		{
			return Call("shouldCascadeWindows").To<bool>();
		}

		public NSObject document()
		{
			return Call("document").To<NSObject>();
		}

		public void setDocument(NSDocument document)
		{
			Unused.Value = Call("setDocument:", document);
		}

		public void setDocumentEdited(bool dirtyFlag)
		{
			Unused.Value = Call("setDocumentEdited:", dirtyFlag);
		}

		public void setShouldCloseDocument(bool flag)
		{
			Unused.Value = Call("setShouldCloseDocument:", flag);
		}

		public bool shouldCloseDocument()
		{
			return Call("shouldCloseDocument").To<bool>();
		}

		public void setWindow(NSWindow window)
		{
			Unused.Value = Call("setWindow:", window);
		}

		public NSWindow window()
		{
			return Call("window").To<NSWindow>();
		}

		public void synchronizeWindowTitleWithDocumentName()
		{
			Unused.Value = Call("synchronizeWindowTitleWithDocumentName");
		}

		public NSString windowTitleForDocumentDisplayName(NSString displayName)
		{
			return Call("windowTitleForDocumentDisplayName:", displayName).To<NSString>();
		}

		public void close()
		{
			Unused.Value = Call("close");
		}

		public void showWindow(NSObject sender)
		{
			Unused.Value = Call("showWindow:", sender);
		}

		public bool isWindowLoaded()
		{
			return Call("isWindowLoaded").To<bool>();
		}

		public void windowWillLoad()
		{
			Unused.Value = Call("windowWillLoad");
		}

		public void windowDidLoad()
		{
			Unused.Value = Call("windowDidLoad");
		}

		public void loadWindow()
		{
			Unused.Value = Call("loadWindow");
		}

		private static Class ms_class = new Class("NSWindowController");
	}
}
