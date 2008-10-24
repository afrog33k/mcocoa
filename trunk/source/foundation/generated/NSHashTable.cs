// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSHashTable.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSHashTableStrongMemory = 0;
		public const int NSHashTableZeroingWeakMemory = NSPointerFunctionsZeroingWeakMemory;
		public const int NSHashTableCopyIn = NSPointerFunctionsCopyIn;
		public const int NSHashTableObjectPointerPersonality = NSPointerFunctionsObjectPointerPersonality;
	}

	[Register]
	public partial class NSHashTable : NSObject
	{
		public NSHashTable() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSHashTable(IntPtr instance) : base(instance)
		{
		}

		public NSHashTable(Untyped instance) : base(instance)
		{
		}

		public static new NSHashTable alloc()
		{
			return new NSHashTable(ms_class.Call("alloc"));
		}

		public new NSHashTable retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithOptionsCapacity(UInt32 options, UInt32 initialCapacity)
		{
			return Call("initWithOptions:capacity:", options, initialCapacity).To<NSObject>();
		}

		public NSObject initWithPointerFunctionsCapacity(NSPointerFunctions functions, UInt32 initialCapacity)
		{
			return Call("initWithPointerFunctions:capacity:", functions, initialCapacity).To<NSObject>();
		}

		public static NSObject hashTableWithOptions(UInt32 options)
		{
			return ms_class.Call("hashTableWithOptions:", options).To<NSObject>();
		}

		public static NSObject hashTableWithWeakObjects()
		{
			return ms_class.Call("hashTableWithWeakObjects").To<NSObject>();
		}

		public NSPointerFunctions pointerFunctions()
		{
			return Call("pointerFunctions").To<NSPointerFunctions>();
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

		public void addObject(NSObject object_)
		{
			Unused.Value = Call("addObject:", object_);
		}

		public void removeObject(NSObject object_)
		{
			Unused.Value = Call("removeObject:", object_);
		}

		public void removeAllObjects()
		{
			Unused.Value = Call("removeAllObjects");
		}

		public NSArray allObjects()
		{
			return Call("allObjects").To<NSArray>();
		}

		public NSObject anyObject()
		{
			return Call("anyObject").To<NSObject>();
		}

		public bool containsObject(NSObject anObject)
		{
			return Call("containsObject:", anObject).To<bool>();
		}

		public bool intersectsHashTable(NSHashTable other)
		{
			return Call("intersectsHashTable:", other).To<bool>();
		}

		public bool isEqualToHashTable(NSHashTable other)
		{
			return Call("isEqualToHashTable:", other).To<bool>();
		}

		public bool isSubsetOfHashTable(NSHashTable other)
		{
			return Call("isSubsetOfHashTable:", other).To<bool>();
		}

		public void intersectHashTable(NSHashTable other)
		{
			Unused.Value = Call("intersectHashTable:", other);
		}

		public void unionHashTable(NSHashTable other)
		{
			Unused.Value = Call("unionHashTable:", other);
		}

		public void minusHashTable(NSHashTable other)
		{
			Unused.Value = Call("minusHashTable:", other);
		}

		public NSSet setRepresentation()
		{
			return Call("setRepresentation").To<NSSet>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
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

		private static Class ms_class = new Class("NSHashTable");
	}
}
