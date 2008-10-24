// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSLock.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSLock : NSObject
	{
		public NSLock() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSLock(IntPtr instance) : base(instance)
		{
		}

		public NSLock(Untyped instance) : base(instance)
		{
		}

		public static new NSLock alloc()
		{
			return new NSLock(ms_class.Call("alloc"));
		}

		public new NSLock retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool tryLock()
		{
			return Call("tryLock").To<bool>();
		}

		public bool lockBeforeDate(NSDate limit)
		{
			return Call("lockBeforeDate:", limit).To<bool>();
		}

		public void setNameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSString n)
		{
			Unused.Value = Call("setName:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", n);
		}

		public NSString nameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("nameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSString>();
		}

		#region NSLocking Methods
		public void lock_()
		{
			Unused.Value = Call("lock");
		}

		public void unlock()
		{
			Unused.Value = Call("unlock");
		}
		#endregion

		private static Class ms_class = new Class("NSLock");
	}

	[Register]
	public partial class NSConditionLock : NSObject
	{
		public NSConditionLock() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSConditionLock(IntPtr instance) : base(instance)
		{
		}

		public NSConditionLock(Untyped instance) : base(instance)
		{
		}

		public static new NSConditionLock alloc()
		{
			return new NSConditionLock(ms_class.Call("alloc"));
		}

		public new NSConditionLock retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithCondition(Int32 condition)
		{
			return Call("initWithCondition:", condition).To<NSObject>();
		}

		public Int32 condition()
		{
			return Call("condition").To<Int32>();
		}

		public void lockWhenCondition(Int32 condition)
		{
			Unused.Value = Call("lockWhenCondition:", condition);
		}

		public bool tryLock()
		{
			return Call("tryLock").To<bool>();
		}

		public bool tryLockWhenCondition(Int32 condition)
		{
			return Call("tryLockWhenCondition:", condition).To<bool>();
		}

		public void unlockWithCondition(Int32 condition)
		{
			Unused.Value = Call("unlockWithCondition:", condition);
		}

		public bool lockBeforeDate(NSDate limit)
		{
			return Call("lockBeforeDate:", limit).To<bool>();
		}

		public bool lockWhenConditionBeforeDate(Int32 condition, NSDate limit)
		{
			return Call("lockWhenCondition:beforeDate:", condition, limit).To<bool>();
		}

		public void setNameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSString n)
		{
			Unused.Value = Call("setName:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", n);
		}

		public NSString nameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("nameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSString>();
		}

		#region NSLocking Methods
		public void lock_()
		{
			Unused.Value = Call("lock");
		}

		public void unlock()
		{
			Unused.Value = Call("unlock");
		}
		#endregion

		private static Class ms_class = new Class("NSConditionLock");
	}

	[Register]
	public partial class NSRecursiveLock : NSObject
	{
		public NSRecursiveLock() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSRecursiveLock(IntPtr instance) : base(instance)
		{
		}

		public NSRecursiveLock(Untyped instance) : base(instance)
		{
		}

		public static new NSRecursiveLock alloc()
		{
			return new NSRecursiveLock(ms_class.Call("alloc"));
		}

		public new NSRecursiveLock retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool tryLock()
		{
			return Call("tryLock").To<bool>();
		}

		public bool lockBeforeDate(NSDate limit)
		{
			return Call("lockBeforeDate:", limit).To<bool>();
		}

		public void setNameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSString n)
		{
			Unused.Value = Call("setName:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", n);
		}

		public NSString nameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("nameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSString>();
		}

		#region NSLocking Methods
		public void lock_()
		{
			Unused.Value = Call("lock");
		}

		public void unlock()
		{
			Unused.Value = Call("unlock");
		}
		#endregion

		private static Class ms_class = new Class("NSRecursiveLock");
	}

	[Register]
	public partial class NSCondition : NSObject
	{
		public NSCondition() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCondition(IntPtr instance) : base(instance)
		{
		}

		public NSCondition(Untyped instance) : base(instance)
		{
		}

		public static new NSCondition alloc()
		{
			return new NSCondition(ms_class.Call("alloc"));
		}

		public new NSCondition retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void wait()
		{
			Unused.Value = Call("wait");
		}

		public bool waitUntilDate(NSDate limit)
		{
			return Call("waitUntilDate:", limit).To<bool>();
		}

		public void signal()
		{
			Unused.Value = Call("signal");
		}

		public void broadcast()
		{
			Unused.Value = Call("broadcast");
		}

		public void setNameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSString n)
		{
			Unused.Value = Call("setName:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", n);
		}

		public NSString nameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("nameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSString>();
		}

		#region NSLocking Methods
		public void lock_()
		{
			Unused.Value = Call("lock");
		}

		public void unlock()
		{
			Unused.Value = Call("unlock");
		}
		#endregion

		private static Class ms_class = new Class("NSCondition");
	}
}
