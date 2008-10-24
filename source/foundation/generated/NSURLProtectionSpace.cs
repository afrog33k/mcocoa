// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLProtectionSpace.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSURLProtectionSpace : NSObject
	{
		public NSURLProtectionSpace() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLProtectionSpace(IntPtr instance) : base(instance)
		{
		}

		public NSURLProtectionSpace(Untyped instance) : base(instance)
		{
		}

		public static new NSURLProtectionSpace alloc()
		{
			return new NSURLProtectionSpace(ms_class.Call("alloc"));
		}

		public new NSURLProtectionSpace retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithHostPortProtocolRealmAuthenticationMethod(NSString host, Int32 port, NSString protocol, NSString realm, NSString authenticationMethod)
		{
			return Call("initWithHost:port:protocol:realm:authenticationMethod:", host, port, protocol, realm, authenticationMethod).To<NSObject>();
		}

		public NSObject initWithProxyHostPortTypeRealmAuthenticationMethod(NSString host, Int32 port, NSString type, NSString realm, NSString authenticationMethod)
		{
			return Call("initWithProxyHost:port:type:realm:authenticationMethod:", host, port, type, realm, authenticationMethod).To<NSObject>();
		}

		public NSString realm()
		{
			return Call("realm").To<NSString>();
		}

		public bool receivesCredentialSecurely()
		{
			return Call("receivesCredentialSecurely").To<bool>();
		}

		// skipping isProxy (it's already defined)

		public NSString host()
		{
			return Call("host").To<NSString>();
		}

		public Int32 port()
		{
			return Call("port").To<Int32>();
		}

		public NSString proxyType()
		{
			return Call("proxyType").To<NSString>();
		}

		public NSString protocol()
		{
			return Call("protocol").To<NSString>();
		}

		public NSString authenticationMethod()
		{
			return Call("authenticationMethod").To<NSString>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSURLProtectionSpace");
	}
}
