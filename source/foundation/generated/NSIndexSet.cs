// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSIndexSet.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSIndexSet : NSObject
	{
		public NSIndexSet() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSIndexSet(IntPtr instance) : base(instance)
		{
		}

		public NSIndexSet(Untyped instance) : base(instance)
		{
		}

		public static new NSIndexSet alloc()
		{
			return new NSIndexSet(ms_class.Call("alloc"));
		}

		public new NSIndexSet retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject indexSet()
		{
			return ms_class.Call("indexSet").To<NSObject>();
		}

		public static NSObject indexSetWithIndex(UInt32 value)
		{
			return ms_class.Call("indexSetWithIndex:", value).To<NSObject>();
		}

		public static NSObject indexSetWithIndexesInRange(NSRange range)
		{
			return ms_class.Call("indexSetWithIndexesInRange:", range).To<NSObject>();
		}

		// skipping init (it's already defined)

		public NSObject initWithIndex(UInt32 value)
		{
			return Call("initWithIndex:", value).To<NSObject>();
		}

		public NSObject initWithIndexesInRange(NSRange range)
		{
			return Call("initWithIndexesInRange:", range).To<NSObject>();
		}

		public NSObject initWithIndexSet(NSIndexSet indexSet)
		{
			return Call("initWithIndexSet:", indexSet).To<NSObject>();
		}

		public bool isEqualToIndexSet(NSIndexSet indexSet)
		{
			return Call("isEqualToIndexSet:", indexSet).To<bool>();
		}

		public UInt32 count()
		{
			return Call("count").To<UInt32>();
		}

		public UInt32 firstIndex()
		{
			return Call("firstIndex").To<UInt32>();
		}

		public UInt32 lastIndex()
		{
			return Call("lastIndex").To<UInt32>();
		}

		public UInt32 indexGreaterThanIndex(UInt32 value)
		{
			return Call("indexGreaterThanIndex:", value).To<UInt32>();
		}

		public UInt32 indexLessThanIndex(UInt32 value)
		{
			return Call("indexLessThanIndex:", value).To<UInt32>();
		}

		public UInt32 indexGreaterThanOrEqualToIndex(UInt32 value)
		{
			return Call("indexGreaterThanOrEqualToIndex:", value).To<UInt32>();
		}

		public UInt32 indexLessThanOrEqualToIndex(UInt32 value)
		{
			return Call("indexLessThanOrEqualToIndex:", value).To<UInt32>();
		}

		public UInt32 getIndexesMaxCountInIndexRange(IntPtr indexBuffer, UInt32 bufferSize, IntPtr range)
		{
			return Call("getIndexes:maxCount:inIndexRange:", indexBuffer, bufferSize, range).To<UInt32>();
		}

		public UInt32 countOfIndexesInRange(NSRange range)
		{
			return Call("countOfIndexesInRange:", range).To<UInt32>();
		}

		public bool containsIndex(UInt32 value)
		{
			return Call("containsIndex:", value).To<bool>();
		}

		public bool containsIndexesInRange(NSRange range)
		{
			return Call("containsIndexesInRange:", range).To<bool>();
		}

		public bool containsIndexes(NSIndexSet indexSet)
		{
			return Call("containsIndexes:", indexSet).To<bool>();
		}

		public bool intersectsIndexesInRange(NSRange range)
		{
			return Call("intersectsIndexesInRange:", range).To<bool>();
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

		private static Class ms_class = new Class("NSIndexSet");
	}

	[Register]
	public partial class NSMutableIndexSet : NSIndexSet
	{
		public NSMutableIndexSet() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableIndexSet(IntPtr instance) : base(instance)
		{
		}

		public NSMutableIndexSet(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableIndexSet alloc()
		{
			return new NSMutableIndexSet(ms_class.Call("alloc"));
		}

		public new NSMutableIndexSet retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void addIndexes(NSIndexSet indexSet)
		{
			Unused.Value = Call("addIndexes:", indexSet);
		}

		public void removeIndexes(NSIndexSet indexSet)
		{
			Unused.Value = Call("removeIndexes:", indexSet);
		}

		public void removeAllIndexes()
		{
			Unused.Value = Call("removeAllIndexes");
		}

		public void addIndex(UInt32 value)
		{
			Unused.Value = Call("addIndex:", value);
		}

		public void removeIndex(UInt32 value)
		{
			Unused.Value = Call("removeIndex:", value);
		}

		public void addIndexesInRange(NSRange range)
		{
			Unused.Value = Call("addIndexesInRange:", range);
		}

		public void removeIndexesInRange(NSRange range)
		{
			Unused.Value = Call("removeIndexesInRange:", range);
		}

		public void shiftIndexesStartingAtIndexBy(UInt32 index, Int32 delta)
		{
			Unused.Value = Call("shiftIndexesStartingAtIndex:by:", index, delta);
		}

		private static Class ms_class = new Class("NSMutableIndexSet");
	}
}
