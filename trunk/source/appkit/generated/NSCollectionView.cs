// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSCollectionView.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSCollectionViewItem : NSObject
	{
		public NSCollectionViewItem() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCollectionViewItem(IntPtr instance) : base(instance)
		{
		}

		public NSCollectionViewItem(Untyped instance) : base(instance)
		{
		}

		public static new NSCollectionViewItem alloc()
		{
			return new NSCollectionViewItem(ms_class.Call("alloc"));
		}

		public new NSCollectionViewItem retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSCollectionView collectionView()
		{
			return Call("collectionView").To<NSCollectionView>();
		}

		public void setRepresentedObject(NSObject object_)
		{
			Unused.Value = Call("setRepresentedObject:", object_);
		}

		public NSObject representedObject()
		{
			return Call("representedObject").To<NSObject>();
		}

		public void setView(NSView view)
		{
			Unused.Value = Call("setView:", view);
		}

		public NSView view()
		{
			return Call("view").To<NSView>();
		}

		public void setSelected(bool flag)
		{
			Unused.Value = Call("setSelected:", flag);
		}

		public bool isSelected()
		{
			return Call("isSelected").To<bool>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSCollectionViewItem");
	}

	[Register]
	public partial class NSCollectionView : NSView
	{
		public NSCollectionView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCollectionView(IntPtr instance) : base(instance)
		{
		}

		public NSCollectionView(Untyped instance) : base(instance)
		{
		}

		public static new NSCollectionView alloc()
		{
			return new NSCollectionView(ms_class.Call("alloc"));
		}

		public new NSCollectionView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool isFirstResponder()
		{
			return Call("isFirstResponder").To<bool>();
		}

		public void setContent(NSArray content)
		{
			Unused.Value = Call("setContent:", content);
		}

		public NSArray content()
		{
			return Call("content").To<NSArray>();
		}

		public void setSelectable(bool flag)
		{
			Unused.Value = Call("setSelectable:", flag);
		}

		public bool isSelectable()
		{
			return Call("isSelectable").To<bool>();
		}

		public void setAllowsMultipleSelection(bool flag)
		{
			Unused.Value = Call("setAllowsMultipleSelection:", flag);
		}

		public bool allowsMultipleSelection()
		{
			return Call("allowsMultipleSelection").To<bool>();
		}

		public void setSelectionIndexes(NSIndexSet indexes)
		{
			Unused.Value = Call("setSelectionIndexes:", indexes);
		}

		public NSIndexSet selectionIndexes()
		{
			return Call("selectionIndexes").To<NSIndexSet>();
		}

		public NSCollectionViewItem newItemForRepresentedObject(NSObject object_)
		{
			return Call("newItemForRepresentedObject:", object_).To<NSCollectionViewItem>();
		}

		public void setItemPrototype(NSCollectionViewItem prototype)
		{
			Unused.Value = Call("setItemPrototype:", prototype);
		}

		public NSCollectionViewItem itemPrototype()
		{
			return Call("itemPrototype").To<NSCollectionViewItem>();
		}

		public void setMaxNumberOfRows(UInt32 number)
		{
			Unused.Value = Call("setMaxNumberOfRows:", number);
		}

		public UInt32 maxNumberOfRows()
		{
			return Call("maxNumberOfRows").To<UInt32>();
		}

		public void setMaxNumberOfColumns(UInt32 number)
		{
			Unused.Value = Call("setMaxNumberOfColumns:", number);
		}

		public UInt32 maxNumberOfColumns()
		{
			return Call("maxNumberOfColumns").To<UInt32>();
		}

		public void setMinItemSize(NSSize size)
		{
			Unused.Value = Call("setMinItemSize:", size);
		}

		public NSSize minItemSize()
		{
			return Call("minItemSize").To<NSSize>();
		}

		public void setMaxItemSize(NSSize size)
		{
			Unused.Value = Call("setMaxItemSize:", size);
		}

		public NSSize maxItemSize()
		{
			return Call("maxItemSize").To<NSSize>();
		}

		public void setBackgroundColors(NSArray colors)
		{
			Unused.Value = Call("setBackgroundColors:", colors);
		}

		public NSArray backgroundColors()
		{
			return Call("backgroundColors").To<NSArray>();
		}

		private static Class ms_class = new Class("NSCollectionView");
	}
}
