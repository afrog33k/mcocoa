// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSKeyedArchiver.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSKeyedArchiver : NSCoder
	{
		public NSKeyedArchiver() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSKeyedArchiver(IntPtr instance) : base(instance)
		{
		}

		public NSKeyedArchiver(Untyped instance) : base(instance)
		{
		}

		public static new NSKeyedArchiver alloc()
		{
			return new NSKeyedArchiver(ms_class.Call("alloc"));
		}

		public new NSKeyedArchiver retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSData archivedDataWithRootObject(NSObject rootObject)
		{
			return ms_class.Call("archivedDataWithRootObject:", rootObject).To<NSData>();
		}

		public static bool archiveRootObjectToFile(NSObject rootObject, NSString path)
		{
			return ms_class.Call("archiveRootObject:toFile:", rootObject, path).To<bool>();
		}

		public NSObject initForWritingWithMutableData(NSMutableData data)
		{
			return Call("initForWritingWithMutableData:", data).To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setOutputFormat(UInt32 format)
		{
			Unused.Value = Call("setOutputFormat:", format);
		}

		public UInt32 outputFormat()
		{
			return Call("outputFormat").To<UInt32>();
		}

		public void finishEncoding()
		{
			Unused.Value = Call("finishEncoding");
		}

		public static void setClassNameForClass(NSString codedName, Class cls)
		{
			Unused.Value = ms_class.Call("setClassName:forClass:", codedName, cls);
		}

		// skipping setClassName:forClass: (it's already defined)

		public static NSString classNameForClass(Class cls)
		{
			return ms_class.Call("classNameForClass:", cls).To<NSString>();
		}

		// skipping classNameForClass: (it's already defined)

		public void encodeObjectForKey(NSObject objv, NSString key)
		{
			Unused.Value = Call("encodeObject:forKey:", objv, key);
		}

		public void encodeConditionalObjectForKey(NSObject objv, NSString key)
		{
			Unused.Value = Call("encodeConditionalObject:forKey:", objv, key);
		}

		public void encodeBoolForKey(bool boolv, NSString key)
		{
			Unused.Value = Call("encodeBool:forKey:", boolv, key);
		}

		public void encodeIntForKey(Int32 intv, NSString key)
		{
			Unused.Value = Call("encodeInt:forKey:", intv, key);
		}

		public void encodeInt32ForKey(Int32 intv, NSString key)
		{
			Unused.Value = Call("encodeInt32:forKey:", intv, key);
		}

		public void encodeInt64ForKey(Int64 intv, NSString key)
		{
			Unused.Value = Call("encodeInt64:forKey:", intv, key);
		}

		public void encodeFloatForKey(float realv, NSString key)
		{
			Unused.Value = Call("encodeFloat:forKey:", realv, key);
		}

		public void encodeDoubleForKey(double realv, NSString key)
		{
			Unused.Value = Call("encodeDouble:forKey:", realv, key);
		}

		public void encodeBytesLengthForKey(IntPtr bytesp, UInt32 lenv, NSString key)
		{
			Unused.Value = Call("encodeBytes:length:forKey:", bytesp, lenv, key);
		}

		private static Class ms_class = new Class("NSKeyedArchiver");
	}

	[Register]
	public partial class NSKeyedUnarchiver : NSCoder
	{
		public NSKeyedUnarchiver() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSKeyedUnarchiver(IntPtr instance) : base(instance)
		{
		}

		public NSKeyedUnarchiver(Untyped instance) : base(instance)
		{
		}

		public static new NSKeyedUnarchiver alloc()
		{
			return new NSKeyedUnarchiver(ms_class.Call("alloc"));
		}

		public new NSKeyedUnarchiver retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject unarchiveObjectWithData(NSData data)
		{
			return ms_class.Call("unarchiveObjectWithData:", data).To<NSObject>();
		}

		public static NSObject unarchiveObjectWithFile(NSString path)
		{
			return ms_class.Call("unarchiveObjectWithFile:", path).To<NSObject>();
		}

		public NSObject initForReadingWithData(NSData data)
		{
			return Call("initForReadingWithData:", data).To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void finishDecoding()
		{
			Unused.Value = Call("finishDecoding");
		}

		public static void setClassForClassName(Class cls, NSString codedName)
		{
			Unused.Value = ms_class.Call("setClass:forClassName:", cls, codedName);
		}

		// skipping setClass:forClassName: (it's already defined)

		public static Class classForClassName(NSString codedName)
		{
			return ms_class.Call("classForClassName:", codedName).To<Class>();
		}

		// skipping classForClassName: (it's already defined)

		public bool containsValueForKey(NSString key)
		{
			return Call("containsValueForKey:", key).To<bool>();
		}

		public NSObject decodeObjectForKey(NSString key)
		{
			return Call("decodeObjectForKey:", key).To<NSObject>();
		}

		public bool decodeBoolForKey(NSString key)
		{
			return Call("decodeBoolForKey:", key).To<bool>();
		}

		public Int32 decodeIntForKey(NSString key)
		{
			return Call("decodeIntForKey:", key).To<Int32>();
		}

		public Int32 decodeInt32ForKey(NSString key)
		{
			return Call("decodeInt32ForKey:", key).To<Int32>();
		}

		public Int64 decodeInt64ForKey(NSString key)
		{
			return Call("decodeInt64ForKey:", key).To<Int64>();
		}

		public float decodeFloatForKey(NSString key)
		{
			return Call("decodeFloatForKey:", key).To<float>();
		}

		public double decodeDoubleForKey(NSString key)
		{
			return Call("decodeDoubleForKey:", key).To<double>();
		}

		public IntPtr decodeBytesForKeyReturnedLength(NSString key, IntPtr lengthp)
		{
			return Call("decodeBytesForKey:returnedLength:", key, lengthp).To<IntPtr>();
		}

		private static Class ms_class = new Class("NSKeyedUnarchiver");
	}

	public static class NSGeometryKeyedCodingForNSCoderCategory
	{
		public static void encodePointForKey(this NSCoder _instance, NSPoint point, NSString key)
		{
			Unused.Value = _instance.Call("encodePoint:forKey:", point, key);
		}

		public static void encodeSizeForKey(this NSCoder _instance, NSSize size, NSString key)
		{
			Unused.Value = _instance.Call("encodeSize:forKey:", size, key);
		}

		public static void encodeRectForKey(this NSCoder _instance, NSRect rect, NSString key)
		{
			Unused.Value = _instance.Call("encodeRect:forKey:", rect, key);
		}

		public static NSPoint decodePointForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodePointForKey:", key).To<NSPoint>();
		}

		public static NSSize decodeSizeForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeSizeForKey:", key).To<NSSize>();
		}

		public static NSRect decodeRectForKey(this NSCoder _instance, NSString key)
		{
			return _instance.Call("decodeRectForKey:", key).To<NSRect>();
		}
	}

	public static class NSKeyedArchiverDelegateForNSObjectCategory
	{
		public static NSObject archiverWillEncodeObject(this NSObject _instance, NSKeyedArchiver archiver, NSObject object_)
		{
			return _instance.Call("archiver:willEncodeObject:", archiver, object_).To<NSObject>();
		}

		public static void archiverDidEncodeObject(this NSObject _instance, NSKeyedArchiver archiver, NSObject object_)
		{
			Unused.Value = _instance.Call("archiver:didEncodeObject:", archiver, object_);
		}

		public static void archiverWillReplaceObjectWithObject(this NSObject _instance, NSKeyedArchiver archiver, NSObject object_, NSObject newObject)
		{
			Unused.Value = _instance.Call("archiver:willReplaceObject:withObject:", archiver, object_, newObject);
		}

		public static void archiverWillFinish(this NSObject _instance, NSKeyedArchiver archiver)
		{
			Unused.Value = _instance.Call("archiverWillFinish:", archiver);
		}

		public static void archiverDidFinish(this NSObject _instance, NSKeyedArchiver archiver)
		{
			Unused.Value = _instance.Call("archiverDidFinish:", archiver);
		}
	}

	public static class NSKeyedUnarchiverDelegateForNSObjectCategory
	{
		public static Class unarchiverCannotDecodeObjectOfClassNameOriginalClasses(this NSObject _instance, NSKeyedUnarchiver unarchiver, NSString name, NSArray classNames)
		{
			return _instance.Call("unarchiver:cannotDecodeObjectOfClassName:originalClasses:", unarchiver, name, classNames).To<Class>();
		}

		public static NSObject unarchiverDidDecodeObject(this NSObject _instance, NSKeyedUnarchiver unarchiver, NSObject object_)
		{
			return _instance.Call("unarchiver:didDecodeObject:", unarchiver, object_).To<NSObject>();
		}

		public static void unarchiverWillReplaceObjectWithObject(this NSObject _instance, NSKeyedUnarchiver unarchiver, NSObject object_, NSObject newObject)
		{
			Unused.Value = _instance.Call("unarchiver:willReplaceObject:withObject:", unarchiver, object_, newObject);
		}

		public static void unarchiverWillFinish(this NSObject _instance, NSKeyedUnarchiver unarchiver)
		{
			Unused.Value = _instance.Call("unarchiverWillFinish:", unarchiver);
		}

		public static void unarchiverDidFinish(this NSObject _instance, NSKeyedUnarchiver unarchiver)
		{
			Unused.Value = _instance.Call("unarchiverDidFinish:", unarchiver);
		}
	}

	public static class NSKeyedArchiverObjectSubstitutionForNSObjectCategory
	{
		public static Class classForKeyedArchiver(this NSObject _instance)
		{
			return _instance.Call("classForKeyedArchiver").To<Class>();
		}

		public static NSObject replacementObjectForKeyedArchiver(this NSObject _instance, NSKeyedArchiver archiver)
		{
			return _instance.Call("replacementObjectForKeyedArchiver:", archiver).To<NSObject>();
		}

		public static NSArray classFallbacksForKeyedArchiver(this NSObject _instance)
		{
			return _instance.Call("classFallbacksForKeyedArchiver").To<NSArray>();
		}
	}

	public static class NSKeyedUnarchiverObjectSubstitutionForNSObjectCategory
	{
		public static Class classForKeyedUnarchiver(this NSObject _instance)
		{
			return _instance.Call("classForKeyedUnarchiver").To<Class>();
		}
	}
}
