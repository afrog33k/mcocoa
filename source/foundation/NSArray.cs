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
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OldCollections = System.Collections;

namespace MCocoa
{
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/DOCUMENTATION/Cocoa/Reference/Foundation/Classes/NSArray_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSArray : NSObject, IEnumerable<NSObject>
	{
		/// <summary>Converts the strings to NSStrings and creates a new array.</summary>
		public static NSArray Create(params string[] args)
		{
			NSString[] strs = new NSString[args.Length];
			for (int i = 0; i < args.Length; ++i)
				strs[i] = NSString.Create(args[i]);
				
			return Create(strs);
		}
		
		public static NSArray Create(params NSObject[] args)
		{
			IntPtr[] ptrs = new IntPtr[args.Length];
			for (int i = 0; i < args.Length; ++i)
				ptrs[i] = (IntPtr) args[i];
				
			GCHandle handle = GCHandle.Alloc(ptrs, GCHandleType.Pinned);
			IntPtr objects = handle.AddrOfPinnedObject();
			
			NSArray result = ms_class.Call("arrayWithObjects:count:", objects, (uint) args.Length).To<NSArray>();
			handle.Free();
			
			return result;
		}
		
		OldCollections.IEnumerator OldCollections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		
		/// <summary>Allows NSArrays to be enumerated with foreach.</summary>
		public IEnumerator<NSObject> GetEnumerator()
		{
			for (uint i = 0; i < count(); ++i)
				yield return objectAtIndex(i);
		}
	}
	
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Classes/NSMutableArray_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSMutableArray : NSArray
	{
		/// <summary>Converts the strings to NSStrings and creates a new array.</summary>
		public static new NSMutableArray Create(params string[] args)
		{
			NSString[] strs = new NSString[args.Length];
			for (int i = 0; i < args.Length; ++i)
				strs[i] = NSString.Create(args[i]);
				
			return Create(strs);
		}
		
		public static new NSMutableArray Create(params NSObject[] args)
		{
			IntPtr[] ptrs = new IntPtr[args.Length];
			for (int i = 0; i < args.Length; ++i)
				ptrs[i] = (IntPtr) args[i];
				
			GCHandle handle = GCHandle.Alloc(ptrs, GCHandleType.Pinned);
			IntPtr objects = handle.AddrOfPinnedObject();
			
			NSMutableArray result = ms_class.Call("arrayWithObjects:count:", objects, (uint) args.Length).To<NSMutableArray>();
			handle.Free();
			
			return result;
		}
	}
}
