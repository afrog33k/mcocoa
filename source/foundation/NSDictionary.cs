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
using System.Collections.Generic;
using OldCollections = System.Collections;

namespace MCocoa
{
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Classes/NSDictionary_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSDictionary : NSObject, IEnumerable<KeyValuePair<NSObject, NSObject>>
	{
		public static NSDictionary dictionaryWithObjectsAndKeys(params NSObject[] args)
		{
			// TODO: This is not ideal but it's hard to efficiently create an immutable
			// dictionary using this method when we don't support variadic method calls.
			return NSMutableDictionary.dictionaryWithObjectsAndKeys(args);
		}
		
		OldCollections.IEnumerator OldCollections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		
		/// <summary>Allows dictionaries to be enumerated using foreach.</summary>
		public IEnumerator<KeyValuePair<NSObject, NSObject>> GetEnumerator()
		{
			NSEnumerator keys = keyEnumerator();
			
			NSObject key = keys.nextObject();
			while (!NSObject.IsNullOrNil(key))
			{
				NSObject value = objectForKey(key);
				yield return new KeyValuePair<NSObject, NSObject>(key, value);
				
				key = keys.nextObject();
			}
		}
	}
	
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/mac/library/documentation/Cocoa/Reference/Foundation/Classes/NSMutableDictionary_Class/Reference/Reference.html#//apple_ref/occ/cl/NSMutableDictionary">docs</a>.</summary>
	public partial class NSMutableDictionary : NSDictionary
	{
		public static new NSMutableDictionary dictionaryWithObjectsAndKeys(params NSObject[] args)
		{
			Contract.Requires(args.Length % 2 == 0, "args length must be even");
			
			var result = NSMutableDictionary.Create();
			for (int i = 0; i < args.Length; i += 2)
			{
				result.setObject_forKey(args[i], args[i + 1]);
			}
			
			return result;
		}
	}
}
