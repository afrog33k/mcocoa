// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSRange.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSValueRangeExtensionsForNSValueCategory
	{
		public static NSValue valueWithRange(this NSValue _instance, NSRange range)
		{
			return _instance.Call("valueWithRange:", range).To<NSValue>();
		}

		public static NSRange rangeValue(this NSValue _instance)
		{
			return _instance.Call("rangeValue").To<NSRange>();
		}
	}
}
