// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSDistributedLock.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSDistributedLock : NSObject
	{
		public NSDistributedLock() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDistributedLock(IntPtr instance) : base(instance)
		{
		}

		public NSDistributedLock(Untyped instance) : base(instance)
		{
		}

		public static new NSDistributedLock alloc()
		{
			return new NSDistributedLock(ms_class.Call("alloc"));
		}

		public new NSDistributedLock retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSDistributedLock lockWithPath(NSString path)
		{
			return ms_class.Call("lockWithPath:", path).To<NSDistributedLock>();
		}

		public NSObject initWithPath(NSString path)
		{
			return Call("initWithPath:", path).To<NSObject>();
		}

		public bool tryLock()
		{
			return Call("tryLock").To<bool>();
		}

		public void unlock()
		{
			Unused.Value = Call("unlock");
		}

		public void breakLock()
		{
			Unused.Value = Call("breakLock");
		}

		public NSDate lockDate()
		{
			return Call("lockDate").To<NSDate>();
		}

		private static Class ms_class = new Class("NSDistributedLock");
	}
}
