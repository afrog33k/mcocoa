// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSNotification.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSNotification : NSObject
	{
		public NSNotification() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNotification(IntPtr instance) : base(instance)
		{
		}

		public NSNotification(Untyped instance) : base(instance)
		{
		}

		public static new NSNotification alloc()
		{
			return new NSNotification(ms_class.Call("alloc"));
		}

		public new NSNotification retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public NSObject object_()
		{
			return Call("object").To<NSObject>();
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

		private static Class ms_class = new Class("NSNotification");
	}

	public static class NSNotificationCreationForNSNotificationCategory
	{
		public static NSObject notificationWithNameObject(this NSNotification _instance, NSString aName, NSObject anObject)
		{
			return _instance.Call("notificationWithName:object:", aName, anObject).To<NSObject>();
		}

		public static NSObject notificationWithNameObjectUserInfo(this NSNotification _instance, NSString aName, NSObject anObject, NSDictionary aUserInfo)
		{
			return _instance.Call("notificationWithName:object:userInfo:", aName, anObject, aUserInfo).To<NSObject>();
		}
	}

	[Register]
	public partial class NSNotificationCenter : NSObject
	{
		public NSNotificationCenter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNotificationCenter(IntPtr instance) : base(instance)
		{
		}

		public NSNotificationCenter(Untyped instance) : base(instance)
		{
		}

		public static new NSNotificationCenter alloc()
		{
			return new NSNotificationCenter(ms_class.Call("alloc"));
		}

		public new NSNotificationCenter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject defaultCenter()
		{
			return ms_class.Call("defaultCenter").To<NSObject>();
		}

		public void addObserverSelectorNameObject(NSObject observer, Selector aSelector, NSString aName, NSObject anObject)
		{
			Unused.Value = Call("addObserver:selector:name:object:", observer, aSelector, aName, anObject);
		}

		public void postNotification(NSNotification notification)
		{
			Unused.Value = Call("postNotification:", notification);
		}

		public void postNotificationNameObject(NSString aName, NSObject anObject)
		{
			Unused.Value = Call("postNotificationName:object:", aName, anObject);
		}

		public void postNotificationNameObjectUserInfo(NSString aName, NSObject anObject, NSDictionary aUserInfo)
		{
			Unused.Value = Call("postNotificationName:object:userInfo:", aName, anObject, aUserInfo);
		}

		public void removeObserver(NSObject observer)
		{
			Unused.Value = Call("removeObserver:", observer);
		}

		public void removeObserverNameObject(NSObject observer, NSString aName, NSObject anObject)
		{
			Unused.Value = Call("removeObserver:name:object:", observer, aName, anObject);
		}

		private static Class ms_class = new Class("NSNotificationCenter");
	}
}
