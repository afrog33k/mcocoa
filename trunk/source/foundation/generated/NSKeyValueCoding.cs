// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSKeyValueCoding.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSKeyValueCodingForNSObjectCategory
	{
		public static bool accessInstanceVariablesDirectly(this NSObject _instance)
		{
			return _instance.Call("accessInstanceVariablesDirectly").To<bool>();
		}

		public static NSObject valueForKey(this NSObject _instance, NSString key)
		{
			return _instance.Call("valueForKey:", key).To<NSObject>();
		}

		public static void setValueForKey(this NSObject _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("setValue:forKey:", value, key);
		}

		public static bool validateValueForKeyError(this NSObject _instance, IntPtr ioValue, NSString inKey, IntPtr outError)
		{
			return _instance.Call("validateValue:forKey:error:", ioValue, inKey, outError).To<bool>();
		}

		public static NSMutableArray mutableArrayValueForKey(this NSObject _instance, NSString key)
		{
			return _instance.Call("mutableArrayValueForKey:", key).To<NSMutableArray>();
		}

		public static NSMutableSet mutableSetValueForKey(this NSObject _instance, NSString key)
		{
			return _instance.Call("mutableSetValueForKey:", key).To<NSMutableSet>();
		}

		public static NSObject valueForKeyPath(this NSObject _instance, NSString keyPath)
		{
			return _instance.Call("valueForKeyPath:", keyPath).To<NSObject>();
		}

		public static void setValueForKeyPath(this NSObject _instance, NSObject value, NSString keyPath)
		{
			Unused.Value = _instance.Call("setValue:forKeyPath:", value, keyPath);
		}

		public static bool validateValueForKeyPathError(this NSObject _instance, IntPtr ioValue, NSString inKeyPath, IntPtr outError)
		{
			return _instance.Call("validateValue:forKeyPath:error:", ioValue, inKeyPath, outError).To<bool>();
		}

		public static NSMutableArray mutableArrayValueForKeyPath(this NSObject _instance, NSString keyPath)
		{
			return _instance.Call("mutableArrayValueForKeyPath:", keyPath).To<NSMutableArray>();
		}

		public static NSMutableSet mutableSetValueForKeyPath(this NSObject _instance, NSString keyPath)
		{
			return _instance.Call("mutableSetValueForKeyPath:", keyPath).To<NSMutableSet>();
		}

		public static NSObject valueForUndefinedKey(this NSObject _instance, NSString key)
		{
			return _instance.Call("valueForUndefinedKey:", key).To<NSObject>();
		}

		public static void setValueForUndefinedKey(this NSObject _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("setValue:forUndefinedKey:", value, key);
		}

		public static void setNilValueForKey(this NSObject _instance, NSString key)
		{
			Unused.Value = _instance.Call("setNilValueForKey:", key);
		}

		public static NSDictionary dictionaryWithValuesForKeys(this NSObject _instance, NSArray keys)
		{
			return _instance.Call("dictionaryWithValuesForKeys:", keys).To<NSDictionary>();
		}

		public static void setValuesForKeysWithDictionary(this NSObject _instance, NSDictionary keyedValues)
		{
			Unused.Value = _instance.Call("setValuesForKeysWithDictionary:", keyedValues);
		}
	}

	public static class NSKeyValueCodingForNSArrayCategory
	{
		public static NSObject valueForKey(this NSArray _instance, NSString key)
		{
			return _instance.Call("valueForKey:", key).To<NSObject>();
		}

		public static void setValueForKey(this NSArray _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("setValue:forKey:", value, key);
		}
	}

	public static class NSKeyValueCodingForNSDictionaryCategory
	{
		public static NSObject valueForKey(this NSDictionary _instance, NSString key)
		{
			return _instance.Call("valueForKey:", key).To<NSObject>();
		}
	}

	public static class NSKeyValueCodingForNSMutableDictionaryCategory
	{
		public static void setValueForKey(this NSMutableDictionary _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("setValue:forKey:", value, key);
		}
	}

	public static class NSKeyValueCodingForNSSetCategory
	{
		public static NSObject valueForKey(this NSSet _instance, NSString key)
		{
			return _instance.Call("valueForKey:", key).To<NSObject>();
		}

		public static void setValueForKey(this NSSet _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("setValue:forKey:", value, key);
		}
	}

	public static class NSDeprecatedKeyValueCodingForNSObjectCategory
	{
		public static bool useStoredAccessor(this NSObject _instance)
		{
			return _instance.Call("useStoredAccessor").To<bool>();
		}

		public static NSObject storedValueForKey(this NSObject _instance, NSString key)
		{
			return _instance.Call("storedValueForKey:", key).To<NSObject>();
		}

		public static void takeStoredValueForKey(this NSObject _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("takeStoredValue:forKey:", value, key);
		}

		public static void takeValueForKey(this NSObject _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("takeValue:forKey:", value, key);
		}

		public static void takeValueForKeyPath(this NSObject _instance, NSObject value, NSString keyPath)
		{
			Unused.Value = _instance.Call("takeValue:forKeyPath:", value, keyPath);
		}

		public static NSObject handleQueryWithUnboundKey(this NSObject _instance, NSString key)
		{
			return _instance.Call("handleQueryWithUnboundKey:", key).To<NSObject>();
		}

		public static void handleTakeValueForUnboundKey(this NSObject _instance, NSObject value, NSString key)
		{
			Unused.Value = _instance.Call("handleTakeValue:forUnboundKey:", value, key);
		}

		public static void unableToSetNilForKey(this NSObject _instance, NSString key)
		{
			Unused.Value = _instance.Call("unableToSetNilForKey:", key);
		}

		public static NSDictionary valuesForKeys(this NSObject _instance, NSArray keys)
		{
			return _instance.Call("valuesForKeys:", keys).To<NSDictionary>();
		}

		public static void takeValuesFromDictionary(this NSObject _instance, NSDictionary properties)
		{
			Unused.Value = _instance.Call("takeValuesFromDictionary:", properties);
		}
	}
}
