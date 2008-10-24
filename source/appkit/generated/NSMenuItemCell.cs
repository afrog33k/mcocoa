// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSMenuItemCell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSMenuItemCell : NSButtonCell
	{
		public NSMenuItemCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMenuItemCell(IntPtr instance) : base(instance)
		{
		}

		public NSMenuItemCell(Untyped instance) : base(instance)
		{
		}

		public static new NSMenuItemCell alloc()
		{
			return new NSMenuItemCell(ms_class.Call("alloc"));
		}

		public new NSMenuItemCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setMenuItem(NSMenuItem item)
		{
			Unused.Value = Call("setMenuItem:", item);
		}

		public NSMenuItem menuItem()
		{
			return Call("menuItem").To<NSMenuItem>();
		}

		public void setMenuView(NSMenuView menuView)
		{
			Unused.Value = Call("setMenuView:", menuView);
		}

		public NSMenuView menuView()
		{
			return Call("menuView").To<NSMenuView>();
		}

		public void setNeedsSizing(bool flag)
		{
			Unused.Value = Call("setNeedsSizing:", flag);
		}

		public bool needsSizing()
		{
			return Call("needsSizing").To<bool>();
		}

		public void calcSize()
		{
			Unused.Value = Call("calcSize");
		}

		public void setNeedsDisplay(bool flag)
		{
			Unused.Value = Call("setNeedsDisplay:", flag);
		}

		public bool needsDisplay()
		{
			return Call("needsDisplay").To<bool>();
		}

		public float stateImageWidth()
		{
			return Call("stateImageWidth").To<float>();
		}

		public float imageWidth()
		{
			return Call("imageWidth").To<float>();
		}

		public float titleWidth()
		{
			return Call("titleWidth").To<float>();
		}

		public float keyEquivalentWidth()
		{
			return Call("keyEquivalentWidth").To<float>();
		}

		public NSRect stateImageRectForBounds(NSRect cellFrame)
		{
			return Call("stateImageRectForBounds:", cellFrame).To<NSRect>();
		}

		// skipping titleRectForBounds: (it's declared in a base class)

		public NSRect keyEquivalentRectForBounds(NSRect cellFrame)
		{
			return Call("keyEquivalentRectForBounds:", cellFrame).To<NSRect>();
		}

		public void drawSeparatorItemWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("drawSeparatorItemWithFrame:inView:", cellFrame, controlView);
		}

		public void drawStateImageWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("drawStateImageWithFrame:inView:", cellFrame, controlView);
		}

		public void drawImageWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("drawImageWithFrame:inView:", cellFrame, controlView);
		}

		public void drawTitleWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("drawTitleWithFrame:inView:", cellFrame, controlView);
		}

		public void drawKeyEquivalentWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("drawKeyEquivalentWithFrame:inView:", cellFrame, controlView);
		}

		public void drawBorderAndBackgroundWithFrameInView(NSRect cellFrame, NSView controlView)
		{
			Unused.Value = Call("drawBorderAndBackgroundWithFrame:inView:", cellFrame, controlView);
		}

		// skipping tag (it's declared in a base class)

		private static Class ms_class = new Class("NSMenuItemCell");
	}
}
