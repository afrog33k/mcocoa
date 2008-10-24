// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSThread.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSThread : NSObject
	{
		public NSThread() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSThread(IntPtr instance) : base(instance)
		{
		}

		public NSThread(Untyped instance) : base(instance)
		{
		}

		public static new NSThread alloc()
		{
			return new NSThread(ms_class.Call("alloc"));
		}

		public new NSThread retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSThread currentThread()
		{
			return ms_class.Call("currentThread").To<NSThread>();
		}

		public static void detachNewThreadSelectorToTargetWithObject(Selector selector, NSObject target, NSObject argument)
		{
			Unused.Value = ms_class.Call("detachNewThreadSelector:toTarget:withObject:", selector, target, argument);
		}

		public static bool isMultiThreaded()
		{
			return ms_class.Call("isMultiThreaded").To<bool>();
		}

		public NSMutableDictionary threadDictionary()
		{
			return Call("threadDictionary").To<NSMutableDictionary>();
		}

		public static void sleepUntilDate(NSDate date)
		{
			Unused.Value = ms_class.Call("sleepUntilDate:", date);
		}

		public static void sleepForTimeInterval(double ti)
		{
			Unused.Value = ms_class.Call("sleepForTimeInterval:", ti);
		}

		public static void exit()
		{
			Unused.Value = ms_class.Call("exit");
		}

		public static double threadPriority()
		{
			return ms_class.Call("threadPriority").To<double>();
		}

		public static bool setThreadPriority(double p)
		{
			return ms_class.Call("setThreadPriority:", p).To<bool>();
		}

		public static NSArray callStackReturnAddresses()
		{
			return ms_class.Call("callStackReturnAddresses").To<NSArray>();
		}

		public void setName(NSString n)
		{
			Unused.Value = Call("setName:", n);
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public UInt32 stackSize()
		{
			return Call("stackSize").To<UInt32>();
		}

		public void setStackSize(UInt32 s)
		{
			Unused.Value = Call("setStackSize:", s);
		}

		public bool isMainThread()
		{
			return Call("isMainThread").To<bool>();
		}

		// skipping isMainThread (it's already defined)

		public static NSThread mainThread()
		{
			return ms_class.Call("mainThread").To<NSThread>();
		}

		// skipping init (it's already defined)

		public NSObject initWithTargetSelectorObject(NSObject target, Selector selector, NSObject argument)
		{
			return Call("initWithTarget:selector:object:", target, selector, argument).To<NSObject>();
		}

		public bool isExecuting()
		{
			return Call("isExecuting").To<bool>();
		}

		public bool isFinished()
		{
			return Call("isFinished").To<bool>();
		}

		public bool isCancelled()
		{
			return Call("isCancelled").To<bool>();
		}

		public void cancel()
		{
			Unused.Value = Call("cancel");
		}

		public void start()
		{
			Unused.Value = Call("start");
		}

		public void main()
		{
			Unused.Value = Call("main");
		}

		private static Class ms_class = new Class("NSThread");
	}

	public static class NSThreadPerformAdditionsForNSObjectCategory
	{
		public static void performSelectorOnMainThreadWithObjectWaitUntilDoneModes(this NSObject _instance, Selector aSelector, NSObject arg, bool wait, NSArray array)
		{
			Unused.Value = _instance.Call("performSelectorOnMainThread:withObject:waitUntilDone:modes:", aSelector, arg, wait, array);
		}

		public static void performSelectorOnMainThreadWithObjectWaitUntilDone(this NSObject _instance, Selector aSelector, NSObject arg, bool wait)
		{
			Unused.Value = _instance.Call("performSelectorOnMainThread:withObject:waitUntilDone:", aSelector, arg, wait);
		}

		public static void performSelectorOnThreadWithObjectWaitUntilDoneModes(this NSObject _instance, Selector aSelector, NSThread thr, NSObject arg, bool wait, NSArray array)
		{
			Unused.Value = _instance.Call("performSelector:onThread:withObject:waitUntilDone:modes:", aSelector, thr, arg, wait, array);
		}

		public static void performSelectorOnThreadWithObjectWaitUntilDone(this NSObject _instance, Selector aSelector, NSThread thr, NSObject arg, bool wait)
		{
			Unused.Value = _instance.Call("performSelector:onThread:withObject:waitUntilDone:", aSelector, thr, arg, wait);
		}

		public static void performSelectorInBackgroundWithObject(this NSObject _instance, Selector aSelector, NSObject arg)
		{
			Unused.Value = _instance.Call("performSelectorInBackground:withObject:", aSelector, arg);
		}
	}
}
