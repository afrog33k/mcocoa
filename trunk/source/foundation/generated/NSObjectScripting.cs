// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSObjectScripting.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSScriptingForNSObjectCategory
	{
		public static NSObject scriptingValueForSpecifier(this NSObject _instance, NSScriptObjectSpecifier objectSpecifier)
		{
			return _instance.Call("scriptingValueForSpecifier:", objectSpecifier).To<NSObject>();
		}

		public static NSDictionary scriptingProperties(this NSObject _instance)
		{
			return _instance.Call("scriptingProperties").To<NSDictionary>();
		}

		public static void setScriptingProperties(this NSObject _instance, NSDictionary properties)
		{
			Unused.Value = _instance.Call("setScriptingProperties:", properties);
		}

		public static NSObject copyScriptingValueForKeyWithProperties(this NSObject _instance, NSObject value, NSString key, NSDictionary properties)
		{
			return _instance.Call("copyScriptingValue:forKey:withProperties:", value, key, properties).To<NSObject>();
		}

		public static NSObject newScriptingObjectOfClassForValueForKeyWithContentsValueProperties(this NSObject _instance, Class objectClass, NSString key, NSObject contentsValue, NSDictionary properties)
		{
			return _instance.Call("newScriptingObjectOfClass:forValueForKey:withContentsValue:properties:", objectClass, key, contentsValue, properties).To<NSObject>();
		}
	}
}
