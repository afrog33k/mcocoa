// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptCommandDescription.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSScriptCommandDescription : NSObject
	{
		public NSScriptCommandDescription() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScriptCommandDescription(IntPtr instance) : base(instance)
		{
		}

		public NSScriptCommandDescription(Untyped instance) : base(instance)
		{
		}

		public static new NSScriptCommandDescription alloc()
		{
			return new NSScriptCommandDescription(ms_class.Call("alloc"));
		}

		public new NSScriptCommandDescription retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithSuiteNameCommandNameDictionary(NSString suiteName, NSString commandName, NSDictionary commandDeclaration)
		{
			return Call("initWithSuiteName:commandName:dictionary:", suiteName, commandName, commandDeclaration).To<NSObject>();
		}

		public NSString suiteName()
		{
			return Call("suiteName").To<NSString>();
		}

		public NSString commandName()
		{
			return Call("commandName").To<NSString>();
		}

		public UInt32 appleEventClassCode()
		{
			return Call("appleEventClassCode").To<UInt32>();
		}

		public UInt32 appleEventCode()
		{
			return Call("appleEventCode").To<UInt32>();
		}

		public NSString commandClassName()
		{
			return Call("commandClassName").To<NSString>();
		}

		public NSString returnType()
		{
			return Call("returnType").To<NSString>();
		}

		public UInt32 appleEventCodeForReturnType()
		{
			return Call("appleEventCodeForReturnType").To<UInt32>();
		}

		public NSArray argumentNames()
		{
			return Call("argumentNames").To<NSArray>();
		}

		public NSString typeForArgumentWithName(NSString argumentName)
		{
			return Call("typeForArgumentWithName:", argumentName).To<NSString>();
		}

		public UInt32 appleEventCodeForArgumentWithName(NSString argumentName)
		{
			return Call("appleEventCodeForArgumentWithName:", argumentName).To<UInt32>();
		}

		public bool isOptionalArgumentWithName(NSString argumentName)
		{
			return Call("isOptionalArgumentWithName:", argumentName).To<bool>();
		}

		public NSScriptCommand createCommandInstance()
		{
			return Call("createCommandInstance").To<NSScriptCommand>();
		}

		public NSScriptCommand createCommandInstanceWithZone(IntPtr zone)
		{
			return Call("createCommandInstanceWithZone:", zone).To<NSScriptCommand>();
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

		private static Class ms_class = new Class("NSScriptCommandDescription");
	}
}
