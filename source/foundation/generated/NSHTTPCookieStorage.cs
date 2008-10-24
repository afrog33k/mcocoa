// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSHTTPCookieStorage.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSHTTPCookieAcceptPolicyAlways = 0;
		public const int NSHTTPCookieAcceptPolicyNever = 1;
		public const int NSHTTPCookieAcceptPolicyOnlyFromMainDocumentDomain = 2;
	}

	[Register]
	public partial class NSHTTPCookieStorage : NSObject
	{
		public NSHTTPCookieStorage() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSHTTPCookieStorage(IntPtr instance) : base(instance)
		{
		}

		public NSHTTPCookieStorage(Untyped instance) : base(instance)
		{
		}

		public static new NSHTTPCookieStorage alloc()
		{
			return new NSHTTPCookieStorage(ms_class.Call("alloc"));
		}

		public new NSHTTPCookieStorage retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSHTTPCookieStorage sharedHTTPCookieStorage()
		{
			return ms_class.Call("sharedHTTPCookieStorage").To<NSHTTPCookieStorage>();
		}

		public NSArray cookies()
		{
			return Call("cookies").To<NSArray>();
		}

		public void setCookie(NSHTTPCookie cookie)
		{
			Unused.Value = Call("setCookie:", cookie);
		}

		public void deleteCookie(NSHTTPCookie cookie)
		{
			Unused.Value = Call("deleteCookie:", cookie);
		}

		public NSArray cookiesForURL(NSURL URL)
		{
			return Call("cookiesForURL:", URL).To<NSArray>();
		}

		public void setCookiesForURLMainDocumentURL(NSArray cookies, NSURL URL, NSURL mainDocumentURL)
		{
			Unused.Value = Call("setCookies:forURL:mainDocumentURL:", cookies, URL, mainDocumentURL);
		}

		public UInt32 cookieAcceptPolicy()
		{
			return Call("cookieAcceptPolicy").To<UInt32>();
		}

		public void setCookieAcceptPolicy(UInt32 cookieAcceptPolicy)
		{
			Unused.Value = Call("setCookieAcceptPolicy:", cookieAcceptPolicy);
		}

		private static Class ms_class = new Class("NSHTTPCookieStorage");
	}
}
