// machine generated on 10/24/2008 3:54:03 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSArchiver.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSArchiver : NSCoder
	{
		public NSArchiver() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSArchiver(IntPtr instance) : base(instance)
		{
		}

		public NSArchiver(Untyped instance) : base(instance)
		{
		}

		public static new NSArchiver alloc()
		{
			return new NSArchiver(ms_class.Call("alloc"));
		}

		public new NSArchiver retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initForWritingWithMutableData(NSMutableData mdata)
		{
			return Call("initForWritingWithMutableData:", mdata).To<NSObject>();
		}

		public NSMutableData archiverData()
		{
			return Call("archiverData").To<NSMutableData>();
		}

		public void encodeRootObject(NSObject rootObject)
		{
			Unused.Value = Call("encodeRootObject:", rootObject);
		}

		public void encodeConditionalObject(NSObject object_)
		{
			Unused.Value = Call("encodeConditionalObject:", object_);
		}

		public static NSData archivedDataWithRootObject(NSObject rootObject)
		{
			return ms_class.Call("archivedDataWithRootObject:", rootObject).To<NSData>();
		}

		public static bool archiveRootObjectToFile(NSObject rootObject, NSString path)
		{
			return ms_class.Call("archiveRootObject:toFile:", rootObject, path).To<bool>();
		}

		public void encodeClassNameIntoClassName(NSString trueName, NSString inArchiveName)
		{
			Unused.Value = Call("encodeClassName:intoClassName:", trueName, inArchiveName);
		}

		public NSString classNameEncodedForTrueClassName(NSString trueName)
		{
			return Call("classNameEncodedForTrueClassName:", trueName).To<NSString>();
		}

		public void replaceObjectWithObject(NSObject object_, NSObject newObject)
		{
			Unused.Value = Call("replaceObject:withObject:", object_, newObject);
		}

		private static Class ms_class = new Class("NSArchiver");
	}

	[Register]
	public partial class NSUnarchiver : NSCoder
	{
		public NSUnarchiver() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSUnarchiver(IntPtr instance) : base(instance)
		{
		}

		public NSUnarchiver(Untyped instance) : base(instance)
		{
		}

		public static new NSUnarchiver alloc()
		{
			return new NSUnarchiver(ms_class.Call("alloc"));
		}

		public new NSUnarchiver retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initForReadingWithData(NSData data)
		{
			return Call("initForReadingWithData:", data).To<NSObject>();
		}

		public void setObjectZone(IntPtr zone)
		{
			Unused.Value = Call("setObjectZone:", zone);
		}

		public IntPtr objectZone()
		{
			return Call("objectZone").To<IntPtr>();
		}

		public bool isAtEnd()
		{
			return Call("isAtEnd").To<bool>();
		}

		public UInt32 systemVersion()
		{
			return Call("systemVersion").To<UInt32>();
		}

		public static NSObject unarchiveObjectWithData(NSData data)
		{
			return ms_class.Call("unarchiveObjectWithData:", data).To<NSObject>();
		}

		public static NSObject unarchiveObjectWithFile(NSString path)
		{
			return ms_class.Call("unarchiveObjectWithFile:", path).To<NSObject>();
		}

		public static void decodeClassNameAsClassName(NSString inArchiveName, NSString trueName)
		{
			Unused.Value = ms_class.Call("decodeClassName:asClassName:", inArchiveName, trueName);
		}

		// skipping decodeClassName:asClassName: (it's already defined)

		public static NSString classNameDecodedForArchiveClassName(NSString inArchiveName)
		{
			return ms_class.Call("classNameDecodedForArchiveClassName:", inArchiveName).To<NSString>();
		}

		// skipping classNameDecodedForArchiveClassName: (it's already defined)

		public void replaceObjectWithObject(NSObject object_, NSObject newObject)
		{
			Unused.Value = Call("replaceObject:withObject:", object_, newObject);
		}

		private static Class ms_class = new Class("NSUnarchiver");
	}

	public static class NSArchiverCallbackForNSObjectCategory
	{
		public static Class classForArchiver(this NSObject _instance)
		{
			return _instance.Call("classForArchiver").To<Class>();
		}

		public static NSObject replacementObjectForArchiver(this NSObject _instance, NSArchiver archiver)
		{
			return _instance.Call("replacementObjectForArchiver:", archiver).To<NSObject>();
		}
	}
}
