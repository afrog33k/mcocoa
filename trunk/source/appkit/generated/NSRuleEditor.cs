// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSRuleEditor.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSRuleEditorNestingModeSingle = 0;
		public const int NSRuleEditorNestingModeList = 1;
		public const int NSRuleEditorNestingModeCompound = 2;
		public const int NSRuleEditorNestingModeSimple = 3;
	}

	public partial class Enums
	{
		public const int NSRuleEditorRowTypeSimple = 0;
		public const int NSRuleEditorRowTypeCompound = 1;
	}

	[Register]
	public partial class NSRuleEditor : NSControl
	{
		public NSRuleEditor() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSRuleEditor(IntPtr instance) : base(instance)
		{
		}

		public NSRuleEditor(Untyped instance) : base(instance)
		{
		}

		public static new NSRuleEditor alloc()
		{
			return new NSRuleEditor(ms_class.Call("alloc"));
		}

		public new NSRuleEditor retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setDelegateDelegate()
		{
			Unused.Value = Call("setDelegate:delegate");
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setFormattingStringsFilename(NSString stringsFilename)
		{
			Unused.Value = Call("setFormattingStringsFilename:", stringsFilename);
		}

		public NSString formattingStringsFilename()
		{
			return Call("formattingStringsFilename").To<NSString>();
		}

		public void setFormattingDictionary(NSDictionary dictionary)
		{
			Unused.Value = Call("setFormattingDictionary:", dictionary);
		}

		public NSDictionary formattingDictionary()
		{
			return Call("formattingDictionary").To<NSDictionary>();
		}

		public void reloadCriteria()
		{
			Unused.Value = Call("reloadCriteria");
		}

		public void setNestingMode(UInt32 mode)
		{
			Unused.Value = Call("setNestingMode:", mode);
		}

		public UInt32 nestingMode()
		{
			return Call("nestingMode").To<UInt32>();
		}

		public void setRowHeight(float height)
		{
			Unused.Value = Call("setRowHeight:", height);
		}

		public float rowHeight()
		{
			return Call("rowHeight").To<float>();
		}

		public void setEditable(bool editable)
		{
			Unused.Value = Call("setEditable:", editable);
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public void setCanRemoveAllRows(bool val)
		{
			Unused.Value = Call("setCanRemoveAllRows:", val);
		}

		public bool canRemoveAllRows()
		{
			return Call("canRemoveAllRows").To<bool>();
		}

		public NSPredicate predicate()
		{
			return Call("predicate").To<NSPredicate>();
		}

		public void reloadPredicate()
		{
			Unused.Value = Call("reloadPredicate");
		}

		public NSPredicate predicateForRow(Int32 row)
		{
			return Call("predicateForRow:", row).To<NSPredicate>();
		}

		public Int32 numberOfRows()
		{
			return Call("numberOfRows").To<Int32>();
		}

		public NSIndexSet subrowIndexesForRow(Int32 rowIndex)
		{
			return Call("subrowIndexesForRow:", rowIndex).To<NSIndexSet>();
		}

		public NSArray criteriaForRow(Int32 row)
		{
			return Call("criteriaForRow:", row).To<NSArray>();
		}

		public NSArray displayValuesForRow(Int32 row)
		{
			return Call("displayValuesForRow:", row).To<NSArray>();
		}

		public Int32 rowForDisplayValue(NSObject displayValue)
		{
			return Call("rowForDisplayValue:", displayValue).To<Int32>();
		}

		public UInt32 rowTypeForRow(Int32 rowIndex)
		{
			return Call("rowTypeForRow:", rowIndex).To<UInt32>();
		}

		public Int32 parentRowForRow(Int32 rowIndex)
		{
			return Call("parentRowForRow:", rowIndex).To<Int32>();
		}

		public void addRow(NSObject sender)
		{
			Unused.Value = Call("addRow:", sender);
		}

		public void insertRowAtIndexWithTypeAsSubrowOfRowAnimate(Int32 rowIndex, UInt32 rowType, Int32 parentRow, bool shouldAnimate)
		{
			Unused.Value = Call("insertRowAtIndex:withType:asSubrowOfRow:animate:", rowIndex, rowType, parentRow, shouldAnimate);
		}

		public void setCriteriaAndDisplayValuesForRowAtIndex(NSArray criteria, NSArray values, Int32 rowIndex)
		{
			Unused.Value = Call("setCriteria:andDisplayValues:forRowAtIndex:", criteria, values, rowIndex);
		}

		public void removeRowAtIndex(Int32 rowIndex)
		{
			Unused.Value = Call("removeRowAtIndex:", rowIndex);
		}

		public void removeRowsAtIndexesIncludeSubrows(NSIndexSet rowIndexes, bool includeSubrows)
		{
			Unused.Value = Call("removeRowsAtIndexes:includeSubrows:", rowIndexes, includeSubrows);
		}

		public NSIndexSet selectedRowIndexes()
		{
			return Call("selectedRowIndexes").To<NSIndexSet>();
		}

		public void selectRowIndexesByExtendingSelection(NSIndexSet indexes, bool extend)
		{
			Unused.Value = Call("selectRowIndexes:byExtendingSelection:", indexes, extend);
		}

		public void setRowClass(Class rowClass)
		{
			Unused.Value = Call("setRowClass:", rowClass);
		}

		public Class rowClass()
		{
			return Call("rowClass").To<Class>();
		}

		public void setRowTypeKeyPath(NSString keyPath)
		{
			Unused.Value = Call("setRowTypeKeyPath:", keyPath);
		}

		public NSString rowTypeKeyPath()
		{
			return Call("rowTypeKeyPath").To<NSString>();
		}

		public void setSubrowsKeyPath(NSString keyPath)
		{
			Unused.Value = Call("setSubrowsKeyPath:", keyPath);
		}

		public NSString subrowsKeyPath()
		{
			return Call("subrowsKeyPath").To<NSString>();
		}

		public void setCriteriaKeyPath(NSString keyPath)
		{
			Unused.Value = Call("setCriteriaKeyPath:", keyPath);
		}

		public NSString criteriaKeyPath()
		{
			return Call("criteriaKeyPath").To<NSString>();
		}

		public void setDisplayValuesKeyPath(NSString keyPath)
		{
			Unused.Value = Call("setDisplayValuesKeyPath:", keyPath);
		}

		public NSString displayValuesKeyPath()
		{
			return Call("displayValuesKeyPath").To<NSString>();
		}

		private static Class ms_class = new Class("NSRuleEditor");
	}

	public static class NSRuleEditorDelegateMethodsForNSObjectCategory
	{
		public static Int32 ruleEditorNumberOfChildrenForCriterionWithRowType(this NSObject _instance, NSRuleEditor editor, NSObject criterion, UInt32 rowType)
		{
			return _instance.Call("ruleEditor:numberOfChildrenForCriterion:withRowType:", editor, criterion, rowType).To<Int32>();
		}

		public static NSObject ruleEditorChildForCriterionWithRowType(this NSObject _instance, NSRuleEditor editor, Int32 index, NSObject criterion, UInt32 rowType)
		{
			return _instance.Call("ruleEditor:child:forCriterion:withRowType:", editor, index, criterion, rowType).To<NSObject>();
		}

		public static NSObject ruleEditorDisplayValueForCriterionInRow(this NSObject _instance, NSRuleEditor editor, NSObject criterion, Int32 row)
		{
			return _instance.Call("ruleEditor:displayValueForCriterion:inRow:", editor, criterion, row).To<NSObject>();
		}

		public static NSDictionary ruleEditorPredicatePartsForCriterionWithDisplayValueInRow(this NSObject _instance, NSRuleEditor editor, NSObject criterion, NSObject value, Int32 row)
		{
			return _instance.Call("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:", editor, criterion, value, row).To<NSDictionary>();
		}

		public static void ruleEditorRowsDidChange(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("ruleEditorRowsDidChange:", notification);
		}
	}
}
