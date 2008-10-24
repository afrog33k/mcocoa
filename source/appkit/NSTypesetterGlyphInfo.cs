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
	[Register("_NSTypesetterGlyphInfo")]
	public struct NSTypesetterGlyphInfo
	{
		public NSPoint curLocation;		// Location (relative to the baseline) for laying this glyph out 
		public float extent;			// Required space from curLocation to lay this glyph out; -1.0 if not set 
		public float belowBaseline;		// Distance from baseline to bottom of the line fragment required for all the glyphs so far, including this one (positive if baseline is above the bottom of the line fragment) 
		public float aboveBaseline;		// Distance from baseline to top of the line fragment required for all the glyphs so far, including this one (positive if baseline is below the top of the line fragment) 
		public UInt32 glyphCharacterIndex;		// ...and its char index 
		public IntPtr font;			// ...and its font 
		public NSSize attachmentSize;  	// Size of the character if it's an attachment; otherwise meaningless 
		public byte _giflags;
	}
}