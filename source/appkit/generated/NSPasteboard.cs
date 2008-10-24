// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPasteboard.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPasteboard : NSObject
	{
		public NSPasteboard() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPasteboard(IntPtr instance) : base(instance)
		{
		}

		public NSPasteboard(Untyped instance) : base(instance)
		{
		}

		public static new NSPasteboard alloc()
		{
			return new NSPasteboard(ms_class.Call("alloc"));
		}

		public new NSPasteboard retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSPasteboard generalPasteboard()
		{
			return ms_class.Call("generalPasteboard").To<NSPasteboard>();
		}

		public static NSPasteboard pasteboardWithName(NSString name)
		{
			return ms_class.Call("pasteboardWithName:", name).To<NSPasteboard>();
		}

		public static NSPasteboard pasteboardWithUniqueName()
		{
			return ms_class.Call("pasteboardWithUniqueName").To<NSPasteboard>();
		}

		public static NSArray typesFilterableTo(NSString type)
		{
			return ms_class.Call("typesFilterableTo:", type).To<NSArray>();
		}

		public static NSPasteboard pasteboardByFilteringFile(NSString filename)
		{
			return ms_class.Call("pasteboardByFilteringFile:", filename).To<NSPasteboard>();
		}

		public static NSPasteboard pasteboardByFilteringDataOfType(NSData data, NSString type)
		{
			return ms_class.Call("pasteboardByFilteringData:ofType:", data, type).To<NSPasteboard>();
		}

		public static NSPasteboard pasteboardByFilteringTypesInPasteboard(NSPasteboard pboard)
		{
			return ms_class.Call("pasteboardByFilteringTypesInPasteboard:", pboard).To<NSPasteboard>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public void releaseGlobally()
		{
			Unused.Value = Call("releaseGlobally");
		}

		public Int32 declareTypesOwner(NSArray newTypes, NSObject newOwner)
		{
			return Call("declareTypes:owner:", newTypes, newOwner).To<Int32>();
		}

		public Int32 addTypesOwner(NSArray newTypes, NSObject newOwner)
		{
			return Call("addTypes:owner:", newTypes, newOwner).To<Int32>();
		}

		public Int32 changeCount()
		{
			return Call("changeCount").To<Int32>();
		}

		public NSArray types()
		{
			return Call("types").To<NSArray>();
		}

		public NSString availableTypeFromArray(NSArray types)
		{
			return Call("availableTypeFromArray:", types).To<NSString>();
		}

		public bool setDataForType(NSData data, NSString dataType)
		{
			return Call("setData:forType:", data, dataType).To<bool>();
		}

		public NSData dataForType(NSString dataType)
		{
			return Call("dataForType:", dataType).To<NSData>();
		}

		public bool setPropertyListForType(NSObject plist, NSString dataType)
		{
			return Call("setPropertyList:forType:", plist, dataType).To<bool>();
		}

		public NSObject propertyListForType(NSString dataType)
		{
			return Call("propertyListForType:", dataType).To<NSObject>();
		}

		public bool setStringForType(NSString string_, NSString dataType)
		{
			return Call("setString:forType:", string_, dataType).To<bool>();
		}

		public NSString stringForType(NSString dataType)
		{
			return Call("stringForType:", dataType).To<NSString>();
		}

		private static Class ms_class = new Class("NSPasteboard");
	}

	public static class NSFileContentsForNSPasteboardCategory
	{
		public static bool writeFileContents(this NSPasteboard _instance, NSString filename)
		{
			return _instance.Call("writeFileContents:", filename).To<bool>();
		}

		public static NSString readFileContentsTypeToFile(this NSPasteboard _instance, NSString type, NSString filename)
		{
			return _instance.Call("readFileContentsType:toFile:", type, filename).To<NSString>();
		}

		public static bool writeFileWrapper(this NSPasteboard _instance, NSFileWrapper wrapper)
		{
			return _instance.Call("writeFileWrapper:", wrapper).To<bool>();
		}

		public static NSFileWrapper readFileWrapper(this NSPasteboard _instance)
		{
			return _instance.Call("readFileWrapper").To<NSFileWrapper>();
		}
	}

	public static class NSPasteboardSupportForNSURLCategory
	{
		public static NSURL URLFromPasteboard(this NSURL _instance, NSPasteboard pasteBoard)
		{
			return _instance.Call("URLFromPasteboard:", pasteBoard).To<NSURL>();
		}

		public static void writeToPasteboard(this NSURL _instance, NSPasteboard pasteBoard)
		{
			Unused.Value = _instance.Call("writeToPasteboard:", pasteBoard);
		}
	}

	public static class NSPasteboardOwnerForNSObjectCategory
	{
		public static void pasteboardProvideDataForType(this NSObject _instance, NSPasteboard sender, NSString type)
		{
			Unused.Value = _instance.Call("pasteboard:provideDataForType:", sender, type);
		}

		public static void pasteboardChangedOwner(this NSObject _instance, NSPasteboard sender)
		{
			Unused.Value = _instance.Call("pasteboardChangedOwner:", sender);
		}
	}
}
