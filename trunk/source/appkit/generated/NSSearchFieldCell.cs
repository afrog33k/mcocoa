// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSearchFieldCell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSearchFieldCell : NSTextFieldCell
	{
		public NSSearchFieldCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSearchFieldCell(IntPtr instance) : base(instance)
		{
		}

		public NSSearchFieldCell(Untyped instance) : base(instance)
		{
		}

		public static new NSSearchFieldCell alloc()
		{
			return new NSSearchFieldCell(ms_class.Call("alloc"));
		}

		public new NSSearchFieldCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSButtonCell searchButtonCell()
		{
			return Call("searchButtonCell").To<NSButtonCell>();
		}

		public void setSearchButtonCell(NSButtonCell cell)
		{
			Unused.Value = Call("setSearchButtonCell:", cell);
		}

		public NSButtonCell cancelButtonCell()
		{
			return Call("cancelButtonCell").To<NSButtonCell>();
		}

		public void setCancelButtonCell(NSButtonCell cell)
		{
			Unused.Value = Call("setCancelButtonCell:", cell);
		}

		public void resetSearchButtonCell()
		{
			Unused.Value = Call("resetSearchButtonCell");
		}

		public void resetCancelButtonCell()
		{
			Unused.Value = Call("resetCancelButtonCell");
		}

		public NSRect searchTextRectForBounds(NSRect rect)
		{
			return Call("searchTextRectForBounds:", rect).To<NSRect>();
		}

		public NSRect searchButtonRectForBounds(NSRect rect)
		{
			return Call("searchButtonRectForBounds:", rect).To<NSRect>();
		}

		public NSRect cancelButtonRectForBounds(NSRect rect)
		{
			return Call("cancelButtonRectForBounds:", rect).To<NSRect>();
		}

		public void setSearchMenuTemplate(NSMenu menu)
		{
			Unused.Value = Call("setSearchMenuTemplate:", menu);
		}

		public NSMenu searchMenuTemplate()
		{
			return Call("searchMenuTemplate").To<NSMenu>();
		}

		public void setSendsWholeSearchString(bool flag)
		{
			Unused.Value = Call("setSendsWholeSearchString:", flag);
		}

		public bool sendsWholeSearchString()
		{
			return Call("sendsWholeSearchString").To<bool>();
		}

		public void setMaximumRecents(Int32 maxRecents)
		{
			Unused.Value = Call("setMaximumRecents:", maxRecents);
		}

		public Int32 maximumRecents()
		{
			return Call("maximumRecents").To<Int32>();
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

		public bool sendsSearchStringImmediately()
		{
			return Call("sendsSearchStringImmediately").To<bool>();
		}

		public void setSendsSearchStringImmediately(bool flag)
		{
			Unused.Value = Call("setSendsSearchStringImmediately:", flag);
		}

		private static Class ms_class = new Class("NSSearchFieldCell");
	}
}
