// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPort.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSMachPortDeallocateNone = 0;
		public const int NSMachPortDeallocateSendRight = ( 1 << 0 );
		public const int NSMachPortDeallocateReceiveRight = ( 1 << 1 );
	}

	[Register]
	public partial class NSPort : NSObject
	{
		public NSPort() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPort(IntPtr instance) : base(instance)
		{
		}

		public NSPort(Untyped instance) : base(instance)
		{
		}

		public static new NSPort alloc()
		{
			return new NSPort(ms_class.Call("alloc"));
		}

		public new NSPort retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject allocWithZone(IntPtr zone)
		{
			return ms_class.Call("allocWithZone:", zone).To<NSObject>();
		}

		public static NSPort port()
		{
			return ms_class.Call("port").To<NSPort>();
		}

		public void invalidate()
		{
			Unused.Value = Call("invalidate");
		}

		public bool isValid()
		{
			return Call("isValid").To<bool>();
		}

		public void setDelegate(NSObject anId)
		{
			Unused.Value = Call("setDelegate:", anId);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void scheduleInRunLoopForMode(NSRunLoop runLoop, NSString mode)
		{
			Unused.Value = Call("scheduleInRunLoop:forMode:", runLoop, mode);
		}

		public void removeFromRunLoopForMode(NSRunLoop runLoop, NSString mode)
		{
			Unused.Value = Call("removeFromRunLoop:forMode:", runLoop, mode);
		}

		public UInt32 reservedSpaceLength()
		{
			return Call("reservedSpaceLength").To<UInt32>();
		}

		public bool sendBeforeDateComponentsFromReserved(NSDate limitDate, NSMutableArray components, NSPort receivePort, UInt32 headerSpaceReserved)
		{
			return Call("sendBeforeDate:components:from:reserved:", limitDate, components, receivePort, headerSpaceReserved).To<bool>();
		}

		public bool sendBeforeDateMsgidComponentsFromReserved(NSDate limitDate, UInt32 msgID, NSMutableArray components, NSPort receivePort, UInt32 headerSpaceReserved)
		{
			return Call("sendBeforeDate:msgid:components:from:reserved:", limitDate, msgID, components, receivePort, headerSpaceReserved).To<bool>();
		}

		public void addConnectionToRunLoopForMode(NSConnection conn, NSRunLoop runLoop, NSString mode)
		{
			Unused.Value = Call("addConnection:toRunLoop:forMode:", conn, runLoop, mode);
		}

		public void removeConnectionFromRunLoopForMode(NSConnection conn, NSRunLoop runLoop, NSString mode)
		{
			Unused.Value = Call("removeConnection:fromRunLoop:forMode:", conn, runLoop, mode);
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSPort");
	}

	public static class NSPortDelegateMethodsForNSObjectCategory
	{
		public static void handlePortMessage(this NSObject _instance, NSPortMessage message)
		{
			Unused.Value = _instance.Call("handlePortMessage:", message);
		}
	}

	[Register]
	public partial class NSMachPort : NSPort
	{
		public NSMachPort() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMachPort(IntPtr instance) : base(instance)
		{
		}

		public NSMachPort(Untyped instance) : base(instance)
		{
		}

		public static new NSMachPort alloc()
		{
			return new NSMachPort(ms_class.Call("alloc"));
		}

		public new NSMachPort retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSPort portWithMachPort(UInt32 machPort)
		{
			return ms_class.Call("portWithMachPort:", machPort).To<NSPort>();
		}

		public NSObject initWithMachPort(UInt32 machPort)
		{
			return Call("initWithMachPort:", machPort).To<NSObject>();
		}

		public static NSPort portWithMachPortOptionsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(UInt32 machPort, UInt32 f)
		{
			return ms_class.Call("portWithMachPort:options:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", machPort, f).To<NSPort>();
		}

		public NSObject initWithMachPortOptionsAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(UInt32 machPort, UInt32 f)
		{
			return Call("initWithMachPort:options:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", machPort, f).To<NSObject>();
		}

		public UInt32 machPort()
		{
			return Call("machPort").To<UInt32>();
		}

		// skipping scheduleInRunLoop:forMode: (it's declared in a base class)

		// skipping removeFromRunLoop:forMode: (it's declared in a base class)

		private static Class ms_class = new Class("NSMachPort");
	}

	public static class NSMachPortDelegateMethodsForNSObjectCategory
	{
		public static void handleMachMessage(this NSObject _instance, IntPtr msg)
		{
			Unused.Value = _instance.Call("handleMachMessage:", msg);
		}
	}

	[Register]
	public partial class NSMessagePort : NSPort
	{
		public NSMessagePort() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMessagePort(IntPtr instance) : base(instance)
		{
		}

		public NSMessagePort(Untyped instance) : base(instance)
		{
		}

		public static new NSMessagePort alloc()
		{
			return new NSMessagePort(ms_class.Call("alloc"));
		}

		public new NSMessagePort retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSMessagePort");
	}

	[Register]
	public partial class NSSocketPort : NSPort
	{
		public NSSocketPort() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSocketPort(IntPtr instance) : base(instance)
		{
		}

		public NSSocketPort(Untyped instance) : base(instance)
		{
		}

		public static new NSSocketPort alloc()
		{
			return new NSSocketPort(ms_class.Call("alloc"));
		}

		public new NSSocketPort retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public NSObject initWithTCPPort(UInt16 port)
		{
			return Call("initWithTCPPort:", port).To<NSObject>();
		}

		public NSObject initWithProtocolFamilySocketTypeProtocolAddress(Int32 family, Int32 type, Int32 protocol, NSData address)
		{
			return Call("initWithProtocolFamily:socketType:protocol:address:", family, type, protocol, address).To<NSObject>();
		}

		public NSObject initWithProtocolFamilySocketTypeProtocolSocket(Int32 family, Int32 type, Int32 protocol, Int32 sock)
		{
			return Call("initWithProtocolFamily:socketType:protocol:socket:", family, type, protocol, sock).To<NSObject>();
		}

		public NSObject initRemoteWithTCPPortHost(UInt16 port, NSString hostName)
		{
			return Call("initRemoteWithTCPPort:host:", port, hostName).To<NSObject>();
		}

		public NSObject initRemoteWithProtocolFamilySocketTypeProtocolAddress(Int32 family, Int32 type, Int32 protocol, NSData address)
		{
			return Call("initRemoteWithProtocolFamily:socketType:protocol:address:", family, type, protocol, address).To<NSObject>();
		}

		public Int32 protocolFamily()
		{
			return Call("protocolFamily").To<Int32>();
		}

		public Int32 socketType()
		{
			return Call("socketType").To<Int32>();
		}

		public Int32 protocol()
		{
			return Call("protocol").To<Int32>();
		}

		public NSData address()
		{
			return Call("address").To<NSData>();
		}

		public Int32 socket()
		{
			return Call("socket").To<Int32>();
		}

		private static Class ms_class = new Class("NSSocketPort");
	}
}
