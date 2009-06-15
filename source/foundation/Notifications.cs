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
		public static readonly LazyString NSPopUpButtonWillPopUpNotification = new LazyString("NSPopUpButtonWillPopUpNotification");
		public static readonly LazyString NSAccessibilityMainWindowChangedNotification = new LazyString("AXMainWindowChanged");
		public static readonly LazyString NSAccessibilityFocusedWindowChangedNotification = new LazyString("AXFocusedWindowChanged");
		public static readonly LazyString NSAccessibilityFocusedUIElementChangedNotification = new LazyString("AXFocusedUIElementChanged");
		public static readonly LazyString NSAccessibilityApplicationActivatedNotification = new LazyString("AXApplicationActivated");
		public static readonly LazyString NSAccessibilityApplicationDeactivatedNotification = new LazyString("AXApplicationDeactivated");
		public static readonly LazyString NSAccessibilityApplicationHiddenNotification = new LazyString("AXApplicationHidden");
		public static readonly LazyString NSAccessibilityApplicationShownNotification = new LazyString("AXApplicationShown");
		public static readonly LazyString NSAccessibilityWindowCreatedNotification = new LazyString("AXWindowCreated");
		public static readonly LazyString NSAccessibilityWindowMovedNotification = new LazyString("AXWindowMoved");
		public static readonly LazyString NSAccessibilityWindowResizedNotification = new LazyString("AXWindowResized");
		public static readonly LazyString NSAccessibilityWindowMiniaturizedNotification = new LazyString("AXWindowMiniaturized");
		public static readonly LazyString NSAccessibilityWindowDeminiaturizedNotification = new LazyString("AXWindowDeminiaturized");
		public static readonly LazyString NSAccessibilityDrawerCreatedNotification = new LazyString("AXDrawerCreated");
		public static readonly LazyString NSAccessibilitySheetCreatedNotification = new LazyString("AXSheetCreated");
		public static readonly LazyString NSAccessibilityUIElementDestroyedNotification = new LazyString("AXUIElementDestroyed");
		public static readonly LazyString NSAccessibilityValueChangedNotification = new LazyString("AXValueChanged");
		public static readonly LazyString NSAccessibilityTitleChangedNotification = new LazyString("AXTitleChanged");
		public static readonly LazyString NSAccessibilityResizedNotification = new LazyString("AXResized");
		public static readonly LazyString NSAccessibilityMovedNotification = new LazyString("AXMoved");
		public static readonly LazyString NSAccessibilityCreatedNotification = new LazyString("AXCreated");
		public static readonly LazyString NSAccessibilityHelpTagCreatedNotification = new LazyString("AXHelpTagCreated");
		public static readonly LazyString NSAccessibilitySelectedTextChangedNotification = new LazyString("AXSelectedTextChanged");
		public static readonly LazyString NSAccessibilityRowCountChangedNotification = new LazyString("AXRowCountChanged");
		public static readonly LazyString NSAccessibilitySelectedChildrenChangedNotification = new LazyString("AXSelectedChildrenChanged");
		public static readonly LazyString NSAccessibilitySelectedRowsChangedNotification = new LazyString("AXSelectedRowsChanged");
		public static readonly LazyString NSAccessibilitySelectedColumnsChangedNotification = new LazyString("AXSelectedColumnsChanged");
		public static readonly LazyString NSAnimationProgressMarkNotification = new LazyString("NSAnimationProgressMarkNotification");
		public static readonly LazyString NSApplicationDidBecomeActiveNotification = new LazyString("NSApplicationDidBecomeActiveNotification");
		public static readonly LazyString NSApplicationDidHideNotification = new LazyString("NSApplicationDidHideNotification");
		public static readonly LazyString NSApplicationDidFinishLaunchingNotification = new LazyString("NSApplicationDidFinishLaunchingNotification");
		public static readonly LazyString NSApplicationDidResignActiveNotification = new LazyString("NSApplicationDidResignActiveNotification");
		public static readonly LazyString NSApplicationDidUnhideNotification = new LazyString("NSApplicationDidUnhideNotification");
		public static readonly LazyString NSApplicationDidUpdateNotification = new LazyString("NSApplicationDidUpdateNotification");
		public static readonly LazyString NSApplicationWillBecomeActiveNotification = new LazyString("NSApplicationWillBecomeActiveNotification");
		public static readonly LazyString NSApplicationWillHideNotification = new LazyString("NSApplicationWillHideNotification");
		public static readonly LazyString NSApplicationWillFinishLaunchingNotification = new LazyString("NSApplicationWillFinishLaunchingNotification");
		public static readonly LazyString NSApplicationWillResignActiveNotification = new LazyString("NSApplicationWillResignActiveNotification");
		public static readonly LazyString NSApplicationWillUnhideNotification = new LazyString("NSApplicationWillUnhideNotification");
		public static readonly LazyString NSApplicationWillUpdateNotification = new LazyString("NSApplicationWillUpdateNotification");
		public static readonly LazyString NSApplicationWillTerminateNotification = new LazyString("NSApplicationWillTerminateNotification");
		public static readonly LazyString NSApplicationDidChangeScreenParametersNotification = new LazyString("NSApplicationDidChangeScreenParametersNotification");
		public static readonly LazyString NSControlTintDidChangeNotification = new LazyString("NSControlTintDidChangeNotification");
		public static readonly LazyString NSSystemColorsDidChangeNotification = new LazyString("NSSystemColorsDidChangeNotification");
		public static readonly LazyString NSColorListDidChangeNotification = new LazyString("NSColorListDidChangeNotification");
		public static readonly LazyString NSColorPanelColorDidChangeNotification = new LazyString("NSColorPanelColorDidChangeNotification");
		public static readonly LazyString NSComboBoxWillPopUpNotification = new LazyString("NSComboBoxWillPopUpNotification");
		public static readonly LazyString NSComboBoxWillDismissNotification = new LazyString("NSComboBoxWillDismissNotification");
		public static readonly LazyString NSComboBoxSelectionDidChangeNotification = new LazyString("NSComboBoxSelectionDidChangeNotification");
		public static readonly LazyString NSComboBoxSelectionIsChangingNotification = new LazyString("NSComboBoxSelectionIsChangingNotification");
		public static readonly LazyString NSControlTextDidBeginEditingNotification = new LazyString("NSControlTextDidBeginEditingNotification");
		public static readonly LazyString NSControlTextDidEndEditingNotification = new LazyString("NSControlTextDidEndEditingNotification");
		public static readonly LazyString NSControlTextDidChangeNotification = new LazyString("NSControlTextDidChangeNotification");
		public static readonly LazyString NSDrawerWillOpenNotification = new LazyString("NSDrawerWillOpenNotification");
		public static readonly LazyString NSDrawerDidOpenNotification = new LazyString("NSDrawerDidOpenNotification");
		public static readonly LazyString NSDrawerWillCloseNotification = new LazyString("NSDrawerWillCloseNotification");
		public static readonly LazyString NSDrawerDidCloseNotification = new LazyString("NSDrawerDidCloseNotification");
		public static readonly LazyString NSContextHelpModeDidActivateNotification = new LazyString("NSContextHelpModeDidActivateNotification");
		public static readonly LazyString NSContextHelpModeDidDeactivateNotification = new LazyString("NSContextHelpModeDidDeactivateNotification");
		public static readonly LazyString NSImageRepRegistryDidChangeNotification = new LazyString("NSImageRepRegistryDidChangeNotification");
		public static readonly LazyString NSMenuWillSendActionNotification = new LazyString("NSMenuWillSendActionNotification");
		public static readonly LazyString NSMenuDidSendActionNotification = new LazyString("NSMenuDidSendActionNotification");
		public static readonly LazyString NSMenuDidAddItemNotification = new LazyString("NSMenuDidAddItemNotification");
		public static readonly LazyString NSMenuDidRemoveItemNotification = new LazyString("NSMenuDidRemoveItemNotification");
		public static readonly LazyString NSMenuDidChangeItemNotification = new LazyString("NSMenuDidChangeItemNotification");
		public static readonly LazyString NSMenuDidBeginTrackingNotification = new LazyString("NSMenuDidBeginTrackingNotification");
		public static readonly LazyString NSMenuDidEndTrackingNotification = new LazyString("NSMenuDidEndTrackingNotification");
		public static readonly LazyString NSOutlineViewSelectionDidChangeNotification = new LazyString("NSOutlineViewSelectionDidChangeNotification");
		public static readonly LazyString NSOutlineViewColumnDidMoveNotification = new LazyString("NSOutlineViewColumnDidMoveNotification");
		public static readonly LazyString NSOutlineViewColumnDidResizeNotification = new LazyString("NSOutlineViewColumnDidResizeNotification");
		public static readonly LazyString NSOutlineViewSelectionIsChangingNotification = new LazyString("NSOutlineViewSelectionIsChangingNotification");
		public static readonly LazyString NSOutlineViewItemWillExpandNotification = new LazyString("NSOutlineViewItemWillExpandNotification");
		public static readonly LazyString NSOutlineViewItemDidExpandNotification = new LazyString("NSOutlineViewItemDidExpandNotification");
		public static readonly LazyString NSOutlineViewItemWillCollapseNotification = new LazyString("NSOutlineViewItemWillCollapseNotification");
		public static readonly LazyString NSOutlineViewItemDidCollapseNotification = new LazyString("NSOutlineViewItemDidCollapseNotification");
		public static readonly LazyString NSPopUpButtonCellWillPopUpNotification = new LazyString("NSPopUpButtonCellWillPopUpNotification");
		public static readonly LazyString NSRuleEditorRowsDidChangeNotification = new LazyString("NSRuleEditorRowsDidChangeNotification");
		public static readonly LazyString NSSplitViewWillResizeSubviewsNotification = new LazyString("NSSplitViewWillResizeSubviewsNotification");
		public static readonly LazyString NSSplitViewDidResizeSubviewsNotification = new LazyString("NSSplitViewDidResizeSubviewsNotification");
		public static readonly LazyString NSTableViewSelectionDidChangeNotification = new LazyString("NSTableViewSelectionDidChangeNotification");
		public static readonly LazyString NSTableViewColumnDidMoveNotification = new LazyString("NSTableViewColumnDidMoveNotification");
		public static readonly LazyString NSTableViewColumnDidResizeNotification = new LazyString("NSTableViewColumnDidResizeNotification");
		public static readonly LazyString NSTableViewSelectionIsChangingNotification = new LazyString("NSTableViewSelectionIsChangingNotification");
		public static readonly LazyString NSTextDidBeginEditingNotification = new LazyString("NSTextDidBeginEditingNotification");
		public static readonly LazyString NSTextDidEndEditingNotification = new LazyString("NSTextDidEndEditingNotification");
		public static readonly LazyString NSTextDidChangeNotification = new LazyString("NSTextDidChangeNotification");
		public static readonly LazyString NSTextStorageWillProcessEditingNotification = new LazyString("NSTextStorageWillProcessEditingNotification");
		public static readonly LazyString NSTextStorageDidProcessEditingNotification = new LazyString("NSTextStorageDidProcessEditingNotification");
		public static readonly LazyString NSTextViewWillChangeNotifyingTextViewNotification = new LazyString("NSTextViewWillChangeNotifyingTextViewNotification");
		public static readonly LazyString NSTextViewDidChangeSelectionNotification = new LazyString("NSTextViewDidChangeSelectionNotification");
		public static readonly LazyString NSTextViewDidChangeTypingAttributesNotification = new LazyString("NSTextViewDidChangeTypingAttributesNotification");
		public static readonly LazyString NSToolbarWillAddItemNotification = new LazyString("NSToolbarWillAddItemNotification");
		public static readonly LazyString NSToolbarDidRemoveItemNotification = new LazyString("NSToolbarDidRemoveItemNotification");
		public static readonly LazyString NSViewFrameDidChangeNotification = new LazyString("NSViewFrameDidChangeNotification");
		public static readonly LazyString NSViewFocusDidChangeNotification = new LazyString("NSViewFocusDidChangeNotification");
		public static readonly LazyString NSViewBoundsDidChangeNotification = new LazyString("NSViewBoundsDidChangeNotification");
		public static readonly LazyString NSViewGlobalFrameDidChangeNotification = new LazyString("NSViewGlobalFrameDidChangeNotification");
		public static readonly LazyString NSViewDidUpdateTrackingAreasNotification = new LazyString("NSViewDidUpdateTrackingAreasNotification");
		public static readonly LazyString NSWindowDidBecomeKeyNotification = new LazyString("NSWindowDidBecomeKeyNotification");
		public static readonly LazyString NSWindowDidBecomeMainNotification = new LazyString("NSWindowDidBecomeMainNotification");
		public static readonly LazyString NSWindowDidChangeScreenNotification = new LazyString("NSWindowDidChangeScreenNotification");
		public static readonly LazyString NSWindowDidDeminiaturizeNotification = new LazyString("NSWindowDidDeminiaturizeNotification");
		public static readonly LazyString NSWindowDidExposeNotification = new LazyString("NSWindowDidExposeNotification");
		public static readonly LazyString NSWindowDidMiniaturizeNotification = new LazyString("NSWindowDidMiniaturizeNotification");
		public static readonly LazyString NSWindowDidMoveNotification = new LazyString("NSWindowDidMoveNotification");
		public static readonly LazyString NSWindowDidResignKeyNotification = new LazyString("NSWindowDidResignKeyNotification");
		public static readonly LazyString NSWindowDidResignMainNotification = new LazyString("NSWindowDidResignMainNotification");
		public static readonly LazyString NSWindowDidResizeNotification = new LazyString("NSWindowDidResizeNotification");
		public static readonly LazyString NSWindowDidUpdateNotification = new LazyString("NSWindowDidUpdateNotification");
		public static readonly LazyString NSWindowWillCloseNotification = new LazyString("NSWindowWillCloseNotification");
		public static readonly LazyString NSWindowWillMiniaturizeNotification = new LazyString("NSWindowWillMiniaturizeNotification");
		public static readonly LazyString NSWindowWillMoveNotification = new LazyString("NSWindowWillMoveNotification");
		public static readonly LazyString NSWindowWillBeginSheetNotification = new LazyString("NSWindowWillBeginSheetNotification");
		public static readonly LazyString NSWindowDidEndSheetNotification = new LazyString("NSWindowDidEndSheetNotification");
		public static readonly LazyString NSWindowDidChangeScreenProfileNotification = new LazyString("NSWindowDidChangeScreenProfileNotification");
		public static readonly LazyString NSWorkspaceDidLaunchApplicationNotification = new LazyString("NSWorkspaceDidLaunchApplicationNotification");
		public static readonly LazyString NSWorkspaceDidMountNotification = new LazyString("NSWorkspaceDidMountNotification");
		public static readonly LazyString NSWorkspaceDidPerformFileOperationNotification = new LazyString("NSWorkspaceDidPerformFileOperationNotification");
		public static readonly LazyString NSWorkspaceDidTerminateApplicationNotification = new LazyString("NSWorkspaceDidTerminateApplicationNotification");
		public static readonly LazyString NSWorkspaceDidUnmountNotification = new LazyString("NSWorkspaceDidUnmountNotification");
		public static readonly LazyString NSWorkspaceWillLaunchApplicationNotification = new LazyString("NSWorkspaceWillLaunchApplicationNotification");
		public static readonly LazyString NSWorkspaceWillPowerOffNotification = new LazyString("NSWorkspaceWillPowerOffNotification");
		public static readonly LazyString NSWorkspaceWillUnmountNotification = new LazyString("NSWorkspaceWillUnmountNotification");
		public static readonly LazyString NSWorkspaceWillSleepNotification = new LazyString("NSWorkspaceWillSleepNotification");
		public static readonly LazyString NSWorkspaceDidWakeNotification = new LazyString("NSWorkspaceDidWakeNotification");
		public static readonly LazyString NSWorkspaceSessionDidBecomeActiveNotification = new LazyString("NSWorkspaceSessionDidBecomeActiveNotification");
		public static readonly LazyString NSWorkspaceSessionDidResignActiveNotification = new LazyString("NSWorkspaceSessionDidResignActiveNotification");
	}
}