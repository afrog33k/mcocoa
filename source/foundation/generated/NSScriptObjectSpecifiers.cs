// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptObjectSpecifiers.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNoSpecifierError = 0;
		public const int NSNoTopLevelContainersSpecifierError = 1;
		public const int NSContainerSpecifierError = 2;
		public const int NSUnknownKeySpecifierError = 3;
		public const int NSInvalidIndexSpecifierError = 4;
		public const int NSInternalSpecifierError = 5;
		public const int NSOperationNotSupportedForKeySpecifierError = 6;
	}

	public partial class Enums
	{
		public const int NSPositionAfter = 0;
		public const int NSPositionBefore = 1;
		public const int NSPositionBeginning = 2;
		public const int NSPositionEnd = 3;
		public const int NSPositionReplace = 4;
	}

	public partial class Enums
	{
		public const int NSRelativeAfter = 0;
		public const int NSRelativeBefore = 1;
	}

	public partial class Enums
	{
		public const int NSIndexSubelement = 0;
		public const int NSEverySubelement = 1;
		public const int NSMiddleSubelement = 2;
		public const int NSRandomSubelement = 3;
		public const int NSNoSubelement = 4;
	}

	[Register]
	public partial class NSScriptObjectSpecifier : NSObject
	{
		public NSScriptObjectSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScriptObjectSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSScriptObjectSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSScriptObjectSpecifier alloc()
		{
			return new NSScriptObjectSpecifier(ms_class.Call("alloc"));
		}

		public new NSScriptObjectSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSScriptObjectSpecifier objectSpecifierWithDescriptor(NSAppleEventDescriptor descriptor)
		{
			return ms_class.Call("objectSpecifierWithDescriptor:", descriptor).To<NSScriptObjectSpecifier>();
		}

		public NSObject initWithContainerSpecifierKey(NSScriptObjectSpecifier container, NSString property)
		{
			return Call("initWithContainerSpecifier:key:", container, property).To<NSObject>();
		}

		public NSObject initWithContainerClassDescriptionContainerSpecifierKey(NSScriptClassDescription classDesc, NSScriptObjectSpecifier container, NSString property)
		{
			return Call("initWithContainerClassDescription:containerSpecifier:key:", classDesc, container, property).To<NSObject>();
		}

		public NSScriptObjectSpecifier childSpecifier()
		{
			return Call("childSpecifier").To<NSScriptObjectSpecifier>();
		}

		public void setChildSpecifier(NSScriptObjectSpecifier child)
		{
			Unused.Value = Call("setChildSpecifier:", child);
		}

		public NSScriptObjectSpecifier containerSpecifier()
		{
			return Call("containerSpecifier").To<NSScriptObjectSpecifier>();
		}

		public void setContainerSpecifier(NSScriptObjectSpecifier subRef)
		{
			Unused.Value = Call("setContainerSpecifier:", subRef);
		}

		public bool containerIsObjectBeingTested()
		{
			return Call("containerIsObjectBeingTested").To<bool>();
		}

		public void setContainerIsObjectBeingTested(bool flag)
		{
			Unused.Value = Call("setContainerIsObjectBeingTested:", flag);
		}

		public bool containerIsRangeContainerObject()
		{
			return Call("containerIsRangeContainerObject").To<bool>();
		}

		public void setContainerIsRangeContainerObject(bool flag)
		{
			Unused.Value = Call("setContainerIsRangeContainerObject:", flag);
		}

		public NSString key()
		{
			return Call("key").To<NSString>();
		}

		public void setKey(NSString key)
		{
			Unused.Value = Call("setKey:", key);
		}

		public NSScriptClassDescription containerClassDescription()
		{
			return Call("containerClassDescription").To<NSScriptClassDescription>();
		}

		public void setContainerClassDescription(NSScriptClassDescription classDesc)
		{
			Unused.Value = Call("setContainerClassDescription:", classDesc);
		}

		public NSScriptClassDescription keyClassDescription()
		{
			return Call("keyClassDescription").To<NSScriptClassDescription>();
		}

		public IntPtr indicesOfObjectsByEvaluatingWithContainerCount(NSObject container, IntPtr count)
		{
			return Call("indicesOfObjectsByEvaluatingWithContainer:count:", container, count).To<IntPtr>();
		}

		public NSObject objectsByEvaluatingWithContainers(NSObject containers)
		{
			return Call("objectsByEvaluatingWithContainers:", containers).To<NSObject>();
		}

		public NSObject objectsByEvaluatingSpecifier()
		{
			return Call("objectsByEvaluatingSpecifier").To<NSObject>();
		}

		public Int32 evaluationErrorNumber()
		{
			return Call("evaluationErrorNumber").To<Int32>();
		}

		public void setEvaluationErrorNumber(Int32 error)
		{
			Unused.Value = Call("setEvaluationErrorNumber:", error);
		}

		public NSScriptObjectSpecifier evaluationErrorSpecifier()
		{
			return Call("evaluationErrorSpecifier").To<NSScriptObjectSpecifier>();
		}

		public NSAppleEventDescriptor descriptor()
		{
			return Call("descriptor").To<NSAppleEventDescriptor>();
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

		private static Class ms_class = new Class("NSScriptObjectSpecifier");
	}

	public static class NSScriptObjectSpecifiersForNSObjectCategory
	{
		public static NSScriptObjectSpecifier objectSpecifier(this NSObject _instance)
		{
			return _instance.Call("objectSpecifier").To<NSScriptObjectSpecifier>();
		}

		public static NSArray indicesOfObjectsByEvaluatingObjectSpecifier(this NSObject _instance, NSScriptObjectSpecifier specifier)
		{
			return _instance.Call("indicesOfObjectsByEvaluatingObjectSpecifier:", specifier).To<NSArray>();
		}
	}

	[Register]
	public partial class NSIndexSpecifier : NSScriptObjectSpecifier
	{
		public NSIndexSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSIndexSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSIndexSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSIndexSpecifier alloc()
		{
			return new NSIndexSpecifier(ms_class.Call("alloc"));
		}

		public new NSIndexSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContainerClassDescriptionContainerSpecifierKeyIndex(NSScriptClassDescription classDesc, NSScriptObjectSpecifier container, NSString property, Int32 index)
		{
			return Call("initWithContainerClassDescription:containerSpecifier:key:index:", classDesc, container, property, index).To<NSObject>();
		}

		public Int32 index()
		{
			return Call("index").To<Int32>();
		}

		public void setIndex(Int32 index)
		{
			Unused.Value = Call("setIndex:", index);
		}

		private static Class ms_class = new Class("NSIndexSpecifier");
	}

	[Register]
	public partial class NSMiddleSpecifier : NSScriptObjectSpecifier
	{
		public NSMiddleSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMiddleSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSMiddleSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSMiddleSpecifier alloc()
		{
			return new NSMiddleSpecifier(ms_class.Call("alloc"));
		}

		public new NSMiddleSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSMiddleSpecifier");
	}

	[Register]
	public partial class NSNameSpecifier : NSScriptObjectSpecifier
	{
		public NSNameSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSNameSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSNameSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSNameSpecifier alloc()
		{
			return new NSNameSpecifier(ms_class.Call("alloc"));
		}

		public new NSNameSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContainerClassDescriptionContainerSpecifierKeyName(NSScriptClassDescription classDesc, NSScriptObjectSpecifier container, NSString property, NSString name)
		{
			return Call("initWithContainerClassDescription:containerSpecifier:key:name:", classDesc, container, property, name).To<NSObject>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public void setName(NSString name)
		{
			Unused.Value = Call("setName:", name);
		}

		private static Class ms_class = new Class("NSNameSpecifier");
	}

	[Register]
	public partial class NSPositionalSpecifier : NSObject
	{
		public NSPositionalSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPositionalSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSPositionalSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSPositionalSpecifier alloc()
		{
			return new NSPositionalSpecifier(ms_class.Call("alloc"));
		}

		public new NSPositionalSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithPositionObjectSpecifier(UInt32 position, NSScriptObjectSpecifier specifier)
		{
			return Call("initWithPosition:objectSpecifier:", position, specifier).To<NSObject>();
		}

		public UInt32 position()
		{
			return Call("position").To<UInt32>();
		}

		public NSScriptObjectSpecifier objectSpecifier()
		{
			return Call("objectSpecifier").To<NSScriptObjectSpecifier>();
		}

		public void setInsertionClassDescription(NSScriptClassDescription classDescription)
		{
			Unused.Value = Call("setInsertionClassDescription:", classDescription);
		}

		public void evaluate()
		{
			Unused.Value = Call("evaluate");
		}

		public NSObject insertionContainer()
		{
			return Call("insertionContainer").To<NSObject>();
		}

		public NSString insertionKey()
		{
			return Call("insertionKey").To<NSString>();
		}

		public Int32 insertionIndex()
		{
			return Call("insertionIndex").To<Int32>();
		}

		public bool insertionReplaces()
		{
			return Call("insertionReplaces").To<bool>();
		}

		private static Class ms_class = new Class("NSPositionalSpecifier");
	}

	[Register]
	public partial class NSPropertySpecifier : NSScriptObjectSpecifier
	{
		public NSPropertySpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSPropertySpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSPropertySpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSPropertySpecifier alloc()
		{
			return new NSPropertySpecifier(ms_class.Call("alloc"));
		}

		public new NSPropertySpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSPropertySpecifier");
	}

	[Register]
	public partial class NSRandomSpecifier : NSScriptObjectSpecifier
	{
		public NSRandomSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSRandomSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSRandomSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSRandomSpecifier alloc()
		{
			return new NSRandomSpecifier(ms_class.Call("alloc"));
		}

		public new NSRandomSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSRandomSpecifier");
	}

	[Register]
	public partial class NSRangeSpecifier : NSScriptObjectSpecifier
	{
		public NSRangeSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSRangeSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSRangeSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSRangeSpecifier alloc()
		{
			return new NSRangeSpecifier(ms_class.Call("alloc"));
		}

		public new NSRangeSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContainerClassDescriptionContainerSpecifierKeyStartSpecifierEndSpecifier(NSScriptClassDescription classDesc, NSScriptObjectSpecifier container, NSString property, NSScriptObjectSpecifier startSpec, NSScriptObjectSpecifier endSpec)
		{
			return Call("initWithContainerClassDescription:containerSpecifier:key:startSpecifier:endSpecifier:", classDesc, container, property, startSpec, endSpec).To<NSObject>();
		}

		public NSScriptObjectSpecifier startSpecifier()
		{
			return Call("startSpecifier").To<NSScriptObjectSpecifier>();
		}

		public void setStartSpecifier(NSScriptObjectSpecifier startSpec)
		{
			Unused.Value = Call("setStartSpecifier:", startSpec);
		}

		public NSScriptObjectSpecifier endSpecifier()
		{
			return Call("endSpecifier").To<NSScriptObjectSpecifier>();
		}

		public void setEndSpecifier(NSScriptObjectSpecifier endSpec)
		{
			Unused.Value = Call("setEndSpecifier:", endSpec);
		}

		private static Class ms_class = new Class("NSRangeSpecifier");
	}

	[Register]
	public partial class NSRelativeSpecifier : NSScriptObjectSpecifier
	{
		public NSRelativeSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSRelativeSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSRelativeSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSRelativeSpecifier alloc()
		{
			return new NSRelativeSpecifier(ms_class.Call("alloc"));
		}

		public new NSRelativeSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContainerClassDescriptionContainerSpecifierKeyRelativePositionBaseSpecifier(NSScriptClassDescription classDesc, NSScriptObjectSpecifier container, NSString property, UInt32 relPos, NSScriptObjectSpecifier baseSpecifier)
		{
			return Call("initWithContainerClassDescription:containerSpecifier:key:relativePosition:baseSpecifier:", classDesc, container, property, relPos, baseSpecifier).To<NSObject>();
		}

		public UInt32 relativePosition()
		{
			return Call("relativePosition").To<UInt32>();
		}

		public void setRelativePosition(UInt32 relPos)
		{
			Unused.Value = Call("setRelativePosition:", relPos);
		}

		public NSScriptObjectSpecifier baseSpecifier()
		{
			return Call("baseSpecifier").To<NSScriptObjectSpecifier>();
		}

		public void setBaseSpecifier(NSScriptObjectSpecifier baseSpecifier)
		{
			Unused.Value = Call("setBaseSpecifier:", baseSpecifier);
		}

		private static Class ms_class = new Class("NSRelativeSpecifier");
	}

	[Register]
	public partial class NSUniqueIDSpecifier : NSScriptObjectSpecifier
	{
		public NSUniqueIDSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSUniqueIDSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSUniqueIDSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSUniqueIDSpecifier alloc()
		{
			return new NSUniqueIDSpecifier(ms_class.Call("alloc"));
		}

		public new NSUniqueIDSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContainerClassDescriptionContainerSpecifierKeyUniqueID(NSScriptClassDescription classDesc, NSScriptObjectSpecifier container, NSString property, NSObject uniqueID)
		{
			return Call("initWithContainerClassDescription:containerSpecifier:key:uniqueID:", classDesc, container, property, uniqueID).To<NSObject>();
		}

		public NSObject uniqueID()
		{
			return Call("uniqueID").To<NSObject>();
		}

		public void setUniqueID(NSObject uniqueID)
		{
			Unused.Value = Call("setUniqueID:", uniqueID);
		}

		private static Class ms_class = new Class("NSUniqueIDSpecifier");
	}

	[Register]
	public partial class NSWhoseSpecifier : NSScriptObjectSpecifier
	{
		public NSWhoseSpecifier() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSWhoseSpecifier(IntPtr instance) : base(instance)
		{
		}

		public NSWhoseSpecifier(Untyped instance) : base(instance)
		{
		}

		public static new NSWhoseSpecifier alloc()
		{
			return new NSWhoseSpecifier(ms_class.Call("alloc"));
		}

		public new NSWhoseSpecifier retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContainerClassDescriptionContainerSpecifierKeyTest(NSScriptClassDescription classDesc, NSScriptObjectSpecifier container, NSString property, NSScriptWhoseTest test)
		{
			return Call("initWithContainerClassDescription:containerSpecifier:key:test:", classDesc, container, property, test).To<NSObject>();
		}

		public NSScriptWhoseTest test()
		{
			return Call("test").To<NSScriptWhoseTest>();
		}

		public void setTest(NSScriptWhoseTest test)
		{
			Unused.Value = Call("setTest:", test);
		}

		public UInt32 startSubelementIdentifier()
		{
			return Call("startSubelementIdentifier").To<UInt32>();
		}

		public void setStartSubelementIdentifier(UInt32 subelement)
		{
			Unused.Value = Call("setStartSubelementIdentifier:", subelement);
		}

		public Int32 startSubelementIndex()
		{
			return Call("startSubelementIndex").To<Int32>();
		}

		public void setStartSubelementIndex(Int32 index)
		{
			Unused.Value = Call("setStartSubelementIndex:", index);
		}

		public UInt32 endSubelementIdentifier()
		{
			return Call("endSubelementIdentifier").To<UInt32>();
		}

		public void setEndSubelementIdentifier(UInt32 subelement)
		{
			Unused.Value = Call("setEndSubelementIdentifier:", subelement);
		}

		public Int32 endSubelementIndex()
		{
			return Call("endSubelementIndex").To<Int32>();
		}

		public void setEndSubelementIndex(Int32 index)
		{
			Unused.Value = Call("setEndSubelementIndex:", index);
		}

		private static Class ms_class = new Class("NSWhoseSpecifier");
	}
}
