// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURL.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSURL : NSObject
	{
		public NSURL() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURL(IntPtr instance) : base(instance)
		{
		}

		public NSURL(Untyped instance) : base(instance)
		{
		}

		public static new NSURL alloc()
		{
			return new NSURL(ms_class.Call("alloc"));
		}

		public new NSURL retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject fileURLWithPathIsDirectoryAVAILABLE_MAC_OS_X_VERSION_10_4_AND_LATER(NSString path, bool isDir)
		{
			return ms_class.Call("fileURLWithPath:isDirectory:AVAILABLE_MAC_OS_X_VERSION_10_4_AND_LATER", path, isDir).To<NSObject>();
		}

		public static NSObject fileURLWithPath(NSString path)
		{
			return ms_class.Call("fileURLWithPath:", path).To<NSObject>();
		}

		public static NSObject URLWithString(NSString URLString)
		{
			return ms_class.Call("URLWithString:", URLString).To<NSObject>();
		}

		public static NSObject URLWithStringRelativeToURL(NSString URLString, NSURL baseURL)
		{
			return ms_class.Call("URLWithString:relativeToURL:", URLString, baseURL).To<NSObject>();
		}

		public NSString absoluteString()
		{
			return Call("absoluteString").To<NSString>();
		}

		public NSString relativeString()
		{
			return Call("relativeString").To<NSString>();
		}

		public NSURL baseURL()
		{
			return Call("baseURL").To<NSURL>();
		}

		public NSURL absoluteURL()
		{
			return Call("absoluteURL").To<NSURL>();
		}

		public NSString scheme()
		{
			return Call("scheme").To<NSString>();
		}

		public NSString resourceSpecifier()
		{
			return Call("resourceSpecifier").To<NSString>();
		}

		public NSString host()
		{
			return Call("host").To<NSString>();
		}

		public NSNumber port()
		{
			return Call("port").To<NSNumber>();
		}

		public NSString user()
		{
			return Call("user").To<NSString>();
		}

		public NSString password()
		{
			return Call("password").To<NSString>();
		}

		public NSString path()
		{
			return Call("path").To<NSString>();
		}

		public NSString fragment()
		{
			return Call("fragment").To<NSString>();
		}

		public NSString parameterString()
		{
			return Call("parameterString").To<NSString>();
		}

		public NSString query()
		{
			return Call("query").To<NSString>();
		}

		public NSString relativePath()
		{
			return Call("relativePath").To<NSString>();
		}

		public bool isFileURL()
		{
			return Call("isFileURL").To<bool>();
		}

		public NSURL standardizedURL()
		{
			return Call("standardizedURL").To<NSURL>();
		}

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

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSURLHandleClient Methods
		#endregion

		private static Class ms_class = new Class("NSURL");
	}

	public static class NSURLUtilitiesForNSStringCategory
	{
		public static NSString stringByAddingPercentEscapesUsingEncoding(this NSString _instance, UInt32 enc)
		{
			return _instance.Call("stringByAddingPercentEscapesUsingEncoding:", enc).To<NSString>();
		}

		public static NSString stringByReplacingPercentEscapesUsingEncoding(this NSString _instance, UInt32 enc)
		{
			return _instance.Call("stringByReplacingPercentEscapesUsingEncoding:", enc).To<NSString>();
		}
	}

	public static class NSURLClientForNSObjectCategory
	{
	}

	public static class NSURLLoadingForNSURLCategory
	{
	}
}
