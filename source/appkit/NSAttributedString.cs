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
	// http://developer.apple.com/documentation/Cocoa/Reference/ApplicationKit/Classes/NSAttributedString_AppKitAdditions/Reference/Reference.html#//apple_ref/doc/uid/20000167-SW6
	public static partial class Externs
	{
		public static readonly NSString NSFontAttributeName = NSString.Create("NSFont").Retain();					 		// NSFont, default Helvetica 12
		public static readonly NSString NSParagraphStyleAttributeName = NSString.Create("NSParagraphStyle").Retain();		// NSParagraphStyle, default defaultParagraphStyle
		public static readonly NSString NSForegroundColorAttributeName = NSString.Create("NSColor").Retain();				// NSColor, default blackColor
		public static readonly NSString NSUnderlineStyleAttributeName = NSString.Create("NSUnderline").Retain();			// NSNumber containing integer, default 0: no underline
		public static readonly NSString NSSuperscriptAttributeName = NSString.Create("NSSuperScript").Retain();			// NSNumber containing integer, default 0
		public static readonly NSString NSBackgroundColorAttributeName = NSString.Create("NSBackgroundColor").Retain();	// NSColor, default nil: no background
		public static readonly NSString NSAttachmentAttributeName = NSString.Create("NSAttachment").Retain();				// NSTextAttachment, default nil
		public static readonly NSString NSLigatureAttributeName = NSString.Create("NSLigature").Retain();					// NSNumber containing integer, default 1: default ligatures, 0: no ligatures, 2: all ligatures
		public static readonly NSString NSBaselineOffsetAttributeName = NSString.Create("NSBaselineOffset").Retain();		// NSNumber containing floating point value, in points; offset from baseline, default 0
		public static readonly NSString NSKernAttributeName = NSString.Create("NSKern").Retain();							// NSNumber containing floating point value, in points; amount to modify default kerning, if 0, kerning off
		public static readonly NSString NSLinkAttributeName = NSString.Create("NSLink").Retain();							// NSURL (preferred) or NSString
		public static readonly NSString NSStrokeWidthAttributeName = NSString.Create("NSStrokeWidth").Retain();			// NSNumber containing floating point value, in percent of font point size, default 0: no stroke; positive for stroke alone, negative for stroke and fill (a typical value for outlined text would be 3.0)
		public static readonly NSString NSStrokeColorAttributeName = NSString.Create("NSStrokeColor").Retain();			// NSColor, default nil: same as foreground color
		public static readonly NSString NSUnderlineColorAttributeName = NSString.Create("NSUnderlineColor").Retain();		// NSColor, default nil: same as foreground color
		public static readonly NSString NSStrikethroughStyleAttributeName = NSString.Create("NSStrikethrough").Retain();	// NSNumber containing integer, default 0: no strikethrough
		public static readonly NSString NSStrikethroughColorAttributeName = NSString.Create("NSStrikethroughColor").Retain();// NSColor, default nil: same as foreground color
		public static readonly NSString NSShadowAttributeName = NSString.Create("NSShadow").Retain();						// NSShadow, default nil: no shadow
		public static readonly NSString NSObliquenessAttributeName = NSString.Create("NSObliqueness").Retain();			// NSNumber containing floating point value; skew to be applied to glyphs, default 0: no skew
		public static readonly NSString NSExpansionAttributeName = NSString.Create("NSExpansion").Retain();				// NSNumber containing floating point value; log of expansion factor to be applied to glyphs, default 0: no expansion
		public static readonly NSString NSCursorAttributeName = NSString.Create("NSCursor").Retain();						// NSCursor, default IBeamCursor
		public static readonly NSString NSToolTipAttributeName = NSString.Create("NSToolTip").Retain();					// NSString, default nil: no tooltip
	}
}