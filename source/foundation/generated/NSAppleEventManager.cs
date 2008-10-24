// machine generated on 10/24/2008 3:54:03 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSAppleEventManager.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSAppleEventManager : NSObject
	{
		public NSAppleEventManager() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAppleEventManager(IntPtr instance) : base(instance)
		{
		}

		public NSAppleEventManager(Untyped instance) : base(instance)
		{
		}

		public static new NSAppleEventManager alloc()
		{
			return new NSAppleEventManager(ms_class.Call("alloc"));
		}

		public new NSAppleEventManager retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSAppleEventManager sharedAppleEventManager()
		{
			return ms_class.Call("sharedAppleEventManager").To<NSAppleEventManager>();
		}

		public void setEventHandlerAndSelectorForEventClassAndEventID(NSObject handler, Selector handleEventSelector, UInt32 eventClass, UInt32 eventID)
		{
			Unused.Value = Call("setEventHandler:andSelector:forEventClass:andEventID:", handler, handleEventSelector, eventClass, eventID);
		}

		public void removeEventHandlerForEventClassAndEventID(UInt32 eventClass, UInt32 eventID)
		{
			Unused.Value = Call("removeEventHandlerForEventClass:andEventID:", eventClass, eventID);
		}

		public Int16 dispatchRawAppleEventWithRawReplyHandlerRefCon(IntPtr theAppleEvent, IntPtr theReply, Int32 handlerRefCon)
		{
			return Call("dispatchRawAppleEvent:withRawReply:handlerRefCon:", theAppleEvent, theReply, handlerRefCon).To<Int16>();
		}

		public NSAppleEventDescriptor currentAppleEvent()
		{
			return Call("currentAppleEvent").To<NSAppleEventDescriptor>();
		}

		public NSAppleEventDescriptor currentReplyAppleEvent()
		{
			return Call("currentReplyAppleEvent").To<NSAppleEventDescriptor>();
		}

		public IntPtr suspendCurrentAppleEvent()
		{
			return Call("suspendCurrentAppleEvent").To<IntPtr>();
		}

		public NSAppleEventDescriptor appleEventForSuspensionID(IntPtr suspensionID)
		{
			return Call("appleEventForSuspensionID:", suspensionID).To<NSAppleEventDescriptor>();
		}

		public NSAppleEventDescriptor replyAppleEventForSuspensionID(IntPtr suspensionID)
		{
			return Call("replyAppleEventForSuspensionID:", suspensionID).To<NSAppleEventDescriptor>();
		}

		public void setCurrentAppleEventAndReplyEventWithSuspensionID(IntPtr suspensionID)
		{
			Unused.Value = Call("setCurrentAppleEventAndReplyEventWithSuspensionID:", suspensionID);
		}

		public void resumeWithSuspensionID(IntPtr suspensionID)
		{
			Unused.Value = Call("resumeWithSuspensionID:", suspensionID);
		}

		private static Class ms_class = new Class("NSAppleEventManager");
	}
}
