// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDictionaryController.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSDictionaryControllerKeyValuePairForNSObjectCategory
	{
		public static void setLocalizedKey(this NSObject _instance, NSString localizedKey)
		{
			Unused.Value = _instance.Call("setLocalizedKey:", localizedKey);
		}

		public static NSString localizedKey(this NSObject _instance)
		{
			return _instance.Call("localizedKey").To<NSString>();
		}

		public static void setKey(this NSObject _instance, NSString key)
		{
			Unused.Value = _instance.Call("setKey:", key);
		}

		public static NSString key(this NSObject _instance)
		{
			return _instance.Call("key").To<NSString>();
		}

		public static void setValue(this NSObject _instance, NSObject value)
		{
			Unused.Value = _instance.Call("setValue:", value);
		}

		public static NSObject value(this NSObject _instance)
		{
			return _instance.Call("value").To<NSObject>();
		}

		public static bool isExplicitlyIncluded(this NSObject _instance)
		{
			return _instance.Call("isExplicitlyIncluded").To<bool>();
		}
	}

	[Register]
	public partial class NSDictionaryController : NSArrayController
	{
		public NSDictionaryController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDictionaryController(IntPtr instance) : base(instance)
		{
		}

		public NSDictionaryController(Untyped instance) : base(instance)
		{
		}

		public static new NSDictionaryController alloc()
		{
			return new NSDictionaryController(ms_class.Call("alloc"));
		}

		public new NSDictionaryController retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping newObject (it's declared in a base class)

		public void setInitialKey(NSString key)
		{
			Unused.Value = Call("setInitialKey:", key);
		}

		public NSString initialKey()
		{
			return Call("initialKey").To<NSString>();
		}

		public void setInitialValue(NSObject value)
		{
			Unused.Value = Call("setInitialValue:", value);
		}

		public NSObject initialValue()
		{
			return Call("initialValue").To<NSObject>();
		}

		public void setIncludedKeys(NSArray keys)
		{
			Unused.Value = Call("setIncludedKeys:", keys);
		}

		public NSArray includedKeys()
		{
			return Call("includedKeys").To<NSArray>();
		}

		public void setExcludedKeys(NSArray keys)
		{
			Unused.Value = Call("setExcludedKeys:", keys);
		}

		public NSArray excludedKeys()
		{
			return Call("excludedKeys").To<NSArray>();
		}

		public void setLocalizedKeyDictionary(NSDictionary dictionary)
		{
			Unused.Value = Call("setLocalizedKeyDictionary:", dictionary);
		}

		public NSDictionary localizedKeyDictionary()
		{
			return Call("localizedKeyDictionary").To<NSDictionary>();
		}

		public void setLocalizedKeyTable(NSString stringsFileName)
		{
			Unused.Value = Call("setLocalizedKeyTable:", stringsFileName);
		}

		public NSString localizedKeyTable()
		{
			return Call("localizedKeyTable").To<NSString>();
		}

		private static Class ms_class = new Class("NSDictionaryController");
	}
}
