// machine generated on 10/24/2008 3:54:07 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSTableColumn.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSTableColumnNoResizing = 0;
		public const int NSTableColumnAutoresizingMask = ( 1 << 0 );
		public const int NSTableColumnUserResizingMask = ( 1 << 1 );
	}

	[Register]
	public partial class NSTableColumn : NSObject
	{
		public NSTableColumn() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSTableColumn(IntPtr instance) : base(instance)
		{
		}

		public NSTableColumn(Untyped instance) : base(instance)
		{
		}

		public static new NSTableColumn alloc()
		{
			return new NSTableColumn(ms_class.Call("alloc"));
		}

		public new NSTableColumn retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithIdentifier(NSObject identifier)
		{
			return Call("initWithIdentifier:", identifier).To<NSObject>();
		}

		public void setIdentifier(NSObject identifier)
		{
			Unused.Value = Call("setIdentifier:", identifier);
		}

		public NSObject identifier()
		{
			return Call("identifier").To<NSObject>();
		}

		public void setTableView(NSTableView tableView)
		{
			Unused.Value = Call("setTableView:", tableView);
		}

		public NSTableView tableView()
		{
			return Call("tableView").To<NSTableView>();
		}

		public void setWidth(float width)
		{
			Unused.Value = Call("setWidth:", width);
		}

		public float width()
		{
			return Call("width").To<float>();
		}

		public void setMinWidth(float minWidth)
		{
			Unused.Value = Call("setMinWidth:", minWidth);
		}

		public float minWidth()
		{
			return Call("minWidth").To<float>();
		}

		public void setMaxWidth(float maxWidth)
		{
			Unused.Value = Call("setMaxWidth:", maxWidth);
		}

		public float maxWidth()
		{
			return Call("maxWidth").To<float>();
		}

		public void setHeaderCell(NSCell cell)
		{
			Unused.Value = Call("setHeaderCell:", cell);
		}

		public NSObject headerCell()
		{
			return Call("headerCell").To<NSObject>();
		}

		public void setDataCell(NSCell cell)
		{
			Unused.Value = Call("setDataCell:", cell);
		}

		public NSObject dataCell()
		{
			return Call("dataCell").To<NSObject>();
		}

		public NSObject dataCellForRow(Int32 row)
		{
			return Call("dataCellForRow:", row).To<NSObject>();
		}

		public void setEditable(bool flag)
		{
			Unused.Value = Call("setEditable:", flag);
		}

		public bool isEditable()
		{
			return Call("isEditable").To<bool>();
		}

		public void sizeToFit()
		{
			Unused.Value = Call("sizeToFit");
		}

		public void setSortDescriptorPrototype(NSSortDescriptor sortDescriptor)
		{
			Unused.Value = Call("setSortDescriptorPrototype:", sortDescriptor);
		}

		public NSSortDescriptor sortDescriptorPrototype()
		{
			return Call("sortDescriptorPrototype").To<NSSortDescriptor>();
		}

		public void setResizingMask(UInt32 resizingMask)
		{
			Unused.Value = Call("setResizingMask:", resizingMask);
		}

		public UInt32 resizingMask()
		{
			return Call("resizingMask").To<UInt32>();
		}

		public void setHeaderToolTip(NSString string_)
		{
			Unused.Value = Call("setHeaderToolTip:", string_);
		}

		public NSString headerToolTip()
		{
			return Call("headerToolTip").To<NSString>();
		}

		public bool isHidden()
		{
			return Call("isHidden").To<bool>();
		}

		public void setHidden(bool hidden)
		{
			Unused.Value = Call("setHidden:", hidden);
		}

		public void setResizable(bool flag)
		{
			Unused.Value = Call("setResizable:", flag);
		}

		public bool isResizable()
		{
			return Call("isResizable").To<bool>();
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

		private static Class ms_class = new Class("NSTableColumn");
	}
}
