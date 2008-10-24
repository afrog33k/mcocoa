// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTableHeaderCell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSTableHeaderCell : NSTextFieldCell
	{
		public NSTableHeaderCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTableHeaderCell(IntPtr instance) : base(instance)
		{
		}

		public NSTableHeaderCell(Untyped instance) : base(instance)
		{
		}

		public static new NSTableHeaderCell alloc()
		{
			return new NSTableHeaderCell(ms_class.Call("alloc"));
		}

		public new NSTableHeaderCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void drawSortIndicatorWithFrameInViewAscendingPriority(NSRect cellFrame, NSView controlView, bool ascending_, Int32 priority)
		{
			Unused.Value = Call("drawSortIndicatorWithFrame:inView:ascending:priority:", cellFrame, controlView, ascending_, priority);
		}

		public NSRect sortIndicatorRectForBounds(NSRect theRect)
		{
			return Call("sortIndicatorRectForBounds:", theRect).To<NSRect>();
		}

		private static Class ms_class = new Class("NSTableHeaderCell");
	}
}
