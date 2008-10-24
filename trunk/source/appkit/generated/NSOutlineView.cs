// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSOutlineView.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSOutlineViewDropOnItemIndex = -1;
	}

	[Register]
	public partial class NSOutlineView : NSTableView
	{
		public NSOutlineView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOutlineView(IntPtr instance) : base(instance)
		{
		}

		public NSOutlineView(Untyped instance) : base(instance)
		{
		}

		public static new NSOutlineView alloc()
		{
			return new NSOutlineView(ms_class.Call("alloc"));
		}

		public new NSOutlineView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setOutlineTableColumn(NSTableColumn outlineTableColumn)
		{
			Unused.Value = Call("setOutlineTableColumn:", outlineTableColumn);
		}

		public NSTableColumn outlineTableColumn()
		{
			return Call("outlineTableColumn").To<NSTableColumn>();
		}

		public bool isExpandable(NSObject item)
		{
			return Call("isExpandable:", item).To<bool>();
		}

		public void expandItemExpandChildren(NSObject item, bool expandChildren)
		{
			Unused.Value = Call("expandItem:expandChildren:", item, expandChildren);
		}

		public void expandItem(NSObject item)
		{
			Unused.Value = Call("expandItem:", item);
		}

		public void collapseItemCollapseChildren(NSObject item, bool collapseChildren)
		{
			Unused.Value = Call("collapseItem:collapseChildren:", item, collapseChildren);
		}

		public void collapseItem(NSObject item)
		{
			Unused.Value = Call("collapseItem:", item);
		}

		public void reloadItemReloadChildren(NSObject item, bool reloadChildren)
		{
			Unused.Value = Call("reloadItem:reloadChildren:", item, reloadChildren);
		}

		public void reloadItem(NSObject item)
		{
			Unused.Value = Call("reloadItem:", item);
		}

		public NSObject parentForItem(NSObject item)
		{
			return Call("parentForItem:", item).To<NSObject>();
		}

		public NSObject itemAtRow(Int32 row)
		{
			return Call("itemAtRow:", row).To<NSObject>();
		}

		public Int32 rowForItem(NSObject item)
		{
			return Call("rowForItem:", item).To<Int32>();
		}

		public Int32 levelForItem(NSObject item)
		{
			return Call("levelForItem:", item).To<Int32>();
		}

		public Int32 levelForRow(Int32 row)
		{
			return Call("levelForRow:", row).To<Int32>();
		}

		public bool isItemExpanded(NSObject item)
		{
			return Call("isItemExpanded:", item).To<bool>();
		}

		public void setIndentationPerLevel(float indentationPerLevel)
		{
			Unused.Value = Call("setIndentationPerLevel:", indentationPerLevel);
		}

		public float indentationPerLevel()
		{
			return Call("indentationPerLevel").To<float>();
		}

		public void setIndentationMarkerFollowsCell(bool drawInCell)
		{
			Unused.Value = Call("setIndentationMarkerFollowsCell:", drawInCell);
		}

		public bool indentationMarkerFollowsCell()
		{
			return Call("indentationMarkerFollowsCell").To<bool>();
		}

		public void setAutoresizesOutlineColumn(bool resize)
		{
			Unused.Value = Call("setAutoresizesOutlineColumn:", resize);
		}

		public bool autoresizesOutlineColumn()
		{
			return Call("autoresizesOutlineColumn").To<bool>();
		}

		public NSRect frameOfOutlineCellAtRow(Int32 row)
		{
			return Call("frameOfOutlineCellAtRow:", row).To<NSRect>();
		}

		public void setDropItemDropChildIndex(NSObject item, Int32 index)
		{
			Unused.Value = Call("setDropItem:dropChildIndex:", item, index);
		}

		public bool shouldCollapseAutoExpandedItemsForDeposited(bool deposited)
		{
			return Call("shouldCollapseAutoExpandedItemsForDeposited:", deposited).To<bool>();
		}

		public bool autosaveExpandedItems()
		{
			return Call("autosaveExpandedItems").To<bool>();
		}

		public void setAutosaveExpandedItems(bool save)
		{
			Unused.Value = Call("setAutosaveExpandedItems:", save);
		}

		private static Class ms_class = new Class("NSOutlineView");
	}

	public static class NSOutlineViewDataSourceForNSObjectCategory
	{
		public static NSObject outlineViewChildOfItem(this NSObject _instance, NSOutlineView outlineView, Int32 index, NSObject item)
		{
			return _instance.Call("outlineView:child:ofItem:", outlineView, index, item).To<NSObject>();
		}

		public static bool outlineViewIsItemExpandable(this NSObject _instance, NSOutlineView outlineView, NSObject item)
		{
			return _instance.Call("outlineView:isItemExpandable:", outlineView, item).To<bool>();
		}

		public static Int32 outlineViewNumberOfChildrenOfItem(this NSObject _instance, NSOutlineView outlineView, NSObject item)
		{
			return _instance.Call("outlineView:numberOfChildrenOfItem:", outlineView, item).To<Int32>();
		}

		public static NSObject outlineViewObjectValueForTableColumnByItem(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			return _instance.Call("outlineView:objectValueForTableColumn:byItem:", outlineView, tableColumn, item).To<NSObject>();
		}

		public static void outlineViewSetObjectValueForTableColumnByItem(this NSObject _instance, NSOutlineView outlineView, NSObject object_, NSTableColumn tableColumn, NSObject item)
		{
			Unused.Value = _instance.Call("outlineView:setObjectValue:forTableColumn:byItem:", outlineView, object_, tableColumn, item);
		}

		public static NSObject outlineViewItemForPersistentObject(this NSObject _instance, NSOutlineView outlineView, NSObject object_)
		{
			return _instance.Call("outlineView:itemForPersistentObject:", outlineView, object_).To<NSObject>();
		}

		public static NSObject outlineViewPersistentObjectForItem(this NSObject _instance, NSOutlineView outlineView, NSObject item)
		{
			return _instance.Call("outlineView:persistentObjectForItem:", outlineView, item).To<NSObject>();
		}

		public static void outlineViewSortDescriptorsDidChange(this NSObject _instance, NSOutlineView outlineView, NSArray oldDescriptors)
		{
			Unused.Value = _instance.Call("outlineView:sortDescriptorsDidChange:", outlineView, oldDescriptors);
		}

		public static bool outlineViewWriteItemsToPasteboard(this NSObject _instance, NSOutlineView outlineView, NSArray items, NSPasteboard pasteboard)
		{
			return _instance.Call("outlineView:writeItems:toPasteboard:", outlineView, items, pasteboard).To<bool>();
		}

		public static UInt32 outlineViewValidateDropProposedItemProposedChildIndex(this NSObject _instance, NSOutlineView outlineView, NSObject info, NSObject item, Int32 index)
		{
			return _instance.Call("outlineView:validateDrop:proposedItem:proposedChildIndex:", outlineView, info, item, index).To<UInt32>();
		}

		public static bool outlineViewAcceptDropItemChildIndex(this NSObject _instance, NSOutlineView outlineView, NSObject info, NSObject item, Int32 index)
		{
			return _instance.Call("outlineView:acceptDrop:item:childIndex:", outlineView, info, item, index).To<bool>();
		}

		public static NSArray outlineViewNamesOfPromisedFilesDroppedAtDestinationForDraggedItems(this NSObject _instance, NSOutlineView outlineView, NSURL dropDestination, NSArray items)
		{
			return _instance.Call("outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:", outlineView, dropDestination, items).To<NSArray>();
		}
	}

	public static class NSOutlineViewDelegateForNSObjectCategory
	{
		public static void outlineViewWillDisplayCellForTableColumnItem(this NSObject _instance, NSOutlineView outlineView, NSObject cell, NSTableColumn tableColumn, NSObject item)
		{
			Unused.Value = _instance.Call("outlineView:willDisplayCell:forTableColumn:item:", outlineView, cell, tableColumn, item);
		}

		public static bool outlineViewShouldEditTableColumnItem(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			return _instance.Call("outlineView:shouldEditTableColumn:item:", outlineView, tableColumn, item).To<bool>();
		}

		public static bool selectionShouldChangeInOutlineView(this NSObject _instance, NSOutlineView outlineView)
		{
			return _instance.Call("selectionShouldChangeInOutlineView:", outlineView).To<bool>();
		}

		public static bool outlineViewShouldSelectItem(this NSObject _instance, NSOutlineView outlineView, NSObject item)
		{
			return _instance.Call("outlineView:shouldSelectItem:", outlineView, item).To<bool>();
		}

		public static NSIndexSet outlineViewSelectionIndexesForProposedSelection(this NSObject _instance, NSOutlineView outlineView, NSIndexSet proposedSelectionIndexes)
		{
			return _instance.Call("outlineView:selectionIndexesForProposedSelection:", outlineView, proposedSelectionIndexes).To<NSIndexSet>();
		}

		public static bool outlineViewShouldSelectTableColumn(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			return _instance.Call("outlineView:shouldSelectTableColumn:", outlineView, tableColumn).To<bool>();
		}

		public static void outlineViewMouseDownInHeaderOfTableColumn(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			Unused.Value = _instance.Call("outlineView:mouseDownInHeaderOfTableColumn:", outlineView, tableColumn);
		}

		public static void outlineViewDidClickTableColumn(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			Unused.Value = _instance.Call("outlineView:didClickTableColumn:", outlineView, tableColumn);
		}

		public static void outlineViewDidDragTableColumn(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn)
		{
			Unused.Value = _instance.Call("outlineView:didDragTableColumn:", outlineView, tableColumn);
		}

		public static NSString outlineViewToolTipForCellRectTableColumnItemMouseLocation(this NSObject _instance, NSOutlineView outlineView, NSCell cell, IntPtr rect, NSTableColumn tableColumn, NSObject item, NSPoint mouseLocation)
		{
			return _instance.Call("outlineView:toolTipForCell:rect:tableColumn:item:mouseLocation:", outlineView, cell, rect, tableColumn, item, mouseLocation).To<NSString>();
		}

		public static float outlineViewHeightOfRowByItem(this NSObject _instance, NSOutlineView outlineView, NSObject item)
		{
			return _instance.Call("outlineView:heightOfRowByItem:", outlineView, item).To<float>();
		}

		public static NSString outlineViewTypeSelectStringForTableColumnItem(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			return _instance.Call("outlineView:typeSelectStringForTableColumn:item:", outlineView, tableColumn, item).To<NSString>();
		}

		public static NSObject outlineViewNextTypeSelectMatchFromItemToItemForString(this NSObject _instance, NSOutlineView outlineView, NSObject startItem, NSObject endItem, NSString searchString)
		{
			return _instance.Call("outlineView:nextTypeSelectMatchFromItem:toItem:forString:", outlineView, startItem, endItem, searchString).To<NSObject>();
		}

		public static bool outlineViewShouldTypeSelectForEventWithCurrentSearchString(this NSObject _instance, NSOutlineView outlineView, NSEvent event_, NSString searchString)
		{
			return _instance.Call("outlineView:shouldTypeSelectForEvent:withCurrentSearchString:", outlineView, event_, searchString).To<bool>();
		}

		public static bool outlineViewShouldShowCellExpansionForTableColumnItem(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			return _instance.Call("outlineView:shouldShowCellExpansionForTableColumn:item:", outlineView, tableColumn, item).To<bool>();
		}

		public static bool outlineViewShouldTrackCellForTableColumnItem(this NSObject _instance, NSOutlineView outlineView, NSCell cell, NSTableColumn tableColumn, NSObject item)
		{
			return _instance.Call("outlineView:shouldTrackCell:forTableColumn:item:", outlineView, cell, tableColumn, item).To<bool>();
		}

		public static NSCell outlineViewDataCellForTableColumnItem(this NSObject _instance, NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
		{
			return _instance.Call("outlineView:dataCellForTableColumn:item:", outlineView, tableColumn, item).To<NSCell>();
		}

		public static bool outlineViewIsGroupItem(this NSObject _instance, NSOutlineView outlineView, NSObject item)
		{
			return _instance.Call("outlineView:isGroupItem:", outlineView, item).To<bool>();
		}

		public static bool outlineViewShouldExpandItem(this NSObject _instance, NSOutlineView outlineView, NSObject item)
		{
			return _instance.Call("outlineView:shouldExpandItem:", outlineView, item).To<bool>();
		}

		public static bool outlineViewShouldCollapseItem(this NSObject _instance, NSOutlineView outlineView, NSObject item)
		{
			return _instance.Call("outlineView:shouldCollapseItem:", outlineView, item).To<bool>();
		}

		public static void outlineViewWillDisplayOutlineCellForTableColumnItem(this NSObject _instance, NSOutlineView outlineView, NSObject cell, NSTableColumn tableColumn, NSObject item)
		{
			Unused.Value = _instance.Call("outlineView:willDisplayOutlineCell:forTableColumn:item:", outlineView, cell, tableColumn, item);
		}
	}

	public static class NSOutlineViewNotificationsForNSObjectCategory
	{
		public static void outlineViewSelectionDidChange(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("outlineViewSelectionDidChange:", notification);
		}

		public static void outlineViewColumnDidMove(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("outlineViewColumnDidMove:", notification);
		}

		public static void outlineViewColumnDidResize(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("outlineViewColumnDidResize:", notification);
		}

		public static void outlineViewSelectionIsChanging(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("outlineViewSelectionIsChanging:", notification);
		}

		public static void outlineViewItemWillExpand(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("outlineViewItemWillExpand:", notification);
		}

		public static void outlineViewItemDidExpand(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("outlineViewItemDidExpand:", notification);
		}

		public static void outlineViewItemWillCollapse(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("outlineViewItemWillCollapse:", notification);
		}

		public static void outlineViewItemDidCollapse(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("outlineViewItemDidCollapse:", notification);
		}
	}
}
