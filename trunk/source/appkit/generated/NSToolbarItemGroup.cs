// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSToolbarItemGroup.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSToolbarItemGroup : NSToolbarItem
	{
		public NSToolbarItemGroup() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSToolbarItemGroup(IntPtr instance) : base(instance)
		{
		}

		public NSToolbarItemGroup(Untyped instance) : base(instance)
		{
		}

		public static new NSToolbarItemGroup alloc()
		{
			return new NSToolbarItemGroup(ms_class.Call("alloc"));
		}

		public new NSToolbarItemGroup retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setSubitems(NSArray subitems)
		{
			Unused.Value = Call("setSubitems:", subitems);
		}

		public NSArray subitems()
		{
			return Call("subitems").To<NSArray>();
		}

		private static Class ms_class = new Class("NSToolbarItemGroup");
	}
}
