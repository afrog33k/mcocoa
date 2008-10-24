// machine generated on 10/24/2008 3:54:03 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSAttributedString.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSAttributedString : NSObject
	{
		public NSAttributedString() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAttributedString(IntPtr instance) : base(instance)
		{
		}

		public NSAttributedString(Untyped instance) : base(instance)
		{
		}

		public static new NSAttributedString alloc()
		{
			return new NSAttributedString(ms_class.Call("alloc"));
		}

		public new NSAttributedString retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString string_()
		{
			return Call("string").To<NSString>();
		}

		public NSDictionary attributesAtIndexEffectiveRange(UInt32 location, IntPtr range)
		{
			return Call("attributesAtIndex:effectiveRange:", location, range).To<NSDictionary>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSMutableCopying Methods
		public NSObject mutableCopyWithZone(IntPtr zone)
		{
			return Call("mutableCopyWithZone:", zone).To<NSObject>();
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

		private static Class ms_class = new Class("NSAttributedString");
	}

	public static class NSExtendedAttributedStringForNSAttributedStringCategory
	{
		public static UInt32 length(this NSAttributedString _instance)
		{
			return _instance.Call("length").To<UInt32>();
		}

		public static NSObject attributeAtIndexEffectiveRange(this NSAttributedString _instance, NSString attrName, UInt32 location, IntPtr range)
		{
			return _instance.Call("attribute:atIndex:effectiveRange:", attrName, location, range).To<NSObject>();
		}

		public static NSAttributedString attributedSubstringFromRange(this NSAttributedString _instance, NSRange range)
		{
			return _instance.Call("attributedSubstringFromRange:", range).To<NSAttributedString>();
		}

		public static NSDictionary attributesAtIndexLongestEffectiveRangeInRange(this NSAttributedString _instance, UInt32 location, IntPtr range, NSRange rangeLimit)
		{
			return _instance.Call("attributesAtIndex:longestEffectiveRange:inRange:", location, range, rangeLimit).To<NSDictionary>();
		}

		public static NSObject attributeAtIndexLongestEffectiveRangeInRange(this NSAttributedString _instance, NSString attrName, UInt32 location, IntPtr range, NSRange rangeLimit)
		{
			return _instance.Call("attribute:atIndex:longestEffectiveRange:inRange:", attrName, location, range, rangeLimit).To<NSObject>();
		}

		public static bool isEqualToAttributedString(this NSAttributedString _instance, NSAttributedString other)
		{
			return _instance.Call("isEqualToAttributedString:", other).To<bool>();
		}

		public static NSObject initWithString(this NSAttributedString _instance, NSString str)
		{
			return _instance.Call("initWithString:", str).To<NSObject>();
		}

		public static NSObject initWithStringAttributes(this NSAttributedString _instance, NSString str, NSDictionary attrs)
		{
			return _instance.Call("initWithString:attributes:", str, attrs).To<NSObject>();
		}

		public static NSObject initWithAttributedString(this NSAttributedString _instance, NSAttributedString attrStr)
		{
			return _instance.Call("initWithAttributedString:", attrStr).To<NSObject>();
		}
	}

	[Register]
	public partial class NSMutableAttributedString : NSAttributedString
	{
		public NSMutableAttributedString() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableAttributedString(IntPtr instance) : base(instance)
		{
		}

		public NSMutableAttributedString(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableAttributedString alloc()
		{
			return new NSMutableAttributedString(ms_class.Call("alloc"));
		}

		public new NSMutableAttributedString retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void replaceCharactersInRangeWithString(NSRange range, NSString str)
		{
			Unused.Value = Call("replaceCharactersInRange:withString:", range, str);
		}

		public void setAttributesRange(NSDictionary attrs, NSRange range)
		{
			Unused.Value = Call("setAttributes:range:", attrs, range);
		}

		private static Class ms_class = new Class("NSMutableAttributedString");
	}

	public static class NSExtendedMutableAttributedStringForNSMutableAttributedStringCategory
	{
		public static NSMutableString mutableString(this NSMutableAttributedString _instance)
		{
			return _instance.Call("mutableString").To<NSMutableString>();
		}

		public static void addAttributeValueRange(this NSMutableAttributedString _instance, NSString name, NSObject value, NSRange range)
		{
			Unused.Value = _instance.Call("addAttribute:value:range:", name, value, range);
		}

		public static void addAttributesRange(this NSMutableAttributedString _instance, NSDictionary attrs, NSRange range)
		{
			Unused.Value = _instance.Call("addAttributes:range:", attrs, range);
		}

		public static void removeAttributeRange(this NSMutableAttributedString _instance, NSString name, NSRange range)
		{
			Unused.Value = _instance.Call("removeAttribute:range:", name, range);
		}

		public static void replaceCharactersInRangeWithAttributedString(this NSMutableAttributedString _instance, NSRange range, NSAttributedString attrString)
		{
			Unused.Value = _instance.Call("replaceCharactersInRange:withAttributedString:", range, attrString);
		}

		public static void insertAttributedStringAtIndex(this NSMutableAttributedString _instance, NSAttributedString attrString, UInt32 loc)
		{
			Unused.Value = _instance.Call("insertAttributedString:atIndex:", attrString, loc);
		}

		public static void appendAttributedString(this NSMutableAttributedString _instance, NSAttributedString attrString)
		{
			Unused.Value = _instance.Call("appendAttributedString:", attrString);
		}

		public static void deleteCharactersInRange(this NSMutableAttributedString _instance, NSRange range)
		{
			Unused.Value = _instance.Call("deleteCharactersInRange:", range);
		}

		public static void setAttributedString(this NSMutableAttributedString _instance, NSAttributedString attrString)
		{
			Unused.Value = _instance.Call("setAttributedString:", attrString);
		}

		public static void beginEditing(this NSMutableAttributedString _instance)
		{
			Unused.Value = _instance.Call("beginEditing");
		}

		public static void endEditing(this NSMutableAttributedString _instance)
		{
			Unused.Value = _instance.Call("endEditing");
		}
	}
}
