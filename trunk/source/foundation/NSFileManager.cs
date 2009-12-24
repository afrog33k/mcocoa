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
		public static readonly LazyString NSFileSystemSize = new LazyString("NSFileSystemSize");
		public static readonly LazyString NSFileSystemFreeSize = new LazyString("NSFileSystemFreeSize");
		public static readonly LazyString NSFileSystemNodes = new LazyString("NSFileSystemNodes");
		public static readonly LazyString NSFileSystemFreeNodes = new LazyString("NSFileSystemFreeNodes");
		public static readonly LazyString NSFileSystemNumber = new LazyString("NSFileSystemNumber");

		// Item Attribute Keys
		public static readonly LazyString NSFileType = new LazyString("NSFileType");
		public static readonly LazyString NSFileTypeDirectory = new LazyString("NSFileTypeDirectory");
		public static readonly LazyString NSFileTypeRegular = new LazyString("NSFileTypeRegular");
		public static readonly LazyString NSFileTypeSymbolicLink = new LazyString("NSFileTypeSymbolicLink");
		public static readonly LazyString NSFileTypeSocket = new LazyString("NSFileTypeSocket");
		public static readonly LazyString NSFileTypeCharacterSpecial = new LazyString("NSFileTypeCharacterSpecial");
		public static readonly LazyString NSFileTypeBlockSpecial = new LazyString("NSFileTypeBlockSpecial");
		public static readonly LazyString NSFileTypeUnknown = new LazyString("NSFileTypeUnknown");
		public static readonly LazyString NSFileSize = new LazyString("NSFileSize");
		public static readonly LazyString NSFileModificationDate = new LazyString("NSFileModificationDate");
		public static readonly LazyString NSFileReferenceCount = new LazyString("NSFileReferenceCount");
		public static readonly LazyString NSFileDeviceIdentifier = new LazyString("NSFileDeviceIdentifier");
		public static readonly LazyString NSFileOwnerAccountName = new LazyString("NSFileOwnerAccountName");
		public static readonly LazyString NSFileGroupOwnerAccountName = new LazyString("NSFileGroupOwnerAccountName");
		public static readonly LazyString NSFilePosixPermissions = new LazyString("NSFilePosixPermissions");
//		public static readonly LazyString NSFileSystemNumber = new LazyString("NSFileSystemNumber");
		public static readonly LazyString NSFileSystemFileNumber = new LazyString("NSFileSystemFileNumber");
		public static readonly LazyString NSFileExtensionHidden = new LazyString("NSFileExtensionHidden");
		public static readonly LazyString NSFileHFSCreatorCode = new LazyString("NSFileHFSCreatorCode");
		public static readonly LazyString NSFileHFSTypeCode = new LazyString("NSFileHFSTypeCode");
		public static readonly LazyString NSFileImmutable = new LazyString("NSFileImmutable");
		public static readonly LazyString NSFileAppendOnly = new LazyString("NSFileAppendOnly");
		public static readonly LazyString NSFileCreationDate = new LazyString("NSFileCreationDate");
		public static readonly LazyString NSFileOwnerAccountID = new LazyString("NSFileOwnerAccountID");
		public static readonly LazyString NSFileGroupOwnerAccountID = new LazyString("NSFileGroupOwnerAccountID");
		public static readonly LazyString NSFileBusy = new LazyString("NSFileBusy");
	}
	
//	[ThreadModel(ThreadModel.SingleThread)] (generated class defines this)
	public partial class NSFileManager : NSObject
	{
		/// <exclude/>
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
		
		/// <exclude/>
		public NSDirectoryEnumerator enumeratorAtURL_includingPropertiesForKeys_options_errorHandler(
			NSURL url,
			NSArray keys,
			uint mask,
			Func<NSURL, NSError, bool> callback)
		{
			Func<IntPtr, IntPtr, IntPtr, byte> thunk = (IntPtr context, IntPtr urlPtr, IntPtr errorPtr) =>
			{
				var url2 = NSObject.Lookup(urlPtr).To<NSURL>();
				var error = NSObject.Lookup(errorPtr).To<NSError>();
				bool stopped = callback(url2, error);
				return stopped ? (byte) 1 : (byte) 0;
			};
			
			var block = new ExtendedBlock(thunk);
			var e = Call("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:",
				url,
				keys,
				mask,
				block).To<NSDirectoryEnumerator>();
			GC.KeepAlive(block);
			
			return e;
		}
	}
}
