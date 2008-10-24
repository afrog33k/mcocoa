// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextView.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSSelectByCharacter = 0;
		public const int NSSelectByWord = 1;
		public const int NSSelectByParagraph = 2;
	}

	public partial class Enums
	{
		public const int NSSelectionAffinityUpstream = 0;
		public const int NSSelectionAffinityDownstream = 1;
	}

	public partial class Enums
	{
		public const int NSFindPanelActionShowFindPanel = 1;
		public const int NSFindPanelActionNext = 2;
		public const int NSFindPanelActionPrevious = 3;
		public const int NSFindPanelActionReplaceAll = 4;
		public const int NSFindPanelActionReplace = 5;
		public const int NSFindPanelActionReplaceAndFind = 6;
		public const int NSFindPanelActionSetFindString = 7;
		public const int NSFindPanelActionReplaceAllInSelection = 8;
		public const int NSFindPanelActionSelectAll = 9;
		public const int NSFindPanelActionSelectAllInSelection = 10;
	}

	public partial class Enums
	{
		public const int NSFindPanelSubstringMatchTypeContains = 0;
		public const int NSFindPanelSubstringMatchTypeStartsWith = 1;
		public const int NSFindPanelSubstringMatchTypeFullWord = 2;
		public const int NSFindPanelSubstringMatchTypeEndsWith = 3;
	}

	[Register]
	public partial class NSTextView : NSText
	{
		public NSTextView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextView(IntPtr instance) : base(instance)
		{
		}

		public NSTextView(Untyped instance) : base(instance)
		{
		}

		public static new NSTextView alloc()
		{
			return new NSTextView(ms_class.Call("alloc"));
		}

		public new NSTextView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithFrameTextContainer(NSRect frameRect, NSTextContainer container)
		{
			return Call("initWithFrame:textContainer:", frameRect, container).To<NSObject>();
		}

		// skipping initWithFrame: (it's declared in a base class)

		public NSTextContainer textContainer()
		{
			return Call("textContainer").To<NSTextContainer>();
		}

		public void setTextContainer(NSTextContainer container)
		{
			Unused.Value = Call("setTextContainer:", container);
		}

		public void replaceTextContainer(NSTextContainer newContainer)
		{
			Unused.Value = Call("replaceTextContainer:", newContainer);
		}

		public void setTextContainerInset(NSSize inset)
		{
			Unused.Value = Call("setTextContainerInset:", inset);
		}

		public NSSize textContainerInset()
		{
			return Call("textContainerInset").To<NSSize>();
		}

		public NSPoint textContainerOrigin()
		{
			return Call("textContainerOrigin").To<NSPoint>();
		}

		public void invalidateTextContainerOrigin()
		{
			Unused.Value = Call("invalidateTextContainerOrigin");
		}

		public NSLayoutManager layoutManager()
		{
			return Call("layoutManager").To<NSLayoutManager>();
		}

		public NSTextStorage textStorage()
		{
			return Call("textStorage").To<NSTextStorage>();
		}

		public void insertText(NSObject insertString)
		{
			Unused.Value = Call("insertText:", insertString);
		}

		public void setConstrainedFrameSize(NSSize desiredSize)
		{
			Unused.Value = Call("setConstrainedFrameSize:", desiredSize);
		}

		public void setAlignmentRange(UInt32 alignment, NSRange range)
		{
			Unused.Value = Call("setAlignment:range:", alignment, range);
		}

		public void setBaseWritingDirectionRange(Int32 writingDirection, NSRange range)
		{
			Unused.Value = Call("setBaseWritingDirection:range:", writingDirection, range);
		}

		public void turnOffKerning(NSObject sender)
		{
			Unused.Value = Call("turnOffKerning:", sender);
		}

		public void tightenKerning(NSObject sender)
		{
			Unused.Value = Call("tightenKerning:", sender);
		}

		public void loosenKerning(NSObject sender)
		{
			Unused.Value = Call("loosenKerning:", sender);
		}

		public void useStandardKerning(NSObject sender)
		{
			Unused.Value = Call("useStandardKerning:", sender);
		}

		public void turnOffLigatures(NSObject sender)
		{
			Unused.Value = Call("turnOffLigatures:", sender);
		}

		public void useStandardLigatures(NSObject sender)
		{
			Unused.Value = Call("useStandardLigatures:", sender);
		}

		public void useAllLigatures(NSObject sender)
		{
			Unused.Value = Call("useAllLigatures:", sender);
		}

		public void raiseBaseline(NSObject sender)
		{
			Unused.Value = Call("raiseBaseline:", sender);
		}

		public void lowerBaseline(NSObject sender)
		{
			Unused.Value = Call("lowerBaseline:", sender);
		}

		public void toggleTraditionalCharacterShape(NSObject sender)
		{
			Unused.Value = Call("toggleTraditionalCharacterShape:", sender);
		}

		public void outline(NSObject sender)
		{
			Unused.Value = Call("outline:", sender);
		}

		public void performFindPanelAction(NSObject sender)
		{
			Unused.Value = Call("performFindPanelAction:", sender);
		}

		public void alignJustified(NSObject sender)
		{
			Unused.Value = Call("alignJustified:", sender);
		}

		public void changeColor(NSObject sender)
		{
			Unused.Value = Call("changeColor:", sender);
		}

		public void changeAttributes(NSObject sender)
		{
			Unused.Value = Call("changeAttributes:", sender);
		}

		public void changeDocumentBackgroundColor(NSObject sender)
		{
			Unused.Value = Call("changeDocumentBackgroundColor:", sender);
		}

		public void toggleBaseWritingDirection(NSObject sender)
		{
			Unused.Value = Call("toggleBaseWritingDirection:", sender);
		}

		public void orderFrontSpacingPanel(NSObject sender)
		{
			Unused.Value = Call("orderFrontSpacingPanel:", sender);
		}

		public void orderFrontLinkPanel(NSObject sender)
		{
			Unused.Value = Call("orderFrontLinkPanel:", sender);
		}

		public void orderFrontListPanel(NSObject sender)
		{
			Unused.Value = Call("orderFrontListPanel:", sender);
		}

		public void orderFrontTablePanel(NSObject sender)
		{
			Unused.Value = Call("orderFrontTablePanel:", sender);
		}

		public void rulerViewDidMoveMarker(NSRulerView ruler, NSRulerMarker marker)
		{
			Unused.Value = Call("rulerView:didMoveMarker:", ruler, marker);
		}

		public void rulerViewDidRemoveMarker(NSRulerView ruler, NSRulerMarker marker)
		{
			Unused.Value = Call("rulerView:didRemoveMarker:", ruler, marker);
		}

		public void rulerViewDidAddMarker(NSRulerView ruler, NSRulerMarker marker)
		{
			Unused.Value = Call("rulerView:didAddMarker:", ruler, marker);
		}

		public bool rulerViewShouldMoveMarker(NSRulerView ruler, NSRulerMarker marker)
		{
			return Call("rulerView:shouldMoveMarker:", ruler, marker).To<bool>();
		}

		public bool rulerViewShouldAddMarker(NSRulerView ruler, NSRulerMarker marker)
		{
			return Call("rulerView:shouldAddMarker:", ruler, marker).To<bool>();
		}

		public float rulerViewWillMoveMarkerToLocation(NSRulerView ruler, NSRulerMarker marker, float location)
		{
			return Call("rulerView:willMoveMarker:toLocation:", ruler, marker, location).To<float>();
		}

		public bool rulerViewShouldRemoveMarker(NSRulerView ruler, NSRulerMarker marker)
		{
			return Call("rulerView:shouldRemoveMarker:", ruler, marker).To<bool>();
		}

		public float rulerViewWillAddMarkerAtLocation(NSRulerView ruler, NSRulerMarker marker, float location)
		{
			return Call("rulerView:willAddMarker:atLocation:", ruler, marker, location).To<float>();
		}

		public void rulerViewHandleMouseDown(NSRulerView ruler, NSEvent event_)
		{
			Unused.Value = Call("rulerView:handleMouseDown:", ruler, event_);
		}

		public void setNeedsDisplayInRectAvoidAdditionalLayout(NSRect rect, bool flag)
		{
			Unused.Value = Call("setNeedsDisplayInRect:avoidAdditionalLayout:", rect, flag);
		}

		public bool shouldDrawInsertionPoint()
		{
			return Call("shouldDrawInsertionPoint").To<bool>();
		}

		public void drawInsertionPointInRectColorTurnedOn(NSRect rect, NSColor color, bool flag)
		{
			Unused.Value = Call("drawInsertionPointInRect:color:turnedOn:", rect, color, flag);
		}

		public void drawViewBackgroundInRect(NSRect rect)
		{
			Unused.Value = Call("drawViewBackgroundInRect:", rect);
		}

		public void updateRuler()
		{
			Unused.Value = Call("updateRuler");
		}

		public void updateFontPanel()
		{
			Unused.Value = Call("updateFontPanel");
		}

		public void updateDragTypeRegistration()
		{
			Unused.Value = Call("updateDragTypeRegistration");
		}

		public NSRange selectionRangeForProposedRangeGranularity(NSRange proposedCharRange, UInt32 granularity)
		{
			return Call("selectionRangeForProposedRange:granularity:", proposedCharRange, granularity).To<NSRange>();
		}

		public void clickedOnLinkAtIndex(NSObject link, UInt32 charIndex)
		{
			Unused.Value = Call("clickedOnLink:atIndex:", link, charIndex);
		}

		public void startSpeaking(NSObject sender)
		{
			Unused.Value = Call("startSpeaking:", sender);
		}

		public void stopSpeaking(NSObject sender)
		{
			Unused.Value = Call("stopSpeaking:", sender);
		}

		public UInt32 characterIndexForInsertionAtPoint(NSPoint point)
		{
			return Call("characterIndexForInsertionAtPoint:", point).To<UInt32>();
		}

		#region NSTextInput Methods

		public void doCommandBySelector(Selector aSelector)
		{
			Unused.Value = Call("doCommandBySelector:", aSelector);
		}

		public void setMarkedTextSelectedRange(NSObject aString, NSRange selRange)
		{
			Unused.Value = Call("setMarkedText:selectedRange:", aString, selRange);
		}

		public void unmarkText()
		{
			Unused.Value = Call("unmarkText");
		}

		public bool hasMarkedText()
		{
			return Call("hasMarkedText").To<bool>();
		}

		public Int32 conversationIdentifier()
		{
			return Call("conversationIdentifier").To<Int32>();
		}

		public NSAttributedString attributedSubstringFromRange(NSRange theRange)
		{
			return Call("attributedSubstringFromRange:", theRange).To<NSAttributedString>();
		}

		public NSRange markedRange()
		{
			return Call("markedRange").To<NSRange>();
		}

		// skipping selectedRange (it's declared in a base class)

		public NSRect firstRectForCharacterRange(NSRange theRange)
		{
			return Call("firstRectForCharacterRange:", theRange).To<NSRect>();
		}

		public UInt32 characterIndexForPoint(NSPoint thePoint)
		{
			return Call("characterIndexForPoint:", thePoint).To<UInt32>();
		}

		public NSArray validAttributesForMarkedText()
		{
			return Call("validAttributesForMarkedText").To<NSArray>();
		}
		#endregion

		#region NSUserInterfaceValidations Methods
		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}
		#endregion

		#region NSTextInputClient Methods
		public void insertTextReplacementRange(NSObject aString, NSRange replacementRange)
		{
			Unused.Value = Call("insertText:replacementRange:", aString, replacementRange);
		}


		public void setMarkedTextSelectedRangeReplacementRange(NSObject aString, NSRange selectedRange, NSRange replacementRange)
		{
			Unused.Value = Call("setMarkedText:selectedRange:replacementRange:", aString, selectedRange, replacementRange);
		}


		// skipping selectedRange (it's declared in a base class)



		public NSAttributedString attributedSubstringForProposedRangeActualRange(NSRange aRange, IntPtr actualRange)
		{
			return Call("attributedSubstringForProposedRange:actualRange:", aRange, actualRange).To<NSAttributedString>();
		}


		public NSRect firstRectForCharacterRangeActualRange(NSRange aRange, IntPtr actualRange)
		{
			return Call("firstRectForCharacterRange:actualRange:", aRange, actualRange).To<NSRect>();
		}


		public NSAttributedString attributedString()
		{
			return Call("attributedString").To<NSAttributedString>();
		}

		public float fractionOfDistanceThroughGlyphForPoint(NSPoint aPoint)
		{
			return Call("fractionOfDistanceThroughGlyphForPoint:", aPoint).To<float>();
		}

		public float baselineDeltaForCharacterAtIndex(UInt32 anIndex)
		{
			return Call("baselineDeltaForCharacterAtIndex:", anIndex).To<float>();
		}

		public Int32 windowLevel()
		{
			return Call("windowLevel").To<Int32>();
		}
		#endregion

		private static Class ms_class = new Class("NSTextView");
	}

	public static class NSCompletionForNSTextViewCategory
	{
		public static void complete(this NSTextView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("complete:", sender);
		}

		public static NSRange rangeForUserCompletion(this NSTextView _instance)
		{
			return _instance.Call("rangeForUserCompletion").To<NSRange>();
		}

		public static NSArray completionsForPartialWordRangeIndexOfSelectedItem(this NSTextView _instance, NSRange charRange, IntPtr index)
		{
			return _instance.Call("completionsForPartialWordRange:indexOfSelectedItem:", charRange, index).To<NSArray>();
		}

		public static void insertCompletionForPartialWordRangeMovementIsFinal(this NSTextView _instance, NSString word, NSRange charRange, Int32 movement, bool flag)
		{
			Unused.Value = _instance.Call("insertCompletion:forPartialWordRange:movement:isFinal:", word, charRange, movement, flag);
		}
	}

	public static class NSPasteboardForNSTextViewCategory
	{
		public static NSArray writablePasteboardTypes(this NSTextView _instance)
		{
			return _instance.Call("writablePasteboardTypes").To<NSArray>();
		}

		public static bool writeSelectionToPasteboardType(this NSTextView _instance, NSPasteboard pboard, NSString type)
		{
			return _instance.Call("writeSelectionToPasteboard:type:", pboard, type).To<bool>();
		}

		public static bool writeSelectionToPasteboardTypes(this NSTextView _instance, NSPasteboard pboard, NSArray types)
		{
			return _instance.Call("writeSelectionToPasteboard:types:", pboard, types).To<bool>();
		}

		public static NSArray readablePasteboardTypes(this NSTextView _instance)
		{
			return _instance.Call("readablePasteboardTypes").To<NSArray>();
		}

		public static NSString preferredPasteboardTypeFromArrayRestrictedToTypesFromArray(this NSTextView _instance, NSArray availableTypes, NSArray allowedTypes)
		{
			return _instance.Call("preferredPasteboardTypeFromArray:restrictedToTypesFromArray:", availableTypes, allowedTypes).To<NSString>();
		}

		public static bool readSelectionFromPasteboardType(this NSTextView _instance, NSPasteboard pboard, NSString type)
		{
			return _instance.Call("readSelectionFromPasteboard:type:", pboard, type).To<bool>();
		}

		public static bool readSelectionFromPasteboard(this NSTextView _instance, NSPasteboard pboard)
		{
			return _instance.Call("readSelectionFromPasteboard:", pboard).To<bool>();
		}

		public static void registerForServices(this NSTextView _instance)
		{
			Unused.Value = _instance.Call("registerForServices");
		}

		public static NSObject validRequestorForSendTypeReturnType(this NSTextView _instance, NSString sendType, NSString returnType)
		{
			return _instance.Call("validRequestorForSendType:returnType:", sendType, returnType).To<NSObject>();
		}

		public static void pasteAsPlainText(this NSTextView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("pasteAsPlainText:", sender);
		}

		public static void pasteAsRichText(this NSTextView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("pasteAsRichText:", sender);
		}
	}

	public static class NSDraggingForNSTextViewCategory
	{
		public static bool dragSelectionWithEventOffsetSlideBack(this NSTextView _instance, NSEvent event_, NSSize mouseOffset, bool slideBack)
		{
			return _instance.Call("dragSelectionWithEvent:offset:slideBack:", event_, mouseOffset, slideBack).To<bool>();
		}

		public static NSImage dragImageForSelectionWithEventOrigin(this NSTextView _instance, NSEvent event_, IntPtr origin)
		{
			return _instance.Call("dragImageForSelectionWithEvent:origin:", event_, origin).To<NSImage>();
		}

		public static NSArray acceptableDragTypes(this NSTextView _instance)
		{
			return _instance.Call("acceptableDragTypes").To<NSArray>();
		}

		public static UInt32 dragOperationForDraggingInfoType(this NSTextView _instance, NSObject dragInfo, NSString type)
		{
			return _instance.Call("dragOperationForDraggingInfo:type:", dragInfo, type).To<UInt32>();
		}

		public static void cleanUpAfterDragOperation(this NSTextView _instance)
		{
			Unused.Value = _instance.Call("cleanUpAfterDragOperation");
		}
	}

	public static class NSSharingForNSTextViewCategory
	{
		public static NSArray selectedRanges(this NSTextView _instance)
		{
			return _instance.Call("selectedRanges").To<NSArray>();
		}

		public static void setSelectedRangesAffinityStillSelecting(this NSTextView _instance, NSArray ranges, UInt32 affinity, bool stillSelectingFlag)
		{
			Unused.Value = _instance.Call("setSelectedRanges:affinity:stillSelecting:", ranges, affinity, stillSelectingFlag);
		}

		public static void setSelectedRanges(this NSTextView _instance, NSArray ranges)
		{
			Unused.Value = _instance.Call("setSelectedRanges:", ranges);
		}

		public static void setSelectedRangeAffinityStillSelecting(this NSTextView _instance, NSRange charRange, UInt32 affinity, bool stillSelectingFlag)
		{
			Unused.Value = _instance.Call("setSelectedRange:affinity:stillSelecting:", charRange, affinity, stillSelectingFlag);
		}

		public static UInt32 selectionAffinity(this NSTextView _instance)
		{
			return _instance.Call("selectionAffinity").To<UInt32>();
		}

		public static UInt32 selectionGranularity(this NSTextView _instance)
		{
			return _instance.Call("selectionGranularity").To<UInt32>();
		}

		public static void setSelectionGranularity(this NSTextView _instance, UInt32 granularity)
		{
			Unused.Value = _instance.Call("setSelectionGranularity:", granularity);
		}

		public static void setSelectedTextAttributes(this NSTextView _instance, NSDictionary attributeDictionary)
		{
			Unused.Value = _instance.Call("setSelectedTextAttributes:", attributeDictionary);
		}

		public static NSDictionary selectedTextAttributes(this NSTextView _instance)
		{
			return _instance.Call("selectedTextAttributes").To<NSDictionary>();
		}

		public static void setInsertionPointColor(this NSTextView _instance, NSColor color)
		{
			Unused.Value = _instance.Call("setInsertionPointColor:", color);
		}

		public static NSColor insertionPointColor(this NSTextView _instance)
		{
			return _instance.Call("insertionPointColor").To<NSColor>();
		}

		public static void updateInsertionPointStateAndRestartTimer(this NSTextView _instance, bool restartFlag)
		{
			Unused.Value = _instance.Call("updateInsertionPointStateAndRestartTimer:", restartFlag);
		}

		public static void setMarkedTextAttributes(this NSTextView _instance, NSDictionary attributeDictionary)
		{
			Unused.Value = _instance.Call("setMarkedTextAttributes:", attributeDictionary);
		}

		public static NSDictionary markedTextAttributes(this NSTextView _instance)
		{
			return _instance.Call("markedTextAttributes").To<NSDictionary>();
		}

		public static void setLinkTextAttributes(this NSTextView _instance, NSDictionary attributeDictionary)
		{
			Unused.Value = _instance.Call("setLinkTextAttributes:", attributeDictionary);
		}

		public static NSDictionary linkTextAttributes(this NSTextView _instance)
		{
			return _instance.Call("linkTextAttributes").To<NSDictionary>();
		}

		public static bool displaysLinkToolTips(this NSTextView _instance)
		{
			return _instance.Call("displaysLinkToolTips").To<bool>();
		}

		public static void setDisplaysLinkToolTips(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setDisplaysLinkToolTips:", flag);
		}

		public static bool acceptsGlyphInfo(this NSTextView _instance)
		{
			return _instance.Call("acceptsGlyphInfo").To<bool>();
		}

		public static void setAcceptsGlyphInfo(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAcceptsGlyphInfo:", flag);
		}

		public static void setRulerVisible(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setRulerVisible:", flag);
		}

		public static bool usesRuler(this NSTextView _instance)
		{
			return _instance.Call("usesRuler").To<bool>();
		}

		public static void setUsesRuler(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setUsesRuler:", flag);
		}

		public static void setContinuousSpellCheckingEnabled(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setContinuousSpellCheckingEnabled:", flag);
		}

		public static bool isContinuousSpellCheckingEnabled(this NSTextView _instance)
		{
			return _instance.Call("isContinuousSpellCheckingEnabled").To<bool>();
		}

		public static void toggleContinuousSpellChecking(this NSTextView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("toggleContinuousSpellChecking:", sender);
		}

		public static Int32 spellCheckerDocumentTag(this NSTextView _instance)
		{
			return _instance.Call("spellCheckerDocumentTag").To<Int32>();
		}

		public static void setGrammarCheckingEnabled(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setGrammarCheckingEnabled:", flag);
		}

		public static bool isGrammarCheckingEnabled(this NSTextView _instance)
		{
			return _instance.Call("isGrammarCheckingEnabled").To<bool>();
		}

		public static void toggleGrammarChecking(this NSTextView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("toggleGrammarChecking:", sender);
		}

		public static void setSpellingStateRange(this NSTextView _instance, Int32 value, NSRange charRange)
		{
			Unused.Value = _instance.Call("setSpellingState:range:", value, charRange);
		}

		public static NSDictionary typingAttributes(this NSTextView _instance)
		{
			return _instance.Call("typingAttributes").To<NSDictionary>();
		}

		public static void setTypingAttributes(this NSTextView _instance, NSDictionary attrs)
		{
			Unused.Value = _instance.Call("setTypingAttributes:", attrs);
		}

		public static bool shouldChangeTextInRangesReplacementStrings(this NSTextView _instance, NSArray affectedRanges, NSArray replacementStrings)
		{
			return _instance.Call("shouldChangeTextInRanges:replacementStrings:", affectedRanges, replacementStrings).To<bool>();
		}

		public static NSArray rangesForUserTextChange(this NSTextView _instance)
		{
			return _instance.Call("rangesForUserTextChange").To<NSArray>();
		}

		public static NSArray rangesForUserCharacterAttributeChange(this NSTextView _instance)
		{
			return _instance.Call("rangesForUserCharacterAttributeChange").To<NSArray>();
		}

		public static NSArray rangesForUserParagraphAttributeChange(this NSTextView _instance)
		{
			return _instance.Call("rangesForUserParagraphAttributeChange").To<NSArray>();
		}

		public static bool shouldChangeTextInRangeReplacementString(this NSTextView _instance, NSRange affectedCharRange, NSString replacementString)
		{
			return _instance.Call("shouldChangeTextInRange:replacementString:", affectedCharRange, replacementString).To<bool>();
		}

		public static void didChangeText(this NSTextView _instance)
		{
			Unused.Value = _instance.Call("didChangeText");
		}

		public static NSRange rangeForUserTextChange(this NSTextView _instance)
		{
			return _instance.Call("rangeForUserTextChange").To<NSRange>();
		}

		public static NSRange rangeForUserCharacterAttributeChange(this NSTextView _instance)
		{
			return _instance.Call("rangeForUserCharacterAttributeChange").To<NSRange>();
		}

		public static NSRange rangeForUserParagraphAttributeChange(this NSTextView _instance)
		{
			return _instance.Call("rangeForUserParagraphAttributeChange").To<NSRange>();
		}

		public static void setUsesFindPanel(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setUsesFindPanel:", flag);
		}

		public static bool usesFindPanel(this NSTextView _instance)
		{
			return _instance.Call("usesFindPanel").To<bool>();
		}

		public static void setAllowsDocumentBackgroundColorChange(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAllowsDocumentBackgroundColorChange:", flag);
		}

		public static bool allowsDocumentBackgroundColorChange(this NSTextView _instance)
		{
			return _instance.Call("allowsDocumentBackgroundColorChange").To<bool>();
		}

		public static void setDefaultParagraphStyle(this NSTextView _instance, NSParagraphStyle paragraphStyle)
		{
			Unused.Value = _instance.Call("setDefaultParagraphStyle:", paragraphStyle);
		}

		public static NSParagraphStyle defaultParagraphStyle(this NSTextView _instance)
		{
			return _instance.Call("defaultParagraphStyle").To<NSParagraphStyle>();
		}

		public static void setAllowsUndo(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAllowsUndo:", flag);
		}

		public static bool allowsUndo(this NSTextView _instance)
		{
			return _instance.Call("allowsUndo").To<bool>();
		}

		public static void breakUndoCoalescing(this NSTextView _instance)
		{
			Unused.Value = _instance.Call("breakUndoCoalescing");
		}

		public static bool allowsImageEditing(this NSTextView _instance)
		{
			return _instance.Call("allowsImageEditing").To<bool>();
		}

		public static void setAllowsImageEditing(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAllowsImageEditing:", flag);
		}

		public static void showFindIndicatorForRange(this NSTextView _instance, NSRange charRange)
		{
			Unused.Value = _instance.Call("showFindIndicatorForRange:", charRange);
		}

		public static NSObject delegate_(this NSTextView _instance)
		{
			return _instance.Call("delegate").To<NSObject>();
		}

		public static void setDelegate(this NSTextView _instance, NSObject anObject)
		{
			Unused.Value = _instance.Call("setDelegate:", anObject);
		}

		public static bool isEditable(this NSTextView _instance)
		{
			return _instance.Call("isEditable").To<bool>();
		}

		public static void setEditable(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setEditable:", flag);
		}

		public static bool isSelectable(this NSTextView _instance)
		{
			return _instance.Call("isSelectable").To<bool>();
		}

		public static void setSelectable(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setSelectable:", flag);
		}

		public static bool isRichText(this NSTextView _instance)
		{
			return _instance.Call("isRichText").To<bool>();
		}

		public static void setRichText(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setRichText:", flag);
		}

		public static bool importsGraphics(this NSTextView _instance)
		{
			return _instance.Call("importsGraphics").To<bool>();
		}

		public static void setImportsGraphics(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setImportsGraphics:", flag);
		}

		public static bool drawsBackground(this NSTextView _instance)
		{
			return _instance.Call("drawsBackground").To<bool>();
		}

		public static void setDrawsBackground(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setDrawsBackground:", flag);
		}

		public static NSColor backgroundColor(this NSTextView _instance)
		{
			return _instance.Call("backgroundColor").To<NSColor>();
		}

		public static void setBackgroundColor(this NSTextView _instance, NSColor color)
		{
			Unused.Value = _instance.Call("setBackgroundColor:", color);
		}

		public static bool isFieldEditor(this NSTextView _instance)
		{
			return _instance.Call("isFieldEditor").To<bool>();
		}

		public static void setFieldEditor(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setFieldEditor:", flag);
		}

		public static bool usesFontPanel(this NSTextView _instance)
		{
			return _instance.Call("usesFontPanel").To<bool>();
		}

		public static void setUsesFontPanel(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setUsesFontPanel:", flag);
		}

		public static bool isRulerVisible(this NSTextView _instance)
		{
			return _instance.Call("isRulerVisible").To<bool>();
		}

		public static void setSelectedRange(this NSTextView _instance, NSRange charRange)
		{
			Unused.Value = _instance.Call("setSelectedRange:", charRange);
		}

		public static bool smartInsertDeleteEnabled(this NSTextView _instance)
		{
			return _instance.Call("smartInsertDeleteEnabled").To<bool>();
		}

		public static void setSmartInsertDeleteEnabled(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setSmartInsertDeleteEnabled:", flag);
		}

		public static NSRange smartDeleteRangeForProposedRange(this NSTextView _instance, NSRange proposedCharRange)
		{
			return _instance.Call("smartDeleteRangeForProposedRange:", proposedCharRange).To<NSRange>();
		}

		public static void toggleSmartInsertDelete(this NSTextView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("toggleSmartInsertDelete:", sender);
		}

		public static void smartInsertForStringReplacingRangeBeforeStringAfterString(this NSTextView _instance, NSString pasteString, NSRange charRangeToReplace, IntPtr beforeString, IntPtr afterString)
		{
			Unused.Value = _instance.Call("smartInsertForString:replacingRange:beforeString:afterString:", pasteString, charRangeToReplace, beforeString, afterString);
		}

		public static NSString smartInsertBeforeStringForStringReplacingRange(this NSTextView _instance, NSString pasteString, NSRange charRangeToReplace)
		{
			return _instance.Call("smartInsertBeforeStringForString:replacingRange:", pasteString, charRangeToReplace).To<NSString>();
		}

		public static NSString smartInsertAfterStringForStringReplacingRange(this NSTextView _instance, NSString pasteString, NSRange charRangeToReplace)
		{
			return _instance.Call("smartInsertAfterStringForString:replacingRange:", pasteString, charRangeToReplace).To<NSString>();
		}

		public static void setAutomaticQuoteSubstitutionEnabled(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAutomaticQuoteSubstitutionEnabled:", flag);
		}

		public static bool isAutomaticQuoteSubstitutionEnabled(this NSTextView _instance)
		{
			return _instance.Call("isAutomaticQuoteSubstitutionEnabled").To<bool>();
		}

		public static void toggleAutomaticQuoteSubstitution(this NSTextView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("toggleAutomaticQuoteSubstitution:", sender);
		}

		public static void setAutomaticLinkDetectionEnabled(this NSTextView _instance, bool flag)
		{
			Unused.Value = _instance.Call("setAutomaticLinkDetectionEnabled:", flag);
		}

		public static bool isAutomaticLinkDetectionEnabled(this NSTextView _instance)
		{
			return _instance.Call("isAutomaticLinkDetectionEnabled").To<bool>();
		}

		public static void toggleAutomaticLinkDetection(this NSTextView _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("toggleAutomaticLinkDetection:", sender);
		}

		public static NSArray allowedInputSourceLocales(this NSTextView _instance)
		{
			return _instance.Call("allowedInputSourceLocales").To<NSArray>();
		}

		public static void setAllowedInputSourceLocales(this NSTextView _instance, NSArray localeIdentifiers)
		{
			Unused.Value = _instance.Call("setAllowedInputSourceLocales:", localeIdentifiers);
		}
	}

	public static class NSTextViewDelegateForNSObjectCategory
	{
		public static bool textViewClickedOnLinkAtIndex(this NSObject _instance, NSTextView textView, NSObject link, UInt32 charIndex)
		{
			return _instance.Call("textView:clickedOnLink:atIndex:", textView, link, charIndex).To<bool>();
		}

		public static void textViewClickedOnCellInRectAtIndex(this NSObject _instance, NSTextView textView, NSObject cell, NSRect cellFrame, UInt32 charIndex)
		{
			Unused.Value = _instance.Call("textView:clickedOnCell:inRect:atIndex:", textView, cell, cellFrame, charIndex);
		}

		public static void textViewDoubleClickedOnCellInRectAtIndex(this NSObject _instance, NSTextView textView, NSObject cell, NSRect cellFrame, UInt32 charIndex)
		{
			Unused.Value = _instance.Call("textView:doubleClickedOnCell:inRect:atIndex:", textView, cell, cellFrame, charIndex);
		}

		public static void textViewDraggedCellInRectEventAtIndex(this NSObject _instance, NSTextView view, NSObject cell, NSRect rect, NSEvent event_, UInt32 charIndex)
		{
			Unused.Value = _instance.Call("textView:draggedCell:inRect:event:atIndex:", view, cell, rect, event_, charIndex);
		}

		public static NSArray textViewWritablePasteboardTypesForCellAtIndex(this NSObject _instance, NSTextView view, NSObject cell, UInt32 charIndex)
		{
			return _instance.Call("textView:writablePasteboardTypesForCell:atIndex:", view, cell, charIndex).To<NSArray>();
		}

		public static bool textViewWriteCellAtIndexToPasteboardType(this NSObject _instance, NSTextView view, NSObject cell, UInt32 charIndex, NSPasteboard pboard, NSString type)
		{
			return _instance.Call("textView:writeCell:atIndex:toPasteboard:type:", view, cell, charIndex, pboard, type).To<bool>();
		}

		public static NSRange textViewWillChangeSelectionFromCharacterRangeToCharacterRange(this NSObject _instance, NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
		{
			return _instance.Call("textView:willChangeSelectionFromCharacterRange:toCharacterRange:", textView, oldSelectedCharRange, newSelectedCharRange).To<NSRange>();
		}

		public static NSArray textViewWillChangeSelectionFromCharacterRangesToCharacterRanges(this NSObject _instance, NSTextView textView, NSArray oldSelectedCharRanges, NSArray newSelectedCharRanges)
		{
			return _instance.Call("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:", textView, oldSelectedCharRanges, newSelectedCharRanges).To<NSArray>();
		}

		public static bool textViewShouldChangeTextInRangesReplacementStrings(this NSObject _instance, NSTextView textView, NSArray affectedRanges, NSArray replacementStrings)
		{
			return _instance.Call("textView:shouldChangeTextInRanges:replacementStrings:", textView, affectedRanges, replacementStrings).To<bool>();
		}

		public static NSDictionary textViewShouldChangeTypingAttributesToAttributes(this NSObject _instance, NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
		{
			return _instance.Call("textView:shouldChangeTypingAttributes:toAttributes:", textView, oldTypingAttributes, newTypingAttributes).To<NSDictionary>();
		}

		public static void textViewDidChangeSelection(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("textViewDidChangeSelection:", notification);
		}

		public static void textViewDidChangeTypingAttributes(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("textViewDidChangeTypingAttributes:", notification);
		}

		public static NSString textViewWillDisplayToolTipForCharacterAtIndex(this NSObject _instance, NSTextView textView, NSString tooltip, UInt32 characterIndex)
		{
			return _instance.Call("textView:willDisplayToolTip:forCharacterAtIndex:", textView, tooltip, characterIndex).To<NSString>();
		}

		public static NSArray textViewCompletionsForPartialWordRangeIndexOfSelectedItem(this NSObject _instance, NSTextView textView, NSArray words, NSRange charRange, IntPtr index)
		{
			return _instance.Call("textView:completions:forPartialWordRange:indexOfSelectedItem:", textView, words, charRange, index).To<NSArray>();
		}

		public static bool textViewShouldChangeTextInRangeReplacementString(this NSObject _instance, NSTextView textView, NSRange affectedCharRange, NSString replacementString)
		{
			return _instance.Call("textView:shouldChangeTextInRange:replacementString:", textView, affectedCharRange, replacementString).To<bool>();
		}

		public static bool textViewDoCommandBySelector(this NSObject _instance, NSTextView textView, Selector commandSelector)
		{
			return _instance.Call("textView:doCommandBySelector:", textView, commandSelector).To<bool>();
		}

		public static Int32 textViewShouldSetSpellingStateRange(this NSObject _instance, NSTextView textView, Int32 value, NSRange affectedCharRange)
		{
			return _instance.Call("textView:shouldSetSpellingState:range:", textView, value, affectedCharRange).To<Int32>();
		}

		public static NSMenu textViewMenuForEventAtIndex(this NSObject _instance, NSTextView view, NSMenu menu, NSEvent event_, UInt32 charIndex)
		{
			return _instance.Call("textView:menu:forEvent:atIndex:", view, menu, event_, charIndex).To<NSMenu>();
		}

		public static bool textViewClickedOnLink(this NSObject _instance, NSTextView textView, NSObject link)
		{
			return _instance.Call("textView:clickedOnLink:", textView, link).To<bool>();
		}

		public static void textViewClickedOnCellInRect(this NSObject _instance, NSTextView textView, NSObject cell, NSRect cellFrame)
		{
			Unused.Value = _instance.Call("textView:clickedOnCell:inRect:", textView, cell, cellFrame);
		}

		public static void textViewDoubleClickedOnCellInRect(this NSObject _instance, NSTextView textView, NSObject cell, NSRect cellFrame)
		{
			Unused.Value = _instance.Call("textView:doubleClickedOnCell:inRect:", textView, cell, cellFrame);
		}

		public static void textViewDraggedCellInRectEvent(this NSObject _instance, NSTextView view, NSObject cell, NSRect rect, NSEvent event_)
		{
			Unused.Value = _instance.Call("textView:draggedCell:inRect:event:", view, cell, rect, event_);
		}

		public static NSUndoManager undoManagerForTextView(this NSObject _instance, NSTextView view)
		{
			return _instance.Call("undoManagerForTextView:", view).To<NSUndoManager>();
		}
	}
}
