// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDocumentController.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSDocumentController : NSObject
	{
		public NSDocumentController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDocumentController(IntPtr instance) : base(instance)
		{
		}

		public NSDocumentController(Untyped instance) : base(instance)
		{
		}

		public static new NSDocumentController alloc()
		{
			return new NSDocumentController(ms_class.Call("alloc"));
		}

		public new NSDocumentController retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject sharedDocumentController()
		{
			return ms_class.Call("sharedDocumentController").To<NSObject>();
		}

		// skipping init (it's already defined)

		public NSArray documents()
		{
			return Call("documents").To<NSArray>();
		}

		public NSObject currentDocument()
		{
			return Call("currentDocument").To<NSObject>();
		}

		public NSString currentDirectory()
		{
			return Call("currentDirectory").To<NSString>();
		}

		public NSObject documentForURL(NSURL absoluteURL)
		{
			return Call("documentForURL:", absoluteURL).To<NSObject>();
		}

		public NSObject documentForWindow(NSWindow window)
		{
			return Call("documentForWindow:", window).To<NSObject>();
		}

		public void addDocument(NSDocument document)
		{
			Unused.Value = Call("addDocument:", document);
		}

		public void removeDocument(NSDocument document)
		{
			Unused.Value = Call("removeDocument:", document);
		}

		public void newDocument(NSObject sender)
		{
			Unused.Value = Call("newDocument:", sender);
		}

		public NSObject openUntitledDocumentAndDisplayError(bool displayDocument, IntPtr outError)
		{
			return Call("openUntitledDocumentAndDisplay:error:", displayDocument, outError).To<NSObject>();
		}

		public NSObject makeUntitledDocumentOfTypeError(NSString typeName, IntPtr outError)
		{
			return Call("makeUntitledDocumentOfType:error:", typeName, outError).To<NSObject>();
		}

		public void openDocument(NSObject sender)
		{
			Unused.Value = Call("openDocument:", sender);
		}

		public NSArray URLsFromRunningOpenPanel()
		{
			return Call("URLsFromRunningOpenPanel").To<NSArray>();
		}

		public Int32 runModalOpenPanelForTypes(NSOpenPanel openPanel, NSArray types)
		{
			return Call("runModalOpenPanel:forTypes:", openPanel, types).To<Int32>();
		}

		public NSObject openDocumentWithContentsOfURLDisplayError(NSURL absoluteURL, bool displayDocument, IntPtr outError)
		{
			return Call("openDocumentWithContentsOfURL:display:error:", absoluteURL, displayDocument, outError).To<NSObject>();
		}

		public NSObject makeDocumentWithContentsOfURLOfTypeError(NSURL absoluteURL, NSString typeName, IntPtr outError)
		{
			return Call("makeDocumentWithContentsOfURL:ofType:error:", absoluteURL, typeName, outError).To<NSObject>();
		}

		public bool reopenDocumentForURLWithContentsOfURLError(NSURL absoluteDocumentURL, NSURL absoluteDocumentContentsURL, IntPtr outError)
		{
			return Call("reopenDocumentForURL:withContentsOfURL:error:", absoluteDocumentURL, absoluteDocumentContentsURL, outError).To<bool>();
		}

		public NSObject makeDocumentForURLWithContentsOfURLOfTypeError(NSURL absoluteDocumentURL, NSURL absoluteDocumentContentsURL, NSString typeName, IntPtr outError)
		{
			return Call("makeDocumentForURL:withContentsOfURL:ofType:error:", absoluteDocumentURL, absoluteDocumentContentsURL, typeName, outError).To<NSObject>();
		}

		public void setAutosavingDelay(double autosavingDelay)
		{
			Unused.Value = Call("setAutosavingDelay:", autosavingDelay);
		}

		public double autosavingDelay()
		{
			return Call("autosavingDelay").To<double>();
		}

		public void saveAllDocuments(NSObject sender)
		{
			Unused.Value = Call("saveAllDocuments:", sender);
		}

		public bool hasEditedDocuments()
		{
			return Call("hasEditedDocuments").To<bool>();
		}

		public void reviewUnsavedDocumentsWithAlertTitleCancellableDelegateDidReviewAllSelectorContextInfo(NSString title, bool cancellable, NSObject delegate_, Selector didReviewAllSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:", title, cancellable, delegate_, didReviewAllSelector, contextInfo);
		}

		public void closeAllDocumentsWithDelegateDidCloseAllSelectorContextInfo(NSObject delegate_, Selector didCloseAllSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:", delegate_, didCloseAllSelector, contextInfo);
		}

		public void presentErrorModalForWindowDelegateDidPresentSelectorContextInfo(NSError error, NSWindow window, NSObject delegate_, Selector didPresentSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:", error, window, delegate_, didPresentSelector, contextInfo);
		}

		public bool presentError(NSError error)
		{
			return Call("presentError:", error).To<bool>();
		}

		public NSError willPresentError(NSError error)
		{
			return Call("willPresentError:", error).To<NSError>();
		}

		public UInt32 maximumRecentDocumentCount()
		{
			return Call("maximumRecentDocumentCount").To<UInt32>();
		}

		public void clearRecentDocuments(NSObject sender)
		{
			Unused.Value = Call("clearRecentDocuments:", sender);
		}

		public void noteNewRecentDocument(NSDocument document)
		{
			Unused.Value = Call("noteNewRecentDocument:", document);
		}

		public void noteNewRecentDocumentURL(NSURL absoluteURL)
		{
			Unused.Value = Call("noteNewRecentDocumentURL:", absoluteURL);
		}

		public NSArray recentDocumentURLs()
		{
			return Call("recentDocumentURLs").To<NSArray>();
		}

		public NSString defaultType()
		{
			return Call("defaultType").To<NSString>();
		}

		public NSString typeForContentsOfURLError(NSURL inAbsoluteURL, IntPtr outError)
		{
			return Call("typeForContentsOfURL:error:", inAbsoluteURL, outError).To<NSString>();
		}

		public NSArray documentClassNames()
		{
			return Call("documentClassNames").To<NSArray>();
		}

		public Class documentClassForType(NSString typeName)
		{
			return Call("documentClassForType:", typeName).To<Class>();
		}

		public NSString displayNameForType(NSString typeName)
		{
			return Call("displayNameForType:", typeName).To<NSString>();
		}

		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}

		#region NSCoding Methods
		public void encodeWithCoder(NSCoder aCoder)
		{
			Unused.Value = Call("encodeWithCoder:", aCoder);
		}

		public NSObject initWithCoder(NSCoder aDecoder)
		{
			return Call("initWithCoder:", aDecoder).To<NSObject>();
		}
		#endregion

		#region NSUserInterfaceValidations Methods
		#endregion

		private static Class ms_class = new Class("NSDocumentController");
	}

	public static class NSDeprecatedForNSDocumentControllerCategory
	{
		public static NSArray fileExtensionsFromType(this NSDocumentController _instance, NSString typeName)
		{
			return _instance.Call("fileExtensionsFromType:", typeName).To<NSArray>();
		}

		public static NSString typeFromFileExtension(this NSDocumentController _instance, NSString fileNameExtensionOrHFSFileType)
		{
			return _instance.Call("typeFromFileExtension:", fileNameExtensionOrHFSFileType).To<NSString>();
		}

		public static NSObject documentForFileName(this NSDocumentController _instance, NSString fileName)
		{
			return _instance.Call("documentForFileName:", fileName).To<NSObject>();
		}

		public static NSArray fileNamesFromRunningOpenPanel(this NSDocumentController _instance)
		{
			return _instance.Call("fileNamesFromRunningOpenPanel").To<NSArray>();
		}

		public static NSObject makeDocumentWithContentsOfFileOfType(this NSDocumentController _instance, NSString fileName, NSString type)
		{
			return _instance.Call("makeDocumentWithContentsOfFile:ofType:", fileName, type).To<NSObject>();
		}

		public static NSObject makeDocumentWithContentsOfURLOfType(this NSDocumentController _instance, NSURL url, NSString type)
		{
			return _instance.Call("makeDocumentWithContentsOfURL:ofType:", url, type).To<NSObject>();
		}

		public static NSObject makeUntitledDocumentOfType(this NSDocumentController _instance, NSString type)
		{
			return _instance.Call("makeUntitledDocumentOfType:", type).To<NSObject>();
		}

		public static NSObject openDocumentWithContentsOfFileDisplay(this NSDocumentController _instance, NSString fileName, bool display)
		{
			return _instance.Call("openDocumentWithContentsOfFile:display:", fileName, display).To<NSObject>();
		}

		public static NSObject openDocumentWithContentsOfURLDisplay(this NSDocumentController _instance, NSURL url, bool display)
		{
			return _instance.Call("openDocumentWithContentsOfURL:display:", url, display).To<NSObject>();
		}

		public static NSObject openUntitledDocumentOfTypeDisplay(this NSDocumentController _instance, NSString type, bool display)
		{
			return _instance.Call("openUntitledDocumentOfType:display:", type, display).To<NSObject>();
		}

		public static void setShouldCreateUI(this NSDocumentController _instance, bool flag)
		{
			Unused.Value = _instance.Call("setShouldCreateUI:", flag);
		}

		public static bool shouldCreateUI(this NSDocumentController _instance)
		{
			return _instance.Call("shouldCreateUI").To<bool>();
		}
	}
}
