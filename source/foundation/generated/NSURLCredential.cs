// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLCredential.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSURLCredentialPersistenceNone = 0;
		public const int NSURLCredentialPersistenceForSession = 1;
		public const int NSURLCredentialPersistencePermanent = 2;
	}

	[Register]
	public partial class NSURLCredential : NSObject
	{
		public NSURLCredential() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLCredential(IntPtr instance) : base(instance)
		{
		}

		public NSURLCredential(Untyped instance) : base(instance)
		{
		}

		public static new NSURLCredential alloc()
		{
			return new NSURLCredential(ms_class.Call("alloc"));
		}

		public new NSURLCredential retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithUserPasswordPersistence(NSString user, NSString password, UInt32 persistence)
		{
			return Call("initWithUser:password:persistence:", user, password, persistence).To<NSObject>();
		}

		public static NSURLCredential credentialWithUserPasswordPersistence(NSString user, NSString password, UInt32 persistence)
		{
			return ms_class.Call("credentialWithUser:password:persistence:", user, password, persistence).To<NSURLCredential>();
		}

		public NSString user()
		{
			return Call("user").To<NSString>();
		}

		public NSString password()
		{
			return Call("password").To<NSString>();
		}

		public bool hasPassword()
		{
			return Call("hasPassword").To<bool>();
		}

		public UInt32 persistence()
		{
			return Call("persistence").To<UInt32>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSURLCredential");
	}
}
