// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSData.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSMappedRead = 1;
		public const int NSUncachedRead = 2;
	}

	public partial class Enums
	{
		public const int NSAtomicWrite = 1;
	}

	[Register]
	public partial class NSData : NSObject
	{
		public NSData() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSData(IntPtr instance) : base(instance)
		{
		}

		public NSData(Untyped instance) : base(instance)
		{
		}

		public static new NSData alloc()
		{
			return new NSData(ms_class.Call("alloc"));
		}

		public new NSData retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 length()
		{
			return Call("length").To<UInt32>();
		}

		public IntPtr bytes()
		{
			return Call("bytes").To<IntPtr>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSMutableCopying Methods
		public NSObject mutableCopyWithZone(IntPtr zone)
		{
			return Call("mutableCopyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSData");
	}

	public static class NSExtendedDataForNSDataCategory
	{
		// skipping description (it's already defined)

		public static void getBytes(this NSData _instance, IntPtr buffer)
		{
			Unused.Value = _instance.Call("getBytes:", buffer);
		}

		public static void getBytesLength(this NSData _instance, IntPtr buffer, UInt32 length)
		{
			Unused.Value = _instance.Call("getBytes:length:", buffer, length);
		}

		public static void getBytesRange(this NSData _instance, IntPtr buffer, NSRange range)
		{
			Unused.Value = _instance.Call("getBytes:range:", buffer, range);
		}

		public static bool isEqualToData(this NSData _instance, NSData other)
		{
			return _instance.Call("isEqualToData:", other).To<bool>();
		}

		public static NSData subdataWithRange(this NSData _instance, NSRange range)
		{
			return _instance.Call("subdataWithRange:", range).To<NSData>();
		}

		public static bool writeToFileAtomically(this NSData _instance, NSString path, bool useAuxiliaryFile)
		{
			return _instance.Call("writeToFile:atomically:", path, useAuxiliaryFile).To<bool>();
		}

		public static bool writeToURLAtomically(this NSData _instance, NSURL url, bool atomically)
		{
			return _instance.Call("writeToURL:atomically:", url, atomically).To<bool>();
		}

		public static bool writeToFileOptionsError(this NSData _instance, NSString path, UInt32 writeOptionsMask, IntPtr errorPtr)
		{
			return _instance.Call("writeToFile:options:error:", path, writeOptionsMask, errorPtr).To<bool>();
		}

		public static bool writeToURLOptionsError(this NSData _instance, NSURL url, UInt32 writeOptionsMask, IntPtr errorPtr)
		{
			return _instance.Call("writeToURL:options:error:", url, writeOptionsMask, errorPtr).To<bool>();
		}
	}

	public static class NSDataCreationForNSDataCategory
	{
		public static NSObject data(this NSData _instance)
		{
			return _instance.Call("data").To<NSObject>();
		}

		public static NSObject dataWithBytesLength(this NSData _instance, IntPtr bytes, UInt32 length)
		{
			return _instance.Call("dataWithBytes:length:", bytes, length).To<NSObject>();
		}

		public static NSObject dataWithBytesNoCopyLength(this NSData _instance, IntPtr bytes, UInt32 length)
		{
			return _instance.Call("dataWithBytesNoCopy:length:", bytes, length).To<NSObject>();
		}

		public static NSObject dataWithBytesNoCopyLengthFreeWhenDone(this NSData _instance, IntPtr bytes, UInt32 length, bool b)
		{
			return _instance.Call("dataWithBytesNoCopy:length:freeWhenDone:", bytes, length, b).To<NSObject>();
		}

		public static NSObject dataWithContentsOfFileOptionsError(this NSData _instance, NSString path, UInt32 readOptionsMask, IntPtr errorPtr)
		{
			return _instance.Call("dataWithContentsOfFile:options:error:", path, readOptionsMask, errorPtr).To<NSObject>();
		}

		public static NSObject dataWithContentsOfURLOptionsError(this NSData _instance, NSURL url, UInt32 readOptionsMask, IntPtr errorPtr)
		{
			return _instance.Call("dataWithContentsOfURL:options:error:", url, readOptionsMask, errorPtr).To<NSObject>();
		}

		public static NSObject dataWithContentsOfFile(this NSData _instance, NSString path)
		{
			return _instance.Call("dataWithContentsOfFile:", path).To<NSObject>();
		}

		public static NSObject dataWithContentsOfURL(this NSData _instance, NSURL url)
		{
			return _instance.Call("dataWithContentsOfURL:", url).To<NSObject>();
		}

		public static NSObject dataWithContentsOfMappedFile(this NSData _instance, NSString path)
		{
			return _instance.Call("dataWithContentsOfMappedFile:", path).To<NSObject>();
		}

		public static NSObject initWithBytesLength(this NSData _instance, IntPtr bytes, UInt32 length)
		{
			return _instance.Call("initWithBytes:length:", bytes, length).To<NSObject>();
		}

		public static NSObject initWithBytesNoCopyLength(this NSData _instance, IntPtr bytes, UInt32 length)
		{
			return _instance.Call("initWithBytesNoCopy:length:", bytes, length).To<NSObject>();
		}

		public static NSObject initWithBytesNoCopyLengthFreeWhenDone(this NSData _instance, IntPtr bytes, UInt32 length, bool b)
		{
			return _instance.Call("initWithBytesNoCopy:length:freeWhenDone:", bytes, length, b).To<NSObject>();
		}

		public static NSObject initWithContentsOfFileOptionsError(this NSData _instance, NSString path, UInt32 readOptionsMask, IntPtr errorPtr)
		{
			return _instance.Call("initWithContentsOfFile:options:error:", path, readOptionsMask, errorPtr).To<NSObject>();
		}

		public static NSObject initWithContentsOfURLOptionsError(this NSData _instance, NSURL url, UInt32 readOptionsMask, IntPtr errorPtr)
		{
			return _instance.Call("initWithContentsOfURL:options:error:", url, readOptionsMask, errorPtr).To<NSObject>();
		}

		public static NSObject initWithContentsOfFile(this NSData _instance, NSString path)
		{
			return _instance.Call("initWithContentsOfFile:", path).To<NSObject>();
		}

		public static NSObject initWithContentsOfURL(this NSData _instance, NSURL url)
		{
			return _instance.Call("initWithContentsOfURL:", url).To<NSObject>();
		}

		public static NSObject initWithContentsOfMappedFile(this NSData _instance, NSString path)
		{
			return _instance.Call("initWithContentsOfMappedFile:", path).To<NSObject>();
		}

		public static NSObject initWithData(this NSData _instance, NSData data)
		{
			return _instance.Call("initWithData:", data).To<NSObject>();
		}

		public static NSObject dataWithData(this NSData _instance, NSData data)
		{
			return _instance.Call("dataWithData:", data).To<NSObject>();
		}
	}

	[Register]
	public partial class NSMutableData : NSData
	{
		public NSMutableData() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableData(IntPtr instance) : base(instance)
		{
		}

		public NSMutableData(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableData alloc()
		{
			return new NSMutableData(ms_class.Call("alloc"));
		}

		public new NSMutableData retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public IntPtr mutableBytes()
		{
			return Call("mutableBytes").To<IntPtr>();
		}

		public void setLength(UInt32 length)
		{
			Unused.Value = Call("setLength:", length);
		}

		private static Class ms_class = new Class("NSMutableData");
	}

	public static class NSExtendedMutableDataForNSMutableDataCategory
	{
		public static void appendBytesLength(this NSMutableData _instance, IntPtr bytes, UInt32 length)
		{
			Unused.Value = _instance.Call("appendBytes:length:", bytes, length);
		}

		public static void appendData(this NSMutableData _instance, NSData other)
		{
			Unused.Value = _instance.Call("appendData:", other);
		}

		public static void increaseLengthBy(this NSMutableData _instance, UInt32 extraLength)
		{
			Unused.Value = _instance.Call("increaseLengthBy:", extraLength);
		}

		public static void replaceBytesInRangeWithBytes(this NSMutableData _instance, NSRange range, IntPtr bytes)
		{
			Unused.Value = _instance.Call("replaceBytesInRange:withBytes:", range, bytes);
		}

		public static void resetBytesInRange(this NSMutableData _instance, NSRange range)
		{
			Unused.Value = _instance.Call("resetBytesInRange:", range);
		}

		public static void setData(this NSMutableData _instance, NSData data)
		{
			Unused.Value = _instance.Call("setData:", data);
		}

		public static void replaceBytesInRangeWithBytesLength(this NSMutableData _instance, NSRange range, IntPtr replacementBytes, UInt32 replacementLength)
		{
			Unused.Value = _instance.Call("replaceBytesInRange:withBytes:length:", range, replacementBytes, replacementLength);
		}
	}

	public static class NSMutableDataCreationForNSMutableDataCategory
	{
		public static NSObject dataWithCapacity(this NSMutableData _instance, UInt32 aNumItems)
		{
			return _instance.Call("dataWithCapacity:", aNumItems).To<NSObject>();
		}

		public static NSObject dataWithLength(this NSMutableData _instance, UInt32 length)
		{
			return _instance.Call("dataWithLength:", length).To<NSObject>();
		}

		public static NSObject initWithCapacity(this NSMutableData _instance, UInt32 capacity)
		{
			return _instance.Call("initWithCapacity:", capacity).To<NSObject>();
		}

		public static NSObject initWithLength(this NSMutableData _instance, UInt32 length)
		{
			return _instance.Call("initWithLength:", length).To<NSObject>();
		}
	}
}
