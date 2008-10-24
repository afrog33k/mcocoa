// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSXMLDTD.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSXMLDTD : NSXMLNode
	{
		public NSXMLDTD() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSXMLDTD(IntPtr instance) : base(instance)
		{
		}

		public NSXMLDTD(Untyped instance) : base(instance)
		{
		}

		public static new NSXMLDTD alloc()
		{
			return new NSXMLDTD(ms_class.Call("alloc"));
		}

		public new NSXMLDTD retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithContentsOfURLOptionsError(NSURL url, UInt32 mask, IntPtr error)
		{
			return Call("initWithContentsOfURL:options:error:", url, mask, error).To<NSObject>();
		}

		public NSObject initWithDataOptionsError(NSData data, UInt32 mask, IntPtr error)
		{
			return Call("initWithData:options:error:", data, mask, error).To<NSObject>();
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

		public NSXMLDTDNode entityDeclarationForName(NSString name)
		{
			return Call("entityDeclarationForName:", name).To<NSXMLDTDNode>();
		}

		public NSXMLDTDNode notationDeclarationForName(NSString name)
		{
			return Call("notationDeclarationForName:", name).To<NSXMLDTDNode>();
		}

		public NSXMLDTDNode elementDeclarationForName(NSString name)
		{
			return Call("elementDeclarationForName:", name).To<NSXMLDTDNode>();
		}

		public NSXMLDTDNode attributeDeclarationForNameElementName(NSString name, NSString elementName)
		{
			return Call("attributeDeclarationForName:elementName:", name, elementName).To<NSXMLDTDNode>();
		}

		public static NSXMLDTDNode predefinedEntityDeclarationForName(NSString name)
		{
			return ms_class.Call("predefinedEntityDeclarationForName:", name).To<NSXMLDTDNode>();
		}

		private static Class ms_class = new Class("NSXMLDTD");
	}
}
