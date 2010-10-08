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
internal struct Rect : IEquatable<Rect>
{
	public Rect(BigFloat left, BigFloat top, BigFloat right, BigFloat bottom) : this()
	{
		TopLeft = new Complex(left, top);
		BottomRight = new Complex(right, bottom);
	}
	
	public Rect(Complex topLeft, Complex botRight) : this()
	{
		TopLeft = topLeft;
		BottomRight = botRight;
	}
	
	public Complex TopLeft {get; private set;}
	
	public Complex BottomRight {get; private set;}
	
	public Complex Center
	{
		get {return new Complex(Left + Width/2, Bottom + Height/2);}
	}
	
	public BigFloat Top
	{
		get {return TopLeft.Y;}
	}
	
	public BigFloat Bottom
	{
		get {return BottomRight.Y;}
	}
	
	public BigFloat Left
	{
		get {return TopLeft.X;}
	}
	
	public BigFloat Right
	{
		get {return BottomRight.X;}
	}
	
	public BigFloat Width
	{
		get {return Right - Left;}
	}
	
	public BigFloat Height
	{
		get {return Top - Bottom;}
	}
	
	public Rect Offset(BigFloat dx, BigFloat dy)
	{
		Complex topLeft = new Complex(TopLeft.X + dx, TopLeft.Y + dy);
		Complex botRight = new Complex(BottomRight.X + dx, BottomRight.Y + dy);
		
		return new Rect(topLeft, botRight);
	}
	
#if false
	public Rect Inset(BigFloat dx, BigFloat dy)
	{
		Complex topLeft = new Complex(Left + dx, Top - dy);
		Complex botRight = new Complex(Right - dx, Bottom + dy);
		
		return new Rect(topLeft, botRight);
	}
	
	public Rect Inset(BigFloat dx, BigFloat dy, float precision)
	{
		Complex topLeft = new Complex(Left.Add(dx, precision), Top.Sub(dy, precision));
		Complex botRight = new Complex(Right.Sub(dx, precision), Bottom.Add(dy, precision));
		
		return new Rect(topLeft, botRight);
	}
#endif

	public override string ToString()
	{
		return string.Format("[{0}, {1}]", TopLeft, BottomRight);
	}
	
	#region Equatable Support
	public override bool Equals(object obj)
	{
		if (obj == null)
			return false;
		
		if (GetType() != obj.GetType())
			return false;
		
		Rect rhs = (Rect) obj;
		return this == rhs;
	}
	
	public bool Equals(Rect rhs)
	{
		return this == rhs;
	}
	
	public static bool operator==(Rect lhs, Rect rhs)
	{
		if (lhs.TopLeft != rhs.TopLeft)
			return false;
		
		if (lhs.BottomRight != rhs.BottomRight)
			return false;
		
		return true;
	}
	
	public static bool operator!=(Rect lhs, Rect rhs)
	{
		return !(lhs == rhs);
	}
	
	public override int GetHashCode()
	{
		int hash = 0;
		
		unchecked
		{
			hash += TopLeft.GetHashCode();
			hash += BottomRight.GetHashCode();
		}
		
		return hash;
	}
	#endregion
}
