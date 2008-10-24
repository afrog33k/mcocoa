// machine generated on 10/24/2008 3:54:08 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSWorkspace.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSWorkspaceLaunchAndPrint = 0x00000002;
		public const int NSWorkspaceLaunchInhibitingBackgroundOnly = 0x00000080;
		public const int NSWorkspaceLaunchWithoutAddingToRecents = 0x00000100;
		public const int NSWorkspaceLaunchWithoutActivation = 0x00000200;
		public const int NSWorkspaceLaunchAsync = 0x00010000;
		public const int NSWorkspaceLaunchAllowingClassicStartup = 0x00020000;
		public const int NSWorkspaceLaunchPreferringClassic = 0x00040000;
		public const int NSWorkspaceLaunchNewInstance = 0x00080000;
		public const int NSWorkspaceLaunchAndHide = 0x00100000;
		public const int NSWorkspaceLaunchAndHideOthers = 0x00200000;
		public const int NSWorkspaceLaunchDefault = NSWorkspaceLaunchAsync | NSWorkspaceLaunchAllowingClassicStartup;
	}

	public partial class Enums
	{
		public const int NSExcludeQuickDrawElementsIconCreationOption = 1 << 1;
		public const int NSExclude10_4ElementsIconCreationOption = 1 << 2;
	}

	[Register]
	public partial class NSWorkspace : NSObject
	{
		public NSWorkspace() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSWorkspace(IntPtr instance) : base(instance)
		{
		}

		public NSWorkspace(Untyped instance) : base(instance)
		{
		}

		public static new NSWorkspace alloc()
		{
			return new NSWorkspace(ms_class.Call("alloc"));
		}

		public new NSWorkspace retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSWorkspace sharedWorkspace()
		{
			return ms_class.Call("sharedWorkspace").To<NSWorkspace>();
		}

		public NSNotificationCenter notificationCenter()
		{
			return Call("notificationCenter").To<NSNotificationCenter>();
		}

		public bool openFile(NSString fullPath)
		{
			return Call("openFile:", fullPath).To<bool>();
		}

		public bool openFileWithApplication(NSString fullPath, NSString appName)
		{
			return Call("openFile:withApplication:", fullPath, appName).To<bool>();
		}

		public bool openFileWithApplicationAndDeactivate(NSString fullPath, NSString appName, bool flag)
		{
			return Call("openFile:withApplication:andDeactivate:", fullPath, appName, flag).To<bool>();
		}

		public bool openTempFile(NSString fullPath)
		{
			return Call("openTempFile:", fullPath).To<bool>();
		}

		public bool openFileFromImageAtInView(NSString fullPath, NSImage anImage, NSPoint point, NSView aView)
		{
			return Call("openFile:fromImage:at:inView:", fullPath, anImage, point, aView).To<bool>();
		}

		public bool openURL(NSURL url)
		{
			return Call("openURL:", url).To<bool>();
		}

		public bool launchApplication(NSString appName)
		{
			return Call("launchApplication:", appName).To<bool>();
		}

		public bool launchApplicationShowIconAutolaunch(NSString appName, bool showIcon, bool autolaunch)
		{
			return Call("launchApplication:showIcon:autolaunch:", appName, showIcon, autolaunch).To<bool>();
		}

		public NSString fullPathForApplication(NSString appName)
		{
			return Call("fullPathForApplication:", appName).To<NSString>();
		}

		public bool selectFileInFileViewerRootedAtPath(NSString fullPath, NSString rootFullpath)
		{
			return Call("selectFile:inFileViewerRootedAtPath:", fullPath, rootFullpath).To<bool>();
		}

		public void findApplications()
		{
			Unused.Value = Call("findApplications");
		}

		public void noteFileSystemChanged()
		{
			Unused.Value = Call("noteFileSystemChanged");
		}

		public void noteFileSystemChanged(NSString path)
		{
			Unused.Value = Call("noteFileSystemChanged:", path);
		}

		public bool fileSystemChanged()
		{
			return Call("fileSystemChanged").To<bool>();
		}

		public void noteUserDefaultsChanged()
		{
			Unused.Value = Call("noteUserDefaultsChanged");
		}

		public bool userDefaultsChanged()
		{
			return Call("userDefaultsChanged").To<bool>();
		}

		public bool getInfoForFileApplicationType(NSString fullPath, IntPtr appName, IntPtr type)
		{
			return Call("getInfoForFile:application:type:", fullPath, appName, type).To<bool>();
		}

		public bool isFilePackageAtPath(NSString fullPath)
		{
			return Call("isFilePackageAtPath:", fullPath).To<bool>();
		}

		public NSImage iconForFile(NSString fullPath)
		{
			return Call("iconForFile:", fullPath).To<NSImage>();
		}

		public NSImage iconForFiles(NSArray fullPaths)
		{
			return Call("iconForFiles:", fullPaths).To<NSImage>();
		}

		public NSImage iconForFileType(NSString fileType)
		{
			return Call("iconForFileType:", fileType).To<NSImage>();
		}

		public bool setIconForFileOptions(NSImage image, NSString fullPath, UInt32 options)
		{
			return Call("setIcon:forFile:options:", image, fullPath, options).To<bool>();
		}

		public bool getFileSystemInfoForPathIsRemovableIsWritableIsUnmountableDescriptionType(NSString fullPath, IntPtr removableFlag, IntPtr writableFlag, IntPtr unmountableFlag, IntPtr description, IntPtr fileSystemType)
		{
			return Call("getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:", fullPath, removableFlag, writableFlag, unmountableFlag, description, fileSystemType).To<bool>();
		}

		public bool performFileOperationSourceDestinationFilesTag(NSString operation, NSString source, NSString destination, NSArray files, IntPtr tag)
		{
			return Call("performFileOperation:source:destination:files:tag:", operation, source, destination, files, tag).To<bool>();
		}

		public bool unmountAndEjectDeviceAtPath(NSString path)
		{
			return Call("unmountAndEjectDeviceAtPath:", path).To<bool>();
		}

		public Int32 extendPowerOffBy(Int32 requested)
		{
			return Call("extendPowerOffBy:", requested).To<Int32>();
		}

		public void slideImageFromTo(NSImage image, NSPoint fromPoint, NSPoint toPoint)
		{
			Unused.Value = Call("slideImage:from:to:", image, fromPoint, toPoint);
		}

		public void hideOtherApplications()
		{
			Unused.Value = Call("hideOtherApplications");
		}

		public NSArray mountedLocalVolumePaths()
		{
			return Call("mountedLocalVolumePaths").To<NSArray>();
		}

		public NSArray mountedRemovableMedia()
		{
			return Call("mountedRemovableMedia").To<NSArray>();
		}

		public NSArray mountNewRemovableMedia()
		{
			return Call("mountNewRemovableMedia").To<NSArray>();
		}

		public void checkForRemovableMedia()
		{
			Unused.Value = Call("checkForRemovableMedia");
		}

		public NSString absolutePathForAppBundleWithIdentifier(NSString bundleIdentifier)
		{
			return Call("absolutePathForAppBundleWithIdentifier:", bundleIdentifier).To<NSString>();
		}

		public bool launchAppWithBundleIdentifierOptionsAdditionalEventParamDescriptorLaunchIdentifier(NSString bundleIdentifier, UInt32 options, NSAppleEventDescriptor descriptor, IntPtr identifier)
		{
			return Call("launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:", bundleIdentifier, options, descriptor, identifier).To<bool>();
		}

		public bool openURLsWithAppBundleIdentifierOptionsAdditionalEventParamDescriptorLaunchIdentifiers(NSArray urls, NSString bundleIdentifier, UInt32 options, NSAppleEventDescriptor descriptor, IntPtr identifiers)
		{
			return Call("openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:", urls, bundleIdentifier, options, descriptor, identifiers).To<bool>();
		}

		public NSArray launchedApplications()
		{
			return Call("launchedApplications").To<NSArray>();
		}

		public NSDictionary activeApplication()
		{
			return Call("activeApplication").To<NSDictionary>();
		}

		public NSString typeOfFileError(NSString absoluteFilePath, IntPtr outError)
		{
			return Call("typeOfFile:error:", absoluteFilePath, outError).To<NSString>();
		}

		public NSString localizedDescriptionForType(NSString typeName)
		{
			return Call("localizedDescriptionForType:", typeName).To<NSString>();
		}

		public NSString preferredFilenameExtensionForType(NSString typeName)
		{
			return Call("preferredFilenameExtensionForType:", typeName).To<NSString>();
		}

		public bool filenameExtensionIsValidForType(NSString filenameExtension, NSString typeName)
		{
			return Call("filenameExtension:isValidForType:", filenameExtension, typeName).To<bool>();
		}

		public bool typeConformsToType(NSString firstTypeName, NSString secondTypeName)
		{
			return Call("type:conformsToType:", firstTypeName, secondTypeName).To<bool>();
		}

		private static Class ms_class = new Class("NSWorkspace");
	}
}
