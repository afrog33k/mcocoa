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
using System.IO;
using System.Reflection;
using System.Xml;

[ExportClass("FractalController", "NSWindowController", Outlets = "view")]
internal sealed class FractalController : NSWindowController
{
	public FractalController(Document doc) : base(NSObject.AllocAndInitInstance("FractalController"))
	{
		m_document = doc;
		
		Unused.Value = NSBundle.loadNibNamed_owner(NSString.Create("document"), this);
		m_view = this["view"].To<FractalView>();
		
		NSNotificationCenter.defaultCenter().addObserver_selector_name_object(
			this, "docStateChanged:", Document.StateChanged, null);
	}
	
	protected override void OnDealloc()
	{
		NSNotificationCenter.defaultCenter().removeObserver(this);
		window().autorelease();
		
		base.OnDealloc();
	}
	
	public Document Document
	{
		get {return m_document;}
	}
	
	public void windowDidBecomeMain(NSNotification notification)
	{
		NSNotificationCenter.defaultCenter().postNotificationName_object(
			Document.StateChanged, DocChange.Create(m_document, ChangeType.All));
	}
	
	public void windowDidResignMain(NSNotification notification)
	{
		NSNotificationCenter.defaultCenter().postNotificationName_object(
			Document.StateChanged, DocChange.Create(null, ChangeType.All));
	}
	
	public void docStateChanged(NSNotification notification)
	{
		DocChange change = notification.object_().To<DocChange>();
		
		if (m_document == change.Document)
		{
			if ((change.Type & ChangeType.Settings) == ChangeType.Settings)
			{
				NSSize size = NSScrollView.frameSizeForContentSize_hasHorizontalScroller_hasVerticalScroller_borderType(
					new NSSize(m_document.Settings.Width, m_document.Settings.Height),
					false, false, Enums.NSNoBorder);
				
				NSRect frame = window().frameRectForContentRect(new NSRect(NSPoint.Zero, size));
				frame.origin = window().frame().origin;
				window().setFrame_display(frame, false);
				
				window().setMaxSize(frame.size);
			}
		}
	}
	
	public void magnify(NSObject sender)
	{
		FractalSettings settings = DoGetSelectionSettings();
		
		m_document.updateSettings(new Wrapper(settings));
		m_document.undoManager().setActionName(NSString.Create("Magnify"));
	}
	
	public void extract(NSObject sender)
	{
		FractalSettings settings = DoGetSelectionSettings();
		
		var doc = new Document(settings);
		NSDocumentController.sharedDocumentController().addDocument(doc);
		
		doc.makeWindowControllers();
		doc.showWindows();
	}
	
	public void zoomIn(NSObject sender)
	{
		FractalSettings settings = m_document.Settings;
		
		BigFloat width = 0.25*settings.Extent.Width/2;
		BigFloat height = 0.25*settings.Extent.Height/2;
		
		Complex origin = settings.Extent.Center;
		settings.Extent = new Rect(
			origin.X - width,
			origin.Y + height,
			origin.X + width,
			origin.Y - height);
		
		m_document.updateSettings(new Wrapper(settings));
		m_document.undoManager().setActionName(NSString.Create("Zoom In"));
	}
	
	public void zoomOut(NSObject sender)
	{
		FractalSettings settings = m_document.Settings;
		
		BigFloat width = 4.0*settings.Extent.Width/2;
		BigFloat height = 4.0*settings.Extent.Height/2;
		
		float precision = Math.Max(width.Precision, height.Precision);
		
		Complex origin = settings.Extent.Center;
		settings.Extent = new Rect(
			origin.X.Sub(width, precision),
			origin.Y.Add(height, precision),
			origin.X.Add(width, precision),
			origin.Y.Sub(height, precision));
		
		m_document.updateSettings(new Wrapper(settings));
		m_document.undoManager().setActionName(NSString.Create("Zoom Out"));
	}
	
