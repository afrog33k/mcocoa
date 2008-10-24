// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSSpellServer.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSpellServer : NSObject
	{
		public NSSpellServer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSpellServer(IntPtr instance) : base(instance)
		{
		}

		public NSSpellServer(Untyped instance) : base(instance)
		{
		}

		public static new NSSpellServer alloc()
		{
			return new NSSpellServer(ms_class.Call("alloc"));
		}

		public new NSSpellServer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void setDelegate(NSObject anObject)
		{
			Unused.Value = Call("setDelegate:", anObject);
		}

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public bool registerLanguageByVendor(NSString language, NSString vendor)
		{
			return Call("registerLanguage:byVendor:", language, vendor).To<bool>();
		}

		public bool isWordInUserDictionariesCaseSensitive(NSString word, bool flag)
		{
			return Call("isWordInUserDictionaries:caseSensitive:", word, flag).To<bool>();
		}

		public void run()
		{
			Unused.Value = Call("run");
		}

		private static Class ms_class = new Class("NSSpellServer");
	}

	public static class NSSpellServerDelegateForNSObjectCategory
	{
		public static NSRange spellServerFindMisspelledWordInStringLanguageWordCountCountOnly(this NSObject _instance, NSSpellServer sender, NSString stringToCheck, NSString language, IntPtr wordCount, bool countOnly)
		{
			return _instance.Call("spellServer:findMisspelledWordInString:language:wordCount:countOnly:", sender, stringToCheck, language, wordCount, countOnly).To<NSRange>();
		}

		public static NSArray spellServerSuggestGuessesForWordInLanguage(this NSObject _instance, NSSpellServer sender, NSString word, NSString language)
		{
			return _instance.Call("spellServer:suggestGuessesForWord:inLanguage:", sender, word, language).To<NSArray>();
		}

		public static void spellServerDidLearnWordInLanguage(this NSObject _instance, NSSpellServer sender, NSString word, NSString language)
		{
			Unused.Value = _instance.Call("spellServer:didLearnWord:inLanguage:", sender, word, language);
		}

		public static void spellServerDidForgetWordInLanguage(this NSObject _instance, NSSpellServer sender, NSString word, NSString language)
		{
			Unused.Value = _instance.Call("spellServer:didForgetWord:inLanguage:", sender, word, language);
		}

		public static NSArray spellServerSuggestCompletionsForPartialWordRangeInStringLanguage(this NSObject _instance, NSSpellServer sender, NSRange range, NSString string_, NSString language)
		{
			return _instance.Call("spellServer:suggestCompletionsForPartialWordRange:inString:language:", sender, range, string_, language).To<NSArray>();
		}

		public static NSRange spellServerCheckGrammarInStringLanguageDetails(this NSObject _instance, NSSpellServer sender, NSString stringToCheck, NSString language, IntPtr details)
		{
			return _instance.Call("spellServer:checkGrammarInString:language:details:", sender, stringToCheck, language, details).To<NSRange>();
		}
	}
}
