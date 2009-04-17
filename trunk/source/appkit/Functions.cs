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
using System.Diagnostics;
using System.Runtime.InteropServices;

// http://developer.apple.com/documentation/Cocoa/Reference/ApplicationKit/Miscellaneous/AppKit_Functions/Reference/reference.html#//apple_ref/doc/uid/TP40004154-I1-DontLinkElementID_61
namespace MCocoa
{
	public static partial class Functions
	{
		public static void NSBeep()
		{
			NativeMethods.NSBeep();
		}
		
		#region Panels
		public static void NSBeginAlertSheet(NSString title, NSString defaultButton, NSString alternateButton, NSString otherButton, NSWindow docWindow, NSObject modalDelegate, string didEndSelector, string didDismissSelector, IntPtr contextInfo, NSString message)
		{
			Selector endSelector = didEndSelector != null ? new Selector(didEndSelector) : null;
			Selector dismissSelector = didDismissSelector != null ? new Selector(didDismissSelector) : null;
			
			NativeMethods.NSBeginAlertSheet(title, defaultButton, alternateButton, otherButton, docWindow, modalDelegate, endSelector, dismissSelector, contextInfo, message);
		}
		
		public static void NSBeginInformationalAlertSheet(NSString title, NSString defaultButton, NSString alternateButton, NSString otherButton, NSWindow docWindow, NSObject modalDelegate, string didEndSelector, string didDismissSelector, IntPtr contextInfo, NSString message)
		{
			Selector endSelector = didEndSelector != null ? new Selector(didEndSelector) : null;
			Selector dismissSelector = didDismissSelector != null ? new Selector(didDismissSelector) : null;
			
			NativeMethods.NSBeginInformationalAlertSheet(title, defaultButton, alternateButton, otherButton, docWindow, modalDelegate, endSelector, dismissSelector, contextInfo, message);
		}
		
		public static void NSBeginCriticalAlertSheet(NSString title, NSString defaultButton, NSString alternateButton, NSString otherButton, NSWindow docWindow, NSObject modalDelegate, string didEndSelector, string didDismissSelector, IntPtr contextInfo, NSString message)
		{
			Selector endSelector = didEndSelector != null ? new Selector(didEndSelector) : null;
			Selector dismissSelector = didDismissSelector != null ? new Selector(didDismissSelector) : null;
			
			NativeMethods.NSBeginCriticalAlertSheet(title, defaultButton, alternateButton, otherButton, docWindow, modalDelegate, endSelector, dismissSelector, contextInfo, message);
		}

