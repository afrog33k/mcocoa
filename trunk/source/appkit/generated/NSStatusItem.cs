// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSStatusItem.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSStatusItem : NSObject
	{
		public NSStatusItem() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSStatusItem(IntPtr instance) : base(instance)
		{
		}

		public NSStatusItem(Untyped instance) : base(instance)
		{
		}

		public static new NSStatusItem alloc()
		{
			return new NSStatusItem(ms_class.Call("alloc"));
		}

		public new NSStatusItem retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSStatusBar statusBar()
		{
			return Call("statusBar").To<NSStatusBar>();
		}

		public float length()
		{
			return Call("length").To<float>();
		}

		public void setLength(float length)
		{
			Unused.Value = Call("setLength:", length);
		}

		private static Class ms_class = new Class("NSStatusItem");
	}

	public static class NSStatusItemCommonForNSStatusItemCategory
	{
		public static Selector action(this NSStatusItem _instance)
		{
			return _instance.Call("action").To<Selector>();
		}

		public static void setAction(this NSStatusItem _instance, Selector action)
		{
			Unused.Value = _instance.Call("setAction:", action);
		}

		public static Selector doubleAction(this NSStatusItem _instance)
		{
			return _instance.Call("doubleAction").To<Selector>();
		}

		public static void setDoubleAction(this NSStatusItem _instance, Selector action)
		{
			Unused.Value = _instance.Call("setDoubleAction:", action);
		}

		public static NSObject target(this NSStatusItem _instance)
		{
			return _instance.Call("target").To<NSObject>();
		}

		public static void setTarget(this NSStatusItem _instance, NSObject target)
		{
			Unused.Value = _instance.Call("setTarget:", target);
		}

		public static NSString title(this NSStatusItem _instance)
		{
			return _instance.Call("title").To<NSString>();
		}

		public static void setTitle(this NSStatusItem _instance, NSString title)
		{
			Unused.Value = _instance.Call("setTitle:", title);
		}

		public static NSAttributedString attributedTitle(this NSStatusItem _instance)
		{
			return _instance.Call("attributedTitle").To<NSAttributedString>();
		}

		public static void setAttributedTitle(this NSStatusItem _instance, NSAttributedString title)
		{
			Unused.Value = _instance.Call("setAttributedTitle:", title);
		}

		public static NSImage image(this NSStatusItem _instance)
		{
			return _instance.Call("image").To<NSImage>();
		}

		public static void setImage(this NSStatusItem _instance, NSImage image)
		{
			Unused.Value = _instance.Call("setImage:", image);
		}

		public static NSImage alternateImage(this NSStatusItem _instance)
		{
			return _instance.Call("alternateImage").To<NSImage>();
		}

		public static void setAlternateImage(this NSStatusItem _instance, NSImage image)
		{
			Unused.Value = _instance.Call("setAlternateImage:", image);
		}

		public static NSMenu menu(this NSStatusItem _instance)
		{
			return _instance.Call("menu").To<NSMenu>();
		}

		public static void setMenu(this NSStatusItem _instance, NSMenu menu)
		{
			Unused.Value = _instance.Call("setMenu:", menu);
		}

		public static bool isEnabled(this NSStatusItem _instance)
		{
			return _instance.Call("isEnabled").To<bool>();
		}

		public static void setEnabled(this NSStatusItem _instance, bool enabled)
		{
			Unused.Value = _instance.Call("setEnabled:", enabled);
		}

		public static NSString toolTip(this NSStatusItem _instance)
		{
			return _instance.Call("toolTip").To<NSString>();
		}

		public static void setToolTip(this NSStatusItem _instance, NSString toolTip)
		{
			Unused.Value = _instance.Call("setToolTip:", toolTip);
		}

		public static void setHighlightMode(this NSStatusItem _instance, bool highlightMode)
		{
			Unused.Value = _instance.Call("setHighlightMode:", highlightMode);
		}

		public static bool highlightMode(this NSStatusItem _instance)
		{
			return _instance.Call("highlightMode").To<bool>();
		}

		public static Int32 sendActionOn(this NSStatusItem _instance, Int32 mask)
		{
			return _instance.Call("sendActionOn:", mask).To<Int32>();
		}

		public static void popUpStatusItemMenu(this NSStatusItem _instance, NSMenu menu)
		{
			Unused.Value = _instance.Call("popUpStatusItemMenu:", menu);
		}

		public static void drawStatusBarBackgroundInRectWithHighlight(this NSStatusItem _instance, NSRect rect, bool highlight)
		{
			Unused.Value = _instance.Call("drawStatusBarBackgroundInRect:withHighlight:", rect, highlight);
		}
	}

	public static class NSStatusItemViewForNSStatusItemCategory
	{
		public static NSView view(this NSStatusItem _instance)
		{
			return _instance.Call("view").To<NSView>();
		}

		public static void setView(this NSStatusItem _instance, NSView view)
		{
			Unused.Value = _instance.Call("setView:", view);
		}
	}
}
