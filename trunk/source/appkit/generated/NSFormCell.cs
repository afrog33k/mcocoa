// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSFormCell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSFormCell : NSActionCell
	{
		public NSFormCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFormCell(IntPtr instance) : base(instance)
		{
		}

		public NSFormCell(Untyped instance) : base(instance)
		{
		}

		public static new NSFormCell alloc()
		{
			return new NSFormCell(ms_class.Call("alloc"));
		}

		public new NSFormCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping initTextCell: (it's declared in a base class)

		public float titleWidth(NSSize aSize)
		{
			return Call("titleWidth:", aSize).To<float>();
		}

		public float titleWidth()
		{
			return Call("titleWidth").To<float>();
		}

		public void setTitleWidth(float width)
		{
			Unused.Value = Call("setTitleWidth:", width);
		}

		// skipping title (it's declared in a base class)

		// skipping setTitle: (it's declared in a base class)

		public NSFont titleFont()
		{
			return Call("titleFont").To<NSFont>();
		}

		public void setTitleFont(NSFont fontObj)
		{
			Unused.Value = Call("setTitleFont:", fontObj);
		}

		public UInt32 titleAlignment()
		{
			return Call("titleAlignment").To<UInt32>();
		}

		public void setTitleAlignment(UInt32 mode)
		{
			Unused.Value = Call("setTitleAlignment:", mode);
		}

		// skipping isOpaque (it's declared in a base class)

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

		public Int32 titleBaseWritingDirection()
		{
			return Call("titleBaseWritingDirection").To<Int32>();
		}

		public void setTitleBaseWritingDirection(Int32 writingDirection)
		{
			Unused.Value = Call("setTitleBaseWritingDirection:", writingDirection);
		}

		private static Class ms_class = new Class("NSFormCell");
	}

	public static class NSKeyboardUIForNSFormCellCategory
	{
		public static void setTitleWithMnemonic(this NSFormCell _instance, NSString stringWithAmpersand)
		{
			Unused.Value = _instance.Call("setTitleWithMnemonic:", stringWithAmpersand);
		}
	}

	public static class NSFormCellAttributedStringMethodsForNSFormCellCategory
	{
		public static NSAttributedString attributedTitle(this NSFormCell _instance)
		{
			return _instance.Call("attributedTitle").To<NSAttributedString>();
		}

		public static void setAttributedTitle(this NSFormCell _instance, NSAttributedString obj)
		{
			Unused.Value = _instance.Call("setAttributedTitle:", obj);
		}
	}
}
