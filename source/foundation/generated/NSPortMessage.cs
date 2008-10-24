// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPortMessage.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPortMessage : NSObject
	{
		public NSPortMessage() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPortMessage(IntPtr instance) : base(instance)
		{
		}

		public NSPortMessage(Untyped instance) : base(instance)
		{
		}

		public static new NSPortMessage alloc()
		{
			return new NSPortMessage(ms_class.Call("alloc"));
		}

		public new NSPortMessage retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithSendPortReceivePortComponents(NSPort sendPort, NSPort replyPort, NSArray components)
		{
			return Call("initWithSendPort:receivePort:components:", sendPort, replyPort, components).To<NSObject>();
		}

		public NSArray components()
		{
			return Call("components").To<NSArray>();
		}

		public NSPort receivePort()
		{
			return Call("receivePort").To<NSPort>();
		}

		public NSPort sendPort()
		{
			return Call("sendPort").To<NSPort>();
		}

		public bool sendBeforeDate(NSDate date)
		{
			return Call("sendBeforeDate:", date).To<bool>();
		}

		public UInt32 msgid()
		{
			return Call("msgid").To<UInt32>();
		}

		public void setMsgid(UInt32 msgid)
		{
			Unused.Value = Call("setMsgid:", msgid);
		}

		private static Class ms_class = new Class("NSPortMessage");
	}
}
