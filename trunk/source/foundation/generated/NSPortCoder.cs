// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSPortCoder.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPortCoder : NSCoder
	{
		public NSPortCoder() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPortCoder(IntPtr instance) : base(instance)
		{
		}

		public NSPortCoder(Untyped instance) : base(instance)
		{
		}

		public static new NSPortCoder alloc()
		{
			return new NSPortCoder(ms_class.Call("alloc"));
		}

		public new NSPortCoder retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public bool isBycopy()
		{
			return Call("isBycopy").To<bool>();
		}

		public bool isByref()
		{
			return Call("isByref").To<bool>();
		}

		public NSConnection connection()
		{
			return Call("connection").To<NSConnection>();
		}

		public void encodePortObject(NSPort aport)
		{
			Unused.Value = Call("encodePortObject:", aport);
		}

		public NSPort decodePortObject()
		{
			return Call("decodePortObject").To<NSPort>();
		}

		public NSObject initWithReceivePortSendPortComponents(NSPort rcvPort, NSPort sndPort, NSArray comps)
		{
			return Call("initWithReceivePort:sendPort:components:", rcvPort, sndPort, comps).To<NSObject>();
		}

		public void dispatch()
		{
			Unused.Value = Call("dispatch");
		}

		private static Class ms_class = new Class("NSPortCoder");
	}

	public static class NSDistributedObjectsForNSObjectCategory
	{
		public static Class classForPortCoder(this NSObject _instance)
		{
			return _instance.Call("classForPortCoder").To<Class>();
		}

		public static NSObject replacementObjectForPortCoder(this NSObject _instance, NSPortCoder coder)
		{
			return _instance.Call("replacementObjectForPortCoder:", coder).To<NSObject>();
		}
	}
}
