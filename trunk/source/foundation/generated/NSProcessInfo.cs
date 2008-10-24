// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSProcessInfo.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSWindowsNTOperatingSystem = 1;
		public const int NSWindows95OperatingSystem = 2;
		public const int NSSolarisOperatingSystem = 3;
		public const int NSHPUXOperatingSystem = 4;
		public const int NSMACHOperatingSystem = 5;
		public const int NSSunOSOperatingSystem = 6;
		public const int NSOSF1OperatingSystem = 7;
	}

	[Register]
	public partial class NSProcessInfo : NSObject
	{
		public NSProcessInfo() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSProcessInfo(IntPtr instance) : base(instance)
		{
		}

		public NSProcessInfo(Untyped instance) : base(instance)
		{
		}

		public static new NSProcessInfo alloc()
		{
			return new NSProcessInfo(ms_class.Call("alloc"));
		}

		public new NSProcessInfo retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSProcessInfo processInfo()
		{
			return ms_class.Call("processInfo").To<NSProcessInfo>();
		}

		public NSDictionary environment()
		{
			return Call("environment").To<NSDictionary>();
		}

		public NSArray arguments()
		{
			return Call("arguments").To<NSArray>();
		}

		public NSString hostName()
		{
			return Call("hostName").To<NSString>();
		}

		public NSString processName()
		{
			return Call("processName").To<NSString>();
		}

		public Int32 processIdentifier()
		{
			return Call("processIdentifier").To<Int32>();
		}

		public void setProcessName(NSString newName)
		{
			Unused.Value = Call("setProcessName:", newName);
		}

		public NSString globallyUniqueString()
		{
			return Call("globallyUniqueString").To<NSString>();
		}

		public UInt32 operatingSystem()
		{
			return Call("operatingSystem").To<UInt32>();
		}

		public NSString operatingSystemName()
		{
			return Call("operatingSystemName").To<NSString>();
		}

		public NSString operatingSystemVersionString()
		{
			return Call("operatingSystemVersionString").To<NSString>();
		}

		public UInt32 processorCount()
		{
			return Call("processorCount").To<UInt32>();
		}

		public UInt32 activeProcessorCount()
		{
			return Call("activeProcessorCount").To<UInt32>();
		}

		public UInt64 physicalMemory()
		{
			return Call("physicalMemory").To<UInt64>();
		}

		private static Class ms_class = new Class("NSProcessInfo");
	}
}
