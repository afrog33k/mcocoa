// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSNib.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSNib : NSObject
	{
		public NSNib() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNib(IntPtr instance) : base(instance)
		{
		}

		public NSNib(Untyped instance) : base(instance)
		{
		}

		public static new NSNib alloc()
		{
			return new NSNib(ms_class.Call("alloc"));
		}

		public new NSNib retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContentsOfURL(NSURL nibFileURL)
		{
			return Call("initWithContentsOfURL:", nibFileURL).To<NSObject>();
		}

		public NSObject initWithNibNamedBundle(NSString nibName, NSBundle bundle)
		{
			return Call("initWithNibNamed:bundle:", nibName, bundle).To<NSObject>();
		}

		public bool instantiateNibWithExternalNameTable(NSDictionary externalNameTable)
		{
			return Call("instantiateNibWithExternalNameTable:", externalNameTable).To<bool>();
		}

		public bool instantiateNibWithOwnerTopLevelObjects(NSObject owner, IntPtr topLevelObjects)
		{
			return Call("instantiateNibWithOwner:topLevelObjects:", owner, topLevelObjects).To<bool>();
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

		private static Class ms_class = new Class("NSNib");
	}
}
