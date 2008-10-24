// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptExecutionContext.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSScriptExecutionContext : NSObject
	{
		public NSScriptExecutionContext() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScriptExecutionContext(IntPtr instance) : base(instance)
		{
		}

		public NSScriptExecutionContext(Untyped instance) : base(instance)
		{
		}

		public static new NSScriptExecutionContext alloc()
		{
			return new NSScriptExecutionContext(ms_class.Call("alloc"));
		}

		public new NSScriptExecutionContext retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSScriptExecutionContext sharedScriptExecutionContext()
		{
			return ms_class.Call("sharedScriptExecutionContext").To<NSScriptExecutionContext>();
		}

		public NSObject topLevelObject()
		{
			return Call("topLevelObject").To<NSObject>();
		}

		public void setTopLevelObject(NSObject obj)
		{
			Unused.Value = Call("setTopLevelObject:", obj);
		}

		public NSObject objectBeingTested()
		{
			return Call("objectBeingTested").To<NSObject>();
		}

		public void setObjectBeingTested(NSObject obj)
		{
			Unused.Value = Call("setObjectBeingTested:", obj);
		}

		public NSObject rangeContainerObject()
		{
			return Call("rangeContainerObject").To<NSObject>();
		}

		public void setRangeContainerObject(NSObject obj)
		{
			Unused.Value = Call("setRangeContainerObject:", obj);
		}

		private static Class ms_class = new Class("NSScriptExecutionContext");
	}
}
