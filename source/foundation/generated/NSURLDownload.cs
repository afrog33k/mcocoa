// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLDownload.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSURLDownload : NSObject
	{
		public NSURLDownload() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLDownload(IntPtr instance) : base(instance)
		{
		}

		public NSURLDownload(Untyped instance) : base(instance)
		{
		}

		public static new NSURLDownload alloc()
		{
			return new NSURLDownload(ms_class.Call("alloc"));
		}

		public new NSURLDownload retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static bool canResumeDownloadDecodedWithEncodingMIMEType(NSString MIMEType)
		{
			return ms_class.Call("canResumeDownloadDecodedWithEncodingMIMEType:", MIMEType).To<bool>();
		}

		public NSObject initWithRequestDelegate(NSURLRequest request, NSObject delegate_)
		{
			return Call("initWithRequest:delegate:", request, delegate_).To<NSObject>();
		}

		public NSObject initWithResumeDataDelegatePath(NSData resumeData, NSObject delegate_, NSString path)
		{
			return Call("initWithResumeData:delegate:path:", resumeData, delegate_, path).To<NSObject>();
		}

		public void cancel()
		{
			Unused.Value = Call("cancel");
		}

		public void setDestinationAllowOverwrite(NSString path, bool allowOverwrite)
		{
			Unused.Value = Call("setDestination:allowOverwrite:", path, allowOverwrite);
		}

		public NSURLRequest request()
		{
			return Call("request").To<NSURLRequest>();
		}

		public NSData resumeData()
		{
			return Call("resumeData").To<NSData>();
		}

		public void setDeletesFileUponFailure(bool deletesFileUponFailure)
		{
			Unused.Value = Call("setDeletesFileUponFailure:", deletesFileUponFailure);
		}

		public bool deletesFileUponFailure()
		{
			return Call("deletesFileUponFailure").To<bool>();
		}

		private static Class ms_class = new Class("NSURLDownload");
	}

	public static class NSURLDownloadDelegateForNSObjectCategory
	{
		public static void downloadDidBegin(this NSObject _instance, NSURLDownload download)
		{
			Unused.Value = _instance.Call("downloadDidBegin:", download);
		}

		public static NSURLRequest downloadWillSendRequestRedirectResponse(this NSObject _instance, NSURLDownload download, NSURLRequest request, NSURLResponse redirectResponse)
		{
			return _instance.Call("download:willSendRequest:redirectResponse:", download, request, redirectResponse).To<NSURLRequest>();
		}

		public static void downloadDidReceiveAuthenticationChallenge(this NSObject _instance, NSURLDownload download, NSURLAuthenticationChallenge challenge)
		{
			Unused.Value = _instance.Call("download:didReceiveAuthenticationChallenge:", download, challenge);
		}

		public static void downloadDidCancelAuthenticationChallenge(this NSObject _instance, NSURLDownload download, NSURLAuthenticationChallenge challenge)
		{
			Unused.Value = _instance.Call("download:didCancelAuthenticationChallenge:", download, challenge);
		}

		public static void downloadDidReceiveResponse(this NSObject _instance, NSURLDownload download, NSURLResponse response)
		{
			Unused.Value = _instance.Call("download:didReceiveResponse:", download, response);
		}

		public static void downloadWillResumeWithResponseFromByte(this NSObject _instance, NSURLDownload download, NSURLResponse response, Int64 startingByte)
		{
			Unused.Value = _instance.Call("download:willResumeWithResponse:fromByte:", download, response, startingByte);
		}

		public static void downloadDidReceiveDataOfLength(this NSObject _instance, NSURLDownload download, UInt32 length)
		{
			Unused.Value = _instance.Call("download:didReceiveDataOfLength:", download, length);
		}

		public static bool downloadShouldDecodeSourceDataOfMIMEType(this NSObject _instance, NSURLDownload download, NSString encodingType)
		{
			return _instance.Call("download:shouldDecodeSourceDataOfMIMEType:", download, encodingType).To<bool>();
		}

		public static void downloadDecideDestinationWithSuggestedFilename(this NSObject _instance, NSURLDownload download, NSString filename)
		{
			Unused.Value = _instance.Call("download:decideDestinationWithSuggestedFilename:", download, filename);
		}

		public static void downloadDidCreateDestination(this NSObject _instance, NSURLDownload download, NSString path)
		{
			Unused.Value = _instance.Call("download:didCreateDestination:", download, path);
		}

		public static void downloadDidFinish(this NSObject _instance, NSURLDownload download)
		{
			Unused.Value = _instance.Call("downloadDidFinish:", download);
		}

		public static void downloadDidFailWithError(this NSObject _instance, NSURLDownload download, NSError error)
		{
			Unused.Value = _instance.Call("download:didFailWithError:", download, error);
		}
	}
}
