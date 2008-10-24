// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSScriptStandardSuiteCommands.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSSaveOptionsYes = 0;
		public const int NSSaveOptionsNo = 1;
		public const int NSSaveOptionsAsk = 2;
	}

	[Register]
	public partial class NSCloneCommand : NSScriptCommand
	{
		public NSCloneCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCloneCommand(IntPtr instance) : base(instance)
		{
		}

		public NSCloneCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSCloneCommand alloc()
		{
			return new NSCloneCommand(ms_class.Call("alloc"));
		}

		public new NSCloneCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping setReceiversSpecifier: (it's declared in a base class)

		public NSScriptObjectSpecifier keySpecifier()
		{
			return Call("keySpecifier").To<NSScriptObjectSpecifier>();
		}

		private static Class ms_class = new Class("NSCloneCommand");
	}

	[Register]
	public partial class NSCloseCommand : NSScriptCommand
	{
		public NSCloseCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCloseCommand(IntPtr instance) : base(instance)
		{
		}

		public NSCloseCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSCloseCommand alloc()
		{
			return new NSCloseCommand(ms_class.Call("alloc"));
		}

		public new NSCloseCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 saveOptions()
		{
			return Call("saveOptions").To<UInt32>();
		}

		private static Class ms_class = new Class("NSCloseCommand");
	}

	[Register]
	public partial class NSCountCommand : NSScriptCommand
	{
		public NSCountCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCountCommand(IntPtr instance) : base(instance)
		{
		}

		public NSCountCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSCountCommand alloc()
		{
			return new NSCountCommand(ms_class.Call("alloc"));
		}

		public new NSCountCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSCountCommand");
	}

	[Register]
	public partial class NSCreateCommand : NSScriptCommand
	{
		public NSCreateCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCreateCommand(IntPtr instance) : base(instance)
		{
		}

		public NSCreateCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSCreateCommand alloc()
		{
			return new NSCreateCommand(ms_class.Call("alloc"));
		}

		public new NSCreateCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSScriptClassDescription createClassDescription()
		{
			return Call("createClassDescription").To<NSScriptClassDescription>();
		}

		public NSDictionary resolvedKeyDictionary()
		{
			return Call("resolvedKeyDictionary").To<NSDictionary>();
		}

		private static Class ms_class = new Class("NSCreateCommand");
	}

	[Register]
	public partial class NSDeleteCommand : NSScriptCommand
	{
		public NSDeleteCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSDeleteCommand(IntPtr instance) : base(instance)
		{
		}

		public NSDeleteCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSDeleteCommand alloc()
		{
			return new NSDeleteCommand(ms_class.Call("alloc"));
		}

		public new NSDeleteCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping setReceiversSpecifier: (it's declared in a base class)

		public NSScriptObjectSpecifier keySpecifier()
		{
			return Call("keySpecifier").To<NSScriptObjectSpecifier>();
		}

		private static Class ms_class = new Class("NSDeleteCommand");
	}

	[Register]
	public partial class NSExistsCommand : NSScriptCommand
	{
		public NSExistsCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSExistsCommand(IntPtr instance) : base(instance)
		{
		}

		public NSExistsCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSExistsCommand alloc()
		{
			return new NSExistsCommand(ms_class.Call("alloc"));
		}

		public new NSExistsCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSExistsCommand");
	}

	[Register]
	public partial class NSGetCommand : NSScriptCommand
	{
		public NSGetCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSGetCommand(IntPtr instance) : base(instance)
		{
		}

		public NSGetCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSGetCommand alloc()
		{
			return new NSGetCommand(ms_class.Call("alloc"));
		}

		public new NSGetCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		private static Class ms_class = new Class("NSGetCommand");
	}

	[Register]
	public partial class NSMoveCommand : NSScriptCommand
	{
		public NSMoveCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMoveCommand(IntPtr instance) : base(instance)
		{
		}

		public NSMoveCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSMoveCommand alloc()
		{
			return new NSMoveCommand(ms_class.Call("alloc"));
		}

		public new NSMoveCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping setReceiversSpecifier: (it's declared in a base class)

		public NSScriptObjectSpecifier keySpecifier()
		{
			return Call("keySpecifier").To<NSScriptObjectSpecifier>();
		}

		private static Class ms_class = new Class("NSMoveCommand");
	}

	[Register]
	public partial class NSQuitCommand : NSScriptCommand
	{
		public NSQuitCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSQuitCommand(IntPtr instance) : base(instance)
		{
		}

		public NSQuitCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSQuitCommand alloc()
		{
			return new NSQuitCommand(ms_class.Call("alloc"));
		}

		public new NSQuitCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public UInt32 saveOptions()
		{
			return Call("saveOptions").To<UInt32>();
		}

		private static Class ms_class = new Class("NSQuitCommand");
	}

	[Register]
	public partial class NSSetCommand : NSScriptCommand
	{
		public NSSetCommand() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSSetCommand(IntPtr instance) : base(instance)
		{
		}

		public NSSetCommand(Untyped instance) : base(instance)
		{
		}

		public static new NSSetCommand alloc()
		{
			return new NSSetCommand(ms_class.Call("alloc"));
		}

		public new NSSetCommand retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping setReceiversSpecifier: (it's declared in a base class)

		public NSScriptObjectSpecifier keySpecifier()
		{
			return Call("keySpecifier").To<NSScriptObjectSpecifier>();
		}

		private static Class ms_class = new Class("NSSetCommand");
	}
}
