// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSXMLElement.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSXMLElement : NSXMLNode
	{
		public NSXMLElement() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSXMLElement(IntPtr instance) : base(instance)
		{
		}

		public NSXMLElement(Untyped instance) : base(instance)
		{
		}

		public static new NSXMLElement alloc()
		{
			return new NSXMLElement(ms_class.Call("alloc"));
		}

		public new NSXMLElement retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithName(NSString name)
		{
			return Call("initWithName:", name).To<NSObject>();
		}

		public NSObject initWithNameURI(NSString name, NSString URI)
		{
			return Call("initWithName:URI:", name, URI).To<NSObject>();
		}

		public NSObject initWithNameStringValue(NSString name, NSString string_)
		{
			return Call("initWithName:stringValue:", name, string_).To<NSObject>();
		}

		public NSObject initWithXMLStringError(NSString string_, IntPtr error)
		{
			return Call("initWithXMLString:error:", string_, error).To<NSObject>();
		}

		public NSArray elementsForName(NSString name)
		{
			return Call("elementsForName:", name).To<NSArray>();
		}

		public NSArray elementsForLocalNameURI(NSString localName, NSString URI)
		{
			return Call("elementsForLocalName:URI:", localName, URI).To<NSArray>();
		}

		public void addAttribute(NSXMLNode attribute)
		{
			Unused.Value = Call("addAttribute:", attribute);
		}

		public void removeAttributeForName(NSString name)
		{
			Unused.Value = Call("removeAttributeForName:", name);
		}

		public void setAttributes(NSArray attributes)
		{
			Unused.Value = Call("setAttributes:", attributes);
		}

		public void setAttributesAsDictionary(NSDictionary attributes)
		{
			Unused.Value = Call("setAttributesAsDictionary:", attributes);
		}

		public NSArray attributes()
		{
			return Call("attributes").To<NSArray>();
		}

		public NSXMLNode attributeForName(NSString name)
		{
			return Call("attributeForName:", name).To<NSXMLNode>();
		}

		public NSXMLNode attributeForLocalNameURI(NSString localName, NSString URI)
		{
			return Call("attributeForLocalName:URI:", localName, URI).To<NSXMLNode>();
		}

		public void addNamespace(NSXMLNode aNamespace)
		{
			Unused.Value = Call("addNamespace:", aNamespace);
		}

		public void removeNamespaceForPrefix(NSString name)
		{
			Unused.Value = Call("removeNamespaceForPrefix:", name);
		}

		public void setNamespaces(NSArray namespaces)
		{
			Unused.Value = Call("setNamespaces:", namespaces);
		}

		public NSArray namespaces()
		{
			return Call("namespaces").To<NSArray>();
		}

		public NSXMLNode namespaceForPrefix(NSString name)
		{
			return Call("namespaceForPrefix:", name).To<NSXMLNode>();
		}

		public NSXMLNode resolveNamespaceForName(NSString name)
		{
			return Call("resolveNamespaceForName:", name).To<NSXMLNode>();
		}

		public NSString resolvePrefixForNamespaceURI(NSString namespaceURI)
		{
			return Call("resolvePrefixForNamespaceURI:", namespaceURI).To<NSString>();
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

		public void normalizeAdjacentTextNodesPreservingCDATA(bool preserve)
		{
			Unused.Value = Call("normalizeAdjacentTextNodesPreservingCDATA:", preserve);
		}

		private static Class ms_class = new Class("NSXMLElement");
	}
}
