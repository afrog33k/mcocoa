// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPointerArray.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPointerArray : NSObject
	{
		public NSPointerArray() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPointerArray(IntPtr instance) : base(instance)
		{
		}

		public NSPointerArray(Untyped instance) : base(instance)
		{
		}

		public static new NSPointerArray alloc()
		{
			return new NSPointerArray(ms_class.Call("alloc"));
		}

		public new NSPointerArray retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSPointerFunctions pointerFunctions()
		{
			return Call("pointerFunctions").To<NSPointerFunctions>();
		}

		public IntPtr pointerAtIndex(UInt32 index)
		{
			return Call("pointerAtIndex:", index).To<IntPtr>();
		}

		public void addPointer(IntPtr pointer)
		{
			Unused.Value = Call("addPointer:", pointer);
		}

		public void removePointerAtIndex(UInt32 index)
		{
			Unused.Value = Call("removePointerAtIndex:", index);
		}

		public void insertPointerAtIndex(IntPtr item, UInt32 index)
		{
			Unused.Value = Call("insertPointer:atIndex:", item, index);
		}

		public void replacePointerAtIndexWithPointer(UInt32 index, IntPtr item)
		{
			Unused.Value = Call("replacePointerAtIndex:withPointer:", index, item);
		}

		public void compact()
		{
			Unused.Value = Call("compact");
		}

		public UInt32 count()
		{
			return Call("count").To<UInt32>();
		}

		public void setCount(UInt32 count)
		{
			Unused.Value = Call("setCount:", count);
		}

		#region NSFastEnumeration Methods
		public UInt32 countByEnumeratingWithStateObjectsCount(NSFastEnumerationState state, IntPtr stackbuf, UInt32 len)
		{
			return Call("countByEnumeratingWithState:objects:count:", state, stackbuf, len).To<UInt32>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSPointerArray");
	}

	public static class NSArrayConveniencesForNSPointerArrayCategory
	{
		public static NSArray allObjects(this NSPointerArray _instance)
		{
			return _instance.Call("allObjects").To<NSArray>();
		}
	}
}
