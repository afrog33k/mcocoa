// Copyright (C) 2008 Jesse Jones
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using MObjc;
using MObjc.Helpers;
using System;

namespace MCocoa
{
	/// <exclude/>
	public static partial class Externs
	{
		// File-System Attribute Keys
		public static readonly NSString NSFileSystemSize = NSString.Create("NSFileSystemSize").Retain();
		public static readonly NSString NSFileSystemFreeSize = NSString.Create("NSFileSystemFreeSize").Retain();
		public static readonly NSString NSFileSystemNodes = NSString.Create("NSFileSystemNodes").Retain();
		public static readonly NSString NSFileSystemFreeNodes = NSString.Create("NSFileSystemFreeNodes").Retain();
		public static readonly NSString NSFileSystemNumber = NSString.Create("NSFileSystemNumber").Retain();

		// Item Attribute Keys
		public static readonly NSString NSFileType = NSString.Create("NSFileType").Retain();
		public static readonly NSString NSFileTypeDirectory = NSString.Create("NSFileTypeDirectory").Retain();
		public static readonly NSString NSFileTypeRegular = NSString.Create("NSFileTypeRegular").Retain();
		public static readonly NSString NSFileTypeSymbolicLink = NSString.Create("NSFileTypeSymbolicLink").Retain();
		public static readonly NSString NSFileTypeSocket = NSString.Create("NSFileTypeSocket").Retain();
		public static readonly NSString NSFileTypeCharacterSpecial = NSString.Create("NSFileTypeCharacterSpecial").Retain();
		public static readonly NSString NSFileTypeBlockSpecial = NSString.Create("NSFileTypeBlockSpecial").Retain();
		public static readonly NSString NSFileTypeUnknown = NSString.Create("NSFileTypeUnknown").Retain();
		public static readonly NSString NSFileSize = NSString.Create("NSFileSize").Retain();
		public static readonly NSString NSFileModificationDate = NSString.Create("NSFileModificationDate").Retain();
		public static readonly NSString NSFileReferenceCount = NSString.Create("NSFileReferenceCount").Retain();
		public static readonly NSString NSFileDeviceIdentifier = NSString.Create("NSFileDeviceIdentifier").Retain();
		public static readonly NSString NSFileOwnerAccountName = NSString.Create("NSFileOwnerAccountName").Retain();
		public static readonly NSString NSFileGroupOwnerAccountName = NSString.Create("NSFileGroupOwnerAccountName").Retain();
		public static readonly NSString NSFilePosixPermissions = NSString.Create("NSFilePosixPermissions").Retain();
//		public static readonly NSString NSFileSystemNumber = NSString.Create("NSFileSystemNumber").Retain();
		public static readonly NSString NSFileSystemFileNumber = NSString.Create("NSFileSystemFileNumber").Retain();
		public static readonly NSString NSFileExtensionHidden = NSString.Create("NSFileExtensionHidden").Retain();
		public static readonly NSString NSFileHFSCreatorCode = NSString.Create("NSFileHFSCreatorCode").Retain();
		public static readonly NSString NSFileHFSTypeCode = NSString.Create("NSFileHFSTypeCode").Retain();
		public static readonly NSString NSFileImmutable = NSString.Create("NSFileImmutable").Retain();
		public static readonly NSString NSFileAppendOnly = NSString.Create("NSFileAppendOnly").Retain();
		public static readonly NSString NSFileCreationDate = NSString.Create("NSFileCreationDate").Retain();
		public static readonly NSString NSFileOwnerAccountID = NSString.Create("NSFileOwnerAccountID").Retain();
		public static readonly NSString NSFileGroupOwnerAccountID = NSString.Create("NSFileGroupOwnerAccountID").Retain();
		public static readonly NSString NSFileBusy = NSString.Create("NSFileBusy").Retain();
	}

//	[ThreadModel(ThreadModel.SingleThread)] (generated class defines this)
	public partial class NSFileManager : NSObject
	{
		[ThreadModel(ThreadModel.MainThread)]
		public static NSFileManager defaultManager()
		{
			Contract.Requires(System.Threading.Thread.CurrentThread.ManagedThreadId == 1, "use NSFileManager.Alloc().init().To<NSFileManager>() to get a thread safe instance");
			
			IntPtr exception_ = IntPtr.Zero;
			IntPtr result_ = DirectCalls.Callp(ms_class, new Selector("defaultManager"), ref exception_);
			if (exception_ != IntPtr.Zero)
				CocoaException.Raise(exception_);
			
			return result_.To<NSFileManager>();
		}
	}
}
