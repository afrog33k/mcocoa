// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTabViewItem.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSSelectedTab = 0;
		public const int NSBackgroundTab = 1;
		public const int NSPressedTab = 2;
	}

	[Register]
	public partial class NSTabViewItem : NSObject
	{
		public NSTabViewItem() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTabViewItem(IntPtr instance) : base(instance)
		{
		}

		public NSTabViewItem(Untyped instance) : base(instance)
		{
		}

		public static new NSTabViewItem alloc()
		{
			return new NSTabViewItem(ms_class.Call("alloc"));
		}

		public new NSTabViewItem retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithIdentifier(NSObject identifier)
		{
			return Call("initWithIdentifier:", identifier).To<NSObject>();
		}

		public NSObject identifier()
		{
			return Call("identifier").To<NSObject>();
		}

		public NSObject view()
		{
			return Call("view").To<NSObject>();
		}

		public NSObject initialFirstResponder()
		{
			return Call("initialFirstResponder").To<NSObject>();
		}

		public NSString label()
		{
			return Call("label").To<NSString>();
		}

		public NSColor color()
		{
			return Call("color").To<NSColor>();
		}

		public UInt32 tabState()
		{
			return Call("tabState").To<UInt32>();
		}

		public NSTabView tabView()
		{
			return Call("tabView").To<NSTabView>();
		}

		public void setIdentifier(NSObject identifier)
		{
			Unused.Value = Call("setIdentifier:", identifier);
		}

		public void setLabel(NSString label)
		{
			Unused.Value = Call("setLabel:", label);
		}

		public void setColor(NSColor color)
		{
			Unused.Value = Call("setColor:", color);
		}

		public void setView(NSView view)
		{
			Unused.Value = Call("setView:", view);
		}

		public void setInitialFirstResponder(NSView view)
		{
			Unused.Value = Call("setInitialFirstResponder:", view);
		}

		public void drawLabelInRect(bool shouldTruncateLabel, NSRect labelRect)
		{
			Unused.Value = Call("drawLabel:inRect:", shouldTruncateLabel, labelRect);
		}

		public NSSize sizeOfLabel(bool computeMin)
		{
			return Call("sizeOfLabel:", computeMin).To<NSSize>();
		}

		#region NSCoding Methods
		public void encodeWithCoder(NSCoder aCoder)
		{
			Unused.Value = Call("encodeWithCoder:", aCoder);
		}

		public NSObject initWithCoder(NSCoder aDecoder)
		{
			return Call("initWithCoder:", aDecoder).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSTabViewItem");
	}
}
