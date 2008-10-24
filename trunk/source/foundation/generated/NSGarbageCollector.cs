// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSGarbageCollector.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSGarbageCollector : NSObject
	{
		public NSGarbageCollector() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSGarbageCollector(IntPtr instance) : base(instance)
		{
		}

		public NSGarbageCollector(Untyped instance) : base(instance)
		{
		}

		public static new NSGarbageCollector alloc()
		{
			return new NSGarbageCollector(ms_class.Call("alloc"));
		}

		public new NSGarbageCollector retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject defaultCollector()
		{
			return ms_class.Call("defaultCollector").To<NSObject>();
		}

		public bool isCollecting()
		{
			return Call("isCollecting").To<bool>();
		}

		public void disable()
		{
			Unused.Value = Call("disable");
		}

		public void enable()
		{
			Unused.Value = Call("enable");
		}

		public bool isEnabled()
		{
			return Call("isEnabled").To<bool>();
		}

		public void collectIfNeeded()
		{
			Unused.Value = Call("collectIfNeeded");
		}

		public void collectExhaustively()
		{
			Unused.Value = Call("collectExhaustively");
		}

		public void disableCollectorForPointer(IntPtr ptr)
		{
			Unused.Value = Call("disableCollectorForPointer:", ptr);
		}

		public void enableCollectorForPointer(IntPtr ptr)
		{
			Unused.Value = Call("enableCollectorForPointer:", ptr);
		}

		// skipping zone (it's already defined)

		private static Class ms_class = new Class("NSGarbageCollector");
	}
}
