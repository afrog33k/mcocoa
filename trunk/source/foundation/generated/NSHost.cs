// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSHost.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSHost : NSObject
	{
		public NSHost() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSHost(IntPtr instance) : base(instance)
		{
		}

		public NSHost(Untyped instance) : base(instance)
		{
		}

		public static new NSHost alloc()
		{
			return new NSHost(ms_class.Call("alloc"));
		}

		public new NSHost retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSHost currentHost()
		{
			return ms_class.Call("currentHost").To<NSHost>();
		}

		public static NSHost hostWithName(NSString name)
		{
			return ms_class.Call("hostWithName:", name).To<NSHost>();
		}

		public static NSHost hostWithAddress(NSString address)
		{
			return ms_class.Call("hostWithAddress:", address).To<NSHost>();
		}

		public static void setHostCacheEnabled(bool flag)
		{
			Unused.Value = ms_class.Call("setHostCacheEnabled:", flag);
		}

		public static bool isHostCacheEnabled()
		{
			return ms_class.Call("isHostCacheEnabled").To<bool>();
		}

		public static void flushHostCache()
		{
			Unused.Value = ms_class.Call("flushHostCache");
		}

		public bool isEqualToHost(NSHost aHost)
		{
			return Call("isEqualToHost:", aHost).To<bool>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public NSArray names()
		{
			return Call("names").To<NSArray>();
		}

		public NSString address()
		{
			return Call("address").To<NSString>();
		}

		public NSArray addresses()
		{
			return Call("addresses").To<NSArray>();
		}

		private static Class ms_class = new Class("NSHost");
	}
}
