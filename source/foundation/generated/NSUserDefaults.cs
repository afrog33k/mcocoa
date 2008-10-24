// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSUserDefaults.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSUserDefaults : NSObject
	{
		public NSUserDefaults() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSUserDefaults(IntPtr instance) : base(instance)
		{
		}

		public NSUserDefaults(Untyped instance) : base(instance)
		{
		}

		public static new NSUserDefaults alloc()
		{
			return new NSUserDefaults(ms_class.Call("alloc"));
		}

		public new NSUserDefaults retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSUserDefaults standardUserDefaults()
		{
			return ms_class.Call("standardUserDefaults").To<NSUserDefaults>();
		}

		public static void resetStandardUserDefaults()
		{
			Unused.Value = ms_class.Call("resetStandardUserDefaults");
		}

		// skipping init (it's already defined)

		public NSObject initWithUser(NSString username)
		{
			return Call("initWithUser:", username).To<NSObject>();
		}

		public NSObject objectForKey(NSString defaultName)
		{
			return Call("objectForKey:", defaultName).To<NSObject>();
		}

		public void setObjectForKey(NSObject value, NSString defaultName)
		{
			Unused.Value = Call("setObject:forKey:", value, defaultName);
		}

		public void removeObjectForKey(NSString defaultName)
		{
			Unused.Value = Call("removeObjectForKey:", defaultName);
		}

		public NSString stringForKey(NSString defaultName)
		{
			return Call("stringForKey:", defaultName).To<NSString>();
		}

		public NSArray arrayForKey(NSString defaultName)
		{
			return Call("arrayForKey:", defaultName).To<NSArray>();
		}

		public NSDictionary dictionaryForKey(NSString defaultName)
		{
			return Call("dictionaryForKey:", defaultName).To<NSDictionary>();
		}

		public NSData dataForKey(NSString defaultName)
		{
			return Call("dataForKey:", defaultName).To<NSData>();
		}

		public NSArray stringArrayForKey(NSString defaultName)
		{
			return Call("stringArrayForKey:", defaultName).To<NSArray>();
		}

		public Int32 integerForKey(NSString defaultName)
		{
			return Call("integerForKey:", defaultName).To<Int32>();
		}

		public float floatForKey(NSString defaultName)
		{
			return Call("floatForKey:", defaultName).To<float>();
		}

		public double doubleForKey(NSString defaultName)
		{
			return Call("doubleForKey:", defaultName).To<double>();
		}

		public bool boolForKey(NSString defaultName)
		{
			return Call("boolForKey:", defaultName).To<bool>();
		}

		public void setIntegerForKey(Int32 value, NSString defaultName)
		{
			Unused.Value = Call("setInteger:forKey:", value, defaultName);
		}

		public void setFloatForKey(float value, NSString defaultName)
		{
			Unused.Value = Call("setFloat:forKey:", value, defaultName);
		}

		public void setDoubleForKey(double value, NSString defaultName)
		{
			Unused.Value = Call("setDouble:forKey:", value, defaultName);
		}

		public void setBoolForKey(bool value, NSString defaultName)
		{
			Unused.Value = Call("setBool:forKey:", value, defaultName);
		}

		public void registerDefaults(NSDictionary registrationDictionary)
		{
			Unused.Value = Call("registerDefaults:", registrationDictionary);
		}

		public void addSuiteNamed(NSString suiteName)
		{
			Unused.Value = Call("addSuiteNamed:", suiteName);
		}

		public void removeSuiteNamed(NSString suiteName)
		{
			Unused.Value = Call("removeSuiteNamed:", suiteName);
		}

		public NSDictionary dictionaryRepresentation()
		{
			return Call("dictionaryRepresentation").To<NSDictionary>();
		}

		public NSArray volatileDomainNames()
		{
			return Call("volatileDomainNames").To<NSArray>();
		}

		public NSDictionary volatileDomainForName(NSString domainName)
		{
			return Call("volatileDomainForName:", domainName).To<NSDictionary>();
		}

		public void setVolatileDomainForName(NSDictionary domain, NSString domainName)
		{
			Unused.Value = Call("setVolatileDomain:forName:", domain, domainName);
		}

		public void removeVolatileDomainForName(NSString domainName)
		{
			Unused.Value = Call("removeVolatileDomainForName:", domainName);
		}

		public NSArray persistentDomainNames()
		{
			return Call("persistentDomainNames").To<NSArray>();
		}

		public NSDictionary persistentDomainForName(NSString domainName)
		{
			return Call("persistentDomainForName:", domainName).To<NSDictionary>();
		}

		public void setPersistentDomainForName(NSDictionary domain, NSString domainName)
		{
			Unused.Value = Call("setPersistentDomain:forName:", domain, domainName);
		}

		public void removePersistentDomainForName(NSString domainName)
		{
			Unused.Value = Call("removePersistentDomainForName:", domainName);
		}

		public bool synchronize()
		{
			return Call("synchronize").To<bool>();
		}

		public bool objectIsForcedForKey(NSString key)
		{
			return Call("objectIsForcedForKey:", key).To<bool>();
		}

		public bool objectIsForcedForKeyInDomain(NSString key, NSString domain)
		{
			return Call("objectIsForcedForKey:inDomain:", key, domain).To<bool>();
		}

		private static Class ms_class = new Class("NSUserDefaults");
	}
}
