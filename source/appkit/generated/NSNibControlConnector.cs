// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSNibControlConnector.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSNibControlConnector : NSNibConnector
	{
		public NSNibControlConnector() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNibControlConnector(IntPtr instance) : base(instance)
		{
		}

		public NSNibControlConnector(Untyped instance) : base(instance)
		{
		}

		public static new NSNibControlConnector alloc()
		{
			return new NSNibControlConnector(ms_class.Call("alloc"));
		}

		public new NSNibControlConnector retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping establishConnection (it's declared in a base class)

		private static Class ms_class = new Class("NSNibControlConnector");
	}
}
