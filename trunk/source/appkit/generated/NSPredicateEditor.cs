// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPredicateEditor.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPredicateEditor : NSRuleEditor
	{
		public NSPredicateEditor() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPredicateEditor(IntPtr instance) : base(instance)
		{
		}

		public NSPredicateEditor(Untyped instance) : base(instance)
		{
		}

		public static new NSPredicateEditor alloc()
		{
			return new NSPredicateEditor(ms_class.Call("alloc"));
		}

		public new NSPredicateEditor retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setRowTemplates(NSArray rowTemplates)
		{
			Unused.Value = Call("setRowTemplates:", rowTemplates);
		}

		public NSArray rowTemplates()
		{
			return Call("rowTemplates").To<NSArray>();
		}

		private static Class ms_class = new Class("NSPredicateEditor");
	}
}
