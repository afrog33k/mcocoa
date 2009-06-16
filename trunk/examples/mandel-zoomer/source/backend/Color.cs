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

using MCocoa;

internal struct Color
{
	public Color(byte r, byte g, byte b)
	{
		Red = r;
		Green = g;
		Blue = b;
	}
	
	public byte Red {get; private set;}
	public byte Green {get; private set;}
	public byte Blue {get; private set;}
	
	public static explicit operator NSColor(Color value)
	{
		return NSColor.colorWithDeviceRed_green_blue_alpha(
			value.Red/255.0f, value.Green/255.0f, value.Blue/255.0f, 1.0f);
	}
	
	public override string ToString()
	{
		return string.Format("({0}, {1}, {2})", Red, Green, Blue);
	}
	
	public static readonly Color Black = new Color(0, 0, 0);
	public static readonly Color Unknown = new Color(0xE8, 0xE8, 0xE8);
}
