// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPanel.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSAlertDefaultReturn = 1;
		public const int NSAlertAlternateReturn = 0;
		public const int NSAlertOtherReturn = -1;
		public const int NSAlertErrorReturn = -2;
	}

	public partial class Enums
	{
		public const int NSOKButton = 1;
		public const int NSCancelButton = 0;
	}

	public partial class Enums
	{
		public const int NSUtilityWindowMask = 1 << 4;
		public const int NSDocModalWindowMask = 1 << 6;
	}

	public partial class Enums
	{
		public const int NSNonactivatingPanelMask = 1 << 7;
	}

	public partial class Enums
	{
		public const int NSHUDWindowMask = 1 << 13;
	}

	[Register]
	public partial class NSPanel : NSWindow
	{
		public NSPanel() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPanel(IntPtr instance) : base(instance)
		{
		}

		public NSPanel(Untyped instance) : base(instance)
		{
		}

		public static new NSPanel alloc()
		{
			return new NSPanel(ms_class.Call("alloc"));
		}

		public new NSPanel retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool isFloatingPanel()
		{
			return Call("isFloatingPanel").To<bool>();
		}

		public void setFloatingPanel(bool flag)
		{
			Unused.Value = Call("setFloatingPanel:", flag);
		}

		public bool becomesKeyOnlyIfNeeded()
		{
			return Call("becomesKeyOnlyIfNeeded").To<bool>();
		}

		public void setBecomesKeyOnlyIfNeeded(bool flag)
		{
			Unused.Value = Call("setBecomesKeyOnlyIfNeeded:", flag);
		}

		// skipping worksWhenModal (it's declared in a base class)

		public void setWorksWhenModal(bool flag)
		{
			Unused.Value = Call("setWorksWhenModal:", flag);
		}

		private static Class ms_class = new Class("NSPanel");
	}
}
