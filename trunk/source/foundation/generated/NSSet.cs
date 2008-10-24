// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSSet.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSet : NSObject
	{
		public NSSet() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSet(IntPtr instance) : base(instance)
		{
		}

		public NSSet(Untyped instance) : base(instance)
		{
		}

		public static new NSSet alloc()
		{
			return new NSSet(ms_class.Call("alloc"));
		}

		public new NSSet retain()
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

		public NSObject member(NSObject object_)
		{
			return Call("member:", object_).To<NSObject>();
		}

		public NSEnumerator objectEnumerator()
		{
			return Call("objectEnumerator").To<NSEnumerator>();
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

		private static Class ms_class = new Class("NSSet");
	}

	public static class NSExtendedSetForNSSetCategory
	{
		public static NSArray allObjects(this NSSet _instance)
		{
			return _instance.Call("allObjects").To<NSArray>();
		}

		public static NSObject anyObject(this NSSet _instance)
		{
			return _instance.Call("anyObject").To<NSObject>();
		}

		public static bool containsObject(this NSSet _instance, NSObject anObject)
		{
			return _instance.Call("containsObject:", anObject).To<bool>();
		}

		// skipping description (it's already defined)

		public static NSString descriptionWithLocale(this NSSet _instance, NSObject locale)
		{
			return _instance.Call("descriptionWithLocale:", locale).To<NSString>();
		}

		public static bool intersectsSet(this NSSet _instance, NSSet otherSet)
		{
			return _instance.Call("intersectsSet:", otherSet).To<bool>();
		}

		public static bool isEqualToSet(this NSSet _instance, NSSet otherSet)
		{
			return _instance.Call("isEqualToSet:", otherSet).To<bool>();
		}

		public static bool isSubsetOfSet(this NSSet _instance, NSSet otherSet)
		{
			return _instance.Call("isSubsetOfSet:", otherSet).To<bool>();
		}

		public static void makeObjectsPerformSelector(this NSSet _instance, Selector aSelector)
		{
			Unused.Value = _instance.Call("makeObjectsPerformSelector:", aSelector);
		}

		public static void makeObjectsPerformSelectorWithObject(this NSSet _instance, Selector aSelector, NSObject argument)
		{
			Unused.Value = _instance.Call("makeObjectsPerformSelector:withObject:", aSelector, argument);
		}

		public static NSSet setByAddingObjectAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSSet _instance, NSObject anObject)
		{
			return _instance.Call("setByAddingObject:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", anObject).To<NSSet>();
		}

		public static NSSet setByAddingObjectsFromSetAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSSet _instance, NSSet other)
		{
			return _instance.Call("setByAddingObjectsFromSet:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", other).To<NSSet>();
		}

		public static NSSet setByAddingObjectsFromArrayAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(this NSSet _instance, NSArray other)
		{
			return _instance.Call("setByAddingObjectsFromArray:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", other).To<NSSet>();
		}
	}

	public static class NSSetCreationForNSSetCategory
	{
		public static NSObject set(this NSSet _instance)
		{
			return _instance.Call("set").To<NSObject>();
		}

		public static NSObject setWithObject(this NSSet _instance, NSObject object_)
		{
			return _instance.Call("setWithObject:", object_).To<NSObject>();
		}

		public static NSObject setWithObjectsCount(this NSSet _instance, IntPtr objects, UInt32 cnt)
		{
			return _instance.Call("setWithObjects:count:", objects, cnt).To<NSObject>();
		}

		// skipping setWithObjects: because it is variadic

		public static NSObject setWithSet(this NSSet _instance, NSSet set_)
		{
			return _instance.Call("setWithSet:", set_).To<NSObject>();
		}

		public static NSObject setWithArray(this NSSet _instance, NSArray array)
		{
			return _instance.Call("setWithArray:", array).To<NSObject>();
		}

		public static NSObject initWithObjectsCount(this NSSet _instance, IntPtr objects, UInt32 cnt)
		{
			return _instance.Call("initWithObjects:count:", objects, cnt).To<NSObject>();
		}

		// skipping initWithObjects: because it is variadic

		public static NSObject initWithSet(this NSSet _instance, NSSet set_)
		{
			return _instance.Call("initWithSet:", set_).To<NSObject>();
		}

		public static NSObject initWithSetCopyItems(this NSSet _instance, NSSet set_, bool flag)
		{
			return _instance.Call("initWithSet:copyItems:", set_, flag).To<NSObject>();
		}

		public static NSObject initWithArray(this NSSet _instance, NSArray array)
		{
			return _instance.Call("initWithArray:", array).To<NSObject>();
		}
	}

	[Register]
	public partial class NSMutableSet : NSSet
	{
		public NSMutableSet() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableSet(IntPtr instance) : base(instance)
		{
		}

		public NSMutableSet(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableSet alloc()
		{
			return new NSMutableSet(ms_class.Call("alloc"));
		}

		public new NSMutableSet retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void addObject(NSObject object_)
		{
			Unused.Value = Call("addObject:", object_);
		}

		public void removeObject(NSObject object_)
		{
			Unused.Value = Call("removeObject:", object_);
		}

		private static Class ms_class = new Class("NSMutableSet");
	}

	public static class NSExtendedMutableSetForNSMutableSetCategory
	{
		public static void addObjectsFromArray(this NSMutableSet _instance, NSArray array)
		{
			Unused.Value = _instance.Call("addObjectsFromArray:", array);
		}

		public static void intersectSet(this NSMutableSet _instance, NSSet otherSet)
		{
			Unused.Value = _instance.Call("intersectSet:", otherSet);
		}

		public static void minusSet(this NSMutableSet _instance, NSSet otherSet)
		{
			Unused.Value = _instance.Call("minusSet:", otherSet);
		}

		public static void removeAllObjects(this NSMutableSet _instance)
		{
			Unused.Value = _instance.Call("removeAllObjects");
		}

		public static void unionSet(this NSMutableSet _instance, NSSet otherSet)
		{
			Unused.Value = _instance.Call("unionSet:", otherSet);
		}

		public static void setSet(this NSMutableSet _instance, NSSet otherSet)
		{
			Unused.Value = _instance.Call("setSet:", otherSet);
		}
	}

	public static class NSMutableSetCreationForNSMutableSetCategory
	{
		public static NSObject setWithCapacity(this NSMutableSet _instance, UInt32 numItems)
		{
			return _instance.Call("setWithCapacity:", numItems).To<NSObject>();
		}

		public static NSObject initWithCapacity(this NSMutableSet _instance, UInt32 numItems)
		{
			return _instance.Call("initWithCapacity:", numItems).To<NSObject>();
		}
	}

	[Register]
	public partial class NSCountedSet : NSMutableSet
	{
		public NSCountedSet() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCountedSet(IntPtr instance) : base(instance)
		{
		}

		public NSCountedSet(Untyped instance) : base(instance)
		{
		}

		public static new NSCountedSet alloc()
		{
			return new NSCountedSet(ms_class.Call("alloc"));
		}

		public new NSCountedSet retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithCapacity(UInt32 numItems)
		{
			return Call("initWithCapacity:", numItems).To<NSObject>();
		}

		public NSObject initWithArray(NSArray array)
		{
			return Call("initWithArray:", array).To<NSObject>();
		}

		public NSObject initWithSet(NSSet set_)
		{
			return Call("initWithSet:", set_).To<NSObject>();
		}

		public UInt32 countForObject(NSObject object_)
		{
			return Call("countForObject:", object_).To<UInt32>();
		}

		// skipping objectEnumerator (it's declared in a base class)

		// skipping addObject: (it's declared in a base class)

		// skipping removeObject: (it's declared in a base class)

		private static Class ms_class = new Class("NSCountedSet");
	}
}
