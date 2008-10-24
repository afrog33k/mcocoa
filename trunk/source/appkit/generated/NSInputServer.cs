// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSInputServer.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSInputServer : NSObject
	{
		public NSInputServer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSInputServer(IntPtr instance) : base(instance)
		{
		}

		public NSInputServer(Untyped instance) : base(instance)
		{
		}

		public static new NSInputServer alloc()
		{
			return new NSInputServer(ms_class.Call("alloc"));
		}

		public new NSInputServer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		#region NSInputServiceProvider Methods
		public void insertTextClient(NSObject aString, NSObject sender)
		{
			Unused.Value = Call("insertText:client:", aString, sender);
		}

		public void doCommandBySelectorClient(Selector aSelector, NSObject sender)
		{
			Unused.Value = Call("doCommandBySelector:client:", aSelector, sender);
		}

		public void markedTextAbandoned(NSObject sender)
		{
			Unused.Value = Call("markedTextAbandoned:", sender);
		}

		public void markedTextSelectionChangedClient(NSRange newSel, NSObject sender)
		{
			Unused.Value = Call("markedTextSelectionChanged:client:", newSel, sender);
		}

		public void terminate(NSObject sender)
		{
			Unused.Value = Call("terminate:", sender);
		}

		public bool canBeDisabled()
		{
			return Call("canBeDisabled").To<bool>();
		}

		public bool wantsToInterpretAllKeystrokes()
		{
			return Call("wantsToInterpretAllKeystrokes").To<bool>();
		}

		public bool wantsToHandleMouseEvents()
		{
			return Call("wantsToHandleMouseEvents").To<bool>();
		}

		public bool wantsToDelayTextChangeNotifications()
		{
			return Call("wantsToDelayTextChangeNotifications").To<bool>();
		}

		public void inputClientBecomeActive(NSObject sender)
		{
			Unused.Value = Call("inputClientBecomeActive:", sender);
		}

		public void inputClientResignActive(NSObject sender)
		{
			Unused.Value = Call("inputClientResignActive:", sender);
		}

		public void inputClientEnabled(NSObject sender)
		{
			Unused.Value = Call("inputClientEnabled:", sender);
		}

		public void inputClientDisabled(NSObject sender)
		{
			Unused.Value = Call("inputClientDisabled:", sender);
		}

		public void activeConversationWillChangeFromOldConversation(NSObject sender, Int32 oldConversation)
		{
			Unused.Value = Call("activeConversationWillChange:fromOldConversation:", sender, oldConversation);
		}

		public void activeConversationChangedToNewConversation(NSObject sender, Int32 newConversation)
		{
			Unused.Value = Call("activeConversationChanged:toNewConversation:", sender, newConversation);
		}
		#endregion

		#region NSInputServerMouseTracker Methods
		public bool mouseDownOnCharacterIndexAtCoordinateWithModifierClient(UInt32 theIndex, NSPoint thePoint, UInt32 theFlags, NSObject sender)
		{
			return Call("mouseDownOnCharacterIndex:atCoordinate:withModifier:client:", theIndex, thePoint, theFlags, sender).To<bool>();
		}

		public bool mouseDraggedOnCharacterIndexAtCoordinateWithModifierClient(UInt32 theIndex, NSPoint thePoint, UInt32 theFlags, NSObject sender)
		{
			return Call("mouseDraggedOnCharacterIndex:atCoordinate:withModifier:client:", theIndex, thePoint, theFlags, sender).To<bool>();
		}

		public void mouseUpOnCharacterIndexAtCoordinateWithModifierClient(UInt32 theIndex, NSPoint thePoint, UInt32 theFlags, NSObject sender)
		{
			Unused.Value = Call("mouseUpOnCharacterIndex:atCoordinate:withModifier:client:", theIndex, thePoint, theFlags, sender);
		}
		#endregion

		private static Class ms_class = new Class("NSInputServer");
	}
}
