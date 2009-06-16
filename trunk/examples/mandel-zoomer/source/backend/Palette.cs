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
using System.Collections.Generic;
using System.Xml;

// Dwells are assigned an interpolated color using a palette.
internal sealed class Palette
{
	public Palette(string name, XmlDocument doc)
	{
		Contract.Requires(!string.IsNullOrEmpty(name), "name is null or empty");
		Contract.Requires(doc != null, "doc is null");
		
		m_name = name;
		DoParseRoot(doc);
	}
	
	public Palette(string name, XmlNode node)
	{
		Contract.Requires(!string.IsNullOrEmpty(name), "name is null or empty");
		Contract.Requires(node != null, "node is null");
		
		m_name = name;
		DoParsePalette(node);
	}
	
	private Palette(Palette rhs)
	{
		m_name = rhs.m_name;
		m_colors = rhs.m_colors;
	}
	
	public string Name
	{
		get {return m_name;}
	}
	
	public int Length
	{
		get {return m_colors.Length;}
	}
	
	public ColorStop this[int index]
	{
		get {return m_colors[index];}
	}
	
	public Color Interpolate(double x, double exponent)	// could use a pre-computed lookup table here
	{
		Contract.Requires(x >= 0.0 && x <= 1.0, "x is oor: " + x);
		
		byte r = 0, g = 0, b = 0;
		x = Math.Pow(x, 1.0/exponent);
		
		int i = DoGetColorStop(x);
		if (i + 1 < m_colors.Length)
		{
			double fraction = (x - m_colors[i].Location)/(m_colors[i + 1].Location - m_colors[i].Location);
			
			r = (byte) ((1.0 - fraction)*m_colors[i].Color.Red + fraction*m_colors[i + 1].Color.Red);
			g = (byte) ((1.0 - fraction)*m_colors[i].Color.Green + fraction*m_colors[i + 1].Color.Green);
			b = (byte) ((1.0 - fraction)*m_colors[i].Color.Blue + fraction*m_colors[i + 1].Color.Blue);
		}
		else
		{
			r = m_colors[i].Color.Red;
			g = m_colors[i].Color.Green;
			b = m_colors[i].Color.Blue;
		}
		
		return new Color(r, g, b);
	}
	
	public XmlDocument GetXmlDoc()
	{
		XmlDocument doc = new XmlDocument();
		
		XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);
		doc.InsertBefore(xmlDeclaration, doc.DocumentElement);
		
		XmlElement root  = GetXmlNode(doc);
		doc.AppendChild(root);
		
		return doc;
	}
	
	public XmlElement GetXmlNode(XmlDocument doc)
	{
		XmlElement root  = doc.CreateElement("palette");
		
		foreach (ColorStop stop in m_colors)
		{
			XmlElement child  = doc.CreateElement("color");
			child.SetAttribute("location", string.Format("{0:0.000}", stop.Location));
			child.SetAttribute("red", string.Format("{0:0.000}", stop.Color.Red/255.0f));
			child.SetAttribute("green", string.Format("{0:0.000}", stop.Color.Green/255.0f));
			child.SetAttribute("blue", string.Format("{0:0.000}", stop.Color.Blue/255.0f));
			
			root.AppendChild(child);
		}
		
		return root;
	}
	
	#region Mutators
	public Palette SetName(string name)
	{
		Palette result = new Palette(this);
		
		result.m_name = name;
		
		return result;
	}
	#endregion
	
	#region Private Methods
	private int DoGetColorStop(double x)	// could use a binary search here but I don't know if it would matter
	{
		for (int i = 0; i < m_colors.Length - 1; ++i)
		{
			if (m_colors[i + 1].Location > x)
				return i;
		}
		
		return m_colors.Length - 1;
	}
	
	private void DoParseRoot(XmlDocument doc)
	{
		foreach (XmlNode child in doc.ChildNodes)
		{
			if (child.Name == "palette")
			{
				DoParsePalette(child);
			}
		}
	}
	
	private void DoParsePalette(XmlNode parent)
	{
		var colors = new List<ColorStop>();
		
		foreach (XmlNode child in parent.ChildNodes)
		{
			if (child.Name == "color")
			{
				colors.Add(DoParseColor(child));
			}
		}
		
		m_colors = colors.ToArray();
	}
	
	private ColorStop DoParseColor(XmlNode node)
	{
		return new ColorStop(
			float.Parse(node.Attributes["location"].Value),
			(byte) (255*float.Parse(node.Attributes["red"].Value)),
			(byte) (255*float.Parse(node.Attributes["green"].Value)),
			(byte) (255*float.Parse(node.Attributes["blue"].Value)));
	}
	#endregion
	
	#region Fields
	private string m_name;
	private ColorStop[] m_colors;
	#endregion
}
