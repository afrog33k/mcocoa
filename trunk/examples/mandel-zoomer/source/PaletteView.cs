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

[ExportClass("PaletteView", "NSView")]
internal sealed class PaletteView : NSView
{
	private PaletteView(IntPtr instance) : base(instance)
	{
		m_gradient = NSGradient.Create(NSColor.blackColor(), NSColor.blackColor()).Retain();
		
		NSNotificationCenter.defaultCenter().addObserver_selector_name_object(	// note that the controller doesn't go away so we don't bother removing ourself
			this, "docStateChanged:", Document.StateChanged, null);
	}
	
	public void docStateChanged(NSNotification notification)
	{
		DocChange change = notification.object_().To<DocChange>();
		
		NSGradient gradient = null;
		if (!NSObject.IsNullOrNil(change.Document))
		{
			if ((change.Type & ChangeType.Palette) == ChangeType.Palette)
			{
				float[] locations = new float[change.Document.Palette.Length];
				NSMutableArray colors = NSMutableArray.arrayWithCapacity((uint) change.Document.Palette.Length);
				
				for (int i = 0; i < change.Document.Palette.Length; ++i)
				{
					locations[i] = change.Document.Palette[i].Location;
					colors.addObject((NSColor) change.Document.Palette[i].Color);
				}
				
				gradient = NSGradient.Create(colors, locations).Retain();
			}
		}
		else
		{
			gradient = NSGradient.Create(NSColor.blackColor(), NSColor.blackColor()).Retain();
		}
		
		if (gradient != null)
		{
			if (m_gradient != null)
				m_gradient.release();
			m_gradient = gradient;
			
			setNeedsDisplay(true);
		}
	}
	
	public new void drawRect(NSRect dirtyRect)
	{
		m_gradient.drawInRect_angle(bounds(), 0.0f);
	}
	
	#region Fields
	private NSGradient m_gradient;
	#endregion
}
