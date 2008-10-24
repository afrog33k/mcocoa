// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSMethodSignature.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSMethodSignature : NSObject
	{
		public NSMethodSignature() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMethodSignature(IntPtr instance) : base(instance)
		{
		}

		public NSMethodSignature(Untyped instance) : base(instance)
		{
		}

		public static new NSMethodSignature alloc()
		{
			return new NSMethodSignature(ms_class.Call("alloc"));
		}

		public new NSMethodSignature retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSMethodSignature signatureWithObjCTypes(string types)
		{
			return ms_class.Call("signatureWithObjCTypes:", types).To<NSMethodSignature>();
		}

		public UInt32 numberOfArguments()
		{
			return Call("numberOfArguments").To<UInt32>();
		}

		public string getArgumentTypeAtIndex(UInt32 idx)
		{
			return Call("getArgumentTypeAtIndex:", idx).To<string>();
		}

		public UInt32 frameLength()
		{
			return Call("frameLength").To<UInt32>();
		}

		public bool isOneway()
		{
			return Call("isOneway").To<bool>();
		}

		public string methodReturnType()
		{
			return Call("methodReturnType").To<string>();
		}

		public UInt32 methodReturnLength()
		{
			return Call("methodReturnLength").To<UInt32>();
		}

		private static Class ms_class = new Class("NSMethodSignature");
	}
}
