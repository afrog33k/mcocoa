// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSActionCell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSActionCell : NSCell
	{
		public NSActionCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSActionCell(IntPtr instance) : base(instance)
		{
		}

		public NSActionCell(Untyped instance) : base(instance)
		{
		}

		public static new NSActionCell alloc()
		{
			return new NSActionCell(ms_class.Call("alloc"));
		}

		public new NSActionCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping controlView (it's declared in a base class)

		// skipping setControlView: (it's declared in a base class)

		// skipping setFont: (it's declared in a base class)

		// skipping setAlignment: (it's declared in a base class)

		// skipping setBordered: (it's declared in a base class)

		// skipping setBezeled: (it's declared in a base class)

		// skipping setEnabled: (it's declared in a base class)

		// skipping setFloatingPointFormat:left:right: (it's declared in a base class)

		// skipping setImage: (it's declared in a base class)

		// skipping target (it's declared in a base class)

		// skipping setTarget: (it's declared in a base class)

		// skipping action (it's declared in a base class)

		// skipping setAction: (it's declared in a base class)

		// skipping tag (it's declared in a base class)

		// skipping setTag: (it's declared in a base class)

		// skipping stringValue (it's declared in a base class)

		// skipping intValue (it's declared in a base class)

		// skipping floatValue (it's declared in a base class)

		// skipping doubleValue (it's declared in a base class)

		// skipping setObjectValue: (it's declared in a base class)

		// skipping integerValue (it's declared in a base class)

		private static Class ms_class = new Class("NSActionCell");
	}
}
