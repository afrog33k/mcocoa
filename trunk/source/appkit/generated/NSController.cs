// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSController.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSController : NSObject
	{
		public NSController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSController(IntPtr instance) : base(instance)
		{
		}

		public NSController(Untyped instance) : base(instance)
		{
		}

		public static new NSController alloc()
		{
			return new NSController(ms_class.Call("alloc"));
		}

		public new NSController retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void objectDidBeginEditing(NSObject editor)
		{
			Unused.Value = Call("objectDidBeginEditing:", editor);
		}

		public void objectDidEndEditing(NSObject editor)
		{
			Unused.Value = Call("objectDidEndEditing:", editor);
		}

		public void discardEditing()
		{
			Unused.Value = Call("discardEditing");
		}

		public bool commitEditing()
		{
			return Call("commitEditing").To<bool>();
		}

		public void commitEditingWithDelegateDidCommitSelectorContextInfo(NSObject delegate_, Selector didCommitSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("commitEditingWithDelegate:didCommitSelector:contextInfo:", delegate_, didCommitSelector, contextInfo);
		}

		public bool isEditing()
		{
			return Call("isEditing").To<bool>();
		}

		#region NSCoding Methods
		public void encodeWithCoder(NSCoder aCoder)
		{
			Unused.Value = Call("encodeWithCoder:", aCoder);
		}

		public NSObject initWithCoder(NSCoder aDecoder)
		{
			return Call("initWithCoder:", aDecoder).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSController");
	}
}
