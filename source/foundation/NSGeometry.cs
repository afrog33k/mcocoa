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
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace MCocoa
{
	[Register("_NSPoint")]
	public struct NSPoint : IEquatable<NSPoint>
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
		
		public override string ToString()
		{
			return ToString("G", null);
		}
		
		public string ToString(string format)
		{
			return ToString(format, null);
		}
		
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
		
		public static NSPoint Parse(string text)
		{
			Trace.Assert(!string.IsNullOrEmpty(text), "text is null or empty");
			
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
	
	[Register("_NSSize")]
	public struct NSSize : IEquatable<NSSize>
	{
		public float width;
		public float height;
		
		public NSSize(float width, float height)
		{
			this.width = width;
			this.height = height;
		}
		
		public override string ToString()
		{
			return ToString("G", null);
		}
		
		public string ToString(string format)
		{
			return ToString(format, null);
		}
		
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
		
		public static NSSize Parse(string text)
		{
			Trace.Assert(!string.IsNullOrEmpty(text), "text is null or empty");
			
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
	
	[Register("_NSRect")]
	public struct NSRect : IEquatable<NSRect>
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
		
		public NSPoint Center
		{
			get {return new NSPoint(origin.x + size.width/2.0f, origin.y + size.height/2.0f);}
		}
	
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
		
		public static NSRect Parse(string text)
		{
			Trace.Assert(!string.IsNullOrEmpty(text), "text is null or empty");
			
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
		private extern static NSRect NSIntegralRect(NSRect aRect);
	}
}
