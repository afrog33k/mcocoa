// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSFileHandle.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSFileHandle : NSObject
	{
		public NSFileHandle() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFileHandle(IntPtr instance) : base(instance)
		{
		}

		public NSFileHandle(Untyped instance) : base(instance)
		{
		}

		public static new NSFileHandle alloc()
		{
			return new NSFileHandle(ms_class.Call("alloc"));
		}

		public new NSFileHandle retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSData availableData()
		{
			return Call("availableData").To<NSData>();
		}

		public NSData readDataToEndOfFile()
		{
			return Call("readDataToEndOfFile").To<NSData>();
		}

		public NSData readDataOfLength(UInt32 length)
		{
			return Call("readDataOfLength:", length).To<NSData>();
		}

		public void writeData(NSData data)
		{
			Unused.Value = Call("writeData:", data);
		}

		public UInt64 offsetInFile()
		{
			return Call("offsetInFile").To<UInt64>();
		}

		public UInt64 seekToEndOfFile()
		{
			return Call("seekToEndOfFile").To<UInt64>();
		}

		public void seekToFileOffset(UInt64 offset)
		{
			Unused.Value = Call("seekToFileOffset:", offset);
		}

		public void truncateFileAtOffset(UInt64 offset)
		{
			Unused.Value = Call("truncateFileAtOffset:", offset);
		}

		public void synchronizeFile()
		{
			Unused.Value = Call("synchronizeFile");
		}

		public void closeFile()
		{
			Unused.Value = Call("closeFile");
		}

		private static Class ms_class = new Class("NSFileHandle");
	}

	public static class NSFileHandleCreationForNSFileHandleCategory
	{
		public static NSObject fileHandleWithStandardInput(this NSFileHandle _instance)
		{
			return _instance.Call("fileHandleWithStandardInput").To<NSObject>();
		}

		public static NSObject fileHandleWithStandardOutput(this NSFileHandle _instance)
		{
			return _instance.Call("fileHandleWithStandardOutput").To<NSObject>();
		}

		public static NSObject fileHandleWithStandardError(this NSFileHandle _instance)
		{
			return _instance.Call("fileHandleWithStandardError").To<NSObject>();
		}

		public static NSObject fileHandleWithNullDevice(this NSFileHandle _instance)
		{
			return _instance.Call("fileHandleWithNullDevice").To<NSObject>();
		}

		public static NSObject fileHandleForReadingAtPath(this NSFileHandle _instance, NSString path)
		{
			return _instance.Call("fileHandleForReadingAtPath:", path).To<NSObject>();
		}

		public static NSObject fileHandleForWritingAtPath(this NSFileHandle _instance, NSString path)
		{
			return _instance.Call("fileHandleForWritingAtPath:", path).To<NSObject>();
		}

		public static NSObject fileHandleForUpdatingAtPath(this NSFileHandle _instance, NSString path)
		{
			return _instance.Call("fileHandleForUpdatingAtPath:", path).To<NSObject>();
		}
	}

	public static class NSFileHandleAsynchronousAccessForNSFileHandleCategory
	{
		public static void readInBackgroundAndNotifyForModes(this NSFileHandle _instance, NSArray modes)
		{
			Unused.Value = _instance.Call("readInBackgroundAndNotifyForModes:", modes);
		}

		public static void readInBackgroundAndNotify(this NSFileHandle _instance)
		{
			Unused.Value = _instance.Call("readInBackgroundAndNotify");
		}

		public static void readToEndOfFileInBackgroundAndNotifyForModes(this NSFileHandle _instance, NSArray modes)
		{
			Unused.Value = _instance.Call("readToEndOfFileInBackgroundAndNotifyForModes:", modes);
		}

		public static void readToEndOfFileInBackgroundAndNotify(this NSFileHandle _instance)
		{
			Unused.Value = _instance.Call("readToEndOfFileInBackgroundAndNotify");
		}

		public static void acceptConnectionInBackgroundAndNotifyForModes(this NSFileHandle _instance, NSArray modes)
		{
			Unused.Value = _instance.Call("acceptConnectionInBackgroundAndNotifyForModes:", modes);
		}

		public static void acceptConnectionInBackgroundAndNotify(this NSFileHandle _instance)
		{
			Unused.Value = _instance.Call("acceptConnectionInBackgroundAndNotify");
		}

		public static void waitForDataInBackgroundAndNotifyForModes(this NSFileHandle _instance, NSArray modes)
		{
			Unused.Value = _instance.Call("waitForDataInBackgroundAndNotifyForModes:", modes);
		}

		public static void waitForDataInBackgroundAndNotify(this NSFileHandle _instance)
		{
			Unused.Value = _instance.Call("waitForDataInBackgroundAndNotify");
		}
	}

	public static class NSFileHandlePlatformSpecificForNSFileHandleCategory
	{
		public static NSObject initWithFileDescriptorCloseOnDealloc(this NSFileHandle _instance, Int32 fd, bool closeopt)
		{
			return _instance.Call("initWithFileDescriptor:closeOnDealloc:", fd, closeopt).To<NSObject>();
		}

		public static NSObject initWithFileDescriptor(this NSFileHandle _instance, Int32 fd)
		{
			return _instance.Call("initWithFileDescriptor:", fd).To<NSObject>();
		}

		public static Int32 fileDescriptor(this NSFileHandle _instance)
		{
			return _instance.Call("fileDescriptor").To<Int32>();
		}
	}

	[Register]
	public partial class NSPipe : NSObject
	{
		public NSPipe() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPipe(IntPtr instance) : base(instance)
		{
		}

		public NSPipe(Untyped instance) : base(instance)
		{
		}

		public static new NSPipe alloc()
		{
			return new NSPipe(ms_class.Call("alloc"));
		}

		public new NSPipe retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSFileHandle fileHandleForReading()
		{
			return Call("fileHandleForReading").To<NSFileHandle>();
		}

		public NSFileHandle fileHandleForWriting()
		{
			return Call("fileHandleForWriting").To<NSFileHandle>();
		}

		// skipping init (it's already defined)

		public static NSObject pipe()
		{
			return ms_class.Call("pipe").To<NSObject>();
		}

		private static Class ms_class = new Class("NSPipe");
	}
}
