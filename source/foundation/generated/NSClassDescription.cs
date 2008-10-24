// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSClassDescription.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSClassDescription : NSObject
	{
		public NSClassDescription() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSClassDescription(IntPtr instance) : base(instance)
		{
		}

		public NSClassDescription(Untyped instance) : base(instance)
		{
		}

		public static new NSClassDescription alloc()
		{
			return new NSClassDescription(ms_class.Call("alloc"));
		}

		public new NSClassDescription retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void registerClassDescriptionForClass(NSClassDescription description, Class aClass)
		{
			Unused.Value = ms_class.Call("registerClassDescription:forClass:", description, aClass);
		}

		public static void invalidateClassDescriptionCache()
		{
			Unused.Value = ms_class.Call("invalidateClassDescriptionCache");
		}

		public static NSClassDescription classDescriptionForClass(Class aClass)
		{
			return ms_class.Call("classDescriptionForClass:", aClass).To<NSClassDescription>();
		}

		public NSArray attributeKeys()
		{
			return Call("attributeKeys").To<NSArray>();
		}

		public NSArray toOneRelationshipKeys()
		{
			return Call("toOneRelationshipKeys").To<NSArray>();
		}

		public NSArray toManyRelationshipKeys()
		{
			return Call("toManyRelationshipKeys").To<NSArray>();
		}

		public NSString inverseForRelationshipKey(NSString relationshipKey)
		{
			return Call("inverseForRelationshipKey:", relationshipKey).To<NSString>();
		}

		private static Class ms_class = new Class("NSClassDescription");
	}

	public static class NSClassDescriptionPrimitivesForNSObjectCategory
	{
		public static NSClassDescription classDescription(this NSObject _instance)
		{
			return _instance.Call("classDescription").To<NSClassDescription>();
		}

		public static NSArray attributeKeys(this NSObject _instance)
		{
			return _instance.Call("attributeKeys").To<NSArray>();
		}

		public static NSArray toOneRelationshipKeys(this NSObject _instance)
		{
			return _instance.Call("toOneRelationshipKeys").To<NSArray>();
		}

		public static NSArray toManyRelationshipKeys(this NSObject _instance)
		{
			return _instance.Call("toManyRelationshipKeys").To<NSArray>();
		}

		public static NSString inverseForRelationshipKey(this NSObject _instance, NSString relationshipKey)
		{
			return _instance.Call("inverseForRelationshipKey:", relationshipKey).To<NSString>();
		}
	}
}
