// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSApplication.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSRunStoppedResponse = ( -1000 );
		public const int NSRunAbortedResponse = ( -1001 );
		public const int NSRunContinuesResponse = ( -1002 );
	}

	public partial class Enums
	{
		public const int NSUpdateWindowsRunLoopOrdering = 500000;
	}

	public partial class Enums
	{
		public const int NSCriticalRequest = 0;
		public const int NSInformationalRequest = 10;
	}

	public partial class Enums
	{
		public const int NSApplicationDelegateReplySuccess = 0;
		public const int NSApplicationDelegateReplyCancel = 1;
		public const int NSApplicationDelegateReplyFailure = 2;
	}

	public partial class Enums
	{
		public const int NSTerminateCancel = 0;
		public const int NSTerminateNow = 1;
		public const int NSTerminateLater = 2;
	}

	public partial class Enums
	{
		public const int NSPrintingCancelled = 0;
		public const int NSPrintingSuccess = 1;
		public const int NSPrintingFailure = 3;
		public const int NSPrintingReplyLater = 2;
	}

	[Register]
	public partial class NSApplication : NSResponder
	{
		public NSApplication() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSApplication(IntPtr instance) : base(instance)
		{
		}

		public NSApplication(Untyped instance) : base(instance)
		{
		}

		public static new NSApplication alloc()
		{
			return new NSApplication(ms_class.Call("alloc"));
		}

		public new NSApplication retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSApplication sharedApplication()
		{
			return ms_class.Call("sharedApplication").To<NSApplication>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public NSGraphicsContext context()
		{
			return Call("context").To<NSGraphicsContext>();
		}

		public void hide(NSObject sender)
		{
			Unused.Value = Call("hide:", sender);
		}

		public void unhide(NSObject sender)
		{
			Unused.Value = Call("unhide:", sender);
		}

		public void unhideWithoutActivation()
		{
			Unused.Value = Call("unhideWithoutActivation");
		}

		public NSWindow windowWithWindowNumber(Int32 windowNum)
		{
			return Call("windowWithWindowNumber:", windowNum).To<NSWindow>();
		}

		public NSWindow mainWindow()
		{
			return Call("mainWindow").To<NSWindow>();
		}

		public NSWindow keyWindow()
		{
			return Call("keyWindow").To<NSWindow>();
		}

		public bool isActive()
		{
			return Call("isActive").To<bool>();
		}

		public bool isHidden()
		{
			return Call("isHidden").To<bool>();
		}

		public bool isRunning()
		{
			return Call("isRunning").To<bool>();
		}

		public void deactivate()
		{
			Unused.Value = Call("deactivate");
		}

		public void activateIgnoringOtherApps(bool flag)
		{
			Unused.Value = Call("activateIgnoringOtherApps:", flag);
		}

		public void hideOtherApplications(NSObject sender)
		{
			Unused.Value = Call("hideOtherApplications:", sender);
		}

		public void unhideAllApplications(NSObject sender)
		{
			Unused.Value = Call("unhideAllApplications:", sender);
		}

		public void finishLaunching()
		{
			Unused.Value = Call("finishLaunching");
		}

		// skipping run because there is a hand-written version

		public Int32 runModalForWindow(NSWindow theWindow)
		{
			return Call("runModalForWindow:", theWindow).To<Int32>();
		}

		public void stop(NSObject sender)
		{
			Unused.Value = Call("stop:", sender);
		}

		public void stopModal()
		{
			Unused.Value = Call("stopModal");
		}

		public void stopModalWithCode(Int32 returnCode)
		{
			Unused.Value = Call("stopModalWithCode:", returnCode);
		}

		public void abortModal()
		{
			Unused.Value = Call("abortModal");
		}

		public NSWindow modalWindow()
		{
			return Call("modalWindow").To<NSWindow>();
		}

		public IntPtr beginModalSessionForWindow(NSWindow theWindow)
		{
			return Call("beginModalSessionForWindow:", theWindow).To<IntPtr>();
		}

		public Int32 runModalSession(IntPtr session)
		{
			return Call("runModalSession:", session).To<Int32>();
		}

		public void endModalSession(IntPtr session)
		{
			Unused.Value = Call("endModalSession:", session);
		}

		public void terminate(NSObject sender)
		{
			Unused.Value = Call("terminate:", sender);
		}

		public Int32 requestUserAttention(UInt32 requestType)
		{
			return Call("requestUserAttention:", requestType).To<Int32>();
		}

		public void cancelUserAttentionRequest(Int32 request)
		{
			Unused.Value = Call("cancelUserAttentionRequest:", request);
		}

		public void beginSheetModalForWindowModalDelegateDidEndSelectorContextInfo(NSWindow sheet, NSWindow docWindow, NSObject modalDelegate, Selector didEndSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("beginSheet:modalForWindow:modalDelegate:didEndSelector:contextInfo:", sheet, docWindow, modalDelegate, didEndSelector, contextInfo);
		}

		public void endSheet(NSWindow sheet)
		{
			Unused.Value = Call("endSheet:", sheet);
		}

		public void endSheetReturnCode(NSWindow sheet, Int32 returnCode)
		{
			Unused.Value = Call("endSheet:returnCode:", sheet, returnCode);
		}

		public Int32 runModalForWindowRelativeToWindow(NSWindow theWindow, NSWindow docWindow)
		{
			return Call("runModalForWindow:relativeToWindow:", theWindow, docWindow).To<Int32>();
		}

		public IntPtr beginModalSessionForWindowRelativeToWindow(NSWindow theWindow, NSWindow docWindow)
		{
			return Call("beginModalSessionForWindow:relativeToWindow:", theWindow, docWindow).To<IntPtr>();
		}

		public NSEvent nextEventMatchingMaskUntilDateInModeDequeue(UInt32 mask, NSDate expiration, NSString mode, bool deqFlag)
		{
			return Call("nextEventMatchingMask:untilDate:inMode:dequeue:", mask, expiration, mode, deqFlag).To<NSEvent>();
		}

		public void discardEventsMatchingMaskBeforeEvent(UInt32 mask, NSEvent lastEvent)
		{
			Unused.Value = Call("discardEventsMatchingMask:beforeEvent:", mask, lastEvent);
		}

		public void postEventAtStart(NSEvent event_, bool flag)
		{
			Unused.Value = Call("postEvent:atStart:", event_, flag);
		}

		public NSEvent currentEvent()
		{
			return Call("currentEvent").To<NSEvent>();
		}

		public void sendEvent(NSEvent theEvent)
		{
			Unused.Value = Call("sendEvent:", theEvent);
		}

		public void preventWindowOrdering()
		{
			Unused.Value = Call("preventWindowOrdering");
		}

		public NSWindow makeWindowsPerformInOrder(Selector aSelector, bool flag)
		{
			return Call("makeWindowsPerform:inOrder:", aSelector, flag).To<NSWindow>();
		}

		// skipping windows because there is a hand-written version

		public void setWindowsNeedUpdate(bool needUpdate)
		{
			Unused.Value = Call("setWindowsNeedUpdate:", needUpdate);
		}

		public void updateWindows()
		{
			Unused.Value = Call("updateWindows");
		}

		public void setMainMenu(NSMenu aMenu)
		{
			Unused.Value = Call("setMainMenu:", aMenu);
		}

		public NSMenu mainMenu()
		{
			return Call("mainMenu").To<NSMenu>();
		}

		public void setApplicationIconImage(NSImage image)
		{
			Unused.Value = Call("setApplicationIconImage:", image);
		}

		public NSImage applicationIconImage()
		{
			return Call("applicationIconImage").To<NSImage>();
		}

		public NSDockTile dockTile()
		{
			return Call("dockTile").To<NSDockTile>();
		}

		public bool sendActionToFrom(Selector theAction, NSObject theTarget, NSObject sender)
		{
			return Call("sendAction:to:from:", theAction, theTarget, sender).To<bool>();
		}

		public NSObject targetForAction(Selector theAction)
		{
			return Call("targetForAction:", theAction).To<NSObject>();
		}

		public NSObject targetForActionToFrom(Selector theAction, NSObject theTarget, NSObject sender)
		{
			return Call("targetForAction:to:from:", theAction, theTarget, sender).To<NSObject>();
		}

		// skipping tryToPerform:with: (it's declared in a base class)

		// skipping validRequestorForSendType:returnType: (it's declared in a base class)

		public void reportException(NSException theException)
		{
			Unused.Value = Call("reportException:", theException);
		}

		public static void detachDrawingThreadToTargetWithObject(Selector selector, NSObject target, NSObject argument)
		{
			Unused.Value = ms_class.Call("detachDrawingThread:toTarget:withObject:", selector, target, argument);
		}

		public void replyToApplicationShouldTerminate(bool shouldTerminate)
		{
			Unused.Value = Call("replyToApplicationShouldTerminate:", shouldTerminate);
		}

		public void replyToOpenOrPrint(UInt32 reply)
		{
			Unused.Value = Call("replyToOpenOrPrint:", reply);
		}

		public void orderFrontCharacterPalette(NSObject sender)
		{
			Unused.Value = Call("orderFrontCharacterPalette:", sender);
		}

		#region NSUserInterfaceValidations Methods
		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}
		#endregion

		private static Class ms_class = new Class("NSApplication");
	}

	public static class NSWindowsMenuForNSApplicationCategory
	{
		public static void setWindowsMenu(this NSApplication _instance, NSMenu aMenu)
		{
			Unused.Value = _instance.Call("setWindowsMenu:", aMenu);
		}

		public static NSMenu windowsMenu(this NSApplication _instance)
		{
			return _instance.Call("windowsMenu").To<NSMenu>();
		}

		public static void arrangeInFront(this NSApplication _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("arrangeInFront:", sender);
		}

		public static void removeWindowsItem(this NSApplication _instance, NSWindow win)
		{
			Unused.Value = _instance.Call("removeWindowsItem:", win);
		}

		public static void addWindowsItemTitleFilename(this NSApplication _instance, NSWindow win, NSString aString, bool isFilename)
		{
			Unused.Value = _instance.Call("addWindowsItem:title:filename:", win, aString, isFilename);
		}

		public static void changeWindowsItemTitleFilename(this NSApplication _instance, NSWindow win, NSString aString, bool isFilename)
		{
			Unused.Value = _instance.Call("changeWindowsItem:title:filename:", win, aString, isFilename);
		}

		public static void updateWindowsItem(this NSApplication _instance, NSWindow win)
		{
			Unused.Value = _instance.Call("updateWindowsItem:", win);
		}

		public static void miniaturizeAll(this NSApplication _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("miniaturizeAll:", sender);
		}
	}

	public static class NSApplicationNotificationsForNSObjectCategory
	{
		public static void applicationWillFinishLaunching(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationWillFinishLaunching:", notification);
		}

		public static void applicationDidFinishLaunching(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationDidFinishLaunching:", notification);
		}

		public static void applicationWillHide(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationWillHide:", notification);
		}

		public static void applicationDidHide(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationDidHide:", notification);
		}

		public static void applicationWillUnhide(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationWillUnhide:", notification);
		}

		public static void applicationDidUnhide(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationDidUnhide:", notification);
		}

		public static void applicationWillBecomeActive(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationWillBecomeActive:", notification);
		}

		public static void applicationDidBecomeActive(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationDidBecomeActive:", notification);
		}

		public static void applicationWillResignActive(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationWillResignActive:", notification);
		}

		public static void applicationDidResignActive(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationDidResignActive:", notification);
		}

		public static void applicationWillUpdate(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationWillUpdate:", notification);
		}

		public static void applicationDidUpdate(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationDidUpdate:", notification);
		}

		public static void applicationWillTerminate(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationWillTerminate:", notification);
		}

		public static void applicationDidChangeScreenParameters(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("applicationDidChangeScreenParameters:", notification);
		}
	}

	public static class NSApplicationDelegateForNSObjectCategory
	{
		public static UInt32 applicationShouldTerminate(this NSObject _instance, NSApplication sender)
		{
			return _instance.Call("applicationShouldTerminate:", sender).To<UInt32>();
		}

		public static bool applicationOpenFile(this NSObject _instance, NSApplication sender, NSString filename)
		{
			return _instance.Call("application:openFile:", sender, filename).To<bool>();
		}

		public static void applicationOpenFiles(this NSObject _instance, NSApplication sender, NSArray filenames)
		{
			Unused.Value = _instance.Call("application:openFiles:", sender, filenames);
		}

		public static bool applicationOpenTempFile(this NSObject _instance, NSApplication sender, NSString filename)
		{
			return _instance.Call("application:openTempFile:", sender, filename).To<bool>();
		}

		public static bool applicationShouldOpenUntitledFile(this NSObject _instance, NSApplication sender)
		{
			return _instance.Call("applicationShouldOpenUntitledFile:", sender).To<bool>();
		}

		public static bool applicationOpenUntitledFile(this NSObject _instance, NSApplication sender)
		{
			return _instance.Call("applicationOpenUntitledFile:", sender).To<bool>();
		}

		public static bool applicationOpenFileWithoutUI(this NSObject _instance, NSObject sender, NSString filename)
		{
			return _instance.Call("application:openFileWithoutUI:", sender, filename).To<bool>();
		}

		public static bool applicationPrintFile(this NSObject _instance, NSApplication sender, NSString filename)
		{
			return _instance.Call("application:printFile:", sender, filename).To<bool>();
		}

		public static UInt32 applicationPrintFilesWithSettingsShowPrintPanels(this NSObject _instance, NSApplication application, NSArray fileNames, NSDictionary printSettings, bool showPrintPanels)
		{
			return _instance.Call("application:printFiles:withSettings:showPrintPanels:", application, fileNames, printSettings, showPrintPanels).To<UInt32>();
		}

		public static void applicationPrintFiles(this NSObject _instance, NSApplication sender, NSArray filenames)
		{
			Unused.Value = _instance.Call("application:printFiles:", sender, filenames);
		}

		public static bool applicationShouldTerminateAfterLastWindowClosed(this NSObject _instance, NSApplication sender)
		{
			return _instance.Call("applicationShouldTerminateAfterLastWindowClosed:", sender).To<bool>();
		}

		public static bool applicationShouldHandleReopenHasVisibleWindows(this NSObject _instance, NSApplication sender, bool flag)
		{
			return _instance.Call("applicationShouldHandleReopen:hasVisibleWindows:", sender, flag).To<bool>();
		}

		public static NSMenu applicationDockMenu(this NSObject _instance, NSApplication sender)
		{
			return _instance.Call("applicationDockMenu:", sender).To<NSMenu>();
		}

		public static NSError applicationWillPresentError(this NSObject _instance, NSApplication application, NSError error)
		{
			return _instance.Call("application:willPresentError:", application, error).To<NSError>();
		}
	}

	public static class NSServicesMenuForNSApplicationCategory
	{
		public static void setServicesMenu(this NSApplication _instance, NSMenu aMenu)
		{
			Unused.Value = _instance.Call("setServicesMenu:", aMenu);
		}

		public static NSMenu servicesMenu(this NSApplication _instance)
		{
			return _instance.Call("servicesMenu").To<NSMenu>();
		}

		public static void registerServicesMenuSendTypesReturnTypes(this NSApplication _instance, NSArray sendTypes, NSArray returnTypes)
		{
			Unused.Value = _instance.Call("registerServicesMenuSendTypes:returnTypes:", sendTypes, returnTypes);
		}
	}

	public static class NSServicesRequestsForNSObjectCategory
	{
		public static bool writeSelectionToPasteboardTypes(this NSObject _instance, NSPasteboard pboard, NSArray types)
		{
			return _instance.Call("writeSelectionToPasteboard:types:", pboard, types).To<bool>();
		}

		public static bool readSelectionFromPasteboard(this NSObject _instance, NSPasteboard pboard)
		{
			return _instance.Call("readSelectionFromPasteboard:", pboard).To<bool>();
		}
	}

	public static class NSServicesHandlingForNSApplicationCategory
	{
		public static void setServicesProvider(this NSApplication _instance, NSObject provider)
		{
			Unused.Value = _instance.Call("setServicesProvider:", provider);
		}

		public static NSObject servicesProvider(this NSApplication _instance)
		{
			return _instance.Call("servicesProvider").To<NSObject>();
		}
	}

	public static class NSStandardAboutPanelForNSApplicationCategory
	{
		public static void orderFrontStandardAboutPanel(this NSApplication _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("orderFrontStandardAboutPanel:", sender);
		}

		public static void orderFrontStandardAboutPanelWithOptions(this NSApplication _instance, NSDictionary optionsDictionary)
		{
			Unused.Value = _instance.Call("orderFrontStandardAboutPanelWithOptions:", optionsDictionary);
		}
	}
}
