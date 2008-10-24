// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextContainer.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSLineSweepLeft = 0;
		public const int NSLineSweepRight = 1;
		public const int NSLineSweepDown = 2;
		public const int NSLineSweepUp = 3;
	}

	public partial class Enums
	{
		public const int NSLineDoesntMove = 0;
		public const int NSLineMovesLeft = 1;
		public const int NSLineMovesRight = 2;
		public const int NSLineMovesDown = 3;
		public const int NSLineMovesUp = 4;
	}

	[Register]
	public partial class NSTextContainer : NSObject
	{
		public NSTextContainer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextContainer(IntPtr instance) : base(instance)
		{
		}

		public NSTextContainer(Untyped instance) : base(instance)
		{
		}

		public static new NSTextContainer alloc()
		{
			return new NSTextContainer(ms_class.Call("alloc"));
		}

		public new NSTextContainer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContainerSize(NSSize size)
		{
			return Call("initWithContainerSize:", size).To<NSObject>();
		}

		public NSLayoutManager layoutManager()
		{
			return Call("layoutManager").To<NSLayoutManager>();
		}

		public void setLayoutManager(NSLayoutManager layoutManager)
		{
			Unused.Value = Call("setLayoutManager:", layoutManager);
		}

		public void replaceLayoutManager(NSLayoutManager newLayoutManager)
		{
			Unused.Value = Call("replaceLayoutManager:", newLayoutManager);
		}

		public NSTextView textView()
		{
			return Call("textView").To<NSTextView>();
		}

		public void setTextView(NSTextView textView)
		{
			Unused.Value = Call("setTextView:", textView);
		}

		public void setWidthTracksTextView(bool flag)
		{
			Unused.Value = Call("setWidthTracksTextView:", flag);
		}

		public bool widthTracksTextView()
		{
			return Call("widthTracksTextView").To<bool>();
		}

		public void setHeightTracksTextView(bool flag)
		{
			Unused.Value = Call("setHeightTracksTextView:", flag);
		}

		public bool heightTracksTextView()
		{
			return Call("heightTracksTextView").To<bool>();
		}

		public void setContainerSize(NSSize size)
		{
			Unused.Value = Call("setContainerSize:", size);
		}

		public NSSize containerSize()
		{
			return Call("containerSize").To<NSSize>();
		}

		public void setLineFragmentPadding(float pad)
		{
			Unused.Value = Call("setLineFragmentPadding:", pad);
		}

		public float lineFragmentPadding()
		{
			return Call("lineFragmentPadding").To<float>();
		}

		public NSRect lineFragmentRectForProposedRectSweepDirectionMovementDirectionRemainingRect(NSRect proposedRect, UInt32 sweepDirection, UInt32 movementDirection, IntPtr remainingRect)
		{
			return Call("lineFragmentRectForProposedRect:sweepDirection:movementDirection:remainingRect:", proposedRect, sweepDirection, movementDirection, remainingRect).To<NSRect>();
		}

		public bool isSimpleRectangularTextContainer()
		{
			return Call("isSimpleRectangularTextContainer").To<bool>();
		}

		public bool containsPoint(NSPoint point)
		{
			return Call("containsPoint:", point).To<bool>();
		}

		#region NSCoding Methods
		public void encodeWithCoder(NSCoder aCoder)
		{
			Unused.Value = Call("encodeWithCoder:", aCoder);
		}

		public NSObject initWithCoder(NSCoder aDecoder)
		{
			return Call("initWithCoder:", aDecoder).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSTextContainer");
	}
}
