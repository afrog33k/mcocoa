// Copyright (C) 2009 Jesse Jones
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
	public partial class NSData : NSObject
	{
		public static NSData Create(byte[] data)
		{
			GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
			
			NSData result = NSData.Alloc();
			result = result.initWithBytes_length(handle.AddrOfPinnedObject(), (uint) data.Length);
			result.autorelease();
			
			handle.Free();
			return result;
		}
		
		/// <exclude/>
		[Pure]
		public byte[] bytes()
		{
			int len = (int) length();
			byte[] buffer = new byte[len];
			
			if (len > 0)
			{
				IntPtr ptr = DoGetBytes();
				Marshal.Copy(ptr, buffer, 0, len);
			}
			
			return buffer;
		}
		
		/// <exclude/>
		[Pure]
		public void getBytes(out byte[] buffer)
		{
			buffer = bytes();
		}
		
		/// <exclude/>
		[Pure]
		public void getBytes_length(out byte[] buffer, UInt32 length)
		{
			int len = (int) Math.Min(this.length(), length);
			buffer = new byte[len];
			
			if (len > 0)
			{
				IntPtr ptr = DoGetBytes();
				Marshal.Copy(ptr, buffer, 0, len);
			}
		}
		
		/// <exclude/>
		[Pure]
		public void getBytes_range(out byte[] buffer, NSRange range)
		{
			if (range.location < 0)
				throw new ArgumentException("range.location is negative");
			if (range.length < 0)
				throw new ArgumentException("range.length is negative");
			if (range.location + range.length > length())
				throw new ArgumentException("range upper bound is too large");
			
			buffer = new byte[range.length];
			
			if (range.length > 0)
			{
				IntPtr ptr = DoGetBytes();
				Marshal.Copy(ptr, buffer, range.location, range.length);
			}
		}
		
		#region Private Methods
		[Pure]
		private IntPtr DoGetBytes()
		{
			IntPtr exception_ = IntPtr.Zero;
			IntPtr result_ = DirectCalls.Callp(this, new Selector("bytes"), ref exception_);
			if (exception_ != IntPtr.Zero)
				CocoaException.Raise(exception_);
			
			return result_;
		}
		#endregion
	}
}
