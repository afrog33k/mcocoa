// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSColorList.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSColorList : NSObject
	{
		public NSColorList() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSColorList(IntPtr instance) : base(instance)
		{
		}

		public NSColorList(Untyped instance) : base(instance)
		{
		}

		public static new NSColorList alloc()
		{
			return new NSColorList(ms_class.Call("alloc"));
		}

		public new NSColorList retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSArray availableColorLists()
		{
			return ms_class.Call("availableColorLists").To<NSArray>();
		}

		public static NSColorList colorListNamed(NSString name)
		{
			return ms_class.Call("colorListNamed:", name).To<NSColorList>();
		}

		public NSObject initWithName(NSString name)
		{
			return Call("initWithName:", name).To<NSObject>();
		}

		public NSObject initWithNameFromFile(NSString name, NSString path)
		{
			return Call("initWithName:fromFile:", name, path).To<NSObject>();
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public void setColorForKey(NSColor color, NSString key)
		{
			Unused.Value = Call("setColor:forKey:", color, key);
		}

		public void insertColorKeyAtIndex(NSColor color, NSString key, UInt32 loc)
		{
			Unused.Value = Call("insertColor:key:atIndex:", color, key, loc);
		}

		public void removeColorWithKey(NSString key)
		{
			Unused.Value = Call("removeColorWithKey:", key);
		}

		public NSColor colorWithKey(NSString key)
		{
			return Call("colorWithKey:", key).To<NSColor>();
		}

		public NSArray allKeys()
		{
			return Call("allKeys").To<NSArray>();
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public bool writeToFile(NSString path)
		{
			return Call("writeToFile:", path).To<bool>();
		}

		public void removeFile()
		{
			Unused.Value = Call("removeFile");
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

		private static Class ms_class = new Class("NSColorList");
	}
}
