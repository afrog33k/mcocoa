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

internal sealed class Tokenizer
{
	public Tokenizer(string path, string text)
	{		
		m_path = path;
		m_text = text;
		
		if (!AtEnd)
			Advance();
	}
	
	public string Path
	{
		get {return m_path;}
	}

	public bool AtEnd 
	{
		get {return m_token == null && m_index >= m_text.Length;}
	}
	
	public string Token
	{
		get {return m_token;}
	}

	public void Advance()
	{		
		DoSkipWhiteSpace();
		
		if (m_index < m_text.Length)
			DoGetToken();
		else
			m_token = null;
	}
	
	public override string ToString()
	{
		return string.Format("File: {0}:{1}, Token: {2}.", m_path, m_line, m_token);
	}
	
	private void DoGetToken()
	{
		int len = 0;
		
		if (m_index < m_text.Length && (m_text[m_index] == '@' || m_text[m_index] == '#' || m_text[m_index] == '_' || char.IsLetter(m_text[m_index])))
		{
			++len;
			while (m_index+len < m_text.Length && (char.IsLetterOrDigit(m_text[m_index+len]) || m_text[m_index+len] == '_'))
				++len;
		}
		else if (m_index < m_text.Length && (char.IsDigit(m_text[m_index]) || m_text[m_index] == '-'))
		{
			++len;
			while (m_index+len < m_text.Length && (char.IsLetterOrDigit(m_text[m_index+len])))
				++len;
		}
		else if (m_index < m_text.Length && m_text[m_index] == '.')
		{
			++len;
			while (m_index+len < m_text.Length && m_text[m_index+len] == '.')
				++len;
		}
		else if (m_index < m_text.Length && m_text[m_index] == '<')
		{
			++len;
			while (m_index+len < m_text.Length && m_text[m_index+len] == '<')
				++len;
		}
		else if (m_index < m_text.Length && m_text[m_index] == '>')
		{
			++len;
			while (m_index+len < m_text.Length && m_text[m_index+len] == '>')
				++len;
		}
		else if (m_index < m_text.Length && m_text[m_index] == '*')
		{
			++len;
			while (m_index+len < m_text.Length && m_text[m_index+len] == '*')
				++len;
		}
		else
		{
			++len;
		}
			
		m_token = m_text.Substring(m_index, len);
		m_index += len;
//		Console.WriteLine("token: {0}", m_token);
	}

	private void DoSkipWhiteSpace()
	{		
		while (true)
		{
			int oldIndex = m_index;
			
			// white space
			while (m_index < m_text.Length && char.IsWhiteSpace(m_text[m_index]))
			{
				if (m_text[m_index] == '\r' || m_text[m_index] == '\n')	
					++m_line;
				++m_index;
			}
			
			// C++ Comment
			if (m_index+1 < m_text.Length && m_text[m_index] == '/' && m_text[m_index+1] == '/')
			{
				while (m_index < m_text.Length && m_text[m_index] != '\r' && m_text[m_index] != '\n')
					++m_index;
			}
			
			// C Comment
			if (m_index+1 < m_text.Length && m_text[m_index] == '/' && m_text[m_index+1] == '*')
			{
				while (m_index+1 < m_text.Length && !(m_text[m_index] == '*' && m_text[m_index+1] == '/'))
				{
					if (m_text[m_index] == '\r' || m_text[m_index] == '\n')	
						++m_line;
					++m_index;
				}
					
				if (m_index+1 < m_text.Length)
					m_index += 2;
			}
			
			// preprocessor
			if (m_index+1 < m_text.Length && m_text[m_index] == '#' && char.IsLetter(m_text[m_index+1]))
			{
				while (m_index < m_text.Length && m_text[m_index] != '\r' && m_text[m_index] != '\n')
					++m_index;
			}
			
			if (m_index == oldIndex)
				break;
		}
	}
	
	private string m_path;
	private string m_text;
	private int m_index;
	private int m_line = 1;
	private string m_token;
}

