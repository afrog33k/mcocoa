// machine generated on 10/24/2008 3:54:03 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSAffineTransform.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSAffineTransform : NSObject
	{
		public NSAffineTransform() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAffineTransform(IntPtr instance) : base(instance)
		{
		}

		public NSAffineTransform(Untyped instance) : base(instance)
		{
		}

		public static new NSAffineTransform alloc()
		{
			return new NSAffineTransform(ms_class.Call("alloc"));
		}

		public new NSAffineTransform retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSAffineTransform transform()
		{
			return ms_class.Call("transform").To<NSAffineTransform>();
		}

		public NSObject initWithTransform(NSAffineTransform transform)
		{
			return Call("initWithTransform:", transform).To<NSObject>();
		}

		public void translateXByYBy(float deltaX, float deltaY)
		{
			Unused.Value = Call("translateXBy:yBy:", deltaX, deltaY);
		}

		public void rotateByDegrees(float angle)
		{
			Unused.Value = Call("rotateByDegrees:", angle);
		}

		public void rotateByRadians(float angle)
		{
			Unused.Value = Call("rotateByRadians:", angle);
		}

		public void scaleBy(float scale)
		{
			Unused.Value = Call("scaleBy:", scale);
		}

		public void scaleXByYBy(float scaleX, float scaleY)
		{
			Unused.Value = Call("scaleXBy:yBy:", scaleX, scaleY);
		}

		public void invert()
		{
			Unused.Value = Call("invert");
		}

		public void appendTransform(NSAffineTransform transform)
		{
			Unused.Value = Call("appendTransform:", transform);
		}

		public void prependTransform(NSAffineTransform transform)
		{
			Unused.Value = Call("prependTransform:", transform);
		}

		public NSPoint transformPoint(NSPoint aPoint)
		{
			return Call("transformPoint:", aPoint).To<NSPoint>();
		}

		public NSSize transformSize(NSSize aSize)
		{
			return Call("transformSize:", aSize).To<NSSize>();
		}

		public NSAffineTransformStruct transformStruct()
		{
			return Call("transformStruct").To<NSAffineTransformStruct>();
		}

		public void setTransformStruct(NSAffineTransformStruct transformStruct)
		{
			Unused.Value = Call("setTransformStruct:", transformStruct);
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

		private static Class ms_class = new Class("NSAffineTransform");
	}
}
