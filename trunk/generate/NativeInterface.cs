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

using System;
using System.Collections.Generic;

internal sealed class NativeInterface
{
	public string Name {get; set;}
	
	// Will be null if Category is not null.
	public string BaseName {get; set;}
	
	// May be empty.
	public string[] Protocols {get; set;}
	
	// May be null.
	public string Category {get; set;}
	
	public List<NativeMethod> Methods
	{
		get {return m_methods;}
	}
	
	public void Add(NativeMethod method)
	{
		m_methods.Add(method);
	}
	
	public override string ToString()
	{
		string result = "@interface " + Name;		// debugging code so we won't bother with StringBuilder
		
		if (BaseName != null)
			result += " : " + BaseName;
			
		if (Protocols.Length > 0)
			result += " <" + string.Join(", ", Protocols) + ">";
			
		if (Category != null)
			result += " (" + Category + ")";
			
		return result;
	}
	
	private List<NativeMethod> m_methods = new List<NativeMethod>();
}
