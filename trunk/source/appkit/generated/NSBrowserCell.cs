// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSBrowserCell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSBrowserCell : NSCell
	{
		public NSBrowserCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSBrowserCell(IntPtr instance) : base(instance)
		{
		}

		public NSBrowserCell(Untyped instance) : base(instance)
		{
		}

		public static new NSBrowserCell alloc()
		{
			return new NSBrowserCell(ms_class.Call("alloc"));
		}

		public new NSBrowserCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSImage branchImage()
		{
			return ms_class.Call("branchImage").To<NSImage>();
		}

		public static NSImage highlightedBranchImage()
		{
			return ms_class.Call("highlightedBranchImage").To<NSImage>();
		}

		public NSColor highlightColorInView(NSView controlView)
		{
			return Call("highlightColorInView:", controlView).To<NSColor>();
		}

		public bool isLeaf()
		{
			return Call("isLeaf").To<bool>();
		}

		public void setLeaf(bool flag)
		{
			Unused.Value = Call("setLeaf:", flag);
		}

		public bool isLoaded()
		{
			return Call("isLoaded").To<bool>();
		}

		public void setLoaded(bool flag)
		{
			Unused.Value = Call("setLoaded:", flag);
		}

		public void reset()
		{
			Unused.Value = Call("reset");
		}

		public void set()
		{
			Unused.Value = Call("set");
		}

		// skipping setImage: (it's declared in a base class)

		// skipping image (it's declared in a base class)

		public void setAlternateImage(NSImage newAltImage)
		{
			Unused.Value = Call("setAlternateImage:", newAltImage);
		}

		public NSImage alternateImage()
		{
			return Call("alternateImage").To<NSImage>();
		}

		private static Class ms_class = new Class("NSBrowserCell");
	}
}
