// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSMovieView.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSQTMovieNormalPlayback = 0;
		public const int NSQTMovieLoopingPlayback = 1;
		public const int NSQTMovieLoopingBackAndForthPlayback = 2;
	}

	[Register]
	public partial class NSMovieView : NSView
	{
		public NSMovieView() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMovieView(IntPtr instance) : base(instance)
		{
		}

		public NSMovieView(Untyped instance) : base(instance)
		{
		}

		public static new NSMovieView alloc()
		{
			return new NSMovieView(ms_class.Call("alloc"));
		}

		public new NSMovieView retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setMovie(NSMovie movie)
		{
			Unused.Value = Call("setMovie:", movie);
		}

		public NSMovie movie()
		{
			return Call("movie").To<NSMovie>();
		}

		public IntPtr movieController()
		{
			return Call("movieController").To<IntPtr>();
		}

		public NSRect movieRect()
		{
			return Call("movieRect").To<NSRect>();
		}

		public void start(NSObject sender)
		{
			Unused.Value = Call("start:", sender);
		}

		public void stop(NSObject sender)
		{
			Unused.Value = Call("stop:", sender);
		}

		public bool isPlaying()
		{
			return Call("isPlaying").To<bool>();
		}

		public void gotoPosterFrame(NSObject sender)
		{
			Unused.Value = Call("gotoPosterFrame:", sender);
		}

		public void gotoBeginning(NSObject sender)
		{
			Unused.Value = Call("gotoBeginning:", sender);
		}

		public void gotoEnd(NSObject sender)
		{
			Unused.Value = Call("gotoEnd:", sender);
		}

		public void stepForward(NSObject sender)
		{
			Unused.Value = Call("stepForward:", sender);
		}

		public void stepBack(NSObject sender)
		{
			Unused.Value = Call("stepBack:", sender);
		}

		public void setRate(float rate)
		{
			Unused.Value = Call("setRate:", rate);
		}

		public float rate()
		{
			return Call("rate").To<float>();
		}

		public void setVolume(float volume)
		{
			Unused.Value = Call("setVolume:", volume);
		}

		public float volume()
		{
			return Call("volume").To<float>();
		}

		public void setMuted(bool mute)
		{
			Unused.Value = Call("setMuted:", mute);
		}

		public bool isMuted()
		{
			return Call("isMuted").To<bool>();
		}

		public void setLoopMode(UInt32 mode)
		{
			Unused.Value = Call("setLoopMode:", mode);
		}

		public UInt32 loopMode()
		{
			return Call("loopMode").To<UInt32>();
		}

		public void setPlaysSelectionOnly(bool flag)
		{
			Unused.Value = Call("setPlaysSelectionOnly:", flag);
		}

		public bool playsSelectionOnly()
		{
			return Call("playsSelectionOnly").To<bool>();
		}

		public void setPlaysEveryFrame(bool flag)
		{
			Unused.Value = Call("setPlaysEveryFrame:", flag);
		}

		public bool playsEveryFrame()
		{
			return Call("playsEveryFrame").To<bool>();
		}

		public void showControllerAdjustingSize(bool show, bool adjustSize)
		{
			Unused.Value = Call("showController:adjustingSize:", show, adjustSize);
		}

		public bool isControllerVisible()
		{
			return Call("isControllerVisible").To<bool>();
		}

		public void resizeWithMagnification(float magnification)
		{
			Unused.Value = Call("resizeWithMagnification:", magnification);
		}

		public NSSize sizeForMagnification(float magnification)
		{
			return Call("sizeForMagnification:", magnification).To<NSSize>();
		}

		public void setEditable(bool editable)
		{
			Unused.Value = Call("setEditable:", editable);
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public void cut(NSObject sender)
		{
			Unused.Value = Call("cut:", sender);
		}

		public void copy(NSObject sender)
		{
			Unused.Value = Call("copy:", sender);
		}

		public void paste(NSObject sender)
		{
			Unused.Value = Call("paste:", sender);
		}

		public void delete(NSObject sender)
		{
			Unused.Value = Call("delete:", sender);
		}

		public void selectAll(NSObject sender)
		{
			Unused.Value = Call("selectAll:", sender);
		}

		public void clear(NSObject sender)
		{
			Unused.Value = Call("clear:", sender);
		}

		#region NSUserInterfaceValidations Methods
		public bool validateUserInterfaceItem(NSObject anItem)
		{
			return Call("validateUserInterfaceItem:", anItem).To<bool>();
		}
		#endregion

		private static Class ms_class = new Class("NSMovieView");
	}
}
