// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSForm.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSForm : NSMatrix
	{
		public NSForm() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSForm(IntPtr instance) : base(instance)
		{
		}

		public NSForm(Untyped instance) : base(instance)
		{
		}

		public static new NSForm alloc()
		{
			return new NSForm(ms_class.Call("alloc"));
		}

		public new NSForm retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public Int32 indexOfSelectedItem()
		{
			return Call("indexOfSelectedItem").To<Int32>();
		}

		public void setEntryWidth(float width)
		{
			Unused.Value = Call("setEntryWidth:", width);
		}

		public void setInterlineSpacing(float spacing)
		{
			Unused.Value = Call("setInterlineSpacing:", spacing);
		}

		public void setBordered(bool flag)
		{
			Unused.Value = Call("setBordered:", flag);
		}

		public void setBezeled(bool flag)
		{
			Unused.Value = Call("setBezeled:", flag);
		}

		public void setTitleAlignment(UInt32 mode)
		{
			Unused.Value = Call("setTitleAlignment:", mode);
		}

		public void setTextAlignment(UInt32 mode)
		{
			Unused.Value = Call("setTextAlignment:", mode);
		}

		public void setTitleFont(NSFont fontObj)
		{
			Unused.Value = Call("setTitleFont:", fontObj);
		}

		public void setTextFont(NSFont fontObj)
		{
			Unused.Value = Call("setTextFont:", fontObj);
		}

		public NSObject cellAtIndex(Int32 index)
		{
			return Call("cellAtIndex:", index).To<NSObject>();
		}

		public void drawCellAtIndex(Int32 index)
		{
			Unused.Value = Call("drawCellAtIndex:", index);
		}

		public NSFormCell addEntry(NSString title)
		{
			return Call("addEntry:", title).To<NSFormCell>();
		}

		public NSFormCell insertEntryAtIndex(NSString title, Int32 index)
		{
			return Call("insertEntry:atIndex:", title, index).To<NSFormCell>();
		}

		public void removeEntryAtIndex(Int32 index)
		{
			Unused.Value = Call("removeEntryAtIndex:", index);
		}

		public Int32 indexOfCellWithTag(Int32 aTag)
		{
			return Call("indexOfCellWithTag:", aTag).To<Int32>();
		}

		public void selectTextAtIndex(Int32 index)
		{
			Unused.Value = Call("selectTextAtIndex:", index);
		}

		// skipping setFrameSize: (it's declared in a base class)

		public void setTitleBaseWritingDirection(Int32 writingDirection)
		{
			Unused.Value = Call("setTitleBaseWritingDirection:", writingDirection);
		}

		public void setTextBaseWritingDirection(Int32 writingDirection)
		{
			Unused.Value = Call("setTextBaseWritingDirection:", writingDirection);
		}

		private static Class ms_class = new Class("NSForm");
	}
}
