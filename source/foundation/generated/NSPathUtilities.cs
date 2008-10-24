// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPathUtilities.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSApplicationDirectory = 1;
		public const int NSDemoApplicationDirectory = 2;
		public const int NSDeveloperApplicationDirectory = 3;
		public const int NSAdminApplicationDirectory = 4;
		public const int NSLibraryDirectory = 5;
		public const int NSDeveloperDirectory = 6;
		public const int NSUserDirectory = 7;
		public const int NSDocumentationDirectory = 8;
		public const int NSDocumentDirectory = 9;
		public const int NSCoreServiceDirectory = 10;
		public const int NSDesktopDirectory = 12;
		public const int NSCachesDirectory = 13;
		public const int NSApplicationSupportDirectory = 14;
		public const int NSDownloadsDirectory = 15;
		public const int NSAllApplicationsDirectory = 100;
		public const int NSAllLibrariesDirectory = 101;
	}

	public partial class Enums
	{
		public const int NSUserDomainMask = 1;
		public const int NSLocalDomainMask = 2;
		public const int NSNetworkDomainMask = 4;
		public const int NSSystemDomainMask = 8;
		public const int NSAllDomainsMask = 0x0ffff;
	}

	public static class NSStringPathExtensionsForNSStringCategory
	{
		public static NSString pathWithComponents(this NSString _instance, NSArray components)
		{
			return _instance.Call("pathWithComponents:", components).To<NSString>();
		}

		public static NSArray pathComponents(this NSString _instance)
		{
			return _instance.Call("pathComponents").To<NSArray>();
		}

		public static bool isAbsolutePath(this NSString _instance)
		{
			return _instance.Call("isAbsolutePath").To<bool>();
		}

		public static NSString lastPathComponent(this NSString _instance)
		{
			return _instance.Call("lastPathComponent").To<NSString>();
		}

		public static NSString stringByDeletingLastPathComponent(this NSString _instance)
		{
			return _instance.Call("stringByDeletingLastPathComponent").To<NSString>();
		}

		public static NSString stringByAppendingPathComponent(this NSString _instance, NSString str)
		{
			return _instance.Call("stringByAppendingPathComponent:", str).To<NSString>();
		}

		public static NSString pathExtension(this NSString _instance)
		{
			return _instance.Call("pathExtension").To<NSString>();
		}

		public static NSString stringByDeletingPathExtension(this NSString _instance)
		{
			return _instance.Call("stringByDeletingPathExtension").To<NSString>();
		}

		public static NSString stringByAppendingPathExtension(this NSString _instance, NSString str)
		{
			return _instance.Call("stringByAppendingPathExtension:", str).To<NSString>();
		}

		public static NSString stringByAbbreviatingWithTildeInPath(this NSString _instance)
		{
			return _instance.Call("stringByAbbreviatingWithTildeInPath").To<NSString>();
		}

		public static NSString stringByExpandingTildeInPath(this NSString _instance)
		{
			return _instance.Call("stringByExpandingTildeInPath").To<NSString>();
		}

		public static NSString stringByStandardizingPath(this NSString _instance)
		{
			return _instance.Call("stringByStandardizingPath").To<NSString>();
		}

		public static NSString stringByResolvingSymlinksInPath(this NSString _instance)
		{
			return _instance.Call("stringByResolvingSymlinksInPath").To<NSString>();
		}

		public static NSArray stringsByAppendingPaths(this NSString _instance, NSArray paths)
		{
			return _instance.Call("stringsByAppendingPaths:", paths).To<NSArray>();
		}

		public static UInt32 completePathIntoStringCaseSensitiveMatchesIntoArrayFilterTypes(this NSString _instance, IntPtr outputName, bool flag, IntPtr outputArray, NSArray filterTypes)
		{
			return _instance.Call("completePathIntoString:caseSensitive:matchesIntoArray:filterTypes:", outputName, flag, outputArray, filterTypes).To<UInt32>();
		}

		public static string fileSystemRepresentation(this NSString _instance)
		{
			return _instance.Call("fileSystemRepresentation").To<string>();
		}

		public static bool getFileSystemRepresentationMaxLength(this NSString _instance, IntPtr cname, UInt32 max)
		{
			return _instance.Call("getFileSystemRepresentation:maxLength:", cname, max).To<bool>();
		}
	}

	public static class NSArrayPathExtensionsForNSArrayCategory
	{
		public static NSArray pathsMatchingExtensions(this NSArray _instance, NSArray filterTypes)
		{
			return _instance.Call("pathsMatchingExtensions:", filterTypes).To<NSArray>();
		}
	}
}
