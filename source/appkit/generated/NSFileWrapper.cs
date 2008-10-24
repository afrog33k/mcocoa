// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSFileWrapper.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSFileWrapper : NSObject
	{
		public NSFileWrapper() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFileWrapper(IntPtr instance) : base(instance)
		{
		}

		public NSFileWrapper(Untyped instance) : base(instance)
		{
		}

		public static new NSFileWrapper alloc()
		{
			return new NSFileWrapper(ms_class.Call("alloc"));
		}

		public new NSFileWrapper retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initDirectoryWithFileWrappers(NSDictionary docs)
		{
			return Call("initDirectoryWithFileWrappers:", docs).To<NSObject>();
		}

		public NSObject initRegularFileWithContents(NSData data)
		{
			return Call("initRegularFileWithContents:", data).To<NSObject>();
		}

		public NSObject initSymbolicLinkWithDestination(NSString path)
		{
			return Call("initSymbolicLinkWithDestination:", path).To<NSObject>();
		}

		public NSObject initWithPath(NSString path)
		{
			return Call("initWithPath:", path).To<NSObject>();
		}

		public NSObject initWithSerializedRepresentation(NSData data)
		{
			return Call("initWithSerializedRepresentation:", data).To<NSObject>();
		}

		public bool writeToFileAtomicallyUpdateFilenames(NSString path, bool atomicFlag, bool updateFilenamesFlag)
		{
			return Call("writeToFile:atomically:updateFilenames:", path, atomicFlag, updateFilenamesFlag).To<bool>();
		}

		public NSData serializedRepresentation()
		{
			return Call("serializedRepresentation").To<NSData>();
		}

		public void setFilename(NSString filename)
		{
			Unused.Value = Call("setFilename:", filename);
		}

		public NSString filename()
		{
			return Call("filename").To<NSString>();
		}

		public void setPreferredFilename(NSString filename)
		{
			Unused.Value = Call("setPreferredFilename:", filename);
		}

		public NSString preferredFilename()
		{
			return Call("preferredFilename").To<NSString>();
		}

		public void setFileAttributes(NSDictionary attributes)
		{
			Unused.Value = Call("setFileAttributes:", attributes);
		}

		public NSDictionary fileAttributes()
		{
			return Call("fileAttributes").To<NSDictionary>();
		}

		public bool isRegularFile()
		{
			return Call("isRegularFile").To<bool>();
		}

		public bool isDirectory()
		{
			return Call("isDirectory").To<bool>();
		}

		public bool isSymbolicLink()
		{
			return Call("isSymbolicLink").To<bool>();
		}

		public void setIcon(NSImage icon)
		{
			Unused.Value = Call("setIcon:", icon);
		}

		public NSImage icon()
		{
			return Call("icon").To<NSImage>();
		}

		public bool needsToBeUpdatedFromPath(NSString path)
		{
			return Call("needsToBeUpdatedFromPath:", path).To<bool>();
		}

		public bool updateFromPath(NSString path)
		{
			return Call("updateFromPath:", path).To<bool>();
		}

		public NSString addFileWrapper(NSFileWrapper doc)
		{
			return Call("addFileWrapper:", doc).To<NSString>();
		}

		public void removeFileWrapper(NSFileWrapper doc)
		{
			Unused.Value = Call("removeFileWrapper:", doc);
		}

		public NSDictionary fileWrappers()
		{
			return Call("fileWrappers").To<NSDictionary>();
		}

		public NSString keyForFileWrapper(NSFileWrapper doc)
		{
			return Call("keyForFileWrapper:", doc).To<NSString>();
		}

		public NSString addFileWithPath(NSString path)
		{
			return Call("addFileWithPath:", path).To<NSString>();
		}

		public NSString addRegularFileWithContentsPreferredFilename(NSData data, NSString filename)
		{
			return Call("addRegularFileWithContents:preferredFilename:", data, filename).To<NSString>();
		}

		public NSString addSymbolicLinkWithDestinationPreferredFilename(NSString path, NSString filename)
		{
			return Call("addSymbolicLinkWithDestination:preferredFilename:", path, filename).To<NSString>();
		}

		public NSData regularFileContents()
		{
			return Call("regularFileContents").To<NSData>();
		}

		public NSString symbolicLinkDestination()
		{
			return Call("symbolicLinkDestination").To<NSString>();
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

		private static Class ms_class = new Class("NSFileWrapper");
	}
}
