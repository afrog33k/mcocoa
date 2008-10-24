// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSInputManager.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSInputManager : NSObject
	{
		public NSInputManager() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSInputManager(IntPtr instance) : base(instance)
		{
		}

		public NSInputManager(Untyped instance) : base(instance)
		{
		}

		public static new NSInputManager alloc()
		{
			return new NSInputManager(ms_class.Call("alloc"));
		}

		public new NSInputManager retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSInputManager currentInputManager()
		{
			return ms_class.Call("currentInputManager").To<NSInputManager>();
		}

		public static void cycleToNextInputLanguage(NSObject sender)
		{
			Unused.Value = ms_class.Call("cycleToNextInputLanguage:", sender);
		}

		public static void cycleToNextInputServerInLanguage(NSObject sender)
		{
			Unused.Value = ms_class.Call("cycleToNextInputServerInLanguage:", sender);
		}

		public NSInputManager initWithNameHost(NSString inputServerName, NSString hostName)
		{
			return Call("initWithName:host:", inputServerName, hostName).To<NSInputManager>();
		}

		public NSString localizedInputManagerName()
		{
			return Call("localizedInputManagerName").To<NSString>();
		}

		public void markedTextAbandoned(NSObject cli)
		{
			Unused.Value = Call("markedTextAbandoned:", cli);
		}

		public void markedTextSelectionChangedClient(NSRange newSel, NSObject cli)
		{
			Unused.Value = Call("markedTextSelectionChanged:client:", newSel, cli);
		}

		public bool wantsToInterpretAllKeystrokes()
		{
			return Call("wantsToInterpretAllKeystrokes").To<bool>();
		}

		public NSString language()
		{
			return Call("language").To<NSString>();
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public NSInputServer server()
		{
			return Call("server").To<NSInputServer>();
		}

		public bool wantsToHandleMouseEvents()
		{
			return Call("wantsToHandleMouseEvents").To<bool>();
		}

		public bool handleMouseEvent(NSEvent theMouseEvent)
		{
			return Call("handleMouseEvent:", theMouseEvent).To<bool>();
		}

		public bool wantsToDelayTextChangeNotifications()
		{
			return Call("wantsToDelayTextChangeNotifications").To<bool>();
		}

		#region NSTextInput Methods
		public void insertText(NSObject aString)
		{
			Unused.Value = Call("insertText:", aString);
		}

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

		public NSRange selectedRange()
		{
			return Call("selectedRange").To<NSRange>();
		}

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

		private static Class ms_class = new Class("NSInputManager");
	}
}
