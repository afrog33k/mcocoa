// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSOpenGL.h

using MObjc;
using System;

namespace MCocoa
{
	public enum NSOpenGLGlobalOption
	{
		NSOpenGLGOFormatCacheSize = 501,
		NSOpenGLGOClearFormatCache = 502,
		NSOpenGLGORetainRenderers = 503,
		NSOpenGLGOResetLibrary = 504,
	}

	public partial class Enums
	{
		public const int NSOpenGLPFAAllRenderers = 1;
		public const int NSOpenGLPFADoubleBuffer = 5;
		public const int NSOpenGLPFAStereo = 6;
		public const int NSOpenGLPFAAuxBuffers = 7;
		public const int NSOpenGLPFAColorSize = 8;
		public const int NSOpenGLPFAAlphaSize = 11;
		public const int NSOpenGLPFADepthSize = 12;
		public const int NSOpenGLPFAStencilSize = 13;
		public const int NSOpenGLPFAAccumSize = 14;
		public const int NSOpenGLPFAMinimumPolicy = 51;
		public const int NSOpenGLPFAMaximumPolicy = 52;
		public const int NSOpenGLPFAOffScreen = 53;
		public const int NSOpenGLPFAFullScreen = 54;
		public const int NSOpenGLPFASampleBuffers = 55;
		public const int NSOpenGLPFASamples = 56;
		public const int NSOpenGLPFAAuxDepthStencil = 57;
		public const int NSOpenGLPFAColorFloat = 58;
		public const int NSOpenGLPFAMultisample = 59;
		public const int NSOpenGLPFASupersample = 60;
		public const int NSOpenGLPFASampleAlpha = 61;
		public const int NSOpenGLPFARendererID = 70;
		public const int NSOpenGLPFASingleRenderer = 71;
		public const int NSOpenGLPFANoRecovery = 72;
		public const int NSOpenGLPFAAccelerated = 73;
		public const int NSOpenGLPFAClosestPolicy = 74;
		public const int NSOpenGLPFARobust = 75;
		public const int NSOpenGLPFABackingStore = 76;
		public const int NSOpenGLPFAMPSafe = 78;
		public const int NSOpenGLPFAWindow = 80;
		public const int NSOpenGLPFAMultiScreen = 81;
		public const int NSOpenGLPFACompliant = 83;
		public const int NSOpenGLPFAScreenMask = 84;
		public const int NSOpenGLPFAPixelBuffer = 90;
		public const int NSOpenGLPFAAllowOfflineRenderers = 96;
		public const int NSOpenGLPFAVirtualScreenCount = 128;
	}

	public enum NSOpenGLContextParameter
	{
		NSOpenGLCPSwapRectangle = 200,
		NSOpenGLCPSwapRectangleEnable = 201,
		NSOpenGLCPRasterizationEnable = 221,
		NSOpenGLCPSwapInterval = 222,
		NSOpenGLCPSurfaceOrder = 235,
		NSOpenGLCPSurfaceOpacity = 236,
		NSOpenGLCPStateValidation = 301,
	}

	[Register]
	public partial class NSOpenGLPixelFormat : NSObject
	{
		public NSOpenGLPixelFormat() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOpenGLPixelFormat(IntPtr instance) : base(instance)
		{
		}

		public NSOpenGLPixelFormat(Untyped instance) : base(instance)
		{
		}

		public static new NSOpenGLPixelFormat alloc()
		{
			return new NSOpenGLPixelFormat(ms_class.Call("alloc"));
		}

		public new NSOpenGLPixelFormat retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithAttributes(IntPtr attribs)
		{
			return Call("initWithAttributes:", attribs).To<NSObject>();
		}

		public NSObject initWithData(NSData attribs)
		{
			return Call("initWithData:", attribs).To<NSObject>();
		}

		public NSData attributes()
		{
			return Call("attributes").To<NSData>();
		}

		public void setAttributes(NSData attribs)
		{
			Unused.Value = Call("setAttributes:", attribs);
		}

		public void getValuesForAttributeForVirtualScreen(IntPtr vals, UInt32 attrib, Int32 screen)
		{
			Unused.Value = Call("getValues:forAttribute:forVirtualScreen:", vals, attrib, screen);
		}

		public Int32 numberOfVirtualScreens()
		{
			return Call("numberOfVirtualScreens").To<Int32>();
		}

		public IntPtr CGLPixelFormatObj()
		{
			return Call("CGLPixelFormatObj").To<IntPtr>();
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

		private static Class ms_class = new Class("NSOpenGLPixelFormat");
	}

	[Register]
	public partial class NSOpenGLPixelBuffer : NSObject
	{
		public NSOpenGLPixelBuffer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOpenGLPixelBuffer(IntPtr instance) : base(instance)
		{
		}

		public NSOpenGLPixelBuffer(Untyped instance) : base(instance)
		{
		}

		public static new NSOpenGLPixelBuffer alloc()
		{
			return new NSOpenGLPixelBuffer(ms_class.Call("alloc"));
		}

