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

// Note that this has the same lifetime as the app so we don't bother releasing
// the window or calling removeObserver.
[ExportClass("PaletteController", "NSWindowController", Outlets = "exponent")]
internal sealed class PaletteController : NSWindowController
{
	public PaletteController() : base(NSObject.AllocAndInitInstance("PaletteController"))
	{
		Unused.Value = NSBundle.loadNibNamed_owner(NSString.Create("palette"), this);
		
		m_exponent = this["exponent"].To<NSTextField>();
		
		Unused.Value = window().setFrameAutosaveName(NSString.Create("palette window"));
		
		NSNotificationCenter.defaultCenter().addObserver_selector_name_object(	// note that the controller doesn't go away so we don't bother removing ourself
			this, "docStateChanged:", Document.StateChanged, null);
	}
	
	public void docStateChanged(NSNotification notification)
	{
		DocChange change = notification.object_().To<DocChange>();
		m_document = change.Document;
		
		m_exponent.setEnabled(!NSObject.IsNullOrNil(m_document));
		
		if (!NSObject.IsNullOrNil(m_document))
		{
			if ((change.Type & ChangeType.Palette) == ChangeType.Palette)
			{
				window().setTitle(NSString.Create(m_document.Palette.Name));
			}
			
			if ((change.Type & ChangeType.PaletteExponent) == ChangeType.PaletteExponent)
			{
				m_exponent.setFloatValue(m_document.PaletteExponent);
			}
		}
		else
		{
			m_exponent.setFloatValue(0.0f);
			window().setTitle(NSString.Create("Palette"));
		}
	}
	
	public void exponentChanged(NSObject sender)
	{
		float value = m_exponent.floatValue();
		if (value != m_document.PaletteExponent)
		{
			m_document.updatePaletteExponent(NSNumber.Create(value));
			m_document.undoManager().setActionName(NSString.Create("Set Palette Exponent"));
		}
	}
	
	#region Fields
	private Document m_document;
	private NSTextField m_exponent;
	#endregion
}
