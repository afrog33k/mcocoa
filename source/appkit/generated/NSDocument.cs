// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDocument.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSChangeDone = 0;
		public const int NSChangeUndone = 1;
		public const int NSChangeCleared = 2;
		public const int NSChangeRedone = 5;
		public const int NSChangeReadOtherContents = 3;
		public const int NSChangeAutosaved = 4;
	}

	public partial class Enums
	{
		public const int NSSaveOperation = 0;
		public const int NSSaveAsOperation = 1;
		public const int NSSaveToOperation = 2;
		public const int NSAutosaveOperation = 3;
	}

	[Register]
	public partial class NSDocument : NSObject
	{
		public NSDocument() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDocument(IntPtr instance) : base(instance)
		{
		}

		public NSDocument(Untyped instance) : base(instance)
		{
		}

		public static new NSDocument alloc()
		{
			return new NSDocument(ms_class.Call("alloc"));
		}

		public new NSDocument retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public NSObject initWithTypeError(NSString typeName, IntPtr outError)
		{
			return Call("initWithType:error:", typeName, outError).To<NSObject>();
		}

		public NSObject initWithContentsOfURLOfTypeError(NSURL absoluteURL, NSString typeName, IntPtr outError)
		{
			return Call("initWithContentsOfURL:ofType:error:", absoluteURL, typeName, outError).To<NSObject>();
		}

		public NSObject initForURLWithContentsOfURLOfTypeError(NSURL absoluteDocumentURL, NSURL absoluteDocumentContentsURL, NSString typeName, IntPtr outError)
		{
			return Call("initForURL:withContentsOfURL:ofType:error:", absoluteDocumentURL, absoluteDocumentContentsURL, typeName, outError).To<NSObject>();
		}

		public void setFileType(NSString typeName)
		{
			Unused.Value = Call("setFileType:", typeName);
		}

		public NSString fileType()
		{
			return Call("fileType").To<NSString>();
		}

		public void setFileURL(NSURL absoluteURL)
		{
			Unused.Value = Call("setFileURL:", absoluteURL);
		}

		public NSURL fileURL()
		{
			return Call("fileURL").To<NSURL>();
		}

		public void setFileModificationDate(NSDate modificationDate)
		{
			Unused.Value = Call("setFileModificationDate:", modificationDate);
		}

		public NSDate fileModificationDate()
		{
			return Call("fileModificationDate").To<NSDate>();
		}

		public void revertDocumentToSaved(NSObject sender)
		{
			Unused.Value = Call("revertDocumentToSaved:", sender);
		}

		public bool revertToContentsOfURLOfTypeError(NSURL absoluteURL, NSString typeName, IntPtr outError)
		{
			return Call("revertToContentsOfURL:ofType:error:", absoluteURL, typeName, outError).To<bool>();
		}

		public bool readFromURLOfTypeError(NSURL absoluteURL, NSString typeName, IntPtr outError)
		{
			return Call("readFromURL:ofType:error:", absoluteURL, typeName, outError).To<bool>();
		}

		public bool readFromFileWrapperOfTypeError(NSFileWrapper fileWrapper, NSString typeName, IntPtr outError)
		{
			return Call("readFromFileWrapper:ofType:error:", fileWrapper, typeName, outError).To<bool>();
		}

		public bool readFromDataOfTypeError(NSData data, NSString typeName, IntPtr outError)
		{
			return Call("readFromData:ofType:error:", data, typeName, outError).To<bool>();
		}

		public bool writeToURLOfTypeError(NSURL absoluteURL, NSString typeName, IntPtr outError)
		{
			return Call("writeToURL:ofType:error:", absoluteURL, typeName, outError).To<bool>();
		}

		public NSFileWrapper fileWrapperOfTypeError(NSString typeName, IntPtr outError)
		{
			return Call("fileWrapperOfType:error:", typeName, outError).To<NSFileWrapper>();
		}

		public NSData dataOfTypeError(NSString typeName, IntPtr outError)
		{
			return Call("dataOfType:error:", typeName, outError).To<NSData>();
		}

		public bool writeSafelyToURLOfTypeForSaveOperationError(NSURL absoluteURL, NSString typeName, UInt32 saveOperation, IntPtr outError)
		{
			return Call("writeSafelyToURL:ofType:forSaveOperation:error:", absoluteURL, typeName, saveOperation, outError).To<bool>();
		}

		public bool writeToURLOfTypeForSaveOperationOriginalContentsURLError(NSURL absoluteURL, NSString typeName, UInt32 saveOperation, NSURL absoluteOriginalContentsURL, IntPtr outError)
		{
			return Call("writeToURL:ofType:forSaveOperation:originalContentsURL:error:", absoluteURL, typeName, saveOperation, absoluteOriginalContentsURL, outError).To<bool>();
		}

		public NSDictionary fileAttributesToWriteToURLOfTypeForSaveOperationOriginalContentsURLError(NSURL absoluteURL, NSString typeName, UInt32 saveOperation, NSURL absoluteOriginalContentsURL, IntPtr outError)
		{
			return Call("fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:", absoluteURL, typeName, saveOperation, absoluteOriginalContentsURL, outError).To<NSDictionary>();
		}

		public bool keepBackupFile()
		{
			return Call("keepBackupFile").To<bool>();
		}

		public void saveDocument(NSObject sender)
		{
			Unused.Value = Call("saveDocument:", sender);
		}

		public void saveDocumentAs(NSObject sender)
		{
			Unused.Value = Call("saveDocumentAs:", sender);
		}

		public void saveDocumentTo(NSObject sender)
		{
			Unused.Value = Call("saveDocumentTo:", sender);
		}

		public void saveDocumentWithDelegateDidSaveSelectorContextInfo(NSObject delegate_, Selector didSaveSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("saveDocumentWithDelegate:didSaveSelector:contextInfo:", delegate_, didSaveSelector, contextInfo);
		}

		public void runModalSavePanelForSaveOperationDelegateDidSaveSelectorContextInfo(UInt32 saveOperation, NSObject delegate_, Selector didSaveSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:", saveOperation, delegate_, didSaveSelector, contextInfo);
		}

		public bool shouldRunSavePanelWithAccessoryView()
		{
			return Call("shouldRunSavePanelWithAccessoryView").To<bool>();
		}

		public bool prepareSavePanel(NSSavePanel savePanel)
		{
			return Call("prepareSavePanel:", savePanel).To<bool>();
		}

		public bool fileNameExtensionWasHiddenInLastRunSavePanel()
		{
			return Call("fileNameExtensionWasHiddenInLastRunSavePanel").To<bool>();
		}

		public NSString fileTypeFromLastRunSavePanel()
		{
			return Call("fileTypeFromLastRunSavePanel").To<NSString>();
		}

		public void saveToURLOfTypeForSaveOperationDelegateDidSaveSelectorContextInfo(NSURL absoluteURL, NSString typeName, UInt32 saveOperation, NSObject delegate_, Selector didSaveSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:", absoluteURL, typeName, saveOperation, delegate_, didSaveSelector, contextInfo);
		}

		public bool saveToURLOfTypeForSaveOperationError(NSURL absoluteURL, NSString typeName, UInt32 saveOperation, IntPtr outError)
		{
			return Call("saveToURL:ofType:forSaveOperation:error:", absoluteURL, typeName, saveOperation, outError).To<bool>();
		}

		public bool hasUnautosavedChanges()
		{
			return Call("hasUnautosavedChanges").To<bool>();
		}

		public void autosaveDocumentWithDelegateDidAutosaveSelectorContextInfo(NSObject delegate_, Selector didAutosaveSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:", delegate_, didAutosaveSelector, contextInfo);
		}

		public NSString autosavingFileType()
		{
			return Call("autosavingFileType").To<NSString>();
		}

		public void setAutosavedContentsFileURL(NSURL absoluteURL)
		{
			Unused.Value = Call("setAutosavedContentsFileURL:", absoluteURL);
		}

		public NSURL autosavedContentsFileURL()
		{
			return Call("autosavedContentsFileURL").To<NSURL>();
		}

		public void canCloseDocumentWithDelegateShouldCloseSelectorContextInfo(NSObject delegate_, Selector shouldCloseSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:", delegate_, shouldCloseSelector, contextInfo);
		}

		public void close()
		{
			Unused.Value = Call("close");
		}

		public void runPageLayout(NSObject sender)
		{
			Unused.Value = Call("runPageLayout:", sender);
		}

		public void runModalPageLayoutWithPrintInfoDelegateDidRunSelectorContextInfo(NSPrintInfo printInfo, NSObject delegate_, Selector didRunSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:", printInfo, delegate_, didRunSelector, contextInfo);
		}

		public bool preparePageLayout(NSPageLayout pageLayout)
		{
			return Call("preparePageLayout:", pageLayout).To<bool>();
		}

		public bool shouldChangePrintInfo(NSPrintInfo newPrintInfo)
		{
			return Call("shouldChangePrintInfo:", newPrintInfo).To<bool>();
		}

		public void setPrintInfo(NSPrintInfo printInfo)
		{
			Unused.Value = Call("setPrintInfo:", printInfo);
		}

		public NSPrintInfo printInfo()
		{
			return Call("printInfo").To<NSPrintInfo>();
		}

		public void printDocument(NSObject sender)
		{
			Unused.Value = Call("printDocument:", sender);
		}

		public void printDocumentWithSettingsShowPrintPanelDelegateDidPrintSelectorContextInfo(NSDictionary printSettings, bool showPrintPanel, NSObject delegate_, Selector didPrintSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:", printSettings, showPrintPanel, delegate_, didPrintSelector, contextInfo);
		}

		public NSPrintOperation printOperationWithSettingsError(NSDictionary printSettings, IntPtr outError)
		{
			return Call("printOperationWithSettings:error:", printSettings, outError).To<NSPrintOperation>();
		}

		public void runModalPrintOperationDelegateDidRunSelectorContextInfo(NSPrintOperation printOperation, NSObject delegate_, Selector didRunSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("runModalPrintOperation:delegate:didRunSelector:contextInfo:", printOperation, delegate_, didRunSelector, contextInfo);
		}

		public bool isDocumentEdited()
		{
			return Call("isDocumentEdited").To<bool>();
		}

		public void updateChangeCount(UInt32 change)
		{
			Unused.Value = Call("updateChangeCount:", change);
		}

		public void setUndoManager(NSUndoManager undoManager)
		{
			Unused.Value = Call("setUndoManager:", undoManager);
		}

		public NSUndoManager undoManager()
		{
			return Call("undoManager").To<NSUndoManager>();
		}

		public void setHasUndoManager(bool hasUndoManager)
		{
			Unused.Value = Call("setHasUndoManager:", hasUndoManager);
		}

		public bool hasUndoManager()
		{
			return Call("hasUndoManager").To<bool>();
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

		public void makeWindowControllers()
		{
			Unused.Value = Call("makeWindowControllers");
		}

		public NSString windowNibName()
		{
			return Call("windowNibName").To<NSString>();
		}

		public void windowControllerWillLoadNib(NSWindowController windowController)
		{
			Unused.Value = Call("windowControllerWillLoadNib:", windowController);
		}

		public void windowControllerDidLoadNib(NSWindowController windowController)
		{
			Unused.Value = Call("windowControllerDidLoadNib:", windowController);
		}

		public void setWindow(NSWindow window)
		{
			Unused.Value = Call("setWindow:", window);
		}

		public void addWindowController(NSWindowController windowController)
		{
			Unused.Value = Call("addWindowController:", windowController);
		}

		public void removeWindowController(NSWindowController windowController)
		{
			Unused.Value = Call("removeWindowController:", windowController);
		}

		public void showWindows()
		{
			Unused.Value = Call("showWindows");
		}

		public NSArray windowControllers()
		{
			return Call("windowControllers").To<NSArray>();
		}

		public void shouldCloseWindowControllerDelegateShouldCloseSelectorContextInfo(NSWindowController windowController, NSObject delegate_, Selector shouldCloseSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:", windowController, delegate_, shouldCloseSelector, contextInfo);
		}

		public NSString displayName()
		{
			return Call("displayName").To<NSString>();
		}

		public NSWindow windowForSheet()
		{
			return Call("windowForSheet").To<NSWindow>();
		}

		public static NSArray readableTypes()
		{
			return ms_class.Call("readableTypes").To<NSArray>();
		}

		public static NSArray writableTypes()
		{
			return ms_class.Call("writableTypes").To<NSArray>();
		}

		public static bool isNativeType(NSString type)
		{
			return ms_class.Call("isNativeType:", type).To<bool>();
		}

		public NSArray writableTypesForSaveOperation(UInt32 saveOperation)
		{
			return Call("writableTypesForSaveOperation:", saveOperation).To<NSArray>();
		}

		public NSString fileNameExtensionForTypeSaveOperation(NSString typeName, UInt32 saveOperation)
		{
			return Call("fileNameExtensionForType:saveOperation:", typeName, saveOperation).To<NSString>();
		}

		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}

		#region NSUserInterfaceValidations Methods
		#endregion

		private static Class ms_class = new Class("NSDocument");
	}

	public static class NSDeprecatedForNSDocumentCategory
	{
		public static NSData dataRepresentationOfType(this NSDocument _instance, NSString type)
		{
			return _instance.Call("dataRepresentationOfType:", type).To<NSData>();
		}

		public static NSDictionary fileAttributesToWriteToFileOfTypeSaveOperation(this NSDocument _instance, NSString fullDocumentPath, NSString documentTypeName, UInt32 saveOperationType)
		{
			return _instance.Call("fileAttributesToWriteToFile:ofType:saveOperation:", fullDocumentPath, documentTypeName, saveOperationType).To<NSDictionary>();
		}

		public static NSString fileName(this NSDocument _instance)
		{
			return _instance.Call("fileName").To<NSString>();
		}

		public static NSFileWrapper fileWrapperRepresentationOfType(this NSDocument _instance, NSString type)
		{
			return _instance.Call("fileWrapperRepresentationOfType:", type).To<NSFileWrapper>();
		}

		public static NSObject initWithContentsOfFileOfType(this NSDocument _instance, NSString absolutePath, NSString typeName)
		{
			return _instance.Call("initWithContentsOfFile:ofType:", absolutePath, typeName).To<NSObject>();
		}

		public static NSObject initWithContentsOfURLOfType(this NSDocument _instance, NSURL absoluteURL, NSString typeName)
		{
			return _instance.Call("initWithContentsOfURL:ofType:", absoluteURL, typeName).To<NSObject>();
		}

		public static bool loadDataRepresentationOfType(this NSDocument _instance, NSData data, NSString type)
		{
			return _instance.Call("loadDataRepresentation:ofType:", data, type).To<bool>();
		}

		public static bool loadFileWrapperRepresentationOfType(this NSDocument _instance, NSFileWrapper wrapper, NSString type)
		{
			return _instance.Call("loadFileWrapperRepresentation:ofType:", wrapper, type).To<bool>();
		}

		public static void printShowingPrintPanel(this NSDocument _instance, bool flag)
		{
			Unused.Value = _instance.Call("printShowingPrintPanel:", flag);
		}

		public static bool readFromFileOfType(this NSDocument _instance, NSString fileName, NSString type)
		{
			return _instance.Call("readFromFile:ofType:", fileName, type).To<bool>();
		}

		public static bool readFromURLOfType(this NSDocument _instance, NSURL url, NSString type)
		{
			return _instance.Call("readFromURL:ofType:", url, type).To<bool>();
		}

		public static bool revertToSavedFromFileOfType(this NSDocument _instance, NSString fileName, NSString type)
		{
			return _instance.Call("revertToSavedFromFile:ofType:", fileName, type).To<bool>();
		}

		public static bool revertToSavedFromURLOfType(this NSDocument _instance, NSURL url, NSString type)
		{
			return _instance.Call("revertToSavedFromURL:ofType:", url, type).To<bool>();
		}

		public static Int32 runModalPageLayoutWithPrintInfo(this NSDocument _instance, NSPrintInfo printInfo)
		{
			return _instance.Call("runModalPageLayoutWithPrintInfo:", printInfo).To<Int32>();
		}

		public static void saveToFileSaveOperationDelegateDidSaveSelectorContextInfo(this NSDocument _instance, NSString fileName, UInt32 saveOperation, NSObject delegate_, Selector didSaveSelector, IntPtr contextInfo)
		{
			Unused.Value = _instance.Call("saveToFile:saveOperation:delegate:didSaveSelector:contextInfo:", fileName, saveOperation, delegate_, didSaveSelector, contextInfo);
		}

		public static void setFileName(this NSDocument _instance, NSString fileName)
		{
			Unused.Value = _instance.Call("setFileName:", fileName);
		}

		public static bool writeToFileOfType(this NSDocument _instance, NSString fileName, NSString type)
		{
			return _instance.Call("writeToFile:ofType:", fileName, type).To<bool>();
		}

		public static bool writeToFileOfTypeOriginalFileSaveOperation(this NSDocument _instance, NSString fullDocumentPath, NSString documentTypeName, NSString fullOriginalDocumentPath, UInt32 saveOperationType)
		{
			return _instance.Call("writeToFile:ofType:originalFile:saveOperation:", fullDocumentPath, documentTypeName, fullOriginalDocumentPath, saveOperationType).To<bool>();
		}

		public static bool writeToURLOfType(this NSDocument _instance, NSURL url, NSString type)
		{
			return _instance.Call("writeToURL:ofType:", url, type).To<bool>();
		}

		public static bool writeWithBackupToFileOfTypeSaveOperation(this NSDocument _instance, NSString fullDocumentPath, NSString documentTypeName, UInt32 saveOperationType)
		{
			return _instance.Call("writeWithBackupToFile:ofType:saveOperation:", fullDocumentPath, documentTypeName, saveOperationType).To<bool>();
		}
	}
}
