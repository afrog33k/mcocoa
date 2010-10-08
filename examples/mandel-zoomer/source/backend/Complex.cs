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

using MObjc.Helpers;
using System;

[ThreadModel(ThreadModel.Concurrent)]
internal struct Complex : IEquatable<Complex>
{
	public Complex(BigFloat x, BigFloat y) : this()
	{
		X = x;
		Y = y;
	}
	
	public BigFloat X {get; private set;}
	
	public BigFloat Y {get; private set;}
	
	public override string ToString()
	{
		return string.Format("({0}, {1})", X, Y);
	}
	
	#region Equatable Support
	public override bool Equals(object obj)
	{
		if (obj == null)
			return false;
		
		if (GetType() != obj.GetType())
			return false;
		
		Complex rhs = (Complex) obj;
		return this == rhs;
	}
	
	public bool Equals(Complex rhs)
	{
		return this == rhs;
	}
	
	public static bool operator==(Complex lhs, Complex rhs)
	{
		if (lhs.X != rhs.X)
			return false;
		
		if (lhs.Y != rhs.Y)
			return false;
		
		return true;
	}
	
	public static bool operator!=(Complex lhs, Complex rhs)
	{
		return !(lhs == rhs);
	}
	
	public override int GetHashCode()
	{
		int hash = 0;
		
		unchecked
		{
			hash += X.GetHashCode();
			hash += Y.GetHashCode();
		}
		
		return hash;
	}
	#endregion
}
