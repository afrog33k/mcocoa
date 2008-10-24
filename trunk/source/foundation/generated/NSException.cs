// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSException.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSException : NSObject
	{
		public NSException() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSException(IntPtr instance) : base(instance)
		{
		}

		public NSException(Untyped instance) : base(instance)
		{
		}

		public static new NSException alloc()
		{
			return new NSException(ms_class.Call("alloc"));
		}

		public new NSException retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSException exceptionWithNameReasonUserInfo(NSString name, NSString reason, NSDictionary userInfo)
		{
			return ms_class.Call("exceptionWithName:reason:userInfo:", name, reason, userInfo).To<NSException>();
		}

		public NSObject initWithNameReasonUserInfo(NSString aName, NSString aReason, NSDictionary aUserInfo)
		{
			return Call("initWithName:reason:userInfo:", aName, aReason, aUserInfo).To<NSObject>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public NSString reason()
		{
			return Call("reason").To<NSString>();
		}

		public NSDictionary userInfo()
		{
			return Call("userInfo").To<NSDictionary>();
		}

		public NSArray callStackReturnAddressesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER()
		{
			return Call("callStackReturnAddressesAVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER").To<NSArray>();
		}

		public void raise()
		{
			Unused.Value = Call("raise");
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

		private static Class ms_class = new Class("NSException");
	}

	public static class NSExceptionRaisingConveniencesForNSExceptionCategory
	{
		// skipping raise:format: because it is variadic

		public static void raiseFormatArguments(this NSException _instance, NSString name, NSString format, IntPtr argList)
		{
			Unused.Value = _instance.Call("raise:format:arguments:", name, format, argList);
		}
	}

	[Register]
	public partial class NSAssertionHandler : NSObject
	{
		public NSAssertionHandler() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAssertionHandler(IntPtr instance) : base(instance)
		{
		}

		public NSAssertionHandler(Untyped instance) : base(instance)
		{
		}

		public static new NSAssertionHandler alloc()
		{
			return new NSAssertionHandler(ms_class.Call("alloc"));
		}

		public new NSAssertionHandler retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSAssertionHandler currentHandler()
		{
			return ms_class.Call("currentHandler").To<NSAssertionHandler>();
		}

		// skipping handleFailureInMethod:object:file:lineNumber:description: because it is variadic

		// skipping handleFailureInFunction:file:lineNumber:description: because it is variadic

		private static Class ms_class = new Class("NSAssertionHandler");
	}
}
