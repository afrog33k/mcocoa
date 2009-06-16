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

using System;

#if !LIBGMP
// We could make this a struct but that shouldn't make much of a difference
// because we don't create BigFloats inside inner loops and we want to avoid
// gratuitous differences with the gmp code.
internal sealed class BigFloat : IFormattable, IEquatable<BigFloat>
{
	// We don't want to use doubles for our math so we don't allow BigFloats
	// to be constructed from arbitrary doubles.
	public static readonly BigFloat Bailout = new BigFloat(512.0);
	public static readonly BigFloat Zero = new BigFloat(0.0);
	
	public static readonly BigFloat DefaultLeft = new BigFloat(-1.9);
	public static readonly BigFloat DefaultRight = new BigFloat(0.6);
	public static readonly BigFloat DefaultTop = new BigFloat(1.2);
	public static readonly BigFloat DefaultBottom = new BigFloat(-1.2);
	
	private BigFloat(double value) : this(value, DoublePrecision)
	{
	}
	
	private BigFloat(double value, float precision)
	{
		++ms_instances;
		
		m_value = value;
		m_precision = precision;
	}
	
	public static ulong InstanceCount
	{
		get {return ms_instances;}
	}
	
	public float Precision
	{
		get {return m_precision;}
	}
	
	public static explicit operator double(BigFloat value)
	{
		return value.m_value;
	}
	
	public BigFloat Add(BigFloat rhs, float precision)
	{
		return new BigFloat(m_value + rhs.m_value, precision);
	}
	
	public BigFloat Sub(BigFloat rhs, float precision)
	{
		return new BigFloat(m_value - rhs.m_value, precision);
	}
	
	public static BigFloat operator+(BigFloat lhs, BigFloat rhs)
	{
		float precision = Math.Max(lhs.m_precision, rhs.m_precision);
		
		return new BigFloat(lhs.m_value + rhs.m_value, precision);
	}
	
	public static BigFloat operator-(BigFloat lhs, BigFloat rhs)
	{
		float precision = Math.Max(lhs.m_precision, rhs.m_precision);
		
		return new BigFloat(lhs.m_value - rhs.m_value, precision);
	}
	
	public static BigFloat operator*(BigFloat lhs, BigFloat rhs)
	{
		float precision = Math.Max(lhs.m_precision, rhs.m_precision);
		
		return new BigFloat(lhs.m_value * rhs.m_value, precision);
	}
	
	public static BigFloat operator/(BigFloat lhs, BigFloat rhs)
	{
		float precision = Math.Max(lhs.m_precision, rhs.m_precision);
		
		return new BigFloat(lhs.m_value / rhs.m_value, precision);
	}
	
	#region Convenience Operators
	public static BigFloat operator*(double lhs, BigFloat rhs)
	{
		float precision = rhs.m_precision;
		const double Scaling = 3.4;			// 3.321928 would be log2 but that sometimes gives us artifacts just before we add gmp limbs
		
		double alhs = Math.Abs(lhs);			// TODO: should use a common method for this
		if (lhs > 0.0 && alhs < 1.0)
		{
			// Increase the precision (log will return negative numbers for lhs < 1.0)
			precision -= (float) (Scaling*Math.Log10(alhs));
		}
		else if (alhs > 1.0)
		{
			// Decrease the precision (log will return positive numbers for lhs > 1.0)
			precision = (float) Math.Max(precision - Scaling*Math.Log10(alhs), 1.0);
		}
		
		return new BigFloat(lhs * rhs.m_value, precision);
	}
	
	public static BigFloat operator*(BigFloat lhs, int rhs)
	{
		return lhs*(new BigFloat((double) rhs));
	}
	
	public static BigFloat operator/(BigFloat lhs, int rhs)
	{
		return lhs/(new BigFloat((double) rhs));
	}
	
	public static BigFloat operator/(int lhs, BigFloat rhs)
	{
		return new BigFloat(lhs) / rhs;
	}
	
	public static BigFloat operator-(BigFloat rhs)
	{
		return Zero - rhs;
	}
	#endregion
	
	#region String Conversions
	public override string ToString()
	{
		return ToString("G", null);
	}
	
	public string ToString(string format)
	{
		return ToString(format, null);
	}
	
	// G - returns something like 3.14@0
	// F - returns something like 3.14@0{32/20} (where the 32 is the gmp precision in bits and 20 is our precision)
	// R - returns something like 3.14@0:20.12 (where the 20.12 is our precision)
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
				return m_value.ToString("E16").Replace('E', '@');
				
			case "f":
			case "F":
				return string.Format("{0}{1}{2}/{3}{4}", ToString("G", null), '{', 64, (uint) m_precision, '}');
			
			case "r":
			case "R":
				return string.Format("{0}:{1:0.00}", ToString("G", null), m_precision);
			
			default:	// might want to support "0.000" format
				string message = string.Format("{0} isn't a valid {1} format string.", format, GetType());
				throw new FormatException(message);
		}
	}
	
	public static BigFloat Parse(string str)
	{
		if (!str.Contains("@"))
			throw new ArgumentException("Invalid BigFloat string: " + str);
		if (!str.Contains(":"))
			throw new ArgumentException("Invalid BigFloat string: " + str);
			
		int i = str.IndexOf(':');
		string s1 = str.Substring(0, i).Replace('@', 'E');
		string s2 = str.Substring(i + 1);
		
		double value = double.Parse(s1);
		float precision = float.Parse(s2);
		
		return new BigFloat(value, precision);
	}
	#endregion
	
	#region Equality
	public override bool Equals(object obj)
	{
		if (obj == null)
			return false;
		
		BigFloat rhs = obj as BigFloat;
		return this == rhs;
	}
	
	public bool Equals(BigFloat rhs)
	{
		return this == rhs;
	}
	
	public static bool operator==(BigFloat lhs, BigFloat rhs)
	{
		if (object.ReferenceEquals(lhs, rhs))
			return true;
		
		if ((object) lhs == null || (object) rhs == null)
			return false;
		
		return lhs.m_value == rhs.m_value;
	}
	
	public static bool operator!=(BigFloat lhs, BigFloat rhs)
	{
		return !(lhs == rhs);
	}
	
	public override int GetHashCode()
	{
		// gmp doesn't support this so neither do we.
		throw new NotSupportedException();
	}
	#endregion
	
	#region Fields
	private const float DoublePrecision = 1;
	
	private double m_value;
	private float m_precision;		// we need to track this so that saved documents work properly when opened with gmp versions
	
	private static ulong ms_instances;
	#endregion
}
#endif 	// !LIBGMP
