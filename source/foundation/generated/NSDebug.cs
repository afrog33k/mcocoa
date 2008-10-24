// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSDebug.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSAutoreleasePoolDebuggingForNSAutoreleasePoolCategory
	{
		public static void enableRelease(this NSAutoreleasePool _instance, bool enable)
		{
			Unused.Value = _instance.Call("enableRelease:", enable);
		}

		public static void showPools(this NSAutoreleasePool _instance)
		{
			Unused.Value = _instance.Call("showPools");
		}

		public static void resetTotalAutoreleasedObjects(this NSAutoreleasePool _instance)
		{
			Unused.Value = _instance.Call("resetTotalAutoreleasedObjects");
		}

		public static UInt32 totalAutoreleasedObjects(this NSAutoreleasePool _instance)
		{
			return _instance.Call("totalAutoreleasedObjects").To<UInt32>();
		}

		public static void enableFreedObjectCheck(this NSAutoreleasePool _instance, bool enable)
		{
			Unused.Value = _instance.Call("enableFreedObjectCheck:", enable);
		}

		public static UInt32 autoreleasedObjectCount(this NSAutoreleasePool _instance)
		{
			return _instance.Call("autoreleasedObjectCount").To<UInt32>();
		}

		public static UInt32 topAutoreleasePoolCount(this NSAutoreleasePool _instance)
		{
			return _instance.Call("topAutoreleasePoolCount").To<UInt32>();
		}

		public static UInt32 poolCountHighWaterMark(this NSAutoreleasePool _instance)
		{
			return _instance.Call("poolCountHighWaterMark").To<UInt32>();
		}

		public static void setPoolCountHighWaterMark(this NSAutoreleasePool _instance, UInt32 count)
		{
			Unused.Value = _instance.Call("setPoolCountHighWaterMark:", count);
		}

		public static UInt32 poolCountHighWaterResolution(this NSAutoreleasePool _instance)
		{
			return _instance.Call("poolCountHighWaterResolution").To<UInt32>();
		}

		public static void setPoolCountHighWaterResolution(this NSAutoreleasePool _instance, UInt32 res)
		{
			Unused.Value = _instance.Call("setPoolCountHighWaterResolution:", res);
		}
	}
}
