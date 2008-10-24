// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLRequest.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSURLRequestUseProtocolCachePolicy = 0;
		public const int NSURLRequestReloadIgnoringLocalCacheData = 1;
		public const int NSURLRequestReloadIgnoringLocalAndRemoteCacheData = 4;
		public const int NSURLRequestReloadIgnoringCacheData = NSURLRequestReloadIgnoringLocalCacheData;
		public const int NSURLRequestReturnCacheDataElseLoad = 2;
		public const int NSURLRequestReturnCacheDataDontLoad = 3;
		public const int NSURLRequestReloadRevalidatingCacheData = 5;
	}

	[Register]
	public partial class NSURLRequest : NSObject
	{
		public NSURLRequest() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLRequest(IntPtr instance) : base(instance)
		{
		}

		public NSURLRequest(Untyped instance) : base(instance)
		{
		}

		public static new NSURLRequest alloc()
		{
			return new NSURLRequest(ms_class.Call("alloc"));
		}

		public new NSURLRequest retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject requestWithURL(NSURL URL)
		{
			return ms_class.Call("requestWithURL:", URL).To<NSObject>();
		}

		public static NSObject requestWithURLCachePolicyTimeoutInterval(NSURL URL, UInt32 cachePolicy, double timeoutInterval)
		{
			return ms_class.Call("requestWithURL:cachePolicy:timeoutInterval:", URL, cachePolicy, timeoutInterval).To<NSObject>();
		}

		public NSObject initWithURL(NSURL URL)
		{
			return Call("initWithURL:", URL).To<NSObject>();
		}

		public NSObject initWithURLCachePolicyTimeoutInterval(NSURL URL, UInt32 cachePolicy, double timeoutInterval)
		{
			return Call("initWithURL:cachePolicy:timeoutInterval:", URL, cachePolicy, timeoutInterval).To<NSObject>();
		}

		public NSURL URL()
		{
			return Call("URL").To<NSURL>();
		}

		public UInt32 cachePolicy()
		{
			return Call("cachePolicy").To<UInt32>();
		}

		public double timeoutInterval()
		{
			return Call("timeoutInterval").To<double>();
		}

		public NSURL mainDocumentURL()
		{
			return Call("mainDocumentURL").To<NSURL>();
		}

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

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSMutableCopying Methods
		public NSObject mutableCopyWithZone(IntPtr zone)
		{
			return Call("mutableCopyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSURLRequest");
	}

	[Register]
	public partial class NSMutableURLRequest : NSURLRequest
	{
		public NSMutableURLRequest() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableURLRequest(IntPtr instance) : base(instance)
		{
		}

		public NSMutableURLRequest(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableURLRequest alloc()
		{
			return new NSMutableURLRequest(ms_class.Call("alloc"));
		}

		public new NSMutableURLRequest retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setURL(NSURL URL)
		{
			Unused.Value = Call("setURL:", URL);
		}

		public void setCachePolicy(UInt32 policy)
		{
			Unused.Value = Call("setCachePolicy:", policy);
		}

		public void setTimeoutInterval(double seconds)
		{
			Unused.Value = Call("setTimeoutInterval:", seconds);
		}

		public void setMainDocumentURL(NSURL URL)
		{
			Unused.Value = Call("setMainDocumentURL:", URL);
		}

		private static Class ms_class = new Class("NSMutableURLRequest");
	}

	public static class NSHTTPURLRequestForNSURLRequestCategory
	{
		public static NSString HTTPMethod(this NSURLRequest _instance)
		{
			return _instance.Call("HTTPMethod").To<NSString>();
		}

		public static NSDictionary allHTTPHeaderFields(this NSURLRequest _instance)
		{
			return _instance.Call("allHTTPHeaderFields").To<NSDictionary>();
		}

		public static NSString valueForHTTPHeaderField(this NSURLRequest _instance, NSString field)
		{
			return _instance.Call("valueForHTTPHeaderField:", field).To<NSString>();
		}

		public static NSData HTTPBody(this NSURLRequest _instance)
		{
			return _instance.Call("HTTPBody").To<NSData>();
		}

		public static NSInputStream HTTPBodyStream(this NSURLRequest _instance)
		{
			return _instance.Call("HTTPBodyStream").To<NSInputStream>();
		}

		public static bool HTTPShouldHandleCookies(this NSURLRequest _instance)
		{
			return _instance.Call("HTTPShouldHandleCookies").To<bool>();
		}
	}

	public static class NSMutableHTTPURLRequestForNSMutableURLRequestCategory
	{
		public static void setHTTPMethod(this NSMutableURLRequest _instance, NSString method)
		{
			Unused.Value = _instance.Call("setHTTPMethod:", method);
		}

		public static void setAllHTTPHeaderFields(this NSMutableURLRequest _instance, NSDictionary headerFields)
		{
			Unused.Value = _instance.Call("setAllHTTPHeaderFields:", headerFields);
		}

		public static void setValueForHTTPHeaderField(this NSMutableURLRequest _instance, NSString value, NSString field)
		{
			Unused.Value = _instance.Call("setValue:forHTTPHeaderField:", value, field);
		}

		public static void addValueForHTTPHeaderField(this NSMutableURLRequest _instance, NSString value, NSString field)
		{
			Unused.Value = _instance.Call("addValue:forHTTPHeaderField:", value, field);
		}

		public static void setHTTPBody(this NSMutableURLRequest _instance, NSData data)
		{
			Unused.Value = _instance.Call("setHTTPBody:", data);
		}

		public static void setHTTPBodyStream(this NSMutableURLRequest _instance, NSInputStream inputStream)
		{
			Unused.Value = _instance.Call("setHTTPBodyStream:", inputStream);
		}

		public static void setHTTPShouldHandleCookies(this NSMutableURLRequest _instance, bool should)
		{
			Unused.Value = _instance.Call("setHTTPShouldHandleCookies:", should);
		}
	}
}
