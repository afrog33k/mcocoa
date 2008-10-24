// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSAccessibility.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSAccessibilityForNSObjectCategory
	{
		public static NSArray accessibilityAttributeNames(this NSObject _instance)
		{
			return _instance.Call("accessibilityAttributeNames").To<NSArray>();
		}

		public static NSObject accessibilityAttributeValue(this NSObject _instance, NSString attribute)
		{
			return _instance.Call("accessibilityAttributeValue:", attribute).To<NSObject>();
		}

		public static bool accessibilityIsAttributeSettable(this NSObject _instance, NSString attribute)
		{
			return _instance.Call("accessibilityIsAttributeSettable:", attribute).To<bool>();
		}

		public static void accessibilitySetValueForAttribute(this NSObject _instance, NSObject value, NSString attribute)
		{
			Unused.Value = _instance.Call("accessibilitySetValue:forAttribute:", value, attribute);
		}

		public static NSArray accessibilityParameterizedAttributeNames(this NSObject _instance)
		{
			return _instance.Call("accessibilityParameterizedAttributeNames").To<NSArray>();
		}

		public static NSObject accessibilityAttributeValueForParameter(this NSObject _instance, NSString attribute, NSObject parameter)
		{
			return _instance.Call("accessibilityAttributeValue:forParameter:", attribute, parameter).To<NSObject>();
		}

		public static NSArray accessibilityActionNames(this NSObject _instance)
		{
			return _instance.Call("accessibilityActionNames").To<NSArray>();
		}

		public static NSString accessibilityActionDescription(this NSObject _instance, NSString action)
		{
			return _instance.Call("accessibilityActionDescription:", action).To<NSString>();
		}

		public static void accessibilityPerformAction(this NSObject _instance, NSString action)
		{
			Unused.Value = _instance.Call("accessibilityPerformAction:", action);
		}

		public static bool accessibilityIsIgnored(this NSObject _instance)
		{
			return _instance.Call("accessibilityIsIgnored").To<bool>();
		}

		public static NSObject accessibilityHitTest(this NSObject _instance, NSPoint point)
		{
			return _instance.Call("accessibilityHitTest:", point).To<NSObject>();
		}

		public static NSObject accessibilityFocusedUIElement(this NSObject _instance)
		{
			return _instance.Call("accessibilityFocusedUIElement").To<NSObject>();
		}
	}

	public static class NSAccessibilityAdditionsForNSObjectCategory
	{
		public static bool accessibilitySetOverrideValueForAttribute(this NSObject _instance, NSObject value, NSString attribute)
		{
			return _instance.Call("accessibilitySetOverrideValue:forAttribute:", value, attribute).To<bool>();
		}
	}
}
