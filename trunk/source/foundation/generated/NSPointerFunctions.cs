// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPointerFunctions.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSPointerFunctionsStrongMemory = ( 0 << 0 );
		public const int NSPointerFunctionsZeroingWeakMemory = ( 1 << 0 );
		public const int NSPointerFunctionsOpaqueMemory = ( 2 << 0 );
		public const int NSPointerFunctionsMallocMemory = ( 3 << 0 );
		public const int NSPointerFunctionsMachVirtualMemory = ( 4 << 0 );
		public const int NSPointerFunctionsObjectPersonality = ( 0 << 8 );
		public const int NSPointerFunctionsOpaquePersonality = ( 1 << 8 );
		public const int NSPointerFunctionsObjectPointerPersonality = ( 2 << 8 );
		public const int NSPointerFunctionsCStringPersonality = ( 3 << 8 );
		public const int NSPointerFunctionsStructPersonality = ( 4 << 8 );
		public const int NSPointerFunctionsIntegerPersonality = ( 5 << 8 );
		public const int NSPointerFunctionsCopyIn = ( 1 << 16 );
	}

	[Register]
	public partial class NSPointerFunctions : NSObject
	{
		public NSPointerFunctions() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPointerFunctions(IntPtr instance) : base(instance)
		{
		}

		public NSPointerFunctions(Untyped instance) : base(instance)
		{
		}

		public static new NSPointerFunctions alloc()
		{
			return new NSPointerFunctions(ms_class.Call("alloc"));
		}

		public new NSPointerFunctions retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithOptions(UInt32 options)
		{
			return Call("initWithOptions:", options).To<NSObject>();
		}

		public static NSObject pointerFunctionsWithOptions(UInt32 options)
		{
			return ms_class.Call("pointerFunctionsWithOptions:", options).To<NSObject>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSPointerFunctions");
	}
}
