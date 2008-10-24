// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLCredentialStorage.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSURLCredentialStorage : NSObject
	{
		public NSURLCredentialStorage() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLCredentialStorage(IntPtr instance) : base(instance)
		{
		}

		public NSURLCredentialStorage(Untyped instance) : base(instance)
		{
		}

		public static new NSURLCredentialStorage alloc()
		{
			return new NSURLCredentialStorage(ms_class.Call("alloc"));
		}

		public new NSURLCredentialStorage retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSURLCredentialStorage sharedCredentialStorage()
		{
			return ms_class.Call("sharedCredentialStorage").To<NSURLCredentialStorage>();
		}

		public NSDictionary credentialsForProtectionSpace(NSURLProtectionSpace space)
		{
			return Call("credentialsForProtectionSpace:", space).To<NSDictionary>();
		}

		public NSDictionary allCredentials()
		{
			return Call("allCredentials").To<NSDictionary>();
		}

		public void setCredentialForProtectionSpace(NSURLCredential credential, NSURLProtectionSpace space)
		{
			Unused.Value = Call("setCredential:forProtectionSpace:", credential, space);
		}

		public void removeCredentialForProtectionSpace(NSURLCredential credential, NSURLProtectionSpace space)
		{
			Unused.Value = Call("removeCredential:forProtectionSpace:", credential, space);
		}

		public NSURLCredential defaultCredentialForProtectionSpace(NSURLProtectionSpace space)
		{
			return Call("defaultCredentialForProtectionSpace:", space).To<NSURLCredential>();
		}

		public void setDefaultCredentialForProtectionSpace(NSURLCredential credential, NSURLProtectionSpace space)
		{
			Unused.Value = Call("setDefaultCredential:forProtectionSpace:", credential, space);
		}

		private static Class ms_class = new Class("NSURLCredentialStorage");
	}
}
