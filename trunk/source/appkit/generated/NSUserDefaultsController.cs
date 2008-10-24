// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSUserDefaultsController.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSUserDefaultsController : NSController
	{
		public NSUserDefaultsController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSUserDefaultsController(IntPtr instance) : base(instance)
		{
		}

		public NSUserDefaultsController(Untyped instance) : base(instance)
		{
		}

		public static new NSUserDefaultsController alloc()
		{
			return new NSUserDefaultsController(ms_class.Call("alloc"));
		}

		public new NSUserDefaultsController retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject sharedUserDefaultsController()
		{
			return ms_class.Call("sharedUserDefaultsController").To<NSObject>();
		}

		public NSObject initWithDefaultsInitialValues(NSUserDefaults defaults, NSDictionary initialValues)
		{
			return Call("initWithDefaults:initialValues:", defaults, initialValues).To<NSObject>();
		}

		public NSUserDefaults defaults()
		{
			return Call("defaults").To<NSUserDefaults>();
		}

		public void setInitialValues(NSDictionary initialValues)
		{
			Unused.Value = Call("setInitialValues:", initialValues);
		}

		public NSDictionary initialValues()
		{
			return Call("initialValues").To<NSDictionary>();
		}

		public void setAppliesImmediately(bool flag)
		{
			Unused.Value = Call("setAppliesImmediately:", flag);
		}

		public bool appliesImmediately()
		{
			return Call("appliesImmediately").To<bool>();
		}

		public bool hasUnappliedChanges()
		{
			return Call("hasUnappliedChanges").To<bool>();
		}

		public NSObject values()
		{
			return Call("values").To<NSObject>();
		}

		public void revert(NSObject sender)
		{
			Unused.Value = Call("revert:", sender);
		}

		public void save(NSObject sender)
		{
			Unused.Value = Call("save:", sender);
		}

		public void revertToInitialValues(NSObject sender)
		{
			Unused.Value = Call("revertToInitialValues:", sender);
		}

		private static Class ms_class = new Class("NSUserDefaultsController");
	}
}
