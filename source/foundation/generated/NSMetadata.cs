// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSMetadata.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSMetadataQuery : NSObject
	{
		public NSMetadataQuery() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMetadataQuery(IntPtr instance) : base(instance)
		{
		}

		public NSMetadataQuery(Untyped instance) : base(instance)
		{
		}

		public static new NSMetadataQuery alloc()
		{
			return new NSMetadataQuery(ms_class.Call("alloc"));
		}

		public new NSMetadataQuery retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		// skipping init (it's already defined)

		public NSObject delegate_()
		{
			return Call("delegate").To<NSObject>();
		}

		public void setDelegate(NSObject delegate_)
		{
			Unused.Value = Call("setDelegate:", delegate_);
		}

		public NSPredicate predicate()
		{
			return Call("predicate").To<NSPredicate>();
		}

		public void setPredicate(NSPredicate predicate)
		{
			Unused.Value = Call("setPredicate:", predicate);
		}

		public NSArray sortDescriptors()
		{
			return Call("sortDescriptors").To<NSArray>();
		}

		public void setSortDescriptors(NSArray descriptors)
		{
			Unused.Value = Call("setSortDescriptors:", descriptors);
		}

		public NSArray valueListAttributes()
		{
			return Call("valueListAttributes").To<NSArray>();
		}

		public void setValueListAttributes(NSArray attrs)
		{
			Unused.Value = Call("setValueListAttributes:", attrs);
		}

		public NSArray groupingAttributes()
		{
			return Call("groupingAttributes").To<NSArray>();
		}

		public void setGroupingAttributes(NSArray attrs)
		{
			Unused.Value = Call("setGroupingAttributes:", attrs);
		}

		public double notificationBatchingInterval()
		{
			return Call("notificationBatchingInterval").To<double>();
		}

		public void setNotificationBatchingInterval(double ti)
		{
			Unused.Value = Call("setNotificationBatchingInterval:", ti);
		}

		public NSArray searchScopes()
		{
			return Call("searchScopes").To<NSArray>();
		}

		public void setSearchScopes(NSArray scopes)
		{
			Unused.Value = Call("setSearchScopes:", scopes);
		}

		public bool startQuery()
		{
			return Call("startQuery").To<bool>();
		}

		public void stopQuery()
		{
			Unused.Value = Call("stopQuery");
		}

		public bool isStarted()
		{
			return Call("isStarted").To<bool>();
		}

		public bool isGathering()
		{
			return Call("isGathering").To<bool>();
		}

		public bool isStopped()
		{
			return Call("isStopped").To<bool>();
		}

		public void disableUpdates()
		{
			Unused.Value = Call("disableUpdates");
		}

		public void enableUpdates()
		{
			Unused.Value = Call("enableUpdates");
		}

		public UInt32 resultCount()
		{
			return Call("resultCount").To<UInt32>();
		}

		public NSObject resultAtIndex(UInt32 idx)
		{
			return Call("resultAtIndex:", idx).To<NSObject>();
		}

		public NSArray results()
		{
			return Call("results").To<NSArray>();
		}

		public UInt32 indexOfResult(NSObject result)
		{
			return Call("indexOfResult:", result).To<UInt32>();
		}

		public NSDictionary valueLists()
		{
			return Call("valueLists").To<NSDictionary>();
		}

		public NSArray groupedResults()
		{
			return Call("groupedResults").To<NSArray>();
		}

		public NSObject valueOfAttributeForResultAtIndex(NSString attrName, UInt32 idx)
		{
			return Call("valueOfAttribute:forResultAtIndex:", attrName, idx).To<NSObject>();
		}

		private static Class ms_class = new Class("NSMetadataQuery");
	}

	public static class NSMetadataQueryDelegateForNSObjectCategory
	{
		public static NSObject metadataQueryReplacementObjectForResultObject(this NSObject _instance, NSMetadataQuery query, NSMetadataItem result)
		{
			return _instance.Call("metadataQuery:replacementObjectForResultObject:", query, result).To<NSObject>();
		}

		public static NSObject metadataQueryReplacementValueForAttributeValue(this NSObject _instance, NSMetadataQuery query, NSString attrName, NSObject attrValue)
		{
			return _instance.Call("metadataQuery:replacementValueForAttribute:value:", query, attrName, attrValue).To<NSObject>();
		}
	}

	[Register]
	public partial class NSMetadataItem : NSObject
	{
		public NSMetadataItem() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMetadataItem(IntPtr instance) : base(instance)
		{
		}

		public NSMetadataItem(Untyped instance) : base(instance)
		{
		}

		public static new NSMetadataItem alloc()
		{
			return new NSMetadataItem(ms_class.Call("alloc"));
		}

		public new NSMetadataItem retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject valueForAttribute(NSString key)
		{
			return Call("valueForAttribute:", key).To<NSObject>();
		}

		public NSDictionary valuesForAttributes(NSArray keys)
		{
			return Call("valuesForAttributes:", keys).To<NSDictionary>();
		}

		public NSArray attributes()
		{
			return Call("attributes").To<NSArray>();
		}

		private static Class ms_class = new Class("NSMetadataItem");
	}

	[Register]
	public partial class NSMetadataQueryAttributeValueTuple : NSObject
	{
		public NSMetadataQueryAttributeValueTuple() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMetadataQueryAttributeValueTuple(IntPtr instance) : base(instance)
		{
		}

		public NSMetadataQueryAttributeValueTuple(Untyped instance) : base(instance)
		{
		}

		public static new NSMetadataQueryAttributeValueTuple alloc()
		{
			return new NSMetadataQueryAttributeValueTuple(ms_class.Call("alloc"));
		}

		public new NSMetadataQueryAttributeValueTuple retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString attribute()
		{
			return Call("attribute").To<NSString>();
		}

		public NSObject value()
		{
			return Call("value").To<NSObject>();
		}

		public UInt32 count()
		{
			return Call("count").To<UInt32>();
		}

		private static Class ms_class = new Class("NSMetadataQueryAttributeValueTuple");
	}

	[Register]
	public partial class NSMetadataQueryResultGroup : NSObject
	{
		public NSMetadataQueryResultGroup() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSMetadataQueryResultGroup(IntPtr instance) : base(instance)
		{
		}

		public NSMetadataQueryResultGroup(Untyped instance) : base(instance)
		{
		}

		public static new NSMetadataQueryResultGroup alloc()
		{
			return new NSMetadataQueryResultGroup(ms_class.Call("alloc"));
		}

		public new NSMetadataQueryResultGroup retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSString attribute()
		{
			return Call("attribute").To<NSString>();
		}

		public NSObject value()
		{
			return Call("value").To<NSObject>();
		}

		public NSArray subgroups()
		{
			return Call("subgroups").To<NSArray>();
		}

		public UInt32 resultCount()
		{
			return Call("resultCount").To<UInt32>();
		}

		public NSObject resultAtIndex(UInt32 idx)
		{
			return Call("resultAtIndex:", idx).To<NSObject>();
		}

		public NSArray results()
		{
			return Call("results").To<NSArray>();
		}

		private static Class ms_class = new Class("NSMetadataQueryResultGroup");
	}
}
