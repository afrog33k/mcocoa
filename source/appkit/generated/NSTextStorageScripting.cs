// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTextStorageScripting.h

using MObjc;
using System;

namespace MCocoa
{
	public static class ScriptingForNSTextStorageCategory
	{
		public static NSArray attributeRuns(this NSTextStorage _instance)
		{
			return _instance.Call("attributeRuns").To<NSArray>();
		}

		public static void setAttributeRuns(this NSTextStorage _instance, NSArray attributeRuns)
		{
			Unused.Value = _instance.Call("setAttributeRuns:", attributeRuns);
		}

		public static NSArray paragraphs(this NSTextStorage _instance)
		{
			return _instance.Call("paragraphs").To<NSArray>();
		}

		public static void setParagraphs(this NSTextStorage _instance, NSArray paragraphs)
		{
			Unused.Value = _instance.Call("setParagraphs:", paragraphs);
		}

		public static NSArray words(this NSTextStorage _instance)
		{
			return _instance.Call("words").To<NSArray>();
		}

		public static void setWords(this NSTextStorage _instance, NSArray words)
		{
			Unused.Value = _instance.Call("setWords:", words);
		}

		public static NSArray characters(this NSTextStorage _instance)
		{
			return _instance.Call("characters").To<NSArray>();
		}

		public static void setCharacters(this NSTextStorage _instance, NSArray characters)
		{
			Unused.Value = _instance.Call("setCharacters:", characters);
		}

		public static NSFont font(this NSTextStorage _instance)
		{
			return _instance.Call("font").To<NSFont>();
		}

		public static void setFont(this NSTextStorage _instance, NSFont font)
		{
			Unused.Value = _instance.Call("setFont:", font);
		}

		public static NSColor foregroundColor(this NSTextStorage _instance)
		{
			return _instance.Call("foregroundColor").To<NSColor>();
		}

		public static void setForegroundColor(this NSTextStorage _instance, NSColor color)
		{
			Unused.Value = _instance.Call("setForegroundColor:", color);
		}
	}
}
