// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSInvocation.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSInvocation : NSObject
	{
		public NSInvocation() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSInvocation(IntPtr instance) : base(instance)
		{
		}

		public NSInvocation(Untyped instance) : base(instance)
		{
		}

		public static new NSInvocation alloc()
		{
			return new NSInvocation(ms_class.Call("alloc"));
		}

		public new NSInvocation retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSInvocation invocationWithMethodSignature(NSMethodSignature sig)
		{
			return ms_class.Call("invocationWithMethodSignature:", sig).To<NSInvocation>();
		}

		public NSMethodSignature methodSignature()
		{
			return Call("methodSignature").To<NSMethodSignature>();
		}

		public void retainArguments()
		{
			Unused.Value = Call("retainArguments");
		}

		public bool argumentsRetained()
		{
			return Call("argumentsRetained").To<bool>();
		}

		public NSObject target()
		{
			return Call("target").To<NSObject>();
		}

		public void setTarget(NSObject target)
		{
			Unused.Value = Call("setTarget:", target);
		}

		public Selector selector()
		{
			return Call("selector").To<Selector>();
		}

		public void setSelector(Selector selector)
		{
			Unused.Value = Call("setSelector:", selector);
		}

		public void getReturnValue(IntPtr retLoc)
		{
			Unused.Value = Call("getReturnValue:", retLoc);
		}

		public void setReturnValue(IntPtr retLoc)
		{
			Unused.Value = Call("setReturnValue:", retLoc);
		}

		public void getArgumentAtIndex(IntPtr argumentLocation, Int32 idx)
		{
			Unused.Value = Call("getArgument:atIndex:", argumentLocation, idx);
		}

		public void setArgumentAtIndex(IntPtr argumentLocation, Int32 idx)
		{
			Unused.Value = Call("setArgument:atIndex:", argumentLocation, idx);
		}

		public void invoke()
		{
			Unused.Value = Call("invoke");
		}

		public void invokeWithTarget(NSObject target)
		{
			Unused.Value = Call("invokeWithTarget:", target);
		}

		private static Class ms_class = new Class("NSInvocation");
	}
}
