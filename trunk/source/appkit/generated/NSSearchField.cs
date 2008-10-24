// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSearchField.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSearchField : NSTextField
	{
		public NSSearchField() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSearchField(IntPtr instance) : base(instance)
		{
		}

		public NSSearchField(Untyped instance) : base(instance)
		{
		}

		public static new NSSearchField alloc()
		{
			return new NSSearchField(ms_class.Call("alloc"));
		}

		public new NSSearchField retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setRecentSearches(NSArray searches)
		{
			Unused.Value = Call("setRecentSearches:", searches);
		}

		public NSArray recentSearches()
		{
			return Call("recentSearches").To<NSArray>();
		}

		public void setRecentsAutosaveName(NSString string_)
		{
			Unused.Value = Call("setRecentsAutosaveName:", string_);
		}

		public NSString recentsAutosaveName()
		{
			return Call("recentsAutosaveName").To<NSString>();
		}

		private static Class ms_class = new Class("NSSearchField");
	}
}
