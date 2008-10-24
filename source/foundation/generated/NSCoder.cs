// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSCoder.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSCoder : NSObject
	{
		public NSCoder() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCoder(IntPtr instance) : base(instance)
		{
		}

		public NSCoder(Untyped instance) : base(instance)
		{
		}

		public static new NSCoder alloc()
		{
			return new NSCoder(ms_class.Call("alloc"));
		}

		public new NSCoder retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void encodeValueOfObjCTypeAt(string type, IntPtr addr)
		{
			Unused.Value = Call("encodeValueOfObjCType:at:", type, addr);
		}

		public void encodeDataObject(NSData data)
		{
			Unused.Value = Call("encodeDataObject:", data);
		}

		public void decodeValueOfObjCTypeAt(string type, IntPtr data)
		{
			Unused.Value = Call("decodeValueOfObjCType:at:", type, data);
		}

		public NSData decodeDataObject()
		{
			return Call("decodeDataObject").To<NSData>();
		}

		public Int32 versionForClassName(NSString className)
		{
			return Call("versionForClassName:", className).To<Int32>();
		}

		private static Class ms_class = new Class("NSCoder");
	}

	public static class NSExtendedCoderForNSCoderCategory
	{
		public static void encodeObject(this NSCoder _instance, NSObject object_)
		{
			Unused.Value = _instance.Call("encodeObject:", object_);
		}

		public static void encodePropertyList(this NSCoder _instance, NSObject aPropertyList)
		{
			Unused.Value = _instance.Call("encodePropertyList:", aPropertyList);
		}

		public static void encodeRootObject(this NSCoder _instance, NSObject rootObject)
		{
			Unused.Value = _instance.Call("encodeRootObject:", rootObject);
		}

		public static void encodeBycopyObject(this NSCoder _instance, NSObject anObject)
		{
			Unused.Value = _instance.Call("encodeBycopyObject:", anObject);
		}

		public static void encodeByrefObject(this NSCoder _instance, NSObject anObject)
		{
			Unused.Value = _instance.Call("encodeByrefObject:", anObject);
		}

		public static void encodeConditionalObject(this NSCoder _instance, NSObject object_)
		{
			Unused.Value = _instance.Call("encodeConditionalObject:", object_);
		}

		// skipping encodeValuesOfObjCTypes: because it is variadic

		public static void encodeArrayOfObjCTypeCountAt(this NSCoder _instance, string type, UInt32 count, IntPtr array)
		{
			Unused.Value = _instance.Call("encodeArrayOfObjCType:count:at:", type, count, array);
		}

		public static void encodeBytesLength(this NSCoder _instance, IntPtr byteaddr, UInt32 length)
		{
			Unused.Value = _instance.Call("encodeBytes:length:", byteaddr, length);
		}

		public static NSObject decodeObject(this NSCoder _instance)
		{
			return _instance.Call("decodeObject").To<NSObject>();
		}

		public static NSObject decodePropertyList(this NSCoder _instance)
		{
			return _instance.Call("decodePropertyList").To<NSObject>();
		}

		// skipping decodeValuesOfObjCTypes: because it is variadic

		public static void decodeArrayOfObjCTypeCountAt(this NSCoder _instance, string itemType, UInt32 count, IntPtr array)
		{
			Unused.Value = _instance.Call("decodeArrayOfObjCType:count:at:", itemType, count, array);
		}

		public static IntPtr decodeBytesWithReturnedLength(this NSCoder _instance, IntPtr lengthp)
		{
			return _instance.Call("decodeBytesWithReturnedLength:", lengthp).To<IntPtr>();
		}

		public static void setObjectZone(this NSCoder _instance, IntPtr zone)
		{
			Unused.Value = _instance.Call("setObjectZone:", zone);
		}

		public static IntPtr objectZone(this NSCoder _instance)
		{
			return _instance.Call("objectZone").To<IntPtr>();
		}

		public static UInt32 systemVersion(this NSCoder _instance)
		{
			return _instance.Call("systemVersion").To<UInt32>();
		}

		public static bool allowsKeyedCoding(this NSCoder _instance)
		{
			return _instance.Call("allowsKeyedCoding").To<bool>();
		}

		public static void encodeObjectForKey(this NSCoder _instance, NSObject objv, NSString key)
		{
			Unused.Value = _instance.Call("encodeObject:forKey:", objv, key);
		}

		public static void encodeConditionalObjectForKey(this NSCoder _instance, NSObject objv, NSString key)
		{
			Unused.Value = _instance.Call("encodeConditionalObject:forKey:", objv, key);
		}

		public static void encodeBoolForKey(this NSCoder _instance, bool boolv, NSString key)
		{
			Unused.Value = _instance.Call("encodeBool:forKey:", boolv, key);
		}

		public static void encodeIntForKey(this NSCoder _instance, Int32 intv, NSString key)
		{
			Unused.Value = _instance.Call("encodeInt:forKey:", intv, key);
		}

		public static void encodeInt32ForKey(this NSCoder _instance, Int32 intv, NSString key)
		{
			Unused.Value = _instance.Call("encodeInt32:forKey:", intv, key);
		}

		public static void encodeInt64ForKey(this NSCoder _instance, Int64 intv, NSString key)
		{
			Unused.Value = _instance.Call("encodeInt64:forKey:", intv, key);
		}

		public static void encodeFloatForKey(this NSCoder _instance, float realv, NSString key)
		{
			Unused.Value = _instance.Call("encodeFloat:forKey:", realv, key);
		}

		public static void encodeDoubleForKey(this NSCoder _instance, double realv, NSString key)
		{
			Unused.Value = _instance.Call("encodeDouble:forKey:", realv, key);
		}

		public static void encodeBytesLengthForKey(this NSCoder _instance, IntPtr bytesp, UInt32 lenv, NSString key)
		{
			Unused.Value = _instance.Call("encodeBytes:length:forKey:", bytesp, lenv, key);
		}

		public static bool containsValueForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("containsValueForKey:", key).To<bool>();
		}

		public static NSObject decodeObjectForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeObjectForKey:", key).To<NSObject>();
		}

		public static bool decodeBoolForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeBoolForKey:", key).To<bool>();
		}

		public static Int32 decodeIntForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeIntForKey:", key).To<Int32>();
		}

		public static Int32 decodeInt32ForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeInt32ForKey:", key).To<Int32>();
		}

		public static Int64 decodeInt64ForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeInt64ForKey:", key).To<Int64>();
		}

		public static float decodeFloatForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeFloatForKey:", key).To<float>();
		}

		public static double decodeDoubleForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeDoubleForKey:", key).To<double>();
		}

		public static IntPtr decodeBytesForKeyReturnedLength(this NSCoder _instance, NSString key, IntPtr lengthp)
		{
			return _instance.Call("decodeBytesForKey:returnedLength:", key, lengthp).To<IntPtr>();
		}

		public static void encodeIntegerForKey(this NSCoder _instance, Int32 intv, NSString key)
		{
			Unused.Value = _instance.Call("encodeInteger:forKey:", intv, key);
		}

		public static Int32 decodeIntegerForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeIntegerForKey:", key).To<Int32>();
		}
	}

	public static class NSTypedstreamCompatibilityForNSCoderCategory
	{
	}
}
