// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSFontManager.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSItalicFontMask = 0x00000001;
		public const int NSBoldFontMask = 0x00000002;
		public const int NSUnboldFontMask = 0x00000004;
		public const int NSNonStandardCharacterSetFontMask = 0x00000008;
		public const int NSNarrowFontMask = 0x00000010;
		public const int NSExpandedFontMask = 0x00000020;
		public const int NSCondensedFontMask = 0x00000040;
		public const int NSSmallCapsFontMask = 0x00000080;
		public const int NSPosterFontMask = 0x00000100;
		public const int NSCompressedFontMask = 0x00000200;
		public const int NSFixedPitchFontMask = 0x00000400;
		public const int NSUnitalicFontMask = 0x01000000;
	}

	public partial class Enums
	{
		public const int NSFontCollectionApplicationOnlyMask = 1 << 0;
	}

	public partial class Enums
	{
		public const int NSNoFontChangeAction = 0;
		public const int NSViaPanelFontAction = 1;
		public const int NSAddTraitFontAction = 2;
		public const int NSSizeUpFontAction = 3;
		public const int NSSizeDownFontAction = 4;
		public const int NSHeavierFontAction = 5;
		public const int NSLighterFontAction = 6;
		public const int NSRemoveTraitFontAction = 7;
	}

	[Register]
	public partial class NSFontManager : NSObject
	{
		public NSFontManager() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFontManager(IntPtr instance) : base(instance)
		{
		}

		public NSFontManager(Untyped instance) : base(instance)
		{
		}

		public static new NSFontManager alloc()
		{
			return new NSFontManager(ms_class.Call("alloc"));
		}

		public new NSFontManager retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void setFontPanelFactory(Class factoryId)
		{
			Unused.Value = ms_class.Call("setFontPanelFactory:", factoryId);
		}

		public static void setFontManagerFactory(Class factoryId)
		{
			Unused.Value = ms_class.Call("setFontManagerFactory:", factoryId);
		}

		public static NSFontManager sharedFontManager()
		{
			return ms_class.Call("sharedFontManager").To<NSFontManager>();
		}

		public bool isMultiple()
		{
			return Call("isMultiple").To<bool>();
		}

		public NSFont selectedFont()
		{
			return Call("selectedFont").To<NSFont>();
		}

		public void setSelectedFontIsMultiple(NSFont fontObj, bool flag)
		{
			Unused.Value = Call("setSelectedFont:isMultiple:", fontObj, flag);
		}

		public void setFontMenu(NSMenu newMenu)
		{
			Unused.Value = Call("setFontMenu:", newMenu);
		}

		public NSMenu fontMenu(bool create)
		{
			return Call("fontMenu:", create).To<NSMenu>();
		}

		public NSFontPanel fontPanel(bool create)
		{
			return Call("fontPanel:", create).To<NSFontPanel>();
		}

		public NSFont fontWithFamilyTraitsWeightSize(NSString family, UInt32 traits, Int32 weight, float size)
		{
			return Call("fontWithFamily:traits:weight:size:", family, traits, weight, size).To<NSFont>();
		}

		public UInt32 traitsOfFont(NSFont fontObj)
		{
			return Call("traitsOfFont:", fontObj).To<UInt32>();
		}

		public Int32 weightOfFont(NSFont fontObj)
		{
			return Call("weightOfFont:", fontObj).To<Int32>();
		}

		public NSArray availableFonts()
		{
			return Call("availableFonts").To<NSArray>();
		}

		public NSArray availableFontFamilies()
		{
			return Call("availableFontFamilies").To<NSArray>();
		}

		public NSArray availableMembersOfFontFamily(NSString fam)
		{
			return Call("availableMembersOfFontFamily:", fam).To<NSArray>();
		}

		public NSFont convertFont(NSFont fontObj)
		{
			return Call("convertFont:", fontObj).To<NSFont>();
		}

		public NSFont convertFontToSize(NSFont fontObj, float size)
		{
			return Call("convertFont:toSize:", fontObj, size).To<NSFont>();
		}

		public NSFont convertFontToFace(NSFont fontObj, NSString typeface)
		{
			return Call("convertFont:toFace:", fontObj, typeface).To<NSFont>();
		}

		public NSFont convertFontToFamily(NSFont fontObj, NSString family)
		{
			return Call("convertFont:toFamily:", fontObj, family).To<NSFont>();
		}

		public NSFont convertFontToHaveTrait(NSFont fontObj, UInt32 trait)
		{
			return Call("convertFont:toHaveTrait:", fontObj, trait).To<NSFont>();
		}

		public NSFont convertFontToNotHaveTrait(NSFont fontObj, UInt32 trait)
		{
			return Call("convertFont:toNotHaveTrait:", fontObj, trait).To<NSFont>();
		}

		public NSFont convertWeightOfFont(bool upFlag, NSFont fontObj)
		{
			return Call("convertWeight:ofFont:", upFlag, fontObj).To<NSFont>();
		}

		public bool isEnabled()
		{
			return Call("isEnabled").To<bool>();
		}

		public void setEnabled(bool flag)
		{
			Unused.Value = Call("setEnabled:", flag);
		}

		public Selector action()
		{
			return Call("action").To<Selector>();
		}

		public void setAction(Selector aSelector)
		{
			Unused.Value = Call("setAction:", aSelector);
		}

		public bool sendAction()
		{
			return Call("sendAction").To<bool>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public NSString localizedNameForFamilyFace(NSString family, NSString faceKey)
		{
			return Call("localizedNameForFamily:face:", family, faceKey).To<NSString>();
		}

		public void setSelectedAttributesIsMultiple(NSDictionary attributes, bool flag)
		{
			Unused.Value = Call("setSelectedAttributes:isMultiple:", attributes, flag);
		}

		public NSDictionary convertAttributes(NSDictionary attributes)
		{
			return Call("convertAttributes:", attributes).To<NSDictionary>();
		}

		public NSArray availableFontNamesMatchingFontDescriptor(NSFontDescriptor descriptor)
		{
			return Call("availableFontNamesMatchingFontDescriptor:", descriptor).To<NSArray>();
		}

		public NSArray collectionNames()
		{
			return Call("collectionNames").To<NSArray>();
		}

		public NSArray fontDescriptorsInCollection(NSString collectionNames)
		{
			return Call("fontDescriptorsInCollection:", collectionNames).To<NSArray>();
		}

		public bool addCollectionOptions(NSString collectionName, Int32 collectionOptions)
		{
			return Call("addCollection:options:", collectionName, collectionOptions).To<bool>();
		}

		public bool removeCollection(NSString collectionName)
		{
			return Call("removeCollection:", collectionName).To<bool>();
		}

		public void addFontDescriptorsToCollection(NSArray descriptors, NSString collectionName)
		{
			Unused.Value = Call("addFontDescriptors:toCollection:", descriptors, collectionName);
		}

		public void removeFontDescriptorFromCollection(NSFontDescriptor descriptor, NSString collection)
		{
			Unused.Value = Call("removeFontDescriptor:fromCollection:", descriptor, collection);
		}

		public UInt32 currentFontAction()
		{
			return Call("currentFontAction").To<UInt32>();
		}

		public UInt32 convertFontTraits(UInt32 traits)
		{
			return Call("convertFontTraits:", traits).To<UInt32>();
		}

		public void setTarget(NSObject aTarget)
		{
			Unused.Value = Call("setTarget:", aTarget);
		}

		public NSObject target()
		{
			return Call("target").To<NSObject>();
		}

		private static Class ms_class = new Class("NSFontManager");
	}

	public static class NSFontManagerMenuActionMethodsForNSFontManagerCategory
	{
		public static bool fontNamedHasTraits(this NSFontManager _instance, NSString fName, UInt32 someTraits)
		{
			return _instance.Call("fontNamed:hasTraits:", fName, someTraits).To<bool>();
		}

		public static NSArray availableFontNamesWithTraits(this NSFontManager _instance, UInt32 someTraits)
		{
			return _instance.Call("availableFontNamesWithTraits:", someTraits).To<NSArray>();
		}

		public static void addFontTrait(this NSFontManager _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("addFontTrait:", sender);
		}

		public static void removeFontTrait(this NSFontManager _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("removeFontTrait:", sender);
		}

		public static void modifyFontViaPanel(this NSFontManager _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("modifyFontViaPanel:", sender);
		}

		public static void modifyFont(this NSFontManager _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("modifyFont:", sender);
		}

		public static void orderFrontFontPanel(this NSFontManager _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("orderFrontFontPanel:", sender);
		}

		public static void orderFrontStylesPanel(this NSFontManager _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("orderFrontStylesPanel:", sender);
		}
	}

	public static class NSFontManagerDelegateForNSObjectCategory
	{
		public static bool fontManagerWillIncludeFont(this NSObject _instance, NSObject sender, NSString fontName)
		{
			return _instance.Call("fontManager:willIncludeFont:", sender, fontName).To<bool>();
		}
	}

	public static class NSFontManagerResponderMethodForNSObjectCategory
	{
		public static void changeFont(this NSObject _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("changeFont:", sender);
		}
	}
}
