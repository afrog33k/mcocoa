// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSound.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSound : NSObject
	{
		public NSSound() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSound(IntPtr instance) : base(instance)
		{
		}

		public NSSound(Untyped instance) : base(instance)
		{
		}

		public static new NSSound alloc()
		{
			return new NSSound(ms_class.Call("alloc"));
		}

		public new NSSound retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject soundNamed(NSString name)
		{
			return ms_class.Call("soundNamed:", name).To<NSObject>();
		}

		public NSObject initWithContentsOfURLByReference(NSURL url, bool byRef)
		{
			return Call("initWithContentsOfURL:byReference:", url, byRef).To<NSObject>();
		}

		public NSObject initWithContentsOfFileByReference(NSString path, bool byRef)
		{
			return Call("initWithContentsOfFile:byReference:", path, byRef).To<NSObject>();
		}

		public NSObject initWithData(NSData data)
		{
			return Call("initWithData:", data).To<NSObject>();
		}

		public bool setName(NSString string_)
		{
			return Call("setName:", string_).To<bool>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public static bool canInitWithPasteboard(NSPasteboard pasteboard)
		{
			return ms_class.Call("canInitWithPasteboard:", pasteboard).To<bool>();
		}

		public static NSArray soundUnfilteredTypes()
		{
			return ms_class.Call("soundUnfilteredTypes").To<NSArray>();
		}

		public NSObject initWithPasteboard(NSPasteboard pasteboard)
		{
			return Call("initWithPasteboard:", pasteboard).To<NSObject>();
		}

		public void writeToPasteboard(NSPasteboard pasteboard)
		{
			Unused.Value = Call("writeToPasteboard:", pasteboard);
		}

		public bool play()
		{
			return Call("play").To<bool>();
		}

		public bool pause()
		{
			return Call("pause").To<bool>();
		}

		public bool resume()
		{
			return Call("resume").To<bool>();
		}

		public bool stop()
		{
			return Call("stop").To<bool>();
		}

		public bool isPlaying()
		{
			return Call("isPlaying").To<bool>();
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject aDelegate)
		{
			Unused.Value = Call("setDelegate:", aDelegate);
		}

		public double duration()
		{
			return Call("duration").To<double>();
		}

		public void setVolume(float volume)
		{
			Unused.Value = Call("setVolume:", volume);
		}

		public float volume()
		{
			return Call("volume").To<float>();
		}

		public double currentTime()
		{
			return Call("currentTime").To<double>();
		}

		public void setCurrentTime(double seconds)
		{
			Unused.Value = Call("setCurrentTime:", seconds);
		}

		public void setLoops(bool val)
		{
			Unused.Value = Call("setLoops:", val);
		}

		public bool loops()
		{
			return Call("loops").To<bool>();
		}

		public void setPlaybackDeviceIdentifier(NSString deviceUID)
		{
			Unused.Value = Call("setPlaybackDeviceIdentifier:", deviceUID);
		}

		public NSString playbackDeviceIdentifier()
		{
			return Call("playbackDeviceIdentifier").To<NSString>();
		}

		public void setChannelMapping(NSArray channelMapping)
		{
			Unused.Value = Call("setChannelMapping:", channelMapping);
		}

		public NSArray channelMapping()
		{
			return Call("channelMapping").To<NSArray>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSSound");
	}

	public static class NSDeprecatedForNSSoundCategory
	{
		public static NSArray soundUnfilteredFileTypes(this NSSound _instance)
		{
			return _instance.Call("soundUnfilteredFileTypes").To<NSArray>();
		}

		public static NSArray soundUnfilteredPasteboardTypes(this NSSound _instance)
		{
			return _instance.Call("soundUnfilteredPasteboardTypes").To<NSArray>();
		}
	}

	public static class NSSoundDelegateMethodsForNSObjectCategory
	{
		public static void soundDidFinishPlaying(this NSObject _instance, NSSound sound, bool aBool)
		{
			Unused.Value = _instance.Call("sound:didFinishPlaying:", sound, aBool);
		}
	}

	public static class NSBundleSoundExtensionsForNSBundleCategory
	{
		public static NSString pathForSoundResource(this NSBundle _instance, NSString name)
		{
			return _instance.Call("pathForSoundResource:", name).To<NSString>();
		}
	}
}
