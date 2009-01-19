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
	public static partial class Externs
	{
		// standard error domains
		public static readonly NSString NSPOSIXErrorDomain = NSString.Create("NSPOSIXErrorDomain").Retain();
		public static readonly NSString NSOSStatusErrorDomain = NSString.Create("NSOSStatusErrorDomain").Retain();
		public static readonly NSString NSMachErrorDomain = NSString.Create("NSMachErrorDomain").Retain();
		public static readonly NSString Cocoa3Domain = NSString.Create("Cocoa3Domain").Retain();

		// standard userInfo keys
		public static readonly NSString NSLocalizedDescriptionKey = NSString.Create("NSLocalizedDescription").Retain();
		public static readonly NSString NSErrorFailingURLStringKey = NSString.Create("NSErrorFailingURLStringKey").Retain();
		public static readonly NSString NSFilePathErrorKey = NSString.Create("NSFilePath").Retain();
		public static readonly NSString NSStringEncodingErrorKey = NSString.Create("NSStringEncoding").Retain();
		public static readonly NSString NSUnderlyingErrorKey = NSString.Create("NSUnderlyingError").Retain();
		public static readonly NSString NSURLErrorKey = NSString.Create("NSURL").Retain();
		public static readonly NSString NSLocalizedFailureReasonErrorKey = NSString.Create("NSLocalizedFailureReason").Retain();
		public static readonly NSString NSLocalizedRecoverySuggestionErrorKey = NSString.Create("NSLocalizedRecoverySuggestion").Retain();
		public static readonly NSString NSLocalizedRecoveryOptionsErrorKey = NSString.Create("NSLocalizedRecoveryOptions").Retain();
		public static readonly NSString NSRecoveryAttempterErrorKey = NSString.Create("NSRecoveryAttempter").Retain();
	}

	public partial class NSError : NSObject
	{
		public void Raise()
		{
			string message = string.Format("{0} ({1})", localizedDescription().description(), localizedFailureReason().description());
			throw new InvalidOperationException(message);
		}
	}
}