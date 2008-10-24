// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSpeechSynthesizer.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSSpeechImmediateBoundary = 0;
		public const int NSSpeechWordBoundary = 1;
		public const int NSSpeechSentenceBoundary = 2;
	}

	[Register]
	public partial class NSSpeechSynthesizer : NSObject
	{
		public NSSpeechSynthesizer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSpeechSynthesizer(IntPtr instance) : base(instance)
		{
		}

		public NSSpeechSynthesizer(Untyped instance) : base(instance)
		{
		}

		public static new NSSpeechSynthesizer alloc()
		{
			return new NSSpeechSynthesizer(ms_class.Call("alloc"));
		}

		public new NSSpeechSynthesizer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithVoice(NSString voice)
		{
			return Call("initWithVoice:", voice).To<NSObject>();
		}

		public bool startSpeakingString(NSString string_)
		{
			return Call("startSpeakingString:", string_).To<bool>();
		}

		public bool startSpeakingStringToURL(NSString string_, NSURL url)
		{
			return Call("startSpeakingString:toURL:", string_, url).To<bool>();
		}

		public bool isSpeaking()
		{
			return Call("isSpeaking").To<bool>();
		}

		public void stopSpeaking()
		{
			Unused.Value = Call("stopSpeaking");
		}

		public void stopSpeakingAtBoundary(UInt32 boundary)
		{
			Unused.Value = Call("stopSpeakingAtBoundary:", boundary);
		}

		public void pauseSpeakingAtBoundary(UInt32 boundary)
		{
			Unused.Value = Call("pauseSpeakingAtBoundary:", boundary);
		}

		public void continueSpeaking()
		{
			Unused.Value = Call("continueSpeaking");
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSString voice()
		{
			return Call("voice").To<NSString>();
		}

		public bool setVoice(NSString voice)
		{
			return Call("setVoice:", voice).To<bool>();
		}

		public float rate()
		{
			return Call("rate").To<float>();
		}

		public void setRate(float rate)
		{
			Unused.Value = Call("setRate:", rate);
		}

		public float volume()
		{
			return Call("volume").To<float>();
		}

		public void setVolume(float volume)
		{
			Unused.Value = Call("setVolume:", volume);
		}

		public bool usesFeedbackWindow()
		{
			return Call("usesFeedbackWindow").To<bool>();
		}

		public void setUsesFeedbackWindow(bool flag)
		{
			Unused.Value = Call("setUsesFeedbackWindow:", flag);
		}

		public void addSpeechDictionary(NSDictionary speechDictionary)
		{
			Unused.Value = Call("addSpeechDictionary:", speechDictionary);
		}

		public NSString phonemesFromText(NSString text)
		{
			return Call("phonemesFromText:", text).To<NSString>();
		}

		public NSObject objectForPropertyError(NSString property, IntPtr outError)
		{
			return Call("objectForProperty:error:", property, outError).To<NSObject>();
		}

		public bool setObjectForPropertyError(NSObject object_, NSString property, IntPtr outError)
		{
			return Call("setObject:forProperty:error:", object_, property, outError).To<bool>();
		}

		public static bool isAnyApplicationSpeaking()
		{
			return ms_class.Call("isAnyApplicationSpeaking").To<bool>();
		}

		public static NSString defaultVoice()
		{
			return ms_class.Call("defaultVoice").To<NSString>();
		}

		public static NSArray availableVoices()
		{
			return ms_class.Call("availableVoices").To<NSArray>();
		}

		public static NSDictionary attributesForVoice(NSString voice)
		{
			return ms_class.Call("attributesForVoice:", voice).To<NSDictionary>();
		}

		private static Class ms_class = new Class("NSSpeechSynthesizer");
	}

	public static class NSSpeechSynthesizerDelegateForNSObjectCategory
	{
		public static void speechSynthesizerDidFinishSpeaking(this NSObject _instance, NSSpeechSynthesizer sender, bool finishedSpeaking)
		{
			Unused.Value = _instance.Call("speechSynthesizer:didFinishSpeaking:", sender, finishedSpeaking);
		}

		public static void speechSynthesizerWillSpeakWordOfString(this NSObject _instance, NSSpeechSynthesizer sender, NSRange characterRange, NSString string_)
		{
			Unused.Value = _instance.Call("speechSynthesizer:willSpeakWord:ofString:", sender, characterRange, string_);
		}

		public static void speechSynthesizerWillSpeakPhoneme(this NSObject _instance, NSSpeechSynthesizer sender, UInt32 phonemeOpcode)
		{
			Unused.Value = _instance.Call("speechSynthesizer:willSpeakPhoneme:", sender, phonemeOpcode);
		}

		public static void speechSynthesizerDidEncounterErrorAtIndexOfStringMessage(this NSObject _instance, NSSpeechSynthesizer sender, UInt32 characterIndex, NSString string_, NSString message)
		{
			Unused.Value = _instance.Call("speechSynthesizer:didEncounterErrorAtIndex:ofString:message:", sender, characterIndex, string_, message);
		}

		public static void speechSynthesizerDidEncounterSyncMessage(this NSObject _instance, NSSpeechSynthesizer sender, NSString message)
		{
			Unused.Value = _instance.Call("speechSynthesizer:didEncounterSyncMessage:", sender, message);
		}
	}
}
