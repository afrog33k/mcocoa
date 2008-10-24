// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPathComponentCell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPathComponentCell : NSTextFieldCell
	{
		public NSPathComponentCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPathComponentCell(IntPtr instance) : base(instance)
		{
		}

		public NSPathComponentCell(Untyped instance) : base(instance)
		{
		}

		public static new NSPathComponentCell alloc()
		{
			return new NSPathComponentCell(ms_class.Call("alloc"));
		}

		public new NSPathComponentCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping image (it's declared in a base class)

		// skipping setImage: (it's declared in a base class)

		public NSURL URL()
		{
			return Call("URL").To<NSURL>();
		}

		public void setURL(NSURL url)
		{
			Unused.Value = Call("setURL:", url);
		}

		private static Class ms_class = new Class("NSPathComponentCell");
	}
}
