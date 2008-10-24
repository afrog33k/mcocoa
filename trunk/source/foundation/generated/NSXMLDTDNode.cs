// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSXMLDTDNode.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSXMLEntityGeneralKind = 1;
		public const int NSXMLEntityParsedKind = 2;
		public const int NSXMLEntityUnparsedKind = 3;
		public const int NSXMLEntityParameterKind = 4;
		public const int NSXMLEntityPredefined = 5;
		public const int NSXMLAttributeCDATAKind = 6;
		public const int NSXMLAttributeIDKind = 7;
		public const int NSXMLAttributeIDRefKind = 8;
		public const int NSXMLAttributeIDRefsKind = 9;
		public const int NSXMLAttributeEntityKind = 10;
		public const int NSXMLAttributeEntitiesKind = 11;
		public const int NSXMLAttributeNMTokenKind = 12;
		public const int NSXMLAttributeNMTokensKind = 13;
		public const int NSXMLAttributeEnumerationKind = 14;
		public const int NSXMLAttributeNotationKind = 15;
		public const int NSXMLElementDeclarationUndefinedKind = 16;
		public const int NSXMLElementDeclarationEmptyKind = 17;
		public const int NSXMLElementDeclarationAnyKind = 18;
		public const int NSXMLElementDeclarationMixedKind = 19;
		public const int NSXMLElementDeclarationElementKind = 20;
	}

	[Register]
	public partial class NSXMLDTDNode : NSXMLNode
	{
		public NSXMLDTDNode() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSXMLDTDNode(IntPtr instance) : base(instance)
		{
		}

		public NSXMLDTDNode(Untyped instance) : base(instance)
		{
		}

		public static new NSXMLDTDNode alloc()
		{
			return new NSXMLDTDNode(ms_class.Call("alloc"));
		}

		public new NSXMLDTDNode retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithXMLString(NSString string_)
		{
			return Call("initWithXMLString:", string_).To<NSObject>();
		}

		public void setDTDKind(UInt32 kind)
		{
			Unused.Value = Call("setDTDKind:", kind);
		}

		public UInt32 DTDKind()
		{
			return Call("DTDKind").To<UInt32>();
		}

		public bool isExternal()
		{
			return Call("isExternal").To<bool>();
		}

		public void setPublicID(NSString publicID)
		{
			Unused.Value = Call("setPublicID:", publicID);
		}

		public NSString publicID()
		{
			return Call("publicID").To<NSString>();
		}

		public void setSystemID(NSString systemID)
		{
			Unused.Value = Call("setSystemID:", systemID);
		}

		public NSString systemID()
		{
			return Call("systemID").To<NSString>();
		}

		public void setNotationName(NSString notationName)
		{
			Unused.Value = Call("setNotationName:", notationName);
		}

		public NSString notationName()
		{
			return Call("notationName").To<NSString>();
		}

		private static Class ms_class = new Class("NSXMLDTDNode");
	}
}
