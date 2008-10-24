// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSNetServices.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNetServicesUnknownError = -72000;
		public const int NSNetServicesCollisionError = -72001;
		public const int NSNetServicesNotFoundError = -72002;
		public const int NSNetServicesActivityInProgress = -72003;
		public const int NSNetServicesBadArgumentError = -72004;
		public const int NSNetServicesCancelledError = -72005;
		public const int NSNetServicesInvalidError = -72006;
		public const int NSNetServicesTimeoutError = -72007;
	}

	public partial class Enums
	{
		public const int NSNetServiceNoAutoRename = 1 << 0;
	}

	[Register]
	public partial class NSNetService : NSObject
	{
		public NSNetService() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNetService(IntPtr instance) : base(instance)
		{
		}

		public NSNetService(Untyped instance) : base(instance)
		{
		}

		public static new NSNetService alloc()
		{
			return new NSNetService(ms_class.Call("alloc"));
		}

		public new NSNetService retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithDomainTypeNamePort(NSString domain, NSString type, NSString name, Int32 port)
		{
			return Call("initWithDomain:type:name:port:", domain, type, name, port).To<NSObject>();
		}

		public NSObject initWithDomainTypeName(NSString domain, NSString type, NSString name)
		{
			return Call("initWithDomain:type:name:", domain, type, name).To<NSObject>();
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public void scheduleInRunLoopForMode(NSRunLoop aRunLoop, NSString mode)
		{
			Unused.Value = Call("scheduleInRunLoop:forMode:", aRunLoop, mode);
		}

		public void removeFromRunLoopForMode(NSRunLoop aRunLoop, NSString mode)
		{
			Unused.Value = Call("removeFromRunLoop:forMode:", aRunLoop, mode);
		}

		public NSString domain()
		{
			return Call("domain").To<NSString>();
		}

		public NSString type()
		{
			return Call("type").To<NSString>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public NSArray addresses()
		{
			return Call("addresses").To<NSArray>();
		}

		public Int32 port()
		{
			return Call("port").To<Int32>();
		}

		public void publish()
		{
			Unused.Value = Call("publish");
		}

		public void publishWithOptions(UInt32 options)
		{
			Unused.Value = Call("publishWithOptions:", options);
		}

		public void resolve()
		{
			Unused.Value = Call("resolve");
		}

		public void stop()
		{
			Unused.Value = Call("stop");
		}

		public static NSDictionary dictionaryFromTXTRecordData(NSData txtData)
		{
			return ms_class.Call("dictionaryFromTXTRecordData:", txtData).To<NSDictionary>();
		}

		public static NSData dataFromTXTRecordDictionary(NSDictionary txtDictionary)
		{
			return ms_class.Call("dataFromTXTRecordDictionary:", txtDictionary).To<NSData>();
		}

		public NSString hostName()
		{
			return Call("hostName").To<NSString>();
		}

		public void resolveWithTimeout(double timeout)
		{
			Unused.Value = Call("resolveWithTimeout:", timeout);
		}

		public bool getInputStreamOutputStream(IntPtr inputStream, IntPtr outputStream)
		{
			return Call("getInputStream:outputStream:", inputStream, outputStream).To<bool>();
		}

		public bool setTXTRecordData(NSData recordData)
		{
			return Call("setTXTRecordData:", recordData).To<bool>();
		}

		public NSData TXTRecordData()
		{
			return Call("TXTRecordData").To<NSData>();
		}

		public void startMonitoring()
		{
			Unused.Value = Call("startMonitoring");
		}

		public void stopMonitoring()
		{
			Unused.Value = Call("stopMonitoring");
		}

		private static Class ms_class = new Class("NSNetService");
	}

	[Register]
	public partial class NSNetServiceBrowser : NSObject
	{
		public NSNetServiceBrowser() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNetServiceBrowser(IntPtr instance) : base(instance)
		{
		}

		public NSNetServiceBrowser(Untyped instance) : base(instance)
		{
		}

		public static new NSNetServiceBrowser alloc()
		{
			return new NSNetServiceBrowser(ms_class.Call("alloc"));
		}

		public new NSNetServiceBrowser retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public void scheduleInRunLoopForMode(NSRunLoop aRunLoop, NSString mode)
		{
			Unused.Value = Call("scheduleInRunLoop:forMode:", aRunLoop, mode);
		}

		public void removeFromRunLoopForMode(NSRunLoop aRunLoop, NSString mode)
		{
			Unused.Value = Call("removeFromRunLoop:forMode:", aRunLoop, mode);
		}

		public void searchForBrowsableDomains()
		{
			Unused.Value = Call("searchForBrowsableDomains");
		}

		public void searchForRegistrationDomains()
		{
			Unused.Value = Call("searchForRegistrationDomains");
		}

		public void searchForServicesOfTypeInDomain(NSString type, NSString domainString)
		{
			Unused.Value = Call("searchForServicesOfType:inDomain:", type, domainString);
		}

		public void stop()
		{
			Unused.Value = Call("stop");
		}

		private static Class ms_class = new Class("NSNetServiceBrowser");
	}

	public static class NSNetServiceDelegateMethodsForNSObjectCategory
	{
		public static void netServiceWillPublish(this NSObject _instance, NSNetService sender)
		{
			Unused.Value = _instance.Call("netServiceWillPublish:", sender);
		}

		public static void netServiceDidPublish(this NSObject _instance, NSNetService sender)
		{
			Unused.Value = _instance.Call("netServiceDidPublish:", sender);
		}

		public static void netServiceDidNotPublish(this NSObject _instance, NSNetService sender, NSDictionary errorDict)
		{
			Unused.Value = _instance.Call("netService:didNotPublish:", sender, errorDict);
		}

		public static void netServiceWillResolve(this NSObject _instance, NSNetService sender)
		{
			Unused.Value = _instance.Call("netServiceWillResolve:", sender);
		}

		public static void netServiceDidResolveAddress(this NSObject _instance, NSNetService sender)
		{
			Unused.Value = _instance.Call("netServiceDidResolveAddress:", sender);
		}

		public static void netServiceDidNotResolve(this NSObject _instance, NSNetService sender, NSDictionary errorDict)
		{
			Unused.Value = _instance.Call("netService:didNotResolve:", sender, errorDict);
		}

		public static void netServiceDidStop(this NSObject _instance, NSNetService sender)
		{
			Unused.Value = _instance.Call("netServiceDidStop:", sender);
		}

		public static void netServiceDidUpdateTXTRecordData(this NSObject _instance, NSNetService sender, NSData data)
		{
			Unused.Value = _instance.Call("netService:didUpdateTXTRecordData:", sender, data);
		}
	}

	public static class NSNetServiceBrowserDelegateMethodsForNSObjectCategory
	{
		public static void netServiceBrowserWillSearch(this NSObject _instance, NSNetServiceBrowser aNetServiceBrowser)
		{
			Unused.Value = _instance.Call("netServiceBrowserWillSearch:", aNetServiceBrowser);
		}

		public static void netServiceBrowserDidStopSearch(this NSObject _instance, NSNetServiceBrowser aNetServiceBrowser)
		{
			Unused.Value = _instance.Call("netServiceBrowserDidStopSearch:", aNetServiceBrowser);
		}

		public static void netServiceBrowserDidNotSearch(this NSObject _instance, NSNetServiceBrowser aNetServiceBrowser, NSDictionary errorDict)
		{
			Unused.Value = _instance.Call("netServiceBrowser:didNotSearch:", aNetServiceBrowser, errorDict);
		}

		public static void netServiceBrowserDidFindDomainMoreComing(this NSObject _instance, NSNetServiceBrowser aNetServiceBrowser, NSString domainString, bool moreComing)
		{
			Unused.Value = _instance.Call("netServiceBrowser:didFindDomain:moreComing:", aNetServiceBrowser, domainString, moreComing);
		}

		public static void netServiceBrowserDidFindServiceMoreComing(this NSObject _instance, NSNetServiceBrowser aNetServiceBrowser, NSNetService aNetService, bool moreComing)
		{
			Unused.Value = _instance.Call("netServiceBrowser:didFindService:moreComing:", aNetServiceBrowser, aNetService, moreComing);
		}

		public static void netServiceBrowserDidRemoveDomainMoreComing(this NSObject _instance, NSNetServiceBrowser aNetServiceBrowser, NSString domainString, bool moreComing)
		{
			Unused.Value = _instance.Call("netServiceBrowser:didRemoveDomain:moreComing:", aNetServiceBrowser, domainString, moreComing);
		}

		public static void netServiceBrowserDidRemoveServiceMoreComing(this NSObject _instance, NSNetServiceBrowser aNetServiceBrowser, NSNetService aNetService, bool moreComing)
		{
			Unused.Value = _instance.Call("netServiceBrowser:didRemoveService:moreComing:", aNetServiceBrowser, aNetService, moreComing);
		}
	}

	public static class NSDeprecatedForNSNetServiceCategory
	{
		public static NSString protocolSpecificInformation(this NSNetService _instance)
		{
			return _instance.Call("protocolSpecificInformation").To<NSString>();
		}

		public static void setProtocolSpecificInformation(this NSNetService _instance, NSString specificInformation)
		{
			Unused.Value = _instance.Call("setProtocolSpecificInformation:", specificInformation);
		}
	}

	public static class NSDeprecatedForNSNetServiceBrowserCategory
	{
		public static void searchForAllDomains(this NSNetServiceBrowser _instance)
		{
			Unused.Value = _instance.Call("searchForAllDomains");
		}
	}
}
