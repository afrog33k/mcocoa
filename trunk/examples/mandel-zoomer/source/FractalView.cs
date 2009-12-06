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

[ExportClass("FractalView", "NSView")]
internal sealed class FractalView : NSView
{
	private FractalView(IntPtr instance) : base(instance)
	{
		NSNotificationCenter.defaultCenter().addObserver_selector_name_object(
			this, "docStateChanged:", Document.StateChanged, null);
	}
	
	public void awakeFromNib()
	{
		FractalController controller = window().windowController().To<FractalController>();
		m_document = controller.Document;
	}
	
	protected override void OnDealloc()
	{
		DoCleanup();
		NSNotificationCenter.defaultCenter().removeObserver(this);
		
		base.OnDealloc();
	}
	
	public new bool acceptsFirstResponder()
	{
		return true;
	}
	
	public void docStateChanged(NSNotification notification)
	{
		DocChange change = notification.object_().To<DocChange>();
		
		if (m_document == change.Document)
		{
			if ((change.Type & ChangeType.Settings) == ChangeType.Settings)
			{
				m_document = change.Document;
				FractalSettings settings = m_document.Settings;
				
				NSBitmapImageRep rep = NSBitmapImageRep.Alloc().initWithBitmapDataPlanes_pixelsWide_pixelsHigh_bitsPerSample_samplesPerPixel_hasAlpha_isPlanar_colorSpaceName_bitmapFormat_bytesPerRow_bitsPerPixel(
					IntPtr.Zero,				// initWithBitmapDataPlanes (null means use meshed)
					settings.Width, 		// pixelsWide
					settings.Height,		// pixelsHigh
					8,								// bitsPerSample
					3,								// samplesPerPixel
					false,						// hasAlpha
					false,						// isPlanar
					Externs.NSDeviceRGBColorSpace,	// colorSpaceName
					0,								// bitmapFormat
					0,								// bytesPerRow (padding may be added)
					0).To<NSBitmapImageRep>();	// bitsPerPixel (don't add meaningless bits)
				rep.autorelease();		// so the rep is released if an exception is thrown
					
				NSImage image = NSImage.Create();
				image.addRepresentation(rep);
				
				DoCleanup();
				
				m_rep = rep.Retain();
				m_image = image.Retain();
				setFrameSize(new NSSize(settings.Width, settings.Height));
				m_selection = NSRect.Empty;
			}
			
			if (!m_refreshing)
			{
				m_refreshing = true;
				NSApplication.sharedApplication().BeginInvoke(this.DoRefresh, TimeSpan.FromMilliseconds(100));
			}
		}
	}
	
	public new void mouseDown(NSEvent evt)
	{
		NSPoint originalPoint = convertPoint_fromView(evt.locationInWindow(), null);
		
		if (m_selection.size != NSSize.Zero)
		{
			setNeedsDisplayInRect(m_selection);
			m_selection = NSRect.Empty;
		}
		
		do
		{
			evt = window().nextEventMatchingMask(Enums.NSLeftMouseDraggedMask | Enums.NSLeftMouseUpMask);
			autoscroll(evt);
			
			NSPoint currentPoint = convertPoint_fromView(evt.locationInWindow(), null);
			NSRect oldSelection = m_selection;
			m_selection = DoCreateSelectionRect(originalPoint, currentPoint);
			setNeedsDisplayInRect(m_selection.Union(oldSelection));
		}
		while (evt.type() == Enums.NSLeftMouseDragged);
		
		DoInvariant();
	}
	
	public new bool isOpaque()
	{
		return true;
	}
	
	public NSRect Selection
	{
		get {return m_selection;}
	}
	
	public void saveImage(NSObject sender)
	{
		NSSavePanel panel = NSSavePanel.savePanel();
		panel.setTitle(NSString.Create("Save Image"));
		panel.setCanCreateDirectories(true);
		panel.setAllowedFileTypes(NSArray.Create("png"));
//		panel.setAllowedFileTypes(NSArray.Create("bmp", "gif", "jpeg", "png", "tiff"));
		panel.setAllowsOtherFileTypes(false);
		panel.beginSheetForDirectory_file_modalForWindow_modalDelegate_didEndSelector_contextInfo(
			null,						// path
			null,						// name (in path)
			window(),				// docWindow
			this,						// delegate
			"saveTheImage",	// end selector
			IntPtr.Zero);		// context
	}
	