		public new NSOpenGLPixelBuffer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithTextureTargetTextureInternalFormatTextureMaxMipMapLevelPixelsWidePixelsHigh(UInt32 target, UInt32 format, Int32 maxLevel, Int32 pixelsWide, Int32 pixelsHigh)
		{
			return Call("initWithTextureTarget:textureInternalFormat:textureMaxMipMapLevel:pixelsWide:pixelsHigh:", target, format, maxLevel, pixelsWide, pixelsHigh).To<NSObject>();
		}

		public Int32 pixelsWide()
		{
			return Call("pixelsWide").To<Int32>();
		}

		public Int32 pixelsHigh()
		{
			return Call("pixelsHigh").To<Int32>();
		}

		public UInt32 textureTarget()
		{
			return Call("textureTarget").To<UInt32>();
		}

		public UInt32 textureInternalFormat()
		{
			return Call("textureInternalFormat").To<UInt32>();
		}

		public Int32 textureMaxMipMapLevel()
		{
			return Call("textureMaxMipMapLevel").To<Int32>();
		}

		private static Class ms_class = new Class("NSOpenGLPixelBuffer");
	}

	[Register]
	public partial class NSOpenGLContext : NSObject
	{
		public NSOpenGLContext() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSOpenGLContext(IntPtr instance) : base(instance)
		{
		}

		public NSOpenGLContext(Untyped instance) : base(instance)
		{
		}

		public static new NSOpenGLContext alloc()
		{
			return new NSOpenGLContext(ms_class.Call("alloc"));
		}

		public new NSOpenGLContext retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithFormatShareContext(NSOpenGLPixelFormat format, NSOpenGLContext share)
		{
			return Call("initWithFormat:shareContext:", format, share).To<NSObject>();
		}

		public void setView(NSView view)
		{
			Unused.Value = Call("setView:", view);
		}

		public NSView view()
		{
			return Call("view").To<NSView>();
		}

		public void setFullScreen()
		{
			Unused.Value = Call("setFullScreen");
		}

		public void setOffScreenWidthHeightRowbytes(IntPtr baseaddr, Int32 width, Int32 height, Int32 rowbytes)
		{
			Unused.Value = Call("setOffScreen:width:height:rowbytes:", baseaddr, width, height, rowbytes);
		}

		public void clearDrawable()
		{
			Unused.Value = Call("clearDrawable");
		}

		public void update()
		{
			Unused.Value = Call("update");
		}

		public void flushBuffer()
		{
			Unused.Value = Call("flushBuffer");
		}

		public void makeCurrentContext()
		{
			Unused.Value = Call("makeCurrentContext");
		}

		public static void clearCurrentContext()
		{
			Unused.Value = ms_class.Call("clearCurrentContext");
		}

		public static NSOpenGLContext currentContext()
		{
			return ms_class.Call("currentContext").To<NSOpenGLContext>();
		}

		public void copyAttributesFromContextWithMask(NSOpenGLContext context, UInt32 mask)
		{
			Unused.Value = Call("copyAttributesFromContext:withMask:", context, mask);
		}

		public void setValuesForParameter(IntPtr vals, NSOpenGLContextParameter param)
		{
			Unused.Value = Call("setValues:forParameter:", vals, param);
		}

		public void getValuesForParameter(IntPtr vals, NSOpenGLContextParameter param)
		{
			Unused.Value = Call("getValues:forParameter:", vals, param);
		}

		public void setCurrentVirtualScreen(Int32 screen)
		{
			Unused.Value = Call("setCurrentVirtualScreen:", screen);
		}

		public Int32 currentVirtualScreen()
		{
			return Call("currentVirtualScreen").To<Int32>();
		}

		public void createTextureFromViewInternalFormat(UInt32 target, NSView view, UInt32 format)
		{
			Unused.Value = Call("createTexture:fromView:internalFormat:", target, view, format);
		}

		public IntPtr CGLContextObj()
		{
			return Call("CGLContextObj").To<IntPtr>();
		}

		public void setPixelBufferCubeMapFaceMipMapLevelCurrentVirtualScreen(NSOpenGLPixelBuffer pixelBuffer, UInt32 face, Int32 level, Int32 screen)
		{
			Unused.Value = Call("setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:", pixelBuffer, face, level, screen);
		}

		public NSOpenGLPixelBuffer pixelBuffer()
		{
			return Call("pixelBuffer").To<NSOpenGLPixelBuffer>();
		}

		public UInt32 pixelBufferCubeMapFace()
		{
			return Call("pixelBufferCubeMapFace").To<UInt32>();
		}

		public Int32 pixelBufferMipMapLevel()
		{
			return Call("pixelBufferMipMapLevel").To<Int32>();
		}

		public void setTextureImageToPixelBufferColorBuffer(NSOpenGLPixelBuffer pixelBuffer, UInt32 source)
		{
			Unused.Value = Call("setTextureImageToPixelBuffer:colorBuffer:", pixelBuffer, source);
		}

		private static Class ms_class = new Class("NSOpenGLContext");
	}
}
