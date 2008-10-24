// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSColorPicker.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSColorPicker : NSObject
	{
		public NSColorPicker() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSColorPicker(IntPtr instance) : base(instance)
		{
		}

		public NSColorPicker(Untyped instance) : base(instance)
		{
		}

		public static new NSColorPicker alloc()
		{
			return new NSColorPicker(ms_class.Call("alloc"));
		}

		public new NSColorPicker retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithPickerMaskColorPanel(UInt32 mask, NSColorPanel owningColorPanel)
		{
			return Call("initWithPickerMask:colorPanel:", mask, owningColorPanel).To<NSObject>();
		}

		public NSColorPanel colorPanel()
		{
			return Call("colorPanel").To<NSColorPanel>();
		}

		public NSImage provideNewButtonImage()
		{
			return Call("provideNewButtonImage").To<NSImage>();
		}

		public void insertNewButtonImageIn(NSImage newButtonImage, NSButtonCell buttonCell)
		{
			Unused.Value = Call("insertNewButtonImage:in:", newButtonImage, buttonCell);
		}

		public void viewSizeChanged(NSObject sender)
		{
			Unused.Value = Call("viewSizeChanged:", sender);
		}

		public void attachColorList(NSColorList colorList)
		{
			Unused.Value = Call("attachColorList:", colorList);
		}

		public void detachColorList(NSColorList colorList)
		{
			Unused.Value = Call("detachColorList:", colorList);
		}

		public void setMode(Int32 mode)
		{
			Unused.Value = Call("setMode:", mode);
		}

		public NSString buttonToolTip()
		{
			return Call("buttonToolTip").To<NSString>();
		}

		public NSSize minContentSize()
		{
			return Call("minContentSize").To<NSSize>();
		}

		#region NSColorPickingDefault Methods




		public void alphaControlAddedOrRemoved(NSObject sender)
		{
			Unused.Value = Call("alphaControlAddedOrRemoved:", sender);
		}





		#endregion

		private static Class ms_class = new Class("NSColorPicker");
	}
}
