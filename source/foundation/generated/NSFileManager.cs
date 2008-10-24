// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSFileManager.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSFileManager : NSObject
	{
		public NSFileManager() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFileManager(IntPtr instance) : base(instance)
		{
		}

		public NSFileManager(Untyped instance) : base(instance)
		{
		}

		public static new NSFileManager alloc()
		{
			return new NSFileManager(ms_class.Call("alloc"));
		}

		public new NSFileManager retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSFileManager defaultManager()
		{
			return ms_class.Call("defaultManager").To<NSFileManager>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public bool setAttributesOfItemAtPathError(NSDictionary attributes, NSString path, IntPtr error)
		{
			return Call("setAttributes:ofItemAtPath:error:", attributes, path, error).To<bool>();
		}

		public bool createDirectoryAtPathWithIntermediateDirectoriesAttributesError(NSString path, bool createIntermediates, NSDictionary attributes, IntPtr error)
		{
			return Call("createDirectoryAtPath:withIntermediateDirectories:attributes:error:", path, createIntermediates, attributes, error).To<bool>();
		}

		public NSArray contentsOfDirectoryAtPathError(NSString path, IntPtr error)
		{
			return Call("contentsOfDirectoryAtPath:error:", path, error).To<NSArray>();
		}

		public NSArray subpathsOfDirectoryAtPathError(NSString path, IntPtr error)
		{
			return Call("subpathsOfDirectoryAtPath:error:", path, error).To<NSArray>();
		}

		public NSDictionary attributesOfItemAtPathError(NSString path, IntPtr error)
		{
			return Call("attributesOfItemAtPath:error:", path, error).To<NSDictionary>();
		}

		public NSDictionary attributesOfFileSystemForPathError(NSString path, IntPtr error)
		{
			return Call("attributesOfFileSystemForPath:error:", path, error).To<NSDictionary>();
		}

		public bool createSymbolicLinkAtPathWithDestinationPathError(NSString path, NSString destPath, IntPtr error)
		{
			return Call("createSymbolicLinkAtPath:withDestinationPath:error:", path, destPath, error).To<bool>();
		}

		public NSString destinationOfSymbolicLinkAtPathError(NSString path, IntPtr error)
		{
			return Call("destinationOfSymbolicLinkAtPath:error:", path, error).To<NSString>();
		}

		public bool copyItemAtPathToPathError(NSString srcPath, NSString dstPath, IntPtr error)
		{
			return Call("copyItemAtPath:toPath:error:", srcPath, dstPath, error).To<bool>();
		}

		public bool moveItemAtPathToPathError(NSString srcPath, NSString dstPath, IntPtr error)
		{
			return Call("moveItemAtPath:toPath:error:", srcPath, dstPath, error).To<bool>();
		}

		public bool linkItemAtPathToPathError(NSString srcPath, NSString dstPath, IntPtr error)
		{
			return Call("linkItemAtPath:toPath:error:", srcPath, dstPath, error).To<bool>();
		}

		public bool removeItemAtPathError(NSString path, IntPtr error)
		{
			return Call("removeItemAtPath:error:", path, error).To<bool>();
		}

		public NSDictionary fileAttributesAtPathTraverseLink(NSString path, bool yorn)
		{
			return Call("fileAttributesAtPath:traverseLink:", path, yorn).To<NSDictionary>();
		}

		public bool changeFileAttributesAtPath(NSDictionary attributes, NSString path)
		{
			return Call("changeFileAttributes:atPath:", attributes, path).To<bool>();
		}

		public NSArray directoryContentsAtPath(NSString path)
		{
			return Call("directoryContentsAtPath:", path).To<NSArray>();
		}

		public NSDictionary fileSystemAttributesAtPath(NSString path)
		{
			return Call("fileSystemAttributesAtPath:", path).To<NSDictionary>();
		}

		public NSString pathContentOfSymbolicLinkAtPath(NSString path)
		{
			return Call("pathContentOfSymbolicLinkAtPath:", path).To<NSString>();
		}

		public bool createSymbolicLinkAtPathPathContent(NSString path, NSString otherpath)
		{
			return Call("createSymbolicLinkAtPath:pathContent:", path, otherpath).To<bool>();
		}

		public bool createDirectoryAtPathAttributes(NSString path, NSDictionary attributes)
		{
			return Call("createDirectoryAtPath:attributes:", path, attributes).To<bool>();
		}

		public bool linkPathToPathHandler(NSString src, NSString dest, NSObject handler)
		{
			return Call("linkPath:toPath:handler:", src, dest, handler).To<bool>();
		}

		public bool copyPathToPathHandler(NSString src, NSString dest, NSObject handler)
		{
			return Call("copyPath:toPath:handler:", src, dest, handler).To<bool>();
		}

		public bool movePathToPathHandler(NSString src, NSString dest, NSObject handler)
		{
			return Call("movePath:toPath:handler:", src, dest, handler).To<bool>();
		}

		public bool removeFileAtPathHandler(NSString path, NSObject handler)
		{
			return Call("removeFileAtPath:handler:", path, handler).To<bool>();
		}

		public NSString currentDirectoryPath()
		{
			return Call("currentDirectoryPath").To<NSString>();
		}

		public bool changeCurrentDirectoryPath(NSString path)
		{
			return Call("changeCurrentDirectoryPath:", path).To<bool>();
		}

		public bool fileExistsAtPath(NSString path)
		{
			return Call("fileExistsAtPath:", path).To<bool>();
		}

		public bool fileExistsAtPathIsDirectory(NSString path, IntPtr isDirectory)
		{
			return Call("fileExistsAtPath:isDirectory:", path, isDirectory).To<bool>();
		}

		public bool isReadableFileAtPath(NSString path)
		{
			return Call("isReadableFileAtPath:", path).To<bool>();
		}

		public bool isWritableFileAtPath(NSString path)
		{
			return Call("isWritableFileAtPath:", path).To<bool>();
		}

		public bool isExecutableFileAtPath(NSString path)
		{
			return Call("isExecutableFileAtPath:", path).To<bool>();
		}

		public bool isDeletableFileAtPath(NSString path)
		{
			return Call("isDeletableFileAtPath:", path).To<bool>();
		}

		public bool contentsEqualAtPathAndPath(NSString path1, NSString path2)
		{
			return Call("contentsEqualAtPath:andPath:", path1, path2).To<bool>();
		}

		public NSString displayNameAtPath(NSString path)
		{
			return Call("displayNameAtPath:", path).To<NSString>();
		}

		public NSArray componentsToDisplayForPath(NSString path)
		{
			return Call("componentsToDisplayForPath:", path).To<NSArray>();
		}

		public NSDirectoryEnumerator enumeratorAtPath(NSString path)
		{
			return Call("enumeratorAtPath:", path).To<NSDirectoryEnumerator>();
		}

		public NSArray subpathsAtPath(NSString path)
		{
			return Call("subpathsAtPath:", path).To<NSArray>();
		}

		public NSData contentsAtPath(NSString path)
		{
			return Call("contentsAtPath:", path).To<NSData>();
		}

		public bool createFileAtPathContentsAttributes(NSString path, NSData data, NSDictionary attr)
		{
			return Call("createFileAtPath:contents:attributes:", path, data, attr).To<bool>();
		}

		public string fileSystemRepresentationWithPath(NSString path)
		{
			return Call("fileSystemRepresentationWithPath:", path).To<string>();
		}

		public NSString stringWithFileSystemRepresentationLength(string str, UInt32 len)
		{
			return Call("stringWithFileSystemRepresentation:length:", str, len).To<NSString>();
		}

		private static Class ms_class = new Class("NSFileManager");
	}

	public static class NSCopyLinkMoveHandlerForNSObjectCategory
	{
		public static bool fileManagerShouldProceedAfterError(this NSObject _instance, NSFileManager fm, NSDictionary errorInfo)
		{
			return _instance.Call("fileManager:shouldProceedAfterError:", fm, errorInfo).To<bool>();
		}

		public static void fileManagerWillProcessPath(this NSObject _instance, NSFileManager fm, NSString path)
		{
			Unused.Value = _instance.Call("fileManager:willProcessPath:", fm, path);
		}
	}

	public static class NSFileManagerFileOperationAdditionsForNSObjectCategory
	{
		public static bool fileManagerShouldCopyItemAtPathToPath(this NSObject _instance, NSFileManager fileManager, NSString srcPath, NSString dstPath)
		{
			return _instance.Call("fileManager:shouldCopyItemAtPath:toPath:", fileManager, srcPath, dstPath).To<bool>();
		}

		public static bool fileManagerShouldProceedAfterErrorCopyingItemAtPathToPath(this NSObject _instance, NSFileManager fileManager, NSError error, NSString srcPath, NSString dstPath)
		{
			return _instance.Call("fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:", fileManager, error, srcPath, dstPath).To<bool>();
		}

		public static bool fileManagerShouldMoveItemAtPathToPath(this NSObject _instance, NSFileManager fileManager, NSString srcPath, NSString dstPath)
		{
			return _instance.Call("fileManager:shouldMoveItemAtPath:toPath:", fileManager, srcPath, dstPath).To<bool>();
		}

		public static bool fileManagerShouldProceedAfterErrorMovingItemAtPathToPath(this NSObject _instance, NSFileManager fileManager, NSError error, NSString srcPath, NSString dstPath)
		{
			return _instance.Call("fileManager:shouldProceedAfterError:movingItemAtPath:toPath:", fileManager, error, srcPath, dstPath).To<bool>();
		}

		public static bool fileManagerShouldLinkItemAtPathToPath(this NSObject _instance, NSFileManager fileManager, NSString srcPath, NSString dstPath)
		{
			return _instance.Call("fileManager:shouldLinkItemAtPath:toPath:", fileManager, srcPath, dstPath).To<bool>();
		}

		public static bool fileManagerShouldProceedAfterErrorLinkingItemAtPathToPath(this NSObject _instance, NSFileManager fileManager, NSError error, NSString srcPath, NSString dstPath)
		{
			return _instance.Call("fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:", fileManager, error, srcPath, dstPath).To<bool>();
		}

		public static bool fileManagerShouldRemoveItemAtPath(this NSObject _instance, NSFileManager fileManager, NSString path)
		{
			return _instance.Call("fileManager:shouldRemoveItemAtPath:", fileManager, path).To<bool>();
		}

		public static bool fileManagerShouldProceedAfterErrorRemovingItemAtPath(this NSObject _instance, NSFileManager fileManager, NSError error, NSString path)
		{
			return _instance.Call("fileManager:shouldProceedAfterError:removingItemAtPath:", fileManager, error, path).To<bool>();
		}
	}

	[Register]
	public partial class NSDirectoryEnumerator : NSEnumerator
	{
		public NSDirectoryEnumerator() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDirectoryEnumerator(IntPtr instance) : base(instance)
		{
		}

		public NSDirectoryEnumerator(Untyped instance) : base(instance)
		{
		}

		public static new NSDirectoryEnumerator alloc()
		{
			return new NSDirectoryEnumerator(ms_class.Call("alloc"));
		}

		public new NSDirectoryEnumerator retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSDictionary fileAttributes()
		{
			return Call("fileAttributes").To<NSDictionary>();
		}

		public NSDictionary directoryAttributes()
		{
			return Call("directoryAttributes").To<NSDictionary>();
		}

		public void skipDescendents()
		{
			Unused.Value = Call("skipDescendents");
		}

		private static Class ms_class = new Class("NSDirectoryEnumerator");
	}

	public static class NSFileAttributesForNSDictionaryCategory
	{
		public static UInt64 fileSize(this NSDictionary _instance)
		{
			return _instance.Call("fileSize").To<UInt64>();
		}

		public static NSDate fileModificationDate(this NSDictionary _instance)
		{
			return _instance.Call("fileModificationDate").To<NSDate>();
		}

		public static NSString fileType(this NSDictionary _instance)
		{
			return _instance.Call("fileType").To<NSString>();
		}

		public static UInt32 filePosixPermissions(this NSDictionary _instance)
		{
			return _instance.Call("filePosixPermissions").To<UInt32>();
		}

		public static NSString fileOwnerAccountName(this NSDictionary _instance)
		{
			return _instance.Call("fileOwnerAccountName").To<NSString>();
		}

		public static NSString fileGroupOwnerAccountName(this NSDictionary _instance)
		{
			return _instance.Call("fileGroupOwnerAccountName").To<NSString>();
		}

		public static Int32 fileSystemNumber(this NSDictionary _instance)
		{
			return _instance.Call("fileSystemNumber").To<Int32>();
		}

		public static UInt32 fileSystemFileNumber(this NSDictionary _instance)
		{
			return _instance.Call("fileSystemFileNumber").To<UInt32>();
		}

		public static bool fileExtensionHidden(this NSDictionary _instance)
		{
			return _instance.Call("fileExtensionHidden").To<bool>();
		}

		public static UInt32 fileHFSCreatorCode(this NSDictionary _instance)
		{
			return _instance.Call("fileHFSCreatorCode").To<UInt32>();
		}

		public static UInt32 fileHFSTypeCode(this NSDictionary _instance)
		{
			return _instance.Call("fileHFSTypeCode").To<UInt32>();
		}

		public static bool fileIsImmutable(this NSDictionary _instance)
		{
			return _instance.Call("fileIsImmutable").To<bool>();
		}

		public static bool fileIsAppendOnly(this NSDictionary _instance)
		{
			return _instance.Call("fileIsAppendOnly").To<bool>();
		}

		public static NSDate fileCreationDate(this NSDictionary _instance)
		{
			return _instance.Call("fileCreationDate").To<NSDate>();
		}

		public static NSNumber fileOwnerAccountID(this NSDictionary _instance)
		{
			return _instance.Call("fileOwnerAccountID").To<NSNumber>();
		}

		public static NSNumber fileGroupOwnerAccountID(this NSDictionary _instance)
		{
			return _instance.Call("fileGroupOwnerAccountID").To<NSNumber>();
		}
	}
}
