// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSInterfaceStyle.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNoInterfaceStyle = 0;
		public const int NSNextStepInterfaceStyle = 1;
		public const int NSWindows95InterfaceStyle = 2;
		public const int NSMacintoshInterfaceStyle = 3;
	}

	public static class NSInterfaceStyleForNSResponderCategory
	{
		public static UInt32 interfaceStyle(this NSResponder _instance)
		{
			return _instance.Call("interfaceStyle").To<UInt32>();
		}

		public static void setInterfaceStyle(this NSResponder _instance, UInt32 interfaceStyle)
		{
			Unused.Value = _instance.Call("setInterfaceStyle:", interfaceStyle);
		}
	}
}
