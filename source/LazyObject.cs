// Copyright (C) 2009 Jesse Jones
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
	/// <summary>Allows the extern strings to be created only if they are used.</summary>
	/// <remarks>This makes it easier to identify the strings which are actually leaking.</remarks>
	public sealed class LazyString
	{
		internal LazyString(string text)
		{
			Contract.Requires(text != null);
			
			m_text = text;
		}
		
		[ThreadModel(ThreadModel.Concurrent)]
		public static implicit operator NSString(LazyString ls)
		{
			// Note that there is a race in this code, but no real harm
			// is done if the race is lost.
			if (ls.m_instance == null)
				ls.m_instance = NSString.Create(ls.m_text).Retain();
			
			return ls.m_instance;
		}
		
		#region Fields
		private string m_text;
		private NSString m_instance;
		#endregion
	}
}
