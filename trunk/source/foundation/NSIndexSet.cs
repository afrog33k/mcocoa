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
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/DOCUMENTATION/Cocoa/Reference/Foundation/Classes/NSIndexSet_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSIndexSet : NSObject, IEnumerable<uint>
	{
		OldCollections.IEnumerator OldCollections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		
		/// <summary>Allows NSIndexSet to be enumerated using foreach.</summary>
		public IEnumerator<uint> GetEnumerator()
		{
			uint index = firstIndex();
			while (index != Enums.NSNotFound)
			{
				yield return index;
				index = indexGreaterThanIndex(index);
			}
		}
	}
}