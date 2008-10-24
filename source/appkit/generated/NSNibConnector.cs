// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSNibConnector.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSNibConnector : NSObject
	{
		public NSNibConnector() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNibConnector(IntPtr instance) : base(instance)
		{
		}

		public NSNibConnector(Untyped instance) : base(instance)
		{
		}

		public static new NSNibConnector alloc()
		{
			return new NSNibConnector(ms_class.Call("alloc"));
		}

		public new NSNibConnector retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject source()
		{
			return Call("source").To<NSObject>();
		}

		public void setSource(NSObject source)
		{
			Unused.Value = Call("setSource:", source);
		}

		public NSObject destination()
		{
			return Call("destination").To<NSObject>();
		}

		public void setDestination(NSObject destination)
		{
			Unused.Value = Call("setDestination:", destination);
		}

		public NSString label()
		{
			return Call("label").To<NSString>();
		}

		public void setLabel(NSString label)
		{
			Unused.Value = Call("setLabel:", label);
		}

		public void replaceObjectWithObject(NSObject oldObject, NSObject newObject)
		{
			Unused.Value = Call("replaceObject:withObject:", oldObject, newObject);
		}

		public void establishConnection()
		{
			Unused.Value = Call("establishConnection");
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

		private static Class ms_class = new Class("NSNibConnector");
	}
}
