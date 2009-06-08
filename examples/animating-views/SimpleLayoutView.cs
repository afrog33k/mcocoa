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

using MCocoa;
using MObjc;
using System;

internal enum Layout {Column, Row, Grid}

[ExportClass("SimpleLayoutView", "NSView", Outlets = "boxColorField")]
internal sealed class SimpleLayoutView : NSView
{
	private SimpleLayoutView(IntPtr instance) : base(instance)
	{
		m_colorWell = this["boxColorField"].To<NSColorWell>();
		
		// By default NSColorPanel does not show an alpha (opacity) slider so enable it.
		NSColorPanel.sharedColorPanel().setShowsAlpha(true);
	}
		
	#region Action Methods
	// Action methods to add/remove boxes, giving us something to animate. Note 
	// that we cause a relayout here; a better design is to relayout in the view 
	// automatically on addition/removal of subviews.
	public void addABox(NSObject sender)
	{
		NSView box = DoMakeBox();
		addSubview(box);
		
		DoLayout();
	}
	
	public void removeLastBox(NSObject sender)
	{
		NSView[] children = subviews();
		if (children.Length > 0)
		{
			children[children.Length - 1].removeFromSuperview();
			DoLayout();
		}
	}
	
	public void changeLayout(NSMatrix sender)
	{
		m_layout = (Layout) sender.selectedTag();
		DoLayout();
	}
	#endregion
	
	#region Overrides
	public new int tag()
	{
		return 33;
	}
	
	// Changing frame (which is what happens when the window is resized) should 
	// cause relayout.
	public new void setFrameSize(NSSize size)
	{
		SuperCall("setFrameSize:", size);
		DoLayout();
	}
	#endregion
	
	#region Private Methods
	// Create a new view to be added/animated. Any kind of view can be added here, we 
	// go for simple colored box using the Leopard "custom" box type.
	private NSBox DoMakeBox()
	{
		NSRect frame = new NSRect(0.0f, 0.0f, BoxWidth, BoxHeight);
		
		NSBox box = NSBox.Alloc().initWithFrame(frame).To<NSBox>();
		box.setBorderType(Enums.NSLineBorder);
		box.setBoxType(Enums.NSBoxCustom);
		box.setFillColor(m_colorWell.color());
		box.setTitlePosition(Enums.NSNoTitle);
		
		return box;
	}
	
	private void DoAnimate(NSView subview, NSRect frame)
	{
		subview.animator().Call("setFrame:", frame);
	}
	
	// This method simply computes the new layout, and calls setFrame: on all subview 
	// with their locations. Since the calls are made to the subviews' animators, the 
	// subview animate to their new locations.
	private void DoLayout()
	{
		NSView[] children = subviews();
		
		NSPoint curPoint;
		switch (m_layout)
		{
			case Layout.Column:
				curPoint = new NSPoint(bounds().size.width / 2.0f, 0.0f);		// Starting point: center bottom of view				
				for (int i = 0; i < children.Length; ++i)
				{
					NSRect frame = new NSRect(curPoint.x - BoxWidth / 2.0f, curPoint.y, BoxWidth, BoxHeight);	// Centered horizontally, stacked higher
					frame = DoGetIntegralRect(frame);
					DoAnimate(children[i], frame);
					curPoint.y += frame.size.height + Separation;					// Next view location; we're stacking higher
				}
				break;
			
			case Layout.Row:
				curPoint = new NSPoint(0.0f, bounds().size.height / 2.0f);	// Starting point: center left edge of view			
				for (int i = 0; i < children.Length; ++i)
				{
					NSRect frame = new NSRect(curPoint.x, curPoint.y - BoxHeight / 2.0f, BoxWidth, BoxHeight);	// Centered vertically, stacked left to right
					frame = DoGetIntegralRect(frame);
					DoAnimate(children[i], frame);
					curPoint.x += frame.size.width + Separation;					// Next view location
				}
				break;
			
			case Layout.Grid:
				int viewsPerSide = (int) Math.Ceiling(Math.Sqrt(children.Length));	// Put the views in a roughly square grid
				int index = 0;
				curPoint = NSPoint.Zero;								// Starting at the bottom left corner
				for (int i = 0; i < children.Length; ++i)
				{
					NSRect frame = new NSRect(curPoint.x, curPoint.y, BoxWidth, BoxHeight);
					frame = DoGetIntegralRect(frame);
					DoAnimate(children[i], frame);
					
					curPoint.x += BoxWidth + Separation;	// Stack them horizontally
					if ((++index) % viewsPerSide == 0)
					{																// And if we have enough on this row, move up to the next
						curPoint.x = 0;
						curPoint.y += BoxHeight + Separation;
					}
				}
				break;
		}
	}
	
	// This method returns a rect that is integral in base coordinates.
	private NSRect DoGetIntegralRect(NSRect rect)
	{
		rect = convertRectToBase(rect).ToIntegral();
		rect = convertRectFromBase(rect);
		return rect;
	}
	#endregion
	
	#region Fields
	private const float Separation = 10.0f;
	private const float BoxWidth = 80.0f;
	private const float BoxHeight = 80.0f;
	
	private Layout m_layout;
	private NSColorWell m_colorWell;
	#endregion
}
