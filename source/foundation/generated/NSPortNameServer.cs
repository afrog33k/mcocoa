// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPortNameServer.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPortNameServer : NSObject
	{
		public NSPortNameServer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPortNameServer(IntPtr instance) : base(instance)
		{
		}

		public NSPortNameServer(Untyped instance) : base(instance)
		{
		}

		public static new NSPortNameServer alloc()
		{
			return new NSPortNameServer(ms_class.Call("alloc"));
		}

		public new NSPortNameServer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSPortNameServer systemDefaultPortNameServer()
		{
			return ms_class.Call("systemDefaultPortNameServer").To<NSPortNameServer>();
		}

		public NSPort portForName(NSString name)
		{
			return Call("portForName:", name).To<NSPort>();
		}

		public NSPort portForNameHost(NSString name, NSString host)
		{
			return Call("portForName:host:", name, host).To<NSPort>();
		}

		public bool registerPortName(NSPort port, NSString name)
		{
			return Call("registerPort:name:", port, name).To<bool>();
		}

		public bool removePortForName(NSString name)
		{
			return Call("removePortForName:", name).To<bool>();
		}

		private static Class ms_class = new Class("NSPortNameServer");
	}

	[Register]
	public partial class NSMachBootstrapServer : NSPortNameServer
	{
		public NSMachBootstrapServer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMachBootstrapServer(IntPtr instance) : base(instance)
		{
		}

		public NSMachBootstrapServer(Untyped instance) : base(instance)
		{
		}

		public static new NSMachBootstrapServer alloc()
		{
			return new NSMachBootstrapServer(ms_class.Call("alloc"));
		}

		public new NSMachBootstrapServer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject sharedInstance()
		{
			return ms_class.Call("sharedInstance").To<NSObject>();
		}

		// skipping portForName: (it's declared in a base class)

		// skipping portForName:host: (it's declared in a base class)

		// skipping registerPort:name: (it's declared in a base class)

		public NSPort servicePortWithNameAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSString name)
		{
			return Call("servicePortWithName:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", name).To<NSPort>();
		}

		private static Class ms_class = new Class("NSMachBootstrapServer");
	}

	[Register]
	public partial class NSMessagePortNameServer : NSPortNameServer
	{
		public NSMessagePortNameServer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMessagePortNameServer(IntPtr instance) : base(instance)
		{
		}

		public NSMessagePortNameServer(Untyped instance) : base(instance)
		{
		}

		public static new NSMessagePortNameServer alloc()
		{
			return new NSMessagePortNameServer(ms_class.Call("alloc"));
		}

		public new NSMessagePortNameServer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject sharedInstance()
		{
			return ms_class.Call("sharedInstance").To<NSObject>();
		}

		// skipping portForName: (it's declared in a base class)

		// skipping portForName:host: (it's declared in a base class)

		private static Class ms_class = new Class("NSMessagePortNameServer");
	}

	[Register]
	public partial class NSSocketPortNameServer : NSPortNameServer
	{
		public NSSocketPortNameServer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSocketPortNameServer(IntPtr instance) : base(instance)
		{
		}

		public NSSocketPortNameServer(Untyped instance) : base(instance)
		{
		}

		public static new NSSocketPortNameServer alloc()
		{
			return new NSSocketPortNameServer(ms_class.Call("alloc"));
		}

		public new NSSocketPortNameServer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject sharedInstance()
		{
			return ms_class.Call("sharedInstance").To<NSObject>();
		}

		// skipping portForName: (it's declared in a base class)

		// skipping portForName:host: (it's declared in a base class)

		// skipping registerPort:name: (it's declared in a base class)

		// skipping removePortForName: (it's declared in a base class)

		public NSPort portForNameHostNameServerPortNumber(NSString name, NSString host, UInt16 portNumber)
		{
			return Call("portForName:host:nameServerPortNumber:", name, host, portNumber).To<NSPort>();
		}

		public bool registerPortNameNameServerPortNumber(NSPort port, NSString name, UInt16 portNumber)
		{
			return Call("registerPort:name:nameServerPortNumber:", port, name, portNumber).To<bool>();
		}

		public void setDefaultNameServerPortNumber(UInt16 portNumber)
		{
			Unused.Value = Call("setDefaultNameServerPortNumber:", portNumber);
		}

		public UInt16 defaultNameServerPortNumber()
		{
			return Call("defaultNameServerPortNumber").To<UInt16>();
		}

		private static Class ms_class = new Class("NSSocketPortNameServer");
	}
}
