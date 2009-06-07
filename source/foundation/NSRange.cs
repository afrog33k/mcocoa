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
using System.Diagnostics;
using System.Globalization;

namespace MCocoa
{
	public static partial class Enums
	{
		public const int NSNotFound = 0x7fffffff;
	}
	
	/// <summary>Wrapper around the Cocoa's NSRange struct.</summary>
	[Register("_NSRange")]
	[ThreadModel(ThreadModel.Serializable)]
	public struct NSRange : IEquatable<NSRange>
	{
		public int location;
		public int length;
		
		public NSRange(int loc, int len)
		{
			location = loc;
			length = len;
		}
		
		public NSRange(NSRange range)
		{
			location = range.location;
			length = range.length;
		}
		
		/// <summary>Returns true if the index is within the half-open range.</summary>
		[Pure]
		public bool Intersects(int index)
		{
			return Intersects(new NSRange(index, 1));
		}
		
		/// <summary>Returns true if intersection of the two ranges is non-empty.</summary>
		[Pure]
		public bool Intersects(NSRange rhs)
		{
			bool intersects = false;
			
			if (this.length > 0 && rhs.length > 0)
			{
				if (rhs.location < this.location)
					intersects = rhs.location + rhs.length > this.location;
				
				else if (rhs.location > this.location)
					intersects = this.location + this.length > rhs.location;
				
				else
					intersects = true;
			}
			
			return intersects;
		}
		
		public override string ToString()
		{
			return ToString("G", null);
		}
		
		public string ToString(string format)
		{
			return ToString(format, null);
		}
		
		/// <remarks>Format may be null or "G" which returns something like 
		/// <c>(1.0, 2.0)</c> or "R" which returns a string that can be used with
		/// <see cref = "Parse"/> to get the original value.</remarks>
		public string ToString(string format, IFormatProvider provider)
		{
			if (provider != null)
			{
				ICustomFormatter formatter = provider.GetFormat(GetType()) as ICustomFormatter;
				if (formatter != null)
					return formatter.Format(format, this, provider);
			}
			
			switch (format)
			{
				case "":
				case null:	
				case "g":
				case "G":
					return string.Format("[{0}, {1}]", location, location + length);
				
				case "r":			// round trip version
				case "R":
					IFormatProvider invariant = CultureInfo.InvariantCulture.NumberFormat;
					return string.Format("{0}:{1}", location.ToString("G", invariant), length.ToString("G", invariant));
				
				default:
					string message = string.Format("{0} isn't a valid {1} format string.", format, GetType());
					throw new FormatException(message);
			}
		}
		
		/// <summary>Converts a round-trippable string back to the original value.</summary>
		/// <remarks>To get a round-trippable string use something like <c>range.ToString(&quot;R&quot;, null)</c>.</remarks>
		public static NSRange Parse(string text)
		{
			Contract.Requires(!string.IsNullOrEmpty(text), "text is null or empty");
			
			string[] fields = text.Split(':');
			if (fields.Length != 2)
			{
				string message = string.Format("{0} isn't a valid round trippable NSRange value.", text);
				throw new FormatException(message);
			}
			
			IFormatProvider format = CultureInfo.InvariantCulture.NumberFormat;
			return new NSRange(int.Parse(fields[0], format), int.Parse(fields[1], format));
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
