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
	/// <exclude/>
	public static partial class Externs
	{
		// Return values for type in getInfoForFile
		public static readonly LazyString NSPlainFileType = new LazyString(string.Empty);
		public static readonly LazyString NSDirectoryFileType = new LazyString("NXDirectoryFileType");
		public static readonly LazyString NSApplicationFileType = new LazyString("app");
		public static readonly LazyString NSFilesystemFileType = new LazyString("NXFilesystemFileType");
		public static readonly LazyString NSShellCommandFileType = new LazyString("NXShellCommandFileType");
		
		// Possible values for operation in performFileOperation
		public static readonly LazyString NSWorkspaceMoveOperation = new LazyString("move");
		public static readonly LazyString NSWorkspaceCopyOperation = new LazyString("copy");
		public static readonly LazyString NSWorkspaceLinkOperation = new LazyString("link");
		public static readonly LazyString NSWorkspaceCompressOperation = new LazyString("compress");
		public static readonly LazyString NSWorkspaceDecompressOperation = new LazyString("decompress");
		public static readonly LazyString NSWorkspaceEncryptOperation = new LazyString("encrypt");
		public static readonly LazyString NSWorkspaceDecryptOperation = new LazyString("decrypt");
		public static readonly LazyString NSWorkspaceDestroyOperation = new LazyString("destroy");
		public static readonly LazyString NSWorkspaceRecycleOperation = new LazyString("recycle");
		public static readonly LazyString NSWorkspaceDuplicateOperation = new LazyString("duplicate");
	}
}
