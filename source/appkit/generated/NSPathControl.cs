// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPathControl.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPathControl : NSControl
	{
		public NSPathControl() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPathControl(IntPtr instance) : base(instance)
		{
		}

		public NSPathControl(Untyped instance) : base(instance)
		{
		}

		public static new NSPathControl alloc()
		{
			return new NSPathControl(ms_class.Call("alloc"));
		}

		public new NSPathControl retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSURL URL()
		{
			return Call("URL").To<NSURL>();
		}

		public void setURL(NSURL url)
		{
			Unused.Value = Call("setURL:", url);
		}

		public Selector doubleAction()
		{
			return Call("doubleAction").To<Selector>();
		}

		public void setDoubleAction(Selector action)
		{
			Unused.Value = Call("setDoubleAction:", action);
		}

		public Int32 pathStyle()
		{
			return Call("pathStyle").To<Int32>();
		}

		public void setPathStyle(Int32 style)
		{
			Unused.Value = Call("setPathStyle:", style);
		}

		public NSPathComponentCell clickedPathComponentCell()
		{
			return Call("clickedPathComponentCell").To<NSPathComponentCell>();
		}

		public NSArray pathComponentCells()
		{
			return Call("pathComponentCells").To<NSArray>();
		}

		public void setPathComponentCells(NSArray cells)
		{
			Unused.Value = Call("setPathComponentCells:", cells);
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public void setDraggingSourceOperationMaskForLocal(UInt32 mask, bool isLocal)
		{
			Unused.Value = Call("setDraggingSourceOperationMask:forLocal:", mask, isLocal);
		}

		private static Class ms_class = new Class("NSPathControl");
	}
}
