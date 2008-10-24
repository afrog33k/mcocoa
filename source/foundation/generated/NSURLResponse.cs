// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSURLResponse.h

using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class NSURLResponse : NSObject
	{
		public NSURLResponse() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSURLResponse(IntPtr instance) : base(instance)
		{
		}

		public NSURLResponse(Untyped instance) : base(instance)
		{
		}

		public static new NSURLResponse alloc()
		{
			return new NSURLResponse(ms_class.Call("alloc"));
		}

		public new NSURLResponse retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public NSObject initWithURLMIMETypeExpectedContentLengthTextEncodingName(NSURL URL, NSString MIMEType, Int32 length, NSString name)
		{
			return Call("initWithURL:MIMEType:expectedContentLength:textEncodingName:", URL, MIMEType, length, name).To<NSObject>();
		}

		public NSURL URL()
		{
			return Call("URL").To<NSURL>();
		}

		public NSString MIMEType()
		{
			return Call("MIMEType").To<NSString>();
		}

		public Int64 expectedContentLength()
		{
			return Call("expectedContentLength").To<Int64>();
		}

		public NSString textEncodingName()
		{
			return Call("textEncodingName").To<NSString>();
		}

		public NSString suggestedFilename()
		{
			return Call("suggestedFilename").To<NSString>();
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

		#region NSCopying Methods
		public NSObject copyWithZone(IntPtr zone)
		{
			return Call("copyWithZone:", zone).To<NSObject>();
		}
		#endregion

		private static Class ms_class = new Class("NSURLResponse");
	}

	[Register]
	public partial class NSHTTPURLResponse : NSURLResponse
	{
		public NSHTTPURLResponse() : base(ms_class.Alloc().init())
		{
			autorelease();
		}

		public NSHTTPURLResponse(IntPtr instance) : base(instance)
		{
		}

		public NSHTTPURLResponse(Untyped instance) : base(instance)
		{
		}

		public static new NSHTTPURLResponse alloc()
		{
			return new NSHTTPURLResponse(ms_class.Call("alloc"));
		}

		public new NSHTTPURLResponse retain()
		{
			base.retain();
			return this;
		}

		public static new Class Class
		{
			get {return ms_class;}
		}

		public Int32 statusCode()
		{
			return Call("statusCode").To<Int32>();
		}

		public NSDictionary allHeaderFields()
		{
			return Call("allHeaderFields").To<NSDictionary>();
		}

		public static NSString localizedStringForStatusCode(Int32 statusCode)
		{
			return ms_class.Call("localizedStringForStatusCode:", statusCode).To<NSString>();
		}

		private static Class ms_class = new Class("NSHTTPURLResponse");
	}
}
