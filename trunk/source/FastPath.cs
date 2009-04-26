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

namespace MCocoa
{
	public static class FastPath
	{
		public static IntPtr CreateBuffer(NSObject instance)
		{
			return instance;
		}
		
		public static void FreeBuffer(NSObject instance, IntPtr buffer)
		{
			Unused.Value = instance;		// instance is just used to pick the correct overload
			Unused.Value = buffer;
		}
		
		public static IntPtr CreateU8Buffer(string instance)
		{
			return Marshal.StringToHGlobalAuto(instance);
		}
		
		public static IntPtr CreateU32Buffer(string instance)
		{
			return Marshal.StringToHGlobalUni(instance);
		}
		
		public static void FreeBuffer(string instance, IntPtr buffer)
		{
			Unused.Value = instance;
			Marshal.FreeHGlobal(buffer);
		}
		
		// structs
		public static IntPtr CreateBuffer(ValueType instance)
		{
			IntPtr buffer = Marshal.AllocHGlobal(Marshal.SizeOf(instance));
			Marshal.StructureToPtr(instance, buffer, false);
			return buffer;
		}
		
		public static void FreeBuffer(ValueType instance, IntPtr buffer)
		{
			Unused.Value = instance;
			Marshal.FreeHGlobal(buffer);
		}
	}
}