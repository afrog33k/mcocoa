// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPersistentDocument.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPersistentDocument : NSDocument
	{
		public NSPersistentDocument() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPersistentDocument(IntPtr instance) : base(instance)
		{
		}

		public NSPersistentDocument(Untyped instance) : base(instance)
		{
		}

		public static new NSPersistentDocument alloc()
		{
			return new NSPersistentDocument(ms_class.Call("alloc"));
		}

		public new NSPersistentDocument retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject managedObjectContext()
		{
			return Call("managedObjectContext").To<NSObject>();
		}

		public void setManagedObjectContext(NSObject managedObjectContext)
		{
			Unused.Value = Call("setManagedObjectContext:", managedObjectContext);
		}

		public NSObject managedObjectModel()
		{
			return Call("managedObjectModel").To<NSObject>();
		}

		public bool configurePersistentStoreCoordinatorForURLOfTypeModelConfigurationStoreOptionsError(NSURL url, NSString fileType, NSString configuration, NSDictionary storeOptions, IntPtr error)
		{
			return Call("configurePersistentStoreCoordinatorForURL:ofType:modelConfiguration:storeOptions:error:", url, fileType, configuration, storeOptions, error).To<bool>();
		}

		public NSString persistentStoreTypeForFileType(NSString fileType)
		{
			return Call("persistentStoreTypeForFileType:", fileType).To<NSString>();
		}

		// skipping writeToURL:ofType:forSaveOperation:originalContentsURL:error: (it's declared in a base class)

		// skipping readFromURL:ofType:error: (it's declared in a base class)

		// skipping revertToContentsOfURL:ofType:error: (it's declared in a base class)

		private static Class ms_class = new Class("NSPersistentDocument");
	}

	public static class NSPersistentDocumentDeprecatedForNSPersistentDocumentCategory
	{
		public static bool configurePersistentStoreCoordinatorForURLOfTypeError(this NSPersistentDocument _instance, NSURL url, NSString fileType, IntPtr error)
		{
			return _instance.Call("configurePersistentStoreCoordinatorForURL:ofType:error:", url, fileType, error).To<bool>();
		}
	}
}
