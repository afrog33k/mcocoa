// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextAttachment.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSAttachmentCharacter = 0xfffc;
	}

	[Register]
	public partial class NSTextAttachmentCell : NSCell
	{
		public NSTextAttachmentCell() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextAttachmentCell(IntPtr instance) : base(instance)
		{
		}

		public NSTextAttachmentCell(Untyped instance) : base(instance)
		{
		}

		public static new NSTextAttachmentCell alloc()
		{
			return new NSTextAttachmentCell(ms_class.Call("alloc"));
		}

		public new NSTextAttachmentCell retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		#region NSTextAttachmentCell Methods
		// skipping drawWithFrame:inView: (it's declared in a base class)

		public bool wantsToTrackMouse()
		{
			return Call("wantsToTrackMouse").To<bool>();
		}

		// skipping highlight:withFrame:inView: (it's declared in a base class)

		// skipping trackMouse:inRect:ofView:untilMouseUp: (it's declared in a base class)

		// skipping cellSize (it's declared in a base class)

		public NSPoint cellBaselineOffset()
		{
			return Call("cellBaselineOffset").To<NSPoint>();
		}

		public void setAttachment(NSTextAttachment anObject)
		{
			Unused.Value = Call("setAttachment:", anObject);
		}

		public NSTextAttachment attachment()
		{
			return Call("attachment").To<NSTextAttachment>();
		}

		public void drawWithFrameInViewCharacterIndex(NSRect cellFrame, NSView controlView, UInt32 charIndex)
		{
			Unused.Value = Call("drawWithFrame:inView:characterIndex:", cellFrame, controlView, charIndex);
		}

		public void drawWithFrameInViewCharacterIndexLayoutManager(NSRect cellFrame, NSView controlView, UInt32 charIndex, NSLayoutManager layoutManager)
		{
			Unused.Value = Call("drawWithFrame:inView:characterIndex:layoutManager:", cellFrame, controlView, charIndex, layoutManager);
		}

		public bool wantsToTrackMouseForEventInRectOfViewAtCharacterIndex(NSEvent theEvent, NSRect cellFrame, NSView controlView, UInt32 charIndex)
		{
			return Call("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:", theEvent, cellFrame, controlView, charIndex).To<bool>();
		}

		public bool trackMouseInRectOfViewAtCharacterIndexUntilMouseUp(NSEvent theEvent, NSRect cellFrame, NSView controlView, UInt32 charIndex, bool flag)
		{
			return Call("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:", theEvent, cellFrame, controlView, charIndex, flag).To<bool>();
		}

		public NSRect cellFrameForTextContainerProposedLineFragmentGlyphPositionCharacterIndex(NSTextContainer textContainer, NSRect lineFrag, NSPoint position, UInt32 charIndex)
		{
			return Call("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:", textContainer, lineFrag, position, charIndex).To<NSRect>();
		}
		#endregion

		private static Class ms_class = new Class("NSTextAttachmentCell");
	}

	[Register]
	public partial class NSTextAttachment : NSObject
	{
		public NSTextAttachment() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTextAttachment(IntPtr instance) : base(instance)
		{
		}

		public NSTextAttachment(Untyped instance) : base(instance)
		{
		}

		public static new NSTextAttachment alloc()
		{
			return new NSTextAttachment(ms_class.Call("alloc"));
		}

		public new NSTextAttachment retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithFileWrapper(NSFileWrapper fileWrapper)
		{
			return Call("initWithFileWrapper:", fileWrapper).To<NSObject>();
		}

		public void setFileWrapper(NSFileWrapper fileWrapper)
		{
			Unused.Value = Call("setFileWrapper:", fileWrapper);
		}

		public NSFileWrapper fileWrapper()
		{
			return Call("fileWrapper").To<NSFileWrapper>();
		}

		public NSObject attachmentCell()
		{
			return Call("attachmentCell").To<NSObject>();
		}

		public void setAttachmentCell(NSObject cell)
		{
			Unused.Value = Call("setAttachmentCell:", cell);
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

		private static Class ms_class = new Class("NSTextAttachment");
	}

	public static class NSAttributedStringAttachmentConveniencesForNSAttributedStringCategory
	{
		public static NSAttributedString attributedStringWithAttachment(this NSAttributedString _instance, NSTextAttachment attachment)
		{
			return _instance.Call("attributedStringWithAttachment:", attachment).To<NSAttributedString>();
		}
	}

	public static class NSMutableAttributedStringAttachmentConveniencesForNSMutableAttributedStringCategory
	{
		public static void updateAttachmentsFromPath(this NSMutableAttributedString _instance, NSString path)
		{
			Unused.Value = _instance.Call("updateAttachmentsFromPath:", path);
		}
	}
}
