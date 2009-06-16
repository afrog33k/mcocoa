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
[ExportClass("FractalInfoController", "NSWindowController", Outlets = "width height maxDwells timeLabel")]
internal sealed class FractalInfoController : NSWindowController
{
	public FractalInfoController() : base(NSObject.AllocAndInitInstance("FractalInfoController"))
	{
		Unused.Value = NSBundle.loadNibNamed_owner(NSString.Create("fractal-info"), this);
		
		m_width = this["width"].To<NSTextField>();
		m_height = this["height"].To<NSTextField>();
		m_maxDwells = this["maxDwells"].To<NSTextField>();
		m_timeLabel = this["timeLabel"].To<NSTextField>();
		
		Unused.Value = window().setFrameAutosaveName(NSString.Create("fractal-info window"));
		
		NSNotificationCenter.defaultCenter().addObserver_selector_name_object(	// note that the controller doesn't go away so we don't bother removing ourself
			this, "docStateChanged:", Document.StateChanged, null);
			
		NSApplication.sharedApplication().BeginInvoke(this.DoUpdateTime, TimeSpan.FromSeconds(1.0));
	}
	
	public void docStateChanged(NSNotification notification)
	{
		DocChange change = notification.object_().To<DocChange>();
		
		m_width.setEnabled(!NSObject.IsNullOrNil(change.Document));
		m_height.setEnabled(!NSObject.IsNullOrNil(change.Document));
		m_maxDwells.setEnabled(!NSObject.IsNullOrNil(change.Document));
		
		if (!NSObject.IsNullOrNil(change.Document))
		{
			if ((change.Type & ChangeType.Settings) == ChangeType.Settings)
			{
				m_width.setIntegerValue(change.Document.Settings.Width);
				m_height.setIntegerValue(change.Document.Settings.Height);
				m_maxDwells.setIntegerValue((int) change.Document.Settings.MaxDwell);
				
				string time = string.Format("Render Time: {0:0.000} mins", change.Document.RenderTime);
				m_timeLabel.setStringValue(NSString.Create(time));
			}
		}
	}
	
	public void dwellsChanged(NSObject sender)
	{
		Document doc = NSDocumentController.sharedDocumentController().currentDocument().To<Document>();
		FractalSettings settings = doc.Settings;
		
		int maxDwell = m_maxDwells.integerValue();
		if (maxDwell != settings.MaxDwell)
		{
			settings.MaxDwell = (ushort) maxDwell;
			
			doc.updateSettings(Wrapper.Create(settings));
			doc.undoManager().setActionName(NSString.Create("Set Max Dwell"));
		}
	}
	
	public void widthChanged(NSObject sender)
	{
		Document doc = NSDocumentController.sharedDocumentController().currentDocument().To<Document>();
		FractalSettings settings = doc.Settings;
		
		int width = m_width.integerValue();
		if (width != settings.Width)
		{
			BigFloat ratio = settings.Extent.Width/settings.Extent.Height;
			BigFloat height = width/ratio;
			settings.Area = (int) (double) (width*height);
			
			doc.updateSettings(Wrapper.Create(settings));
			doc.undoManager().setActionName(NSString.Create("Set Width"));
		}
	}
	
	public void heightChanged(NSObject sender)
	{
		Document doc = NSDocumentController.sharedDocumentController().currentDocument().To<Document>();
		FractalSettings settings = doc.Settings;
		
		int height = m_height.integerValue();
		if (height != settings.Height)
		{
			BigFloat ratio = settings.Extent.Width/settings.Extent.Height;
			BigFloat width = height*ratio;
			settings.Area = (int) (double) (width*height);
			
			doc.updateSettings(Wrapper.Create(settings));
			doc.undoManager().setActionName(NSString.Create("Set Height"));
		}
	}
	
	#region Private Methods
	// Icky polling, but it's only once per second...
	private void DoUpdateTime()
	{
		Document doc = NSDocumentController.sharedDocumentController().currentDocument().To<Document>();
		
		if (!NSObject.IsNullOrNil(doc))
		{
			string time = string.Format("Render Time: {0:0.000} mins", doc.RenderTime);
			m_timeLabel.setStringValue(NSString.Create(time));
		}
		
		NSApplication.sharedApplication().BeginInvoke(this.DoUpdateTime, TimeSpan.FromSeconds(1.0));
	}
	#endregion
	
	#region Fields
	private NSTextField m_width;
	private NSTextField m_height;
	private NSTextField m_maxDwells;
	private NSTextField m_timeLabel;
	#endregion
}
