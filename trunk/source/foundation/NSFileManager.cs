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
using System;

namespace MCocoa
{
	public static partial class Externs
	{
		// File-System Attribute Keys
		public static readonly NSString NSFileSystemSize = NSString.Create("NSFileSystemSize").retain();
		public static readonly NSString NSFileSystemFreeSize = NSString.Create("NSFileSystemFreeSize").retain();
		public static readonly NSString NSFileSystemNodes = NSString.Create("NSFileSystemNodes").retain();
		public static readonly NSString NSFileSystemFreeNodes = NSString.Create("NSFileSystemFreeNodes").retain();
		public static readonly NSString NSFileSystemNumber = NSString.Create("NSFileSystemNumber").retain();

		// Item Attribute Keys
		public static readonly NSString NSFileType = NSString.Create("NSFileType").retain();
		public static readonly NSString NSFileTypeDirectory = NSString.Create("NSFileTypeDirectory").retain();
		public static readonly NSString NSFileTypeRegular = NSString.Create("NSFileTypeRegular").retain();
		public static readonly NSString NSFileTypeSymbolicLink = NSString.Create("NSFileTypeSymbolicLink").retain();
		public static readonly NSString NSFileTypeSocket = NSString.Create("NSFileTypeSocket").retain();
		public static readonly NSString NSFileTypeCharacterSpecial = NSString.Create("NSFileTypeCharacterSpecial").retain();
		public static readonly NSString NSFileTypeBlockSpecial = NSString.Create("NSFileTypeBlockSpecial").retain();
		public static readonly NSString NSFileTypeUnknown = NSString.Create("NSFileTypeUnknown").retain();
		public static readonly NSString NSFileSize = NSString.Create("NSFileSize").retain();
		public static readonly NSString NSFileModificationDate = NSString.Create("NSFileModificationDate").retain();
		public static readonly NSString NSFileReferenceCount = NSString.Create("NSFileReferenceCount").retain();
		public static readonly NSString NSFileDeviceIdentifier = NSString.Create("NSFileDeviceIdentifier").retain();
		public static readonly NSString NSFileOwnerAccountName = NSString.Create("NSFileOwnerAccountName").retain();
		public static readonly NSString NSFileGroupOwnerAccountName = NSString.Create("NSFileGroupOwnerAccountName").retain();
		public static readonly NSString NSFilePosixPermissions = NSString.Create("NSFilePosixPermissions").retain();
//		public static readonly NSString NSFileSystemNumber = NSString.Create("NSFileSystemNumber").retain();
		public static readonly NSString NSFileSystemFileNumber = NSString.Create("NSFileSystemFileNumber").retain();
		public static readonly NSString NSFileExtensionHidden = NSString.Create("NSFileExtensionHidden").retain();
		public static readonly NSString NSFileHFSCreatorCode = NSString.Create("NSFileHFSCreatorCode").retain();
		public static readonly NSString NSFileHFSTypeCode = NSString.Create("NSFileHFSTypeCode").retain();
		public static readonly NSString NSFileImmutable = NSString.Create("NSFileImmutable").retain();
		public static readonly NSString NSFileAppendOnly = NSString.Create("NSFileAppendOnly").retain();
		public static readonly NSString NSFileCreationDate = NSString.Create("NSFileCreationDate").retain();
		public static readonly NSString NSFileOwnerAccountID = NSString.Create("NSFileOwnerAccountID").retain();
		public static readonly NSString NSFileGroupOwnerAccountID = NSString.Create("NSFileGroupOwnerAccountID").retain();
		public static readonly NSString NSFileBusy = NSString.Create("NSFileBusy").retain();
	}
}