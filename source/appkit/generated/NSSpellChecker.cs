// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSSpellChecker.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSSpellChecker : NSObject
	{
		public NSSpellChecker() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSpellChecker(IntPtr instance) : base(instance)
		{
		}

		public NSSpellChecker(Untyped instance) : base(instance)
		{
		}

		public static new NSSpellChecker alloc()
		{
			return new NSSpellChecker(ms_class.Call("alloc"));
		}

		public new NSSpellChecker retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSSpellChecker sharedSpellChecker()
		{
			return ms_class.Call("sharedSpellChecker").To<NSSpellChecker>();
		}

		public static bool sharedSpellCheckerExists()
		{
			return ms_class.Call("sharedSpellCheckerExists").To<bool>();
		}

		public static Int32 uniqueSpellDocumentTag()
		{
			return ms_class.Call("uniqueSpellDocumentTag").To<Int32>();
		}

		public NSRange checkSpellingOfStringStartingAtLanguageWrapInSpellDocumentWithTagWordCount(NSString stringToCheck, Int32 startingOffset, NSString language, bool wrapFlag, Int32 tag, IntPtr wordCount)
		{
			return Call("checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:", stringToCheck, startingOffset, language, wrapFlag, tag, wordCount).To<NSRange>();
		}

		public NSRange checkSpellingOfStringStartingAt(NSString stringToCheck, Int32 startingOffset)
		{
			return Call("checkSpellingOfString:startingAt:", stringToCheck, startingOffset).To<NSRange>();
		}

		public Int32 countWordsInStringLanguage(NSString stringToCount, NSString language)
		{
			return Call("countWordsInString:language:", stringToCount, language).To<Int32>();
		}

		public NSRange checkGrammarOfStringStartingAtLanguageWrapInSpellDocumentWithTagDetails(NSString stringToCheck, Int32 startingOffset, NSString language, bool wrapFlag, Int32 tag, IntPtr details)
		{
			return Call("checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:", stringToCheck, startingOffset, language, wrapFlag, tag, details).To<NSRange>();
		}

		public void updateSpellingPanelWithMisspelledWord(NSString word)
		{
			Unused.Value = Call("updateSpellingPanelWithMisspelledWord:", word);
		}

		public void updateSpellingPanelWithGrammarStringDetail(NSString string_, NSDictionary detail)
		{
			Unused.Value = Call("updateSpellingPanelWithGrammarString:detail:", string_, detail);
		}

		public NSPanel spellingPanel()
		{
			return Call("spellingPanel").To<NSPanel>();
		}

		public NSView accessoryView()
		{
			return Call("accessoryView").To<NSView>();
		}

		public void setAccessoryView(NSView aView)
		{
			Unused.Value = Call("setAccessoryView:", aView);
		}

		public void ignoreWordInSpellDocumentWithTag(NSString wordToIgnore, Int32 tag)
		{
			Unused.Value = Call("ignoreWord:inSpellDocumentWithTag:", wordToIgnore, tag);
		}

		public NSArray ignoredWordsInSpellDocumentWithTag(Int32 tag)
		{
			return Call("ignoredWordsInSpellDocumentWithTag:", tag).To<NSArray>();
		}

		public void setIgnoredWordsInSpellDocumentWithTag(NSArray words, Int32 tag)
		{
			Unused.Value = Call("setIgnoredWords:inSpellDocumentWithTag:", words, tag);
		}

		public NSArray guessesForWord(NSString word)
		{
			return Call("guessesForWord:", word).To<NSArray>();
		}

		public NSArray completionsForPartialWordRangeInStringLanguageInSpellDocumentWithTag(NSRange range, NSString string_, NSString language, Int32 tag)
		{
			return Call("completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:", range, string_, language, tag).To<NSArray>();
		}

		public void closeSpellDocumentWithTag(Int32 tag)
		{
			Unused.Value = Call("closeSpellDocumentWithTag:", tag);
		}

		public NSString language()
		{
			return Call("language").To<NSString>();
		}

		public bool setLanguage(NSString language)
		{
			return Call("setLanguage:", language).To<bool>();
		}

		public NSArray availableLanguages()
		{
			return Call("availableLanguages").To<NSArray>();
		}

		public void setWordFieldStringValue(NSString aString)
		{
			Unused.Value = Call("setWordFieldStringValue:", aString);
		}

		public void learnWord(NSString word)
		{
			Unused.Value = Call("learnWord:", word);
		}

		public bool hasLearnedWord(NSString word)
		{
			return Call("hasLearnedWord:", word).To<bool>();
		}

		public void unlearnWord(NSString word)
		{
			Unused.Value = Call("unlearnWord:", word);
		}

		private static Class ms_class = new Class("NSSpellChecker");
	}

	public static class NSDeprecatedForNSSpellCheckerCategory
	{
		public static void forgetWord(this NSSpellChecker _instance, NSString word)
		{
			Unused.Value = _instance.Call("forgetWord:", word);
		}
	}
}
