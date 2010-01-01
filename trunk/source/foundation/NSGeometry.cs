// Copyright (C) 2008-2009 Jesse Jones
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
using System.Runtime.InteropServices;

namespace MCocoa
{
	/// <summary>Wrapper around the Cocoa's NSPoint struct.</summary>
	[Register("_NSPoint")]
	[ThreadModel(ThreadModel.Serializable)]
	public struct NSPoint : IEquatable<NSPoint>, IFormattable
	{
		public float x;
		public float y;
		
		public NSPoint(float x, float y)
		{
			this.x = x;
			this.y = y;
		}
		
		public static NSPoint operator+(NSPoint lhs, NSPoint rhs)
		{
			return new NSPoint(lhs.x + rhs.x, lhs.y + rhs.y);
		}
		
		public static NSPoint operator-(NSPoint lhs, NSPoint rhs)
		{
			return new NSPoint(lhs.x - rhs.x, lhs.y - rhs.y);
		}
		
		/// <summary>Square-root of the sum of the squared component deltas.</summary>
		public static float Distance(NSPoint lhs, NSPoint rhs)
		{
			float dx = lhs.x - rhs.x;
			float dy = lhs.y - rhs.y;
			
			return (float) Math.Sqrt(dx*dx + dy*dy);
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
					return string.Format("({0}, {1})", x, y);
				
				case "r":			// round trip version
				case "R":
					IFormatProvider invariant = CultureInfo.InvariantCulture.NumberFormat;
					return string.Format("{0}:{1}", x.ToString("R", invariant), y.ToString("R", invariant));
				
				default:
					string message = string.Format("{0} isn't a valid {1} format string.", format, GetType());
					throw new FormatException(message);
			}
		}
		
		/// <summary>Converts a round-trippable string back to the original value.</summary>
		/// <remarks>To get a round-trippable string use something like <c>pt.ToString(&quot;R&quot;, null)</c>.</remarks>
		public static NSPoint Parse(string text)
		{
			Contract.Requires(!string.IsNullOrEmpty(text), "text is null or empty");
			
			string[] fields = text.Split(':');
			if (fields.Length != 2)
			{
				string message = string.Format("{0} isn't a valid round trippable NSPoint value.", text);
				throw new FormatException(message);
			}
			
			IFormatProvider format = CultureInfo.InvariantCulture.NumberFormat;
			return new NSPoint(float.Parse(fields[0], format), float.Parse(fields[1], format));
		}
		
		public override bool Equals(object rhsObj)
		{
			if (rhsObj == null)
				return false;
			
			if (GetType() != rhsObj.GetType())
				return false;
			
			NSPoint rhs = (NSPoint) rhsObj;
			return this == rhs;
		}
		
		public bool Equals(NSPoint rhs)
		{
			return this == rhs;
		}
		
		public static bool operator==(NSPoint lhs, NSPoint rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y;
		}
		
		public static bool operator!=(NSPoint lhs, NSPoint rhs)
		{
			return !(lhs == rhs);
		}
		
		public override int GetHashCode()
		{
			int hash;
			
			unchecked
			{
				hash = 3*x.GetHashCode() + 7*y.GetHashCode();
			}
			
			return hash;
		}
		
