// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLProtocol.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSURLProtocol : NSObject
	{
		public NSURLProtocol() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLProtocol(IntPtr instance) : base(instance)
		{
		}

		public NSURLProtocol(Untyped instance) : base(instance)
		{
		}

		public static new NSURLProtocol alloc()
		{
			return new NSURLProtocol(ms_class.Call("alloc"));
		}

		public new NSURLProtocol retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithRequestCachedResponseClient(NSURLRequest request, NSCachedURLResponse cachedResponse, NSObject client)
		{
			return Call("initWithRequest:cachedResponse:client:", request, cachedResponse, client).To<NSObject>();
		}

		public NSObject client()
		{
			return Call("client").To<NSObject>();
		}

		public NSURLRequest request()
		{
			return Call("request").To<NSURLRequest>();
		}

		public NSCachedURLResponse cachedResponse()
		{
			return Call("cachedResponse").To<NSCachedURLResponse>();
		}

		public static bool canInitWithRequest(NSURLRequest request)
		{
			return ms_class.Call("canInitWithRequest:", request).To<bool>();
		}

		public static NSURLRequest canonicalRequestForRequest(NSURLRequest request)
		{
			return ms_class.Call("canonicalRequestForRequest:", request).To<NSURLRequest>();
		}

		public static bool requestIsCacheEquivalentToRequest(NSURLRequest a, NSURLRequest b)
		{
			return ms_class.Call("requestIsCacheEquivalent:toRequest:", a, b).To<bool>();
		}

		public void startLoading()
		{
			Unused.Value = Call("startLoading");
		}

		public void stopLoading()
		{
			Unused.Value = Call("stopLoading");
		}

		public static NSObject propertyForKeyInRequest(NSString key, NSURLRequest request)
		{
			return ms_class.Call("propertyForKey:inRequest:", key, request).To<NSObject>();
		}

		public static void setPropertyForKeyInRequest(NSObject value, NSString key, NSMutableURLRequest request)
		{
			Unused.Value = ms_class.Call("setProperty:forKey:inRequest:", value, key, request);
		}

		public static void removePropertyForKeyInRequest(NSString key, NSMutableURLRequest request)
		{
			Unused.Value = ms_class.Call("removePropertyForKey:inRequest:", key, request);
		}

		public static bool registerClass(Class protocolClass)
		{
			return ms_class.Call("registerClass:", protocolClass).To<bool>();
		}

		public static void unregisterClass(Class protocolClass)
		{
			Unused.Value = ms_class.Call("unregisterClass:", protocolClass);
		}

		private static Class ms_class = new Class("NSURLProtocol");
	}
}
