// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDocumentScripting.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSScriptingForNSDocumentCategory
	{
		public static NSString lastComponentOfFileName(this NSDocument _instance)
		{
			return _instance.Call("lastComponentOfFileName").To<NSString>();
		}

		public static void setLastComponentOfFileName(this NSDocument _instance, NSString str)
		{
			Unused.Value = _instance.Call("setLastComponentOfFileName:", str);
		}

		public static NSObject handleSaveScriptCommand(this NSDocument _instance, NSScriptCommand command)
		{
			return _instance.Call("handleSaveScriptCommand:", command).To<NSObject>();
		}

		public static NSObject handleCloseScriptCommand(this NSDocument _instance, NSCloseCommand command)
		{
			return _instance.Call("handleCloseScriptCommand:", command).To<NSObject>();
		}

		public static NSObject handlePrintScriptCommand(this NSDocument _instance, NSScriptCommand command)
		{
			return _instance.Call("handlePrintScriptCommand:", command).To<NSObject>();
		}

		public static NSScriptObjectSpecifier objectSpecifier(this NSDocument _instance)
		{
			return _instance.Call("objectSpecifier").To<NSScriptObjectSpecifier>();
		}
	}
}
