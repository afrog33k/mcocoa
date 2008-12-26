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
using System.Diagnostics;

namespace MCocoa
{
	public static partial class Enums
	{
		public const int NSNotFound = 0x7fffffff;
	}
	
	[DisableRule("R1016", "Const2")]	
	[Register("_NSRange")]
	public struct NSRange : IEquatable<NSRange>
	{		
		public int location;
		public int length;

		public NSRange(int loc, int len)
		{
			Trace.Assert(loc >= 0, "loc is negative");
			Trace.Assert(len >= 0, "len is negative");

			location = loc;
			length = len;
		}
		
		public NSRange(NSRange range)
		{
			location = range.location;
			length = range.length;
		}
		
		public bool Intersects(int index)
		{
			return index >= location && index < location + length;
		}
				
		public bool Intersects(NSRange rhs)
		{
			bool intersects = false;
			
			if (Intersects(rhs.location))
			{
				intersects = true;
			}
			else if (rhs.Intersects(location))
			{
				intersects = true;
			}
			
			return intersects;
		}
				
		public override string ToString()
		{
			return string.Format("[{0}, {1}]", location, location + length);
		}
	
		public override bool Equals(object rhsObj)
		{
			if (rhsObj == null)						
				return false;
			
			if (GetType() != rhsObj.GetType()) 
				return false;
		
			NSRange rhs = (NSRange) rhsObj;					
			return this == rhs;
		}
			
		public bool Equals(NSRange rhs)	
		{
			return this == rhs;
		}
	 
		public static bool operator==(NSRange lhs, NSRange rhs)
		{
			return lhs.location == rhs.location && lhs.length == rhs.length;
		}
		
		public static bool operator!=(NSRange lhs, NSRange rhs)
		{
			return !(lhs == rhs);
		}
		
		public override int GetHashCode()
		{
			int hash;
			
			unchecked
			{
				hash = 3*location.GetHashCode() + 7*length.GetHashCode();
			}
			
			return hash;
		}

		public static readonly NSRange Empty = new NSRange(0, 0);
	}
}
