// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSEnumerator.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSEnumerator : NSObject
	{
		public NSEnumerator() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSEnumerator(IntPtr instance) : base(instance)
		{
		}

		public NSEnumerator(Untyped instance) : base(instance)
		{
		}

		public static new NSEnumerator alloc()
		{
			return new NSEnumerator(ms_class.Call("alloc"));
		}

		public new NSEnumerator retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject nextObject()
		{
			return Call("nextObject").To<NSObject>();
		}

		#region NSFastEnumeration Methods
		public UInt32 countByEnumeratingWithStateObjectsCount(NSFastEnumerationState state, IntPtr stackbuf, UInt32 len)
		{
			return Call("countByEnumeratingWithState:objects:count:", state, stackbuf, len).To<UInt32>();
		}
		#endregion

		private static Class ms_class = new Class("NSEnumerator");
	}

	public static class NSExtendedEnumeratorForNSEnumeratorCategory
	{
		public static NSArray allObjects(this NSEnumerator _instance)
		{
			return _instance.Call("allObjects").To<NSArray>();
		}
	}
}
