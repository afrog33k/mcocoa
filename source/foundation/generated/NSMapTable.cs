// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSMapTable.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSMapTableStrongMemory = 0;
		public const int NSMapTableZeroingWeakMemory = NSPointerFunctionsZeroingWeakMemory;
		public const int NSMapTableCopyIn = NSPointerFunctionsCopyIn;
		public const int NSMapTableObjectPointerPersonality = NSPointerFunctionsObjectPointerPersonality;
	}

	[Register]
	public partial class NSMapTable : NSObject
	{
		public NSMapTable() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMapTable(IntPtr instance) : base(instance)
		{
		}

		public NSMapTable(Untyped instance) : base(instance)
		{
		}

		public static new NSMapTable alloc()
		{
			return new NSMapTable(ms_class.Call("alloc"));
		}

		public new NSMapTable retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithKeyOptionsValueOptionsCapacity(UInt32 keyOptions, UInt32 valueOptions, UInt32 initialCapacity)
		{
			return Call("initWithKeyOptions:valueOptions:capacity:", keyOptions, valueOptions, initialCapacity).To<NSObject>();
		}

		public NSObject initWithKeyPointerFunctionsValuePointerFunctionsCapacity(NSPointerFunctions keyFunctions, NSPointerFunctions valueFunctions, UInt32 initialCapacity)
		{
			return Call("initWithKeyPointerFunctions:valuePointerFunctions:capacity:", keyFunctions, valueFunctions, initialCapacity).To<NSObject>();
		}

		public static NSObject mapTableWithKeyOptionsValueOptions(UInt32 keyOptions, UInt32 valueOptions)
		{
			return ms_class.Call("mapTableWithKeyOptions:valueOptions:", keyOptions, valueOptions).To<NSObject>();
		}

		public static NSObject mapTableWithStrongToStrongObjects()
		{
			return ms_class.Call("mapTableWithStrongToStrongObjects").To<NSObject>();
		}

		public static NSObject mapTableWithWeakToStrongObjects()
		{
			return ms_class.Call("mapTableWithWeakToStrongObjects").To<NSObject>();
		}

		public static NSObject mapTableWithStrongToWeakObjects()
		{
			return ms_class.Call("mapTableWithStrongToWeakObjects").To<NSObject>();
		}

		public static NSObject mapTableWithWeakToWeakObjects()
		{
			return ms_class.Call("mapTableWithWeakToWeakObjects").To<NSObject>();
		}

		public NSPointerFunctions keyPointerFunctions()
		{
			return Call("keyPointerFunctions").To<NSPointerFunctions>();
		}

		public NSPointerFunctions valuePointerFunctions()
		{
			return Call("valuePointerFunctions").To<NSPointerFunctions>();
		}

		public NSObject objectForKey(NSObject aKey)
		{
			return Call("objectForKey:", aKey).To<NSObject>();
		}

		public void removeObjectForKey(NSObject aKey)
		{
			Unused.Value = Call("removeObjectForKey:", aKey);
		}

		public void setObjectForKey(NSObject anObject, NSObject aKey)
		{
			Unused.Value = Call("setObject:forKey:", anObject, aKey);
		}

		public UInt32 count()
		{
			return Call("count").To<UInt32>();
		}

		public NSEnumerator keyEnumerator()
		{
			return Call("keyEnumerator").To<NSEnumerator>();
		}

		public NSEnumerator objectEnumerator()
		{
			return Call("objectEnumerator").To<NSEnumerator>();
		}

		public void removeAllObjects()
		{
			Unused.Value = Call("removeAllObjects");
		}

		public NSDictionary dictionaryRepresentation()
		{
			return Call("dictionaryRepresentation").To<NSDictionary>();
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

		private static Class ms_class = new Class("NSMapTable");
	}
}
