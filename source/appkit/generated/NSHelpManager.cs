// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSHelpManager.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSHelpManager : NSObject
	{
		public NSHelpManager() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSHelpManager(IntPtr instance) : base(instance)
		{
		}

		public NSHelpManager(Untyped instance) : base(instance)
		{
		}

		public static new NSHelpManager alloc()
		{
			return new NSHelpManager(ms_class.Call("alloc"));
		}

		public new NSHelpManager retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSHelpManager sharedHelpManager()
		{
			return ms_class.Call("sharedHelpManager").To<NSHelpManager>();
		}

		public static void setContextHelpModeActive(bool active)
		{
			Unused.Value = ms_class.Call("setContextHelpModeActive:", active);
		}

		public static bool isContextHelpModeActive()
		{
			return ms_class.Call("isContextHelpModeActive").To<bool>();
		}

		public void setContextHelpForObject(NSAttributedString attrString, NSObject object_)
		{
			Unused.Value = Call("setContextHelp:forObject:", attrString, object_);
		}

		public void removeContextHelpForObject(NSObject object_)
		{
			Unused.Value = Call("removeContextHelpForObject:", object_);
		}

		public NSAttributedString contextHelpForObject(NSObject object_)
		{
			return Call("contextHelpForObject:", object_).To<NSAttributedString>();
		}

		public bool showContextHelpForObjectLocationHint(NSObject object_, NSPoint pt)
		{
			return Call("showContextHelpForObject:locationHint:", object_, pt).To<bool>();
		}

		public void openHelpAnchorInBook(NSString anchor, NSString book)
		{
			Unused.Value = Call("openHelpAnchor:inBook:", anchor, book);
		}

		public void findStringInBook(NSString query, NSString book)
		{
			Unused.Value = Call("findString:inBook:", query, book);
		}

		private static Class ms_class = new Class("NSHelpManager");
	}

	public static class NSBundleHelpExtensionForNSBundleCategory
	{
		public static NSAttributedString contextHelpForKey(this NSBundle _instance, NSString key)
		{
			return _instance.Call("contextHelpForKey:", key).To<NSAttributedString>();
		}
	}

	public static class NSApplicationHelpExtensionForNSApplicationCategory
	{
		public static void activateContextHelpMode(this NSApplication _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("activateContextHelpMode:", sender);
		}

		public static void showHelp(this NSApplication _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("showHelp:", sender);
		}
	}
}
