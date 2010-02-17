// Copyright (C) 2010 Jesse Jones
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
using System.Runtime.InteropServices;

namespace MCocoa
{
	public partial class NSDate : NSObject
	{
		public static int Compare(NSDate lhs, NSDate rhs)
		{
			if (object.ReferenceEquals(lhs, rhs))
				return 0;
			
			if ((object) lhs == null)
				if ((object) rhs == null)
					return 0;
				else
					return -1;
			else if ((object) rhs == null)
				return +1;
			
			int result = lhs.compare(rhs);
			if (result == Enums.NSOrderedAscending)
				result = -1;
			else if (result == Enums.NSOrderedDescending)
				result = +1;
			
			return 0;
		}
		
		public int CompareTo(NSDate rhs)
		{
			return Compare(this, rhs);
		}
		
		public static bool operator==(NSDate lhs, NSDate rhs)
		{
			return Compare(lhs, rhs) == 0;
		}
		
		public static bool operator!=(NSDate lhs, NSDate rhs)
		{
			return Compare(lhs, rhs) != 0;
		}
		
		public static bool operator>=(NSDate lhs, NSDate rhs)
		{
			return Compare(lhs, rhs) >= 0;
		}
		
		public static bool operator>(NSDate lhs, NSDate rhs)
		{
			return Compare(lhs, rhs) > 0;
		}
		
		public static bool operator<=(NSDate lhs, NSDate rhs)
		{
			return Compare(lhs, rhs) <= 0;
		}
		
		public static bool operator<(NSDate lhs, NSDate rhs)
		{
			return Compare(lhs, rhs) < 0;
		}
		
		// The NSObject versions of these are fine, but gmcs complains if we
		// don't define them here...
		public override bool Equals(object rhs)
		{
			return base.Equals(rhs);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
