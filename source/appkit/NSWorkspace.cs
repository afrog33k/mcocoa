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
	// http://developer.apple.com/documentation/Cocoa/Reference/ApplicationKit/Classes/NSWorkspace_Class/Reference/Reference.html#//apple_ref/doc/uid/20000391-BCIEEFBI
	public static partial class Externs
	{
		// Return values for type in getInfoForFile
		public static readonly NSString NSPlainFileType = NSString.Create(string.Empty).Retain();
		public static readonly NSString NSDirectoryFileType = NSString.Create("NXDirectoryFileType").Retain();
		public static readonly NSString NSApplicationFileType = NSString.Create("app").Retain();
		public static readonly NSString NSFilesystemFileType = NSString.Create("NXFilesystemFileType").Retain();
		public static readonly NSString NSShellCommandFileType = NSString.Create("NXShellCommandFileType").Retain();
		
		// Possible values for operation in performFileOperation
		public static readonly NSString NSWorkspaceMoveOperation = NSString.Create("move").Retain();
		public static readonly NSString NSWorkspaceCopyOperation = NSString.Create("copy").Retain();
		public static readonly NSString NSWorkspaceLinkOperation = NSString.Create("link").Retain();
		public static readonly NSString NSWorkspaceCompressOperation = NSString.Create("compress").Retain();
		public static readonly NSString NSWorkspaceDecompressOperation = NSString.Create("decompress").Retain();
		public static readonly NSString NSWorkspaceEncryptOperation = NSString.Create("encrypt").Retain();
		public static readonly NSString NSWorkspaceDecryptOperation = NSString.Create("decrypt").Retain();
		public static readonly NSString NSWorkspaceDestroyOperation = NSString.Create("destroy").Retain();
		public static readonly NSString NSWorkspaceRecycleOperation = NSString.Create("recycle").Retain();
		public static readonly NSString NSWorkspaceDuplicateOperation = NSString.Create("duplicate").Retain();
	}
}
