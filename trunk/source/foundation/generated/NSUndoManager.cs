// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSUndoManager.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSUndoCloseGroupingRunLoopOrdering = 350000;
	}

	[Register]
	public partial class NSUndoManager : NSObject
	{
		public NSUndoManager() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSUndoManager(IntPtr instance) : base(instance)
		{
		}

		public NSUndoManager(Untyped instance) : base(instance)
		{
		}

		public static new NSUndoManager alloc()
		{
			return new NSUndoManager(ms_class.Call("alloc"));
		}

		public new NSUndoManager retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void beginUndoGrouping()
		{
			Unused.Value = Call("beginUndoGrouping");
		}

		public void endUndoGrouping()
		{
			Unused.Value = Call("endUndoGrouping");
		}

		public Int32 groupingLevel()
		{
			return Call("groupingLevel").To<Int32>();
		}

		public void disableUndoRegistration()
		{
			Unused.Value = Call("disableUndoRegistration");
		}

		public void enableUndoRegistration()
		{
			Unused.Value = Call("enableUndoRegistration");
		}

		public bool isUndoRegistrationEnabled()
		{
			return Call("isUndoRegistrationEnabled").To<bool>();
		}

		public bool groupsByEvent()
		{
			return Call("groupsByEvent").To<bool>();
		}

		public void setGroupsByEvent(bool groupsByEvent)
		{
			Unused.Value = Call("setGroupsByEvent:", groupsByEvent);
		}

		public void setLevelsOfUndo(UInt32 levels)
		{
			Unused.Value = Call("setLevelsOfUndo:", levels);
		}

		public UInt32 levelsOfUndo()
		{
			return Call("levelsOfUndo").To<UInt32>();
		}

		public void setRunLoopModes(NSArray runLoopModes)
		{
			Unused.Value = Call("setRunLoopModes:", runLoopModes);
		}

		public NSArray runLoopModes()
		{
			return Call("runLoopModes").To<NSArray>();
		}

		public void undo()
		{
			Unused.Value = Call("undo");
		}

		public void redo()
		{
			Unused.Value = Call("redo");
		}

		public void undoNestedGroup()
		{
			Unused.Value = Call("undoNestedGroup");
		}

		public bool canUndo()
		{
			return Call("canUndo").To<bool>();
		}

		public bool canRedo()
		{
			return Call("canRedo").To<bool>();
		}

		public bool isUndoing()
		{
			return Call("isUndoing").To<bool>();
		}

		public bool isRedoing()
		{
			return Call("isRedoing").To<bool>();
		}

		public void removeAllActions()
		{
			Unused.Value = Call("removeAllActions");
		}

		public void removeAllActionsWithTarget(NSObject target)
		{
			Unused.Value = Call("removeAllActionsWithTarget:", target);
		}

		public void registerUndoWithTargetSelectorObject(NSObject target, Selector selector, NSObject anObject)
		{
			Unused.Value = Call("registerUndoWithTarget:selector:object:", target, selector, anObject);
		}

		public NSObject prepareWithInvocationTarget(NSObject target)
		{
			return Call("prepareWithInvocationTarget:", target).To<NSObject>();
		}

		public NSString undoActionName()
		{
			return Call("undoActionName").To<NSString>();
		}

		public NSString redoActionName()
		{
			return Call("redoActionName").To<NSString>();
		}

		public void setActionName(NSString actionName)
		{
			Unused.Value = Call("setActionName:", actionName);
		}

		public NSString undoMenuItemTitle()
		{
			return Call("undoMenuItemTitle").To<NSString>();
		}

		public NSString redoMenuItemTitle()
		{
			return Call("redoMenuItemTitle").To<NSString>();
		}

		public NSString undoMenuTitleForUndoActionName(NSString actionName)
		{
			return Call("undoMenuTitleForUndoActionName:", actionName).To<NSString>();
		}

		public NSString redoMenuTitleForUndoActionName(NSString actionName)
		{
			return Call("redoMenuTitleForUndoActionName:", actionName).To<NSString>();
		}

		private static Class ms_class = new Class("NSUndoManager");
	}
}
