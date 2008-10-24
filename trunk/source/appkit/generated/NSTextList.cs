// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextList.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTextListPrependEnclosingMarker = ( 1 << 0 );
	}

	[Register]
	public partial class NSTextList : NSObject
	{
		public NSTextList() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextList(IntPtr instance) : base(instance)
		{
		}

		public NSTextList(Untyped instance) : base(instance)
		{
		}

		public static new NSTextList alloc()
		{
			return new NSTextList(ms_class.Call("alloc"));
		}

		public new NSTextList retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithMarkerFormatOptions(NSString format, UInt32 mask)
		{
			return Call("initWithMarkerFormat:options:", format, mask).To<NSObject>();
		}

		public NSString markerFormat()
		{
			return Call("markerFormat").To<NSString>();
		}

		public UInt32 listOptions()
		{
			return Call("listOptions").To<UInt32>();
		}

		public NSString markerForItemNumber(Int32 itemNum)
		{
			return Call("markerForItemNumber:", itemNum).To<NSString>();
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

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSTextList");
	}
}
