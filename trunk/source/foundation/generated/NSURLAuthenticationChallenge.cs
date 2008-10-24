// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLAuthenticationChallenge.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSURLAuthenticationChallenge : NSObject
	{
		public NSURLAuthenticationChallenge() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLAuthenticationChallenge(IntPtr instance) : base(instance)
		{
		}

		public NSURLAuthenticationChallenge(Untyped instance) : base(instance)
		{
		}

		public static new NSURLAuthenticationChallenge alloc()
		{
			return new NSURLAuthenticationChallenge(ms_class.Call("alloc"));
		}

		public new NSURLAuthenticationChallenge retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithProtectionSpaceProposedCredentialPreviousFailureCountFailureResponseErrorSender(NSURLProtectionSpace space, NSURLCredential credential, Int32 previousFailureCount, NSURLResponse response, NSError error, NSObject sender)
		{
			return Call("initWithProtectionSpace:proposedCredential:previousFailureCount:failureResponse:error:sender:", space, credential, previousFailureCount, response, error, sender).To<NSObject>();
		}

		public NSObject initWithAuthenticationChallengeSender(NSURLAuthenticationChallenge challenge, NSObject sender)
		{
			return Call("initWithAuthenticationChallenge:sender:", challenge, sender).To<NSObject>();
		}

		public NSURLProtectionSpace protectionSpace()
		{
			return Call("protectionSpace").To<NSURLProtectionSpace>();
		}

		public NSURLCredential proposedCredential()
		{
			return Call("proposedCredential").To<NSURLCredential>();
		}

		public Int32 previousFailureCount()
		{
			return Call("previousFailureCount").To<Int32>();
		}

		public NSURLResponse failureResponse()
		{
			return Call("failureResponse").To<NSURLResponse>();
		}

		public NSError error()
		{
			return Call("error").To<NSError>();
		}

		public NSObject sender()
		{
			return Call("sender").To<NSObject>();
		}

		private static Class ms_class = new Class("NSURLAuthenticationChallenge");
	}
}
