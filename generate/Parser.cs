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

internal abstract class Parser
{
	protected Parser(string path, string text)
	{	
		m_tokenizer = new Tokenizer(path, text);
		
		if (!m_tokenizer.AtEnd)
			Advance();
	}
	
	public abstract void Advance();
		
	// Method := ('-' | '+') '(' Type ')' MethodFragment+ macro? ';'
	protected NativeMethod DoParseMethod()
	{
		NativeMethod method = null;
		
		string token = m_tokenizer.Token;
		m_tokenizer.Advance();
		
		if ("(" == m_tokenizer.Token)
		{
			m_tokenizer.Advance();
			
			method = new NativeMethod();
			method.IsClass = token == "+";
			method.Name = string.Empty;
			method.ReturnType = DoParseParensBody();
			DoParseSymbol(')');

			bool deprecated = false;
			var argNames = new List<string>();
			var argTypes = new List<string>();
			while (!m_tokenizer.AtEnd && m_tokenizer.Token != ";")
			{
				string name = DoParseMethodFragment(argNames, argTypes);
				if (name.StartsWith("DEPRECATED"))
					deprecated = true;
				else if (!name.StartsWith("NS_REQUIRES"))
					method.Name += name;
			}
			method.ArgNames = argNames.ToArray();
			method.ArgTypes = argTypes.ToArray();

			DoParseSymbol(';');
			
			if (deprecated)
				method = null;
		}
		
		return method;
	}
	
	// MethodFragment := (Name '(' Type ')' Name) | (',' '...')
	private string DoParseMethodFragment(List<string> argNames, List<string> argTypes)
	{
		string mname = string.Empty;
		
		if ("," == m_tokenizer.Token)
		{
			m_tokenizer.Advance();

			DoParseLiteral("...");
			argTypes.Add("...");
			argNames.Add(string.Empty);
		}
		else
		{
			mname = DoParseMethodName();				// range:(NSRange)aRange
			
			if ("(" == m_tokenizer.Token)
			{
				m_tokenizer.Advance();
				argTypes.Add(DoParseParensBody());
				DoParseSymbol(')');
	
				argNames.Add(DoParseName());
			}
		}
		
		return mname;
	}
	
	private string DoParseParensBody()
	{
		string result = string.Empty;

		int nesting = 1;		
		while (!m_tokenizer.AtEnd)
		{			
			if ("(" == m_tokenizer.Token)
				++nesting;
			else if (")" == m_tokenizer.Token)
				--nesting;
			
			if (nesting == 0)
				break;
				
			result += m_tokenizer.Token + " ";
			m_tokenizer.Advance();
		}

		return result.Trim();
	}
	
	// NameList := Name (',' Name)*
	protected string[] DoParseNameList()
	{
		List<string> names = new List<string>();
		
		names.Add(DoParseName());
		while ("," == m_tokenizer.Token)
		{
			m_tokenizer.Advance();
			names.Add(DoParseName());
		}
		
		return names.ToArray();
	}
	
	protected string DoParseName()
	{
		string name = m_tokenizer.Token;
		
		if (!char.IsLetter(name[0]) && name[0] != '_')
			throw new Exception(string.Format("Expected a name. {0}", m_tokenizer));
		for (int i = 1; i < name.Length; ++i)
			if (!char.IsLetterOrDigit(name[i]) && name[i] != '_')
				throw new Exception(string.Format("Expected a name. {0}", m_tokenizer));
			
		m_tokenizer.Advance();
		
		return name;
	}
	
	protected string DoParseMethodName()
	{
		string name = DoParseName();
		
		if (m_tokenizer.Token == ":")
		{
			name += ":";
			m_tokenizer.Advance();
		}

		return name;
	}
	
	protected void DoParseLiteral(string text)
	{
		if (m_tokenizer.Token != text)
			throw new Exception(string.Format("Expected '{0}'. {1}", text, m_tokenizer));
					
		m_tokenizer.Advance();
	}
	
	protected void DoParseSymbol(char symbol)
	{
		if (m_tokenizer.Token.Length > 1)
			throw new Exception(string.Format("Expected '{0}'. {1}", symbol, m_tokenizer));

		if (m_tokenizer.Token[0] != symbol)
			throw new Exception(string.Format("Expected '{0}'. {1}", symbol, m_tokenizer));
					
		m_tokenizer.Advance();
	}
				
	protected Tokenizer m_tokenizer;
}

