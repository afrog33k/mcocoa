// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSConnection.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSConnection : NSObject
	{
		public NSConnection() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSConnection(IntPtr instance) : base(instance)
		{
		}

		public NSConnection(Untyped instance) : base(instance)
		{
		}

		public static new NSConnection alloc()
		{
			return new NSConnection(ms_class.Call("alloc"));
		}

		public new NSConnection retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSDictionary statistics()
		{
			return Call("statistics").To<NSDictionary>();
		}

		public static NSArray allConnections()
		{
			return ms_class.Call("allConnections").To<NSArray>();
		}

		public static NSConnection defaultConnection()
		{
			return ms_class.Call("defaultConnection").To<NSConnection>();
		}

		public static NSObject connectionWithRegisteredNameHost(NSString name, NSString hostName)
		{
			return ms_class.Call("connectionWithRegisteredName:host:", name, hostName).To<NSObject>();
		}

		public static NSObject connectionWithRegisteredNameHostUsingNameServer(NSString name, NSString hostName, NSPortNameServer server)
		{
			return ms_class.Call("connectionWithRegisteredName:host:usingNameServer:", name, hostName, server).To<NSObject>();
		}

		public static IntPtr rootProxyForConnectionWithRegisteredNameHost(NSString name, NSString hostName)
		{
			return ms_class.Call("rootProxyForConnectionWithRegisteredName:host:", name, hostName).To<IntPtr>();
		}

		public static IntPtr rootProxyForConnectionWithRegisteredNameHostUsingNameServer(NSString name, NSString hostName, NSPortNameServer server)
		{
			return ms_class.Call("rootProxyForConnectionWithRegisteredName:host:usingNameServer:", name, hostName, server).To<IntPtr>();
		}

		public static NSObject serviceConnectionWithNameRootObjectUsingNameServerAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSString name, NSObject root, NSPortNameServer server)
		{
			return ms_class.Call("serviceConnectionWithName:rootObject:usingNameServer:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", name, root, server).To<NSObject>();
		}

		public static NSObject serviceConnectionWithNameRootObjectAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSString name, NSObject root)
		{
			return ms_class.Call("serviceConnectionWithName:rootObject:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", name, root).To<NSObject>();
		}

		public void setRequestTimeout(double ti)
		{
			Unused.Value = Call("setRequestTimeout:", ti);
		}

		public double requestTimeout()
		{
			return Call("requestTimeout").To<double>();
		}

		public void setReplyTimeout(double ti)
		{
			Unused.Value = Call("setReplyTimeout:", ti);
		}

		public double replyTimeout()
		{
			return Call("replyTimeout").To<double>();
		}

		public void setRootObject(NSObject anObject)
		{
			Unused.Value = Call("setRootObject:", anObject);
		}

		public NSObject rootObject()
		{
			return Call("rootObject").To<NSObject>();
		}

		public IntPtr rootProxy()
		{
			return Call("rootProxy").To<IntPtr>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setIndependentConversationQueueing(bool yorn)
		{
			Unused.Value = Call("setIndependentConversationQueueing:", yorn);
		}

		public bool independentConversationQueueing()
		{
			return Call("independentConversationQueueing").To<bool>();
		}

		public bool isValid()
		{
			return Call("isValid").To<bool>();
		}

		public void invalidate()
		{
			Unused.Value = Call("invalidate");
		}

		public void addRequestMode(NSString rmode)
		{
			Unused.Value = Call("addRequestMode:", rmode);
		}

		public void removeRequestMode(NSString rmode)
		{
			Unused.Value = Call("removeRequestMode:", rmode);
		}

		public NSArray requestModes()
		{
			return Call("requestModes").To<NSArray>();
		}

		public bool registerName(NSString name)
		{
			return Call("registerName:", name).To<bool>();
		}

		public bool registerNameWithNameServer(NSString name, NSPortNameServer server)
		{
			return Call("registerName:withNameServer:", name, server).To<bool>();
		}

		public static NSObject connectionWithReceivePortSendPort(NSPort receivePort, NSPort sendPort)
		{
			return ms_class.Call("connectionWithReceivePort:sendPort:", receivePort, sendPort).To<NSObject>();
		}

		public static NSObject currentConversation()
		{
			return ms_class.Call("currentConversation").To<NSObject>();
		}

		public NSObject initWithReceivePortSendPort(NSPort receivePort, NSPort sendPort)
		{
			return Call("initWithReceivePort:sendPort:", receivePort, sendPort).To<NSObject>();
		}

		public NSPort sendPort()
		{
			return Call("sendPort").To<NSPort>();
		}

		public NSPort receivePort()
		{
			return Call("receivePort").To<NSPort>();
		}

		public void enableMultipleThreads()
		{
			Unused.Value = Call("enableMultipleThreads");
		}

		public bool multipleThreadsEnabled()
		{
			return Call("multipleThreadsEnabled").To<bool>();
		}

		public void addRunLoop(NSRunLoop runloop)
		{
			Unused.Value = Call("addRunLoop:", runloop);
		}

		public void removeRunLoop(NSRunLoop runloop)
		{
			Unused.Value = Call("removeRunLoop:", runloop);
		}

		public void runInNewThread()
		{
			Unused.Value = Call("runInNewThread");
		}

		public NSArray remoteObjects()
		{
			return Call("remoteObjects").To<NSArray>();
		}

		public NSArray localObjects()
		{
			return Call("localObjects").To<NSArray>();
		}

		private static Class ms_class = new Class("NSConnection");
	}

	public static class NSConnectionDelegateMethodsForNSObjectCategory
	{
		public static bool makeNewConnectionSender(this NSObject _instance, NSConnection conn, NSConnection ancestor)
		{
			return _instance.Call("makeNewConnection:sender:", conn, ancestor).To<bool>();
		}

		public static bool connectionShouldMakeNewConnection(this NSObject _instance, NSConnection ancestor, NSConnection conn)
		{
			return _instance.Call("connection:shouldMakeNewConnection:", ancestor, conn).To<bool>();
		}

		public static NSData authenticationDataForComponents(this NSObject _instance, NSArray components)
		{
			return _instance.Call("authenticationDataForComponents:", components).To<NSData>();
		}

		public static bool authenticateComponentsWithData(this NSObject _instance, NSArray components, NSData signature)
		{
			return _instance.Call("authenticateComponents:withData:", components, signature).To<bool>();
		}

		public static NSObject createConversationForConnection(this NSObject _instance, NSConnection conn)
		{
			return _instance.Call("createConversationForConnection:", conn).To<NSObject>();
		}
	}

	[Register]
	public partial class NSDistantObjectRequest : NSObject
	{
		public NSDistantObjectRequest() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDistantObjectRequest(IntPtr instance) : base(instance)
		{
		}

		public NSDistantObjectRequest(Untyped instance) : base(instance)
		{
		}

		public static new NSDistantObjectRequest alloc()
		{
			return new NSDistantObjectRequest(ms_class.Call("alloc"));
		}

		public new NSDistantObjectRequest retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSInvocation invocation()
		{
			return Call("invocation").To<NSInvocation>();
		}

		public NSConnection connection()
		{
			return Call("connection").To<NSConnection>();
		}

		public NSObject conversation()
		{
			return Call("conversation").To<NSObject>();
		}

		public void replyWithException(NSException exception)
		{
			Unused.Value = Call("replyWithException:", exception);
		}

		private static Class ms_class = new Class("NSDistantObjectRequest");
	}

	public static class NSDistantObjectRequestMethodsForNSObjectCategory
	{
		public static bool connectionHandleRequest(this NSObject _instance, NSConnection connection, NSDistantObjectRequest doreq)
		{
			return _instance.Call("connection:handleRequest:", connection, doreq).To<bool>();
		}
	}
}
