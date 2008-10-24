// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSCompoundPredicate.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNotPredicateType = 0;
		public const int NSAndPredicateType = 1;
		public const int NSOrPredicateType = 2;
	}

	[Register]
	public partial class NSCompoundPredicate : NSPredicate
	{
		public NSCompoundPredicate() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCompoundPredicate(IntPtr instance) : base(instance)
		{
		}

		public NSCompoundPredicate(Untyped instance) : base(instance)
		{
		}

		public static new NSCompoundPredicate alloc()
		{
			return new NSCompoundPredicate(ms_class.Call("alloc"));
		}

		public new NSCompoundPredicate retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithTypeSubpredicates(UInt32 type, NSArray subpredicates)
		{
			return Call("initWithType:subpredicates:", type, subpredicates).To<NSObject>();
		}

		public UInt32 compoundPredicateType()
		{
			return Call("compoundPredicateType").To<UInt32>();
		}

		public NSArray subpredicates()
		{
			return Call("subpredicates").To<NSArray>();
		}

		public static NSPredicate andPredicateWithSubpredicates(NSArray subpredicates)
		{
			return ms_class.Call("andPredicateWithSubpredicates:", subpredicates).To<NSPredicate>();
		}

		public static NSPredicate orPredicateWithSubpredicates(NSArray subpredicates)
		{
			return ms_class.Call("orPredicateWithSubpredicates:", subpredicates).To<NSPredicate>();
		}

		public static NSPredicate notPredicateWithSubpredicate(NSPredicate predicate)
		{
			return ms_class.Call("notPredicateWithSubpredicate:", predicate).To<NSPredicate>();
		}

		private static Class ms_class = new Class("NSCompoundPredicate");
	}
}