		public static int NSRunAlertPanel(NSString title, NSString message)
		{
			return (int) NativeMethods.NSRunAlertPanel(title, message, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		}
		
		public static int NSRunAlertPanel(NSString title, NSString message, NSString defaultButton, NSString alternateButton, NSString otherButton)
		{
			return (int) NativeMethods.NSRunAlertPanel(title, message, defaultButton, alternateButton, otherButton);
		}
		
		public static int NSRunInformationalAlertPanel(NSString title, NSString message)
		{
			return (int) NativeMethods.NSRunInformationalAlertPanel(title, message, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		}
		
		public static int NSRunInformationalAlertPanel(NSString title, NSString message, NSString defaultButton, NSString alternateButton, NSString otherButton)
		{
			return (int) NativeMethods.NSRunInformationalAlertPanel(title, message, defaultButton, alternateButton, otherButton);
		}
		
		public static int NSRunCriticalAlertPanel(NSString title, NSString message)
		{
			return (int) NativeMethods.NSRunCriticalAlertPanel(title, message, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		}
		
		public static int NSRunCriticalAlertPanel(NSString title, NSString message, NSString defaultButton, NSString alternateButton, NSString otherButton)
		{
			return (int) NativeMethods.NSRunCriticalAlertPanel(title, message, defaultButton, alternateButton, otherButton);
		}
		#endregion
		
		#region Graphics
		public static void NSFrameRect(NSRect rect)
		{
			NativeMethods.NSFrameRect(rect);
		}
		
		public static void NSFrameRectWithWidth(NSRect rect, float width)
		{
			NativeMethods.NSFrameRectWithWidth(rect, width);
		}
		
		public static void NSFrameRectWithWidthUsingOperation(NSRect rect, float width, int op)
		{
			NativeMethods.NSFrameRectWithWidthUsingOperation(rect, width, op);
		}

		public static void NSRectFill(NSRect rect)
		{
			NativeMethods.NSRectFill(rect);
		}
		
		public static void NSRectFillList(NSRect[] rects)
		{
			NativeMethods.NSRectFillList(rects, rects.Length);
		}
		
		public static void NSRectFillListUsingOperation(NSRect[] rects, int op)
		{
			NativeMethods.NSRectFillListUsingOperation(rects, rects.Length, op);
		}
		
		public static void NSRectFillListWithColors(NSRect[] rects, NSColor[] colors)
		{
			Contract.Requires(rects.Length == colors.Length, "rects and colors have different lengths");
			
			NativeMethods.NSRectFillListWithColors(rects, colors, rects.Length);
		}
		
		public static void NSRectFillListWithColorsUsingOperation(NSRect[] rects, NSColor[] colors, int op)
		{
			Contract.Requires(rects.Length == colors.Length, "rects and colors have different lengths");
			
			NativeMethods.NSRectFillListWithColorsUsingOperation(rects, colors, rects.Length, op);
		}
		
		public static void NSRectFillUsingOperation(NSRect rect, int op)
		{
			NativeMethods.NSRectFillUsingOperation(rect, op);
		}
		
		public static void NSShowAnimationEffect(int animationEffect, NSPoint centerLocation)
		{
			NativeMethods.NSShowAnimationEffect(animationEffect, centerLocation, NSSize.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		}
		
		public static void NSShowAnimationEffect(int animationEffect, NSPoint centerLocation, NSSize size, NSObject animationDelegate, Selector didEndSelector, IntPtr contextInfo)
		{
			NativeMethods.NSShowAnimationEffect(animationEffect, centerLocation, size, animationDelegate, didEndSelector, contextInfo);
		}
		#endregion
		
		#region P/Invokes
		private static partial class NativeMethods
		{
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSBeep();
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSFrameRect(NSRect rect);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSFrameRectWithWidth(NSRect rect, float width);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSFrameRectWithWidthUsingOperation(NSRect rect, float width, int op);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSRectFill(NSRect rect);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSRectFillList(NSRect[] rects, int count);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSRectFillListUsingOperation(NSRect[] rects, int count, int op);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSRectFillListWithColors(NSRect[] rects, NSColor[] colors, int count);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSRectFillListWithColorsUsingOperation(NSRect[] rects, NSColor[] colors, int count, int op);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSRectFillUsingOperation(NSRect rect, int op);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSBeginAlertSheet(IntPtr title, IntPtr defaultButton, IntPtr alternateButton, IntPtr otherButton, IntPtr docWindow, IntPtr modalDelegate, IntPtr didEndSelector, IntPtr didDismissSelector, IntPtr contextInfo, IntPtr msgFormat);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSBeginInformationalAlertSheet(IntPtr title, IntPtr defaultButton, IntPtr alternateButton, IntPtr otherButton, IntPtr docWindow, IntPtr modalDelegate, IntPtr didEndSelector, IntPtr didDismissSelector, IntPtr contextInfo, IntPtr msgFormat);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSBeginCriticalAlertSheet(IntPtr title, IntPtr defaultButton, IntPtr alternateButton, IntPtr otherButton, IntPtr docWindow, IntPtr modalDelegate, IntPtr didEndSelector, IntPtr didDismissSelector, IntPtr contextInfo, IntPtr msgFormat);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static int NSRunAlertPanel(IntPtr title, IntPtr msgFormat, IntPtr defaultButton, IntPtr alternateButton, IntPtr otherButton);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static int NSRunInformationalAlertPanel(IntPtr title, IntPtr msgFormat, IntPtr defaultButton, IntPtr alternateButton, IntPtr otherButton);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static int NSRunCriticalAlertPanel(IntPtr title, IntPtr msgFormat, IntPtr defaultButton, IntPtr alternateButton, IntPtr otherButton);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static void NSShowAnimationEffect(int animationEffect, NSPoint centerLocation, NSSize size, IntPtr animationDelegate, IntPtr didEndSelector, IntPtr contextInfo);
		}
		#endregion
	}
}
