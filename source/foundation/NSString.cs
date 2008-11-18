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
		public static NSString Create(char ch)
		{
			return ms_class.Call("stringWithUTF8String:", new string(ch, 1)).To<NSString>();
		}
		
		public static NSString Create(string str) 
		{
			return ms_class.Call("stringWithUTF8String:", str).To<NSString>();
		}
				
		public Int32 compare(NSString string_)
		{
			IntPtr exception_ = IntPtr.Zero;
			Int32 result_ = DirectCalls.Callip(this, new Selector("compare:"), string_, ref exception_);
			if (exception_ != IntPtr.Zero)
				CocoaException.Raise(exception_);

			return result_;
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
			return this != IntPtr.Zero ? (string) Call("UTF8String") : null;
		}
		
		public static readonly NSString Empty = NSString.Create(string.Empty).retain();
	}
}