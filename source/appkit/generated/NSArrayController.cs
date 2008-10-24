// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSArrayController.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSArrayController : NSObjectController
	{
		public NSArrayController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSArrayController(IntPtr instance) : base(instance)
		{
		}

		public NSArrayController(Untyped instance) : base(instance)
		{
		}

		public static new NSArrayController alloc()
		{
			return new NSArrayController(ms_class.Call("alloc"));
		}

		public new NSArrayController retain()
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

		public void setAutomaticallyRearrangesObjects(bool flag)
		{
			Unused.Value = Call("setAutomaticallyRearrangesObjects:", flag);
		}

		public bool automaticallyRearrangesObjects()
		{
			return Call("automaticallyRearrangesObjects").To<bool>();
		}

		public NSArray automaticRearrangementKeyPaths()
		{
			return Call("automaticRearrangementKeyPaths").To<NSArray>();
		}

		public void didChangeArrangementCriteria()
		{
			Unused.Value = Call("didChangeArrangementCriteria");
		}

		public void setSortDescriptors(NSArray sortDescriptors)
		{
			Unused.Value = Call("setSortDescriptors:", sortDescriptors);
		}

		public NSArray sortDescriptors()
		{
			return Call("sortDescriptors").To<NSArray>();
		}

		public void setFilterPredicate(NSPredicate filterPredicate)
		{
			Unused.Value = Call("setFilterPredicate:", filterPredicate);
		}

		public NSPredicate filterPredicate()
		{
			return Call("filterPredicate").To<NSPredicate>();
		}

		public void setClearsFilterPredicateOnInsertion(bool flag)
		{
			Unused.Value = Call("setClearsFilterPredicateOnInsertion:", flag);
		}

		public bool clearsFilterPredicateOnInsertion()
		{
			return Call("clearsFilterPredicateOnInsertion").To<bool>();
		}

		public NSArray arrangeObjects(NSArray objects)
		{
			return Call("arrangeObjects:", objects).To<NSArray>();
		}

		public NSObject arrangedObjects()
		{
			return Call("arrangedObjects").To<NSObject>();
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

		public bool setSelectionIndexes(NSIndexSet indexes)
		{
			return Call("setSelectionIndexes:", indexes).To<bool>();
		}

		public NSIndexSet selectionIndexes()
		{
			return Call("selectionIndexes").To<NSIndexSet>();
		}

		public bool setSelectionIndex(UInt32 index)
		{
			return Call("setSelectionIndex:", index).To<bool>();
		}

		public UInt32 selectionIndex()
		{
			return Call("selectionIndex").To<UInt32>();
		}

		public bool addSelectionIndexes(NSIndexSet indexes)
		{
			return Call("addSelectionIndexes:", indexes).To<bool>();
		}

		public bool removeSelectionIndexes(NSIndexSet indexes)
		{
			return Call("removeSelectionIndexes:", indexes).To<bool>();
		}

		public bool setSelectedObjects(NSArray objects)
		{
			return Call("setSelectedObjects:", objects).To<bool>();
		}

		// skipping selectedObjects (it's declared in a base class)

		public bool addSelectedObjects(NSArray objects)
		{
			return Call("addSelectedObjects:", objects).To<bool>();
		}

		public bool removeSelectedObjects(NSArray objects)
		{
			return Call("removeSelectedObjects:", objects).To<bool>();
		}

		// skipping add: (it's declared in a base class)

		// skipping remove: (it's declared in a base class)

		public void insert(NSObject sender)
		{
			Unused.Value = Call("insert:", sender);
		}

		public bool canInsert()
		{
			return Call("canInsert").To<bool>();
		}

		public void selectNext(NSObject sender)
		{
			Unused.Value = Call("selectNext:", sender);
		}

		public void selectPrevious(NSObject sender)
		{
			Unused.Value = Call("selectPrevious:", sender);
		}

		public bool canSelectNext()
		{
			return Call("canSelectNext").To<bool>();
		}

		public bool canSelectPrevious()
		{
			return Call("canSelectPrevious").To<bool>();
		}

		// skipping addObject: (it's declared in a base class)

		public void addObjects(NSArray objects)
		{
			Unused.Value = Call("addObjects:", objects);
		}

		public void insertObjectAtArrangedObjectIndex(NSObject object_, UInt32 index)
		{
			Unused.Value = Call("insertObject:atArrangedObjectIndex:", object_, index);
		}

		public void insertObjectsAtArrangedObjectIndexes(NSArray objects, NSIndexSet indexes)
		{
			Unused.Value = Call("insertObjects:atArrangedObjectIndexes:", objects, indexes);
		}

		public void removeObjectAtArrangedObjectIndex(UInt32 index)
		{
			Unused.Value = Call("removeObjectAtArrangedObjectIndex:", index);
		}

		public void removeObjectsAtArrangedObjectIndexes(NSIndexSet indexes)
		{
			Unused.Value = Call("removeObjectsAtArrangedObjectIndexes:", indexes);
		}

		// skipping removeObject: (it's declared in a base class)

		public void removeObjects(NSArray objects)
		{
			Unused.Value = Call("removeObjects:", objects);
		}

		private static Class ms_class = new Class("NSArrayController");
	}
}
