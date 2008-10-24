// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSDictionary.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSDictionary : NSObject
	{
		public NSDictionary() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDictionary(IntPtr instance) : base(instance)
		{
		}

		public NSDictionary(Untyped instance) : base(instance)
		{
		}

		public static new NSDictionary alloc()
		{
			return new NSDictionary(ms_class.Call("alloc"));
		}

		public new NSDictionary retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 count()
		{
			return Call("count").To<UInt32>();
		}

		public NSObject objectForKey(NSObject aKey)
		{
			return Call("objectForKey:", aKey).To<NSObject>();
		}

		public NSEnumerator keyEnumerator()
		{
			return Call("keyEnumerator").To<NSEnumerator>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSMutableCopying Methods
		public NSObject mutableCopyWithZone(IntPtr zone)
		{
			return Call("mutableCopyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSCoding Methods
		public void encodeWithCoder(NSCoder aCoder)
		{
			Unused.Value = Call("encodeWithCoder:", aCoder);
		}

		public NSObject initWithCoder(NSCoder aDecoder)
		{
			return Call("initWithCoder:", aDecoder).To<NSObject>();
		}
		#endregion

		#region NSFastEnumeration Methods
		public UInt32 countByEnumeratingWithStateObjectsCount(NSFastEnumerationState state, IntPtr stackbuf, UInt32 len)
		{
			return Call("countByEnumeratingWithState:objects:count:", state, stackbuf, len).To<UInt32>();
		}
		#endregion

		private static Class ms_class = new Class("NSDictionary");
	}

	public static class NSExtendedDictionaryForNSDictionaryCategory
	{
		public static NSArray allKeys(this NSDictionary _instance)
		{
			return _instance.Call("allKeys").To<NSArray>();
		}

		public static NSArray allKeysForObject(this NSDictionary _instance, NSObject anObject)
		{
			return _instance.Call("allKeysForObject:", anObject).To<NSArray>();
		}

		public static NSArray allValues(this NSDictionary _instance)
		{
			return _instance.Call("allValues").To<NSArray>();
		}

		// skipping description (it's already defined)

		public static NSString descriptionInStringsFileFormat(this NSDictionary _instance)
		{
			return _instance.Call("descriptionInStringsFileFormat").To<NSString>();
		}

		public static NSString descriptionWithLocale(this NSDictionary _instance, NSObject locale)
		{
			return _instance.Call("descriptionWithLocale:", locale).To<NSString>();
		}

		public static NSString descriptionWithLocaleIndent(this NSDictionary _instance, NSObject locale, UInt32 level)
		{
			return _instance.Call("descriptionWithLocale:indent:", locale, level).To<NSString>();
		}

		public static bool isEqualToDictionary(this NSDictionary _instance, NSDictionary otherDictionary)
		{
			return _instance.Call("isEqualToDictionary:", otherDictionary).To<bool>();
		}

		public static NSEnumerator objectEnumerator(this NSDictionary _instance)
		{
			return _instance.Call("objectEnumerator").To<NSEnumerator>();
		}

		public static NSArray objectsForKeysNotFoundMarker(this NSDictionary _instance, NSArray keys, NSObject marker)
		{
			return _instance.Call("objectsForKeys:notFoundMarker:", keys, marker).To<NSArray>();
		}

		public static bool writeToFileAtomically(this NSDictionary _instance, NSString path, bool useAuxiliaryFile)
		{
			return _instance.Call("writeToFile:atomically:", path, useAuxiliaryFile).To<bool>();
		}

		public static bool writeToURLAtomically(this NSDictionary _instance, NSURL url, bool atomically)
		{
			return _instance.Call("writeToURL:atomically:", url, atomically).To<bool>();
		}

		public static NSArray keysSortedByValueUsingSelector(this NSDictionary _instance, Selector comparator)
		{
			return _instance.Call("keysSortedByValueUsingSelector:", comparator).To<NSArray>();
		}

		public static void getObjectsAndKeys(this NSDictionary _instance, IntPtr objects, IntPtr keys)
		{
			Unused.Value = _instance.Call("getObjects:andKeys:", objects, keys);
		}
	}

	public static class NSDictionaryCreationForNSDictionaryCategory
	{
		public static NSObject dictionary(this NSDictionary _instance)
		{
			return _instance.Call("dictionary").To<NSObject>();
		}

		public static NSObject dictionaryWithObjectForKey(this NSDictionary _instance, NSObject object_, NSObject key)
		{
			return _instance.Call("dictionaryWithObject:forKey:", object_, key).To<NSObject>();
		}

		public static NSObject dictionaryWithObjectsForKeysCount(this NSDictionary _instance, IntPtr objects, IntPtr keys, UInt32 cnt)
		{
			return _instance.Call("dictionaryWithObjects:forKeys:count:", objects, keys, cnt).To<NSObject>();
		}

		// skipping dictionaryWithObjectsAndKeys: because it is variadic

		public static NSObject dictionaryWithDictionary(this NSDictionary _instance, NSDictionary dict)
		{
			return _instance.Call("dictionaryWithDictionary:", dict).To<NSObject>();
		}

		public static NSObject dictionaryWithObjectsForKeys(this NSDictionary _instance, NSArray objects, NSArray keys)
		{
			return _instance.Call("dictionaryWithObjects:forKeys:", objects, keys).To<NSObject>();
		}

		public static NSObject initWithObjectsForKeysCount(this NSDictionary _instance, IntPtr objects, IntPtr keys, UInt32 cnt)
		{
			return _instance.Call("initWithObjects:forKeys:count:", objects, keys, cnt).To<NSObject>();
		}

		// skipping initWithObjectsAndKeys: because it is variadic

		public static NSObject initWithDictionary(this NSDictionary _instance, NSDictionary otherDictionary)
		{
			return _instance.Call("initWithDictionary:", otherDictionary).To<NSObject>();
		}

		public static NSObject initWithDictionaryCopyItems(this NSDictionary _instance, NSDictionary otherDictionary, bool flag)
		{
			return _instance.Call("initWithDictionary:copyItems:", otherDictionary, flag).To<NSObject>();
		}

		public static NSObject initWithObjectsForKeys(this NSDictionary _instance, NSArray objects, NSArray keys)
		{
			return _instance.Call("initWithObjects:forKeys:", objects, keys).To<NSObject>();
		}

		public static NSObject dictionaryWithContentsOfFile(this NSDictionary _instance, NSString path)
		{
			return _instance.Call("dictionaryWithContentsOfFile:", path).To<NSObject>();
		}

		public static NSObject dictionaryWithContentsOfURL(this NSDictionary _instance, NSURL url)
		{
			return _instance.Call("dictionaryWithContentsOfURL:", url).To<NSObject>();
		}

		public static NSObject initWithContentsOfFile(this NSDictionary _instance, NSString path)
		{
			return _instance.Call("initWithContentsOfFile:", path).To<NSObject>();
		}

		public static NSObject initWithContentsOfURL(this NSDictionary _instance, NSURL url)
		{
			return _instance.Call("initWithContentsOfURL:", url).To<NSObject>();
		}
	}

	[Register]
	public partial class NSMutableDictionary : NSDictionary
	{
		public NSMutableDictionary() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableDictionary(IntPtr instance) : base(instance)
		{
		}

		public NSMutableDictionary(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableDictionary alloc()
		{
			return new NSMutableDictionary(ms_class.Call("alloc"));
		}

		public new NSMutableDictionary retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void removeObjectForKey(NSObject aKey)
		{
			Unused.Value = Call("removeObjectForKey:", aKey);
		}

		public void setObjectForKey(NSObject anObject, NSObject aKey)
		{
			Unused.Value = Call("setObject:forKey:", anObject, aKey);
		}

		private static Class ms_class = new Class("NSMutableDictionary");
	}

	public static class NSExtendedMutableDictionaryForNSMutableDictionaryCategory
	{
		public static void addEntriesFromDictionary(this NSMutableDictionary _instance, NSDictionary otherDictionary)
		{
			Unused.Value = _instance.Call("addEntriesFromDictionary:", otherDictionary);
		}

		public static void removeAllObjects(this NSMutableDictionary _instance)
		{
			Unused.Value = _instance.Call("removeAllObjects");
		}

		public static void removeObjectsForKeys(this NSMutableDictionary _instance, NSArray keyArray)
		{
			Unused.Value = _instance.Call("removeObjectsForKeys:", keyArray);
		}

		public static void setDictionary(this NSMutableDictionary _instance, NSDictionary otherDictionary)
		{
			Unused.Value = _instance.Call("setDictionary:", otherDictionary);
		}
	}

	public static class NSMutableDictionaryCreationForNSMutableDictionaryCategory
	{
		public static NSObject dictionaryWithCapacity(this NSMutableDictionary _instance, UInt32 numItems)
		{
			return _instance.Call("dictionaryWithCapacity:", numItems).To<NSObject>();
		}

		public static NSObject initWithCapacity(this NSMutableDictionary _instance, UInt32 numItems)
		{
			return _instance.Call("initWithCapacity:", numItems).To<NSObject>();
		}
	}
}
