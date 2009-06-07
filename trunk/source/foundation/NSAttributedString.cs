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
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Classes/nsattributedstring_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSAttributedString : NSObject
	{
		/// <summary>Creates a new NSAttributedString with no attributes.</summary>
		[ThreadModel(ThreadModel.MainThread)]
		public static NSAttributedString Create(string text)
		{
			NSAttributedString result = ms_class.Alloc().Call("initWithString:", NSString.Create(text)).To<NSAttributedString>();
			result.autorelease();
			return result;
		}
		
		/// <summary>Creates a new NSAttributedString with one attribute.</summary>
		[ThreadModel(ThreadModel.MainThread)]
		public static NSAttributedString Create(string text, NSString attr, NSObject value)
		{
			return Create(text, CreateDict(attr, value));
		}
		
		/// <summary>Creates a new NSAttributedString with attributes from the dictionary.</summary>
		[ThreadModel(ThreadModel.MainThread)]
		public static NSAttributedString Create(char ch, NSDictionary attrs)
		{
			NSAttributedString result = ms_class.Alloc().Call("initWithString:attributes:", NSString.Create(ch), attrs).To<NSAttributedString>();
			result.autorelease();
			return result;
		}
		
		/// <summary>Creates a new NSAttributedString with attributes from the dictionary.</summary>
		[ThreadModel(ThreadModel.MainThread)]
		public static NSAttributedString Create(string text, NSDictionary attrs)
		{
			NSAttributedString result = ms_class.Alloc().Call("initWithString:attributes:", NSString.Create(text), attrs).To<NSAttributedString>();
			result.autorelease();
			return result;
		}
		
		[ThreadModel(ThreadModel.MainThread)]
		protected static NSDictionary CreateDict(NSString attr, NSObject value)
		{
			NSMutableDictionary dict = NSMutableDictionary.Create();
			dict.setObject_forKey(value, attr);
			return dict;
		}
		
		public override string ToString()
		{
			return this != IntPtr.Zero ? string_().ToString() : "nil";
		}
	}
	
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Classes/nsmutableattributedstring_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSMutableAttributedString : NSAttributedString
	{
		/// <summary>Creates a new NSMutableAttributedString with no attributes.</summary>
		public new static NSMutableAttributedString Create(string text)
		{
			NSMutableAttributedString result = ms_class.Alloc().Call("initWithString:", NSString.Create(text)).To<NSMutableAttributedString>();
			result.autorelease();
			return result;
		}
		
		/// <summary>Creates a new NSMutableAttributedString with one attribute.</summary>
		public new static NSMutableAttributedString Create(string text, NSString attr, NSObject value)
		{
			return Create(text, CreateDict(attr, value));
		}
		
		/// <summary>Creates a new NSMutableAttributedString with attributes from the dictionary.</summary>
		public new static NSMutableAttributedString Create(char ch, NSDictionary attrs)
		{
			NSMutableAttributedString result = ms_class.Alloc().Call("initWithString:attributes:", NSString.Create(ch), attrs).To<NSMutableAttributedString>();
			result.autorelease();
			return result;
		}
		
		/// <summary>Creates a new NSMutableAttributedString with attributes from the dictionary.</summary>
		public new static NSMutableAttributedString Create(string text, NSDictionary attrs)
		{
			NSMutableAttributedString result = ms_class.Alloc().Call("initWithString:attributes:", NSString.Create(text), attrs).To<NSMutableAttributedString>();
			result.autorelease();
			return result;
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableAttributedString initWithString(NSString str)
		{
			return base.initWithString(str).To<NSMutableAttributedString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableAttributedString initWithString_attributes(NSString str, NSDictionary attrs)
		{
			return base.initWithString_attributes(str, attrs).To<NSMutableAttributedString>();
		}
		
		/// <exclude/>
		[ThreadModel(ThreadModel.Concurrent)]
		public new NSMutableAttributedString initWithAttributedString(NSAttributedString attrStr)
		{
			return base.initWithAttributedString(attrStr).To<NSMutableAttributedString>();
		}
	}
}
