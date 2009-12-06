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
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace MCocoa
{
	public partial class NSView : NSResponder
	{
		/// <exclude/>
		public delegate int SortFunction(NSObject lhs, NSObject rhs, IntPtr context);
		
		/// <exclude/>
		public void sortSubviewsUsingFunction_context(SortFunction function, IntPtr context)
		{
			Action<IntPtr, IntPtr, IntPtr> thunk = (IntPtr lhs, IntPtr rhs, IntPtr ctxt) =>
				function(NSObject.Lookup(lhs), NSObject.Lookup(rhs), ctxt);
			
			IntPtr fp = Marshal.GetFunctionPointerForDelegate(thunk);
			Call("sortSubviewsUsingFunction:context:", fp, context);
			
			GC.KeepAlive(thunk);
		}
		
		/// <exclude/>
		[Pure]
		public NSView[] subviews()
		{
			NSArray items = (NSArray) Call("subviews");
			
			NSView[] result = new NSView[items.count()];
			for (int i = 0; i < items.count(); ++i)
				result[i] = items.objectAtIndex((uint) i).To<NSView>();
				
			return result;
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.MainThread)]
		public void setSubviews(NSView[] newSubviews)
		{
			NSMutableArray array = NSMutableArray.Create();
			foreach (NSView view in newSubviews)
				array.addObject(view);
				
			Unused.Value = Call("setSubviews:", array);
		}
	}
}
