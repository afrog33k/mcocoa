// machine generated on 10/24/2008 3:54:03 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSAppleEventDescriptor.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSAppleEventDescriptor : NSObject
	{
		public NSAppleEventDescriptor() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSAppleEventDescriptor(IntPtr instance) : base(instance)
		{
		}

		public NSAppleEventDescriptor(Untyped instance) : base(instance)
		{
		}

		public static new NSAppleEventDescriptor alloc()
		{
			return new NSAppleEventDescriptor(ms_class.Call("alloc"));
		}

		public new NSAppleEventDescriptor retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public static NSAppleEventDescriptor nullDescriptor()
		{
			return ms_class.Call("nullDescriptor").To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor descriptorWithDescriptorTypeBytesLength(UInt32 descriptorType, IntPtr bytes, UInt32 byteCount)
		{
			return ms_class.Call("descriptorWithDescriptorType:bytes:length:", descriptorType, bytes, byteCount).To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor descriptorWithDescriptorTypeData(UInt32 descriptorType, NSData data)
		{
			return ms_class.Call("descriptorWithDescriptorType:data:", descriptorType, data).To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor descriptorWithBoolean(bool boolean)
		{
			return ms_class.Call("descriptorWithBoolean:", boolean).To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor descriptorWithEnumCode(UInt32 enumerator)
		{
			return ms_class.Call("descriptorWithEnumCode:", enumerator).To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor descriptorWithInt32(Int32 signedInt)
		{
			return ms_class.Call("descriptorWithInt32:", signedInt).To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor descriptorWithTypeCode(UInt32 typeCode)
		{
			return ms_class.Call("descriptorWithTypeCode:", typeCode).To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor descriptorWithString(NSString string_)
		{
			return ms_class.Call("descriptorWithString:", string_).To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor appleEventWithEventClassEventIDTargetDescriptorReturnIDTransactionID(UInt32 eventClass, UInt32 eventID, NSAppleEventDescriptor targetDescriptor, Int16 returnID, Int32 transactionID)
		{
			return ms_class.Call("appleEventWithEventClass:eventID:targetDescriptor:returnID:transactionID:", eventClass, eventID, targetDescriptor, returnID, transactionID).To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor listDescriptor()
		{
			return ms_class.Call("listDescriptor").To<NSAppleEventDescriptor>();
		}

		public static NSAppleEventDescriptor recordDescriptor()
		{
			return ms_class.Call("recordDescriptor").To<NSAppleEventDescriptor>();
		}

		public NSObject initWithAEDescNoCopy(IntPtr aeDesc)
		{
			return Call("initWithAEDescNoCopy:", aeDesc).To<NSObject>();
		}

		public NSObject initWithDescriptorTypeBytesLength(UInt32 descriptorType, IntPtr bytes, UInt32 byteCount)
		{
			return Call("initWithDescriptorType:bytes:length:", descriptorType, bytes, byteCount).To<NSObject>();
		}

		public NSObject initWithDescriptorTypeData(UInt32 descriptorType, NSData data)
		{
			return Call("initWithDescriptorType:data:", descriptorType, data).To<NSObject>();
		}

		public NSObject initWithEventClassEventIDTargetDescriptorReturnIDTransactionID(UInt32 eventClass, UInt32 eventID, NSAppleEventDescriptor targetDescriptor, Int16 returnID, Int32 transactionID)
		{
			return Call("initWithEventClass:eventID:targetDescriptor:returnID:transactionID:", eventClass, eventID, targetDescriptor, returnID, transactionID).To<NSObject>();
		}

		public NSObject initListDescriptor()
		{
			return Call("initListDescriptor").To<NSObject>();
		}

		public NSObject initRecordDescriptor()
		{
			return Call("initRecordDescriptor").To<NSObject>();
		}

		public IntPtr aeDesc()
		{
			return Call("aeDesc").To<IntPtr>();
		}

		public UInt32 descriptorType()
		{
			return Call("descriptorType").To<UInt32>();
		}

		public NSData data()
		{
			return Call("data").To<NSData>();
		}

		public bool booleanValue()
		{
			return Call("booleanValue").To<bool>();
		}

		public UInt32 enumCodeValue()
		{
			return Call("enumCodeValue").To<UInt32>();
		}

		public Int32 int32Value()
		{
			return Call("int32Value").To<Int32>();
		}

		public UInt32 typeCodeValue()
		{
			return Call("typeCodeValue").To<UInt32>();
		}

		public NSString stringValue()
		{
			return Call("stringValue").To<NSString>();
		}

		public UInt32 eventClass()
		{
			return Call("eventClass").To<UInt32>();
		}

		public UInt32 eventID()
		{
			return Call("eventID").To<UInt32>();
		}

		public Int16 returnID()
		{
			return Call("returnID").To<Int16>();
		}

		public Int32 transactionID()
		{
			return Call("transactionID").To<Int32>();
		}

		public void setParamDescriptorForKeyword(NSAppleEventDescriptor descriptor, UInt32 keyword)
		{
			Unused.Value = Call("setParamDescriptor:forKeyword:", descriptor, keyword);
		}

		public NSAppleEventDescriptor paramDescriptorForKeyword(UInt32 keyword)
		{
			return Call("paramDescriptorForKeyword:", keyword).To<NSAppleEventDescriptor>();
		}

		public void removeParamDescriptorWithKeyword(UInt32 keyword)
		{
			Unused.Value = Call("removeParamDescriptorWithKeyword:", keyword);
		}

		public void setAttributeDescriptorForKeyword(NSAppleEventDescriptor descriptor, UInt32 keyword)
		{
			Unused.Value = Call("setAttributeDescriptor:forKeyword:", descriptor, keyword);
		}

		public NSAppleEventDescriptor attributeDescriptorForKeyword(UInt32 keyword)
		{
			return Call("attributeDescriptorForKeyword:", keyword).To<NSAppleEventDescriptor>();
		}

		public Int32 numberOfItems()
		{
			return Call("numberOfItems").To<Int32>();
		}

		public void insertDescriptorAtIndex(NSAppleEventDescriptor descriptor, Int32 index)
		{
			Unused.Value = Call("insertDescriptor:atIndex:", descriptor, index);
		}

		public NSAppleEventDescriptor descriptorAtIndex(Int32 index)
		{
			return Call("descriptorAtIndex:", index).To<NSAppleEventDescriptor>();
		}

		public void removeDescriptorAtIndex(Int32 index)
		{
			Unused.Value = Call("removeDescriptorAtIndex:", index);
		}

		public void removeDecriptorAtIndex(Int32 index)
		{
			Unused.Value = Call("removeDecriptorAtIndex:", index);
		}

		public void setDescriptorForKeyword(NSAppleEventDescriptor descriptor, UInt32 keyword)
		{
			Unused.Value = Call("setDescriptor:forKeyword:", descriptor, keyword);
		}

		public NSAppleEventDescriptor descriptorForKeyword(UInt32 keyword)
		{
			return Call("descriptorForKeyword:", keyword).To<NSAppleEventDescriptor>();
		}

		public void removeDescriptorWithKeyword(UInt32 keyword)
		{
			Unused.Value = Call("removeDescriptorWithKeyword:", keyword);
		}

		public UInt32 keywordForDescriptorAtIndex(Int32 index)
		{
			return Call("keywordForDescriptorAtIndex:", index).To<UInt32>();
		}

		public NSAppleEventDescriptor coerceToDescriptorType(UInt32 descriptorType)
		{
			return Call("coerceToDescriptorType:", descriptorType).To<NSAppleEventDescriptor>();
		}

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSAppleEventDescriptor");
	}
}
