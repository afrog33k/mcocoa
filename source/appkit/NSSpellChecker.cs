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
using MObjc.Helpers;
using System;

namespace MCocoa
{
	public partial class NSSpellChecker : NSObject
	{
#if MAC_OS_X_VERSION_10_6
		// Need this because there is no System.Action which takes five arguments.
		private delegate void RequestCheckingCallback(IntPtr context, int sequenceNumber, IntPtr resultsPtr, IntPtr orthographyPtr, int wordCount);
		
		/// <exclude/>
		public int requestCheckingOfString_range_types_options_inSpellDocumentWithTag_completionHandler(
			NSString stringToCheck,
			NSRange range,
			ulong checkingTypes,
			NSDictionary options,
			int tag,
			Action<int, NSArray, NSOrthography, int> callback)
		{
			RequestCheckingCallback thunk = (IntPtr context, int sequenceNumber, IntPtr resultsPtr, IntPtr orthographyPtr, int wordCount) =>
			{
				var results = NSObject.Lookup(resultsPtr).To<NSArray>();
				var orthography = NSObject.Lookup(orthographyPtr).To<NSOrthography>();
				callback(sequenceNumber, results, orthography, wordCount);
			};
			
			var block = new ExtendedBlock(thunk);
			int result = Call("requestCheckingOfString:range:types:options:inSpellDocumentWithTag:completionHandler:",
				stringToCheck,
				range,
				checkingTypes,
				options,
				tag,
				block).To<int>();
			GC.KeepAlive(block);
			
			return result;
		}
#endif
	}
}
