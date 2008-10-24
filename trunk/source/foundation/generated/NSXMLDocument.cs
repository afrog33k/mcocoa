// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSXMLDocument.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSXMLDocumentXMLKind = 0;
		public const int NSXMLDocumentXHTMLKind = 1;
		public const int NSXMLDocumentHTMLKind = 2;
		public const int NSXMLDocumentTextKind = 3;
	}

	[Register]
	public partial class NSXMLDocument : NSXMLNode
	{
		public NSXMLDocument() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSXMLDocument(IntPtr instance) : base(instance)
		{
		}

		public NSXMLDocument(Untyped instance) : base(instance)
		{
		}

		public static new NSXMLDocument alloc()
		{
			return new NSXMLDocument(ms_class.Call("alloc"));
		}

		public new NSXMLDocument retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithXMLStringOptionsError(NSString string_, UInt32 mask, IntPtr error)
		{
			return Call("initWithXMLString:options:error:", string_, mask, error).To<NSObject>();
		}

		public NSObject initWithContentsOfURLOptionsError(NSURL url, UInt32 mask, IntPtr error)
		{
			return Call("initWithContentsOfURL:options:error:", url, mask, error).To<NSObject>();
		}

		public NSObject initWithDataOptionsError(NSData data, UInt32 mask, IntPtr error)
		{
			return Call("initWithData:options:error:", data, mask, error).To<NSObject>();
		}

		public NSObject initWithRootElement(NSXMLElement element)
		{
			return Call("initWithRootElement:", element).To<NSObject>();
		}

		public static Class replacementClassForClass(Class cls)
		{
			return ms_class.Call("replacementClassForClass:", cls).To<Class>();
		}

		public void setCharacterEncoding(NSString encoding)
		{
			Unused.Value = Call("setCharacterEncoding:", encoding);
		}

		public NSString characterEncoding()
		{
			return Call("characterEncoding").To<NSString>();
		}

		public void setVersion(NSString version)
		{
			Unused.Value = Call("setVersion:", version);
		}

		public NSString version()
		{
			return Call("version").To<NSString>();
		}

		public void setStandalone(bool standalone)
		{
			Unused.Value = Call("setStandalone:", standalone);
		}

		public bool isStandalone()
		{
			return Call("isStandalone").To<bool>();
		}

		public void setDocumentContentKind(UInt32 kind)
		{
			Unused.Value = Call("setDocumentContentKind:", kind);
		}

		public UInt32 documentContentKind()
		{
			return Call("documentContentKind").To<UInt32>();
		}

		public void setMIMEType(NSString MIMEType)
		{
			Unused.Value = Call("setMIMEType:", MIMEType);
		}

		public NSString MIMEType()
		{
			return Call("MIMEType").To<NSString>();
		}

		public void setDTD(NSXMLDTD documentTypeDeclaration)
		{
			Unused.Value = Call("setDTD:", documentTypeDeclaration);
		}

		public NSXMLDTD DTD()
		{
			return Call("DTD").To<NSXMLDTD>();
		}

		public void setRootElement(NSXMLNode root)
		{
			Unused.Value = Call("setRootElement:", root);
		}

		public NSXMLElement rootElement()
		{
			return Call("rootElement").To<NSXMLElement>();
		}

		public void insertChildAtIndex(NSXMLNode child, UInt32 index)
		{
			Unused.Value = Call("insertChild:atIndex:", child, index);
		}

		public void insertChildrenAtIndex(NSArray children, UInt32 index)
		{
			Unused.Value = Call("insertChildren:atIndex:", children, index);
		}

		public void removeChildAtIndex(UInt32 index)
		{
			Unused.Value = Call("removeChildAtIndex:", index);
		}

		public void setChildren(NSArray children)
		{
			Unused.Value = Call("setChildren:", children);
		}

		public void addChild(NSXMLNode child)
		{
			Unused.Value = Call("addChild:", child);
		}

		public void replaceChildAtIndexWithNode(UInt32 index, NSXMLNode node)
		{
			Unused.Value = Call("replaceChildAtIndex:withNode:", index, node);
		}

		public NSData XMLData()
		{
			return Call("XMLData").To<NSData>();
		}

		public NSData XMLDataWithOptions(UInt32 options)
		{
			return Call("XMLDataWithOptions:", options).To<NSData>();
		}

		public NSObject objectByApplyingXSLTArgumentsError(NSData xslt, NSDictionary arguments, IntPtr error)
		{
			return Call("objectByApplyingXSLT:arguments:error:", xslt, arguments, error).To<NSObject>();
		}

		public NSObject objectByApplyingXSLTStringArgumentsError(NSString xslt, NSDictionary arguments, IntPtr error)
		{
			return Call("objectByApplyingXSLTString:arguments:error:", xslt, arguments, error).To<NSObject>();
		}

		public NSObject objectByApplyingXSLTAtURLArgumentsError(NSURL xsltURL, NSDictionary argument, IntPtr error)
		{
			return Call("objectByApplyingXSLTAtURL:arguments:error:", xsltURL, argument, error).To<NSObject>();
		}

		public bool validateAndReturnError(IntPtr error)
		{
			return Call("validateAndReturnError:", error).To<bool>();
		}

		private static Class ms_class = new Class("NSXMLDocument");
	}
}
