// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLConnection.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSURLConnection : NSObject
	{
		public NSURLConnection() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLConnection(IntPtr instance) : base(instance)
		{
		}

		public NSURLConnection(Untyped instance) : base(instance)
		{
		}

		public static new NSURLConnection alloc()
		{
			return new NSURLConnection(ms_class.Call("alloc"));
		}

		public new NSURLConnection retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static bool canHandleRequest(NSURLRequest request)
		{
			return ms_class.Call("canHandleRequest:", request).To<bool>();
		}

		public static NSURLConnection connectionWithRequestDelegate(NSURLRequest request, NSObject delegate_)
		{
			return ms_class.Call("connectionWithRequest:delegate:", request, delegate_).To<NSURLConnection>();
		}

		public NSObject initWithRequestDelegate(NSURLRequest request, NSObject delegate_)
		{
			return Call("initWithRequest:delegate:", request, delegate_).To<NSObject>();
		}

		public NSObject initWithRequestDelegateStartImmediatelyAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSURLRequest request, NSObject delegate_, bool startImmediately)
		{
			return Call("initWithRequest:delegate:startImmediately:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", request, delegate_, startImmediately).To<NSObject>();
		}

		public void startAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			Unused.Value = Call("startAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER");
		}

		public void cancel()
		{
			Unused.Value = Call("cancel");
		}

		public void scheduleInRunLoopForModeAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSRunLoop aRunLoop, NSString mode)
		{
			Unused.Value = Call("scheduleInRunLoop:forMode:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", aRunLoop, mode);
		}

		public void unscheduleFromRunLoopForModeAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER(NSRunLoop aRunLoop, NSString mode)
		{
			Unused.Value = Call("unscheduleFromRunLoop:forMode:AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER", aRunLoop, mode);
		}

		private static Class ms_class = new Class("NSURLConnection");
	}

	public static class NSURLConnectionDelegateForNSObjectCategory
	{
		public static NSURLRequest connectionWillSendRequestRedirectResponse(this NSObject _instance, NSURLConnection connection, NSURLRequest request, NSURLResponse response)
		{
			return _instance.Call("connection:willSendRequest:redirectResponse:", connection, request, response).To<NSURLRequest>();
		}

		public static void connectionDidReceiveAuthenticationChallenge(this NSObject _instance, NSURLConnection connection, NSURLAuthenticationChallenge challenge)
		{
			Unused.Value = _instance.Call("connection:didReceiveAuthenticationChallenge:", connection, challenge);
		}

		public static void connectionDidCancelAuthenticationChallenge(this NSObject _instance, NSURLConnection connection, NSURLAuthenticationChallenge challenge)
		{
			Unused.Value = _instance.Call("connection:didCancelAuthenticationChallenge:", connection, challenge);
		}

		public static void connectionDidReceiveResponse(this NSObject _instance, NSURLConnection connection, NSURLResponse response)
		{
			Unused.Value = _instance.Call("connection:didReceiveResponse:", connection, response);
		}

		public static void connectionDidReceiveData(this NSObject _instance, NSURLConnection connection, NSData data)
		{
			Unused.Value = _instance.Call("connection:didReceiveData:", connection, data);
		}

		public static void connectionDidFinishLoading(this NSObject _instance, NSURLConnection connection)
		{
			Unused.Value = _instance.Call("connectionDidFinishLoading:", connection);
		}

		public static void connectionDidFailWithError(this NSObject _instance, NSURLConnection connection, NSError error)
		{
			Unused.Value = _instance.Call("connection:didFailWithError:", connection, error);
		}

		public static NSCachedURLResponse connectionWillCacheResponse(this NSObject _instance, NSURLConnection connection, NSCachedURLResponse cachedResponse)
		{
			return _instance.Call("connection:willCacheResponse:", connection, cachedResponse).To<NSCachedURLResponse>();
		}
	}

	public static class NSURLConnectionSynchronousLoadingForNSURLConnectionCategory
	{
		public static NSData sendSynchronousRequestReturningResponseError(this NSURLConnection _instance, NSURLRequest request, IntPtr response, IntPtr error)
		{
			return _instance.Call("sendSynchronousRequest:returningResponse:error:", request, response, error).To<NSData>();
		}
	}
}
