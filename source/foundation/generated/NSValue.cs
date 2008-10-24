// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSValue.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSValue : NSObject
	{
		public NSValue() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSValue(IntPtr instance) : base(instance)
		{
		}

		public NSValue(Untyped instance) : base(instance)
		{
		}

		public static new NSValue alloc()
		{
			return new NSValue(ms_class.Call("alloc"));
		}

		public new NSValue retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void getValue(IntPtr value)
		{
			Unused.Value = Call("getValue:", value);
		}

		public string objCType()
		{
			return Call("objCType").To<string>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
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

		private static Class ms_class = new Class("NSValue");
	}

	public static class NSValueCreationForNSValueCategory
	{
		public static NSObject initWithBytesObjCType(this NSValue _instance, IntPtr value, string type)
		{
			return _instance.Call("initWithBytes:objCType:", value, type).To<NSObject>();
		}

		public static NSValue valueWithBytesObjCType(this NSValue _instance, IntPtr value, string type)
		{
			return _instance.Call("valueWithBytes:objCType:", value, type).To<NSValue>();
		}

		public static NSValue valueWithObjCType(this NSValue _instance, IntPtr value, string type)
		{
			return _instance.Call("value:withObjCType:", value, type).To<NSValue>();
		}
	}

	public static class NSValueExtensionMethodsForNSValueCategory
	{
		public static NSValue valueWithNonretainedObject(this NSValue _instance, NSObject anObject)
		{
			return _instance.Call("valueWithNonretainedObject:", anObject).To<NSValue>();
		}

		public static NSObject nonretainedObjectValue(this NSValue _instance)
		{
			return _instance.Call("nonretainedObjectValue").To<NSObject>();
		}

		public static NSValue valueWithPointer(this NSValue _instance, IntPtr pointer)
		{
			return _instance.Call("valueWithPointer:", pointer).To<NSValue>();
		}

		public static IntPtr pointerValue(this NSValue _instance)
		{
			return _instance.Call("pointerValue").To<IntPtr>();
		}

		public static bool isEqualToValue(this NSValue _instance, NSValue value)
		{
			return _instance.Call("isEqualToValue:", value).To<bool>();
		}
	}

	[Register]
	public partial class NSNumber : NSValue
	{
		public NSNumber() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNumber(IntPtr instance) : base(instance)
		{
		}

		public NSNumber(Untyped instance) : base(instance)
		{
		}

		public static new NSNumber alloc()
		{
			return new NSNumber(ms_class.Call("alloc"));
		}

		public new NSNumber retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public char charValue()
		{
			return Call("charValue").To<char>();
		}

		public byte unsignedCharValue()
		{
			return Call("unsignedCharValue").To<byte>();
		}

		public UInt32 shortValue()
		{
			return Call("shortValue").To<UInt32>();
		}

		public UInt16 unsignedShortValue()
		{
			return Call("unsignedShortValue").To<UInt16>();
		}

		public Int32 intValue()
		{
			return Call("intValue").To<Int32>();
		}

		public UInt32 unsignedIntValue()
		{
			return Call("unsignedIntValue").To<UInt32>();
		}

		public Int64 longValue()
		{
			return Call("longValue").To<Int64>();
		}

		public UInt64 unsignedLongValue()
		{
			return Call("unsignedLongValue").To<UInt64>();
		}

		public Int64 longLongValue()
		{
			return Call("longLongValue").To<Int64>();
		}

		public UInt64 unsignedLongLongValue()
		{
			return Call("unsignedLongLongValue").To<UInt64>();
		}

		public float floatValue()
		{
			return Call("floatValue").To<float>();
		}

		public double doubleValue()
		{
			return Call("doubleValue").To<double>();
		}

		public bool boolValue()
		{
			return Call("boolValue").To<bool>();
		}

		public Int32 integerValue()
		{
			return Call("integerValue").To<Int32>();
		}

		public UInt32 unsignedIntegerValue()
		{
			return Call("unsignedIntegerValue").To<UInt32>();
		}

		public NSString stringValue()
		{
			return Call("stringValue").To<NSString>();
		}

		public Int32 compare(NSNumber otherNumber)
		{
			return Call("compare:", otherNumber).To<Int32>();
		}

		public bool isEqualToNumber(NSNumber number)
		{
			return Call("isEqualToNumber:", number).To<bool>();
		}

		public NSString descriptionWithLocale(NSObject locale)
		{
			return Call("descriptionWithLocale:", locale).To<NSString>();
		}

		private static Class ms_class = new Class("NSNumber");
	}

	public static class NSNumberCreationForNSNumberCategory
	{
		public static NSObject initWithChar(this NSNumber _instance, char value)
		{
			return _instance.Call("initWithChar:", value).To<NSObject>();
		}

		public static NSObject initWithUnsignedChar(this NSNumber _instance, byte value)
		{
			return _instance.Call("initWithUnsignedChar:", value).To<NSObject>();
		}

		public static NSObject initWithShort(this NSNumber _instance, UInt32 value)
		{
			return _instance.Call("initWithShort:", value).To<NSObject>();
		}

		public static NSObject initWithUnsignedShort(this NSNumber _instance, UInt16 value)
		{
			return _instance.Call("initWithUnsignedShort:", value).To<NSObject>();
		}

		public static NSObject initWithInt(this NSNumber _instance, Int32 value)
		{
			return _instance.Call("initWithInt:", value).To<NSObject>();
		}

		public static NSObject initWithUnsignedInt(this NSNumber _instance, UInt32 value)
		{
			return _instance.Call("initWithUnsignedInt:", value).To<NSObject>();
		}

		public static NSObject initWithLong(this NSNumber _instance, Int64 value)
		{
			return _instance.Call("initWithLong:", value).To<NSObject>();
		}

		public static NSObject initWithUnsignedLong(this NSNumber _instance, UInt64 value)
		{
			return _instance.Call("initWithUnsignedLong:", value).To<NSObject>();
		}

		public static NSObject initWithLongLong(this NSNumber _instance, Int64 value)
		{
			return _instance.Call("initWithLongLong:", value).To<NSObject>();
		}

		public static NSObject initWithUnsignedLongLong(this NSNumber _instance, UInt64 value)
		{
			return _instance.Call("initWithUnsignedLongLong:", value).To<NSObject>();
		}

		public static NSObject initWithFloat(this NSNumber _instance, float value)
		{
			return _instance.Call("initWithFloat:", value).To<NSObject>();
		}

		public static NSObject initWithDouble(this NSNumber _instance, double value)
		{
			return _instance.Call("initWithDouble:", value).To<NSObject>();
		}

		public static NSObject initWithBool(this NSNumber _instance, bool value)
		{
			return _instance.Call("initWithBool:", value).To<NSObject>();
		}

		public static NSObject initWithInteger(this NSNumber _instance, Int32 value)
		{
			return _instance.Call("initWithInteger:", value).To<NSObject>();
		}

		public static NSObject initWithUnsignedInteger(this NSNumber _instance, UInt32 value)
		{
			return _instance.Call("initWithUnsignedInteger:", value).To<NSObject>();
		}

		public static NSNumber numberWithChar(this NSNumber _instance, char value)
		{
			return _instance.Call("numberWithChar:", value).To<NSNumber>();
		}

		public static NSNumber numberWithUnsignedChar(this NSNumber _instance, byte value)
		{
			return _instance.Call("numberWithUnsignedChar:", value).To<NSNumber>();
		}

		public static NSNumber numberWithShort(this NSNumber _instance, UInt32 value)
		{
			return _instance.Call("numberWithShort:", value).To<NSNumber>();
		}

		public static NSNumber numberWithUnsignedShort(this NSNumber _instance, UInt16 value)
		{
			return _instance.Call("numberWithUnsignedShort:", value).To<NSNumber>();
		}

		public static NSNumber numberWithInt(this NSNumber _instance, Int32 value)
		{
			return _instance.Call("numberWithInt:", value).To<NSNumber>();
		}

		public static NSNumber numberWithUnsignedInt(this NSNumber _instance, UInt32 value)
		{
			return _instance.Call("numberWithUnsignedInt:", value).To<NSNumber>();
		}

		public static NSNumber numberWithLong(this NSNumber _instance, Int64 value)
		{
			return _instance.Call("numberWithLong:", value).To<NSNumber>();
		}

		public static NSNumber numberWithUnsignedLong(this NSNumber _instance, UInt64 value)
		{
			return _instance.Call("numberWithUnsignedLong:", value).To<NSNumber>();
		}

		public static NSNumber numberWithLongLong(this NSNumber _instance, Int64 value)
		{
			return _instance.Call("numberWithLongLong:", value).To<NSNumber>();
		}

		public static NSNumber numberWithUnsignedLongLong(this NSNumber _instance, UInt64 value)
		{
			return _instance.Call("numberWithUnsignedLongLong:", value).To<NSNumber>();
		}

		public static NSNumber numberWithFloat(this NSNumber _instance, float value)
		{
			return _instance.Call("numberWithFloat:", value).To<NSNumber>();
		}

		public static NSNumber numberWithDouble(this NSNumber _instance, double value)
		{
			return _instance.Call("numberWithDouble:", value).To<NSNumber>();
		}

		public static NSNumber numberWithBool(this NSNumber _instance, bool value)
		{
			return _instance.Call("numberWithBool:", value).To<NSNumber>();
		}

		public static NSNumber numberWithInteger(this NSNumber _instance, Int32 value)
		{
			return _instance.Call("numberWithInteger:", value).To<NSNumber>();
		}

		public static NSNumber numberWithUnsignedInteger(this NSNumber _instance, UInt32 value)
		{
			return _instance.Call("numberWithUnsignedInteger:", value).To<NSNumber>();
		}
	}
}
