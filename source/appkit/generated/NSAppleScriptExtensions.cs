// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSAppleScriptExtensions.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSExtensionsForNSAppleScriptCategory
	{
		public static NSAttributedString richTextSource(this NSAppleScript _instance)
		{
			return _instance.Call("richTextSource").To<NSAttributedString>();
		}
	}
}
