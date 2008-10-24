// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSegmentedControl.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSSegmentStyleAutomatic = 0;
		public const int NSSegmentStyleRounded = 1;
		public const int NSSegmentStyleTexturedRounded = 2;
		public const int NSSegmentStyleRoundRect = 3;
		public const int NSSegmentStyleTexturedSquare = 4;
		public const int NSSegmentStyleCapsule = 5;
		public const int NSSegmentStyleSmallSquare = 6;
	}

	[Register]
	public partial class NSSegmentedControl : NSControl
	{
		public NSSegmentedControl() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSegmentedControl(IntPtr instance) : base(instance)
		{
		}

		public NSSegmentedControl(Untyped instance) : base(instance)
		{
		}

		public static new NSSegmentedControl alloc()
		{
			return new NSSegmentedControl(ms_class.Call("alloc"));
		}

		public new NSSegmentedControl retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setSegmentCount(Int32 count)
		{
			Unused.Value = Call("setSegmentCount:", count);
		}

		public Int32 segmentCount()
		{
			return Call("segmentCount").To<Int32>();
		}

		public void setSelectedSegment(Int32 selectedSegment)
		{
			Unused.Value = Call("setSelectedSegment:", selectedSegment);
		}

		public Int32 selectedSegment()
		{
			return Call("selectedSegment").To<Int32>();
		}

		public bool selectSegmentWithTag(Int32 tag)
		{
			return Call("selectSegmentWithTag:", tag).To<bool>();
		}

		public void setWidthForSegment(float width, Int32 segment)
		{
			Unused.Value = Call("setWidth:forSegment:", width, segment);
		}

		public float widthForSegment(Int32 segment)
		{
			return Call("widthForSegment:", segment).To<float>();
		}

		public void setImageForSegment(NSImage image, Int32 segment)
		{
			Unused.Value = Call("setImage:forSegment:", image, segment);
		}

		public NSImage imageForSegment(Int32 segment)
		{
			return Call("imageForSegment:", segment).To<NSImage>();
		}

		public void setImageScalingForSegment(UInt32 scaling, Int32 segment)
		{
			Unused.Value = Call("setImageScaling:forSegment:", scaling, segment);
		}

		public UInt32 imageScalingForSegment(Int32 segment)
		{
			return Call("imageScalingForSegment:", segment).To<UInt32>();
		}

		public void setLabelForSegment(NSString label, Int32 segment)
		{
			Unused.Value = Call("setLabel:forSegment:", label, segment);
		}

		public NSString labelForSegment(Int32 segment)
		{
			return Call("labelForSegment:", segment).To<NSString>();
		}

		public void setMenuForSegment(NSMenu menu, Int32 segment)
		{
			Unused.Value = Call("setMenu:forSegment:", menu, segment);
		}

		public NSMenu menuForSegment(Int32 segment)
		{
			return Call("menuForSegment:", segment).To<NSMenu>();
		}

		public void setSelectedForSegment(bool selected, Int32 segment)
		{
			Unused.Value = Call("setSelected:forSegment:", selected, segment);
		}

		public bool isSelectedForSegment(Int32 segment)
		{
			return Call("isSelectedForSegment:", segment).To<bool>();
		}

		public void setEnabledForSegment(bool enabled, Int32 segment)
		{
			Unused.Value = Call("setEnabled:forSegment:", enabled, segment);
		}

		public bool isEnabledForSegment(Int32 segment)
		{
			return Call("isEnabledForSegment:", segment).To<bool>();
		}

		public void setSegmentStyle(Int32 segmentStyle)
		{
			Unused.Value = Call("setSegmentStyle:", segmentStyle);
		}

		public Int32 segmentStyle()
		{
			return Call("segmentStyle").To<Int32>();
		}

		private static Class ms_class = new Class("NSSegmentedControl");
	}
}