	public void shiftLeft(NSObject sender)
	{
		DoScroll(-1, 0, "Shift Left");
	}
	
	public void shiftRight(NSObject sender)
	{
		DoScroll(+1, 0, "Shift Right");
	}
	
	public void shiftUp(NSObject sender)
	{
		DoScroll(0, +1, "Shift Up");
	}
	
	public void shiftDown(NSObject sender)
	{
		DoScroll(0, -1, "Shift Down");
	}
	
	public void changePalette(NSObject sender)
	{
		AppDelegate app = NSApplication.sharedApplication().delegate_().To<AppDelegate>();
		
		string name = sender.Call("title").To<NSObject>().description();
		Palette palette = app.GetPalette(name);
		
		if (name != m_document.Palette.Name)
		{
			m_document.updatePalette(new Wrapper(palette));
			m_document.undoManager().setActionName(NSString.Create("Set Palette"));
		}
	}
	
	public void makeDefault(NSObject sender)
	{
		try
		{
			string path = Assembly.GetExecutingAssembly().Location;
			path = Path.GetDirectoryName(path);
			path = Path.Combine(path, "palettes");
			path = Path.Combine(path, "Default.xml");
			
			XmlDocument xml = m_document.Palette.GetXmlDoc();
			xml.Save(path);
			
			m_document.MakeDefault();
		}
		catch (Exception e)
		{
			NSString title = NSString.Create("Couldn't make the palette the default palette");
			NSString message = NSString.Create(e.Message);
			Unused.Value = Functions.NSRunAlertPanel(title, message);
		}
	}
	
	public bool validateUserInterfaceItem(NSObject sender)
	{
		bool enabled = false;
		
		Selector sel = (Selector) sender.Call("action");
		
		if (sel.Name == "magnify:" || sel.Name == "extract:")
		{
			NSRect selection = m_view.Selection;
			enabled = selection.size != NSSize.Zero;
		}
		else if (sel.Name == "changePalette:")
		{
			string name = sender.Call("title").To<NSObject>().description();
			sender.Call("setState:", name == m_document.Palette.Name ? 1 : 0);
			enabled = true;
		}
		else if (sel.Name == "makeDefault:")
		{
			enabled = m_document.Palette.Name != "Default";
		}
		else if (respondsToSelector(sel))
		{
			enabled = true;
		}
		else if (SuperCall("respondsToSelector:", new Selector("validateUserInterfaceItem")).To<bool>())
		{
			enabled = SuperCall("validateUserInterfaceItem:", sender).To<bool>();
		}
		
		return enabled;
	}
	
	#region Private Methods
	private FractalSettings DoGetSelectionSettings()
	{
		FractalSettings settings = m_document.Settings;
		
		NSRect selection = m_view.Selection;
		BigFloat left = settings.Extent.Left + (selection.Left/settings.Width)*settings.Extent.Width;
		BigFloat right = left + (selection.size.width/settings.Width)*settings.Extent.Width;
		
		BigFloat bottom = settings.Extent.Bottom + (selection.Bottom/settings.Height)*settings.Extent.Height;
		BigFloat top = bottom + (selection.size.height/settings.Height)*settings.Extent.Height;
		
		settings.Extent = new Rect(left, top, right, bottom);
		
		return settings;
	}
	
	// TODO: would be really nice to scroll the dwells
	private void DoScroll(int hx, int hy, string name)
	{
		FractalSettings settings = m_document.Settings;
		
		// Note that we don't want to use operator*(double, BigFloat) here
		// because we don't want to change the precision of the extent.
		BigFloat dx = settings.Extent.Width*hx/10;
		BigFloat dy = settings.Extent.Height*hy/10;
		settings.Extent = settings.Extent.Offset(dx, dy);
		
		m_document.updateSettings(new Wrapper(settings));
		m_document.undoManager().setActionName(NSString.Create(name));
	}
	#endregion
	
	#region Fields
	private Document m_document;
	private FractalView m_view;
	#endregion
}
