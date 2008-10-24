// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSAffineTransform.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSAppKitAdditonsForNSAffineTransformCategory
	{
		public static NSBezierPath transformBezierPath(this NSAffineTransform _instance, NSBezierPath aPath)
		{
			return _instance.Call("transformBezierPath:", aPath).To<NSBezierPath>();
		}

		public static void set(this NSAffineTransform _instance)
		{
			Unused.Value = _instance.Call("set");
		}

		public static void concat(this NSAffineTransform _instance)
		{
			Unused.Value = _instance.Call("concat");
		}
	}
}
