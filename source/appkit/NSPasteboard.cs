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
	public partial class NSPasteboard : NSObject
	{
		/// <exclude/>
		public static readonly NSString NSStringPboardType = NSString.Create("NSStringPboardType").Retain();
		
		/// <exclude/>
		public static readonly NSString NSFilenamesPboardType = NSString.Create("NSFilenamesPboardType").Retain();
		
		/// <exclude/>
		public static readonly NSString NSPostScriptPboardType = NSString.Create("NeXT Encapsulated PostScript v1.2 pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSTIFFPboardType = NSString.Create("NeXT TIFF v4.0 pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSRTFPboardType = NSString.Create("NeXT Rich Text Format v1.0 pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSTabularTextPboardType = NSString.Create("NeXT tabular text pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSFontPboardType = NSString.Create("NeXT font pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSRulerPboardType = NSString.Create("NeXT ruler pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSFileContentsPboardType = NSString.Create("NXFileContentsPboardType").Retain();
		
		/// <exclude/>
		public static readonly NSString NSColorPboardType = NSString.Create("NSColor pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSRTFDPboardType = NSString.Create("NeXT RTFD pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSHTMLPboardType = NSString.Create("Apple HTML pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSPICTPboardType = NSString.Create("Apple PICT pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSURLPboardType = NSString.Create("Apple URL pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSPDFPboardType = NSString.Create("Apple PDF pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSVCardPboardType = NSString.Create("Apple VCard pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSFilesPromisePboardType = NSString.Create("Apple files promise pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSInkTextPboardType = NSString.Create("Apple InkText pasteboard type").Retain();
		
		/// <exclude/>
		public static readonly NSString NSMultipleTextSelectionPboardType = NSString.Create("Apple multiple text selection pasteboard type").Retain();
		
		
		/// <exclude/>
		public static readonly NSString NSGeneralPboard = NSString.Create("Apple CFPasteboard general").Retain();
		
		/// <exclude/>
		public static readonly NSString NSFontPboard = NSString.Create("Apple CFPasteboard font").Retain();
		
		/// <exclude/>
		public static readonly NSString NSRulerPboard = NSString.Create("Apple CFPasteboard ruler").Retain();
		
		/// <exclude/>
		public static readonly NSString NSFindPboard = NSString.Create("Apple CFPasteboard find").Retain();
		
		/// <exclude/>
		public static readonly NSString NSDragPboard = NSString.Create("Apple CFPasteboard drag").Retain();
	}
}
