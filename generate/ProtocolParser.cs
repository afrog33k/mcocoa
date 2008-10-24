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

internal sealed class ProtocolParser : Parser
{
	public ProtocolParser(string path, string text) : base(path, text)
	{	
	}
	
	public bool AtEnd 
	{
		get {return Protocol == null;}
	}
	
	public NativeProtocol Protocol {get; private set;}
	
	public override void Advance()
	{
		Protocol = null;
		
		while (!m_tokenizer.AtEnd && Protocol == null)
		{
			while (!m_tokenizer.AtEnd && m_tokenizer.Token != "@protocol")
				m_tokenizer.Advance();
			
			if (m_tokenizer.Token == "@protocol")
				DoParseProtocol();
		}
	}
	
	// Protocol := Header Methods @end
	private void DoParseProtocol()
	{
		Protocol = new NativeProtocol();
		Protocol.Protocols = new string[0];
		
		DoParseHeader();
		DoParseMethods();
		DoParseLiteral("@end");
	}
	
	// Header := '@protocol' Name Protocols? 
	private void DoParseHeader()
	{
		m_tokenizer.Advance();
		
		Protocol.Name = DoParseName();
		
		if ("<" == m_tokenizer.Token)
			DoParseProtocols();
	}
	
	// Methods := Method*
	private void DoParseMethods()
	{
		while (!m_tokenizer.AtEnd && m_tokenizer.Token != "@end")
		{
			if ("-" == m_tokenizer.Token || "+" == m_tokenizer.Token)
			{
				NativeMethod method = DoParseMethod();
				if (method != null)
					Protocol.Methods.Add(method);
			}
			else
				m_tokenizer.Advance();
		}
	}
	
	// Protocols := '<' NameList '>'
	private void DoParseProtocols()
	{
		m_tokenizer.Advance();
		Protocol.Protocols = DoParseNameList();
		DoParseSymbol('>');
	}
}

