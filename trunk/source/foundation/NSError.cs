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
		public static readonly NSString NSPOSIXErrorDomain = new NSString("NSPOSIXErrorDomain");
		public static readonly NSString NSOSStatusErrorDomain = new NSString("NSOSStatusErrorDomain");
		public static readonly NSString NSMachErrorDomain = new NSString("NSMachErrorDomain");
		public static readonly NSString Cocoa3Domain = new NSString("Cocoa3Domain");

		// standard userInfo keys
		public static readonly NSString NSLocalizedDescriptionKey = new NSString("NSLocalizedDescription").retain();
		public static readonly NSString NSErrorFailingURLStringKey = new NSString("NSErrorFailingURLStringKey").retain();
		public static readonly NSString NSFilePathErrorKey = new NSString("NSFilePath").retain();
		public static readonly NSString NSStringEncodingErrorKey = new NSString("NSStringEncoding").retain();
		public static readonly NSString NSUnderlyingErrorKey = new NSString("NSUnderlyingError").retain();
		public static readonly NSString NSURLErrorKey = new NSString("NSURL").retain();
		public static readonly NSString NSLocalizedFailureReasonErrorKey = new NSString("NSLocalizedFailureReason").retain();
		public static readonly NSString NSLocalizedRecoverySuggestionErrorKey = new NSString("NSLocalizedRecoverySuggestion").retain();
		public static readonly NSString NSLocalizedRecoveryOptionsErrorKey = new NSString("NSLocalizedRecoveryOptions").retain();
		public static readonly NSString NSRecoveryAttempterErrorKey = new NSString("NSRecoveryAttempter").retain();
	}
}