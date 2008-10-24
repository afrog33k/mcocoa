// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSControl.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSControl : NSView
	{
		public NSControl() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSControl(IntPtr instance) : base(instance)
		{
		}

		public NSControl(Untyped instance) : base(instance)
		{
		}

		public static new NSControl alloc()
		{
			return new NSControl(ms_class.Call("alloc"));
		}

		public new NSControl retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void setCellClass(Class factoryId)
		{
			Unused.Value = ms_class.Call("setCellClass:", factoryId);
		}

		public static Class cellClass()
		{
			return ms_class.Call("cellClass").To<Class>();
		}

		// skipping initWithFrame: (it's declared in a base class)

		public void sizeToFit()
		{
			Unused.Value = Call("sizeToFit");
		}

		public void calcSize()
		{
			Unused.Value = Call("calcSize");
		}

		public NSObject cell()
		{
			return Call("cell").To<NSObject>();
		}

		public void setCell(NSCell aCell)
		{
			Unused.Value = Call("setCell:", aCell);
		}

		public NSObject selectedCell()
		{
			return Call("selectedCell").To<NSObject>();
		}

		public NSObject target()
		{
			return Call("target").To<NSObject>();
		}

		public void setTarget(NSObject anObject)
		{
			Unused.Value = Call("setTarget:", anObject);
		}

		public Selector action()
		{
			return Call("action").To<Selector>();
		}

		public void setAction(Selector aSelector)
		{
			Unused.Value = Call("setAction:", aSelector);
		}

		// skipping tag (it's declared in a base class)

		public void setTag(Int32 anInt)
		{
			Unused.Value = Call("setTag:", anInt);
		}

		public Int32 selectedTag()
		{
			return Call("selectedTag").To<Int32>();
		}

		public void setIgnoresMultiClick(bool flag)
		{
			Unused.Value = Call("setIgnoresMultiClick:", flag);
		}

		public bool ignoresMultiClick()
		{
			return Call("ignoresMultiClick").To<bool>();
		}

		public Int32 sendActionOn(Int32 mask)
		{
			return Call("sendActionOn:", mask).To<Int32>();
		}

		public bool isContinuous()
		{
			return Call("isContinuous").To<bool>();
		}

		public void setContinuous(bool flag)
		{
			Unused.Value = Call("setContinuous:", flag);
		}

		public bool isEnabled()
		{
			return Call("isEnabled").To<bool>();
		}

		public void setEnabled(bool flag)
		{
			Unused.Value = Call("setEnabled:", flag);
		}

		public void setFloatingPointFormatLeftRight(bool autoRange, UInt32 leftDigits, UInt32 rightDigits)
		{
			Unused.Value = Call("setFloatingPointFormat:left:right:", autoRange, leftDigits, rightDigits);
		}

		public UInt32 alignment()
		{
			return Call("alignment").To<UInt32>();
		}

		public void setAlignment(UInt32 mode)
		{
			Unused.Value = Call("setAlignment:", mode);
		}

		public NSFont font()
		{
			return Call("font").To<NSFont>();
		}

		public void setFont(NSFont fontObj)
		{
			Unused.Value = Call("setFont:", fontObj);
		}

		public void setFormatter(NSFormatter newFormatter)
		{
			Unused.Value = Call("setFormatter:", newFormatter);
		}

		public NSObject formatter()
		{
			return Call("formatter").To<NSObject>();
		}

		public void setObjectValue(NSObject obj)
		{
			Unused.Value = Call("setObjectValue:", obj);
		}

		public void setStringValue(NSString aString)
		{
			Unused.Value = Call("setStringValue:", aString);
		}

		public void setIntValue(UInt32 anInt)
		{
			Unused.Value = Call("setIntValue:", anInt);
		}

		public void setFloatValue(float aFloat)
		{
			Unused.Value = Call("setFloatValue:", aFloat);
		}

		public void setDoubleValue(double aDouble)
		{
			Unused.Value = Call("setDoubleValue:", aDouble);
		}

		public NSObject objectValue()
		{
			return Call("objectValue").To<NSObject>();
		}

		public NSString stringValue()
		{
			return Call("stringValue").To<NSString>();
		}

		public UInt32 intValue()
		{
			return Call("intValue").To<UInt32>();
		}

		public float floatValue()
		{
			return Call("floatValue").To<float>();
		}

		public double doubleValue()
		{
			return Call("doubleValue").To<double>();
		}

		public void setNeedsDisplay()
		{
			Unused.Value = Call("setNeedsDisplay");
		}

		public void updateCell(NSCell aCell)
		{
			Unused.Value = Call("updateCell:", aCell);
		}

		public void updateCellInside(NSCell aCell)
		{
			Unused.Value = Call("updateCellInside:", aCell);
		}

		public void drawCellInside(NSCell aCell)
		{
			Unused.Value = Call("drawCellInside:", aCell);
		}

		public void drawCell(NSCell aCell)
		{
			Unused.Value = Call("drawCell:", aCell);
		}

		public void selectCell(NSCell aCell)
		{
			Unused.Value = Call("selectCell:", aCell);
		}

		public bool sendActionTo(Selector theAction, NSObject theTarget)
		{
			return Call("sendAction:to:", theAction, theTarget).To<bool>();
		}

		public void takeIntValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeIntValueFrom:", sender);
		}

		public void takeFloatValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeFloatValueFrom:", sender);
		}

		public void takeDoubleValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeDoubleValueFrom:", sender);
		}

		public void takeStringValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeStringValueFrom:", sender);
		}

		public void takeObjectValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeObjectValueFrom:", sender);
		}

		public NSText currentEditor()
		{
			return Call("currentEditor").To<NSText>();
		}

		public bool abortEditing()
		{
			return Call("abortEditing").To<bool>();
		}

		public void validateEditing()
		{
			Unused.Value = Call("validateEditing");
		}

		// skipping mouseDown: (it's declared in a base class)

		public Int32 baseWritingDirection()
		{
			return Call("baseWritingDirection").To<Int32>();
		}

		public void setBaseWritingDirection(Int32 writingDirection)
		{
			Unused.Value = Call("setBaseWritingDirection:", writingDirection);
		}

		public Int32 integerValue()
		{
			return Call("integerValue").To<Int32>();
		}

		public void setIntegerValue(Int32 anInteger)
		{
			Unused.Value = Call("setIntegerValue:", anInteger);
		}

		public void takeIntegerValueFrom(NSObject sender)
		{
			Unused.Value = Call("takeIntegerValueFrom:", sender);
		}

		private static Class ms_class = new Class("NSControl");
	}

	public static class NSKeyboardUIForNSControlCategory
	{
		public static void performClickSender(this NSControl _instance)
		{
			Unused.Value = _instance.Call("performClick:sender");
		}

		public static void setRefusesFirstResponder(this NSControl _instance, bool flag)
		{
			Unused.Value = _instance.Call("setRefusesFirstResponder:", flag);
		}

		public static bool refusesFirstResponder(this NSControl _instance)
		{
			return _instance.Call("refusesFirstResponder").To<bool>();
		}
	}

	public static class NSControlSubclassNotificationsForNSObjectCategory
	{
		public static void controlTextDidBeginEditing(this NSObject _instance, NSNotification obj)
		{
			Unused.Value = _instance.Call("controlTextDidBeginEditing:", obj);
		}

		public static void controlTextDidEndEditing(this NSObject _instance, NSNotification obj)
		{
			Unused.Value = _instance.Call("controlTextDidEndEditing:", obj);
		}

		public static void controlTextDidChange(this NSObject _instance, NSNotification obj)
		{
			Unused.Value = _instance.Call("controlTextDidChange:", obj);
		}
	}

	public static class NSControlSubclassDelegateForNSObjectCategory
	{
		public static bool controlTextShouldBeginEditing(this NSObject _instance, NSControl control, NSText fieldEditor)
		{
			return _instance.Call("control:textShouldBeginEditing:", control, fieldEditor).To<bool>();
		}

		public static bool controlTextShouldEndEditing(this NSObject _instance, NSControl control, NSText fieldEditor)
		{
			return _instance.Call("control:textShouldEndEditing:", control, fieldEditor).To<bool>();
		}

		public static bool controlDidFailToFormatStringErrorDescription(this NSObject _instance, NSControl control, NSString string_, NSString error)
		{
			return _instance.Call("control:didFailToFormatString:errorDescription:", control, string_, error).To<bool>();
		}

		public static void controlDidFailToValidatePartialStringErrorDescription(this NSObject _instance, NSControl control, NSString string_, NSString error)
		{
			Unused.Value = _instance.Call("control:didFailToValidatePartialString:errorDescription:", control, string_, error);
		}

		public static bool controlIsValidObject(this NSObject _instance, NSControl control, NSObject obj)
		{
			return _instance.Call("control:isValidObject:", control, obj).To<bool>();
		}

		public static bool controlTextViewDoCommandBySelector(this NSObject _instance, NSControl control, NSTextView textView, Selector commandSelector)
		{
			return _instance.Call("control:textView:doCommandBySelector:", control, textView, commandSelector).To<bool>();
		}

		public static NSArray controlTextViewCompletionsForPartialWordRangeIndexOfSelectedItem(this NSObject _instance, NSControl control, NSTextView textView, NSArray words, NSRange charRange, IntPtr index)
		{
			return _instance.Call("control:textView:completions:forPartialWordRange:indexOfSelectedItem:", control, textView, words, charRange, index).To<NSArray>();
		}
	}

	public static class NSControlAttributedStringMethodsForNSControlCategory
	{
		public static NSAttributedString attributedStringValue(this NSControl _instance)
		{
			return _instance.Call("attributedStringValue").To<NSAttributedString>();
		}

		public static void setAttributedStringValue(this NSControl _instance, NSAttributedString obj)
		{
			Unused.Value = _instance.Call("setAttributedStringValue:", obj);
		}
	}
}
