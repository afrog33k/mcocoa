// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSGraphicsContext.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSImageInterpolationDefault = 0;
		public const int NSImageInterpolationNone = 1;
		public const int NSImageInterpolationLow = 2;
		public const int NSImageInterpolationHigh = 3;
	}

	public partial class Enums
	{
		public const int NSColorRenderingIntentDefault = 0;
		public const int NSColorRenderingIntentAbsoluteColorimetric = 1;
		public const int NSColorRenderingIntentRelativeColorimetric = 2;
		public const int NSColorRenderingIntentPerceptual = 3;
		public const int NSColorRenderingIntentSaturation = 4;
	}

	[Register]
	public partial class NSGraphicsContext : NSObject
	{
		public NSGraphicsContext() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSGraphicsContext(IntPtr instance) : base(instance)
		{
		}

		public NSGraphicsContext(Untyped instance) : base(instance)
		{
		}

		public static new NSGraphicsContext alloc()
		{
			return new NSGraphicsContext(ms_class.Call("alloc"));
		}

		public new NSGraphicsContext retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSGraphicsContext graphicsContextWithAttributes(NSDictionary attributes)
		{
			return ms_class.Call("graphicsContextWithAttributes:", attributes).To<NSGraphicsContext>();
		}

		public static NSGraphicsContext graphicsContextWithWindow(NSWindow window)
		{
			return ms_class.Call("graphicsContextWithWindow:", window).To<NSGraphicsContext>();
		}

		public static NSGraphicsContext graphicsContextWithBitmapImageRep(NSBitmapImageRep bitmapRep)
		{
			return ms_class.Call("graphicsContextWithBitmapImageRep:", bitmapRep).To<NSGraphicsContext>();
		}

		public static NSGraphicsContext graphicsContextWithGraphicsPortFlipped(IntPtr graphicsPort, bool initialFlippedState)
		{
			return ms_class.Call("graphicsContextWithGraphicsPort:flipped:", graphicsPort, initialFlippedState).To<NSGraphicsContext>();
		}

		public static NSGraphicsContext currentContext()
		{
			return ms_class.Call("currentContext").To<NSGraphicsContext>();
		}

		public static void setCurrentContext(NSGraphicsContext context)
		{
			Unused.Value = ms_class.Call("setCurrentContext:", context);
		}

		public static bool currentContextDrawingToScreen()
		{
			return ms_class.Call("currentContextDrawingToScreen").To<bool>();
		}

		public static void saveGraphicsState()
		{
			Unused.Value = ms_class.Call("saveGraphicsState");
		}

		public static void restoreGraphicsState()
		{
			Unused.Value = ms_class.Call("restoreGraphicsState");
		}

		public static void setGraphicsState(Int32 gState)
		{
			Unused.Value = ms_class.Call("setGraphicsState:", gState);
		}

		public NSDictionary attributes()
		{
			return Call("attributes").To<NSDictionary>();
		}

		public bool isDrawingToScreen()
		{
			return Call("isDrawingToScreen").To<bool>();
		}

		// skipping saveGraphicsState (it's already defined)

		// skipping restoreGraphicsState (it's already defined)

		public void flushGraphics()
		{
			Unused.Value = Call("flushGraphics");
		}

		public NSObject focusStack()
		{
			return Call("focusStack").To<NSObject>();
		}

		public void setFocusStack(NSObject stack)
		{
			Unused.Value = Call("setFocusStack:", stack);
		}

		public IntPtr graphicsPort()
		{
			return Call("graphicsPort").To<IntPtr>();
		}

		public bool isFlipped()
		{
			return Call("isFlipped").To<bool>();
		}

		private static Class ms_class = new Class("NSGraphicsContext");
	}

	public static class NSGraphicsContext_RenderingOptionsForNSGraphicsContextCategory
	{
		public static void setShouldAntialias(this NSGraphicsContext _instance, bool antialias)
		{
			Unused.Value = _instance.Call("setShouldAntialias:", antialias);
		}

		public static bool shouldAntialias(this NSGraphicsContext _instance)
		{
			return _instance.Call("shouldAntialias").To<bool>();
		}

		public static void setImageInterpolation(this NSGraphicsContext _instance, UInt32 interpolation)
		{
			Unused.Value = _instance.Call("setImageInterpolation:", interpolation);
		}

		public static UInt32 imageInterpolation(this NSGraphicsContext _instance)
		{
			return _instance.Call("imageInterpolation").To<UInt32>();
		}

		public static void setPatternPhase(this NSGraphicsContext _instance, NSPoint phase)
		{
			Unused.Value = _instance.Call("setPatternPhase:", phase);
		}

		public static NSPoint patternPhase(this NSGraphicsContext _instance)
		{
			return _instance.Call("patternPhase").To<NSPoint>();
		}

		public static void setCompositingOperation(this NSGraphicsContext _instance, UInt32 operation)
		{
			Unused.Value = _instance.Call("setCompositingOperation:", operation);
		}

		public static UInt32 compositingOperation(this NSGraphicsContext _instance)
		{
			return _instance.Call("compositingOperation").To<UInt32>();
		}

		public static Int32 colorRenderingIntent(this NSGraphicsContext _instance)
		{
			return _instance.Call("colorRenderingIntent").To<Int32>();
		}

		public static void setColorRenderingIntent(this NSGraphicsContext _instance, Int32 renderingIntent)
		{
			Unused.Value = _instance.Call("setColorRenderingIntent:", renderingIntent);
		}
	}

	public static class NSQuartzCoreAdditionsForNSGraphicsContextCategory
	{
		public static IntPtr CIContext(this NSGraphicsContext _instance)
		{
			return _instance.Call("CIContext").To<IntPtr>();
		}
	}
}
