// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSStream.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSStreamStatusNotOpen = 0;
		public const int NSStreamStatusOpening = 1;
		public const int NSStreamStatusOpen = 2;
		public const int NSStreamStatusReading = 3;
		public const int NSStreamStatusWriting = 4;
		public const int NSStreamStatusAtEnd = 5;
		public const int NSStreamStatusClosed = 6;
		public const int NSStreamStatusError = 7;
	}

	public partial class Enums
	{
		public const int NSStreamEventNone = 0;
		public const int NSStreamEventOpenCompleted = 1 << 0;
		public const int NSStreamEventHasBytesAvailable = 1 << 1;
		public const int NSStreamEventHasSpaceAvailable = 1 << 2;
		public const int NSStreamEventErrorOccurred = 1 << 3;
		public const int NSStreamEventEndEncountered = 1 << 4;
	}

	[Register]
	public partial class NSStream : NSObject
	{
		public NSStream() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSStream(IntPtr instance) : base(instance)
		{
		}

		public NSStream(Untyped instance) : base(instance)
		{
		}

		public static new NSStream alloc()
		{
			return new NSStream(ms_class.Call("alloc"));
		}

		public new NSStream retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void open()
		{
			Unused.Value = Call("open");
		}

		public void close()
		{
			Unused.Value = Call("close");
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject propertyForKey(NSString key)
		{
			return Call("propertyForKey:", key).To<NSObject>();
		}

		public bool setPropertyForKey(NSObject property, NSString key)
		{
			return Call("setProperty:forKey:", property, key).To<bool>();
		}

		public void scheduleInRunLoopForMode(NSRunLoop aRunLoop, NSString mode)
		{
			Unused.Value = Call("scheduleInRunLoop:forMode:", aRunLoop, mode);
		}

		public void removeFromRunLoopForMode(NSRunLoop aRunLoop, NSString mode)
		{
			Unused.Value = Call("removeFromRunLoop:forMode:", aRunLoop, mode);
		}

		public UInt32 streamStatus()
		{
			return Call("streamStatus").To<UInt32>();
		}

		public NSError streamError()
		{
			return Call("streamError").To<NSError>();
		}

		private static Class ms_class = new Class("NSStream");
	}

	[Register]
	public partial class NSInputStream : NSStream
	{
		public NSInputStream() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSInputStream(IntPtr instance) : base(instance)
		{
		}

		public NSInputStream(Untyped instance) : base(instance)
		{
		}

		public static new NSInputStream alloc()
		{
			return new NSInputStream(ms_class.Call("alloc"));
		}

		public new NSInputStream retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public Int32 readMaxLength(IntPtr buffer, UInt32 len)
		{
			return Call("read:maxLength:", buffer, len).To<Int32>();
		}

		public bool getBufferLength(IntPtr buffer, IntPtr len)
		{
			return Call("getBuffer:length:", buffer, len).To<bool>();
		}

		public bool hasBytesAvailable()
		{
			return Call("hasBytesAvailable").To<bool>();
		}

		private static Class ms_class = new Class("NSInputStream");
	}

	[Register]
	public partial class NSOutputStream : NSStream
	{
		public NSOutputStream() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOutputStream(IntPtr instance) : base(instance)
		{
		}

		public NSOutputStream(Untyped instance) : base(instance)
		{
		}

		public static new NSOutputStream alloc()
		{
			return new NSOutputStream(ms_class.Call("alloc"));
		}

		public new NSOutputStream retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public Int32 writeMaxLength(IntPtr buffer, UInt32 len)
		{
			return Call("write:maxLength:", buffer, len).To<Int32>();
		}

		public bool hasSpaceAvailable()
		{
			return Call("hasSpaceAvailable").To<bool>();
		}

		private static Class ms_class = new Class("NSOutputStream");
	}

	public static class NSSocketStreamCreationExtensionsForNSStreamCategory
	{
		public static void getStreamsToHostPortInputStreamOutputStream(this NSStream _instance, NSHost host, Int32 port, IntPtr inputStream, IntPtr outputStream)
		{
			Unused.Value = _instance.Call("getStreamsToHost:port:inputStream:outputStream:", host, port, inputStream, outputStream);
		}
	}

	public static class NSInputStreamExtensionsForNSInputStreamCategory
	{
		public static NSObject initWithData(this NSInputStream _instance, NSData data)
		{
			return _instance.Call("initWithData:", data).To<NSObject>();
		}

		public static NSObject initWithFileAtPath(this NSInputStream _instance, NSString path)
		{
			return _instance.Call("initWithFileAtPath:", path).To<NSObject>();
		}

		public static NSObject inputStreamWithData(this NSInputStream _instance, NSData data)
		{
			return _instance.Call("inputStreamWithData:", data).To<NSObject>();
		}

		public static NSObject inputStreamWithFileAtPath(this NSInputStream _instance, NSString path)
		{
			return _instance.Call("inputStreamWithFileAtPath:", path).To<NSObject>();
		}
	}

	public static class NSOutputStreamExtensionsForNSOutputStreamCategory
	{
		public static NSObject initToMemory(this NSOutputStream _instance)
		{
			return _instance.Call("initToMemory").To<NSObject>();
		}

		public static NSObject initToBufferCapacity(this NSOutputStream _instance, IntPtr buffer, UInt32 capacity)
		{
			return _instance.Call("initToBuffer:capacity:", buffer, capacity).To<NSObject>();
		}

		public static NSObject initToFileAtPathAppend(this NSOutputStream _instance, NSString path, bool shouldAppend)
		{
			return _instance.Call("initToFileAtPath:append:", path, shouldAppend).To<NSObject>();
		}

		public static NSObject outputStreamToMemory(this NSOutputStream _instance)
		{
			return _instance.Call("outputStreamToMemory").To<NSObject>();
		}

		public static NSObject outputStreamToBufferCapacity(this NSOutputStream _instance, IntPtr buffer, UInt32 capacity)
		{
			return _instance.Call("outputStreamToBuffer:capacity:", buffer, capacity).To<NSObject>();
		}

		public static NSObject outputStreamToFileAtPathAppend(this NSOutputStream _instance, NSString path, bool shouldAppend)
		{
			return _instance.Call("outputStreamToFileAtPath:append:", path, shouldAppend).To<NSObject>();
		}
	}

	public static class NSStreamDelegateEventExtensionsForNSObjectCategory
	{
		public static void streamHandleEvent(this NSObject _instance, NSStream aStream, UInt32 eventCode)
		{
			Unused.Value = _instance.Call("stream:handleEvent:", aStream, eventCode);
		}
	}
}
