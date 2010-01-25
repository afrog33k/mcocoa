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
	public partial class NSSavePanel : NSPanel
	{
#if MAC_OS_X_VERSION_10_6
		/// <exclude/>
		public BlockCookie beginSheetModalForWindow_completionHandler(NSWindow window, Action<int> callback)
		{
			Action<IntPtr, int> thunk = (IntPtr context, int result) => callback(result);
			
			var cookie = new BlockCookie("beginSheetModalForWindow_completionHandler", thunk);
			Call("beginSheetModalForWindow:completionHandler:", window, cookie.Block);
			return cookie;
		}
		
		/// <exclude/>
		public BlockCookie beginWithCompletionHandler(Action<int> callback)
		{
			Action<IntPtr, int> thunk = (IntPtr context, int result) => callback(result);
			
			var cookie = new BlockCookie("beginWithCompletionHandler", thunk);
			Call("beginWithCompletionHandler:", cookie.Block);
			return cookie;
		}
#endif
	}
}
