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

		// Values returned for the NSDocumentTypeDocumentAttribute key in the document attributes dictionary when reading text documents.  Note that other values are possible, and this set might grow in the future.
		public static readonly NSString NSPlainTextDocumentType = NSString.Create("NSPlainText").Retain();
		public static readonly NSString NSRTFTextDocumentType = NSString.Create("NSRTF").Retain();
		public static readonly NSString NSRTFDTextDocumentType = NSString.Create("NSRTFD").Retain();
		public static readonly NSString NSMacSimpleTextDocumentType = NSString.Create("NSMacSimpleText").Retain();
		public static readonly NSString NSHTMLTextDocumentType = NSString.Create("NSHTML").Retain();
		public static readonly NSString NSDocFormatTextDocumentType = NSString.Create("NSDocFormat").Retain();
		public static readonly NSString NSWordMLTextDocumentType = NSString.Create("NSWordML").Retain();
		public static readonly NSString NSWebArchiveTextDocumentType = NSString.Create("NSWebArchive").Retain();
		public static readonly NSString NSOfficeOpenXMLTextDocumentType = NSString.Create("NSOfficeOpenXML").Retain();
		public static readonly NSString NSOpenDocumentTextDocumentType = NSString.Create("NSOpenDocument").Retain();
		
		// The following are keys for various attributes that can be specified as document attributes in the text read/write APIs further below. Note that the items in the first set have been around since early 10.x releases; but the actual identifier shown below was added in 10.4. If you want your app to run on earlier systems, you need to continue using the actual string value that these identifiers represent. The actual string value is specified in the comments below.
		public static readonly NSString NSPaperSizeDocumentAttribute = NSString.Create("PaperSize").Retain();
		public static readonly NSString NSLeftMarginDocumentAttribute = NSString.Create("LeftMargin").Retain();
		public static readonly NSString NSRightMarginDocumentAttribute = NSString.Create("RightMargin").Retain();
		public static readonly NSString NSTopMarginDocumentAttribute = NSString.Create("TopMargin").Retain();
		public static readonly NSString NSBottomMarginDocumentAttribute = NSString.Create("BottomMargin").Retain();
		public static readonly NSString NSViewSizeDocumentAttribute = NSString.Create("ViewSize").Retain();
		public static readonly NSString NSViewZoomDocumentAttribute = NSString.Create("ViewZoom").Retain();
		public static readonly NSString NSViewModeDocumentAttribute = NSString.Create("ViewMode").Retain();
		public static readonly NSString NSDocumentTypeDocumentAttribute = NSString.Create("DocumentType").Retain();
		public static readonly NSString NSReadOnlyDocumentAttribute = NSString.Create("ReadOnly").Retain();
		public static readonly NSString NSConvertedDocumentAttribute = NSString.Create("Converted").Retain();
		public static readonly NSString NSCocoaVersionDocumentAttribute = NSString.Create("CocoaRTFVersion").Retain();
		public static readonly NSString NSBackgroundColorDocumentAttribute = NSString.Create("BackgroundColor").Retain();
		public static readonly NSString NSHyphenationFactorDocumentAttribute = NSString.Create("HyphenationFactor").Retain();
		public static readonly NSString NSDefaultTabIntervalDocumentAttribute = NSString.Create("DefaultTabInterval").Retain();
		public static readonly NSString NSCharacterEncodingDocumentAttribute = NSString.Create("CharacterEncoding").Retain();
		
		// These document attributes were added in 10.4.
		public static readonly NSString NSTitleDocumentAttribute = NSString.Create("NSTitleDocumentAttribute").Retain();
		public static readonly NSString NSCompanyDocumentAttribute = NSString.Create("NSCompanyDocumentAttribute").Retain();
		public static readonly NSString NSCopyrightDocumentAttribute = NSString.Create("NSCopyrightDocumentAttribute").Retain();
		public static readonly NSString NSSubjectDocumentAttribute = NSString.Create("NSSubjectDocumentAttribute").Retain();
		public static readonly NSString NSAuthorDocumentAttribute = NSString.Create("NSAuthorDocumentAttribute").Retain();
		public static readonly NSString NSKeywordsDocumentAttribute = NSString.Create("NSKeywordsDocumentAttribute").Retain();
		public static readonly NSString NSCommentDocumentAttribute = NSString.Create("NSCommentDocumentAttribute").Retain();
		public static readonly NSString NSEditorDocumentAttribute = NSString.Create("NSEditorDocumentAttribute").Retain();
		public static readonly NSString NSCreationTimeDocumentAttribute = NSString.Create("NSCreationTimeDocumentAttribute").Retain();
		public static readonly NSString NSModificationTimeDocumentAttribute = NSString.Create("NSModificationTimeDocumentAttribute").Retain();
		
		// Additional document attributes added in 10.4, for HTML writing only.  These provide control over the form of generated HTML.  NSExcludedElementsDocumentAttribute allows control over the tags used.  The recognized values in the NSExcludedElementsDocumentAttribute array are (case-insensitive) HTML tags, plus DOCTYPE (representing a doctype declaration) and XML (representing an XML declaration).  By default, if this attribute is not present, the excluded elements will be those deprecated in HTML 4 (APPLET, BASEFONT, CENTER, DIR, FONT, ISINDEX, MENU, S, STRIKE, and U) plus XML.  If XML is on the list, HTML forms will be used; if XML is not on the list, XHTML forms will be used where there is a distinction.  Either NSCharacterEncodingDocumentAttribute or NSTextEncodingNameDocumentAttribute may be used to control the encoding used for generated HTML; character entities will be used for characters not representable in the specified encoding.  Finally, NSPrefixSpacesDocumentAttribute allows some control over formatting.
		public static readonly NSString NSExcludedElementsDocumentAttribute = NSString.Create("ExcludedElements").Retain();
		public static readonly NSString NSTextEncodingNameDocumentAttribute = NSString.Create("TextEncodingName").Retain();
		public static readonly NSString NSPrefixSpacesDocumentAttribute = NSString.Create("PrefixSpaces").Retain();
		
		// The following are keys for various options that can be specified in the options dictionaries for the text import APIs below.  Except for NSTextSizeMultiplierDocumentOption, the values have been recognized for some time, but the actual identifier shown below was added in 10.4. If you want your app to run on earlier systems, you need to continue using the actual string value that these identifiers represent. The actual string value is specified in the comments below.
		public static readonly NSString NSDocumentTypeDocumentOption = NSString.Create("DocumentType").Retain();
		public static readonly NSString NSDefaultAttributesDocumentOption = NSString.Create("DefaultAttributes").Retain();
		public static readonly NSString NSCharacterEncodingDocumentOption = NSString.Create("CharacterEncoding").Retain();
		public static readonly NSString NSTextEncodingNameDocumentOption = NSString.Create("TextEncodingName").Retain();
		public static readonly NSString NSBaseURLDocumentOption = NSString.Create("BaseURL").Retain();
		public static readonly NSString NSTimeoutDocumentOption = NSString.Create("Timeout").Retain();
		public static readonly NSString NSWebPreferencesDocumentOption = NSString.Create("WebPreferences").Retain();
		public static readonly NSString NSWebResourceLoadDelegateDocumentOption = NSString.Create("WebResourceLoadDelegate").Retain();
		public static readonly NSString NSTextSizeMultiplierDocumentOption = NSString.Create("TextSizeMultiplier").Retain();
	}
}