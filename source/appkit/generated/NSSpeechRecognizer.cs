// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSpeechRecognizer.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSpeechRecognizer : NSObject
	{
		public NSSpeechRecognizer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSpeechRecognizer(IntPtr instance) : base(instance)
		{
		}

		public NSSpeechRecognizer(Untyped instance) : base(instance)
		{
		}

		public static new NSSpeechRecognizer alloc()
		{
			return new NSSpeechRecognizer(ms_class.Call("alloc"));
		}

		public new NSSpeechRecognizer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public void startListening()
		{
			Unused.Value = Call("startListening");
		}

		public void stopListening()
		{
			Unused.Value = Call("stopListening");
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSArray commands()
		{
			return Call("commands").To<NSArray>();
		}

		public void setCommands(NSArray commands)
		{
			Unused.Value = Call("setCommands:", commands);
		}

		public NSString displayedCommandsTitle()
		{
			return Call("displayedCommandsTitle").To<NSString>();
		}

		public void setDisplayedCommandsTitle(NSString title)
		{
			Unused.Value = Call("setDisplayedCommandsTitle:", title);
		}

		public bool listensInForegroundOnly()
		{
			return Call("listensInForegroundOnly").To<bool>();
		}

		public void setListensInForegroundOnly(bool flag)
		{
			Unused.Value = Call("setListensInForegroundOnly:", flag);
		}

		public bool blocksOtherRecognizers()
		{
			return Call("blocksOtherRecognizers").To<bool>();
		}

		public void setBlocksOtherRecognizers(bool flag)
		{
			Unused.Value = Call("setBlocksOtherRecognizers:", flag);
		}

		private static Class ms_class = new Class("NSSpeechRecognizer");
	}

	public static class NSSpeechRecognizerDelegateForNSObjectCategory
	{
		public static void speechRecognizerDidRecognizeCommand(this NSObject _instance, NSSpeechRecognizer sender, NSObject command)
		{
			Unused.Value = _instance.Call("speechRecognizer:didRecognizeCommand:", sender, command);
		}
	}
}
