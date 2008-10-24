// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSTask.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSTask : NSObject
	{
		public NSTask() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTask(IntPtr instance) : base(instance)
		{
		}

		public NSTask(Untyped instance) : base(instance)
		{
		}

		public static new NSTask alloc()
		{
			return new NSTask(ms_class.Call("alloc"));
		}

		public new NSTask retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public void setLaunchPath(NSString path)
		{
			Unused.Value = Call("setLaunchPath:", path);
		}

		public void setArguments(NSArray arguments)
		{
			Unused.Value = Call("setArguments:", arguments);
		}

		public void setEnvironment(NSDictionary dict)
		{
			Unused.Value = Call("setEnvironment:", dict);
		}

		public void setCurrentDirectoryPath(NSString path)
		{
			Unused.Value = Call("setCurrentDirectoryPath:", path);
		}

		public void setStandardInput(NSObject input)
		{
			Unused.Value = Call("setStandardInput:", input);
		}

		public void setStandardOutput(NSObject output)
		{
			Unused.Value = Call("setStandardOutput:", output);
		}

		public void setStandardError(NSObject error)
		{
			Unused.Value = Call("setStandardError:", error);
		}

		public NSString launchPath()
		{
			return Call("launchPath").To<NSString>();
		}

		public NSArray arguments()
		{
			return Call("arguments").To<NSArray>();
		}

		public NSDictionary environment()
		{
			return Call("environment").To<NSDictionary>();
		}

		public NSString currentDirectoryPath()
		{
			return Call("currentDirectoryPath").To<NSString>();
		}

		public NSObject standardInput()
		{
			return Call("standardInput").To<NSObject>();
		}

		public NSObject standardOutput()
		{
			return Call("standardOutput").To<NSObject>();
		}

		public NSObject standardError()
		{
			return Call("standardError").To<NSObject>();
		}

		public void launch()
		{
			Unused.Value = Call("launch");
		}

		public void interrupt()
		{
			Unused.Value = Call("interrupt");
		}

		public void terminate()
		{
			Unused.Value = Call("terminate");
		}

		public bool suspend()
		{
			return Call("suspend").To<bool>();
		}

		public bool resume()
		{
			return Call("resume").To<bool>();
		}

		public Int32 processIdentifier()
		{
			return Call("processIdentifier").To<Int32>();
		}

		public bool isRunning()
		{
			return Call("isRunning").To<bool>();
		}

		public Int32 terminationStatus()
		{
			return Call("terminationStatus").To<Int32>();
		}

		private static Class ms_class = new Class("NSTask");
	}

	public static class NSTaskConveniencesForNSTaskCategory
	{
		public static NSTask launchedTaskWithLaunchPathArguments(this NSTask _instance, NSString path, NSArray arguments)
		{
			return _instance.Call("launchedTaskWithLaunchPath:arguments:", path, arguments).To<NSTask>();
		}

		public static void waitUntilExit(this NSTask _instance)
		{
			Unused.Value = _instance.Call("waitUntilExit");
		}
	}
}
