// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTreeNode.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSTreeNode : NSObject
	{
		public NSTreeNode() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTreeNode(IntPtr instance) : base(instance)
		{
		}

		public NSTreeNode(Untyped instance) : base(instance)
		{
		}

		public static new NSTreeNode alloc()
		{
			return new NSTreeNode(ms_class.Call("alloc"));
		}

		public new NSTreeNode retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSObject treeNodeWithRepresentedObject(NSObject modelObject)
		{
			return ms_class.Call("treeNodeWithRepresentedObject:", modelObject).To<NSObject>();
		}

		public NSObject initWithRepresentedObject(NSObject modelObject)
		{
			return Call("initWithRepresentedObject:", modelObject).To<NSObject>();
		}

		public NSObject representedObject()
		{
			return Call("representedObject").To<NSObject>();
		}

		public NSIndexPath indexPath()
		{
			return Call("indexPath").To<NSIndexPath>();
		}

		public bool isLeaf()
		{
			return Call("isLeaf").To<bool>();
		}

		public NSArray childNodes()
		{
			return Call("childNodes").To<NSArray>();
		}

		public NSMutableArray mutableChildNodes()
		{
			return Call("mutableChildNodes").To<NSMutableArray>();
		}

		public NSTreeNode descendantNodeAtIndexPath(NSIndexPath indexPath)
		{
			return Call("descendantNodeAtIndexPath:", indexPath).To<NSTreeNode>();
		}

		public NSTreeNode parentNode()
		{
			return Call("parentNode").To<NSTreeNode>();
		}

		public void sortWithSortDescriptorsRecursively(NSArray sortDescriptors, bool recursively)
		{
			Unused.Value = Call("sortWithSortDescriptors:recursively:", sortDescriptors, recursively);
		}

		private static Class ms_class = new Class("NSTreeNode");
	}
}
