// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptKeyValueCoding.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSScriptKeyValueCodingForNSObjectCategory
	{
		public static NSObject valueAtIndexInPropertyWithKey(this NSObject _instance, UInt32 index, NSString key)
		{
			return _instance.Call("valueAtIndex:inPropertyWithKey:", index, key).To<NSObject>();
		}

		public static NSObject valueWithNameInPropertyWithKey(this NSObject _instance, NSString name, NSString key)
		{
			return _instance.Call("valueWithName:inPropertyWithKey:", name, key).To<NSObject>();
		}

		public static NSObject valueWithUniqueIDInPropertyWithKey(this NSObject _instance, NSObject uniqueID, NSString key)
		{
			return _instance.Call("valueWithUniqueID:inPropertyWithKey:", uniqueID, key).To<NSObject>();
		}

		public static void insertValueAtIndexInPropertyWithKey(this NSObject _instance, NSObject value, UInt32 index, NSString key)
		{
			Unused.Value = _instance.Call("insertValue:atIndex:inPropertyWithKey:", value, index, key);
		}

		public static void removeValueAtIndexFromPropertyWithKey(this NSObject _instance, UInt32 index, NSString key)
		{
			Unused.Value = _instance.Call("removeValueAtIndex:fromPropertyWithKey:", index, key);
		}

		public static void replaceValueAtIndexInPropertyWithKeyWithValue(this NSObject _instance, UInt32 index, NSString key, NSObject value)
		{
			Unused.Value = _instance.Call("replaceValueAtIndex:inPropertyWithKey:withValue:", index, key, value);
		}

		public static void insertValueInPropertyWithKey(this NSObject _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("insertValue:inPropertyWithKey:", value, key);
		}

		public static NSObject coerceValueForKey(this NSObject _instance, NSObject value, NSString key)
		{
			return _instance.Call("coerceValue:forKey:", value, key).To<NSObject>();
		}
	}
}
