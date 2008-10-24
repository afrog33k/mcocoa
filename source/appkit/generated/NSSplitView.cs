// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSplitView.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSSplitViewDividerStyleThick = 1;
		public const int NSSplitViewDividerStyleThin = 2;
	}

	[Register]
	public partial class NSSplitView : NSView
	{
		public NSSplitView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSplitView(IntPtr instance) : base(instance)
		{
		}

		public NSSplitView(Untyped instance) : base(instance)
		{
		}

		public static new NSSplitView alloc()
		{
			return new NSSplitView(ms_class.Call("alloc"));
		}

		public new NSSplitView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setVertical(bool flag)
		{
			Unused.Value = Call("setVertical:", flag);
		}

		public bool isVertical()
		{
			return Call("isVertical").To<bool>();
		}

		public void setDividerStyle(Int32 dividerStyle)
		{
			Unused.Value = Call("setDividerStyle:", dividerStyle);
		}

		public Int32 dividerStyle()
		{
			return Call("dividerStyle").To<Int32>();
		}

		public void setAutosaveName(NSString autosaveName)
		{
			Unused.Value = Call("setAutosaveName:", autosaveName);
		}

		public NSString autosaveName()
		{
			return Call("autosaveName").To<NSString>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void drawDividerInRect(NSRect rect)
		{
			Unused.Value = Call("drawDividerInRect:", rect);
		}

		public NSColor dividerColor()
		{
			return Call("dividerColor").To<NSColor>();
		}

		public float dividerThickness()
		{
			return Call("dividerThickness").To<float>();
		}

		public void adjustSubviews()
		{
			Unused.Value = Call("adjustSubviews");
		}

		public bool isSubviewCollapsed(NSView subview)
		{
			return Call("isSubviewCollapsed:", subview).To<bool>();
		}

		public float minPossiblePositionOfDividerAtIndex(Int32 dividerIndex)
		{
			return Call("minPossiblePositionOfDividerAtIndex:", dividerIndex).To<float>();
		}

		public float maxPossiblePositionOfDividerAtIndex(Int32 dividerIndex)
		{
			return Call("maxPossiblePositionOfDividerAtIndex:", dividerIndex).To<float>();
		}

		public void setPositionOfDividerAtIndex(float position, Int32 dividerIndex)
		{
			Unused.Value = Call("setPosition:ofDividerAtIndex:", position, dividerIndex);
		}

		public void setIsPaneSplitter(bool flag)
		{
			Unused.Value = Call("setIsPaneSplitter:", flag);
		}

		public bool isPaneSplitter()
		{
			return Call("isPaneSplitter").To<bool>();
		}

		private static Class ms_class = new Class("NSSplitView");
	}

	public static class NSSplitViewDelegateForNSObjectCategory
	{
		public static bool splitViewCanCollapseSubview(this NSObject _instance, NSSplitView splitView, NSView subview)
		{
			return _instance.Call("splitView:canCollapseSubview:", splitView, subview).To<bool>();
		}

		public static bool splitViewShouldCollapseSubviewForDoubleClickOnDividerAtIndex(this NSObject _instance, NSSplitView splitView, NSView subview, Int32 dividerIndex)
		{
			return _instance.Call("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:", splitView, subview, dividerIndex).To<bool>();
		}

		public static float splitViewConstrainMinCoordinateOfSubviewAt(this NSObject _instance, NSSplitView splitView, float proposedMinimumPosition, Int32 dividerIndex)
		{
			return _instance.Call("splitView:constrainMinCoordinate:ofSubviewAt:", splitView, proposedMinimumPosition, dividerIndex).To<float>();
		}

		public static float splitViewConstrainMaxCoordinateOfSubviewAt(this NSObject _instance, NSSplitView splitView, float proposedMaximumPosition, Int32 dividerIndex)
		{
			return _instance.Call("splitView:constrainMaxCoordinate:ofSubviewAt:", splitView, proposedMaximumPosition, dividerIndex).To<float>();
		}

		public static float splitViewConstrainSplitPositionOfSubviewAt(this NSObject _instance, NSSplitView splitView, float proposedPosition, Int32 dividerIndex)
		{
			return _instance.Call("splitView:constrainSplitPosition:ofSubviewAt:", splitView, proposedPosition, dividerIndex).To<float>();
		}

		public static void splitViewResizeSubviewsWithOldSize(this NSObject _instance, NSSplitView splitView, NSSize oldSize)
		{
			Unused.Value = _instance.Call("splitView:resizeSubviewsWithOldSize:", splitView, oldSize);
		}

		public static bool splitViewShouldHideDividerAtIndex(this NSObject _instance, NSSplitView splitView, Int32 dividerIndex)
		{
			return _instance.Call("splitView:shouldHideDividerAtIndex:", splitView, dividerIndex).To<bool>();
		}

		public static NSRect splitViewEffectiveRectForDrawnRectOfDividerAtIndex(this NSObject _instance, NSSplitView splitView, NSRect proposedEffectiveRect, NSRect drawnRect, Int32 dividerIndex)
		{
			return _instance.Call("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:", splitView, proposedEffectiveRect, drawnRect, dividerIndex).To<NSRect>();
		}

		public static NSRect splitViewAdditionalEffectiveRectOfDividerAtIndex(this NSObject _instance, NSSplitView splitView, Int32 dividerIndex)
		{
			return _instance.Call("splitView:additionalEffectiveRectOfDividerAtIndex:", splitView, dividerIndex).To<NSRect>();
		}

		public static void splitViewWillResizeSubviews(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("splitViewWillResizeSubviews:", notification);
		}

		public static void splitViewDidResizeSubviews(this NSObject _instance, NSNotification notification)
		{
			Unused.Value = _instance.Call("splitViewDidResizeSubviews:", notification);
		}
	}
}
