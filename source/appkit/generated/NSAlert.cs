// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSAlert.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSWarningAlertStyle = 0;
		public const int NSInformationalAlertStyle = 1;
		public const int NSCriticalAlertStyle = 2;
	}

	public partial class Enums
	{
		public const int NSAlertFirstButtonReturn = 1000;
		public const int NSAlertSecondButtonReturn = 1001;
		public const int NSAlertThirdButtonReturn = 1002;
	}

	[Register]
	public partial class NSAlert : NSObject
	{
		public NSAlert() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAlert(IntPtr instance) : base(instance)
		{
		}

		public NSAlert(Untyped instance) : base(instance)
		{
		}

		public static new NSAlert alloc()
		{
			return new NSAlert(ms_class.Call("alloc"));
		}

		public new NSAlert retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSAlert alertWithError(NSError error)
		{
			return ms_class.Call("alertWithError:", error).To<NSAlert>();
		}

		// skipping alertWithMessageText:defaultButton:alternateButton:otherButton:informativeTextWithFormat: because it is variadic

		public void setMessageText(NSString messageText)
		{
			Unused.Value = Call("setMessageText:", messageText);
		}

		public void setInformativeText(NSString informativeText)
		{
			Unused.Value = Call("setInformativeText:", informativeText);
		}

		public NSString messageText()
		{
			return Call("messageText").To<NSString>();
		}

		public NSString informativeText()
		{
			return Call("informativeText").To<NSString>();
		}

		public void setIcon(NSImage icon)
		{
			Unused.Value = Call("setIcon:", icon);
		}

		public NSImage icon()
		{
			return Call("icon").To<NSImage>();
		}

		public NSButton addButtonWithTitle(NSString title)
		{
			return Call("addButtonWithTitle:", title).To<NSButton>();
		}

		public NSArray buttons()
		{
			return Call("buttons").To<NSArray>();
		}

		public void setShowsHelp(bool showsHelp)
		{
			Unused.Value = Call("setShowsHelp:", showsHelp);
		}

		public bool showsHelp()
		{
			return Call("showsHelp").To<bool>();
		}

		public void setHelpAnchor(NSString anchor)
		{
			Unused.Value = Call("setHelpAnchor:", anchor);
		}

		public NSString helpAnchor()
		{
			return Call("helpAnchor").To<NSString>();
		}

		public void setAlertStyle(UInt32 style)
		{
			Unused.Value = Call("setAlertStyle:", style);
		}

		public UInt32 alertStyle()
		{
			return Call("alertStyle").To<UInt32>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setShowsSuppressionButton(bool flag)
		{
			Unused.Value = Call("setShowsSuppressionButton:", flag);
		}

		public bool showsSuppressionButton()
		{
			return Call("showsSuppressionButton").To<bool>();
		}

		public NSButton suppressionButton()
		{
			return Call("suppressionButton").To<NSButton>();
		}

		public void setAccessoryView(NSView view)
		{
			Unused.Value = Call("setAccessoryView:", view);
		}

		public NSView accessoryView()
		{
			return Call("accessoryView").To<NSView>();
		}

		public void layout()
		{
			Unused.Value = Call("layout");
		}

		public Int32 runModal()
		{
			return Call("runModal").To<Int32>();
		}

		public void beginSheetModalForWindowModalDelegateDidEndSelectorContextInfo(NSWindow window, NSObject delegate_, Selector didEndSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("beginSheetModalForWindow:modalDelegate:didEndSelector:contextInfo:", window, delegate_, didEndSelector, contextInfo);
		}

		public NSObject window()
		{
			return Call("window").To<NSObject>();
		}

		private static Class ms_class = new Class("NSAlert");
	}

	public static class NSAlertDelegateForNSObjectCategory
	{
		public static bool alertShowHelp(this NSObject _instance, NSAlert alert)
		{
			return _instance.Call("alertShowHelp:", alert).To<bool>();
		}
	}
}
