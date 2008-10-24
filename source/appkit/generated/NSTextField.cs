// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextField.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSTextField : NSControl
	{
		public NSTextField() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextField(IntPtr instance) : base(instance)
		{
		}

		public NSTextField(Untyped instance) : base(instance)
		{
		}

		public static new NSTextField alloc()
		{
			return new NSTextField(ms_class.Call("alloc"));
		}

		public new NSTextField retain()
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

		public bool isBordered()
		{
			return Call("isBordered").To<bool>();
		}

		public void setBordered(bool flag)
		{
			Unused.Value = Call("setBordered:", flag);
		}

		public bool isBezeled()
		{
			return Call("isBezeled").To<bool>();
		}

		public void setBezeled(bool flag)
		{
			Unused.Value = Call("setBezeled:", flag);
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public void setEditable(bool flag)
		{
			Unused.Value = Call("setEditable:", flag);
		}

		public bool isSelectable()
		{
			return Call("isSelectable").To<bool>();
		}

		public void setSelectable(bool flag)
		{
			Unused.Value = Call("setSelectable:", flag);
		}

		public void selectText(NSObject sender)
		{
			Unused.Value = Call("selectText:", sender);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public bool textShouldBeginEditing(NSText textObject)
		{
			return Call("textShouldBeginEditing:", textObject).To<bool>();
		}

		public bool textShouldEndEditing(NSText textObject)
		{
			return Call("textShouldEndEditing:", textObject).To<bool>();
		}

		public void textDidBeginEditing(NSNotification notification)
		{
			Unused.Value = Call("textDidBeginEditing:", notification);
		}

		public void textDidEndEditing(NSNotification notification)
		{
			Unused.Value = Call("textDidEndEditing:", notification);
		}

		public void textDidChange(NSNotification notification)
		{
			Unused.Value = Call("textDidChange:", notification);
		}

		// skipping acceptsFirstResponder (it's declared in a base class)

		public void setBezelStyle(UInt32 style)
		{
			Unused.Value = Call("setBezelStyle:", style);
		}

		public UInt32 bezelStyle()
		{
			return Call("bezelStyle").To<UInt32>();
		}

		#region NSUserInterfaceValidations Methods
		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}
		#endregion

		private static Class ms_class = new Class("NSTextField");
	}

	public static class NSKeyboardUIForNSTextFieldCategory
	{
		public static void setTitleWithMnemonic(this NSTextField _instance, NSString stringWithAmpersand)
		{
			Unused.Value = _instance.Call("setTitleWithMnemonic:", stringWithAmpersand);
		}
	}

	public static class NSTextFieldAttributedStringMethodsForNSTextFieldCategory
	{
		public static bool allowsEditingTextAttributes(this NSTextField _instance)
		{
			return _instance.Call("allowsEditingTextAttributes").To<bool>();
		}

		public static void setAllowsEditingTextAttributes(this NSTextField _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAllowsEditingTextAttributes:", flag);
		}

		public static bool importsGraphics(this NSTextField _instance)
		{
			return _instance.Call("importsGraphics").To<bool>();
		}

		public static void setImportsGraphics(this NSTextField _instance, bool flag)
		{
			Unused.Value = _instance.Call("setImportsGraphics:", flag);
		}
	}
}
