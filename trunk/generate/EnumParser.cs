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

internal sealed class EnumParser : Parser
{
	public EnumParser(string path, string text) : base(path, text)
	{	
	}
	
	public bool AtEnd 
	{
		get {return Enum == null;}
	}
	
	public NativeEnum Enum {get; private set;}
	
	public override void Advance()
	{
		Enum = null;
		
		while (!m_tokenizer.AtEnd && Enum == null)
		{
			while (!m_tokenizer.AtEnd && m_tokenizer.Token != "enum")
				m_tokenizer.Advance();
				
			if (!m_tokenizer.AtEnd)
			{
				Enum = new NativeEnum();
				DoParseEnum();
			}
		}
	}
	
	// Enum := 'enum' Name? '{' Items '}' DEPRECATED_IN_XXX? ';'
	private void DoParseEnum()
	{
		m_tokenizer.Advance();
	
		if (m_tokenizer.Token != "{")
			Enum.Name = DoParseName();

		DoParseSymbol('{');
		
		List<string> names = new List<string>();
		List<string> values = new List<string>();
		DoParseItems(names, values);
		Enum.Names = names.ToArray();
		Enum.Values = values.ToArray();
		
		DoParseSymbol('}');
		if (m_tokenizer.Token != ";")
		{
			string name = DoParseName();
			if (name.StartsWith("DEPRECATED"))
				Enum = null;
			else 						// typedef case
				Enum.Name = name;
		}
		
		DoParseSymbol(';');
	}
				
	// Items := Item (',' Item)*
	private void DoParseItems(List<string> names, List<string> values)
	{
		DoParseItem(names, values);
		while ("," == m_tokenizer.Token)
		{
			m_tokenizer.Advance();
			if ("}" != m_tokenizer.Token)
				DoParseItem(names, values);
		}
	}
				
	// Item := Name ('=' Value)?
	private void DoParseItem(List<string> names, List<string> values)
	{
		names.Add(DoParseName());

		if ("=" == m_tokenizer.Token)
		{
			m_tokenizer.Advance();
			values.Add(DoParseValue());
		}
		else
			values.Add(string.Empty);
	}
	
	private string DoParseValue()
	{
		string result = string.Empty;

		while (!m_tokenizer.AtEnd && m_tokenizer.Token != "," && m_tokenizer.Token != "}")
		{							
			result += m_tokenizer.Token + " ";
			m_tokenizer.Advance();
		}

		return result.Trim();
	}
}

