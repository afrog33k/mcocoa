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

internal sealed class NativeMethod
{
	public bool IsClass {get; set;}
	
	// Something like "decodeClassName:asClassName:".
	public string Name {get; set;}
	
	// Something like "void", "NSDate *", etc.
	public string ReturnType {get; set;}
	
	// May be empty.
	public string[] ArgNames {get; set;}
	
	// May be empty.
	public string[] ArgTypes {get; set;}
	
	// May be null.
	public string Obsolete {get; set;}
	
	public override string ToString()
	{
		string result = string.Empty;		// debugging code so we won't bother with StringBuilder
		
		result += IsClass ? "+" : "-";
		
		result += " (" + ReturnType + ")";
		result += Name + " ";
		
		for (int i = 0; i < ArgNames.Length; ++i)
			result += "(" + ArgTypes[i] + ")" + ArgNames[i] + " ";
			
		return result;
	}
}
