// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSShadow.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSShadow : NSObject
	{
		public NSShadow() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSShadow(IntPtr instance) : base(instance)
		{
		}

		public NSShadow(Untyped instance) : base(instance)
		{
		}

		public static new NSShadow alloc()
		{
			return new NSShadow(ms_class.Call("alloc"));
		}

		public new NSShadow retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public NSSize shadowOffset()
		{
			return Call("shadowOffset").To<NSSize>();
		}

		public void setShadowOffset(NSSize offset)
		{
			Unused.Value = Call("setShadowOffset:", offset);
		}

		public float shadowBlurRadius()
		{
			return Call("shadowBlurRadius").To<float>();
		}

		public void setShadowBlurRadius(float val)
		{
			Unused.Value = Call("setShadowBlurRadius:", val);
		}

		public NSColor shadowColor()
		{
			return Call("shadowColor").To<NSColor>();
		}

		public void setShadowColor(NSColor color)
		{
			Unused.Value = Call("setShadowColor:", color);
		}

		public void set()
		{
			Unused.Value = Call("set");
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

		private static Class ms_class = new Class("NSShadow");
	}
}
