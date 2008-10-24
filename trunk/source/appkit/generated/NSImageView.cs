// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSImageView.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSImageView : NSControl
	{
		public NSImageView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSImageView(IntPtr instance) : base(instance)
		{
		}

		public NSImageView(Untyped instance) : base(instance)
		{
		}

		public static new NSImageView alloc()
		{
			return new NSImageView(ms_class.Call("alloc"));
		}

		public new NSImageView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public void setImage(NSImage newImage)
		{
			Unused.Value = Call("setImage:", newImage);
		}

		public UInt32 imageAlignment()
		{
			return Call("imageAlignment").To<UInt32>();
		}

		public void setImageAlignment(UInt32 newAlign)
		{
			Unused.Value = Call("setImageAlignment:", newAlign);
		}

		public UInt32 imageScaling()
		{
			return Call("imageScaling").To<UInt32>();
		}

		public void setImageScaling(UInt32 newScaling)
		{
			Unused.Value = Call("setImageScaling:", newScaling);
		}

		public UInt32 imageFrameStyle()
		{
			return Call("imageFrameStyle").To<UInt32>();
		}

		public void setImageFrameStyle(UInt32 newStyle)
		{
			Unused.Value = Call("setImageFrameStyle:", newStyle);
		}

		public void setEditable(bool yn)
		{
			Unused.Value = Call("setEditable:", yn);
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public void setAnimates(bool flag)
		{
			Unused.Value = Call("setAnimates:", flag);
		}

		public bool animates()
		{
			return Call("animates").To<bool>();
		}

		public bool allowsCutCopyPaste()
		{
			return Call("allowsCutCopyPaste").To<bool>();
		}

		public void setAllowsCutCopyPaste(bool allow)
		{
			Unused.Value = Call("setAllowsCutCopyPaste:", allow);
		}

		private static Class ms_class = new Class("NSImageView");
	}
}
