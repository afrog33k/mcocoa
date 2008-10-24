// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLCache.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSURLCacheStorageAllowed = 0;
		public const int NSURLCacheStorageAllowedInMemoryOnly = 1;
		public const int NSURLCacheStorageNotAllowed = 2;
	}

	[Register]
	public partial class NSCachedURLResponse : NSObject
	{
		public NSCachedURLResponse() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCachedURLResponse(IntPtr instance) : base(instance)
		{
		}

		public NSCachedURLResponse(Untyped instance) : base(instance)
		{
		}

		public static new NSCachedURLResponse alloc()
		{
			return new NSCachedURLResponse(ms_class.Call("alloc"));
		}

		public new NSCachedURLResponse retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithResponseData(NSURLResponse response, NSData data)
		{
			return Call("initWithResponse:data:", response, data).To<NSObject>();
		}

		public NSObject initWithResponseDataUserInfoStoragePolicy(NSURLResponse response, NSData data, NSDictionary userInfo, UInt32 storagePolicy)
		{
			return Call("initWithResponse:data:userInfo:storagePolicy:", response, data, userInfo, storagePolicy).To<NSObject>();
		}

		public NSURLResponse response()
		{
			return Call("response").To<NSURLResponse>();
		}

		public NSData data()
		{
			return Call("data").To<NSData>();
		}

		public NSDictionary userInfo()
		{
			return Call("userInfo").To<NSDictionary>();
		}

		public UInt32 storagePolicy()
		{
			return Call("storagePolicy").To<UInt32>();
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

		private static Class ms_class = new Class("NSCachedURLResponse");
	}

	[Register]
	public partial class NSURLCache : NSObject
	{
		public NSURLCache() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLCache(IntPtr instance) : base(instance)
		{
		}

		public NSURLCache(Untyped instance) : base(instance)
		{
		}

		public static new NSURLCache alloc()
		{
			return new NSURLCache(ms_class.Call("alloc"));
		}

		public new NSURLCache retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSURLCache sharedURLCache()
		{
			return ms_class.Call("sharedURLCache").To<NSURLCache>();
		}

		public static void setSharedURLCache(NSURLCache cache)
		{
			Unused.Value = ms_class.Call("setSharedURLCache:", cache);
		}

		public NSObject initWithMemoryCapacityDiskCapacityDiskPath(UInt32 memoryCapacity, UInt32 diskCapacity, NSString path)
		{
			return Call("initWithMemoryCapacity:diskCapacity:diskPath:", memoryCapacity, diskCapacity, path).To<NSObject>();
		}

		public NSCachedURLResponse cachedResponseForRequest(NSURLRequest request)
		{
			return Call("cachedResponseForRequest:", request).To<NSCachedURLResponse>();
		}

		public void storeCachedResponseForRequest(NSCachedURLResponse cachedResponse, NSURLRequest request)
		{
			Unused.Value = Call("storeCachedResponse:forRequest:", cachedResponse, request);
		}

		public void removeCachedResponseForRequest(NSURLRequest request)
		{
			Unused.Value = Call("removeCachedResponseForRequest:", request);
		}

		public void removeAllCachedResponses()
		{
			Unused.Value = Call("removeAllCachedResponses");
		}

		public UInt32 memoryCapacity()
		{
			return Call("memoryCapacity").To<UInt32>();
		}

		public UInt32 diskCapacity()
		{
			return Call("diskCapacity").To<UInt32>();
		}

		public void setMemoryCapacity(UInt32 memoryCapacity)
		{
			Unused.Value = Call("setMemoryCapacity:", memoryCapacity);
		}

		public void setDiskCapacity(UInt32 diskCapacity)
		{
			Unused.Value = Call("setDiskCapacity:", diskCapacity);
		}

		public UInt32 currentMemoryUsage()
		{
			return Call("currentMemoryUsage").To<UInt32>();
		}

		public UInt32 currentDiskUsage()
		{
			return Call("currentDiskUsage").To<UInt32>();
		}

		private static Class ms_class = new Class("NSURLCache");
	}
}
