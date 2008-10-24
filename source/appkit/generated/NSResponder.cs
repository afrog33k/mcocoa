// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSResponder.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSResponder : NSObject
	{
		public NSResponder() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSResponder(IntPtr instance) : base(instance)
		{
		}

		public NSResponder(Untyped instance) : base(instance)
		{
		}

		public static new NSResponder alloc()
		{
			return new NSResponder(ms_class.Call("alloc"));
		}

		public new NSResponder retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSResponder nextResponder()
		{
			return Call("nextResponder").To<NSResponder>();
		}

		public void setNextResponder(NSResponder aResponder)
		{
			Unused.Value = Call("setNextResponder:", aResponder);
		}

		public bool tryToPerformWith(Selector anAction, NSObject anObject)
		{
			return Call("tryToPerform:with:", anAction, anObject).To<bool>();
		}

		public bool performKeyEquivalent(NSEvent theEvent)
		{
			return Call("performKeyEquivalent:", theEvent).To<bool>();
		}

		public NSObject validRequestorForSendTypeReturnType(NSString sendType, NSString returnType)
		{
			return Call("validRequestorForSendType:returnType:", sendType, returnType).To<NSObject>();
		}

		public void mouseDown(NSEvent theEvent)
		{
			Unused.Value = Call("mouseDown:", theEvent);
		}

		public void rightMouseDown(NSEvent theEvent)
		{
			Unused.Value = Call("rightMouseDown:", theEvent);
		}

		public void otherMouseDown(NSEvent theEvent)
		{
			Unused.Value = Call("otherMouseDown:", theEvent);
		}

		public void mouseUp(NSEvent theEvent)
		{
			Unused.Value = Call("mouseUp:", theEvent);
		}

		public void rightMouseUp(NSEvent theEvent)
		{
			Unused.Value = Call("rightMouseUp:", theEvent);
		}

		public void otherMouseUp(NSEvent theEvent)
		{
			Unused.Value = Call("otherMouseUp:", theEvent);
		}

		public void mouseMoved(NSEvent theEvent)
		{
			Unused.Value = Call("mouseMoved:", theEvent);
		}

		public void mouseDragged(NSEvent theEvent)
		{
			Unused.Value = Call("mouseDragged:", theEvent);
		}

		public void scrollWheel(NSEvent theEvent)
		{
			Unused.Value = Call("scrollWheel:", theEvent);
		}

		public void rightMouseDragged(NSEvent theEvent)
		{
			Unused.Value = Call("rightMouseDragged:", theEvent);
		}

		public void otherMouseDragged(NSEvent theEvent)
		{
			Unused.Value = Call("otherMouseDragged:", theEvent);
		}

		public void mouseEntered(NSEvent theEvent)
		{
			Unused.Value = Call("mouseEntered:", theEvent);
		}

		public void mouseExited(NSEvent theEvent)
		{
			Unused.Value = Call("mouseExited:", theEvent);
		}

		public void keyDown(NSEvent theEvent)
		{
			Unused.Value = Call("keyDown:", theEvent);
		}

		public void keyUp(NSEvent theEvent)
		{
			Unused.Value = Call("keyUp:", theEvent);
		}

		public void flagsChanged(NSEvent theEvent)
		{
			Unused.Value = Call("flagsChanged:", theEvent);
		}

		public void tabletPoint(NSEvent theEvent)
		{
			Unused.Value = Call("tabletPoint:", theEvent);
		}

		public void tabletProximity(NSEvent theEvent)
		{
			Unused.Value = Call("tabletProximity:", theEvent);
		}

		public void cursorUpdate(NSEvent event_)
		{
			Unused.Value = Call("cursorUpdate:", event_);
		}

		public void noResponderFor(Selector eventSelector)
		{
			Unused.Value = Call("noResponderFor:", eventSelector);
		}

		public bool acceptsFirstResponder()
		{
			return Call("acceptsFirstResponder").To<bool>();
		}

		public bool becomeFirstResponder()
		{
			return Call("becomeFirstResponder").To<bool>();
		}

		public bool resignFirstResponder()
		{
			return Call("resignFirstResponder").To<bool>();
		}

		public void interpretKeyEvents(NSArray eventArray)
		{
			Unused.Value = Call("interpretKeyEvents:", eventArray);
		}

		public void flushBufferedKeyEvents()
		{
			Unused.Value = Call("flushBufferedKeyEvents");
		}

		public void setMenu(NSMenu menu)
		{
			Unused.Value = Call("setMenu:", menu);
		}

		public NSMenu menu()
		{
			return Call("menu").To<NSMenu>();
		}

		public void showContextHelp(NSObject sender)
		{
			Unused.Value = Call("showContextHelp:", sender);
		}

		public void helpRequested(NSEvent eventPtr)
		{
			Unused.Value = Call("helpRequested:", eventPtr);
		}

		public bool shouldBeTreatedAsInkEvent(NSEvent theEvent)
		{
			return Call("shouldBeTreatedAsInkEvent:", theEvent).To<bool>();
		}

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

		private static Class ms_class = new Class("NSResponder");
	}

	public static class NSKeyboardUIForNSResponderCategory
	{
		public static bool performMnemonic(this NSResponder _instance, NSString theString)
		{
			return _instance.Call("performMnemonic:", theString).To<bool>();
		}
	}

	public static class NSStandardKeyBindingMethodsForNSResponderCategory
	{
		public static void insertText(this NSResponder _instance, NSObject insertString)
		{
			Unused.Value = _instance.Call("insertText:", insertString);
		}

		public static void doCommandBySelector(this NSResponder _instance, Selector aSelector)
		{
			Unused.Value = _instance.Call("doCommandBySelector:", aSelector);
		}

		public static void moveForward(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveForward:", sender);
		}

		public static void moveRight(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveRight:", sender);
		}

		public static void moveBackward(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveBackward:", sender);
		}

		public static void moveLeft(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveLeft:", sender);
		}

		public static void moveUp(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveUp:", sender);
		}

		public static void moveDown(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveDown:", sender);
		}

		public static void moveWordForward(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveWordForward:", sender);
		}

		public static void moveWordBackward(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveWordBackward:", sender);
		}

		public static void moveToBeginningOfLine(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveToBeginningOfLine:", sender);
		}

		public static void moveToEndOfLine(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveToEndOfLine:", sender);
		}

		public static void moveToBeginningOfParagraph(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveToBeginningOfParagraph:", sender);
		}

		public static void moveToEndOfParagraph(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveToEndOfParagraph:", sender);
		}

		public static void moveToEndOfDocument(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveToEndOfDocument:", sender);
		}

		public static void moveToBeginningOfDocument(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveToBeginningOfDocument:", sender);
		}

		public static void pageDown(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("pageDown:", sender);
		}

		public static void pageUp(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("pageUp:", sender);
		}

		public static void centerSelectionInVisibleArea(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("centerSelectionInVisibleArea:", sender);
		}

		public static void moveBackwardAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveBackwardAndModifySelection:", sender);
		}

		public static void moveForwardAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveForwardAndModifySelection:", sender);
		}

		public static void moveWordForwardAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveWordForwardAndModifySelection:", sender);
		}

		public static void moveWordBackwardAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveWordBackwardAndModifySelection:", sender);
		}

		public static void moveUpAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveUpAndModifySelection:", sender);
		}

		public static void moveDownAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveDownAndModifySelection:", sender);
		}

		public static void moveWordRight(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveWordRight:", sender);
		}

		public static void moveWordLeft(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveWordLeft:", sender);
		}

		public static void moveRightAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveRightAndModifySelection:", sender);
		}

		public static void moveLeftAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveLeftAndModifySelection:", sender);
		}

		public static void moveWordRightAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveWordRightAndModifySelection:", sender);
		}

		public static void moveWordLeftAndModifySelection(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("moveWordLeftAndModifySelection:", sender);
		}

		public static void scrollPageUp(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("scrollPageUp:", sender);
		}

		public static void scrollPageDown(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("scrollPageDown:", sender);
		}

		public static void scrollLineUp(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("scrollLineUp:", sender);
		}

		public static void scrollLineDown(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("scrollLineDown:", sender);
		}

		public static void transpose(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("transpose:", sender);
		}

		public static void transposeWords(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("transposeWords:", sender);
		}

		public static void selectAll(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("selectAll:", sender);
		}

		public static void selectParagraph(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("selectParagraph:", sender);
		}

		public static void selectLine(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("selectLine:", sender);
		}

		public static void selectWord(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("selectWord:", sender);
		}

		public static void indent(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("indent:", sender);
		}

		public static void insertTab(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("insertTab:", sender);
		}

		public static void insertBacktab(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("insertBacktab:", sender);
		}

		public static void insertNewline(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("insertNewline:", sender);
		}

		public static void insertParagraphSeparator(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("insertParagraphSeparator:", sender);
		}

		public static void insertNewlineIgnoringFieldEditor(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("insertNewlineIgnoringFieldEditor:", sender);
		}

		public static void insertTabIgnoringFieldEditor(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("insertTabIgnoringFieldEditor:", sender);
		}

		public static void insertLineBreak(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("insertLineBreak:", sender);
		}

		public static void insertContainerBreak(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("insertContainerBreak:", sender);
		}

		public static void changeCaseOfLetter(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("changeCaseOfLetter:", sender);
		}

		public static void uppercaseWord(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("uppercaseWord:", sender);
		}

		public static void lowercaseWord(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("lowercaseWord:", sender);
		}

		public static void capitalizeWord(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("capitalizeWord:", sender);
		}

		public static void deleteForward(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteForward:", sender);
		}

		public static void deleteBackward(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteBackward:", sender);
		}

		public static void deleteBackwardByDecomposingPreviousCharacter(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteBackwardByDecomposingPreviousCharacter:", sender);
		}

		public static void deleteWordForward(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteWordForward:", sender);
		}

		public static void deleteWordBackward(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteWordBackward:", sender);
		}

		public static void deleteToBeginningOfLine(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteToBeginningOfLine:", sender);
		}

		public static void deleteToEndOfLine(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteToEndOfLine:", sender);
		}

		public static void deleteToBeginningOfParagraph(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteToBeginningOfParagraph:", sender);
		}

		public static void deleteToEndOfParagraph(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteToEndOfParagraph:", sender);
		}

		public static void yank(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("yank:", sender);
		}

		public static void complete(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("complete:", sender);
		}

		public static void setMark(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("setMark:", sender);
		}

		public static void deleteToMark(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("deleteToMark:", sender);
		}

		public static void selectToMark(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("selectToMark:", sender);
		}

		public static void swapWithMark(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("swapWithMark:", sender);
		}

		public static void cancelOperation(this NSResponder _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("cancelOperation:", sender);
		}
	}

	public static class NSUndoSupportForNSResponderCategory
	{
		public static NSUndoManager undoManager(this NSResponder _instance)
		{
			return _instance.Call("undoManager").To<NSUndoManager>();
		}
	}

	public static class NSErrorPresentationForNSResponderCategory
	{
		public static void presentErrorModalForWindowDelegateDidPresentSelectorContextInfo(this NSResponder _instance, NSError error, NSWindow window, NSObject delegate_, Selector didPresentSelector, IntPtr contextInfo)
		{
			Unused.Value = _instance.Call("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:", error, window, delegate_, didPresentSelector, contextInfo);
		}

		public static bool presentError(this NSResponder _instance, NSError error)
		{
			return _instance.Call("presentError:", error).To<bool>();
		}

		public static NSError willPresentError(this NSResponder _instance, NSError error)
		{
			return _instance.Call("willPresentError:", error).To<NSError>();
		}
	}
}
