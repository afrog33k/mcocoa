// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSObjectController.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSObjectController : NSController
	{
		public NSObjectController() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSObjectController(IntPtr instance) : base(instance)
		{
		}

		public NSObjectController(Untyped instance) : base(instance)
		{
		}

		public static new NSObjectController alloc()
		{
			return new NSObjectController(ms_class.Call("alloc"));
		}

		public new NSObjectController retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContent(NSObject content)
		{
			return Call("initWithContent:", content).To<NSObject>();
		}

		public void setContent(NSObject content)
		{
			Unused.Value = Call("setContent:", content);
		}

		public NSObject content()
		{
			return Call("content").To<NSObject>();
		}

		public NSObject selection()
		{
			return Call("selection").To<NSObject>();
		}

		public NSArray selectedObjects()
		{
			return Call("selectedObjects").To<NSArray>();
		}

		public void setAutomaticallyPreparesContent(bool flag)
		{
			Unused.Value = Call("setAutomaticallyPreparesContent:", flag);
		}

		public bool automaticallyPreparesContent()
		{
			return Call("automaticallyPreparesContent").To<bool>();
		}

		public void prepareContent()
		{
			Unused.Value = Call("prepareContent");
		}

		public void setObjectClass(Class objectClass)
		{
			Unused.Value = Call("setObjectClass:", objectClass);
		}

		public Class objectClass()
		{
			return Call("objectClass").To<Class>();
		}

		public NSObject newObject()
		{
			return Call("newObject").To<NSObject>();
		}

		public void addObject(NSObject object_)
		{
			Unused.Value = Call("addObject:", object_);
		}

		public void removeObject(NSObject object_)
		{
			Unused.Value = Call("removeObject:", object_);
		}

		public void setEditable(bool flag)
		{
			Unused.Value = Call("setEditable:", flag);
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public void add(NSObject sender)
		{
			Unused.Value = Call("add:", sender);
		}

		public bool canAdd()
		{
			return Call("canAdd").To<bool>();
		}

		public void remove(NSObject sender)
		{
			Unused.Value = Call("remove:", sender);
		}

		public bool canRemove()
		{
			return Call("canRemove").To<bool>();
		}

		public bool validateUserInterfaceItem(NSObject item)
		{
			return Call("validateUserInterfaceItem:", item).To<bool>();
		}

		private static Class ms_class = new Class("NSObjectController");
	}

	public static class NSManagedControllerForNSObjectControllerCategory
	{
		public static NSObject managedObjectContext(this NSObjectController _instance)
		{
			return _instance.Call("managedObjectContext").To<NSObject>();
		}

		public static void setManagedObjectContext(this NSObjectController _instance, NSObject managedObjectContext)
		{
			Unused.Value = _instance.Call("setManagedObjectContext:", managedObjectContext);
		}

		public static NSString entityName(this NSObjectController _instance)
		{
			return _instance.Call("entityName").To<NSString>();
		}

		public static void setEntityName(this NSObjectController _instance, NSString entityName)
		{
			Unused.Value = _instance.Call("setEntityName:", entityName);
		}

		public static NSPredicate fetchPredicate(this NSObjectController _instance)
		{
			return _instance.Call("fetchPredicate").To<NSPredicate>();
		}

		public static void setFetchPredicate(this NSObjectController _instance, NSPredicate predicate)
		{
			Unused.Value = _instance.Call("setFetchPredicate:", predicate);
		}

		public static bool fetchWithRequestMergeError(this NSObjectController _instance, NSObject fetchRequest, bool merge, IntPtr error)
		{
			return _instance.Call("fetchWithRequest:merge:error:", fetchRequest, merge, error).To<bool>();
		}

		public static void fetch(this NSObjectController _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("fetch:", sender);
		}

		public static void setUsesLazyFetching(this NSObjectController _instance, bool enabled)
		{
			Unused.Value = _instance.Call("setUsesLazyFetching:", enabled);
		}

		public static bool usesLazyFetching(this NSObjectController _instance)
		{
			return _instance.Call("usesLazyFetching").To<bool>();
		}

		public static NSObject defaultFetchRequest(this NSObjectController _instance)
		{
			return _instance.Call("defaultFetchRequest").To<NSObject>();
		}
	}
}
