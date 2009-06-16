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
using MObjc.Helpers;
using System;

[ExportClass("DocumentInfoController", "NSWindowController", Outlets = "left right top bottom maxDwell minDwell precision")]
internal sealed class DocumentInfoController : NSWindowController
{
	public DocumentInfoController() : base(NSObject.AllocAndInitInstance("DocumentInfoController"))
	{
		Unused.Value = NSBundle.loadNibNamed_owner(NSString.Create("document-info"), this);
		
		m_left = this["left"].To<NSTextField>();
		m_right = this["right"].To<NSTextField>();
		m_top = this["top"].To<NSTextField>();
		m_bottom = this["bottom"].To<NSTextField>();
		m_maxDwell = this["maxDwell"].To<NSTextField>();
		m_minDwell = this["minDwell"].To<NSTextField>();
		m_precision = this["precision"].To<NSTextField>();
		
		Unused.Value = window().setFrameAutosaveName(NSString.Create("document-info window"));
		
		NSNotificationCenter.defaultCenter().addObserver_selector_name_object(	// note that the controller doesn't go away so we don't bother removing ourself
			this, "docStateChanged:", Document.StateChanged, null);
	}
	
	public void docStateChanged(NSNotification notification)
	{
		DocChange change = notification.object_().To<DocChange>();
		
		string left = string.Empty;
		string right = string.Empty;
		string top = string.Empty;
		string bottom = string.Empty;
		string minDwell = string.Empty;
		string maxDwell = string.Empty;
		string precision = string.Empty;
		string title = "Document Info";
		
		if (!NSObject.IsNullOrNil(change.Document))
		{
			FractalSettings settings = change.Document.Settings;
			
			left = settings.Extent.Left.ToString().Replace('@', 'E');
			right = settings.Extent.Right.ToString().Replace('@', 'E');
			top = settings.Extent.Top.ToString().Replace('@', 'E');
			bottom = settings.Extent.Bottom.ToString().Replace('@', 'E');
			
			minDwell = change.Document.MinDwell.ToString();
			maxDwell = change.Document.MaxDwell.ToString();
			
#if LIBGMP
			float p1 = (settings.Extent.Width/settings.Width).Precision;
			float p2 = (settings.Extent.Height/settings.Height).Precision;
			uint p = Math.Max((uint) p1, (uint) p2);
			
			if (p < Computer.MaxDoubleBits)
				precision = string.Format("{0} bits (double)", p);
			else
				precision = string.Format("{0} bits (bigfloat)", p);
#else
			precision = "52 bits";
#endif
			
			NSURL url = change.Document.fileURL();
			if (!NSObject.IsNullOrNil(url))
			{
				string path = url.path().description();
				title = System.IO.Path.GetFileNameWithoutExtension(path) + " Info";
			}
		}
		
		m_left.setStringValue(NSString.Create(left));
		m_right.setStringValue(NSString.Create(right));
		m_top.setStringValue(NSString.Create(top));
		m_bottom.setStringValue(NSString.Create(bottom));
		m_minDwell.setStringValue(NSString.Create(minDwell));
		m_maxDwell.setStringValue(NSString.Create(maxDwell));
		m_precision.setStringValue(NSString.Create(precision));
		
		window().setTitle(NSString.Create(title));
	}
	
	#region Fields
	private NSTextField m_left;
	private NSTextField m_right;
	private NSTextField m_top;
	private NSTextField m_bottom;
	private NSTextField m_minDwell;
	private NSTextField m_maxDwell;
	private NSTextField m_precision;
	#endregion
}
