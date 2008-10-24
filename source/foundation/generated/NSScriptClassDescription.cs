// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptClassDescription.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSScriptClassDescription : NSClassDescription
	{
		public NSScriptClassDescription() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScriptClassDescription(IntPtr instance) : base(instance)
		{
		}

		public NSScriptClassDescription(Untyped instance) : base(instance)
		{
		}

		public static new NSScriptClassDescription alloc()
		{
			return new NSScriptClassDescription(ms_class.Call("alloc"));
		}

		public new NSScriptClassDescription retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping classDescriptionForClass: (it's declared in a base class)

		public NSObject initWithSuiteNameClassNameDictionary(NSString suiteName, NSString className, NSDictionary classDeclaration)
		{
			return Call("initWithSuiteName:className:dictionary:", suiteName, className, classDeclaration).To<NSObject>();
		}

		public NSString suiteName()
		{
			return Call("suiteName").To<NSString>();
		}

		public NSString className()
		{
			return Call("className").To<NSString>();
		}

		public NSString implementationClassName()
		{
			return Call("implementationClassName").To<NSString>();
		}

		public NSScriptClassDescription superclassDescription()
		{
			return Call("superclassDescription").To<NSScriptClassDescription>();
		}

		public UInt32 appleEventCode()
		{
			return Call("appleEventCode").To<UInt32>();
		}

		public bool matchesAppleEventCode(UInt32 appleEventCode)
		{
			return Call("matchesAppleEventCode:", appleEventCode).To<bool>();
		}

		public bool supportsCommand(NSScriptCommandDescription commandDescription)
		{
			return Call("supportsCommand:", commandDescription).To<bool>();
		}

		public Selector selectorForCommand(NSScriptCommandDescription commandDescription)
		{
			return Call("selectorForCommand:", commandDescription).To<Selector>();
		}

		public NSString typeForKey(NSString key)
		{
			return Call("typeForKey:", key).To<NSString>();
		}

		public NSScriptClassDescription classDescriptionForKey(NSString key)
		{
			return Call("classDescriptionForKey:", key).To<NSScriptClassDescription>();
		}

		public UInt32 appleEventCodeForKey(NSString key)
		{
			return Call("appleEventCodeForKey:", key).To<UInt32>();
		}

		public NSString keyWithAppleEventCode(UInt32 appleEventCode)
		{
			return Call("keyWithAppleEventCode:", appleEventCode).To<NSString>();
		}

		public NSString defaultSubcontainerAttributeKey()
		{
			return Call("defaultSubcontainerAttributeKey").To<NSString>();
		}

		public bool isLocationRequiredToCreateForKey(NSString toManyRelationshipKey)
		{
			return Call("isLocationRequiredToCreateForKey:", toManyRelationshipKey).To<bool>();
		}

		public bool hasPropertyForKey(NSString key)
		{
			return Call("hasPropertyForKey:", key).To<bool>();
		}

		public bool hasOrderedToManyRelationshipForKey(NSString key)
		{
			return Call("hasOrderedToManyRelationshipForKey:", key).To<bool>();
		}

		public bool hasReadablePropertyForKey(NSString key)
		{
			return Call("hasReadablePropertyForKey:", key).To<bool>();
		}

		public bool hasWritablePropertyForKey(NSString key)
		{
			return Call("hasWritablePropertyForKey:", key).To<bool>();
		}

		private static Class ms_class = new Class("NSScriptClassDescription");
	}

	public static class NSDeprecatedForNSScriptClassDescriptionCategory
	{
		public static bool isReadOnlyKey(this NSScriptClassDescription _instance, NSString key)
		{
			return _instance.Call("isReadOnlyKey:", key).To<bool>();
		}
	}

	public static class NSScriptClassDescriptionForNSObjectCategory
	{
		public static UInt32 classCode(this NSObject _instance)
		{
			return _instance.Call("classCode").To<UInt32>();
		}

		public static NSString className(this NSObject _instance)
		{
			return _instance.Call("className").To<NSString>();
		}
	}
}
