// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSHTTPCookie.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSHTTPCookie : NSObject
	{
		public NSHTTPCookie() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSHTTPCookie(IntPtr instance) : base(instance)
		{
		}

		public NSHTTPCookie(Untyped instance) : base(instance)
		{
		}

		public static new NSHTTPCookie alloc()
		{
			return new NSHTTPCookie(ms_class.Call("alloc"));
		}

		public new NSHTTPCookie retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithProperties(NSDictionary properties)
		{
			return Call("initWithProperties:", properties).To<NSObject>();
		}

		public static NSObject cookieWithProperties(NSDictionary properties)
		{
			return ms_class.Call("cookieWithProperties:", properties).To<NSObject>();
		}

		public static NSDictionary requestHeaderFieldsWithCookies(NSArray cookies)
		{
			return ms_class.Call("requestHeaderFieldsWithCookies:", cookies).To<NSDictionary>();
		}

		public static NSArray cookiesWithResponseHeaderFieldsForURL(NSDictionary headerFields, NSURL URL)
		{
			return ms_class.Call("cookiesWithResponseHeaderFields:forURL:", headerFields, URL).To<NSArray>();
		}

		public NSDictionary properties()
		{
			return Call("properties").To<NSDictionary>();
		}

		public UInt32 version()
		{
			return Call("version").To<UInt32>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public NSString value()
		{
			return Call("value").To<NSString>();
		}

		public NSDate expiresDate()
		{
			return Call("expiresDate").To<NSDate>();
		}

		public bool isSessionOnly()
		{
			return Call("isSessionOnly").To<bool>();
		}

		public NSString domain()
		{
			return Call("domain").To<NSString>();
		}

		public NSString path()
		{
			return Call("path").To<NSString>();
		}

		public bool isSecure()
		{
			return Call("isSecure").To<bool>();
		}

		public NSString comment()
		{
			return Call("comment").To<NSString>();
		}

		public NSURL commentURL()
		{
			return Call("commentURL").To<NSURL>();
		}

		public NSArray portList()
		{
			return Call("portList").To<NSArray>();
		}

		private static Class ms_class = new Class("NSHTTPCookie");
	}
}
