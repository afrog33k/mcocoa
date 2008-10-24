// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextFieldCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTextFieldSquareBezel = 0;
		public const int NSTextFieldRoundedBezel = 1;
	}

	[Register]
	public partial class NSTextFieldCell : NSActionCell
	{
		public NSTextFieldCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextFieldCell(IntPtr instance) : base(instance)
		{
		}

		public NSTextFieldCell(Untyped instance) : base(instance)
		{
		}

		public static new NSTextFieldCell alloc()
		{
			return new NSTextFieldCell(ms_class.Call("alloc"));
		}

		public new NSTextFieldCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setDrawsBackground(bool flag)
		{
			Unused.Value = Call("setDrawsBackground:", flag);
		}

		public bool drawsBackground()
		{
			return Call("drawsBackground").To<bool>();
		}

		public void setTextColor(NSColor color)
		{
			Unused.Value = Call("setTextColor:", color);
		}

		public NSColor textColor()
		{
			return Call("textColor").To<NSColor>();
		}

		// skipping setUpFieldEditorAttributes: (it's declared in a base class)

		public void setBezelStyle(UInt32 style)
		{
			Unused.Value = Call("setBezelStyle:", style);
		}

		public UInt32 bezelStyle()
		{
			return Call("bezelStyle").To<UInt32>();
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

		public void setWantsNotificationForMarkedText(bool flag)
		{
			Unused.Value = Call("setWantsNotificationForMarkedText:", flag);
		}

		public NSArray allowedInputSourceLocales()
		{
			return Call("allowedInputSourceLocales").To<NSArray>();
		}

		public void setAllowedInputSourceLocales(NSArray localeIdentifiers)
		{
			Unused.Value = Call("setAllowedInputSourceLocales:", localeIdentifiers);
		}

		private static Class ms_class = new Class("NSTextFieldCell");
	}
}
