// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSOperation.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSOperationQueuePriorityVeryLow = -8;
		public const int NSOperationQueuePriorityLow = -4;
		public const int NSOperationQueuePriorityNormal = 0;
		public const int NSOperationQueuePriorityHigh = 4;
		public const int NSOperationQueuePriorityVeryHigh = 8;
	}

	public partial class Enums
	{
		public const int NSOperationQueueDefaultMaxConcurrentOperationCount = -1;
	}

	[Register]
	public partial class NSOperation : NSObject
	{
		public NSOperation() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOperation(IntPtr instance) : base(instance)
		{
		}

		public NSOperation(Untyped instance) : base(instance)
		{
		}

		public static new NSOperation alloc()
		{
			return new NSOperation(ms_class.Call("alloc"));
		}

		public new NSOperation retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public void start()
		{
			Unused.Value = Call("start");
		}

		public void main()
		{
			Unused.Value = Call("main");
		}

		public bool isCancelled()
		{
			return Call("isCancelled").To<bool>();
		}

		public void cancel()
		{
			Unused.Value = Call("cancel");
		}

		public bool isExecuting()
		{
			return Call("isExecuting").To<bool>();
		}

		public bool isFinished()
		{
			return Call("isFinished").To<bool>();
		}

		public bool isConcurrent()
		{
			return Call("isConcurrent").To<bool>();
		}

		public bool isReady()
		{
			return Call("isReady").To<bool>();
		}

		public void addDependency(NSOperation op)
		{
			Unused.Value = Call("addDependency:", op);
		}

		public void removeDependency(NSOperation op)
		{
			Unused.Value = Call("removeDependency:", op);
		}

		public NSArray dependencies()
		{
			return Call("dependencies").To<NSArray>();
		}

		public Int32 queuePriority()
		{
			return Call("queuePriority").To<Int32>();
		}

		public void setQueuePriority(Int32 p)
		{
			Unused.Value = Call("setQueuePriority:", p);
		}

		private static Class ms_class = new Class("NSOperation");
	}

	[Register]
	public partial class NSInvocationOperation : NSOperation
	{
		public NSInvocationOperation() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSInvocationOperation(IntPtr instance) : base(instance)
		{
		}

		public NSInvocationOperation(Untyped instance) : base(instance)
		{
		}

		public static new NSInvocationOperation alloc()
		{
			return new NSInvocationOperation(ms_class.Call("alloc"));
		}

		public new NSInvocationOperation retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithTargetSelectorObject(NSObject target, Selector sel, NSObject arg)
		{
			return Call("initWithTarget:selector:object:", target, sel, arg).To<NSObject>();
		}

		public NSObject initWithInvocation(NSInvocation inv)
		{
			return Call("initWithInvocation:", inv).To<NSObject>();
		}

		public NSInvocation invocation()
		{
			return Call("invocation").To<NSInvocation>();
		}

		public NSObject result()
		{
			return Call("result").To<NSObject>();
		}

		private static Class ms_class = new Class("NSInvocationOperation");
	}

	[Register]
	public partial class NSOperationQueue : NSObject
	{
		public NSOperationQueue() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOperationQueue(IntPtr instance) : base(instance)
		{
		}

		public NSOperationQueue(Untyped instance) : base(instance)
		{
		}

		public static new NSOperationQueue alloc()
		{
			return new NSOperationQueue(ms_class.Call("alloc"));
		}

		public new NSOperationQueue retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void addOperation(NSOperation op)
		{
			Unused.Value = Call("addOperation:", op);
		}

		public NSArray operations()
		{
			return Call("operations").To<NSArray>();
		}

		public Int32 maxConcurrentOperationCount()
		{
			return Call("maxConcurrentOperationCount").To<Int32>();
		}

		public void setMaxConcurrentOperationCount(Int32 cnt)
		{
			Unused.Value = Call("setMaxConcurrentOperationCount:", cnt);
		}

		public void setSuspended(bool b)
		{
			Unused.Value = Call("setSuspended:", b);
		}

		public bool isSuspended()
		{
			return Call("isSuspended").To<bool>();
		}

		public void cancelAllOperations()
		{
			Unused.Value = Call("cancelAllOperations");
		}

		public void waitUntilAllOperationsAreFinished()
		{
			Unused.Value = Call("waitUntilAllOperationsAreFinished");
		}

		private static Class ms_class = new Class("NSOperationQueue");
	}
}
