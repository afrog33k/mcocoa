// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSFormatter.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSFormatter : NSObject
	{
		public NSFormatter() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFormatter(IntPtr instance) : base(instance)
		{
		}

		public NSFormatter(Untyped instance) : base(instance)
		{
		}

		public static new NSFormatter alloc()
		{
			return new NSFormatter(ms_class.Call("alloc"));
		}

		public new NSFormatter retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString stringForObjectValue(NSObject obj)
		{
			return Call("stringForObjectValue:", obj).To<NSString>();
		}

		public NSAttributedString attributedStringForObjectValueWithDefaultAttributes(NSObject obj, NSDictionary attrs)
		{
			return Call("attributedStringForObjectValue:withDefaultAttributes:", obj, attrs).To<NSAttributedString>();
		}

		public NSString editingStringForObjectValue(NSObject obj)
		{
			return Call("editingStringForObjectValue:", obj).To<NSString>();
		}

		public bool getObjectValueForStringErrorDescription(IntPtr obj, NSString string_, IntPtr error)
		{
			return Call("getObjectValue:forString:errorDescription:", obj, string_, error).To<bool>();
		}

		public bool isPartialStringValidNewEditingStringErrorDescription(NSString partialString, IntPtr newString, IntPtr error)
		{
			return Call("isPartialStringValid:newEditingString:errorDescription:", partialString, newString, error).To<bool>();
		}

		public bool isPartialStringValidProposedSelectedRangeOriginalStringOriginalSelectedRangeErrorDescription(IntPtr partialStringPtr, IntPtr proposedSelRangePtr, NSString origString, NSRange origSelRange, IntPtr error)
		{
			return Call("isPartialStringValid:proposedSelectedRange:originalString:originalSelectedRange:errorDescription:", partialStringPtr, proposedSelRangePtr, origString, origSelRange, error).To<bool>();
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

		private static Class ms_class = new Class("NSFormatter");
	}
}
