// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPropertyList.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSPropertyListImmutable = 0;
		public const int NSPropertyListMutableContainers = 1;
		public const int NSPropertyListMutableContainersAndLeaves = 2;
	}

	public partial class Enums
	{
		public const int NSPropertyListOpenStepFormat = 1;
		public const int NSPropertyListXMLFormat_v1_0 = 100;
		public const int NSPropertyListBinaryFormat_v1_0 = 200;
	}

	[Register]
	public partial class NSPropertyListSerialization : NSObject
	{
		public NSPropertyListSerialization() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPropertyListSerialization(IntPtr instance) : base(instance)
		{
		}

		public NSPropertyListSerialization(Untyped instance) : base(instance)
		{
		}

		public static new NSPropertyListSerialization alloc()
		{
			return new NSPropertyListSerialization(ms_class.Call("alloc"));
		}

		public new NSPropertyListSerialization retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static bool propertyListIsValidForFormat(NSObject plist, UInt32 format)
		{
			return ms_class.Call("propertyList:isValidForFormat:", plist, format).To<bool>();
		}

		public static NSData dataFromPropertyListFormatErrorDescription(NSObject plist, UInt32 format, IntPtr errorString)
		{
			return ms_class.Call("dataFromPropertyList:format:errorDescription:", plist, format, errorString).To<NSData>();
		}

		public static NSObject propertyListFromDataMutabilityOptionFormatErrorDescription(NSData data, UInt32 opt, IntPtr format, IntPtr errorString)
		{
			return ms_class.Call("propertyListFromData:mutabilityOption:format:errorDescription:", data, opt, format, errorString).To<NSObject>();
		}

		private static Class ms_class = new Class("NSPropertyListSerialization");
	}
}
