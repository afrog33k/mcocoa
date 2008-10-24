// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSViewController.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSViewController : NSResponder
	{
		public NSViewController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSViewController(IntPtr instance) : base(instance)
		{
		}

		public NSViewController(Untyped instance) : base(instance)
		{
		}

		public static new NSViewController alloc()
		{
			return new NSViewController(ms_class.Call("alloc"));
		}

		public new NSViewController retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithNibNameBundle(NSString nibNameOrNil, NSBundle nibBundleOrNil)
		{
			return Call("initWithNibName:bundle:", nibNameOrNil, nibBundleOrNil).To<NSObject>();
		}

		public void setRepresentedObject(NSObject representedObject)
		{
			Unused.Value = Call("setRepresentedObject:", representedObject);
		}

		public NSObject representedObject()
		{
			return Call("representedObject").To<NSObject>();
		}

		public void setTitle(NSString title)
		{
			Unused.Value = Call("setTitle:", title);
		}

		public NSString title()
		{
			return Call("title").To<NSString>();
		}

		public NSView view()
		{
			return Call("view").To<NSView>();
		}

		public void loadView()
		{
			Unused.Value = Call("loadView");
		}

		public NSString nibName()
		{
			return Call("nibName").To<NSString>();
		}

		public NSBundle nibBundle()
		{
			return Call("nibBundle").To<NSBundle>();
		}

		public void setView(NSView view)
		{
			Unused.Value = Call("setView:", view);
		}

		public void commitEditingWithDelegateDidCommitSelectorContextInfo(NSObject delegate_, Selector didCommitSelector, IntPtr contextInfo)
		{
			Unused.Value = Call("commitEditingWithDelegate:didCommitSelector:contextInfo:", delegate_, didCommitSelector, contextInfo);
		}

		public bool commitEditing()
		{
			return Call("commitEditing").To<bool>();
		}

		public void discardEditing()
		{
			Unused.Value = Call("discardEditing");
		}

		private static Class ms_class = new Class("NSViewController");
	}
}
