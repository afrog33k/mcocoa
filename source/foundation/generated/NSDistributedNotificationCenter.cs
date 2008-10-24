// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSDistributedNotificationCenter.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNotificationSuspensionBehaviorDrop = 1;
		public const int NSNotificationSuspensionBehaviorCoalesce = 2;
		public const int NSNotificationSuspensionBehaviorHold = 3;
		public const int NSNotificationSuspensionBehaviorDeliverImmediately = 4;
	}

	public partial class Enums
	{
		public const int NSNotificationDeliverImmediately = ( 1 << 0 );
		public const int NSNotificationPostToAllSessions = ( 1 << 1 );
	}

	[Register]
	public partial class NSDistributedNotificationCenter : NSNotificationCenter
	{
		public NSDistributedNotificationCenter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDistributedNotificationCenter(IntPtr instance) : base(instance)
		{
		}

		public NSDistributedNotificationCenter(Untyped instance) : base(instance)
		{
		}

		public static new NSDistributedNotificationCenter alloc()
		{
			return new NSDistributedNotificationCenter(ms_class.Call("alloc"));
		}

		public new NSDistributedNotificationCenter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSDistributedNotificationCenter notificationCenterForType(NSString notificationCenterType)
		{
			return ms_class.Call("notificationCenterForType:", notificationCenterType).To<NSDistributedNotificationCenter>();
		}

		// skipping defaultCenter (it's declared in a base class)

		public void addObserverSelectorNameObjectSuspensionBehavior(NSObject observer, Selector selector, NSString name, NSString object_, UInt32 suspensionBehavior)
		{
			Unused.Value = Call("addObserver:selector:name:object:suspensionBehavior:", observer, selector, name, object_, suspensionBehavior);
		}

		public void postNotificationNameObjectUserInfoDeliverImmediately(NSString name, NSString object_, NSDictionary userInfo, bool deliverImmediately)
		{
			Unused.Value = Call("postNotificationName:object:userInfo:deliverImmediately:", name, object_, userInfo, deliverImmediately);
		}

		public void postNotificationNameObjectUserInfoOptions(NSString name, NSString object_, NSDictionary userInfo, UInt32 options)
		{
			Unused.Value = Call("postNotificationName:object:userInfo:options:", name, object_, userInfo, options);
		}

		public void setSuspended(bool suspended)
		{
			Unused.Value = Call("setSuspended:", suspended);
		}

		public bool suspended()
		{
			return Call("suspended").To<bool>();
		}

		// skipping addObserver:selector:name:object: (it's declared in a base class)

		// skipping postNotificationName:object: (it's declared in a base class)

		// skipping postNotificationName:object:userInfo: (it's declared in a base class)

		// skipping removeObserver:name:object: (it's declared in a base class)

		private static Class ms_class = new Class("NSDistributedNotificationCenter");
	}
}
