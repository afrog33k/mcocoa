// Copyright (C) 2008 Jesse Jones
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using MObjc;
using System;

namespace MCocoa
{
	/// <exclude/>
	public static partial class Externs
	{
		// standard error domains
		public static readonly LazyString NSPOSIXErrorDomain = new LazyString("NSPOSIXErrorDomain");
		public static readonly LazyString NSOSStatusErrorDomain = new LazyString("NSOSStatusErrorDomain");
		public static readonly LazyString NSMachErrorDomain = new LazyString("NSMachErrorDomain");
		public static readonly LazyString Cocoa3Domain = new LazyString("Cocoa3Domain");
		
		// standard userInfo keys
		public static readonly LazyString NSLocalizedDescriptionKey = new LazyString("NSLocalizedDescription");
		public static readonly LazyString NSErrorFailingURLStringKey = new LazyString("NSErrorFailingURLStringKey");
		public static readonly LazyString NSFilePathErrorKey = new LazyString("NSFilePath");
		public static readonly LazyString NSStringEncodingErrorKey = new LazyString("NSStringEncoding");
		public static readonly LazyString NSUnderlyingErrorKey = new LazyString("NSUnderlyingError");
		public static readonly LazyString NSURLErrorKey = new LazyString("NSURL");
		public static readonly LazyString NSLocalizedFailureReasonErrorKey = new LazyString("NSLocalizedFailureReason");
		public static readonly LazyString NSLocalizedRecoverySuggestionErrorKey = new LazyString("NSLocalizedRecoverySuggestion");
		public static readonly LazyString NSLocalizedRecoveryOptionsErrorKey = new LazyString("NSLocalizedRecoveryOptions");
		public static readonly LazyString NSRecoveryAttempterErrorKey = new LazyString("NSRecoveryAttempter");
	}
	
	/// <summary>Also see Apple's <a href = "http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Classes/nserror_Class/Reference/Reference.html">docs</a>.</summary>
	public partial class NSError : NSObject
	{
		/// <summary>Uses the NSError to create and throw a .NET exception.</summary>
		/// <remarks>If the NSError is in the Cocoa3Domain and the code is NSUserCancelledError then
		/// a OperationCanceledException will be thrown. Otherwise an InvalidOperationException will
		/// be thrown which includes the localizedDescription and the localizedFailureReason.</remarks>
		public void Raise()
		{
			if (domain() == Externs.Cocoa3Domain && code() == Enums.NSUserCancelledError)
			{
				throw new OperationCanceledException();
			}
			else
			{
				string message = string.Format("{0} ({1})", localizedDescription().description(), localizedFailureReason().description());
				throw new InvalidOperationException(message);
			}
		}
	}
}