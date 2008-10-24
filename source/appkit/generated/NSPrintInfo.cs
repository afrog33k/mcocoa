// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPrintInfo.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSPortraitOrientation = 0;
		public const int NSLandscapeOrientation = 1;
	}

	public partial class Enums
	{
		public const int NSAutoPagination = 0;
		public const int NSFitPagination = 1;
		public const int NSClipPagination = 2;
	}

	[Register]
	public partial class NSPrintInfo : NSObject
	{
		public NSPrintInfo() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPrintInfo(IntPtr instance) : base(instance)
		{
		}

		public NSPrintInfo(Untyped instance) : base(instance)
		{
		}

		public static new NSPrintInfo alloc()
		{
			return new NSPrintInfo(ms_class.Call("alloc"));
		}

		public new NSPrintInfo retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void setSharedPrintInfo(NSPrintInfo printInfo)
		{
			Unused.Value = ms_class.Call("setSharedPrintInfo:", printInfo);
		}

		public static NSPrintInfo sharedPrintInfo()
		{
			return ms_class.Call("sharedPrintInfo").To<NSPrintInfo>();
		}

		public NSObject initWithDictionary(NSDictionary attributes)
		{
			return Call("initWithDictionary:", attributes).To<NSObject>();
		}

		public NSMutableDictionary dictionary()
		{
			return Call("dictionary").To<NSMutableDictionary>();
		}

		public void setPaperName(NSString name)
		{
			Unused.Value = Call("setPaperName:", name);
		}

		public void setPaperSize(NSSize size)
		{
			Unused.Value = Call("setPaperSize:", size);
		}

		public void setOrientation(UInt32 orientation)
		{
			Unused.Value = Call("setOrientation:", orientation);
		}

		public NSString paperName()
		{
			return Call("paperName").To<NSString>();
		}

		public NSSize paperSize()
		{
			return Call("paperSize").To<NSSize>();
		}

		public UInt32 orientation()
		{
			return Call("orientation").To<UInt32>();
		}

		public void setLeftMargin(float margin)
		{
			Unused.Value = Call("setLeftMargin:", margin);
		}

		public void setRightMargin(float margin)
		{
			Unused.Value = Call("setRightMargin:", margin);
		}

		public void setTopMargin(float margin)
		{
			Unused.Value = Call("setTopMargin:", margin);
		}

		public void setBottomMargin(float margin)
		{
			Unused.Value = Call("setBottomMargin:", margin);
		}

		public float leftMargin()
		{
			return Call("leftMargin").To<float>();
		}

		public float rightMargin()
		{
			return Call("rightMargin").To<float>();
		}

		public float topMargin()
		{
			return Call("topMargin").To<float>();
		}

		public float bottomMargin()
		{
			return Call("bottomMargin").To<float>();
		}

		public void setHorizontallyCentered(bool flag)
		{
			Unused.Value = Call("setHorizontallyCentered:", flag);
		}

		public void setVerticallyCentered(bool flag)
		{
			Unused.Value = Call("setVerticallyCentered:", flag);
		}

		public bool isHorizontallyCentered()
		{
			return Call("isHorizontallyCentered").To<bool>();
		}

		public bool isVerticallyCentered()
		{
			return Call("isVerticallyCentered").To<bool>();
		}

		public void setHorizontalPagination(UInt32 mode)
		{
			Unused.Value = Call("setHorizontalPagination:", mode);
		}

		public void setVerticalPagination(UInt32 mode)
		{
			Unused.Value = Call("setVerticalPagination:", mode);
		}

		public UInt32 horizontalPagination()
		{
			return Call("horizontalPagination").To<UInt32>();
		}

		public UInt32 verticalPagination()
		{
			return Call("verticalPagination").To<UInt32>();
		}

		public void setJobDisposition(NSString disposition)
		{
			Unused.Value = Call("setJobDisposition:", disposition);
		}

		public NSString jobDisposition()
		{
			return Call("jobDisposition").To<NSString>();
		}

		public void setPrinter(NSPrinter printer)
		{
			Unused.Value = Call("setPrinter:", printer);
		}

		public NSPrinter printer()
		{
			return Call("printer").To<NSPrinter>();
		}

		public void setUpPrintOperationDefaultValues()
		{
			Unused.Value = Call("setUpPrintOperationDefaultValues");
		}

		public NSRect imageablePageBounds()
		{
			return Call("imageablePageBounds").To<NSRect>();
		}

		public NSString localizedPaperName()
		{
			return Call("localizedPaperName").To<NSString>();
		}

		public static NSPrinter defaultPrinter()
		{
			return ms_class.Call("defaultPrinter").To<NSPrinter>();
		}

		public NSMutableDictionary printSettings()
		{
			return Call("printSettings").To<NSMutableDictionary>();
		}

		public IntPtr PMPrintSession()
		{
			return Call("PMPrintSession").To<IntPtr>();
		}

		public IntPtr PMPageFormat()
		{
			return Call("PMPageFormat").To<IntPtr>();
		}

		public IntPtr PMPrintSettings()
		{
			return Call("PMPrintSettings").To<IntPtr>();
		}

		public void updateFromPMPageFormat()
		{
			Unused.Value = Call("updateFromPMPageFormat");
		}

		public void updateFromPMPrintSettings()
		{
			Unused.Value = Call("updateFromPMPrintSettings");
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

		private static Class ms_class = new Class("NSPrintInfo");
	}

	public static class NSDeprecatedForNSPrintInfoCategory
	{
		public static void setDefaultPrinter(this NSPrintInfo _instance, NSPrinter printer)
		{
			Unused.Value = _instance.Call("setDefaultPrinter:", printer);
		}

		public static NSSize sizeForPaperName(this NSPrintInfo _instance, NSString name)
		{
			return _instance.Call("sizeForPaperName:", name).To<NSSize>();
		}
	}
}
