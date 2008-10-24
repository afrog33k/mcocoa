// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLHandle.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSURLHandleNotLoaded = 0;
		public const int NSURLHandleLoadSucceeded = 1;
		public const int NSURLHandleLoadInProgress = 2;
		public const int NSURLHandleLoadFailed = 3;
	}

	[Register]
	public partial class NSURLHandle : NSObject
	{
		public NSURLHandle() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLHandle(IntPtr instance) : base(instance)
		{
		}

		public NSURLHandle(Untyped instance) : base(instance)
		{
		}

		public static new NSURLHandle alloc()
		{
			return new NSURLHandle(ms_class.Call("alloc"));
		}

		public new NSURLHandle retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSURLHandle");
	}
}
