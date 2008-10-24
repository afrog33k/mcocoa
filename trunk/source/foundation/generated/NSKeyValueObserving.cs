// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSKeyValueObserving.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSKeyValueObservingOptionNew = 0x01;
		public const int NSKeyValueObservingOptionOld = 0x02;
		public const int NSKeyValueObservingOptionInitial = 0x04;
		public const int NSKeyValueObservingOptionPrior = 0x08;
	}

	public partial class Enums
	{
		public const int NSKeyValueChangeSetting = 1;
		public const int NSKeyValueChangeInsertion = 2;
		public const int NSKeyValueChangeRemoval = 3;
		public const int NSKeyValueChangeReplacement = 4;
	}

	public partial class Enums
	{
		public const int NSKeyValueUnionSetMutation = 1;
		public const int NSKeyValueMinusSetMutation = 2;
		public const int NSKeyValueIntersectSetMutation = 3;
		public const int NSKeyValueSetSetMutation = 4;
	}

	public static class NSKeyValueObservingForNSObjectCategory
	{
		public static void observeValueForKeyPathOfObjectChangeContext(this NSObject _instance, NSString keyPath, NSObject object_, NSDictionary change, IntPtr context)
		{
			Unused.Value = _instance.Call("observeValueForKeyPath:ofObject:change:context:", keyPath, object_, change, context);
		}
	}

	public static class NSKeyValueObserverRegistrationForNSObjectCategory
	{
		public static void addObserverForKeyPathOptionsContext(this NSObject _instance, NSObject observer, NSString keyPath, UInt32 options, IntPtr context)
		{
			Unused.Value = _instance.Call("addObserver:forKeyPath:options:context:", observer, keyPath, options, context);
		}

		public static void removeObserverForKeyPath(this NSObject _instance, NSObject observer, NSString keyPath)
		{
			Unused.Value = _instance.Call("removeObserver:forKeyPath:", observer, keyPath);
		}
	}

	public static class NSKeyValueObserverRegistrationForNSArrayCategory
	{
		public static void addObserverToObjectsAtIndexesForKeyPathOptionsContext(this NSArray _instance, NSObject observer, NSIndexSet indexes, NSString keyPath, UInt32 options, IntPtr context)
		{
			Unused.Value = _instance.Call("addObserver:toObjectsAtIndexes:forKeyPath:options:context:", observer, indexes, keyPath, options, context);
		}

		public static void removeObserverFromObjectsAtIndexesForKeyPath(this NSArray _instance, NSObject observer, NSIndexSet indexes, NSString keyPath)
		{
			Unused.Value = _instance.Call("removeObserver:fromObjectsAtIndexes:forKeyPath:", observer, indexes, keyPath);
		}

		public static void addObserverForKeyPathOptionsContext(this NSArray _instance, NSObject observer, NSString keyPath, UInt32 options, IntPtr context)
		{
			Unused.Value = _instance.Call("addObserver:forKeyPath:options:context:", observer, keyPath, options, context);
		}

		public static void removeObserverForKeyPath(this NSArray _instance, NSObject observer, NSString keyPath)
		{
			Unused.Value = _instance.Call("removeObserver:forKeyPath:", observer, keyPath);
		}
	}

	public static class NSKeyValueObserverRegistrationForNSSetCategory
	{
		public static void addObserverForKeyPathOptionsContext(this NSSet _instance, NSObject observer, NSString keyPath, UInt32 options, IntPtr context)
		{
			Unused.Value = _instance.Call("addObserver:forKeyPath:options:context:", observer, keyPath, options, context);
		}

		public static void removeObserverForKeyPath(this NSSet _instance, NSObject observer, NSString keyPath)
		{
			Unused.Value = _instance.Call("removeObserver:forKeyPath:", observer, keyPath);
		}
	}

	public static class NSKeyValueObserverNotificationForNSObjectCategory
	{
		public static void willChangeValueForKey(this NSObject _instance, NSString key)
		{
			Unused.Value = _instance.Call("willChangeValueForKey:", key);
		}

		public static void didChangeValueForKey(this NSObject _instance, NSString key)
		{
			Unused.Value = _instance.Call("didChangeValueForKey:", key);
		}

		public static void willChangeValuesAtIndexesForKey(this NSObject _instance, UInt32 changeKind, NSIndexSet indexes, NSString key)
		{
			Unused.Value = _instance.Call("willChange:valuesAtIndexes:forKey:", changeKind, indexes, key);
		}

		public static void didChangeValuesAtIndexesForKey(this NSObject _instance, UInt32 changeKind, NSIndexSet indexes, NSString key)
		{
			Unused.Value = _instance.Call("didChange:valuesAtIndexes:forKey:", changeKind, indexes, key);
		}

		public static void willChangeValueForKeyWithSetMutationUsingObjects(this NSObject _instance, NSString key, UInt32 mutationKind, NSSet objects)
		{
			Unused.Value = _instance.Call("willChangeValueForKey:withSetMutation:usingObjects:", key, mutationKind, objects);
		}

		public static void didChangeValueForKeyWithSetMutationUsingObjects(this NSObject _instance, NSString key, UInt32 mutationKind, NSSet objects)
		{
			Unused.Value = _instance.Call("didChangeValueForKey:withSetMutation:usingObjects:", key, mutationKind, objects);
		}
	}

	public static class NSKeyValueObservingCustomizationForNSObjectCategory
	{
		public static NSSet keyPathsForValuesAffectingValueForKey(this NSObject _instance, NSString key)
		{
			return _instance.Call("keyPathsForValuesAffectingValueForKey:", key).To<NSSet>();
		}

		public static bool automaticallyNotifiesObserversForKey(this NSObject _instance, NSString key)
		{
			return _instance.Call("automaticallyNotifiesObserversForKey:", key).To<bool>();
		}

		public static void setObservationInfo(this NSObject _instance, IntPtr observationInfo)
		{
			Unused.Value = _instance.Call("setObservationInfo:", observationInfo);
		}

		public static IntPtr observationInfo(this NSObject _instance)
		{
			return _instance.Call("observationInfo").To<IntPtr>();
		}
	}

	public static class NSDeprecatedKeyValueObservingCustomizationForNSObjectCategory
	{
		public static void setKeysTriggerChangeNotificationsForDependentKey(this NSObject _instance, NSArray keys, NSString dependentKey)
		{
			Unused.Value = _instance.Call("setKeys:triggerChangeNotificationsForDependentKey:", keys, dependentKey);
		}
	}
}
