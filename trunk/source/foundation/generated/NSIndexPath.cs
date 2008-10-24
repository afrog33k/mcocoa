// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSIndexPath.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSIndexPath : NSObject
	{
		public NSIndexPath() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSIndexPath(IntPtr instance) : base(instance)
		{
		}

		public NSIndexPath(Untyped instance) : base(instance)
		{
		}

		public static new NSIndexPath alloc()
		{
			return new NSIndexPath(ms_class.Call("alloc"));
		}

		public new NSIndexPath retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject indexPathWithIndex(UInt32 index)
		{
			return ms_class.Call("indexPathWithIndex:", index).To<NSObject>();
		}

		public static NSObject indexPathWithIndexesLength(IntPtr indexes, UInt32 length)
		{
			return ms_class.Call("indexPathWithIndexes:length:", indexes, length).To<NSObject>();
		}

		public NSObject initWithIndex(UInt32 index)
		{
			return Call("initWithIndex:", index).To<NSObject>();
		}

		public NSObject initWithIndexesLength(IntPtr indexes, UInt32 length)
		{
			return Call("initWithIndexes:length:", indexes, length).To<NSObject>();
		}

		public NSIndexPath indexPathByAddingIndex(UInt32 index)
		{
			return Call("indexPathByAddingIndex:", index).To<NSIndexPath>();
		}

		public NSIndexPath indexPathByRemovingLastIndex()
		{
			return Call("indexPathByRemovingLastIndex").To<NSIndexPath>();
		}

		public UInt32 indexAtPosition(UInt32 position)
		{
			return Call("indexAtPosition:", position).To<UInt32>();
		}

		public UInt32 length()
		{
			return Call("length").To<UInt32>();
		}

		public void getIndexes(IntPtr indexes)
		{
			Unused.Value = Call("getIndexes:", indexes);
		}

		public Int32 compare(NSIndexPath otherObject)
		{
			return Call("compare:", otherObject).To<Int32>();
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

		private static Class ms_class = new Class("NSIndexPath");
	}
}
