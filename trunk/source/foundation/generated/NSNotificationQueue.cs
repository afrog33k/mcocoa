// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSNotificationQueue.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSPostWhenIdle = 1;
		public const int NSPostASAP = 2;
		public const int NSPostNow = 3;
	}

	public partial class Enums
	{
		public const int NSNotificationNoCoalescing = 0;
		public const int NSNotificationCoalescingOnName = 1;
		public const int NSNotificationCoalescingOnSender = 2;
	}

	[Register]
	public partial class NSNotificationQueue : NSObject
	{
		public NSNotificationQueue() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNotificationQueue(IntPtr instance) : base(instance)
		{
		}

		public NSNotificationQueue(Untyped instance) : base(instance)
		{
		}

		public static new NSNotificationQueue alloc()
		{
			return new NSNotificationQueue(ms_class.Call("alloc"));
		}

		public new NSNotificationQueue retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject defaultQueue()
		{
			return ms_class.Call("defaultQueue").To<NSObject>();
		}

		public NSObject initWithNotificationCenter(NSNotificationCenter notificationCenter)
		{
			return Call("initWithNotificationCenter:", notificationCenter).To<NSObject>();
		}

		public void enqueueNotificationPostingStyle(NSNotification notification, UInt32 postingStyle)
		{
			Unused.Value = Call("enqueueNotification:postingStyle:", notification, postingStyle);
		}

		public void enqueueNotificationPostingStyleCoalesceMaskForModes(NSNotification notification, UInt32 postingStyle, UInt32 coalesceMask, NSArray modes)
		{
			Unused.Value = Call("enqueueNotification:postingStyle:coalesceMask:forModes:", notification, postingStyle, coalesceMask, modes);
		}

		public void dequeueNotificationsMatchingCoalesceMask(NSNotification notification, UInt32 coalesceMask)
		{
			Unused.Value = Call("dequeueNotificationsMatching:coalesceMask:", notification, coalesceMask);
		}

		private static Class ms_class = new Class("NSNotificationQueue");
	}
}
