// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTokenFieldCell.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSDefaultTokenStyle = 0;
		public const int NSPlainTextTokenStyle = 1;
		public const int NSRoundedTokenStyle = 2;
	}

	[Register]
	public partial class NSTokenFieldCell : NSTextFieldCell
	{
		public NSTokenFieldCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTokenFieldCell(IntPtr instance) : base(instance)
		{
		}

		public NSTokenFieldCell(Untyped instance) : base(instance)
		{
		}

		public static new NSTokenFieldCell alloc()
		{
			return new NSTokenFieldCell(ms_class.Call("alloc"));
		}

		public new NSTokenFieldCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setTokenStyle(UInt32 style)
		{
			Unused.Value = Call("setTokenStyle:", style);
		}

		public UInt32 tokenStyle()
		{
			return Call("tokenStyle").To<UInt32>();
		}

		public void setCompletionDelay(double delay)
		{
			Unused.Value = Call("setCompletionDelay:", delay);
		}

		public double completionDelay()
		{
			return Call("completionDelay").To<double>();
		}

		public static double defaultCompletionDelay()
		{
			return ms_class.Call("defaultCompletionDelay").To<double>();
		}

		public void setTokenizingCharacterSet(NSCharacterSet characterSet)
		{
			Unused.Value = Call("setTokenizingCharacterSet:", characterSet);
		}

		public NSCharacterSet tokenizingCharacterSet()
		{
			return Call("tokenizingCharacterSet").To<NSCharacterSet>();
		}

		public static NSCharacterSet defaultTokenizingCharacterSet()
		{
			return ms_class.Call("defaultTokenizingCharacterSet").To<NSCharacterSet>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		private static Class ms_class = new Class("NSTokenFieldCell");
	}

	public static class NSTokenFieldCellDelegateForNSObjectCategory
	{
		public static NSArray tokenFieldCellCompletionsForSubstringIndexOfTokenIndexOfSelectedItem(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSString substring, Int32 tokenIndex, IntPtr selectedIndex)
		{
			return _instance.Call("tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:", tokenFieldCell, substring, tokenIndex, selectedIndex).To<NSArray>();
		}

		public static NSArray tokenFieldCellShouldAddObjectsAtIndex(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSArray tokens, UInt32 index)
		{
			return _instance.Call("tokenFieldCell:shouldAddObjects:atIndex:", tokenFieldCell, tokens, index).To<NSArray>();
		}

		public static NSString tokenFieldCellDisplayStringForRepresentedObject(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _instance.Call("tokenFieldCell:displayStringForRepresentedObject:", tokenFieldCell, representedObject).To<NSString>();
		}

		public static NSString tokenFieldCellEditingStringForRepresentedObject(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _instance.Call("tokenFieldCell:editingStringForRepresentedObject:", tokenFieldCell, representedObject).To<NSString>();
		}

		public static NSObject tokenFieldCellRepresentedObjectForEditingString(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSString editingString)
		{
			return _instance.Call("tokenFieldCell:representedObjectForEditingString:", tokenFieldCell, editingString).To<NSObject>();
		}

		public static bool tokenFieldCellWriteRepresentedObjectsToPasteboard(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSArray objects, NSPasteboard pboard)
		{
			return _instance.Call("tokenFieldCell:writeRepresentedObjects:toPasteboard:", tokenFieldCell, objects, pboard).To<bool>();
		}

		public static NSArray tokenFieldCellReadFromPasteboard(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSPasteboard pboard)
		{
			return _instance.Call("tokenFieldCell:readFromPasteboard:", tokenFieldCell, pboard).To<NSArray>();
		}

		public static NSMenu tokenFieldCellMenuForRepresentedObject(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _instance.Call("tokenFieldCell:menuForRepresentedObject:", tokenFieldCell, representedObject).To<NSMenu>();
		}

		public static bool tokenFieldCellHasMenuForRepresentedObject(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _instance.Call("tokenFieldCell:hasMenuForRepresentedObject:", tokenFieldCell, representedObject).To<bool>();
		}

		public static UInt32 tokenFieldCellStyleForRepresentedObject(this NSObject _instance, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _instance.Call("tokenFieldCell:styleForRepresentedObject:", tokenFieldCell, representedObject).To<UInt32>();
		}
	}
}
