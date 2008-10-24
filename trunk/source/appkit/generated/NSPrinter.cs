// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPrinter.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSPrinterTableOK = 0;
		public const int NSPrinterTableNotFound = 1;
		public const int NSPrinterTableError = 2;
	}

	[Register]
	public partial class NSPrinter : NSObject
	{
		public NSPrinter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPrinter(IntPtr instance) : base(instance)
		{
		}

		public NSPrinter(Untyped instance) : base(instance)
		{
		}

		public static new NSPrinter alloc()
		{
			return new NSPrinter(ms_class.Call("alloc"));
		}

		public new NSPrinter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSArray printerNames()
		{
			return ms_class.Call("printerNames").To<NSArray>();
		}

		public static NSArray printerTypes()
		{
			return ms_class.Call("printerTypes").To<NSArray>();
		}

		public static NSPrinter printerWithName(NSString name)
		{
			return ms_class.Call("printerWithName:", name).To<NSPrinter>();
		}

		public static NSPrinter printerWithType(NSString type)
		{
			return ms_class.Call("printerWithType:", type).To<NSPrinter>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public NSString type()
		{
			return Call("type").To<NSString>();
		}

		public Int32 languageLevel()
		{
			return Call("languageLevel").To<Int32>();
		}

		public NSSize pageSizeForPaper(NSString paperName)
		{
			return Call("pageSizeForPaper:", paperName).To<NSSize>();
		}

		public UInt32 statusForTable(NSString tableName)
		{
			return Call("statusForTable:", tableName).To<UInt32>();
		}

		public bool isKeyInTable(NSString key, NSString table)
		{
			return Call("isKey:inTable:", key, table).To<bool>();
		}

		public bool booleanForKeyInTable(NSString key, NSString table)
		{
			return Call("booleanForKey:inTable:", key, table).To<bool>();
		}

		public float floatForKeyInTable(NSString key, NSString table)
		{
			return Call("floatForKey:inTable:", key, table).To<float>();
		}

		public UInt32 intForKeyInTable(NSString key, NSString table)
		{
			return Call("intForKey:inTable:", key, table).To<UInt32>();
		}

		public NSRect rectForKeyInTable(NSString key, NSString table)
		{
			return Call("rectForKey:inTable:", key, table).To<NSRect>();
		}

		public NSSize sizeForKeyInTable(NSString key, NSString table)
		{
			return Call("sizeForKey:inTable:", key, table).To<NSSize>();
		}

		public NSString stringForKeyInTable(NSString key, NSString table)
		{
			return Call("stringForKey:inTable:", key, table).To<NSString>();
		}

		public NSArray stringListForKeyInTable(NSString key, NSString table)
		{
			return Call("stringListForKey:inTable:", key, table).To<NSArray>();
		}

		public NSDictionary deviceDescription()
		{
			return Call("deviceDescription").To<NSDictionary>();
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

		private static Class ms_class = new Class("NSPrinter");
	}

	public static class NSDeprecatedForNSPrinterCategory
	{
		public static NSRect imageRectForPaper(this NSPrinter _instance, NSString paperName)
		{
			return _instance.Call("imageRectForPaper:", paperName).To<NSRect>();
		}

		public static bool acceptsBinary(this NSPrinter _instance)
		{
			return _instance.Call("acceptsBinary").To<bool>();
		}

		public static bool isColor(this NSPrinter _instance)
		{
			return _instance.Call("isColor").To<bool>();
		}

		public static bool isFontAvailable(this NSPrinter _instance, NSString faceName)
		{
			return _instance.Call("isFontAvailable:", faceName).To<bool>();
		}

		public static bool isOutputStackInReverseOrder(this NSPrinter _instance)
		{
			return _instance.Call("isOutputStackInReverseOrder").To<bool>();
		}

		public static NSPrinter printerWithNameDomainIncludeUnavailable(this NSPrinter _instance, NSString name, NSString domain, bool flag)
		{
			return _instance.Call("printerWithName:domain:includeUnavailable:", name, domain, flag).To<NSPrinter>();
		}

		public static NSString domain(this NSPrinter _instance)
		{
			return _instance.Call("domain").To<NSString>();
		}

		public static NSString host(this NSPrinter _instance)
		{
			return _instance.Call("host").To<NSString>();
		}

		public static NSString note(this NSPrinter _instance)
		{
			return _instance.Call("note").To<NSString>();
		}
	}
}
