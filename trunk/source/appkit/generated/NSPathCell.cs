// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPathCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSPathStyleStandard = 0;
		public const int NSPathStyleNavigationBar = 1;
		public const int NSPathStylePopUp = 2;
	}

	[Register]
	public partial class NSPathCell : NSActionCell
	{
		public NSPathCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPathCell(IntPtr instance) : base(instance)
		{
		}

		public NSPathCell(Untyped instance) : base(instance)
		{
		}

		public static new NSPathCell alloc()
		{
			return new NSPathCell(ms_class.Call("alloc"));
		}

		public new NSPathCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public Int32 pathStyle()
		{
			return Call("pathStyle").To<Int32>();
		}

		public void setPathStyle(Int32 style)
		{
			Unused.Value = Call("setPathStyle:", style);
		}

		public NSURL URL()
		{
			return Call("URL").To<NSURL>();
		}

		public void setURL(NSURL url)
		{
			Unused.Value = Call("setURL:", url);
		}

		// skipping setObjectValue: (it's declared in a base class)

		public NSArray allowedTypes()
		{
			return Call("allowedTypes").To<NSArray>();
		}

		public void setAllowedTypes(NSArray allowedTypes)
		{
			Unused.Value = Call("setAllowedTypes:", allowedTypes);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject value)
		{
			Unused.Value = Call("setDelegate:", value);
		}

		public static Class pathComponentCellClass()
		{
			return ms_class.Call("pathComponentCellClass").To<Class>();
		}

		public NSArray pathComponentCells()
		{
			return Call("pathComponentCells").To<NSArray>();
		}

		public void setPathComponentCells(NSArray cells)
		{
			Unused.Value = Call("setPathComponentCells:", cells);
		}

		public NSRect rectOfPathComponentCellWithFrameInView(NSPathComponentCell cell, NSRect frame, NSView view)
		{
			return Call("rectOfPathComponentCell:withFrame:inView:", cell, frame, view).To<NSRect>();
		}

		public NSPathComponentCell pathComponentCellAtPointWithFrameInView(NSPoint point, NSRect frame, NSView view)
		{
			return Call("pathComponentCellAtPoint:withFrame:inView:", point, frame, view).To<NSPathComponentCell>();
		}

		public NSPathComponentCell clickedPathComponentCell()
		{
			return Call("clickedPathComponentCell").To<NSPathComponentCell>();
		}

		public void mouseEnteredWithFrameInView(NSEvent event_, NSRect frame, NSView view)
		{
			Unused.Value = Call("mouseEntered:withFrame:inView:", event_, frame, view);
		}

		public void mouseExitedWithFrameInView(NSEvent event_, NSRect frame, NSView view)
		{
			Unused.Value = Call("mouseExited:withFrame:inView:", event_, frame, view);
		}

		public Selector doubleAction()
		{
			return Call("doubleAction").To<Selector>();
		}

		public void setDoubleAction(Selector action)
		{
			Unused.Value = Call("setDoubleAction:", action);
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setPlaceholderString(NSString string_)
		{
			Unused.Value = Call("setPlaceholderString:", string_);
		}

		public NSString placeholderString()
		{
			return Call("placeholderString").To<NSString>();
		}

		public void setPlaceholderAttributedString(NSAttributedString string_)
		{
			Unused.Value = Call("setPlaceholderAttributedString:", string_);
		}

		public NSAttributedString placeholderAttributedString()
		{
			return Call("placeholderAttributedString").To<NSAttributedString>();
		}

		// skipping setControlSize: (it's declared in a base class)

		private static Class ms_class = new Class("NSPathCell");
	}
}
