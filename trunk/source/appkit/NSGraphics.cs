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
		public static readonly LazyString NSCalibratedWhiteColorSpace = new LazyString("NSCalibratedWhiteColorSpace");
		public static readonly LazyString NSCalibratedBlackColorSpace = new LazyString("NSCalibratedBlackColorSpace");
		public static readonly LazyString NSCalibratedRGBColorSpace = new LazyString("NSCalibratedRGBColorSpace");
		public static readonly LazyString NSDeviceWhiteColorSpace = new LazyString("NSDeviceWhiteColorSpace");
		public static readonly LazyString NSDeviceBlackColorSpace = new LazyString("NSDeviceBlackColorSpace");
		public static readonly LazyString NSDeviceRGBColorSpace = new LazyString("NSDeviceRGBColorSpace");
		public static readonly LazyString NSDeviceCMYKColorSpace = new LazyString("NSDeviceCMYKColorSpace");
		public static readonly LazyString NSNamedColorSpace = new LazyString("NSNamedColorSpace");
		public static readonly LazyString NSPatternColorSpace = new LazyString("NSPatternColorSpace");
		public static readonly LazyString NSCustomColorSpace = new LazyString("NSCustomColorSpace");
		
		// Keys for deviceDescription dictionaries
		public static readonly LazyString NSDeviceResolution = new LazyString("NSDeviceResolution");
		public static readonly LazyString NSDeviceColorSpaceName = new LazyString("NSDeviceColorSpaceName");
		public static readonly LazyString NSDeviceBitsPerSample = new LazyString("NSDeviceBitsPerSample");
		public static readonly LazyString NSDeviceIsScreen = new LazyString("NSDeviceIsScreen");
		public static readonly LazyString NSDeviceIsPrinter = new LazyString("NSDeviceIsPrinter");
		public static readonly LazyString NSDeviceSize = new LazyString("NSDeviceSize");
		
		// Standard gray values for the 2-bit deep grayscale colorspace
		public const float NSWhite = 1.000000f;
		public const float NSLightGray = 0.666667f;
		public const float NSDarkGray = 0.333333f;
		public const float NSBlack = 0.000000f;
	}
}
