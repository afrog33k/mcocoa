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
using MObjc;
using System;

// Used with NSNotificationCenter to notify views and inspectors that a
// document has changed.
[ExportClass("DocChange")]
internal sealed class DocChange : NSObject
{
	private DocChange(Document doc, ChangeType type) : base(NSObject.AllocAndInitInstance("DocChange"))
	{
		Document = doc;
		Type = type;
	}
	
	public static DocChange Create(Document doc, ChangeType type)
	{
		var change = new DocChange(doc, type);
		change.autorelease();
		return change;
	}
	
	// Will be null if the document window has resigned main.
	public Document Document {get; private set;}
	
	public ChangeType Type {get; private set;}
}
