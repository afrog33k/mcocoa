// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSOpenGLView.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSOpenGLView : NSView
	{
		public NSOpenGLView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOpenGLView(IntPtr instance) : base(instance)
		{
		}

		public NSOpenGLView(Untyped instance) : base(instance)
		{
		}

		public static new NSOpenGLView alloc()
		{
			return new NSOpenGLView(ms_class.Call("alloc"));
		}

		public new NSOpenGLView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSOpenGLPixelFormat defaultPixelFormat()
		{
			return ms_class.Call("defaultPixelFormat").To<NSOpenGLPixelFormat>();
		}

		public NSObject initWithFramePixelFormat(NSRect frameRect, NSOpenGLPixelFormat format)
		{
			return Call("initWithFrame:pixelFormat:", frameRect, format).To<NSObject>();
		}

		public void setOpenGLContext(NSOpenGLContext context)
		{
			Unused.Value = Call("setOpenGLContext:", context);
		}

		public NSOpenGLContext openGLContext()
		{
			return Call("openGLContext").To<NSOpenGLContext>();
		}

		public void clearGLContext()
		{
			Unused.Value = Call("clearGLContext");
		}

		public void update()
		{
			Unused.Value = Call("update");
		}

		public void reshape()
		{
			Unused.Value = Call("reshape");
		}

		public void setPixelFormat(NSOpenGLPixelFormat pixelFormat)
		{
			Unused.Value = Call("setPixelFormat:", pixelFormat);
		}

		public NSOpenGLPixelFormat pixelFormat()
		{
			return Call("pixelFormat").To<NSOpenGLPixelFormat>();
		}

		public void prepareOpenGL()
		{
			Unused.Value = Call("prepareOpenGL");
		}

		private static Class ms_class = new Class("NSOpenGLView");
	}
}
