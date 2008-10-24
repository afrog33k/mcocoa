// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSBox.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNoTitle = 0;
		public const int NSAboveTop = 1;
		public const int NSAtTop = 2;
		public const int NSBelowTop = 3;
		public const int NSAboveBottom = 4;
		public const int NSAtBottom = 5;
		public const int NSBelowBottom = 6;
	}

	public partial class Enums
	{
		public const int NSBoxPrimary = 0;
		public const int NSBoxSecondary = 1;
		public const int NSBoxSeparator = 2;
		public const int NSBoxOldStyle = 3;
		public const int NSBoxCustom = 4;
	}

	[Register]
	public partial class NSBox : NSView
	{
		public NSBox() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSBox(IntPtr instance) : base(instance)
		{
		}

		public NSBox(Untyped instance) : base(instance)
		{
		}

		public static new NSBox alloc()
		{
			return new NSBox(ms_class.Call("alloc"));
		}

		public new NSBox retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 borderType()
		{
			return Call("borderType").To<UInt32>();
		}

		public UInt32 titlePosition()
		{
			return Call("titlePosition").To<UInt32>();
		}

		public void setBorderType(UInt32 aType)
		{
			Unused.Value = Call("setBorderType:", aType);
		}

		public void setBoxType(UInt32 boxType)
		{
			Unused.Value = Call("setBoxType:", boxType);
		}

		public UInt32 boxType()
		{
			return Call("boxType").To<UInt32>();
		}

		public void setTitlePosition(UInt32 aPosition)
		{
			Unused.Value = Call("setTitlePosition:", aPosition);
		}

		public NSString title()
		{
			return Call("title").To<NSString>();
		}

		public void setTitle(NSString aString)
		{
			Unused.Value = Call("setTitle:", aString);
		}

		public NSFont titleFont()
		{
			return Call("titleFont").To<NSFont>();
		}

		public void setTitleFont(NSFont fontObj)
		{
			Unused.Value = Call("setTitleFont:", fontObj);
		}

		public NSRect borderRect()
		{
			return Call("borderRect").To<NSRect>();
		}

		public NSRect titleRect()
		{
			return Call("titleRect").To<NSRect>();
		}

		public NSObject titleCell()
		{
			return Call("titleCell").To<NSObject>();
		}

		public void sizeToFit()
		{
			Unused.Value = Call("sizeToFit");
		}

		public NSSize contentViewMargins()
		{
			return Call("contentViewMargins").To<NSSize>();
		}

		public void setContentViewMargins(NSSize offsetSize)
		{
			Unused.Value = Call("setContentViewMargins:", offsetSize);
		}

		public void setFrameFromContentFrame(NSRect contentFrame)
		{
			Unused.Value = Call("setFrameFromContentFrame:", contentFrame);
		}

		public NSObject contentView()
		{
			return Call("contentView").To<NSObject>();
		}

		public void setContentView(NSView aView)
		{
			Unused.Value = Call("setContentView:", aView);
		}

		public bool isTransparent()
		{
			return Call("isTransparent").To<bool>();
		}

		public void setTransparent(bool flag)
		{
			Unused.Value = Call("setTransparent:", flag);
		}

		private static Class ms_class = new Class("NSBox");
	}

	public static class NSKeyboardUIForNSBoxCategory
	{
		public static void setTitleWithMnemonic(this NSBox _instance, NSString stringWithAmpersand)
		{
			Unused.Value = _instance.Call("setTitleWithMnemonic:", stringWithAmpersand);
		}
	}

	public static class NSCustomBoxTypePropertiesForNSBoxCategory
	{
		public static float borderWidth(this NSBox _instance)
		{
			return _instance.Call("borderWidth").To<float>();
		}

		public static void setBorderWidth(this NSBox _instance, float borderWidth)
		{
			Unused.Value = _instance.Call("setBorderWidth:", borderWidth);
		}

		public static float cornerRadius(this NSBox _instance)
		{
			return _instance.Call("cornerRadius").To<float>();
		}

		public static void setCornerRadius(this NSBox _instance, float cornerRadius)
		{
			Unused.Value = _instance.Call("setCornerRadius:", cornerRadius);
		}

		public static NSColor borderColor(this NSBox _instance)
		{
			return _instance.Call("borderColor").To<NSColor>();
		}

		public static void setBorderColor(this NSBox _instance, NSColor borderColor)
		{
			Unused.Value = _instance.Call("setBorderColor:", borderColor);
		}

		public static NSColor fillColor(this NSBox _instance)
		{
			return _instance.Call("fillColor").To<NSColor>();
		}

		public static void setFillColor(this NSBox _instance, NSColor fillColor)
		{
			Unused.Value = _instance.Call("setFillColor:", fillColor);
		}
	}
}
