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
	/// <summary>Used by the generated code to avoid dynamic calls where possible.</summary>
	/// <remarks>It's a lot faster to use this code along with mobjc's DirectCalls class instead
	/// of NSObject.Call. However this is not something that most users will need to use
	/// unless they are generating wrappers for new Objective-C frameworks.</remarks>
	[ThreadModel(ThreadModel.Concurrent)]
	public static class FastPath
	{
		public static IntPtr CreateBuffer(NSObject instance)
		{
			return instance;
		}
		
		public static void FreeBuffer(NSObject instance, IntPtr buffer)
		{
		}
		
		public static IntPtr CreateU8Buffer(string instance)
		{
			// NSString does not seem to support embedded nulls so to avoid a premature
			// truncation we'll replace nulls with the replacement character.
			string s = instance.Replace('\x0', Replacement);
			
			return Marshal.StringToHGlobalAuto(s);
		}
		
		public static IntPtr CreateU32Buffer(string instance)
		{
			// NSString does not seem to support embedded nulls so to avoid a premature
			// truncation we'll replace nulls with the replacement character.
			string s = instance.Replace('\x0', Replacement);
			
			return Marshal.StringToHGlobalUni(s);
		}
		
		// instance is just used to pick the correct overload
		public static void FreeBuffer(string instance, IntPtr buffer)
		{
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
			Marshal.FreeHGlobal(buffer);
		}
		
		private static readonly char Replacement = '\xFFFD';
	}
}
