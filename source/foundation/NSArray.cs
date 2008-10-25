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
using System.Runtime.InteropServices;

namespace MCocoa
{
	public partial class NSArray : NSObject
	{		
		public NSArray(params string[] args) : base(DoCreate(args))
		{
		}

		public NSArray(params NSObject[] args) : base(DoCreate(args))
		{
		}
		
		#region Private Methods -----------------------------------------------
		private static IntPtr DoCreate(string[] args)
		{
			NSString[] strs = new NSString[args.Length];
			for (int i = 0; i < args.Length; ++i)
				strs[i] = new NSString(args[i]);
				
			return DoCreate(strs);
		}

		private static IntPtr DoCreate(NSObject[] args)
		{
			IntPtr[] ptrs = new IntPtr[args.Length];
			for (int i = 0; i < args.Length; ++i)
				ptrs[i] = (IntPtr) args[i];
				
			GCHandle handle = GCHandle.Alloc(ptrs, GCHandleType.Pinned);
			IntPtr objects = handle.AddrOfPinnedObject();

			return (IntPtr) Native.Call("[NSArray arrayWithObjects:{0} count:{1}]", objects, args.Length);
		}
		#endregion
	}
}