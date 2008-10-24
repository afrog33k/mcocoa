// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSCharacterSet.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSOpenStepUnicodeReservedBase = 0xF400;
	}

	[Register]
	public partial class NSCharacterSet : NSObject
	{
		public NSCharacterSet() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSCharacterSet(IntPtr instance) : base(instance)
		{
		}

		public NSCharacterSet(Untyped instance) : base(instance)
		{
		}

		public static new NSCharacterSet alloc()
		{
			return new NSCharacterSet(ms_class.Call("alloc"));
		}

		public new NSCharacterSet retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject controlCharacterSet()
		{
			return ms_class.Call("controlCharacterSet").To<NSObject>();
		}

		public static NSObject whitespaceCharacterSet()
		{
			return ms_class.Call("whitespaceCharacterSet").To<NSObject>();
		}

		public static NSObject whitespaceAndNewlineCharacterSet()
		{
			return ms_class.Call("whitespaceAndNewlineCharacterSet").To<NSObject>();
		}

		public static NSObject decimalDigitCharacterSet()
		{
			return ms_class.Call("decimalDigitCharacterSet").To<NSObject>();
		}

		public static NSObject letterCharacterSet()
		{
			return ms_class.Call("letterCharacterSet").To<NSObject>();
		}

		public static NSObject lowercaseLetterCharacterSet()
		{
			return ms_class.Call("lowercaseLetterCharacterSet").To<NSObject>();
		}

		public static NSObject uppercaseLetterCharacterSet()
		{
			return ms_class.Call("uppercaseLetterCharacterSet").To<NSObject>();
		}

		public static NSObject nonBaseCharacterSet()
		{
			return ms_class.Call("nonBaseCharacterSet").To<NSObject>();
		}

		public static NSObject alphanumericCharacterSet()
		{
			return ms_class.Call("alphanumericCharacterSet").To<NSObject>();
		}

		public static NSObject decomposableCharacterSet()
		{
			return ms_class.Call("decomposableCharacterSet").To<NSObject>();
		}

		public static NSObject illegalCharacterSet()
		{
			return ms_class.Call("illegalCharacterSet").To<NSObject>();
		}

		public static NSObject punctuationCharacterSet()
		{
			return ms_class.Call("punctuationCharacterSet").To<NSObject>();
		}

		public static NSObject capitalizedLetterCharacterSet()
		{
			return ms_class.Call("capitalizedLetterCharacterSet").To<NSObject>();
		}

		public static NSObject symbolCharacterSet()
		{
			return ms_class.Call("symbolCharacterSet").To<NSObject>();
		}

		public static NSObject newlineCharacterSet()
		{
			return ms_class.Call("newlineCharacterSet").To<NSObject>();
		}

		public static NSObject characterSetWithRange(NSRange aRange)
		{
			return ms_class.Call("characterSetWithRange:", aRange).To<NSObject>();
		}

		public static NSObject characterSetWithCharactersInString(NSString aString)
		{
			return ms_class.Call("characterSetWithCharactersInString:", aString).To<NSObject>();
		}

		public static NSObject characterSetWithBitmapRepresentation(NSData data)
		{
			return ms_class.Call("characterSetWithBitmapRepresentation:", data).To<NSObject>();
		}

		public static NSObject characterSetWithContentsOfFile(NSString fName)
		{
			return ms_class.Call("characterSetWithContentsOfFile:", fName).To<NSObject>();
		}

		public bool characterIsMember(char aCharacter)
		{
			return Call("characterIsMember:", aCharacter).To<bool>();
		}

		public NSData bitmapRepresentation()
		{
			return Call("bitmapRepresentation").To<NSData>();
		}

		public NSCharacterSet invertedSet()
		{
			return Call("invertedSet").To<NSCharacterSet>();
		}

		public bool longCharacterIsMember(UInt32 theLongChar)
		{
			return Call("longCharacterIsMember:", theLongChar).To<bool>();
		}

		public bool isSupersetOfSet(NSCharacterSet theOtherSet)
		{
			return Call("isSupersetOfSet:", theOtherSet).To<bool>();
		}

		public bool hasMemberInPlane(byte thePlane)
		{
			return Call("hasMemberInPlane:", thePlane).To<bool>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		#region NSMutableCopying Methods
		public NSObject mutableCopyWithZone(IntPtr zone)
		{
			return Call("mutableCopyWithZone:", zone).To<NSObject>();
		}
		#endregion

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

		private static Class ms_class = new Class("NSCharacterSet");
	}

	[Register]
	public partial class NSMutableCharacterSet : NSCharacterSet
	{
		public NSMutableCharacterSet() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMutableCharacterSet(IntPtr instance) : base(instance)
		{
		}

		public NSMutableCharacterSet(Untyped instance) : base(instance)
		{
		}

		public static new NSMutableCharacterSet alloc()
		{
			return new NSMutableCharacterSet(ms_class.Call("alloc"));
		}

		public new NSMutableCharacterSet retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public void addCharactersInRange(NSRange aRange)
		{
			Unused.Value = Call("addCharactersInRange:", aRange);
		}

		public void removeCharactersInRange(NSRange aRange)
		{
			Unused.Value = Call("removeCharactersInRange:", aRange);
		}

		public void addCharactersInString(NSString aString)
		{
			Unused.Value = Call("addCharactersInString:", aString);
		}

		public void removeCharactersInString(NSString aString)
		{
			Unused.Value = Call("removeCharactersInString:", aString);
		}

		public void formUnionWithCharacterSet(NSCharacterSet otherSet)
		{
			Unused.Value = Call("formUnionWithCharacterSet:", otherSet);
		}

		public void formIntersectionWithCharacterSet(NSCharacterSet otherSet)
		{
			Unused.Value = Call("formIntersectionWithCharacterSet:", otherSet);
		}

		public void invert()
		{
			Unused.Value = Call("invert");
		}

		private static Class ms_class = new Class("NSMutableCharacterSet");
	}
}
