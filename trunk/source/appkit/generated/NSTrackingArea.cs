// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTrackingArea.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTrackingMouseEnteredAndExited = 0x01;
		public const int NSTrackingMouseMoved = 0x02;
		public const int NSTrackingCursorUpdate = 0x04;
	}

	public partial class Enums
	{
		public const int NSTrackingActiveWhenFirstResponder = 0x10;
		public const int NSTrackingActiveInKeyWindow = 0x20;
		public const int NSTrackingActiveInActiveApp = 0x40;
		public const int NSTrackingActiveAlways = 0x80;
	}

	public partial class Enums
	{
		public const int NSTrackingAssumeInside = 0x100;
		public const int NSTrackingInVisibleRect = 0x200;
		public const int NSTrackingEnabledDuringMouseDrag = 0x400;
	}

	[Register]
	public partial class NSTrackingArea : NSObject
	{
		public NSTrackingArea() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTrackingArea(IntPtr instance) : base(instance)
		{
		}

		public NSTrackingArea(Untyped instance) : base(instance)
		{
		}

		public static new NSTrackingArea alloc()
		{
			return new NSTrackingArea(ms_class.Call("alloc"));
		}

		public new NSTrackingArea retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSTrackingArea initWithRectOptionsOwnerUserInfo(NSRect rect, UInt32 options, NSObject owner, NSDictionary userInfo)
		{
			return Call("initWithRect:options:owner:userInfo:", rect, options, owner, userInfo).To<NSTrackingArea>();
		}

		public NSRect rect()
		{
			return Call("rect").To<NSRect>();
		}

		public UInt32 options()
		{
			return Call("options").To<UInt32>();
		}

		public NSObject owner()
		{
			return Call("owner").To<NSObject>();
		}

		public NSDictionary userInfo()
		{
			return Call("userInfo").To<NSDictionary>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSTrackingArea");
	}
}
