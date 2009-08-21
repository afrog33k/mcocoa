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
using System.Runtime.InteropServices;
using OldCollections = System.Collections;

namespace MCocoa
{
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Classes/NSString_Class/Reference/NSString.html">docs</a>.</summary>
	public partial class NSString : NSObject, IEnumerable<char>
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
			IntPtr buffer = FastPath.CreateU8Buffer(str);
			NSString result = ms_class.Call("stringWithUTF8String:", buffer).To<NSString>();
			FastPath.FreeBuffer(str, buffer);
			
			return result;
		}
		
		public static NSString Create(string format, params object[] args)
		{
			return Create(string.Format(format, args));
		}
		
		public static NSString operator+(NSString lhs, NSString rhs)
		{
			return lhs.stringByAppendingString(rhs);
		}
		
		public static NSString operator+(NSString lhs, string rhs)
		{
			return lhs.stringByAppendingString(NSString.Create(rhs));
		}
		
		/// <exclude/>
		[Pure]
		public void getCharacters(out string str)
		{
			IntPtr buffer = Marshal.AllocHGlobal((int) (2*length()));
			Unused.Value = Call("getCharacters:", buffer);
			
			str = Marshal.PtrToStringUni(buffer, (int) length());
			Marshal.FreeHGlobal(buffer);
		}
		
		/// <exclude/>
		[Pure]
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
		
		OldCollections.IEnumerator OldCollections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		
		/// <summary>Allows strings to be enumerated using foreach.</summary>
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
		
		public static bool operator!=(NSString lhs, NSString rhs)
		{
			return !(lhs == rhs);
		}
		
		public bool Equals(string rhs)
		{
			bool equal = false;
			
			if (rhs != null)
			{
				if (length() == rhs.Length)
					equal = description() == rhs;
			}
			else
			{
				equal = IsNil();
			}
			
			return equal;
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
	
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Classes/nsmutablestring_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSMutableString : NSString
	{
		/// <exclude/>
		// NSString.h says, "NSMutableString responds properly to all NSString creation methods."
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithCharacters_length(string characters, UInt32 length)
		{
			return base.initWithCharacters_length(characters, length).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithUTF8String(string nullTerminatedCString)
		{
			return base.initWithUTF8String(nullTerminatedCString).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithString(NSString aString)
		{
			return base.initWithString(aString).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithData_encoding(NSData data, UInt32 encoding)
		{
			return base.initWithData_encoding(data, encoding).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithBytes_length_encoding(IntPtr bytes, UInt32 len, UInt32 encoding)
		{
			return base.initWithBytes_length_encoding(bytes, len, encoding).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithCString_encoding(string nullTerminatedCString, UInt32 encoding)
		{
			return base.initWithCString_encoding(nullTerminatedCString, encoding).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithContentsOfURL_encoding_error(NSURL url, UInt32 enc, out NSError error)
		{
			return base.initWithContentsOfURL_encoding_error(url, enc, out error).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithContentsOfFile_encoding_error(NSString path, UInt32 enc, out NSError error)
		{
			return base.initWithContentsOfFile_encoding_error(path, enc, out error).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithContentsOfURL_usedEncoding_error(NSURL url, out UInt32 enc, out NSError error)
		{
			return base.initWithContentsOfURL_usedEncoding_error(url, out enc, out error).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableString initWithContentsOfFile_usedEncoding_error(NSString path, out UInt32 enc, out NSError error)
		{
			return base.initWithContentsOfFile_usedEncoding_error(path, out enc, out error).To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static new NSMutableString stringWithString(NSString string_)
		{
			IntPtr exception_ = IntPtr.Zero;
			IntPtr buffer_string_ = FastPath.CreateBuffer(string_);
			IntPtr result_ = DirectCalls.Callpp(ms_class, new Selector("stringWithString:"), buffer_string_, ref exception_);
			FastPath.FreeBuffer(string_, buffer_string_);
			if (exception_ != IntPtr.Zero)
				CocoaException.Raise(exception_);
			
			return result_.To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static new NSMutableString stringWithCharacters_length(string characters, UInt32 length)
		{
			IntPtr exception_ = IntPtr.Zero;
			IntPtr buffer_characters = FastPath.CreateU32Buffer(characters);
			IntPtr result_ = DirectCalls.Callppi(ms_class, new Selector("stringWithCharacters:length:"), buffer_characters, unchecked((Int32) length), ref exception_);
			FastPath.FreeBuffer(characters, buffer_characters);
			if (exception_ != IntPtr.Zero)
				CocoaException.Raise(exception_);
			
			return result_.To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static new NSMutableString stringWithUTF8String(string nullTerminatedCString)
		{
			IntPtr exception_ = IntPtr.Zero;
			IntPtr buffer_nullTerminatedCString = FastPath.CreateU8Buffer(nullTerminatedCString);
			IntPtr result_ = DirectCalls.Callpp(ms_class, new Selector("stringWithUTF8String:"), buffer_nullTerminatedCString, ref exception_);
			FastPath.FreeBuffer(nullTerminatedCString, buffer_nullTerminatedCString);
			if (exception_ != IntPtr.Zero)
				CocoaException.Raise(exception_);
			
			return result_.To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static new NSMutableString stringWithCString_encoding(string cString, UInt32 enc)
		{
			IntPtr exception_ = IntPtr.Zero;
			IntPtr buffer_cString = FastPath.CreateU8Buffer(cString);
			IntPtr result_ = DirectCalls.Callppi(ms_class, new Selector("stringWithCString:encoding:"), buffer_cString, unchecked((Int32) enc), ref exception_);
			FastPath.FreeBuffer(cString, buffer_cString);
			if (exception_ != IntPtr.Zero)
				CocoaException.Raise(exception_);
			
			return result_.To<NSMutableString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static new NSMutableString stringWithContentsOfURL_encoding_error(NSURL url, UInt32 enc, out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			NSMutableString result_ = (NSMutableString) ms_class.Call("stringWithContentsOfURL:encoding:error:", url, enc, errorPtr);
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? new NSError(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return result_;
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static new NSMutableString stringWithContentsOfFile_encoding_error(NSString path, UInt32 enc, out NSError error)
		{
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			NSMutableString result_ = (NSMutableString) ms_class.Call("stringWithContentsOfFile:encoding:error:", path, enc, errorPtr);
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? new NSError(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return result_;
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static new NSMutableString stringWithContentsOfURL_usedEncoding_error(NSURL url, out UInt32 enc, out NSError error)
		{
			IntPtr encPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(UInt32)));
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			NSMutableString result_ = (NSMutableString) ms_class.Call("stringWithContentsOfURL:usedEncoding:error:", url, encPtr, errorPtr);
			enc = (UInt32) Marshal.PtrToStructure(encPtr, typeof(UInt32));
			Marshal.FreeHGlobal(encPtr);
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? new NSError(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return result_;
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public static new NSMutableString stringWithContentsOfFile_usedEncoding_error(NSString path, out UInt32 enc, out NSError error)
		{
			IntPtr encPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(UInt32)));
			IntPtr errorPtr = Marshal.AllocHGlobal(4);
			Marshal.WriteInt32(errorPtr, 0);
			
			NSMutableString result_ = (NSMutableString) ms_class.Call("stringWithContentsOfFile:usedEncoding:error:", path, encPtr, errorPtr);
			enc = (UInt32) Marshal.PtrToStructure(encPtr, typeof(UInt32));
			Marshal.FreeHGlobal(encPtr);
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? new NSError(errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return result_;
		}
	}
}
