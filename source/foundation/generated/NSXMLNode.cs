// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSXMLNode.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSXMLInvalidKind = 0;
		public const int NSXMLDocumentKind = 1;
		public const int NSXMLElementKind = 2;
		public const int NSXMLAttributeKind = 3;
		public const int NSXMLNamespaceKind = 4;
		public const int NSXMLProcessingInstructionKind = 5;
		public const int NSXMLCommentKind = 6;
		public const int NSXMLTextKind = 7;
		public const int NSXMLDTDKind = 8;
		public const int NSXMLEntityDeclarationKind = 9;
		public const int NSXMLAttributeDeclarationKind = 10;
		public const int NSXMLElementDeclarationKind = 11;
		public const int NSXMLNotationDeclarationKind = 12;
	}

	[Register]
	public partial class NSXMLNode : NSObject
	{
		public NSXMLNode() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSXMLNode(IntPtr instance) : base(instance)
		{
		}

		public NSXMLNode(Untyped instance) : base(instance)
		{
		}

		public static new NSXMLNode alloc()
		{
			return new NSXMLNode(ms_class.Call("alloc"));
		}

		public new NSXMLNode retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithKind(UInt32 kind)
		{
			return Call("initWithKind:", kind).To<NSObject>();
		}

		public NSObject initWithKindOptions(UInt32 kind, UInt32 options)
		{
			return Call("initWithKind:options:", kind, options).To<NSObject>();
		}

		public static NSObject document()
		{
			return ms_class.Call("document").To<NSObject>();
		}

		public static NSObject documentWithRootElement(NSXMLElement element)
		{
			return ms_class.Call("documentWithRootElement:", element).To<NSObject>();
		}

		public static NSObject elementWithName(NSString name)
		{
			return ms_class.Call("elementWithName:", name).To<NSObject>();
		}

		public static NSObject elementWithNameURI(NSString name, NSString URI)
		{
			return ms_class.Call("elementWithName:URI:", name, URI).To<NSObject>();
		}

		public static NSObject elementWithNameStringValue(NSString name, NSString string_)
		{
			return ms_class.Call("elementWithName:stringValue:", name, string_).To<NSObject>();
		}

		public static NSObject elementWithNameChildrenAttributes(NSString name, NSArray children, NSArray attributes)
		{
			return ms_class.Call("elementWithName:children:attributes:", name, children, attributes).To<NSObject>();
		}

		public static NSObject attributeWithNameStringValue(NSString name, NSString stringValue)
		{
			return ms_class.Call("attributeWithName:stringValue:", name, stringValue).To<NSObject>();
		}

		public static NSObject attributeWithNameURIStringValue(NSString name, NSString URI, NSString stringValue)
		{
			return ms_class.Call("attributeWithName:URI:stringValue:", name, URI, stringValue).To<NSObject>();
		}

		public static NSObject namespaceWithNameStringValue(NSString name, NSString stringValue)
		{
			return ms_class.Call("namespaceWithName:stringValue:", name, stringValue).To<NSObject>();
		}

		public static NSObject processingInstructionWithNameStringValue(NSString name, NSString stringValue)
		{
			return ms_class.Call("processingInstructionWithName:stringValue:", name, stringValue).To<NSObject>();
		}

		public static NSObject commentWithStringValue(NSString stringValue)
		{
			return ms_class.Call("commentWithStringValue:", stringValue).To<NSObject>();
		}

		public static NSObject textWithStringValue(NSString stringValue)
		{
			return ms_class.Call("textWithStringValue:", stringValue).To<NSObject>();
		}

		public static NSObject DTDNodeWithXMLString(NSString string_)
		{
			return ms_class.Call("DTDNodeWithXMLString:", string_).To<NSObject>();
		}

		public UInt32 kind()
		{
			return Call("kind").To<UInt32>();
		}

		public void setName(NSString name)
		{
			Unused.Value = Call("setName:", name);
		}

		public NSString name()
		{
			return Call("name").To<NSString>();
		}

		public void setObjectValue(NSObject value)
		{
			Unused.Value = Call("setObjectValue:", value);
		}

		public NSObject objectValue()
		{
			return Call("objectValue").To<NSObject>();
		}

		public void setStringValue(NSString string_)
		{
			Unused.Value = Call("setStringValue:", string_);
		}

		public void setStringValueResolvingEntities(NSString string_, bool resolve)
		{
			Unused.Value = Call("setStringValue:resolvingEntities:", string_, resolve);
		}

		public NSString stringValue()
		{
			return Call("stringValue").To<NSString>();
		}

		public UInt32 index()
		{
			return Call("index").To<UInt32>();
		}

		public UInt32 level()
		{
			return Call("level").To<UInt32>();
		}

		public NSXMLDocument rootDocument()
		{
			return Call("rootDocument").To<NSXMLDocument>();
		}

		public NSXMLNode parent()
		{
			return Call("parent").To<NSXMLNode>();
		}

		public UInt32 childCount()
		{
			return Call("childCount").To<UInt32>();
		}

		public NSArray children()
		{
			return Call("children").To<NSArray>();
		}

		public NSXMLNode childAtIndex(UInt32 index)
		{
			return Call("childAtIndex:", index).To<NSXMLNode>();
		}

		public NSXMLNode previousSibling()
		{
			return Call("previousSibling").To<NSXMLNode>();
		}

		public NSXMLNode nextSibling()
		{
			return Call("nextSibling").To<NSXMLNode>();
		}

		public NSXMLNode previousNode()
		{
			return Call("previousNode").To<NSXMLNode>();
		}

		public NSXMLNode nextNode()
		{
			return Call("nextNode").To<NSXMLNode>();
		}

		public void detach()
		{
			Unused.Value = Call("detach");
		}

		public NSString XPath()
		{
			return Call("XPath").To<NSString>();
		}

		public NSString localName()
		{
			return Call("localName").To<NSString>();
		}

		public NSString prefix()
		{
			return Call("prefix").To<NSString>();
		}

		public void setURI(NSString URI)
		{
			Unused.Value = Call("setURI:", URI);
		}

		public NSString URI()
		{
			return Call("URI").To<NSString>();
		}

		public static NSString localNameForName(NSString name)
		{
			return ms_class.Call("localNameForName:", name).To<NSString>();
		}

		public static NSString prefixForName(NSString name)
		{
			return ms_class.Call("prefixForName:", name).To<NSString>();
		}

		public static NSXMLNode predefinedNamespaceForPrefix(NSString name)
		{
			return ms_class.Call("predefinedNamespaceForPrefix:", name).To<NSXMLNode>();
		}

		// skipping description (it's already defined)

		public NSString XMLString()
		{
			return Call("XMLString").To<NSString>();
		}

		public NSString XMLStringWithOptions(UInt32 options)
		{
			return Call("XMLStringWithOptions:", options).To<NSString>();
		}

		public NSString canonicalXMLStringPreservingComments(bool comments)
		{
			return Call("canonicalXMLStringPreservingComments:", comments).To<NSString>();
		}

		public NSArray nodesForXPathError(NSString xpath, IntPtr error)
		{
			return Call("nodesForXPath:error:", xpath, error).To<NSArray>();
		}

		public NSArray objectsForXQueryConstantsError(NSString xquery, NSDictionary constants, IntPtr error)
		{
			return Call("objectsForXQuery:constants:error:", xquery, constants, error).To<NSArray>();
		}

		public NSArray objectsForXQueryError(NSString xquery, IntPtr error)
		{
			return Call("objectsForXQuery:error:", xquery, error).To<NSArray>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSXMLNode");
	}
}
