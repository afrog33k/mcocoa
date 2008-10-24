// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSNibLoading.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSNibLoadingForNSBundleCategory
	{
		public static bool loadNibFileExternalNameTableWithZone(this NSBundle _instance, NSString fileName, NSDictionary context, IntPtr zone)
		{
			return _instance.Call("loadNibFile:externalNameTable:withZone:", fileName, context, zone).To<bool>();
		}

		public static bool loadNibNamedOwner(this NSBundle _instance, NSString nibName, NSObject owner)
		{
			return _instance.Call("loadNibNamed:owner:", nibName, owner).To<bool>();
		}

		// skipping loadNibFile:externalNameTable:withZone: (it's already defined)
	}

	public static class NSNibAwakingForNSObjectCategory
	{
		public static void awakeFromNib(this NSObject _instance)
		{
			Unused.Value = _instance.Call("awakeFromNib");
		}
	}
}
