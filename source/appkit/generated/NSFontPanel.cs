// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSFontPanel.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSFPPreviewButton = 131;
		public const int NSFPRevertButton = 130;
		public const int NSFPSetButton = 132;
		public const int NSFPPreviewField = 128;
		public const int NSFPSizeField = 129;
		public const int NSFPSizeTitle = 133;
		public const int NSFPCurrentField = 134;
	}

	public partial class Enums
	{
		public const int NSFontPanelFaceModeMask = 1 << 0;
		public const int NSFontPanelSizeModeMask = 1 << 1;
		public const int NSFontPanelCollectionModeMask = 1 << 2;
		public const int NSFontPanelUnderlineEffectModeMask = 1 << 8;
		public const int NSFontPanelStrikethroughEffectModeMask = 1 << 9;
		public const int NSFontPanelTextColorEffectModeMask = 1 << 10;
		public const int NSFontPanelDocumentColorEffectModeMask = 1 << 11;
		public const int NSFontPanelShadowEffectModeMask = 1 << 12;
		public const int NSFontPanelAllEffectsModeMask = 0XFFF00;
		public const int NSFontPanelStandardModesMask = 0xFFFF;
		public const uint NSFontPanelAllModesMask = 0xFFFFFFFF;
	}

	public static class NSFontPanelValidationAdditionsForNSObjectCategory
	{
		public static UInt32 validModesForFontPanel(this NSObject _instance, NSFontPanel fontPanel)
		{
			return _instance.Call("validModesForFontPanel:", fontPanel).To<UInt32>();
		}
	}

	[Register]
	public partial class NSFontPanel : NSPanel
	{
		public NSFontPanel() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSFontPanel(IntPtr instance) : base(instance)
		{
		}

		public NSFontPanel(Untyped instance) : base(instance)
		{
		}

		public static new NSFontPanel alloc()
		{
			return new NSFontPanel(ms_class.Call("alloc"));
		}

		public new NSFontPanel retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSFontPanel sharedFontPanel()
		{
			return ms_class.Call("sharedFontPanel").To<NSFontPanel>();
		}

		public static bool sharedFontPanelExists()
		{
			return ms_class.Call("sharedFontPanelExists").To<bool>();
		}

		public NSView accessoryView()
		{
			return Call("accessoryView").To<NSView>();
		}

		public void setAccessoryView(NSView aView)
		{
			Unused.Value = Call("setAccessoryView:", aView);
		}

		public void setPanelFontIsMultiple(NSFont fontObj, bool flag)
		{
			Unused.Value = Call("setPanelFont:isMultiple:", fontObj, flag);
		}

		public NSFont panelConvertFont(NSFont fontObj)
		{
			return Call("panelConvertFont:", fontObj).To<NSFont>();
		}

		// skipping worksWhenModal (it's declared in a base class)

		public bool isEnabled()
		{
			return Call("isEnabled").To<bool>();
		}

		public void setEnabled(bool flag)
		{
			Unused.Value = Call("setEnabled:", flag);
		}

		public void reloadDefaultFontFamilies()
		{
			Unused.Value = Call("reloadDefaultFontFamilies");
		}

		private static Class ms_class = new Class("NSFontPanel");
	}
}
