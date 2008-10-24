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
	public partial class NSString : NSObject
	{		
		public NSString(char ch) : base(Native.Call("[NSString stringWithUTF8String:{0}]", new string(ch, 1)))
		{
		}
		
		public NSString(string str) : base(Native.Call("[NSString stringWithUTF8String:{0}]", str))
		{
		}
		
		public string GetCharacters(NSRange range)
		{
			IntPtr buffer = Marshal.AllocHGlobal(2*range.length);
			Call("getCharacters:range:", buffer, range);
			
			string result = Marshal.PtrToStringUni(buffer, range.length);
			Marshal.FreeHGlobal(buffer);
				
			return result;
		}
						
		public override string ToString()
		{
			return this != IntPtr.Zero ? (string) Call("UTF8String") : string.Empty;
		}
		
		public static readonly NSString Empty = new NSString(string.Empty).retain();
	}
}