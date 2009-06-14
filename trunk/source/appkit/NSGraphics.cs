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
	public partial class Externs
	{
		// Predefined colorspace names
		public static readonly NSString NSCalibratedWhiteColorSpace = NSString.Create("NSCalibratedWhiteColorSpace").Retain();
		public static readonly NSString NSCalibratedBlackColorSpace = NSString.Create("NSCalibratedBlackColorSpace").Retain();
		public static readonly NSString NSCalibratedRGBColorSpace = NSString.Create("NSCalibratedRGBColorSpace").Retain();
		public static readonly NSString NSDeviceWhiteColorSpace = NSString.Create("NSDeviceWhiteColorSpace").Retain();
		public static readonly NSString NSDeviceBlackColorSpace = NSString.Create("NSDeviceBlackColorSpace").Retain();
		public static readonly NSString NSDeviceRGBColorSpace = NSString.Create("NSDeviceRGBColorSpace").Retain();
		public static readonly NSString NSDeviceCMYKColorSpace = NSString.Create("NSDeviceCMYKColorSpace").Retain();
		public static readonly NSString NSNamedColorSpace = NSString.Create("NSNamedColorSpace").Retain();
		public static readonly NSString NSPatternColorSpace = NSString.Create("NSPatternColorSpace").Retain();
		public static readonly NSString NSCustomColorSpace = NSString.Create("NSCustomColorSpace").Retain();
		
		// Keys for deviceDescription dictionaries
		public static readonly NSString NSDeviceResolution = NSString.Create("NSDeviceResolution").Retain();
		public static readonly NSString NSDeviceColorSpaceName = NSString.Create("NSDeviceColorSpaceName").Retain();
		public static readonly NSString NSDeviceBitsPerSample = NSString.Create("NSDeviceBitsPerSample").Retain();
		public static readonly NSString NSDeviceIsScreen = NSString.Create("NSDeviceIsScreen").Retain();
		public static readonly NSString NSDeviceIsPrinter = NSString.Create("NSDeviceIsPrinter").Retain();
		public static readonly NSString NSDeviceSize = NSString.Create("NSDeviceSize").Retain();
		
		// Standard gray values for the 2-bit deep grayscale colorspace
		public const float NSWhite = 1.000000f;
		public const float NSLightGray = 0.666667f;
		public const float NSDarkGray = 0.333333f;
		public const float NSBlack = 0.000000f;
	}
}
