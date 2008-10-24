// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSError.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSError : NSObject
	{
		public NSError() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSError(IntPtr instance) : base(instance)
		{
		}

		public NSError(Untyped instance) : base(instance)
		{
		}

		public static new NSError alloc()
		{
			return new NSError(ms_class.Call("alloc"));
		}

		public new NSError retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithDomainCodeUserInfo(NSString domain, Int32 code, NSDictionary dict)
		{
			return Call("initWithDomain:code:userInfo:", domain, code, dict).To<NSObject>();
		}

		public static NSObject errorWithDomainCodeUserInfo(NSString domain, Int32 code, NSDictionary dict)
		{
			return ms_class.Call("errorWithDomain:code:userInfo:", domain, code, dict).To<NSObject>();
		}

		public NSString domain()
		{
			return Call("domain").To<NSString>();
		}

		public Int32 code()
		{
			return Call("code").To<Int32>();
		}

		public NSDictionary userInfo()
		{
			return Call("userInfo").To<NSDictionary>();
		}

		public NSString localizedDescription()
		{
			return Call("localizedDescription").To<NSString>();
		}

		public NSString localizedFailureReason()
		{
			return Call("localizedFailureReason").To<NSString>();
		}

		public NSString localizedRecoverySuggestion()
		{
			return Call("localizedRecoverySuggestion").To<NSString>();
		}

		public NSArray localizedRecoveryOptions()
		{
			return Call("localizedRecoveryOptions").To<NSArray>();
		}

		public NSObject recoveryAttempter()
		{
			return Call("recoveryAttempter").To<NSObject>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSError");
	}

	public static class NSErrorRecoveryAttemptingForNSObjectCategory
	{
		public static void attemptRecoveryFromErrorOptionIndexDelegateDidRecoverSelectorContextInfo(this NSObject _instance, NSError error, UInt32 recoveryOptionIndex, NSObject delegate_, Selector didRecoverSelector, IntPtr contextInfo)
		{
			Unused.Value = _instance.Call("attemptRecoveryFromError:optionIndex:delegate:didRecoverSelector:contextInfo:", error, recoveryOptionIndex, delegate_, didRecoverSelector, contextInfo);
		}

		public static bool attemptRecoveryFromErrorOptionIndex(this NSObject _instance, NSError error, UInt32 recoveryOptionIndex)
		{
			return _instance.Call("attemptRecoveryFromError:optionIndex:", error, recoveryOptionIndex).To<bool>();
		}
	}
}
