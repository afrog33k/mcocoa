// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSNibOutletConnector.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSNibOutletConnector : NSNibConnector
	{
		public NSNibOutletConnector() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNibOutletConnector(IntPtr instance) : base(instance)
		{
		}

		public NSNibOutletConnector(Untyped instance) : base(instance)
		{
		}

		public static new NSNibOutletConnector alloc()
		{
			return new NSNibOutletConnector(ms_class.Call("alloc"));
		}

		public new NSNibOutletConnector retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping establishConnection (it's declared in a base class)

		private static Class ms_class = new Class("NSNibOutletConnector");
	}
}
