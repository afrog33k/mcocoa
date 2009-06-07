// Copyright (C) 2008 Jesse Jones
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using MObjc;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

// http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Miscellaneous/Foundation_Functions/Reference/reference.html#//apple_ref/doc/uid/TP40003774-DontLinkChapterID_1-DontLinkElementID_60
namespace MCocoa
{
	/// <exclude/>
	[Serializable]
	public enum NSSearchPathDirectory : uint
	{
		NSApplicationDirectory = 1,					// supported applications (Applications)
		NSDemoApplicationDirectory = 2,			// unsupported applications, demonstration versions (Demos)
		NSDeveloperApplicationDirectory = 3,	// developer applications (Developer/Applications)
		NSAdminApplicationDirectory = 4,		// system and network administration applications (Administration)
		NSLibraryDirectory = 5, 						// various user-visible documentation, support, and configuration files, resources (Library)
		NSDeveloperDirectory = 6,					// developer resources (Developer)
		NSUserDirectory = 7,							// user home directories (Users)
		NSDocumentationDirectory = 8,			// documentation (Documentation)
		NSDocumentDirectory = 9,					// documents (Documents)
		NSCoreServiceDirectory = 10,				// locate of core services (System/Library/CoreServices)
		NSDesktopDirectory = 12,            		// location of user's desktop
		NSCachesDirectory = 13,             		// location of discardable cache files (Library/Caches)
		NSApplicationSupportDirectory = 14, 	// location of application support files (plug-ins, etc) (Library/Application Support)
		NSDownloadsDirectory = 15,          		// location of the user's "Downloads" directory
		NSAllApplicationsDirectory = 100,		// all directories where applications can occur
		NSAllLibrariesDirectory = 101,				// all directories where resources can occur
	}
	
	/// <exclude/>
	[Flags]
	[Serializable]
	public enum NSSearchPathDomainMask : uint
	{
		NSUserDomainMask = 1,			// user's home directory --- place to install user's personal items (~)
		NSLocalDomainMask = 2,			// local to the current machine --- place to install items available to everyone on this machine (/Library)
		NSNetworkDomainMask = 4, 	// publically available location in the local area network --- place to install items available on the network (/Network)
		NSSystemDomainMask = 8,		// provided by Apple, unmodifiable (/System)
		NSAllDomainsMask = 0x0ffff,	// all domains: all of the above and future items
	}
	
	public static partial class Functions
	{
		#region Path Utilities
		public static NSString NSUserName()
		{
			return NativeMethods.NSUserName().To<NSString>();
		}
		
		public static NSString NSFullUserName()
		{
			return NativeMethods.NSFullUserName().To<NSString>();
		}
		
		public static NSString NSHomeDirectory()
		{
			return NativeMethods.NSHomeDirectory().To<NSString>();
		}
		
		public static NSString NSHomeDirectoryForUser(NSString userName)
		{
			return NativeMethods.NSHomeDirectoryForUser(userName).To<NSString>();
		}
		
		public static NSString NSTemporaryDirectory()
		{
			return NativeMethods.NSTemporaryDirectory().To<NSString>();
		}
		
		public static NSString NSOpenStepRootDirectory()
		{
			return NativeMethods.NSOpenStepRootDirectory().To<NSString>();
		}
		
		public static NSArray NSSearchPathForDirectoriesInDomains(NSSearchPathDirectory directory, NSSearchPathDomainMask domainMask, bool expandTilde)
		{
			return NativeMethods.NSSearchPathForDirectoriesInDomains(directory, domainMask, expandTilde).To<NSArray>();
		}
		#endregion
		
		#region P/Invokes
		private static partial class NativeMethods
		{
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static IntPtr NSUserName();
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static IntPtr NSFullUserName();
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static IntPtr NSHomeDirectory();
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static IntPtr NSHomeDirectoryForUser(IntPtr userName);
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static IntPtr NSTemporaryDirectory();
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static IntPtr NSOpenStepRootDirectory();
			
			[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
			public extern static IntPtr NSSearchPathForDirectoriesInDomains(NSSearchPathDirectory directory, NSSearchPathDomainMask domainMask, [MarshalAs(UnmanagedType.U1)] bool expandTilde);
		}
		#endregion
	}
}
