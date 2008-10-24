// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTokenField.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSTokenField : NSTextField
	{
		public NSTokenField() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTokenField(IntPtr instance) : base(instance)
		{
		}

		public NSTokenField(Untyped instance) : base(instance)
		{
		}

		public static new NSTokenField alloc()
		{
			return new NSTokenField(ms_class.Call("alloc"));
		}

		public new NSTokenField retain()
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

		private static Class ms_class = new Class("NSTokenField");
	}

	public static class NSTokenFieldDelegateForNSObjectCategory
	{
		public static NSArray tokenFieldCompletionsForSubstringIndexOfTokenIndexOfSelectedItem(this NSObject _instance, NSTokenField tokenField, NSString substring, Int32 tokenIndex, IntPtr selectedIndex)
		{
			return _instance.Call("tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:", tokenField, substring, tokenIndex, selectedIndex).To<NSArray>();
		}

		public static NSArray tokenFieldShouldAddObjectsAtIndex(this NSObject _instance, NSTokenField tokenField, NSArray tokens, UInt32 index)
		{
			return _instance.Call("tokenField:shouldAddObjects:atIndex:", tokenField, tokens, index).To<NSArray>();
		}

		public static NSString tokenFieldDisplayStringForRepresentedObject(this NSObject _instance, NSTokenField tokenField, NSObject representedObject)
		{
			return _instance.Call("tokenField:displayStringForRepresentedObject:", tokenField, representedObject).To<NSString>();
		}

		public static NSString tokenFieldEditingStringForRepresentedObject(this NSObject _instance, NSTokenField tokenField, NSObject representedObject)
		{
			return _instance.Call("tokenField:editingStringForRepresentedObject:", tokenField, representedObject).To<NSString>();
		}

		public static NSObject tokenFieldRepresentedObjectForEditingString(this NSObject _instance, NSTokenField tokenField, NSString editingString)
		{
			return _instance.Call("tokenField:representedObjectForEditingString:", tokenField, editingString).To<NSObject>();
		}

		public static bool tokenFieldWriteRepresentedObjectsToPasteboard(this NSObject _instance, NSTokenField tokenField, NSArray objects, NSPasteboard pboard)
		{
			return _instance.Call("tokenField:writeRepresentedObjects:toPasteboard:", tokenField, objects, pboard).To<bool>();
		}

		public static NSArray tokenFieldReadFromPasteboard(this NSObject _instance, NSTokenField tokenField, NSPasteboard pboard)
		{
			return _instance.Call("tokenField:readFromPasteboard:", tokenField, pboard).To<NSArray>();
		}

		public static NSMenu tokenFieldMenuForRepresentedObject(this NSObject _instance, NSTokenField tokenField, NSObject representedObject)
		{
			return _instance.Call("tokenField:menuForRepresentedObject:", tokenField, representedObject).To<NSMenu>();
		}

		public static bool tokenFieldHasMenuForRepresentedObject(this NSObject _instance, NSTokenField tokenField, NSObject representedObject)
		{
			return _instance.Call("tokenField:hasMenuForRepresentedObject:", tokenField, representedObject).To<bool>();
		}

		public static UInt32 tokenFieldStyleForRepresentedObject(this NSObject _instance, NSTokenField tokenField, NSObject representedObject)
		{
			return _instance.Call("tokenField:styleForRepresentedObject:", tokenField, representedObject).To<UInt32>();
		}
	}
}
