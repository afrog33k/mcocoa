// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSSortDescriptor.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSortDescriptor : NSObject
	{
		public NSSortDescriptor() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSortDescriptor(IntPtr instance) : base(instance)
		{
		}

		public NSSortDescriptor(Untyped instance) : base(instance)
		{
		}

		public static new NSSortDescriptor alloc()
		{
			return new NSSortDescriptor(ms_class.Call("alloc"));
		}

		public new NSSortDescriptor retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithKeyAscending(NSString key, bool ascending_)
		{
			return Call("initWithKey:ascending:", key, ascending_).To<NSObject>();
		}

		public NSObject initWithKeyAscendingSelector(NSString key, bool ascending_, Selector selector)
		{
			return Call("initWithKey:ascending:selector:", key, ascending_, selector).To<NSObject>();
		}

		public NSString key()
		{
			return Call("key").To<NSString>();
		}

		public bool ascending()
		{
			return Call("ascending").To<bool>();
		}

		public Selector selector()
		{
			return Call("selector").To<Selector>();
		}

		public Int32 compareObjectToObject(NSObject object1, NSObject object2)
		{
			return Call("compareObject:toObject:", object1, object2).To<Int32>();
		}

		public NSObject reversedSortDescriptor()
		{
			return Call("reversedSortDescriptor").To<NSObject>();
		}

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

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSSortDescriptor");
	}

	public static class NSSortDescriptorSortingForNSArrayCategory
	{
		public static NSArray sortedArrayUsingDescriptors(this NSArray _instance, NSArray sortDescriptors)
		{
			return _instance.Call("sortedArrayUsingDescriptors:", sortDescriptors).To<NSArray>();
		}
	}

	public static class NSSortDescriptorSortingForNSMutableArrayCategory
	{
		public static void sortUsingDescriptors(this NSMutableArray _instance, NSArray sortDescriptors)
		{
			Unused.Value = _instance.Call("sortUsingDescriptors:", sortDescriptors);
		}
	}
}
