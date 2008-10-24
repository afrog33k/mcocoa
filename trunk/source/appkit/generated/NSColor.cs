// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSColor.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSColor : NSObject
	{
		public NSColor() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSColor(IntPtr instance) : base(instance)
		{
		}

		public NSColor(Untyped instance) : base(instance)
		{
		}

		public static new NSColor alloc()
		{
			return new NSColor(ms_class.Call("alloc"));
		}

		public new NSColor retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSColor colorWithCalibratedWhiteAlpha(float white, float alpha)
		{
			return ms_class.Call("colorWithCalibratedWhite:alpha:", white, alpha).To<NSColor>();
		}

		public static NSColor colorWithCalibratedHueSaturationBrightnessAlpha(float hue, float saturation, float brightness, float alpha)
		{
			return ms_class.Call("colorWithCalibratedHue:saturation:brightness:alpha:", hue, saturation, brightness, alpha).To<NSColor>();
		}

		public static NSColor colorWithCalibratedRedGreenBlueAlpha(float red, float green, float blue, float alpha)
		{
			return ms_class.Call("colorWithCalibratedRed:green:blue:alpha:", red, green, blue, alpha).To<NSColor>();
		}

		public static NSColor colorWithDeviceWhiteAlpha(float white, float alpha)
		{
			return ms_class.Call("colorWithDeviceWhite:alpha:", white, alpha).To<NSColor>();
		}

		public static NSColor colorWithDeviceHueSaturationBrightnessAlpha(float hue, float saturation, float brightness, float alpha)
		{
			return ms_class.Call("colorWithDeviceHue:saturation:brightness:alpha:", hue, saturation, brightness, alpha).To<NSColor>();
		}

		public static NSColor colorWithDeviceRedGreenBlueAlpha(float red, float green, float blue, float alpha)
		{
			return ms_class.Call("colorWithDeviceRed:green:blue:alpha:", red, green, blue, alpha).To<NSColor>();
		}

		public static NSColor colorWithDeviceCyanMagentaYellowBlackAlpha(float cyan, float magenta, float yellow, float black, float alpha)
		{
			return ms_class.Call("colorWithDeviceCyan:magenta:yellow:black:alpha:", cyan, magenta, yellow, black, alpha).To<NSColor>();
		}

		public static NSColor colorWithCatalogNameColorName(NSString listName, NSString colorName)
		{
			return ms_class.Call("colorWithCatalogName:colorName:", listName, colorName).To<NSColor>();
		}

		public static NSColor colorWithColorSpaceComponentsCount(NSColorSpace space, IntPtr components, Int32 numberOfComponents)
		{
			return ms_class.Call("colorWithColorSpace:components:count:", space, components, numberOfComponents).To<NSColor>();
		}

		public static NSColor blackColor()
		{
			return ms_class.Call("blackColor").To<NSColor>();
		}

		public static NSColor darkGrayColor()
		{
			return ms_class.Call("darkGrayColor").To<NSColor>();
		}

		public static NSColor lightGrayColor()
		{
			return ms_class.Call("lightGrayColor").To<NSColor>();
		}

		public static NSColor whiteColor()
		{
			return ms_class.Call("whiteColor").To<NSColor>();
		}

		public static NSColor grayColor()
		{
			return ms_class.Call("grayColor").To<NSColor>();
		}

		public static NSColor redColor()
		{
			return ms_class.Call("redColor").To<NSColor>();
		}

		public static NSColor greenColor()
		{
			return ms_class.Call("greenColor").To<NSColor>();
		}

		public static NSColor blueColor()
		{
			return ms_class.Call("blueColor").To<NSColor>();
		}

		public static NSColor cyanColor()
		{
			return ms_class.Call("cyanColor").To<NSColor>();
		}

		public static NSColor yellowColor()
		{
			return ms_class.Call("yellowColor").To<NSColor>();
		}

		public static NSColor magentaColor()
		{
			return ms_class.Call("magentaColor").To<NSColor>();
		}

		public static NSColor orangeColor()
		{
			return ms_class.Call("orangeColor").To<NSColor>();
		}

		public static NSColor purpleColor()
		{
			return ms_class.Call("purpleColor").To<NSColor>();
		}

		public static NSColor brownColor()
		{
			return ms_class.Call("brownColor").To<NSColor>();
		}

		public static NSColor clearColor()
		{
			return ms_class.Call("clearColor").To<NSColor>();
		}

		public static NSColor controlShadowColor()
		{
			return ms_class.Call("controlShadowColor").To<NSColor>();
		}

		public static NSColor controlDarkShadowColor()
		{
			return ms_class.Call("controlDarkShadowColor").To<NSColor>();
		}

		public static NSColor controlColor()
		{
			return ms_class.Call("controlColor").To<NSColor>();
		}

		public static NSColor controlHighlightColor()
		{
			return ms_class.Call("controlHighlightColor").To<NSColor>();
		}

		public static NSColor controlLightHighlightColor()
		{
			return ms_class.Call("controlLightHighlightColor").To<NSColor>();
		}

		public static NSColor controlTextColor()
		{
			return ms_class.Call("controlTextColor").To<NSColor>();
		}

		public static NSColor controlBackgroundColor()
		{
			return ms_class.Call("controlBackgroundColor").To<NSColor>();
		}

		public static NSColor selectedControlColor()
		{
			return ms_class.Call("selectedControlColor").To<NSColor>();
		}

		public static NSColor secondarySelectedControlColor()
		{
			return ms_class.Call("secondarySelectedControlColor").To<NSColor>();
		}

		public static NSColor selectedControlTextColor()
		{
			return ms_class.Call("selectedControlTextColor").To<NSColor>();
		}

		public static NSColor disabledControlTextColor()
		{
			return ms_class.Call("disabledControlTextColor").To<NSColor>();
		}

		public static NSColor textColor()
		{
			return ms_class.Call("textColor").To<NSColor>();
		}

		public static NSColor textBackgroundColor()
		{
			return ms_class.Call("textBackgroundColor").To<NSColor>();
		}

		public static NSColor selectedTextColor()
		{
			return ms_class.Call("selectedTextColor").To<NSColor>();
		}

		public static NSColor selectedTextBackgroundColor()
		{
			return ms_class.Call("selectedTextBackgroundColor").To<NSColor>();
		}

		public static NSColor gridColor()
		{
			return ms_class.Call("gridColor").To<NSColor>();
		}

		public static NSColor keyboardFocusIndicatorColor()
		{
			return ms_class.Call("keyboardFocusIndicatorColor").To<NSColor>();
		}

		public static NSColor windowBackgroundColor()
		{
			return ms_class.Call("windowBackgroundColor").To<NSColor>();
		}

		public static NSColor scrollBarColor()
		{
			return ms_class.Call("scrollBarColor").To<NSColor>();
		}

		public static NSColor knobColor()
		{
			return ms_class.Call("knobColor").To<NSColor>();
		}

		public static NSColor selectedKnobColor()
		{
			return ms_class.Call("selectedKnobColor").To<NSColor>();
		}

		public static NSColor windowFrameColor()
		{
			return ms_class.Call("windowFrameColor").To<NSColor>();
		}

		public static NSColor windowFrameTextColor()
		{
			return ms_class.Call("windowFrameTextColor").To<NSColor>();
		}

		public static NSColor selectedMenuItemColor()
		{
			return ms_class.Call("selectedMenuItemColor").To<NSColor>();
		}

		public static NSColor selectedMenuItemTextColor()
		{
			return ms_class.Call("selectedMenuItemTextColor").To<NSColor>();
		}

		public static NSColor highlightColor()
		{
			return ms_class.Call("highlightColor").To<NSColor>();
		}

		public static NSColor shadowColor()
		{
			return ms_class.Call("shadowColor").To<NSColor>();
		}

		public static NSColor headerColor()
		{
			return ms_class.Call("headerColor").To<NSColor>();
		}

		public static NSColor headerTextColor()
		{
			return ms_class.Call("headerTextColor").To<NSColor>();
		}

		public static NSColor alternateSelectedControlColor()
		{
			return ms_class.Call("alternateSelectedControlColor").To<NSColor>();
		}

		public static NSColor alternateSelectedControlTextColor()
		{
			return ms_class.Call("alternateSelectedControlTextColor").To<NSColor>();
		}

		public static NSArray controlAlternatingRowBackgroundColors()
		{
			return ms_class.Call("controlAlternatingRowBackgroundColors").To<NSArray>();
		}

		public NSColor highlightWithLevel(float val)
		{
			return Call("highlightWithLevel:", val).To<NSColor>();
		}

		public NSColor shadowWithLevel(float val)
		{
			return Call("shadowWithLevel:", val).To<NSColor>();
		}

		public static NSColor colorForControlTint(UInt32 controlTint)
		{
			return ms_class.Call("colorForControlTint:", controlTint).To<NSColor>();
		}

		public static UInt32 currentControlTint()
		{
			return ms_class.Call("currentControlTint").To<UInt32>();
		}

		public void set()
		{
			Unused.Value = Call("set");
		}

		public void setFill()
		{
			Unused.Value = Call("setFill");
		}

		public void setStroke()
		{
			Unused.Value = Call("setStroke");
		}

		public NSString colorSpaceName()
		{
			return Call("colorSpaceName").To<NSString>();
		}

		public NSColor colorUsingColorSpaceName(NSString colorSpace)
		{
			return Call("colorUsingColorSpaceName:", colorSpace).To<NSColor>();
		}

		public NSColor colorUsingColorSpaceNameDevice(NSString colorSpace, NSDictionary deviceDescription)
		{
			return Call("colorUsingColorSpaceName:device:", colorSpace, deviceDescription).To<NSColor>();
		}

		public NSColor colorUsingColorSpace(NSColorSpace space)
		{
			return Call("colorUsingColorSpace:", space).To<NSColor>();
		}

		public NSColor blendedColorWithFractionOfColor(float fraction, NSColor color)
		{
			return Call("blendedColorWithFraction:ofColor:", fraction, color).To<NSColor>();
		}

		public NSColor colorWithAlphaComponent(float alpha)
		{
			return Call("colorWithAlphaComponent:", alpha).To<NSColor>();
		}

		public NSString catalogNameComponent()
		{
			return Call("catalogNameComponent").To<NSString>();
		}

		public NSString colorNameComponent()
		{
			return Call("colorNameComponent").To<NSString>();
		}

		public NSString localizedCatalogNameComponent()
		{
			return Call("localizedCatalogNameComponent").To<NSString>();
		}

		public NSString localizedColorNameComponent()
		{
			return Call("localizedColorNameComponent").To<NSString>();
		}

		public float redComponent()
		{
			return Call("redComponent").To<float>();
		}

		public float greenComponent()
		{
			return Call("greenComponent").To<float>();
		}

		public float blueComponent()
		{
			return Call("blueComponent").To<float>();
		}

		public void getRedGreenBlueAlpha(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Unused.Value = Call("getRed:green:blue:alpha:", red, green, blue, alpha);
		}

		public float hueComponent()
		{
			return Call("hueComponent").To<float>();
		}

		public float saturationComponent()
		{
			return Call("saturationComponent").To<float>();
		}

		public float brightnessComponent()
		{
			return Call("brightnessComponent").To<float>();
		}

		public void getHueSaturationBrightnessAlpha(IntPtr hue, IntPtr saturation, IntPtr brightness, IntPtr alpha)
		{
			Unused.Value = Call("getHue:saturation:brightness:alpha:", hue, saturation, brightness, alpha);
		}

		public float whiteComponent()
		{
			return Call("whiteComponent").To<float>();
		}

		public void getWhiteAlpha(IntPtr white, IntPtr alpha)
		{
			Unused.Value = Call("getWhite:alpha:", white, alpha);
		}

		public float cyanComponent()
		{
			return Call("cyanComponent").To<float>();
		}

		public float magentaComponent()
		{
			return Call("magentaComponent").To<float>();
		}

		public float yellowComponent()
		{
			return Call("yellowComponent").To<float>();
		}

		public float blackComponent()
		{
			return Call("blackComponent").To<float>();
		}

		public void getCyanMagentaYellowBlackAlpha(IntPtr cyan, IntPtr magenta, IntPtr yellow, IntPtr black, IntPtr alpha)
		{
			Unused.Value = Call("getCyan:magenta:yellow:black:alpha:", cyan, magenta, yellow, black, alpha);
		}

		public NSColorSpace colorSpace()
		{
			return Call("colorSpace").To<NSColorSpace>();
		}

		public Int32 numberOfComponents()
		{
			return Call("numberOfComponents").To<Int32>();
		}

		public void getComponents(IntPtr components)
		{
			Unused.Value = Call("getComponents:", components);
		}

		public float alphaComponent()
		{
			return Call("alphaComponent").To<float>();
		}

		public static NSColor colorFromPasteboard(NSPasteboard pasteBoard)
		{
			return ms_class.Call("colorFromPasteboard:", pasteBoard).To<NSColor>();
		}

		public void writeToPasteboard(NSPasteboard pasteBoard)
		{
			Unused.Value = Call("writeToPasteboard:", pasteBoard);
		}

		public static NSColor colorWithPatternImage(NSImage image)
		{
			return ms_class.Call("colorWithPatternImage:", image).To<NSColor>();
		}

		public NSImage patternImage()
		{
			return Call("patternImage").To<NSImage>();
		}

		public void drawSwatchInRect(NSRect rect)
		{
			Unused.Value = Call("drawSwatchInRect:", rect);
		}

		public static void setIgnoresAlpha(bool flag)
		{
			Unused.Value = ms_class.Call("setIgnoresAlpha:", flag);
		}

		public static bool ignoresAlpha()
		{
			return ms_class.Call("ignoresAlpha").To<bool>();
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

		private static Class ms_class = new Class("NSColor");
	}

	public static class NSQuartzCoreAdditionsForNSColorCategory
	{
		public static NSColor colorWithCIColor(this NSColor _instance, NSObject color)
		{
			return _instance.Call("colorWithCIColor:", color).To<NSColor>();
		}
	}

	public static class NSAppKitAdditionsForCIColorCategory
	{
		public static NSObject initWithColor(this CIColor _instance, NSColor color)
		{
			return _instance.Call("initWithColor:", color).To<NSObject>();
		}
	}

	public static class NSAppKitColorExtensionsForNSCoderCategory
	{
		public static NSColor decodeNXColor(this NSCoder _instance)
		{
			return _instance.Call("decodeNXColor").To<NSColor>();
		}
	}
}
