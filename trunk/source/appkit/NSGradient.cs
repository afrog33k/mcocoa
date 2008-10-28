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
	public partial class NSGradient : NSObject
	{
		public static NSGradient Create(NSColor start, NSColor end)
		{
			return ms_class.Call("alloc").Call("initWithStartingColor:endingColor:", start, end).To<NSGradient>();
		}
		
		public static NSGradient Create(NSArray colors)
		{
			return Create(colors, new float[0]);
		}
		
		public static NSGradient Create(NSArray colors, float[] locations)
		{
			return Create(colors, locations, NSColorSpace.genericRGBColorSpace());
		}
		
		public static NSGradient Create(NSArray colors, float[] locations, NSColorSpace space)
		{
			return ms_class.Call("alloc").Call("initWithColors:atLocations:colorSpace:", colors, locations, space).To<NSGradient>();
		}
	}
}
