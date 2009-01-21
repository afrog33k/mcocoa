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

namespace MCocoa
{
	public partial class NSString : NSObject
	{		
		public static NSString Create(char ch)
		{
			string s = new string(ch, 1);
			
			IntPtr buffer = Marshal.StringToHGlobalAuto(s);
			NSString result = ms_class.Call("stringWithUTF8String:", buffer).To<NSString>();
			Marshal.FreeHGlobal(buffer);
			
			return result;
		}
		
		public static NSString Create(string str) 
		{
			IntPtr buffer = Marshal.StringToHGlobalAuto(str);
			NSString result = ms_class.Call("stringWithUTF8String:", buffer).To<NSString>();
			Marshal.FreeHGlobal(buffer);
			
			return result;
		}
				
		public static NSString Create(string format, params object[] args) 
		{
			IntPtr buffer = Marshal.StringToHGlobalAuto(string.Format(format, args));
			NSString result = ms_class.Call("stringWithUTF8String:", buffer).To<NSString>();
			Marshal.FreeHGlobal(buffer);
			
			return result;
		}
				
		public void getCharacters(out string str)
		{
			IntPtr buffer = Marshal.AllocHGlobal((int) (2*length()));
			Unused.Value = Call("getCharacters:", buffer);
			
			str = Marshal.PtrToStringUni(buffer, (int) length());
			Marshal.FreeHGlobal(buffer);
		}
						
		public void getCharacters_range(NSRange range, out string str)
		{
			IntPtr buffer = Marshal.AllocHGlobal(2*range.length);
			Unused.Value = Call("getCharacters:range:", buffer, range);
			
			str = Marshal.PtrToStringUni(buffer, range.length);
			Marshal.FreeHGlobal(buffer);
		}
		
		public char this[int index]
		{
			get {return characterAtIndex((uint) index);}
		}
						
		public char this[uint index]
		{
			get {return characterAtIndex(index);}
		}
						
		public IEnumerator<char> GetEnumerator()
		{
			uint len = length();
			for (uint i = 0; i < len; ++i)
			{
				yield return characterAtIndex(i);
			}
		}

		public override string ToString()
		{
			return this != IntPtr.Zero ? Marshal.PtrToStringAuto((IntPtr) Call("UTF8String")) : "nil";
		}
		
		public static bool operator==(NSString lhs, NSString rhs)
		{
			if ((object) rhs == null)
				return (object) lhs == null;
			
			return lhs.compare(rhs) == 0;
		}
		
		public static bool operator==(NSString lhs, string rhs)
		{
			if ((object) rhs == null)
				return (object) lhs == null;
			
			return lhs.ToString() == rhs;
		}
		
		public static bool operator!=(NSString lhs, NSString rhs)
		{
			return !(lhs == rhs);
		}
		
		public static bool operator!=(NSString lhs, string rhs)
		{
			return !(lhs == rhs);
		}
		
		// Compiler requires us to define these two.
		public override bool Equals(object rhsObj)
		{
			return base.Equals(rhsObj);
		}
	
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static readonly NSString Empty = NSString.Create(string.Empty).Retain();
	}
}