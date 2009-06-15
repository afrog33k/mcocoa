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
	/// <exclude/>
	public static partial class Externs
	{
		public static readonly LazyString NSFontAttributeName = new LazyString("NSFont");					 		// NSFont, default Helvetica 12
		public static readonly LazyString NSParagraphStyleAttributeName = new LazyString("NSParagraphStyle");		// NSParagraphStyle, default defaultParagraphStyle
		public static readonly LazyString NSForegroundColorAttributeName = new LazyString("NSColor");				// NSColor, default blackColor
		public static readonly LazyString NSUnderlineStyleAttributeName = new LazyString("NSUnderline");			// NSNumber containing integer, default 0: no underline
		public static readonly LazyString NSSuperscriptAttributeName = new LazyString("NSSuperScript");			// NSNumber containing integer, default 0
		public static readonly LazyString NSBackgroundColorAttributeName = new LazyString("NSBackgroundColor");	// NSColor, default nil: no background
		public static readonly LazyString NSAttachmentAttributeName = new LazyString("NSAttachment");				// NSTextAttachment, default nil
		public static readonly LazyString NSLigatureAttributeName = new LazyString("NSLigature");					// NSNumber containing integer, default 1: default ligatures, 0: no ligatures, 2: all ligatures
		public static readonly LazyString NSBaselineOffsetAttributeName = new LazyString("NSBaselineOffset");		// NSNumber containing floating point value, in points; offset from baseline, default 0
		public static readonly LazyString NSKernAttributeName = new LazyString("NSKern");							// NSNumber containing floating point value, in points; amount to modify default kerning, if 0, kerning off
		public static readonly LazyString NSLinkAttributeName = new LazyString("NSLink");							// NSURL (preferred) or NSString
		public static readonly LazyString NSStrokeWidthAttributeName = new LazyString("NSStrokeWidth");			// NSNumber containing floating point value, in percent of font point size, default 0: no stroke; positive for stroke alone, negative for stroke and fill (a typical value for outlined text would be 3.0)
		public static readonly LazyString NSStrokeColorAttributeName = new LazyString("NSStrokeColor");			// NSColor, default nil: same as foreground color
		public static readonly LazyString NSUnderlineColorAttributeName = new LazyString("NSUnderlineColor");		// NSColor, default nil: same as foreground color
		public static readonly LazyString NSStrikethroughStyleAttributeName = new LazyString("NSStrikethrough");	// NSNumber containing integer, default 0: no strikethrough
		public static readonly LazyString NSStrikethroughColorAttributeName = new LazyString("NSStrikethroughColor");// NSColor, default nil: same as foreground color
		public static readonly LazyString NSShadowAttributeName = new LazyString("NSShadow");						// NSShadow, default nil: no shadow
		public static readonly LazyString NSObliquenessAttributeName = new LazyString("NSObliqueness");			// NSNumber containing floating point value; skew to be applied to glyphs, default 0: no skew
		public static readonly LazyString NSExpansionAttributeName = new LazyString("NSExpansion");				// NSNumber containing floating point value; log of expansion factor to be applied to glyphs, default 0: no expansion
		public static readonly LazyString NSCursorAttributeName = new LazyString("NSCursor");						// NSCursor, default IBeamCursor
		public static readonly LazyString NSToolTipAttributeName = new LazyString("NSToolTip");					// NSString, default nil: no tooltip

		// Values returned for the NSDocumentTypeDocumentAttribute key in the document attributes dictionary when reading text documents.  Note that other values are possible, and this set might grow in the future.
		public static readonly LazyString NSPlainTextDocumentType = new LazyString("NSPlainText");
		public static readonly LazyString NSRTFTextDocumentType = new LazyString("NSRTF");
		public static readonly LazyString NSRTFDTextDocumentType = new LazyString("NSRTFD");
		public static readonly LazyString NSMacSimpleTextDocumentType = new LazyString("NSMacSimpleText");
		public static readonly LazyString NSHTMLTextDocumentType = new LazyString("NSHTML");
		public static readonly LazyString NSDocFormatTextDocumentType = new LazyString("NSDocFormat");
		public static readonly LazyString NSWordMLTextDocumentType = new LazyString("NSWordML");
		public static readonly LazyString NSWebArchiveTextDocumentType = new LazyString("NSWebArchive");
		public static readonly LazyString NSOfficeOpenXMLTextDocumentType = new LazyString("NSOfficeOpenXML");
		public static readonly LazyString NSOpenDocumentTextDocumentType = new LazyString("NSOpenDocument");
		
		// The following are keys for various attributes that can be specified as document attributes in the text read/write APIs further below. Note that the items in the first set have been around since early 10.x releases; but the actual identifier shown below was added in 10.4. If you want your app to run on earlier systems, you need to continue using the actual string value that these identifiers represent. The actual string value is specified in the comments below.
		public static readonly LazyString NSPaperSizeDocumentAttribute = new LazyString("PaperSize");
		public static readonly LazyString NSLeftMarginDocumentAttribute = new LazyString("LeftMargin");
		public static readonly LazyString NSRightMarginDocumentAttribute = new LazyString("RightMargin");
		public static readonly LazyString NSTopMarginDocumentAttribute = new LazyString("TopMargin");
		public static readonly LazyString NSBottomMarginDocumentAttribute = new LazyString("BottomMargin");
		public static readonly LazyString NSViewSizeDocumentAttribute = new LazyString("ViewSize");
		public static readonly LazyString NSViewZoomDocumentAttribute = new LazyString("ViewZoom");
		public static readonly LazyString NSViewModeDocumentAttribute = new LazyString("ViewMode");
		public static readonly LazyString NSDocumentTypeDocumentAttribute = new LazyString("DocumentType");
		public static readonly LazyString NSReadOnlyDocumentAttribute = new LazyString("ReadOnly");
		public static readonly LazyString NSConvertedDocumentAttribute = new LazyString("Converted");
		public static readonly LazyString NSCocoaVersionDocumentAttribute = new LazyString("CocoaRTFVersion");
		public static readonly LazyString NSBackgroundColorDocumentAttribute = new LazyString("BackgroundColor");
		public static readonly LazyString NSHyphenationFactorDocumentAttribute = new LazyString("HyphenationFactor");
		public static readonly LazyString NSDefaultTabIntervalDocumentAttribute = new LazyString("DefaultTabInterval");
		public static readonly LazyString NSCharacterEncodingDocumentAttribute = new LazyString("CharacterEncoding");
		
		// These document attributes were added in 10.4.
		public static readonly LazyString NSTitleDocumentAttribute = new LazyString("NSTitleDocumentAttribute");
		public static readonly LazyString NSCompanyDocumentAttribute = new LazyString("NSCompanyDocumentAttribute");
		public static readonly LazyString NSCopyrightDocumentAttribute = new LazyString("NSCopyrightDocumentAttribute");
		public static readonly LazyString NSSubjectDocumentAttribute = new LazyString("NSSubjectDocumentAttribute");
		public static readonly LazyString NSAuthorDocumentAttribute = new LazyString("NSAuthorDocumentAttribute");
		public static readonly LazyString NSKeywordsDocumentAttribute = new LazyString("NSKeywordsDocumentAttribute");
		public static readonly LazyString NSCommentDocumentAttribute = new LazyString("NSCommentDocumentAttribute");
		public static readonly LazyString NSEditorDocumentAttribute = new LazyString("NSEditorDocumentAttribute");
		public static readonly LazyString NSCreationTimeDocumentAttribute = new LazyString("NSCreationTimeDocumentAttribute");
		public static readonly LazyString NSModificationTimeDocumentAttribute = new LazyString("NSModificationTimeDocumentAttribute");
		
		// Additional document attributes added in 10.4, for HTML writing only.  These provide control over the form of generated HTML.  NSExcludedElementsDocumentAttribute allows control over the tags used.  The recognized values in the NSExcludedElementsDocumentAttribute array are (case-insensitive) HTML tags, plus DOCTYPE (representing a doctype declaration) and XML (representing an XML declaration).  By default, if this attribute is not present, the excluded elements will be those deprecated in HTML 4 (APPLET, BASEFONT, CENTER, DIR, FONT, ISINDEX, MENU, S, STRIKE, and U) plus XML.  If XML is on the list, HTML forms will be used; if XML is not on the list, XHTML forms will be used where there is a distinction.  Either NSCharacterEncodingDocumentAttribute or NSTextEncodingNameDocumentAttribute may be used to control the encoding used for generated HTML; character entities will be used for characters not representable in the specified encoding.  Finally, NSPrefixSpacesDocumentAttribute allows some control over formatting.
		public static readonly LazyString NSExcludedElementsDocumentAttribute = new LazyString("ExcludedElements");
		public static readonly LazyString NSTextEncodingNameDocumentAttribute = new LazyString("TextEncodingName");
		public static readonly LazyString NSPrefixSpacesDocumentAttribute = new LazyString("PrefixSpaces");
		
		// The following are keys for various options that can be specified in the options dictionaries for the text import APIs below.  Except for NSTextSizeMultiplierDocumentOption, the values have been recognized for some time, but the actual identifier shown below was added in 10.4. If you want your app to run on earlier systems, you need to continue using the actual string value that these identifiers represent. The actual string value is specified in the comments below.
		public static readonly LazyString NSDocumentTypeDocumentOption = new LazyString("DocumentType");
		public static readonly LazyString NSDefaultAttributesDocumentOption = new LazyString("DefaultAttributes");
		public static readonly LazyString NSCharacterEncodingDocumentOption = new LazyString("CharacterEncoding");
		public static readonly LazyString NSTextEncodingNameDocumentOption = new LazyString("TextEncodingName");
		public static readonly LazyString NSBaseURLDocumentOption = new LazyString("BaseURL");
		public static readonly LazyString NSTimeoutDocumentOption = new LazyString("Timeout");
		public static readonly LazyString NSWebPreferencesDocumentOption = new LazyString("WebPreferences");
		public static readonly LazyString NSWebResourceLoadDelegateDocumentOption = new LazyString("WebResourceLoadDelegate");
		public static readonly LazyString NSTextSizeMultiplierDocumentOption = new LazyString("TextSizeMultiplier");
	}
}