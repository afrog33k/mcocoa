// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSImageCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSImageAlignCenter = 0;
		public const int NSImageAlignTop = 1;
		public const int NSImageAlignTopLeft = 2;
		public const int NSImageAlignTopRight = 3;
		public const int NSImageAlignLeft = 4;
		public const int NSImageAlignBottom = 5;
		public const int NSImageAlignBottomLeft = 6;
		public const int NSImageAlignBottomRight = 7;
		public const int NSImageAlignRight = 8;
	}

	public partial class Enums
	{
		public const int NSImageFrameNone = 0;
		public const int NSImageFramePhoto = 1;
		public const int NSImageFrameGrayBezel = 2;
		public const int NSImageFrameGroove = 3;
		public const int NSImageFrameButton = 4;
	}

	[Register]
	public partial class NSImageCell : NSCell
	{
		public NSImageCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSImageCell(IntPtr instance) : base(instance)
		{
		}

		public NSImageCell(Untyped instance) : base(instance)
		{
		}

		public static new NSImageCell alloc()
		{
			return new NSImageCell(ms_class.Call("alloc"));
		}

		public new NSImageCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
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

		private static Class ms_class = new Class("NSImageCell");
	}
}
