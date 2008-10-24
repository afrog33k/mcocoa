// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextStorage.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTextStorageEditedAttributes = 1;
		public const int NSTextStorageEditedCharacters = 2;
	}

	[Register]
	public partial class NSTextStorage : NSMutableAttributedString
	{
		public NSTextStorage() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextStorage(IntPtr instance) : base(instance)
		{
		}

		public NSTextStorage(Untyped instance) : base(instance)
		{
		}

		public static new NSTextStorage alloc()
		{
			return new NSTextStorage(ms_class.Call("alloc"));
		}

		public new NSTextStorage retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void addLayoutManager(NSLayoutManager obj)
		{
			Unused.Value = Call("addLayoutManager:", obj);
		}

		public void removeLayoutManager(NSLayoutManager obj)
		{
			Unused.Value = Call("removeLayoutManager:", obj);
		}

		public NSArray layoutManagers()
		{
			return Call("layoutManagers").To<NSArray>();
		}

		public void editedRangeChangeInLength(UInt32 editedMask, NSRange range, Int32 delta)
		{
			Unused.Value = Call("edited:range:changeInLength:", editedMask, range, delta);
		}

		public void processEditing()
		{
			Unused.Value = Call("processEditing");
		}

		public void invalidateAttributesInRange(NSRange range)
		{
			Unused.Value = Call("invalidateAttributesInRange:", range);
		}

		public void ensureAttributesAreFixedInRange(NSRange range)
		{
			Unused.Value = Call("ensureAttributesAreFixedInRange:", range);
		}

		public bool fixesAttributesLazily()
		{
			return Call("fixesAttributesLazily").To<bool>();
		}

		public UInt32 editedMask()
		{
			return Call("editedMask").To<UInt32>();
		}

		public NSRange editedRange()
		{
			return Call("editedRange").To<NSRange>();
		}

		public Int32 changeInLength()
		{
			return Call("changeInLength").To<Int32>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		private static Class ms_class = new Class("NSTextStorage");
	}

	public static class NSTextStorageDelegateForNSObjectCategory
	{
		public static void textStorageWillProcessEditing(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("textStorageWillProcessEditing:", notification);
		}

		public static void textStorageDidProcessEditing(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("textStorageDidProcessEditing:", notification);
		}
	}
}
