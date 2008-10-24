// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSMovie.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSMovie : NSObject
	{
		public NSMovie() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMovie(IntPtr instance) : base(instance)
		{
		}

		public NSMovie(Untyped instance) : base(instance)
		{
		}

		public static new NSMovie alloc()
		{
			return new NSMovie(ms_class.Call("alloc"));
		}

		public new NSMovie retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithMovie(IntPtr movie)
		{
			return Call("initWithMovie:", movie).To<NSObject>();
		}

		public NSObject initWithURLByReference(NSURL url, bool byRef)
		{
			return Call("initWithURL:byReference:", url, byRef).To<NSObject>();
		}

		public NSObject initWithPasteboard(NSPasteboard pasteboard)
		{
			return Call("initWithPasteboard:", pasteboard).To<NSObject>();
		}

		public IntPtr QTMovie()
		{
			return Call("QTMovie").To<IntPtr>();
		}

		public NSURL URL()
		{
			return Call("URL").To<NSURL>();
		}

		public static NSArray movieUnfilteredFileTypes()
		{
			return ms_class.Call("movieUnfilteredFileTypes").To<NSArray>();
		}

		public static NSArray movieUnfilteredPasteboardTypes()
		{
			return ms_class.Call("movieUnfilteredPasteboardTypes").To<NSArray>();
		}

		public static bool canInitWithPasteboard(NSPasteboard pasteboard)
		{
			return ms_class.Call("canInitWithPasteboard:", pasteboard).To<bool>();
		}

		// skipping initWithMovie: (it's already defined)

		// skipping QTMovie (it's already defined)

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

		private static Class ms_class = new Class("NSMovie");
	}
}
