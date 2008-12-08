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
	// http://developer.apple.com/documentation/Cocoa/Reference/ApplicationKit/Classes/NSWindow_Class/Reference/Reference.html#//apple_ref/doc/uid/20000013-BCIEBJDE
	public static partial class Externs
	{
		public static readonly NSString NSWindowDidBecomeKeyNotification = NSString.Create("NSWindowDidBecomeKeyNotification").retain();
		public static readonly NSString NSWindowDidBecomeMainNotification = NSString.Create("NSWindowDidBecomeMainNotification").retain();
		public static readonly NSString NSWindowDidChangeScreenNotification = NSString.Create("NSWindowDidChangeScreenNotification").retain();
		public static readonly NSString NSWindowDidDeminiaturizeNotification = NSString.Create("NSWindowDidDeminiaturizeNotification").retain();
		public static readonly NSString NSWindowDidExposeNotification = NSString.Create("NSWindowDidExposeNotification").retain();
		public static readonly NSString NSWindowDidMiniaturizeNotification = NSString.Create("NSWindowDidMiniaturizeNotification").retain();
		public static readonly NSString NSWindowDidMoveNotification = NSString.Create("NSWindowDidMoveNotification").retain();
		public static readonly NSString NSWindowDidResignKeyNotification = NSString.Create("NSWindowDidResignKeyNotification").retain();
		public static readonly NSString NSWindowDidResignMainNotification = NSString.Create("NSWindowDidResignMainNotification").retain();
		public static readonly NSString NSWindowDidResizeNotification = NSString.Create("NSWindowDidResizeNotification").retain();
		public static readonly NSString NSWindowDidUpdateNotification = NSString.Create("NSWindowDidUpdateNotification").retain();
		public static readonly NSString NSWindowWillCloseNotification = NSString.Create("NSWindowWillCloseNotification").retain();
		public static readonly NSString NSWindowWillMiniaturizeNotification = NSString.Create("NSWindowWillMiniaturizeNotification").retain();
		public static readonly NSString NSWindowWillMoveNotification = NSString.Create("NSWindowWillMoveNotification").retain();
		public static readonly NSString NSWindowWillBeginSheetNotification = NSString.Create("NSWindowWillBeginSheetNotification").retain();
		public static readonly NSString NSWindowDidEndSheetNotification = NSString.Create("NSWindowDidEndSheetNotification").retain();
		public static readonly NSString NSWindowDidChangeScreenProfileNotification = NSString.Create("NSWindowDidChangeScreenProfileNotification").retain();
	}
}