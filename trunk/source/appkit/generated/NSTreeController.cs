// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTreeController.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSTreeController : NSObjectController
	{
		public NSTreeController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTreeController(IntPtr instance) : base(instance)
		{
		}

		public NSTreeController(Untyped instance) : base(instance)
		{
		}

		public static new NSTreeController alloc()
		{
			return new NSTreeController(ms_class.Call("alloc"));
		}

		public new NSTreeController retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void rearrangeObjects()
		{
			Unused.Value = Call("rearrangeObjects");
		}

		public NSObject arrangedObjects()
		{
			return Call("arrangedObjects").To<NSObject>();
		}

		public void setChildrenKeyPath(NSString keyPath)
		{
			Unused.Value = Call("setChildrenKeyPath:", keyPath);
		}

		public NSString childrenKeyPath()
		{
			return Call("childrenKeyPath").To<NSString>();
		}

		public void setCountKeyPath(NSString keyPath)
		{
			Unused.Value = Call("setCountKeyPath:", keyPath);
		}

		public NSString countKeyPath()
		{
			return Call("countKeyPath").To<NSString>();
		}

		public void setLeafKeyPath(NSString keyPath)
		{
			Unused.Value = Call("setLeafKeyPath:", keyPath);
		}

		public NSString leafKeyPath()
		{
			return Call("leafKeyPath").To<NSString>();
		}

		public void setSortDescriptors(NSArray sortDescriptors)
		{
			Unused.Value = Call("setSortDescriptors:", sortDescriptors);
		}

		public NSArray sortDescriptors()
		{
			return Call("sortDescriptors").To<NSArray>();
		}

		// skipping content (it's declared in a base class)

		// skipping setContent: (it's declared in a base class)

		// skipping add: (it's declared in a base class)

		// skipping remove: (it's declared in a base class)

		public void addChild(NSObject sender)
		{
			Unused.Value = Call("addChild:", sender);
		}

		public void insert(NSObject sender)
		{
			Unused.Value = Call("insert:", sender);
		}

		public void insertChild(NSObject sender)
		{
			Unused.Value = Call("insertChild:", sender);
		}

		public bool canInsert()
		{
			return Call("canInsert").To<bool>();
		}

		public bool canInsertChild()
		{
			return Call("canInsertChild").To<bool>();
		}

		public bool canAddChild()
		{
			return Call("canAddChild").To<bool>();
		}

		public void insertObjectAtArrangedObjectIndexPath(NSObject object_, NSIndexPath indexPath)
		{
			Unused.Value = Call("insertObject:atArrangedObjectIndexPath:", object_, indexPath);
		}

		public void insertObjectsAtArrangedObjectIndexPaths(NSArray objects, NSArray indexPaths)
		{
			Unused.Value = Call("insertObjects:atArrangedObjectIndexPaths:", objects, indexPaths);
		}

		public void removeObjectAtArrangedObjectIndexPath(NSIndexPath indexPath)
		{
			Unused.Value = Call("removeObjectAtArrangedObjectIndexPath:", indexPath);
		}

		public void removeObjectsAtArrangedObjectIndexPaths(NSArray indexPaths)
		{
			Unused.Value = Call("removeObjectsAtArrangedObjectIndexPaths:", indexPaths);
		}

		public void setAvoidsEmptySelection(bool flag)
		{
			Unused.Value = Call("setAvoidsEmptySelection:", flag);
		}

		public bool avoidsEmptySelection()
		{
			return Call("avoidsEmptySelection").To<bool>();
		}

		public void setPreservesSelection(bool flag)
		{
			Unused.Value = Call("setPreservesSelection:", flag);
		}

		public bool preservesSelection()
		{
			return Call("preservesSelection").To<bool>();
		}

		public void setSelectsInsertedObjects(bool flag)
		{
			Unused.Value = Call("setSelectsInsertedObjects:", flag);
		}

		public bool selectsInsertedObjects()
		{
			return Call("selectsInsertedObjects").To<bool>();
		}

		public void setAlwaysUsesMultipleValuesMarker(bool flag)
		{
			Unused.Value = Call("setAlwaysUsesMultipleValuesMarker:", flag);
		}

		public bool alwaysUsesMultipleValuesMarker()
		{
			return Call("alwaysUsesMultipleValuesMarker").To<bool>();
		}

		// skipping selectedObjects (it's declared in a base class)

		public bool setSelectionIndexPaths(NSArray indexPaths)
		{
			return Call("setSelectionIndexPaths:", indexPaths).To<bool>();
		}

		public NSArray selectionIndexPaths()
		{
			return Call("selectionIndexPaths").To<NSArray>();
		}

		public bool setSelectionIndexPath(NSIndexPath indexPath)
		{
			return Call("setSelectionIndexPath:", indexPath).To<bool>();
		}

		public NSIndexPath selectionIndexPath()
		{
			return Call("selectionIndexPath").To<NSIndexPath>();
		}

		public bool addSelectionIndexPaths(NSArray indexPaths)
		{
			return Call("addSelectionIndexPaths:", indexPaths).To<bool>();
		}

		public bool removeSelectionIndexPaths(NSArray indexPaths)
		{
			return Call("removeSelectionIndexPaths:", indexPaths).To<bool>();
		}

		public NSArray selectedNodes()
		{
			return Call("selectedNodes").To<NSArray>();
		}

		public void moveNodeToIndexPath(NSTreeNode node, NSIndexPath indexPath)
		{
			Unused.Value = Call("moveNode:toIndexPath:", node, indexPath);
		}

		public void moveNodesToIndexPath(NSArray nodes, NSIndexPath startingIndexPath)
		{
			Unused.Value = Call("moveNodes:toIndexPath:", nodes, startingIndexPath);
		}

		public NSString childrenKeyPathForNode(NSTreeNode node)
		{
			return Call("childrenKeyPathForNode:", node).To<NSString>();
		}

		public NSString countKeyPathForNode(NSTreeNode node)
		{
			return Call("countKeyPathForNode:", node).To<NSString>();
		}

		public NSString leafKeyPathForNode(NSTreeNode node)
		{
			return Call("leafKeyPathForNode:", node).To<NSString>();
		}

		private static Class ms_class = new Class("NSTreeController");
	}
}
