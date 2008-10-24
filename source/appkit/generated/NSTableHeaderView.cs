// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTableHeaderView.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSTableHeaderView : NSView
	{
		public NSTableHeaderView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTableHeaderView(IntPtr instance) : base(instance)
		{
		}

		public NSTableHeaderView(Untyped instance) : base(instance)
		{
		}

		public static new NSTableHeaderView alloc()
		{
			return new NSTableHeaderView(ms_class.Call("alloc"));
		}

		public new NSTableHeaderView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setTableView(NSTableView tableView)
		{
			Unused.Value = Call("setTableView:", tableView);
		}

		public NSTableView tableView()
		{
			return Call("tableView").To<NSTableView>();
		}

		public Int32 draggedColumn()
		{
			return Call("draggedColumn").To<Int32>();
		}

		public float draggedDistance()
		{
			return Call("draggedDistance").To<float>();
		}

		public Int32 resizedColumn()
		{
			return Call("resizedColumn").To<Int32>();
		}

		public NSRect headerRectOfColumn(Int32 column)
		{
			return Call("headerRectOfColumn:", column).To<NSRect>();
		}

		public Int32 columnAtPoint(NSPoint point)
		{
			return Call("columnAtPoint:", point).To<Int32>();
		}

		private static Class ms_class = new Class("NSTableHeaderView");
	}
}
