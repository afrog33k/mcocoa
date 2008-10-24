// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPDFImageRep.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPDFImageRep : NSImageRep
	{
		public NSPDFImageRep() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPDFImageRep(IntPtr instance) : base(instance)
		{
		}

		public NSPDFImageRep(Untyped instance) : base(instance)
		{
		}

		public static new NSPDFImageRep alloc()
		{
			return new NSPDFImageRep(ms_class.Call("alloc"));
		}

		public new NSPDFImageRep retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject imageRepWithData(NSData pdfData)
		{
			return ms_class.Call("imageRepWithData:", pdfData).To<NSObject>();
		}

		public NSObject initWithData(NSData pdfData)
		{
			return Call("initWithData:", pdfData).To<NSObject>();
		}

		public NSData PDFRepresentation()
		{
			return Call("PDFRepresentation").To<NSData>();
		}

		public NSRect bounds()
		{
			return Call("bounds").To<NSRect>();
		}

		public void setCurrentPage(Int32 page)
		{
			Unused.Value = Call("setCurrentPage:", page);
		}

		public Int32 currentPage()
		{
			return Call("currentPage").To<Int32>();
		}

		public Int32 pageCount()
		{
			return Call("pageCount").To<Int32>();
		}

		private static Class ms_class = new Class("NSPDFImageRep");
	}
}
