// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSText.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSEnterCharacter = 0x0003;
		public const int NSBackspaceCharacter = 0x0008;
		public const int NSTabCharacter = 0x0009;
		public const int NSNewlineCharacter = 0x000a;
		public const int NSFormFeedCharacter = 0x000c;
		public const int NSCarriageReturnCharacter = 0x000d;
		public const int NSBackTabCharacter = 0x0019;
		public const int NSDeleteCharacter = 0x007f;
		public const int NSLineSeparatorCharacter = 0x2028;
		public const int NSParagraphSeparatorCharacter = 0x2029;
	}

	public partial class Enums
	{
		public const int NSLeftTextAlignment = 0;
		public const int NSRightTextAlignment = 1;
		public const int NSCenterTextAlignment = 2;
		public const int NSJustifiedTextAlignment = 3;
		public const int NSNaturalTextAlignment = 4;
	}

	public partial class Enums
	{
		public const int NSWritingDirectionNatural = -1;
		public const int NSWritingDirectionLeftToRight = 0;
		public const int NSWritingDirectionRightToLeft = 1;
	}

	public partial class Enums
	{
		public const int NSIllegalTextMovement = 0;
		public const int NSReturnTextMovement = 0x10;
		public const int NSTabTextMovement = 0x11;
		public const int NSBacktabTextMovement = 0x12;
		public const int NSLeftTextMovement = 0x13;
		public const int NSRightTextMovement = 0x14;
		public const int NSUpTextMovement = 0x15;
		public const int NSDownTextMovement = 0x16;
		public const int NSCancelTextMovement = 0x17;
		public const int NSOtherTextMovement = 0;
	}

	[Register]
	public partial class NSText : NSView
	{
		public NSText() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSText(IntPtr instance) : base(instance)
		{
		}

		public NSText(Untyped instance) : base(instance)
		{
		}

		public static new NSText alloc()
		{
			return new NSText(ms_class.Call("alloc"));
		}

		public new NSText retain()
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

		public void setString(NSString string_)
		{
			Unused.Value = Call("setString:", string_);
		}

		public void replaceCharactersInRangeWithString(NSRange range, NSString aString)
		{
			Unused.Value = Call("replaceCharactersInRange:withString:", range, aString);
		}

		public void replaceCharactersInRangeWithRTF(NSRange range, NSData rtfData)
		{
			Unused.Value = Call("replaceCharactersInRange:withRTF:", range, rtfData);
		}

		public void replaceCharactersInRangeWithRTFD(NSRange range, NSData rtfdData)
		{
			Unused.Value = Call("replaceCharactersInRange:withRTFD:", range, rtfdData);
		}

		public NSData RTFFromRange(NSRange range)
		{
			return Call("RTFFromRange:", range).To<NSData>();
		}

		public NSData RTFDFromRange(NSRange range)
		{
			return Call("RTFDFromRange:", range).To<NSData>();
		}

		public bool writeRTFDToFileAtomically(NSString path, bool flag)
		{
			return Call("writeRTFDToFile:atomically:", path, flag).To<bool>();
		}

		public bool readRTFDFromFile(NSString path)
		{
			return Call("readRTFDFromFile:", path).To<bool>();
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public void setEditable(bool flag)
		{
			Unused.Value = Call("setEditable:", flag);
		}

		public bool isSelectable()
		{
			return Call("isSelectable").To<bool>();
		}

		public void setSelectable(bool flag)
		{
			Unused.Value = Call("setSelectable:", flag);
		}

		public bool isRichText()
		{
			return Call("isRichText").To<bool>();
		}

		public void setRichText(bool flag)
		{
			Unused.Value = Call("setRichText:", flag);
		}

		public bool importsGraphics()
		{
			return Call("importsGraphics").To<bool>();
		}

		public void setImportsGraphics(bool flag)
		{
			Unused.Value = Call("setImportsGraphics:", flag);
		}

		public bool isFieldEditor()
		{
			return Call("isFieldEditor").To<bool>();
		}

		public void setFieldEditor(bool flag)
		{
			Unused.Value = Call("setFieldEditor:", flag);
		}

		public bool usesFontPanel()
		{
			return Call("usesFontPanel").To<bool>();
		}

		public void setUsesFontPanel(bool flag)
		{
			Unused.Value = Call("setUsesFontPanel:", flag);
		}

		public bool drawsBackground()
		{
			return Call("drawsBackground").To<bool>();
		}

		public void setDrawsBackground(bool flag)
		{
			Unused.Value = Call("setDrawsBackground:", flag);
		}

		public NSColor backgroundColor()
		{
			return Call("backgroundColor").To<NSColor>();
		}

		public void setBackgroundColor(NSColor color)
		{
			Unused.Value = Call("setBackgroundColor:", color);
		}

		public bool isRulerVisible()
		{
			return Call("isRulerVisible").To<bool>();
		}

		public NSRange selectedRange()
		{
			return Call("selectedRange").To<NSRange>();
		}

		public void setSelectedRange(NSRange range)
		{
			Unused.Value = Call("setSelectedRange:", range);
		}

		public void scrollRangeToVisible(NSRange range)
		{
			Unused.Value = Call("scrollRangeToVisible:", range);
		}

		public void setFont(NSFont obj)
		{
			Unused.Value = Call("setFont:", obj);
		}

		public NSFont font()
		{
			return Call("font").To<NSFont>();
		}

		public void setTextColor(NSColor color)
		{
			Unused.Value = Call("setTextColor:", color);
		}

		public NSColor textColor()
		{
			return Call("textColor").To<NSColor>();
		}

		public UInt32 alignment()
		{
			return Call("alignment").To<UInt32>();
		}

		public void setAlignment(UInt32 mode)
		{
			Unused.Value = Call("setAlignment:", mode);
		}

		public Int32 baseWritingDirection()
		{
			return Call("baseWritingDirection").To<Int32>();
		}

		public void setBaseWritingDirection(Int32 writingDirection)
		{
			Unused.Value = Call("setBaseWritingDirection:", writingDirection);
		}

		public void setTextColorRange(NSColor color, NSRange range)
		{
			Unused.Value = Call("setTextColor:range:", color, range);
		}

		public void setFontRange(NSFont font, NSRange range)
		{
			Unused.Value = Call("setFont:range:", font, range);
		}

		public NSSize maxSize()
		{
			return Call("maxSize").To<NSSize>();
		}

		public void setMaxSize(NSSize newMaxSize)
		{
			Unused.Value = Call("setMaxSize:", newMaxSize);
		}

		public NSSize minSize()
		{
			return Call("minSize").To<NSSize>();
		}

		public void setMinSize(NSSize newMinSize)
		{
			Unused.Value = Call("setMinSize:", newMinSize);
		}

		public bool isHorizontallyResizable()
		{
			return Call("isHorizontallyResizable").To<bool>();
		}

		public void setHorizontallyResizable(bool flag)
		{
			Unused.Value = Call("setHorizontallyResizable:", flag);
		}

		public bool isVerticallyResizable()
		{
			return Call("isVerticallyResizable").To<bool>();
		}

		public void setVerticallyResizable(bool flag)
		{
			Unused.Value = Call("setVerticallyResizable:", flag);
		}

		public void sizeToFit()
		{
			Unused.Value = Call("sizeToFit");
		}

		public void copy(NSObject sender)
		{
			Unused.Value = Call("copy:", sender);
		}

		public void copyFont(NSObject sender)
		{
			Unused.Value = Call("copyFont:", sender);
		}

		public void copyRuler(NSObject sender)
		{
			Unused.Value = Call("copyRuler:", sender);
		}

		public void cut(NSObject sender)
		{
			Unused.Value = Call("cut:", sender);
		}

		public void delete(NSObject sender)
		{
			Unused.Value = Call("delete:", sender);
		}

		public void paste(NSObject sender)
		{
			Unused.Value = Call("paste:", sender);
		}

		public void pasteFont(NSObject sender)
		{
			Unused.Value = Call("pasteFont:", sender);
		}

		public void pasteRuler(NSObject sender)
		{
			Unused.Value = Call("pasteRuler:", sender);
		}

		public void selectAll(NSObject sender)
		{
			Unused.Value = Call("selectAll:", sender);
		}

		public void changeFont(NSObject sender)
		{
			Unused.Value = Call("changeFont:", sender);
		}

		public void alignLeft(NSObject sender)
		{
			Unused.Value = Call("alignLeft:", sender);
		}

		public void alignRight(NSObject sender)
		{
			Unused.Value = Call("alignRight:", sender);
		}

		public void alignCenter(NSObject sender)
		{
			Unused.Value = Call("alignCenter:", sender);
		}

		public void subscript(NSObject sender)
		{
			Unused.Value = Call("subscript:", sender);
		}

		public void superscript(NSObject sender)
		{
			Unused.Value = Call("superscript:", sender);
		}

		public void underline(NSObject sender)
		{
			Unused.Value = Call("underline:", sender);
		}

		public void unscript(NSObject sender)
		{
			Unused.Value = Call("unscript:", sender);
		}

		public void showGuessPanel(NSObject sender)
		{
			Unused.Value = Call("showGuessPanel:", sender);
		}

		public void checkSpelling(NSObject sender)
		{
			Unused.Value = Call("checkSpelling:", sender);
		}

		public void toggleRuler(NSObject sender)
		{
			Unused.Value = Call("toggleRuler:", sender);
		}

		#region NSChangeSpelling Methods
		public void changeSpelling(NSObject sender)
		{
			Unused.Value = Call("changeSpelling:", sender);
		}
		#endregion

		#region NSIgnoreMisspelledWords Methods
		public void ignoreSpelling(NSObject sender)
		{
			Unused.Value = Call("ignoreSpelling:", sender);
		}
		#endregion

		private static Class ms_class = new Class("NSText");
	}

	public static class NSTextDelegateForNSObjectCategory
	{
		public static bool textShouldBeginEditing(this NSObject _instance, NSText textObject)
		{
			return _instance.Call("textShouldBeginEditing:", textObject).To<bool>();
		}

		public static bool textShouldEndEditing(this NSObject _instance, NSText textObject)
		{
			return _instance.Call("textShouldEndEditing:", textObject).To<bool>();
		}

		public static void textDidBeginEditing(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("textDidBeginEditing:", notification);
		}

		public static void textDidEndEditing(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("textDidEndEditing:", notification);
		}

		public static void textDidChange(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("textDidChange:", notification);
		}
	}
}
