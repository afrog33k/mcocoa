// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSComboBoxCell.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSComboBoxCell : NSTextFieldCell
	{
		public NSComboBoxCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSComboBoxCell(IntPtr instance) : base(instance)
		{
		}

		public NSComboBoxCell(Untyped instance) : base(instance)
		{
		}

		public static new NSComboBoxCell alloc()
		{
			return new NSComboBoxCell(ms_class.Call("alloc"));
		}

		public new NSComboBoxCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool hasVerticalScroller()
		{
			return Call("hasVerticalScroller").To<bool>();
		}

		public void setHasVerticalScroller(bool flag)
		{
			Unused.Value = Call("setHasVerticalScroller:", flag);
		}

		public NSSize intercellSpacing()
		{
			return Call("intercellSpacing").To<NSSize>();
		}

		public void setIntercellSpacing(NSSize aSize)
		{
			Unused.Value = Call("setIntercellSpacing:", aSize);
		}

		public float itemHeight()
		{
			return Call("itemHeight").To<float>();
		}

		public void setItemHeight(float itemHeight)
		{
			Unused.Value = Call("setItemHeight:", itemHeight);
		}

		public Int32 numberOfVisibleItems()
		{
			return Call("numberOfVisibleItems").To<Int32>();
		}

		public void setNumberOfVisibleItems(Int32 visibleItems)
		{
			Unused.Value = Call("setNumberOfVisibleItems:", visibleItems);
		}

		public void setButtonBordered(bool flag)
		{
			Unused.Value = Call("setButtonBordered:", flag);
		}

		public bool isButtonBordered()
		{
			return Call("isButtonBordered").To<bool>();
		}

		public void reloadData()
		{
			Unused.Value = Call("reloadData");
		}

		public void noteNumberOfItemsChanged()
		{
			Unused.Value = Call("noteNumberOfItemsChanged");
		}

		public void setUsesDataSource(bool flag)
		{
			Unused.Value = Call("setUsesDataSource:", flag);
		}

		public bool usesDataSource()
		{
			return Call("usesDataSource").To<bool>();
		}

		public void scrollItemAtIndexToTop(Int32 index)
		{
			Unused.Value = Call("scrollItemAtIndexToTop:", index);
		}

		public void scrollItemAtIndexToVisible(Int32 index)
		{
			Unused.Value = Call("scrollItemAtIndexToVisible:", index);
		}

		public void selectItemAtIndex(Int32 index)
		{
			Unused.Value = Call("selectItemAtIndex:", index);
		}

		public void deselectItemAtIndex(Int32 index)
		{
			Unused.Value = Call("deselectItemAtIndex:", index);
		}

		public Int32 indexOfSelectedItem()
		{
			return Call("indexOfSelectedItem").To<Int32>();
		}

		public Int32 numberOfItems()
		{
			return Call("numberOfItems").To<Int32>();
		}

		public bool completes()
		{
			return Call("completes").To<bool>();
		}

		public void setCompletes(bool completes)
		{
			Unused.Value = Call("setCompletes:", completes);
		}

		public NSString completedString(NSString string_)
		{
			return Call("completedString:", string_).To<NSString>();
		}

		public NSObject dataSource()
		{
			return Call("dataSource").To<NSObject>();
		}

		public void setDataSource(NSObject aSource)
		{
			Unused.Value = Call("setDataSource:", aSource);
		}

		public void addItemWithObjectValue(NSObject object_)
		{
			Unused.Value = Call("addItemWithObjectValue:", object_);
		}

		public void addItemsWithObjectValues(NSArray objects)
		{
			Unused.Value = Call("addItemsWithObjectValues:", objects);
		}

		public void insertItemWithObjectValueAtIndex(NSObject object_, Int32 index)
		{
			Unused.Value = Call("insertItemWithObjectValue:atIndex:", object_, index);
		}

		public void removeItemWithObjectValue(NSObject object_)
		{
			Unused.Value = Call("removeItemWithObjectValue:", object_);
		}

		public void removeItemAtIndex(Int32 index)
		{
			Unused.Value = Call("removeItemAtIndex:", index);
		}

		public void removeAllItems()
		{
			Unused.Value = Call("removeAllItems");
		}

		public void selectItemWithObjectValue(NSObject object_)
		{
			Unused.Value = Call("selectItemWithObjectValue:", object_);
		}

		public NSObject itemObjectValueAtIndex(Int32 index)
		{
			return Call("itemObjectValueAtIndex:", index).To<NSObject>();
		}

		public NSObject objectValueOfSelectedItem()
		{
			return Call("objectValueOfSelectedItem").To<NSObject>();
		}

		public Int32 indexOfItemWithObjectValue(NSObject object_)
		{
			return Call("indexOfItemWithObjectValue:", object_).To<Int32>();
		}

		public NSArray objectValues()
		{
			return Call("objectValues").To<NSArray>();
		}

		private static Class ms_class = new Class("NSComboBoxCell");
	}

	public static class NSComboBoxCellDataSourceForNSObjectCategory
	{
		public static Int32 numberOfItemsInComboBoxCell(this NSObject _instance, NSComboBoxCell comboBoxCell)
		{
			return _instance.Call("numberOfItemsInComboBoxCell:", comboBoxCell).To<Int32>();
		}

		public static NSObject comboBoxCellObjectValueForItemAtIndex(this NSObject _instance, NSComboBoxCell aComboBoxCell, Int32 index)
		{
			return _instance.Call("comboBoxCell:objectValueForItemAtIndex:", aComboBoxCell, index).To<NSObject>();
		}

		public static UInt32 comboBoxCellIndexOfItemWithStringValue(this NSObject _instance, NSComboBoxCell aComboBoxCell, NSString string_)
		{
			return _instance.Call("comboBoxCell:indexOfItemWithStringValue:", aComboBoxCell, string_).To<UInt32>();
		}

		public static NSString comboBoxCellCompletedString(this NSObject _instance, NSComboBoxCell aComboBoxCell, NSString uncompletedString)
		{
			return _instance.Call("comboBoxCell:completedString:", aComboBoxCell, uncompletedString).To<NSString>();
		}
	}
}
