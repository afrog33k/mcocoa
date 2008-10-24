// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSBundle.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSBundleExecutableArchitectureI386 = 0x00000007;
		public const int NSBundleExecutableArchitecturePPC = 0x00000012;
		public const int NSBundleExecutableArchitectureX86_64 = 0x01000007;
		public const int NSBundleExecutableArchitecturePPC64 = 0x01000012;
	}

	[Register]
	public partial class NSBundle : NSObject
	{
		public NSBundle() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSBundle(IntPtr instance) : base(instance)
		{
		}

		public NSBundle(Untyped instance) : base(instance)
		{
		}

		public static new NSBundle alloc()
		{
			return new NSBundle(ms_class.Call("alloc"));
		}

		public new NSBundle retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSBundle mainBundle()
		{
			return ms_class.Call("mainBundle").To<NSBundle>();
		}

		public static NSBundle bundleWithPath(NSString path)
		{
			return ms_class.Call("bundleWithPath:", path).To<NSBundle>();
		}

		public NSObject initWithPath(NSString path)
		{
			return Call("initWithPath:", path).To<NSObject>();
		}

		public static NSBundle bundleForClass(Class aClass)
		{
			return ms_class.Call("bundleForClass:", aClass).To<NSBundle>();
		}

		public static NSBundle bundleWithIdentifier(NSString identifier)
		{
			return ms_class.Call("bundleWithIdentifier:", identifier).To<NSBundle>();
		}

		public static NSArray allBundles()
		{
			return ms_class.Call("allBundles").To<NSArray>();
		}

		public static NSArray allFrameworks()
		{
			return ms_class.Call("allFrameworks").To<NSArray>();
		}

		public bool load()
		{
			return Call("load").To<bool>();
		}

		public bool isLoaded()
		{
			return Call("isLoaded").To<bool>();
		}

		public bool unload()
		{
			return Call("unload").To<bool>();
		}

		public bool preflightAndReturnError(IntPtr error)
		{
			return Call("preflightAndReturnError:", error).To<bool>();
		}

		public bool loadAndReturnError(IntPtr error)
		{
			return Call("loadAndReturnError:", error).To<bool>();
		}

		public NSString bundlePath()
		{
			return Call("bundlePath").To<NSString>();
		}

		public NSString resourcePath()
		{
			return Call("resourcePath").To<NSString>();
		}

		public NSString executablePath()
		{
			return Call("executablePath").To<NSString>();
		}

		public NSString pathForAuxiliaryExecutable(NSString executableName)
		{
			return Call("pathForAuxiliaryExecutable:", executableName).To<NSString>();
		}

		public NSString privateFrameworksPath()
		{
			return Call("privateFrameworksPath").To<NSString>();
		}

		public NSString sharedFrameworksPath()
		{
			return Call("sharedFrameworksPath").To<NSString>();
		}

		public NSString sharedSupportPath()
		{
			return Call("sharedSupportPath").To<NSString>();
		}

		public NSString builtInPlugInsPath()
		{
			return Call("builtInPlugInsPath").To<NSString>();
		}

		public NSString bundleIdentifier()
		{
			return Call("bundleIdentifier").To<NSString>();
		}

		public Class classNamed(NSString className)
		{
			return Call("classNamed:", className).To<Class>();
		}

		public Class principalClass()
		{
			return Call("principalClass").To<Class>();
		}

		public static NSString pathForResourceOfTypeInDirectory(NSString name, NSString ext, NSString bundlePath)
		{
			return ms_class.Call("pathForResource:ofType:inDirectory:", name, ext, bundlePath).To<NSString>();
		}

		public NSString pathForResourceOfType(NSString name, NSString ext)
		{
			return Call("pathForResource:ofType:", name, ext).To<NSString>();
		}

		// skipping pathForResource:ofType:inDirectory: (it's already defined)

		public NSString pathForResourceOfTypeInDirectoryForLocalization(NSString name, NSString ext, NSString subpath, NSString localizationName)
		{
			return Call("pathForResource:ofType:inDirectory:forLocalization:", name, ext, subpath, localizationName).To<NSString>();
		}

		public static NSArray pathsForResourcesOfTypeInDirectory(NSString ext, NSString bundlePath)
		{
			return ms_class.Call("pathsForResourcesOfType:inDirectory:", ext, bundlePath).To<NSArray>();
		}

		// skipping pathsForResourcesOfType:inDirectory: (it's already defined)

		public NSArray pathsForResourcesOfTypeInDirectoryForLocalization(NSString ext, NSString subpath, NSString localizationName)
		{
			return Call("pathsForResourcesOfType:inDirectory:forLocalization:", ext, subpath, localizationName).To<NSArray>();
		}

		public NSString localizedStringForKeyValueTable(NSString key, NSString value, NSString tableName)
		{
			return Call("localizedStringForKey:value:table:", key, value, tableName).To<NSString>();
		}

		public NSDictionary infoDictionary()
		{
			return Call("infoDictionary").To<NSDictionary>();
		}

		public NSDictionary localizedInfoDictionary()
		{
			return Call("localizedInfoDictionary").To<NSDictionary>();
		}

		public NSObject objectForInfoDictionaryKey(NSString key)
		{
			return Call("objectForInfoDictionaryKey:", key).To<NSObject>();
		}

		public NSArray localizations()
		{
			return Call("localizations").To<NSArray>();
		}

		public NSArray preferredLocalizations()
		{
			return Call("preferredLocalizations").To<NSArray>();
		}

		public NSString developmentLocalization()
		{
			return Call("developmentLocalization").To<NSString>();
		}

		public static NSArray preferredLocalizationsFromArray(NSArray localizationsArray)
		{
			return ms_class.Call("preferredLocalizationsFromArray:", localizationsArray).To<NSArray>();
		}

		public static NSArray preferredLocalizationsFromArrayForPreferences(NSArray localizationsArray, NSArray preferencesArray)
		{
			return ms_class.Call("preferredLocalizationsFromArray:forPreferences:", localizationsArray, preferencesArray).To<NSArray>();
		}

		public NSArray executableArchitectures()
		{
			return Call("executableArchitectures").To<NSArray>();
		}

		private static Class ms_class = new Class("NSBundle");
	}
}
