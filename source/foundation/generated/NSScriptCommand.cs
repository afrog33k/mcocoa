// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptCommand.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSNoScriptError = 0;
		public const int NSReceiverEvaluationScriptError = 1;
		public const int NSKeySpecifierEvaluationScriptError = 2;
		public const int NSArgumentEvaluationScriptError = 3;
		public const int NSReceiversCantHandleCommandScriptError = 4;
		public const int NSRequiredArgumentsMissingScriptError = 5;
		public const int NSArgumentsWrongScriptError = 6;
		public const int NSUnknownKeyScriptError = 7;
		public const int NSInternalScriptError = 8;
		public const int NSOperationNotSupportedForKeyScriptError = 9;
		public const int NSCannotCreateScriptCommandError = 10;
	}

	[Register]
	public partial class NSScriptCommand : NSObject
	{
		public NSScriptCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSScriptCommand(IntPtr instance) : base(instance)
		{
		}

		public NSScriptCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSScriptCommand alloc()
		{
			return new NSScriptCommand(ms_class.Call("alloc"));
		}

		public new NSScriptCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithCommandDescription(NSScriptCommandDescription commandDef)
		{
			return Call("initWithCommandDescription:", commandDef).To<NSObject>();
		}

		public NSScriptCommandDescription commandDescription()
		{
			return Call("commandDescription").To<NSScriptCommandDescription>();
		}

		public void setDirectParameter(NSObject directParameter)
		{
			Unused.Value = Call("setDirectParameter:", directParameter);
		}

		public NSObject directParameter()
		{
			return Call("directParameter").To<NSObject>();
		}

		public void setReceiversSpecifier(NSScriptObjectSpecifier receiversRef)
		{
			Unused.Value = Call("setReceiversSpecifier:", receiversRef);
		}

		public NSScriptObjectSpecifier receiversSpecifier()
		{
			return Call("receiversSpecifier").To<NSScriptObjectSpecifier>();
		}

		public NSObject evaluatedReceivers()
		{
			return Call("evaluatedReceivers").To<NSObject>();
		}

		public void setArguments(NSDictionary args)
		{
			Unused.Value = Call("setArguments:", args);
		}

		public NSDictionary arguments()
		{
			return Call("arguments").To<NSDictionary>();
		}

		public NSDictionary evaluatedArguments()
		{
			return Call("evaluatedArguments").To<NSDictionary>();
		}

		public bool isWellFormed()
		{
			return Call("isWellFormed").To<bool>();
		}

		public NSObject performDefaultImplementation()
		{
			return Call("performDefaultImplementation").To<NSObject>();
		}

		public NSObject executeCommand()
		{
			return Call("executeCommand").To<NSObject>();
		}

		public void setScriptErrorNumber(Int32 errorNumber)
		{
			Unused.Value = Call("setScriptErrorNumber:", errorNumber);
		}

		public void setScriptErrorOffendingObjectDescriptor(NSAppleEventDescriptor errorOffendingObjectDescriptor)
		{
			Unused.Value = Call("setScriptErrorOffendingObjectDescriptor:", errorOffendingObjectDescriptor);
		}

		public void setScriptErrorExpectedTypeDescriptor(NSAppleEventDescriptor errorExpectedTypeDescriptor)
		{
			Unused.Value = Call("setScriptErrorExpectedTypeDescriptor:", errorExpectedTypeDescriptor);
		}

		public void setScriptErrorString(NSString errorString)
		{
			Unused.Value = Call("setScriptErrorString:", errorString);
		}

		public Int32 scriptErrorNumber()
		{
			return Call("scriptErrorNumber").To<Int32>();
		}

		public NSAppleEventDescriptor scriptErrorOffendingObjectDescriptor()
		{
			return Call("scriptErrorOffendingObjectDescriptor").To<NSAppleEventDescriptor>();
		}

		public NSAppleEventDescriptor scriptErrorExpectedTypeDescriptor()
		{
			return Call("scriptErrorExpectedTypeDescriptor").To<NSAppleEventDescriptor>();
		}

		public NSString scriptErrorString()
		{
			return Call("scriptErrorString").To<NSString>();
		}

		public static NSScriptCommand currentCommand()
		{
			return ms_class.Call("currentCommand").To<NSScriptCommand>();
		}

		public NSAppleEventDescriptor appleEvent()
		{
			return Call("appleEvent").To<NSAppleEventDescriptor>();
		}

		public void suspendExecution()
		{
			Unused.Value = Call("suspendExecution");
		}

		public void resumeExecutionWithResult(NSObject result)
		{
			Unused.Value = Call("resumeExecutionWithResult:", result);
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

		private static Class ms_class = new Class("NSScriptCommand");
	}
}
