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
	public static partial class Externs
	{
		public static readonly NSString NSFontAttributeName = new NSString("NSFont").retain();					 		// NSFont, default Helvetica 12
		public static readonly NSString NSParagraphStyleAttributeName = new NSString("NSParagraphStyle").retain();		// NSParagraphStyle, default defaultParagraphStyle
		public static readonly NSString NSForegroundColorAttributeName = new NSString("NSColor").retain();				// NSColor, default blackColor
		public static readonly NSString NSUnderlineStyleAttributeName = new NSString("NSUnderline").retain();			// NSNumber containing integer, default 0: no underline
		public static readonly NSString NSSuperscriptAttributeName = new NSString("NSSuperScript").retain();			// NSNumber containing integer, default 0
		public static readonly NSString NSBackgroundColorAttributeName = new NSString("NSBackgroundColor").retain();	// NSColor, default nil: no background
		public static readonly NSString NSAttachmentAttributeName = new NSString("NSAttachment").retain();				// NSTextAttachment, default nil
		public static readonly NSString NSLigatureAttributeName = new NSString("NSLigature").retain();					// NSNumber containing integer, default 1: default ligatures, 0: no ligatures, 2: all ligatures
		public static readonly NSString NSBaselineOffsetAttributeName = new NSString("NSBaselineOffset").retain();		// NSNumber containing floating point value, in points; offset from baseline, default 0
		public static readonly NSString NSKernAttributeName = new NSString("NSKern").retain();							// NSNumber containing floating point value, in points; amount to modify default kerning, if 0, kerning off
		public static readonly NSString NSLinkAttributeName = new NSString("NSLink").retain();							// NSURL (preferred) or NSString
		public static readonly NSString NSStrokeWidthAttributeName = new NSString("NSStrokeWidth").retain();			// NSNumber containing floating point value, in percent of font point size, default 0: no stroke; positive for stroke alone, negative for stroke and fill (a typical value for outlined text would be 3.0)
		public static readonly NSString NSStrokeColorAttributeName = new NSString("NSStrokeColor").retain();			// NSColor, default nil: same as foreground color
		public static readonly NSString NSUnderlineColorAttributeName = new NSString("NSUnderlineColor").retain();		// NSColor, default nil: same as foreground color
		public static readonly NSString NSStrikethroughStyleAttributeName = new NSString("NSStrikethrough").retain();	// NSNumber containing integer, default 0: no strikethrough
		public static readonly NSString NSStrikethroughColorAttributeName = new NSString("NSStrikethroughColor").retain();// NSColor, default nil: same as foreground color
		public static readonly NSString NSShadowAttributeName = new NSString("NSShadow").retain();						// NSShadow, default nil: no shadow
		public static readonly NSString NSObliquenessAttributeName = new NSString("NSObliqueness").retain();			// NSNumber containing floating point value; skew to be applied to glyphs, default 0: no skew
		public static readonly NSString NSExpansionAttributeName = new NSString("NSExpansion").retain();				// NSNumber containing floating point value; log of expansion factor to be applied to glyphs, default 0: no expansion
		public static readonly NSString NSCursorAttributeName = new NSString("NSCursor").retain();						// NSCursor, default IBeamCursor
		public static readonly NSString NSToolTipAttributeName = new NSString("NSToolTip").retain();					// NSString, default nil: no tooltip
	}
}