		public static readonly NSPoint Zero = new NSPoint(0.0f, 0.0f);
	}
	
	/// <summary>Wrapper around the Cocoa's NSSize struct.</summary>
	[Register("_NSSize")]
	[ThreadModel(ThreadModel.Serializable)]
	public struct NSSize : IEquatable<NSSize>, IFormattable
	{
		public float width;
		public float height;
		
		public NSSize(float width, float height)
		{
			this.width = width;
			this.height = height;
		}
		
		/// <summary>Returns width times height.</summary>
		public float Area
		{
			get {return width*height;}
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
					return string.Format("({0}, {1})", width, height);
				
				case "r":			// round trip version
				case "R":
					IFormatProvider invariant = CultureInfo.InvariantCulture.NumberFormat;
					return string.Format("{0}:{1}", width.ToString("R", invariant), height.ToString("R", invariant));
				
				default:
					string message = string.Format("{0} isn't a valid {1} format string.", format, GetType());
					throw new FormatException(message);
			}
		}
		
		/// <summary>Converts a round-trippable string back to the original value.</summary>
		/// <remarks>To get a round-trippable string use something like <c>size.ToString(&quot;R&quot;, null)</c>.</remarks>
		public static NSSize Parse(string text)
		{
			Contract.Requires(!string.IsNullOrEmpty(text), "text is null or empty");
			
			string[] fields = text.Split(':');
			if (fields.Length != 2)
			{
				string message = string.Format("{0} isn't a valid round trippable NSSize value.", text);
				throw new FormatException(message);
			}
			
			IFormatProvider format = CultureInfo.InvariantCulture.NumberFormat;
			return new NSSize(float.Parse(fields[0], format), float.Parse(fields[1], format));
		}
		
		public override bool Equals(object rhsObj)
		{
			if (rhsObj == null)
				return false;
			
			if (GetType() != rhsObj.GetType())
				return false;
		
			NSSize rhs = (NSSize) rhsObj;
			return this == rhs;
		}
			
		public bool Equals(NSSize rhs)
		{
			return this == rhs;
		}
		
		public static bool operator==(NSSize lhs, NSSize rhs)
		{
			return lhs.width == rhs.width && lhs.height == rhs.height;
		}
		
		public static bool operator!=(NSSize lhs, NSSize rhs)
		{
			return !(lhs == rhs);
		}
		
		public override int GetHashCode()
		{
			int hash;
			
			unchecked
			{
				hash = 3*width.GetHashCode() + 7*height.GetHashCode();
			}
			
			return hash;
		}
		
		public static readonly NSSize Zero = new NSSize(0.0f, 0.0f);
	}
	
	/// <summary>Wrapper around the Cocoa's NSRect struct.</summary>
	[Register("_NSRect")]
	[ThreadModel(ThreadModel.Serializable)]
	public struct NSRect : IEquatable<NSRect>, IFormattable
	{
		public NSPoint origin;
		public NSSize size;
		
		public NSRect(NSPoint origin, NSSize size)
		{
			this.origin = origin;
			this.size = size;
		}
		
		public NSRect(float x, float y, float width, float height)
		{
			origin = new NSPoint(x, y);
			size = new NSSize(width, height);
		}
		
		/// <summary>Returns origin.x.</summary>
		public float Left
		{
			get {return origin.x;}
		}
		
		/// <summary>Returns origin.y.</summary>
		public float Bottom
		{
			get {return origin.y;}
		}
		
		/// <summary>Returns origin.x + size.width.</summary>
		public float Right
		{
			get {return origin.x + size.width;}
		}
		
		/// <summary>Returns origin.y + size.height.</summary>
		public float Top
		{
			get {return origin.y + size.height;}
		}
		
		public NSPoint TopLeft
		{
			get {return new NSPoint(Left, Top);}
		}
		
		public NSPoint BottomRight
		{
			get {return new NSPoint(Right, Bottom);}
		}
		
		public NSPoint Center
		{
			get {return new NSPoint(origin.x + size.width/2.0f, origin.y + size.height/2.0f);}
		}
		
		[Pure]
		public bool Contains(NSPoint pt)
		{
			return pt.y >= Bottom && pt.y < Top && pt.x >= Left && pt.x < Right;
		}
		
		[Pure]
		public bool Contains(NSRect rect)
		{
			return rect.Bottom >= Bottom && rect.Top < Top && rect.Left >= Left && rect.Right < Right;
		}
		
		[Pure]
		public bool Intersects(NSRect rhs)
		{
			return Bottom <= rhs.Top && Top > rhs.Bottom && Left <= rhs.Right && Right > rhs.Left;
		}
		
		/// <summary>Returns the intersection of the two rectangles or Empty.</summary>
		[Pure]
		public NSRect Intersect(NSRect rhs)
		{
			float top = Math.Min(Top, rhs.Top);
			float left = Math.Max(Left, rhs.Left);
			float bottom = Math.Max(Bottom, rhs.Bottom);
			float right = Math.Min(Right, rhs.Right);
			
			NSRect result;
			if (left <= right && bottom <= top)
				result = new NSRect(left, bottom, right - left, top - bottom);
			else
				result = Empty;
			
			return result;
		}
		
		/// <summary>Returns the smallest rectangle enclosing the two rectangles.</summary>
		[Pure]
		public NSRect Union(NSRect rhs)
		{
			NSRect result;
			
			if (size == NSSize.Zero)
			{
				result = rhs;
			}
			else if (rhs.size == NSSize.Zero)
			{
				result = this;
			}
			else
			{
				float top = Math.Max(Top, rhs.Top);
				float left = Math.Min(Left, rhs.Left);
				float bottom = Math.Min(Bottom, rhs.Bottom);
				float right = Math.Max(Right, rhs.Right);
				
				result = new NSRect(left, bottom, right - left, top - bottom);
			}
			
			return result;
		}
		
		/// <summary>Indent (or outdent) each side of the rectangle by the specified amount.</summary>
		[Pure]
		public NSRect Inset(float dx, float dy)
		{
			float x, width;
			if (size.width > 2.0*dx)
			{
				x = origin.x + dx;
				width = size.width - 2.0f*dx;
			}
			else
			{
				x = origin.x + size.width/2.0f;
				width = 0.0f;
			}
			
			float y, height;
			if (size.height > 2.0*dy)
			{
				y = origin.y + dy;
				height = size.height - 2.0f*dy;
			}
			else
			{
				y = origin.y + size.height/2.0f;
				height = 0.0f;
			}
			
			return new NSRect(x, y, width, height);
		}
		
		/// <summary>Returns a new rectangle whose values have no fractional parts.</summary>
		/// <remarks>This works just like NSIntegralRect: if width or height is not positive then
		/// Empty is returned, otherwise the rectangle is expanded outward until the values are integral.</remarks>
		[Pure]
		public NSRect ToIntegral()
		{
			return NSIntegralRect(this);
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
					return string.Format("({0}, {1})", origin, size);
				
				case "r":			// round trip version
				case "R":
					return string.Format("{0};{1}", origin.ToString("R"), size.ToString("R"));
				
				default:
					string message = string.Format("{0} isn't a valid {1} format string.", format, GetType());
					throw new FormatException(message);
			}
		}
		
		/// <summary>Converts a round-trippable string back to the original value.</summary>
		/// <remarks>To get a round-trippable string use something like <c>frame.ToString(&quot;R&quot;, null)</c>.</remarks>
		public static NSRect Parse(string text)
		{
			Contract.Requires(!string.IsNullOrEmpty(text), "text is null or empty");
			
			string[] fields = text.Split(';');
			if (fields.Length != 2)
			{
				string message = string.Format("{0} isn't a valid round trippable NSRect value.", text);
				throw new FormatException(message);
			}
			
			return new NSRect(NSPoint.Parse(fields[0]), NSSize.Parse(fields[1]));
		}
		
		public override bool Equals(object rhsObj)
		{
			if (rhsObj == null)
				return false;
			
			if (GetType() != rhsObj.GetType())
				return false;
			
			NSRect rhs = (NSRect) rhsObj;
			return this == rhs;
		}
			
		public bool Equals(NSRect rhs)
		{
			return this == rhs;
		}
		
		public static bool operator==(NSRect lhs, NSRect rhs)
		{
			return lhs.origin == rhs.origin && lhs.size == rhs.size;
		}
		
		public static bool operator!=(NSRect lhs, NSRect rhs)
		{
			return !(lhs == rhs);
		}
		
		public override int GetHashCode()
		{
			int hash;
			
			unchecked
			{
				hash = 3*origin.GetHashCode() + 7*size.GetHashCode();
			}
			
			return hash;
		}
		
		public static readonly NSRect Empty = new NSRect(0.0f, 0.0f, 0.0f, 0.0f);
		
		[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
		[ThreadModel(ThreadModel.Concurrent)]
		private extern static NSRect NSIntegralRect(NSRect aRect);
	}
}
