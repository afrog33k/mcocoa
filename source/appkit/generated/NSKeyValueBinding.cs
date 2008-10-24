// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSKeyValueBinding.h

using MObjc;
using System;

namespace MCocoa
{
	public static class NSKeyValueBindingCreationForNSObjectCategory
	{
		public static void exposeBinding(this NSObject _instance, NSString binding)
		{
			Unused.Value = _instance.Call("exposeBinding:", binding);
		}

		public static NSArray exposedBindings(this NSObject _instance)
		{
			return _instance.Call("exposedBindings").To<NSArray>();
		}

		public static Class valueClassForBinding(this NSObject _instance, NSString binding)
		{
			return _instance.Call("valueClassForBinding:", binding).To<Class>();
		}

		public static void bindToObjectWithKeyPathOptions(this NSObject _instance, NSString binding, NSObject observable, NSString keyPath, NSDictionary options)
		{
			Unused.Value = _instance.Call("bind:toObject:withKeyPath:options:", binding, observable, keyPath, options);
		}

		public static void unbind(this NSObject _instance, NSString binding)
		{
			Unused.Value = _instance.Call("unbind:", binding);
		}

		public static NSDictionary infoForBinding(this NSObject _instance, NSString binding)
		{
			return _instance.Call("infoForBinding:", binding).To<NSDictionary>();
		}

		public static NSArray optionDescriptionsForBinding(this NSObject _instance, NSString aBinding)
		{
			return _instance.Call("optionDescriptionsForBinding:", aBinding).To<NSArray>();
		}
	}

	public static class NSPlaceholdersForNSObjectCategory
	{
		public static void setDefaultPlaceholderForMarkerWithBinding(this NSObject _instance, NSObject placeholder, NSObject marker, NSString binding)
		{
			Unused.Value = _instance.Call("setDefaultPlaceholder:forMarker:withBinding:", placeholder, marker, binding);
		}

		public static NSObject defaultPlaceholderForMarkerWithBinding(this NSObject _instance, NSObject marker, NSString binding)
		{
			return _instance.Call("defaultPlaceholderForMarker:withBinding:", marker, binding).To<NSObject>();
		}
	}

	public static class NSEditorRegistrationForNSObjectCategory
	{
		public static void objectDidBeginEditing(this NSObject _instance, NSObject editor)
		{
			Unused.Value = _instance.Call("objectDidBeginEditing:", editor);
		}

		public static void objectDidEndEditing(this NSObject _instance, NSObject editor)
		{
			Unused.Value = _instance.Call("objectDidEndEditing:", editor);
		}
	}

	public static class NSEditorForNSObjectCategory
	{
		public static void discardEditing(this NSObject _instance)
		{
			Unused.Value = _instance.Call("discardEditing");
		}

		public static bool commitEditing(this NSObject _instance)
		{
			return _instance.Call("commitEditing").To<bool>();
		}

		public static void commitEditingWithDelegateDidCommitSelectorContextInfo(this NSObject _instance, NSObject delegate_, Selector didCommitSelector, IntPtr contextInfo)
		{
			Unused.Value = _instance.Call("commitEditingWithDelegate:didCommitSelector:contextInfo:", delegate_, didCommitSelector, contextInfo);
		}
	}
}
