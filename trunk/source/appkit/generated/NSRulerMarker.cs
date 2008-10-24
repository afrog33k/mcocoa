// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSRulerMarker.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSRulerMarker : NSObject
	{
		public NSRulerMarker() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSRulerMarker(IntPtr instance) : base(instance)
		{
		}

		public NSRulerMarker(Untyped instance) : base(instance)
		{
		}

		public static new NSRulerMarker alloc()
		{
			return new NSRulerMarker(ms_class.Call("alloc"));
		}

		public new NSRulerMarker retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithRulerViewMarkerLocationImageImageOrigin(NSRulerView ruler, float location, NSImage image, NSPoint imageOrigin)
		{
			return Call("initWithRulerView:markerLocation:image:imageOrigin:", ruler, location, image, imageOrigin).To<NSObject>();
		}

		public NSRulerView ruler()
		{
			return Call("ruler").To<NSRulerView>();
		}

		public void setMarkerLocation(float location)
		{
			Unused.Value = Call("setMarkerLocation:", location);
		}

		public float markerLocation()
		{
			return Call("markerLocation").To<float>();
		}

		public void setImage(NSImage image)
		{
			Unused.Value = Call("setImage:", image);
		}

		public NSImage image()
		{
			return Call("image").To<NSImage>();
		}

		public void setImageOrigin(NSPoint imageOrigin)
		{
			Unused.Value = Call("setImageOrigin:", imageOrigin);
		}

		public NSPoint imageOrigin()
		{
			return Call("imageOrigin").To<NSPoint>();
		}

		public void setMovable(bool flag)
		{
			Unused.Value = Call("setMovable:", flag);
		}

		public void setRemovable(bool flag)
		{
			Unused.Value = Call("setRemovable:", flag);
		}

		public bool isMovable()
		{
			return Call("isMovable").To<bool>();
		}

		public bool isRemovable()
		{
			return Call("isRemovable").To<bool>();
		}

		public bool isDragging()
		{
			return Call("isDragging").To<bool>();
		}

		public void setRepresentedObject(NSObject representedObject)
		{
			Unused.Value = Call("setRepresentedObject:", representedObject);
		}

		public NSObject representedObject()
		{
			return Call("representedObject").To<NSObject>();
		}

		public NSRect imageRectInRuler()
		{
			return Call("imageRectInRuler").To<NSRect>();
		}

		public float thicknessRequiredInRuler()
		{
			return Call("thicknessRequiredInRuler").To<float>();
		}

		public void drawRect(NSRect rect)
		{
			Unused.Value = Call("drawRect:", rect);
		}

		public bool trackMouseAdding(NSEvent mouseDownEvent, bool isAdding)
		{
			return Call("trackMouse:adding:", mouseDownEvent, isAdding).To<bool>();
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

		private static Class ms_class = new Class("NSRulerMarker");
	}
}
