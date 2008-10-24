// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSecureTextField.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSecureTextField : NSTextField
	{
		public NSSecureTextField() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSecureTextField(IntPtr instance) : base(instance)
		{
		}

		public NSSecureTextField(Untyped instance) : base(instance)
		{
		}

		public static new NSSecureTextField alloc()
		{
			return new NSSecureTextField(ms_class.Call("alloc"));
		}

		public new NSSecureTextField retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSSecureTextField");
	}

	[Register]
	public partial class NSSecureTextFieldCell : NSTextFieldCell
	{
		public NSSecureTextFieldCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSecureTextFieldCell(IntPtr instance) : base(instance)
		{
		}

		public NSSecureTextFieldCell(Untyped instance) : base(instance)
		{
		}

		public static new NSSecureTextFieldCell alloc()
		{
			return new NSSecureTextFieldCell(ms_class.Call("alloc"));
		}

		public new NSSecureTextFieldCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setEchosBullets(bool flag)
		{
			Unused.Value = Call("setEchosBullets:", flag);
		}

		public bool echosBullets()
		{
			return Call("echosBullets").To<bool>();
		}

		private static Class ms_class = new Class("NSSecureTextFieldCell");
	}
}
