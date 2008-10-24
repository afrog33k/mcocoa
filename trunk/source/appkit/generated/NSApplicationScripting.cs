// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSApplicationScripting.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSScriptingForNSApplicationCategory
	{
		public static NSArray orderedDocuments(this NSApplication _instance)
		{
			return _instance.Call("orderedDocuments").To<NSArray>();
		}

		public static NSArray orderedWindows(this NSApplication _instance)
		{
			return _instance.Call("orderedWindows").To<NSArray>();
		}
	}

	public static class NSApplicationScriptingDelegationForNSObjectCategory
	{
		public static bool applicationDelegateHandlesKey(this NSObject _instance, NSApplication sender, NSString key)
		{
			return _instance.Call("application:delegateHandlesKey:", sender, key).To<bool>();
		}
	}
}
