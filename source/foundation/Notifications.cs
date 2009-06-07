// Copyright (C) 2009 Jesse Jones
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using MObjc;
using System;

namespace MCocoa
{
	/// <exclude/>
	public static partial class Externs
	{
		public static readonly NSString NSPopUpButtonWillPopUpNotification = NSString.Create("NSPopUpButtonWillPopUpNotification").Retain();
		public static readonly NSString NSAccessibilityMainWindowChangedNotification = NSString.Create("AXMainWindowChanged").Retain();
		public static readonly NSString NSAccessibilityFocusedWindowChangedNotification = NSString.Create("AXFocusedWindowChanged").Retain();
		public static readonly NSString NSAccessibilityFocusedUIElementChangedNotification = NSString.Create("AXFocusedUIElementChanged").Retain();
		public static readonly NSString NSAccessibilityApplicationActivatedNotification = NSString.Create("AXApplicationActivated").Retain();
		public static readonly NSString NSAccessibilityApplicationDeactivatedNotification = NSString.Create("AXApplicationDeactivated").Retain();
		public static readonly NSString NSAccessibilityApplicationHiddenNotification = NSString.Create("AXApplicationHidden").Retain();
		public static readonly NSString NSAccessibilityApplicationShownNotification = NSString.Create("AXApplicationShown").Retain();
		public static readonly NSString NSAccessibilityWindowCreatedNotification = NSString.Create("AXWindowCreated").Retain();
		public static readonly NSString NSAccessibilityWindowMovedNotification = NSString.Create("AXWindowMoved").Retain();
		public static readonly NSString NSAccessibilityWindowResizedNotification = NSString.Create("AXWindowResized").Retain();
		public static readonly NSString NSAccessibilityWindowMiniaturizedNotification = NSString.Create("AXWindowMiniaturized").Retain();
		public static readonly NSString NSAccessibilityWindowDeminiaturizedNotification = NSString.Create("AXWindowDeminiaturized").Retain();
		public static readonly NSString NSAccessibilityDrawerCreatedNotification = NSString.Create("AXDrawerCreated").Retain();
		public static readonly NSString NSAccessibilitySheetCreatedNotification = NSString.Create("AXSheetCreated").Retain();
		public static readonly NSString NSAccessibilityUIElementDestroyedNotification = NSString.Create("AXUIElementDestroyed").Retain();
		public static readonly NSString NSAccessibilityValueChangedNotification = NSString.Create("AXValueChanged").Retain();
		public static readonly NSString NSAccessibilityTitleChangedNotification = NSString.Create("AXTitleChanged").Retain();
		public static readonly NSString NSAccessibilityResizedNotification = NSString.Create("AXResized").Retain();
		public static readonly NSString NSAccessibilityMovedNotification = NSString.Create("AXMoved").Retain();
		public static readonly NSString NSAccessibilityCreatedNotification = NSString.Create("AXCreated").Retain();
		public static readonly NSString NSAccessibilityHelpTagCreatedNotification = NSString.Create("AXHelpTagCreated").Retain();
		public static readonly NSString NSAccessibilitySelectedTextChangedNotification = NSString.Create("AXSelectedTextChanged").Retain();
		public static readonly NSString NSAccessibilityRowCountChangedNotification = NSString.Create("AXRowCountChanged").Retain();
		public static readonly NSString NSAccessibilitySelectedChildrenChangedNotification = NSString.Create("AXSelectedChildrenChanged").Retain();
		public static readonly NSString NSAccessibilitySelectedRowsChangedNotification = NSString.Create("AXSelectedRowsChanged").Retain();
		public static readonly NSString NSAccessibilitySelectedColumnsChangedNotification = NSString.Create("AXSelectedColumnsChanged").Retain();
		public static readonly NSString NSAnimationProgressMarkNotification = NSString.Create("NSAnimationProgressMarkNotification").Retain();
		public static readonly NSString NSApplicationDidBecomeActiveNotification = NSString.Create("NSApplicationDidBecomeActiveNotification").Retain();
		public static readonly NSString NSApplicationDidHideNotification = NSString.Create("NSApplicationDidHideNotification").Retain();
		public static readonly NSString NSApplicationDidFinishLaunchingNotification = NSString.Create("NSApplicationDidFinishLaunchingNotification").Retain();
		public static readonly NSString NSApplicationDidResignActiveNotification = NSString.Create("NSApplicationDidResignActiveNotification").Retain();
		public static readonly NSString NSApplicationDidUnhideNotification = NSString.Create("NSApplicationDidUnhideNotification").Retain();
		public static readonly NSString NSApplicationDidUpdateNotification = NSString.Create("NSApplicationDidUpdateNotification").Retain();
		public static readonly NSString NSApplicationWillBecomeActiveNotification = NSString.Create("NSApplicationWillBecomeActiveNotification").Retain();
		public static readonly NSString NSApplicationWillHideNotification = NSString.Create("NSApplicationWillHideNotification").Retain();
		public static readonly NSString NSApplicationWillFinishLaunchingNotification = NSString.Create("NSApplicationWillFinishLaunchingNotification").Retain();
		public static readonly NSString NSApplicationWillResignActiveNotification = NSString.Create("NSApplicationWillResignActiveNotification").Retain();
		public static readonly NSString NSApplicationWillUnhideNotification = NSString.Create("NSApplicationWillUnhideNotification").Retain();
		public static readonly NSString NSApplicationWillUpdateNotification = NSString.Create("NSApplicationWillUpdateNotification").Retain();
		public static readonly NSString NSApplicationWillTerminateNotification = NSString.Create("NSApplicationWillTerminateNotification").Retain();
		public static readonly NSString NSApplicationDidChangeScreenParametersNotification = NSString.Create("NSApplicationDidChangeScreenParametersNotification").Retain();
		public static readonly NSString NSControlTintDidChangeNotification = NSString.Create("NSControlTintDidChangeNotification").Retain();
		public static readonly NSString NSSystemColorsDidChangeNotification = NSString.Create("NSSystemColorsDidChangeNotification").Retain();
		public static readonly NSString NSColorListDidChangeNotification = NSString.Create("NSColorListDidChangeNotification").Retain();
		public static readonly NSString NSColorPanelColorDidChangeNotification = NSString.Create("NSColorPanelColorDidChangeNotification").Retain();
		public static readonly NSString NSComboBoxWillPopUpNotification = NSString.Create("NSComboBoxWillPopUpNotification").Retain();
		public static readonly NSString NSComboBoxWillDismissNotification = NSString.Create("NSComboBoxWillDismissNotification").Retain();
		public static readonly NSString NSComboBoxSelectionDidChangeNotification = NSString.Create("NSComboBoxSelectionDidChangeNotification").Retain();
		public static readonly NSString NSComboBoxSelectionIsChangingNotification = NSString.Create("NSComboBoxSelectionIsChangingNotification").Retain();
		public static readonly NSString NSControlTextDidBeginEditingNotification = NSString.Create("NSControlTextDidBeginEditingNotification").Retain();
		public static readonly NSString NSControlTextDidEndEditingNotification = NSString.Create("NSControlTextDidEndEditingNotification").Retain();
		public static readonly NSString NSControlTextDidChangeNotification = NSString.Create("NSControlTextDidChangeNotification").Retain();
		public static readonly NSString NSDrawerWillOpenNotification = NSString.Create("NSDrawerWillOpenNotification").Retain();
		public static readonly NSString NSDrawerDidOpenNotification = NSString.Create("NSDrawerDidOpenNotification").Retain();
		public static readonly NSString NSDrawerWillCloseNotification = NSString.Create("NSDrawerWillCloseNotification").Retain();
		public static readonly NSString NSDrawerDidCloseNotification = NSString.Create("NSDrawerDidCloseNotification").Retain();
		public static readonly NSString NSContextHelpModeDidActivateNotification = NSString.Create("NSContextHelpModeDidActivateNotification").Retain();
		public static readonly NSString NSContextHelpModeDidDeactivateNotification = NSString.Create("NSContextHelpModeDidDeactivateNotification").Retain();
		public static readonly NSString NSImageRepRegistryDidChangeNotification = NSString.Create("NSImageRepRegistryDidChangeNotification").Retain();
		public static readonly NSString NSMenuWillSendActionNotification = NSString.Create("NSMenuWillSendActionNotification").Retain();
		public static readonly NSString NSMenuDidSendActionNotification = NSString.Create("NSMenuDidSendActionNotification").Retain();
		public static readonly NSString NSMenuDidAddItemNotification = NSString.Create("NSMenuDidAddItemNotification").Retain();
		public static readonly NSString NSMenuDidRemoveItemNotification = NSString.Create("NSMenuDidRemoveItemNotification").Retain();
		public static readonly NSString NSMenuDidChangeItemNotification = NSString.Create("NSMenuDidChangeItemNotification").Retain();
		public static readonly NSString NSMenuDidBeginTrackingNotification = NSString.Create("NSMenuDidBeginTrackingNotification").Retain();
		public static readonly NSString NSMenuDidEndTrackingNotification = NSString.Create("NSMenuDidEndTrackingNotification").Retain();
		public static readonly NSString NSOutlineViewSelectionDidChangeNotification = NSString.Create("NSOutlineViewSelectionDidChangeNotification").Retain();
		public static readonly NSString NSOutlineViewColumnDidMoveNotification = NSString.Create("NSOutlineViewColumnDidMoveNotification").Retain();
		public static readonly NSString NSOutlineViewColumnDidResizeNotification = NSString.Create("NSOutlineViewColumnDidResizeNotification").Retain();
		public static readonly NSString NSOutlineViewSelectionIsChangingNotification = NSString.Create("NSOutlineViewSelectionIsChangingNotification").Retain();
		public static readonly NSString NSOutlineViewItemWillExpandNotification = NSString.Create("NSOutlineViewItemWillExpandNotification").Retain();
		public static readonly NSString NSOutlineViewItemDidExpandNotification = NSString.Create("NSOutlineViewItemDidExpandNotification").Retain();
		public static readonly NSString NSOutlineViewItemWillCollapseNotification = NSString.Create("NSOutlineViewItemWillCollapseNotification").Retain();
		public static readonly NSString NSOutlineViewItemDidCollapseNotification = NSString.Create("NSOutlineViewItemDidCollapseNotification").Retain();
		public static readonly NSString NSPopUpButtonCellWillPopUpNotification = NSString.Create("NSPopUpButtonCellWillPopUpNotification").Retain();
		public static readonly NSString NSRuleEditorRowsDidChangeNotification = NSString.Create("NSRuleEditorRowsDidChangeNotification").Retain();
		public static readonly NSString NSSplitViewWillResizeSubviewsNotification = NSString.Create("NSSplitViewWillResizeSubviewsNotification").Retain();
		public static readonly NSString NSSplitViewDidResizeSubviewsNotification = NSString.Create("NSSplitViewDidResizeSubviewsNotification").Retain();
		public static readonly NSString NSTableViewSelectionDidChangeNotification = NSString.Create("NSTableViewSelectionDidChangeNotification").Retain();
		public static readonly NSString NSTableViewColumnDidMoveNotification = NSString.Create("NSTableViewColumnDidMoveNotification").Retain();
		public static readonly NSString NSTableViewColumnDidResizeNotification = NSString.Create("NSTableViewColumnDidResizeNotification").Retain();
		public static readonly NSString NSTableViewSelectionIsChangingNotification = NSString.Create("NSTableViewSelectionIsChangingNotification").Retain();
		public static readonly NSString NSTextDidBeginEditingNotification = NSString.Create("NSTextDidBeginEditingNotification").Retain();
		public static readonly NSString NSTextDidEndEditingNotification = NSString.Create("NSTextDidEndEditingNotification").Retain();
		public static readonly NSString NSTextDidChangeNotification = NSString.Create("NSTextDidChangeNotification").Retain();
		public static readonly NSString NSTextStorageWillProcessEditingNotification = NSString.Create("NSTextStorageWillProcessEditingNotification").Retain();
		public static readonly NSString NSTextStorageDidProcessEditingNotification = NSString.Create("NSTextStorageDidProcessEditingNotification").Retain();
		public static readonly NSString NSTextViewWillChangeNotifyingTextViewNotification = NSString.Create("NSTextViewWillChangeNotifyingTextViewNotification").Retain();
		public static readonly NSString NSTextViewDidChangeSelectionNotification = NSString.Create("NSTextViewDidChangeSelectionNotification").Retain();
		public static readonly NSString NSTextViewDidChangeTypingAttributesNotification = NSString.Create("NSTextViewDidChangeTypingAttributesNotification").Retain();
		public static readonly NSString NSToolbarWillAddItemNotification = NSString.Create("NSToolbarWillAddItemNotification").Retain();
		public static readonly NSString NSToolbarDidRemoveItemNotification = NSString.Create("NSToolbarDidRemoveItemNotification").Retain();
		public static readonly NSString NSViewFrameDidChangeNotification = NSString.Create("NSViewFrameDidChangeNotification").Retain();
		public static readonly NSString NSViewFocusDidChangeNotification = NSString.Create("NSViewFocusDidChangeNotification").Retain();
		public static readonly NSString NSViewBoundsDidChangeNotification = NSString.Create("NSViewBoundsDidChangeNotification").Retain();
		public static readonly NSString NSViewGlobalFrameDidChangeNotification = NSString.Create("NSViewGlobalFrameDidChangeNotification").Retain();
		public static readonly NSString NSViewDidUpdateTrackingAreasNotification = NSString.Create("NSViewDidUpdateTrackingAreasNotification").Retain();
		public static readonly NSString NSWindowDidBecomeKeyNotification = NSString.Create("NSWindowDidBecomeKeyNotification").Retain();
		public static readonly NSString NSWindowDidBecomeMainNotification = NSString.Create("NSWindowDidBecomeMainNotification").Retain();
		public static readonly NSString NSWindowDidChangeScreenNotification = NSString.Create("NSWindowDidChangeScreenNotification").Retain();
		public static readonly NSString NSWindowDidDeminiaturizeNotification = NSString.Create("NSWindowDidDeminiaturizeNotification").Retain();
		public static readonly NSString NSWindowDidExposeNotification = NSString.Create("NSWindowDidExposeNotification").Retain();
		public static readonly NSString NSWindowDidMiniaturizeNotification = NSString.Create("NSWindowDidMiniaturizeNotification").Retain();
		public static readonly NSString NSWindowDidMoveNotification = NSString.Create("NSWindowDidMoveNotification").Retain();
		public static readonly NSString NSWindowDidResignKeyNotification = NSString.Create("NSWindowDidResignKeyNotification").Retain();
		public static readonly NSString NSWindowDidResignMainNotification = NSString.Create("NSWindowDidResignMainNotification").Retain();
		public static readonly NSString NSWindowDidResizeNotification = NSString.Create("NSWindowDidResizeNotification").Retain();
		public static readonly NSString NSWindowDidUpdateNotification = NSString.Create("NSWindowDidUpdateNotification").Retain();
		public static readonly NSString NSWindowWillCloseNotification = NSString.Create("NSWindowWillCloseNotification").Retain();
		public static readonly NSString NSWindowWillMiniaturizeNotification = NSString.Create("NSWindowWillMiniaturizeNotification").Retain();
		public static readonly NSString NSWindowWillMoveNotification = NSString.Create("NSWindowWillMoveNotification").Retain();
		public static readonly NSString NSWindowWillBeginSheetNotification = NSString.Create("NSWindowWillBeginSheetNotification").Retain();
		public static readonly NSString NSWindowDidEndSheetNotification = NSString.Create("NSWindowDidEndSheetNotification").Retain();
		public static readonly NSString NSWindowDidChangeScreenProfileNotification = NSString.Create("NSWindowDidChangeScreenProfileNotification").Retain();
		public static readonly NSString NSWorkspaceDidLaunchApplicationNotification = NSString.Create("NSWorkspaceDidLaunchApplicationNotification").Retain();
		public static readonly NSString NSWorkspaceDidMountNotification = NSString.Create("NSWorkspaceDidMountNotification").Retain();
		public static readonly NSString NSWorkspaceDidPerformFileOperationNotification = NSString.Create("NSWorkspaceDidPerformFileOperationNotification").Retain();
		public static readonly NSString NSWorkspaceDidTerminateApplicationNotification = NSString.Create("NSWorkspaceDidTerminateApplicationNotification").Retain();
		public static readonly NSString NSWorkspaceDidUnmountNotification = NSString.Create("NSWorkspaceDidUnmountNotification").Retain();
		public static readonly NSString NSWorkspaceWillLaunchApplicationNotification = NSString.Create("NSWorkspaceWillLaunchApplicationNotification").Retain();
		public static readonly NSString NSWorkspaceWillPowerOffNotification = NSString.Create("NSWorkspaceWillPowerOffNotification").Retain();
		public static readonly NSString NSWorkspaceWillUnmountNotification = NSString.Create("NSWorkspaceWillUnmountNotification").Retain();
		public static readonly NSString NSWorkspaceWillSleepNotification = NSString.Create("NSWorkspaceWillSleepNotification").Retain();
		public static readonly NSString NSWorkspaceDidWakeNotification = NSString.Create("NSWorkspaceDidWakeNotification").Retain();
		public static readonly NSString NSWorkspaceSessionDidBecomeActiveNotification = NSString.Create("NSWorkspaceSessionDidBecomeActiveNotification").Retain();
		public static readonly NSString NSWorkspaceSessionDidResignActiveNotification = NSString.Create("NSWorkspaceSessionDidResignActiveNotification").Retain();
	}
}