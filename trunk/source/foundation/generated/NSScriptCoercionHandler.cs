// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptCoercionHandler.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSScriptCoercionHandler : NSObject
	{
		public NSScriptCoercionHandler() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScriptCoercionHandler(IntPtr instance) : base(instance)
		{
		}

		public NSScriptCoercionHandler(Untyped instance) : base(instance)
		{
		}

		public static new NSScriptCoercionHandler alloc()
		{
			return new NSScriptCoercionHandler(ms_class.Call("alloc"));
		}

		public new NSScriptCoercionHandler retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSScriptCoercionHandler sharedCoercionHandler()
		{
			return ms_class.Call("sharedCoercionHandler").To<NSScriptCoercionHandler>();
		}

		public NSObject coerceValueToClass(NSObject value, Class toClass)
		{
			return Call("coerceValue:toClass:", value, toClass).To<NSObject>();
		}

		public void registerCoercerSelectorToConvertFromClassToClass(NSObject coercer, Selector selector, Class fromClass, Class toClass)
		{
			Unused.Value = Call("registerCoercer:selector:toConvertFromClass:toClass:", coercer, selector, fromClass, toClass);
		}

		private static Class ms_class = new Class("NSScriptCoercionHandler");
	}
}