	public void saveTheImage(NSSavePanel panel, int returnCode, IntPtr context)
	{
		if (returnCode == Enums.NSOKButton)
		{
			NSDictionary properties = NSDictionary.Create();
			NSData data = m_rep.representationUsingType_properties(Enums.NSPNGFileType, properties);
			System.IO.File.WriteAllBytes(panel.filename().description(), data.bytes());
		}
	}
	
	// TODO: 
	// should use dirtyRect
	public new void drawRect(NSRect dirtyRect)
	{
		m_image.drawInRect_fromRect_operation_fraction(
			bounds(),			 					// dstRect
			NSRect.Empty, 					// fromRect
			Enums.NSCompositeCopy, 	// op
			1.0f);									// opacity
			
		if (m_selection.size != NSSize.Zero)
		{
			NSColor.yellowColor().set();
			Functions.NSFrameRect(m_selection);
		}
		
		DoInvariant();
	}
	
	#region Private Methods
	[ContractInvariantMethod]
	private void DoInvariant()
	{
		Contract.Invariant(m_document != null, "document is null");
		Contract.Invariant(!NSObject.IsNullOrNil(m_image), "image is null or nil");
		Contract.Invariant(!NSObject.IsNullOrNil(m_rep), "rep is null or nil");
		
		FractalSettings settings = m_document.Settings;
		Contract.Invariant(m_image.size().width == settings.Width, string.Format("image has width {0} but document has width {1}", m_image.size().width, settings.Width));
		Contract.Invariant(m_image.size().height == settings.Height, string.Format("image has height {0} but document has height {1}", m_image.size().height, settings.Height));
	}
	
	private void DoCleanup()
	{
		if (!NSObject.IsNullOrNil(m_rep))
		{
			m_rep.release();
			m_rep = null;
		}
		
		if (!NSObject.IsNullOrNil(m_image))
		{
			m_image.release();
			m_image = null;
		}
	}
	
	private NSRect DoCreateSelectionRect(NSPoint point1, NSPoint point2)
	{
		return new NSRect(((point1.x <= point2.x) ? point1.x : point2.x),
			((point1.y <= point2.y) ? point1.y : point2.y),
			((point1.x <= point2.x) ? point2.x - point1.x : point1.x - point2.x),
			((point1.y <= point2.y) ? point2.y - point1.y : point1.y - point2.y));
	}
	
	private unsafe void DoRefresh()		// TODO: use unchecked math?
	{
		m_refreshing = !m_document.AllDone;
		
		// Do this first to avoid races.
		if (!m_document.AllDone)
			NSApplication.sharedApplication().BeginInvoke(this.DoRefresh, TimeSpan.FromSeconds(1));
		
		IntPtr data = m_rep.bitmapData();
		byte* start = (byte*) data.ToPointer();
		
		FractalSettings settings = m_document.Settings;
		Palette palette = m_document.Palette;
		float[,] samples = m_document.Samples;
		float min = m_document.MinSample;
		double range = m_document.MaxSample - min;
		
		int height = settings.Height;		// note that we need to use these locals to avoid creating lots of BigFloat objects in the loop
		int width = settings.Width;
	
		int rowWidth = m_rep.bytesPerRow();
		for (int v = 0; v < height; ++v)
		{
			byte* row = start + v*rowWidth;
			
			for (int h = 0; h < width; ++h)
			{
				Color color;
				float sample = samples[h, v];
				if (float.IsPositiveInfinity(sample))
					color = Color.Black;
				else if (!float.IsNaN(sample))
					color = palette.Interpolate(Math.Max(sample - min, 0)/range, m_document.PaletteExponent);
				else
					color = Color.Unknown;
				
				row[3*h + 0] = color.Red;
				row[3*h + 1] = color.Green;
				row[3*h + 2] = color.Blue;
			}
		}
		
		setNeedsDisplay(true);
	}
	#endregion
	
	#region Fields
	private Document m_document;
	private NSImage m_image;
	private NSBitmapImageRep m_rep;
	private NSRect m_selection;
	private bool m_refreshing;
	#endregion
}
