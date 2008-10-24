// machine generated on 10/24/2008 3:54:03 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSAppleScript.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSAppleScript : NSObject
	{
		public NSAppleScript() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAppleScript(IntPtr instance) : base(instance)
		{
		}

		public NSAppleScript(Untyped instance) : base(instance)
		{
		}

		public static new NSAppleScript alloc()
		{
			return new NSAppleScript(ms_class.Call("alloc"));
		}

		public new NSAppleScript retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContentsOfURLError(NSURL url, IntPtr errorInfo)
		{
			return Call("initWithContentsOfURL:error:", url, errorInfo).To<NSObject>();
		}

		public NSObject initWithSource(NSString source)
		{
			return Call("initWithSource:", source).To<NSObject>();
		}

		public NSString source()
		{
			return Call("source").To<NSString>();
		}

		public bool isCompiled()
		{
			return Call("isCompiled").To<bool>();
		}

		public bool compileAndReturnError(IntPtr errorInfo)
		{
			return Call("compileAndReturnError:", errorInfo).To<bool>();
		}

		public NSAppleEventDescriptor executeAndReturnError(IntPtr errorInfo)
		{
			return Call("executeAndReturnError:", errorInfo).To<NSAppleEventDescriptor>();
		}

		public NSAppleEventDescriptor executeAppleEventError(NSAppleEventDescriptor event_, IntPtr errorInfo)
		{
			return Call("executeAppleEvent:error:", event_, errorInfo).To<NSAppleEventDescriptor>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSAppleScript");
	}
}
