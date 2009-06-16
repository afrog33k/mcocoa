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
using System.Runtime.InteropServices;

#if LIBGMP
internal struct mpf_struct		// this is actually named __mpf_struct, but that is just too grotendrous
{
	public int _mp_prec;
	public int _mp_size;
	public int _mp_exp;
	public IntPtr _mp_d;
}

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
	
	~BigFloat()
	{
		mpf_clear(ref m_value);
	}
	
	private BigFloat(mpf_struct value, float precision)
	{
		++ms_instances;
		
		m_precision = precision;
		m_value = value;
	}
	
	private BigFloat(double value) : this(value, DoublePrecision)
	{
	}
	
	private BigFloat(double value, float precision)
	{
		++ms_instances;
		
#if false
		var stack = new System.Diagnostics.StackTrace(1);
		Console.WriteLine("\n{0}", ms_instances);
		for (int i = 0; i < Math.Min(6, stack.FrameCount); ++i)
		{
			Console.WriteLine("   {0}|{1}", stack.GetFrame(i).GetMethod().DeclaringType, stack.GetFrame(i).GetMethod());
		}
#endif
		
		m_precision = precision;
		mpf_init2(out m_value, (uint) m_precision);
		mpf_set_d(ref m_value, value);
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
		return mpf_get_d(ref value.m_value);
	}
	
	public static implicit operator mpf_struct(BigFloat value)
	{
		return value.m_value;
	}
	
	public BigFloat Add(BigFloat rhs, float precision)
	{
		mpf_struct result;
		mpf_init2(out result, (uint) precision);
		mpf_add(ref result, ref m_value, ref rhs.m_value);
		
		return new BigFloat(result, precision);
	}
	
	public BigFloat Sub(BigFloat rhs, float precision)
	{
		mpf_struct result;
		mpf_init2(out result, (uint) precision);
		mpf_sub(ref result, ref m_value, ref rhs.m_value);
		
		return new BigFloat(result, precision);
	}
	
	public static BigFloat operator+(BigFloat lhs, BigFloat rhs)
	{
		float precision = Math.Max(lhs.m_precision, rhs.m_precision);
		
		mpf_struct result;
		mpf_init2(out result, (uint) precision);
		mpf_add(ref result, ref lhs.m_value, ref rhs.m_value);
		
		return new BigFloat(result, precision);
	}
	
	public static BigFloat operator-(BigFloat lhs, BigFloat rhs)
	{
		float precision = Math.Max(lhs.m_precision, rhs.m_precision);
		
		mpf_struct result;
		mpf_init2(out result, (uint) precision);
		mpf_sub(ref result, ref lhs.m_value, ref rhs.m_value);
		
		return new BigFloat(result, precision);
	}
	
	public static BigFloat operator*(BigFloat lhs, BigFloat rhs)
	{
		float precision = Math.Max(lhs.m_precision, rhs.m_precision);
		
		mpf_struct result;
		mpf_init2(out result, (uint) precision);
		mpf_mul(ref result, ref lhs.m_value, ref rhs.m_value);
		
		return new BigFloat(result, precision);
	}
	
	public static BigFloat operator/(BigFloat lhs, BigFloat rhs)
	{
		float precision = Math.Max(lhs.m_precision, rhs.m_precision);
		
		mpf_struct result;
		mpf_init2(out result, (uint) precision);
		mpf_div(ref result, ref lhs.m_value, ref rhs.m_value);
		
		return new BigFloat(result, precision);
	}
	
	#region Convenience Operators
	public static BigFloat operator*(double lhs, BigFloat rhs)
	{
		float precision = rhs.m_precision;
		const double Scaling = 3.4;			// 3.321928 would be log2 but that sometimes gives us artifacts just before we add gmp limbs
		
		double alhs = Math.Abs(lhs);
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
		
		BigFloat left = new BigFloat(lhs, precision);
		
		mpf_struct result;
		mpf_init2(out result, (uint) precision);
		mpf_mul(ref result, ref left.m_value, ref rhs.m_value);
		
		return new BigFloat(result, precision);
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
				int exponent = 0;
				IntPtr result = mpf_get_str(IntPtr.Zero, ref exponent, 10, 0, ref m_value);
				string str = Marshal.PtrToStringAnsi(result);
				Marshal.FreeHGlobal(result);
				if (str.Length == 0 && exponent == 0)
					return "0.0@0";
				else if (str[0] == '-')
					return string.Format("{0}.{1}@{2}", str.Substring(0, 2), str.Substring(2), exponent - 1);
				else
					return string.Format("{0}.{1}@{2}", str[0], str.Substring(1), exponent - 1);
				
			case "f":
			case "F":
				return string.Format("{0}{1}{2}/{3}{4}", ToString("G", null), '{', mpf_get_prec(ref m_value), (uint) m_precision, '}');
			
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
		string s1 = str.Substring(0, i);
		string s2 = str.Substring(i + 1);
		
		float precision = float.Parse(s2);
		mpf_struct value;
		mpf_init2(out value, (uint) precision);
		
		int result = mpf_set_str(ref value, s1, 10);
		if (result != 0)
			throw new ArgumentException("Invalid float: " + str);
		
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
		
		int result = mpf_cmp(ref lhs.m_value, ref rhs.m_value);
		return result == 0;
	}
	
	public static bool operator!=(BigFloat lhs, BigFloat rhs)
	{
		return !(lhs == rhs);
	}
	
	public override int GetHashCode()
	{
		// I think the only way to implement this is using the string rep which kind of blows.
		throw new NotSupportedException();
	}
	#endregion
	
	#region P/Invokes
	// Note that we have to compile libgmp with -m32 so that mono can load the library.
	// This means that native longs are 32 bits.
	[DllImport("gmp", EntryPoint = "__gmpf_add")]
	private extern static void mpf_add(ref mpf_struct rop, ref mpf_struct op1, ref mpf_struct op2);
	
	[DllImport("gmp", EntryPoint = "__gmpf_clear")]
	private extern static void mpf_clear(ref mpf_struct x);
	
	[DllImport("gmp", EntryPoint = "__gmpf_cmp")]
	private extern static int mpf_cmp(ref mpf_struct op1, ref mpf_struct op2);
	
	[DllImport("gmp", EntryPoint = "__gmpf_div")]
	private extern static void mpf_div(ref mpf_struct rop, ref mpf_struct op1, ref mpf_struct op2);
	
	[DllImport("gmp", EntryPoint = "__gmpf_get_d")]
	private extern static double mpf_get_d(ref mpf_struct op);
	
	[DllImport("gmp", EntryPoint = "__gmpf_get_prec")]
	private extern static uint mpf_get_prec(ref mpf_struct op);
	
	[DllImport("gmp", EntryPoint = "__gmpf_get_str")]
	private extern static IntPtr mpf_get_str(IntPtr str, ref int expptr, int radix, int digits, ref mpf_struct op);
	
	[DllImport("gmp", EntryPoint = "__gmpf_init2")]
	private extern static void mpf_init2(out mpf_struct x, uint prec);
	
	[DllImport("gmp", EntryPoint = "__gmpf_mul")]
	private extern static void mpf_mul(ref mpf_struct rop, ref mpf_struct op1, ref mpf_struct op2);
	
	[DllImport("gmp", EntryPoint = "__gmpf_set_d")]
	private extern static void mpf_set_d(ref mpf_struct rop, double op);
	
	[DllImport("gmp", EntryPoint = "__gmpf_set_str")]
	private extern static int mpf_set_str(ref mpf_struct rop, string str, int radix);
	
	[DllImport("gmp", EntryPoint = "__gmpf_sub")]
	private extern static void mpf_sub(ref mpf_struct rop, ref mpf_struct op1, ref mpf_struct op2);
	#endregion
	
	#region Fields
	private const float DoublePrecision = 1;
	
	private mpf_struct m_value;
	private float m_precision;
	
	private static ulong ms_instances;
	#endregion
}
#endif 	// LIBGMP
