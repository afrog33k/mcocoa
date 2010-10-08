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
using System.Xml;

// This class has mutators but it is thread safe because it is a struct (so
// every method that uses the struct will have its own copy).
[ThreadModel(ThreadModel.Concurrent)]
internal struct FractalSettings : IEquatable<FractalSettings>
{
	public FractalSettings(XmlNode node) : this()
	{
		Contract.Requires(node != null, "node is null");
		
		Area = int.Parse(node.Attributes["area"].Value);
		MaxDwell = ushort.Parse(node.Attributes["maxDwell"].Value);
		
		BigFloat left = BigFloat.Parse(node.Attributes["left"].Value);
		BigFloat right = BigFloat.Parse(node.Attributes["right"].Value);
		BigFloat top = BigFloat.Parse(node.Attributes["top"].Value);
		BigFloat bottom = BigFloat.Parse(node.Attributes["bottom"].Value);
		Extent = new Rect(left, top, right, bottom);
	}
	
	// Number of pixels.
	public int Area {get; set;}
	
	public int Width
	{
		get {return (int) Math.Sqrt((double) (Area*Extent.Width/Extent.Height));}
	}
	
	public int Height
	{
		get {return Area/Width;}
	}
	
	public ushort MaxDwell {get; set;}
	
	public Rect Extent {get; set;}
	
	public XmlElement GetXmlNode(XmlDocument doc)
	{
		XmlElement root  = doc.CreateElement("settings");
		root.SetAttribute("area", Area.ToString());
		root.SetAttribute("maxDwell", MaxDwell.ToString());
		root.SetAttribute("left", Extent.Left.ToString("R"));
		root.SetAttribute("right", Extent.Right.ToString("R"));
		root.SetAttribute("top", Extent.Top.ToString("R"));
		root.SetAttribute("bottom", Extent.Bottom.ToString("R"));
		
		return root;
	}
	
	public override string ToString()
	{
		var builder = new System.Text.StringBuilder();
		
		builder.Append("Origin: (");
		builder.Append(Extent.Left + Extent.Width/2);
		builder.Append(", ");
		builder.Append(Extent.Bottom + Extent.Height/2);
		builder.AppendLine(")");
		
		builder.Append("Size: (");
		builder.Append(Extent.Width);
		builder.Append(", ");
		builder.Append(Extent.Height);
		builder.AppendLine(")");
		
		builder.Append("Area: ");
		builder.Append(Area);
		builder.AppendLine();
		
		builder.Append("MaxDwell: ");
		builder.Append(MaxDwell);
		builder.AppendLine();
		
		return builder.ToString();
	}
	
	#region Equatable Support
	public override bool Equals(object obj)
	{
		if (obj == null)
			return false;
		
		if (GetType() != obj.GetType())
			return false;
		
		FractalSettings rhs = (FractalSettings) obj;
		return this == rhs;
	}
	
	public bool Equals(FractalSettings rhs)
	{
		return this == rhs;
	}
	
	public static bool operator==(FractalSettings lhs, FractalSettings rhs)
	{
		if (lhs.Area != rhs.Area)
			return false;
		
		if (lhs.MaxDwell != rhs.MaxDwell)
			return false;
		
		if (lhs.Extent != rhs.Extent)
			return false;
		
		return true;
	}
	
	public static bool operator!=(FractalSettings lhs, FractalSettings rhs)
	{
		return !(lhs == rhs);
	}
	
	public override int GetHashCode()
	{
		int hash = 0;
		
		unchecked
		{
			hash += Area.GetHashCode();
			hash += MaxDwell.GetHashCode();
			hash += Extent.GetHashCode();
		}
		
		return hash;
	}
	#endregion
}
