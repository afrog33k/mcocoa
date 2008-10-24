// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptSuiteRegistry.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSScriptSuiteRegistry : NSObject
	{
		public NSScriptSuiteRegistry() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScriptSuiteRegistry(IntPtr instance) : base(instance)
		{
		}

		public NSScriptSuiteRegistry(Untyped instance) : base(instance)
		{
		}

		public static new NSScriptSuiteRegistry alloc()
		{
			return new NSScriptSuiteRegistry(ms_class.Call("alloc"));
		}

		public new NSScriptSuiteRegistry retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSScriptSuiteRegistry sharedScriptSuiteRegistry()
		{
			return ms_class.Call("sharedScriptSuiteRegistry").To<NSScriptSuiteRegistry>();
		}

		public static void setSharedScriptSuiteRegistry(NSScriptSuiteRegistry registry)
		{
			Unused.Value = ms_class.Call("setSharedScriptSuiteRegistry:", registry);
		}

		public void loadSuitesFromBundle(NSBundle bundle)
		{
			Unused.Value = Call("loadSuitesFromBundle:", bundle);
		}

		public void loadSuiteWithDictionaryFromBundle(NSDictionary suiteDeclaration, NSBundle bundle)
		{
			Unused.Value = Call("loadSuiteWithDictionary:fromBundle:", suiteDeclaration, bundle);
		}

		public void registerClassDescription(NSScriptClassDescription classDescription)
		{
			Unused.Value = Call("registerClassDescription:", classDescription);
		}

		public void registerCommandDescription(NSScriptCommandDescription commandDescription)
		{
			Unused.Value = Call("registerCommandDescription:", commandDescription);
		}

		public NSArray suiteNames()
		{
			return Call("suiteNames").To<NSArray>();
		}

		public UInt32 appleEventCodeForSuite(NSString suiteName)
		{
			return Call("appleEventCodeForSuite:", suiteName).To<UInt32>();
		}

		public NSBundle bundleForSuite(NSString suiteName)
		{
			return Call("bundleForSuite:", suiteName).To<NSBundle>();
		}

		public NSDictionary classDescriptionsInSuite(NSString suiteName)
		{
			return Call("classDescriptionsInSuite:", suiteName).To<NSDictionary>();
		}

		public NSDictionary commandDescriptionsInSuite(NSString suiteName)
		{
			return Call("commandDescriptionsInSuite:", suiteName).To<NSDictionary>();
		}

		public NSString suiteForAppleEventCode(UInt32 appleEventCode)
		{
			return Call("suiteForAppleEventCode:", appleEventCode).To<NSString>();
		}

		public NSScriptClassDescription classDescriptionWithAppleEventCode(UInt32 appleEventCode)
		{
			return Call("classDescriptionWithAppleEventCode:", appleEventCode).To<NSScriptClassDescription>();
		}

		public NSScriptCommandDescription commandDescriptionWithAppleEventClassAndAppleEventCode(UInt32 appleEventClassCode, UInt32 appleEventIDCode)
		{
			return Call("commandDescriptionWithAppleEventClass:andAppleEventCode:", appleEventClassCode, appleEventIDCode).To<NSScriptCommandDescription>();
		}

		public NSData aeteResource(NSString languageName)
		{
			return Call("aeteResource:", languageName).To<NSData>();
		}

		private static Class ms_class = new Class("NSScriptSuiteRegistry");
	}
}
