// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSValueTransformer.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSValueTransformer : NSObject
	{
		public NSValueTransformer() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSValueTransformer(IntPtr instance) : base(instance)
		{
		}

		public NSValueTransformer(Untyped instance) : base(instance)
		{
		}

		public static new NSValueTransformer alloc()
		{
			return new NSValueTransformer(ms_class.Call("alloc"));
		}

		public new NSValueTransformer retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static void setValueTransformerForName(NSValueTransformer transformer, NSString name)
		{
			Unused.Value = ms_class.Call("setValueTransformer:forName:", transformer, name);
		}

		public static NSValueTransformer valueTransformerForName(NSString name)
		{
			return ms_class.Call("valueTransformerForName:", name).To<NSValueTransformer>();
		}

		public static NSArray valueTransformerNames()
		{
			return ms_class.Call("valueTransformerNames").To<NSArray>();
		}

		public static Class transformedValueClass()
		{
			return ms_class.Call("transformedValueClass").To<Class>();
		}

		public static bool allowsReverseTransformation()
		{
			return ms_class.Call("allowsReverseTransformation").To<bool>();
		}

		public NSObject transformedValue(NSObject value)
		{
			return Call("transformedValue:", value).To<NSObject>();
		}

		public NSObject reverseTransformedValue(NSObject value)
		{
			return Call("reverseTransformedValue:", value).To<NSObject>();
		}

		private static Class ms_class = new Class("NSValueTransformer");
	}
}
