// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDockTile.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSDockTile : NSObject
	{
		public NSDockTile() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDockTile(IntPtr instance) : base(instance)
		{
		}

		public NSDockTile(Untyped instance) : base(instance)
		{
		}

		public static new NSDockTile alloc()
		{
			return new NSDockTile(ms_class.Call("alloc"));
		}

		public new NSDockTile retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSSize size()
		{
			return Call("size").To<NSSize>();
		}

		public void setContentView(NSView view)
		{
			Unused.Value = Call("setContentView:", view);
		}

		public NSView contentView()
		{
			return Call("contentView").To<NSView>();
		}

		public void display()
		{
			Unused.Value = Call("display");
		}

		public void setShowsApplicationBadge(bool flag)
		{
			Unused.Value = Call("setShowsApplicationBadge:", flag);
		}

		public bool showsApplicationBadge()
		{
			return Call("showsApplicationBadge").To<bool>();
		}

		public void setBadgeLabel(NSString string_)
		{
			Unused.Value = Call("setBadgeLabel:", string_);
		}

		public NSString badgeLabel()
		{
			return Call("badgeLabel").To<NSString>();
		}

		public NSObject owner()
		{
			return Call("owner").To<NSObject>();
		}

		private static Class ms_class = new Class("NSDockTile");
	}
}
