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

namespace MCocoa
{
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/DOCUMENTATION/Cocoa/Reference/ApplicationKit/Classes/NSMenuItem_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSMenuItem : NSObject
	{
		public static NSMenuItem Create(string title)
		{
			return Create(title, null, string.Empty, null);
		}
		
		public static NSMenuItem Create(string title, string selector)
		{
			return Create(title, selector, string.Empty, null);
		}
		
		public static NSMenuItem Create(string title, string selector, NSObject target)
		{
			return Create(title, selector, string.Empty, target);
		}
		
		/// <param name = "title">The default menu item text.</param>
		/// <param name = "selector">The name of the method to call when the menu item is selected.</param>
		/// <param name = "charCode">The menu item's key equivalent.</param>
		/// <param name = "target">The instance to call when the menu item is selected. If null the first responder is used.</param>
		public static NSMenuItem Create(string title, string selector, string charCode, NSObject target)
		{
			NSMenuItem result = (NSMenuItem) ms_class.Call("alloc").
				Call("initWithTitle:action:keyEquivalent:", NSString.Create(title),
					selector != null ? new Selector(selector) : null, NSString.Create(charCode));
			result.autorelease();
			
			if (target != null)
				result.setTarget(target);
				
			return result;
		}
	}
}
