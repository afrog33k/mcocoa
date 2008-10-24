// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSParagraphStyle.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSLeftTabStopType = 0;
		public const int NSRightTabStopType = 1;
		public const int NSCenterTabStopType = 2;
		public const int NSDecimalTabStopType = 3;
	}

	public partial class Enums
	{
		public const int NSLineBreakByWordWrapping = 0;
		public const int NSLineBreakByCharWrapping = 1;
		public const int NSLineBreakByClipping = 2;
		public const int NSLineBreakByTruncatingHead = 3;
		public const int NSLineBreakByTruncatingTail = 4;
		public const int NSLineBreakByTruncatingMiddle = 5;
	}

	[Register]
	public partial class NSTextTab : NSObject
	{
		public NSTextTab() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextTab(IntPtr instance) : base(instance)
		{
		}

		public NSTextTab(Untyped instance) : base(instance)
		{
		}

		public static new NSTextTab alloc()
		{
			return new NSTextTab(ms_class.Call("alloc"));
		}

		public new NSTextTab retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithTextAlignmentLocationOptions(UInt32 alignment, float loc, NSDictionary options)
		{
			return Call("initWithTextAlignment:location:options:", alignment, loc, options).To<NSObject>();
		}

		public UInt32 alignment()
		{
			return Call("alignment").To<UInt32>();
		}

		public NSDictionary options()
		{
			return Call("options").To<NSDictionary>();
		}

		public NSObject initWithTypeLocation(UInt32 type, float loc)
		{
			return Call("initWithType:location:", type, loc).To<NSObject>();
		}

		public float location()
		{
			return Call("location").To<float>();
		}

		public UInt32 tabStopType()
		{
			return Call("tabStopType").To<UInt32>();
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

		private static Class ms_class = new Class("NSTextTab");
	}

	[Register]
	public partial class NSParagraphStyle : NSObject
	{
		public NSParagraphStyle() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSParagraphStyle(IntPtr instance) : base(instance)
		{
		}

		public NSParagraphStyle(Untyped instance) : base(instance)
		{
		}

		public static new NSParagraphStyle alloc()
		{
			return new NSParagraphStyle(ms_class.Call("alloc"));
		}

		public new NSParagraphStyle retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSParagraphStyle defaultParagraphStyle()
		{
			return ms_class.Call("defaultParagraphStyle").To<NSParagraphStyle>();
		}

		public static Int32 defaultWritingDirectionForLanguage(NSString languageName)
		{
			return ms_class.Call("defaultWritingDirectionForLanguage:", languageName).To<Int32>();
		}

		public float lineSpacing()
		{
			return Call("lineSpacing").To<float>();
		}

		public float paragraphSpacing()
		{
			return Call("paragraphSpacing").To<float>();
		}

		public UInt32 alignment()
		{
			return Call("alignment").To<UInt32>();
		}

		public float headIndent()
		{
			return Call("headIndent").To<float>();
		}

		public float tailIndent()
		{
			return Call("tailIndent").To<float>();
		}

		public float firstLineHeadIndent()
		{
			return Call("firstLineHeadIndent").To<float>();
		}

		public NSArray tabStops()
		{
			return Call("tabStops").To<NSArray>();
		}

		public float minimumLineHeight()
		{
			return Call("minimumLineHeight").To<float>();
		}

		public float maximumLineHeight()
		{
			return Call("maximumLineHeight").To<float>();
		}

		public UInt32 lineBreakMode()
		{
			return Call("lineBreakMode").To<UInt32>();
		}

		public Int32 baseWritingDirection()
		{
			return Call("baseWritingDirection").To<Int32>();
		}

		public float lineHeightMultiple()
		{
			return Call("lineHeightMultiple").To<float>();
		}

		public float paragraphSpacingBefore()
		{
			return Call("paragraphSpacingBefore").To<float>();
		}

		public float defaultTabInterval()
		{
			return Call("defaultTabInterval").To<float>();
		}

		public NSArray textBlocks()
		{
			return Call("textBlocks").To<NSArray>();
		}

		public NSArray textLists()
		{
			return Call("textLists").To<NSArray>();
		}

		public float hyphenationFactor()
		{
			return Call("hyphenationFactor").To<float>();
		}

		public float tighteningFactorForTruncation()
		{
			return Call("tighteningFactorForTruncation").To<float>();
		}

		public Int32 headerLevel()
		{
			return Call("headerLevel").To<Int32>();
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

		private static Class ms_class = new Class("NSParagraphStyle");
	}

	[Register]
	public partial class NSMutableParagraphStyle : NSParagraphStyle
	{
		public NSMutableParagraphStyle() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableParagraphStyle(IntPtr instance) : base(instance)
		{
		}

		public NSMutableParagraphStyle(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableParagraphStyle alloc()
		{
			return new NSMutableParagraphStyle(ms_class.Call("alloc"));
		}

		public new NSMutableParagraphStyle retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setLineSpacing(float aFloat)
		{
			Unused.Value = Call("setLineSpacing:", aFloat);
		}

		public void setParagraphSpacing(float aFloat)
		{
			Unused.Value = Call("setParagraphSpacing:", aFloat);
		}

		public void setAlignment(UInt32 alignment)
		{
			Unused.Value = Call("setAlignment:", alignment);
		}

		public void setFirstLineHeadIndent(float aFloat)
		{
			Unused.Value = Call("setFirstLineHeadIndent:", aFloat);
		}

		public void setHeadIndent(float aFloat)
		{
			Unused.Value = Call("setHeadIndent:", aFloat);
		}

		public void setTailIndent(float aFloat)
		{
			Unused.Value = Call("setTailIndent:", aFloat);
		}

		public void setLineBreakMode(UInt32 mode)
		{
			Unused.Value = Call("setLineBreakMode:", mode);
		}

		public void setMinimumLineHeight(float aFloat)
		{
			Unused.Value = Call("setMinimumLineHeight:", aFloat);
		}

		public void setMaximumLineHeight(float aFloat)
		{
			Unused.Value = Call("setMaximumLineHeight:", aFloat);
		}

		public void addTabStop(NSTextTab anObject)
		{
			Unused.Value = Call("addTabStop:", anObject);
		}

		public void removeTabStop(NSTextTab anObject)
		{
			Unused.Value = Call("removeTabStop:", anObject);
		}

		public void setTabStops(NSArray array)
		{
			Unused.Value = Call("setTabStops:", array);
		}

		public void setParagraphStyle(NSParagraphStyle obj)
		{
			Unused.Value = Call("setParagraphStyle:", obj);
		}

		public void setBaseWritingDirection(Int32 writingDirection)
		{
			Unused.Value = Call("setBaseWritingDirection:", writingDirection);
		}

		public void setLineHeightMultiple(float aFloat)
		{
			Unused.Value = Call("setLineHeightMultiple:", aFloat);
		}

		public void setParagraphSpacingBefore(float aFloat)
		{
			Unused.Value = Call("setParagraphSpacingBefore:", aFloat);
		}

		public void setDefaultTabInterval(float aFloat)
		{
			Unused.Value = Call("setDefaultTabInterval:", aFloat);
		}

		public void setTextBlocks(NSArray array)
		{
			Unused.Value = Call("setTextBlocks:", array);
		}

		public void setTextLists(NSArray array)
		{
			Unused.Value = Call("setTextLists:", array);
		}

		public void setHyphenationFactor(float aFactor)
		{
			Unused.Value = Call("setHyphenationFactor:", aFactor);
		}

		public void setTighteningFactorForTruncation(float aFactor)
		{
			Unused.Value = Call("setTighteningFactorForTruncation:", aFactor);
		}

		public void setHeaderLevel(Int32 level)
		{
			Unused.Value = Call("setHeaderLevel:", level);
		}

		private static Class ms_class = new Class("NSMutableParagraphStyle");
	}
}
