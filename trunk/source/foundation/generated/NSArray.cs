// machine generated on 10/24/2008 3:54:03 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSArray.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSArray : NSObject
	{
		public NSArray() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSArray(IntPtr instance) : base(instance)
		{
		}

		public NSArray(Untyped instance) : base(instance)
		{
		}

		public static new NSArray alloc()
		{
			return new NSArray(ms_class.Call("alloc"));
		}

		public new NSArray retain()
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

		public NSObject objectAtIndex(UInt32 index)
		{
			return Call("objectAtIndex:", index).To<NSObject>();
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

		private static Class ms_class = new Class("NSArray");
	}

	public static class NSExtendedArrayForNSArrayCategory
	{
		public static NSArray arrayByAddingObject(this NSArray _instance, NSObject anObject)
		{
			return _instance.Call("arrayByAddingObject:", anObject).To<NSArray>();
		}

		public static NSArray arrayByAddingObjectsFromArray(this NSArray _instance, NSArray otherArray)
		{
			return _instance.Call("arrayByAddingObjectsFromArray:", otherArray).To<NSArray>();
		}

		public static NSString componentsJoinedByString(this NSArray _instance, NSString separator)
		{
			return _instance.Call("componentsJoinedByString:", separator).To<NSString>();
		}

		public static bool containsObject(this NSArray _instance, NSObject anObject)
		{
			return _instance.Call("containsObject:", anObject).To<bool>();
		}

		// skipping description (it's already defined)

		public static NSString descriptionWithLocale(this NSArray _instance, NSObject locale)
		{
			return _instance.Call("descriptionWithLocale:", locale).To<NSString>();
		}

		public static NSString descriptionWithLocaleIndent(this NSArray _instance, NSObject locale, UInt32 level)
		{
			return _instance.Call("descriptionWithLocale:indent:", locale, level).To<NSString>();
		}

		public static NSObject firstObjectCommonWithArray(this NSArray _instance, NSArray otherArray)
		{
			return _instance.Call("firstObjectCommonWithArray:", otherArray).To<NSObject>();
		}

		public static void getObjects(this NSArray _instance, IntPtr objects)
		{
			Unused.Value = _instance.Call("getObjects:", objects);
		}

		public static void getObjectsRange(this NSArray _instance, IntPtr objects, NSRange range)
		{
			Unused.Value = _instance.Call("getObjects:range:", objects, range);
		}

		public static UInt32 indexOfObject(this NSArray _instance, NSObject anObject)
		{
			return _instance.Call("indexOfObject:", anObject).To<UInt32>();
		}

		public static UInt32 indexOfObjectInRange(this NSArray _instance, NSObject anObject, NSRange range)
		{
			return _instance.Call("indexOfObject:inRange:", anObject, range).To<UInt32>();
		}

		public static UInt32 indexOfObjectIdenticalTo(this NSArray _instance, NSObject anObject)
		{
			return _instance.Call("indexOfObjectIdenticalTo:", anObject).To<UInt32>();
		}

		public static UInt32 indexOfObjectIdenticalToInRange(this NSArray _instance, NSObject anObject, NSRange range)
		{
			return _instance.Call("indexOfObjectIdenticalTo:inRange:", anObject, range).To<UInt32>();
		}

		public static bool isEqualToArray(this NSArray _instance, NSArray otherArray)
		{
			return _instance.Call("isEqualToArray:", otherArray).To<bool>();
		}

		public static NSObject lastObject(this NSArray _instance)
		{
			return _instance.Call("lastObject").To<NSObject>();
		}

		public static NSEnumerator objectEnumerator(this NSArray _instance)
		{
			return _instance.Call("objectEnumerator").To<NSEnumerator>();
		}

		public static NSEnumerator reverseObjectEnumerator(this NSArray _instance)
		{
			return _instance.Call("reverseObjectEnumerator").To<NSEnumerator>();
		}

		public static NSData sortedArrayHint(this NSArray _instance)
		{
			return _instance.Call("sortedArrayHint").To<NSData>();
		}

		// skipping sortedArrayUsingFunction:context: because it has a function pointer

		// skipping sortedArrayUsingFunction:context:hint: because it has a function pointer

		public static NSArray sortedArrayUsingSelector(this NSArray _instance, Selector comparator)
		{
			return _instance.Call("sortedArrayUsingSelector:", comparator).To<NSArray>();
		}

		public static NSArray subarrayWithRange(this NSArray _instance, NSRange range)
		{
			return _instance.Call("subarrayWithRange:", range).To<NSArray>();
		}

		public static bool writeToFileAtomically(this NSArray _instance, NSString path, bool useAuxiliaryFile)
		{
			return _instance.Call("writeToFile:atomically:", path, useAuxiliaryFile).To<bool>();
		}

		public static bool writeToURLAtomically(this NSArray _instance, NSURL url, bool atomically)
		{
			return _instance.Call("writeToURL:atomically:", url, atomically).To<bool>();
		}

		public static void makeObjectsPerformSelector(this NSArray _instance, Selector aSelector)
		{
			Unused.Value = _instance.Call("makeObjectsPerformSelector:", aSelector);
		}

		public static void makeObjectsPerformSelectorWithObject(this NSArray _instance, Selector aSelector, NSObject argument)
		{
			Unused.Value = _instance.Call("makeObjectsPerformSelector:withObject:", aSelector, argument);
		}

		public static NSArray objectsAtIndexes(this NSArray _instance, NSIndexSet indexes)
		{
			return _instance.Call("objectsAtIndexes:", indexes).To<NSArray>();
		}
	}

	public static class NSArrayCreationForNSArrayCategory
	{
		public static NSObject array(this NSArray _instance)
		{
			return _instance.Call("array").To<NSObject>();
		}

		public static NSObject arrayWithObject(this NSArray _instance, NSObject anObject)
		{
			return _instance.Call("arrayWithObject:", anObject).To<NSObject>();
		}

		public static NSObject arrayWithObjectsCount(this NSArray _instance, IntPtr objects, UInt32 cnt)
		{
			return _instance.Call("arrayWithObjects:count:", objects, cnt).To<NSObject>();
		}

		// skipping arrayWithObjects: because it is variadic

		public static NSObject arrayWithArray(this NSArray _instance, NSArray array)
		{
			return _instance.Call("arrayWithArray:", array).To<NSObject>();
		}

		public static NSObject initWithObjectsCount(this NSArray _instance, IntPtr objects, UInt32 cnt)
		{
			return _instance.Call("initWithObjects:count:", objects, cnt).To<NSObject>();
		}

		// skipping initWithObjects: because it is variadic

		public static NSObject initWithArray(this NSArray _instance, NSArray array)
		{
			return _instance.Call("initWithArray:", array).To<NSObject>();
		}

		public static NSObject initWithArrayCopyItemsAVAILABLE_MAC_OS_X_VERSION_10_2_AND_LATER(this NSArray _instance, NSArray array, bool flag)
		{
			return _instance.Call("initWithArray:copyItems:AVAILABLE_MAC_OS_X_VERSION_10_2_AND_LATER", array, flag).To<NSObject>();
		}

		public static NSObject arrayWithContentsOfFile(this NSArray _instance, NSString path)
		{
			return _instance.Call("arrayWithContentsOfFile:", path).To<NSObject>();
		}

		public static NSObject arrayWithContentsOfURL(this NSArray _instance, NSURL url)
		{
			return _instance.Call("arrayWithContentsOfURL:", url).To<NSObject>();
		}

		public static NSObject initWithContentsOfFile(this NSArray _instance, NSString path)
		{
			return _instance.Call("initWithContentsOfFile:", path).To<NSObject>();
		}

		public static NSObject initWithContentsOfURL(this NSArray _instance, NSURL url)
		{
			return _instance.Call("initWithContentsOfURL:", url).To<NSObject>();
		}
	}

	[Register]
	public partial class NSMutableArray : NSArray
	{
		public NSMutableArray() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableArray(IntPtr instance) : base(instance)
		{
		}

		public NSMutableArray(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableArray alloc()
		{
			return new NSMutableArray(ms_class.Call("alloc"));
		}

		public new NSMutableArray retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void addObject(NSObject anObject)
		{
			Unused.Value = Call("addObject:", anObject);
		}

		public void insertObjectAtIndex(NSObject anObject, UInt32 index)
		{
			Unused.Value = Call("insertObject:atIndex:", anObject, index);
		}

		public void removeLastObject()
		{
			Unused.Value = Call("removeLastObject");
		}

		public void removeObjectAtIndex(UInt32 index)
		{
			Unused.Value = Call("removeObjectAtIndex:", index);
		}

		public void replaceObjectAtIndexWithObject(UInt32 index, NSObject anObject)
		{
			Unused.Value = Call("replaceObjectAtIndex:withObject:", index, anObject);
		}

		private static Class ms_class = new Class("NSMutableArray");
	}

	public static class NSExtendedMutableArrayForNSMutableArrayCategory
	{
		public static void addObjectsFromArray(this NSMutableArray _instance, NSArray otherArray)
		{
			Unused.Value = _instance.Call("addObjectsFromArray:", otherArray);
		}

		public static void exchangeObjectAtIndexWithObjectAtIndex(this NSMutableArray _instance, UInt32 idx1, UInt32 idx2)
		{
			Unused.Value = _instance.Call("exchangeObjectAtIndex:withObjectAtIndex:", idx1, idx2);
		}

		public static void removeAllObjects(this NSMutableArray _instance)
		{
			Unused.Value = _instance.Call("removeAllObjects");
		}

		public static void removeObjectInRange(this NSMutableArray _instance, NSObject anObject, NSRange range)
		{
			Unused.Value = _instance.Call("removeObject:inRange:", anObject, range);
		}

		public static void removeObject(this NSMutableArray _instance, NSObject anObject)
		{
			Unused.Value = _instance.Call("removeObject:", anObject);
		}

		public static void removeObjectIdenticalToInRange(this NSMutableArray _instance, NSObject anObject, NSRange range)
		{
			Unused.Value = _instance.Call("removeObjectIdenticalTo:inRange:", anObject, range);
		}

		public static void removeObjectIdenticalTo(this NSMutableArray _instance, NSObject anObject)
		{
			Unused.Value = _instance.Call("removeObjectIdenticalTo:", anObject);
		}

		public static void removeObjectsFromIndicesNumIndices(this NSMutableArray _instance, IntPtr indices, UInt32 cnt)
		{
			Unused.Value = _instance.Call("removeObjectsFromIndices:numIndices:", indices, cnt);
		}

		public static void removeObjectsInArray(this NSMutableArray _instance, NSArray otherArray)
		{
			Unused.Value = _instance.Call("removeObjectsInArray:", otherArray);
		}

		public static void removeObjectsInRange(this NSMutableArray _instance, NSRange range)
		{
			Unused.Value = _instance.Call("removeObjectsInRange:", range);
		}

		public static void replaceObjectsInRangeWithObjectsFromArrayRange(this NSMutableArray _instance, NSRange range, NSArray otherArray, NSRange otherRange)
		{
			Unused.Value = _instance.Call("replaceObjectsInRange:withObjectsFromArray:range:", range, otherArray, otherRange);
		}

		public static void replaceObjectsInRangeWithObjectsFromArray(this NSMutableArray _instance, NSRange range, NSArray otherArray)
		{
			Unused.Value = _instance.Call("replaceObjectsInRange:withObjectsFromArray:", range, otherArray);
		}

		public static void setArray(this NSMutableArray _instance, NSArray otherArray)
		{
			Unused.Value = _instance.Call("setArray:", otherArray);
		}

		// skipping sortUsingFunction:context: because it has a function pointer

		public static void sortUsingSelector(this NSMutableArray _instance, Selector comparator)
		{
			Unused.Value = _instance.Call("sortUsingSelector:", comparator);
		}

		public static void insertObjectsAtIndexes(this NSMutableArray _instance, NSArray objects, NSIndexSet indexes)
		{
			Unused.Value = _instance.Call("insertObjects:atIndexes:", objects, indexes);
		}

		public static void removeObjectsAtIndexes(this NSMutableArray _instance, NSIndexSet indexes)
		{
			Unused.Value = _instance.Call("removeObjectsAtIndexes:", indexes);
		}

		public static void replaceObjectsAtIndexesWithObjects(this NSMutableArray _instance, NSIndexSet indexes, NSArray objects)
		{
			Unused.Value = _instance.Call("replaceObjectsAtIndexes:withObjects:", indexes, objects);
		}
	}

	public static class NSMutableArrayCreationForNSMutableArrayCategory
	{
		public static NSObject arrayWithCapacity(this NSMutableArray _instance, UInt32 numItems)
		{
			return _instance.Call("arrayWithCapacity:", numItems).To<NSObject>();
		}

		public static NSObject initWithCapacity(this NSMutableArray _instance, UInt32 numItems)
		{
			return _instance.Call("initWithCapacity:", numItems).To<NSObject>();
		}
	}
}
