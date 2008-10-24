// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSPredicateEditorRowTemplate.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSPredicateEditorRowTemplate : NSObject
	{
		public NSPredicateEditorRowTemplate() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPredicateEditorRowTemplate(IntPtr instance) : base(instance)
		{
		}

		public NSPredicateEditorRowTemplate(Untyped instance) : base(instance)
		{
		}

		public static new NSPredicateEditorRowTemplate alloc()
		{
			return new NSPredicateEditorRowTemplate(ms_class.Call("alloc"));
		}

		public new NSPredicateEditorRowTemplate retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public double matchForPredicate(NSPredicate predicate)
		{
			return Call("matchForPredicate:", predicate).To<double>();
		}

		public NSArray templateViews()
		{
			return Call("templateViews").To<NSArray>();
		}

		public void setPredicate(NSPredicate predicate)
		{
			Unused.Value = Call("setPredicate:", predicate);
		}

		public NSPredicate predicateWithSubpredicates(NSArray subpredicates)
		{
			return Call("predicateWithSubpredicates:", subpredicates).To<NSPredicate>();
		}

		public NSArray displayableSubpredicatesOfPredicate(NSPredicate predicate)
		{
			return Call("displayableSubpredicatesOfPredicate:", predicate).To<NSArray>();
		}

		public NSObject initWithLeftExpressionsRightExpressionsModifierOperatorsOptions(NSArray leftExpressions, NSArray rightExpressions, UInt32 modifier, NSArray operators, UInt32 options)
		{
			return Call("initWithLeftExpressions:rightExpressions:modifier:operators:options:", leftExpressions, rightExpressions, modifier, operators, options).To<NSObject>();
		}

		public NSObject initWithLeftExpressionsRightExpressionAttributeTypeModifierOperatorsOptions(NSArray leftExpressions, UInt32 attributeType, UInt32 modifier, NSArray operators, UInt32 options)
		{
			return Call("initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:", leftExpressions, attributeType, modifier, operators, options).To<NSObject>();
		}

		public NSObject initWithCompoundTypes(NSArray compoundTypes)
		{
			return Call("initWithCompoundTypes:", compoundTypes).To<NSObject>();
		}

		public NSArray leftExpressions()
		{
			return Call("leftExpressions").To<NSArray>();
		}

		public NSArray rightExpressions()
		{
			return Call("rightExpressions").To<NSArray>();
		}

		public UInt32 rightExpressionAttributeType()
		{
			return Call("rightExpressionAttributeType").To<UInt32>();
		}

		public UInt32 modifier()
		{
			return Call("modifier").To<UInt32>();
		}

		public NSArray operators()
		{
			return Call("operators").To<NSArray>();
		}

		public UInt32 options()
		{
			return Call("options").To<UInt32>();
		}

		public NSArray compoundTypes()
		{
			return Call("compoundTypes").To<NSArray>();
		}

		public static NSArray templatesWithAttributeKeyPathsInEntityDescription(NSArray keyPaths, NSObject entityDescription)
		{
			return ms_class.Call("templatesWithAttributeKeyPaths:inEntityDescription:", keyPaths, entityDescription).To<NSArray>();
		}

		#region NSCoding Methods
		public void encodeWithCoder(NSCoder aCoder)
		{
			Unused.Value = Call("encodeWithCoder:", aCoder);
		}

		public NSObject initWithCoder(NSCoder aDecoder)
		{
			return Call("initWithCoder:", aDecoder).To<NSObject>();
		}
		#endregion

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSPredicateEditorRowTemplate");
	}
}
