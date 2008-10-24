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
using System.IO;

internal sealed class ObjectModel	
{
	public void Parse(string inPath)
	{	
		m_inPath = inPath;
				
		string text = File.ReadAllText(m_inPath);
	
		DoTypedefs(text);
		DoProtocols(text);
		
		List<NativeEnum> enums = DoEnums(text);
		List<NativeInterface> interfaces = DoInterfaces(text);
		m_files.Add(new NativeFile(inPath, enums, interfaces));
	}
	
	public void Reset()
	{
		m_files = new List<NativeFile>();
	}
	
	public IEnumerable<NativeFile> Files
	{
		get {return m_files;}
	}
	
	public string MapType(string type)
	{
		string result;
		
		if (!m_typeMapping.TryGetValue(type, out result))
			result = type;
			
		return result;
	}
	
	public NativeProtocol FindProtocol(string name)
	{
		NativeProtocol result;
		
		if (!m_protocols.TryGetValue(name, out result))
			throw new Exception("Couldn't find protocol " + name);
			
		return result;
	}
	
	public NativeInterface FindInterface(string name)
	{
		NativeInterface result;
		
		if (!m_interfaces.TryGetValue(name, out result))
			throw new Exception("Couldn't find interface " + name);
			
		return result;
	}
	
	#region Private Methods ---------------------------------------------------
	private void DoTypedefs(string text)
	{
		TypedefParser parser = new TypedefParser(m_inPath, text);
		
		while (!parser.AtEnd)
		{
			KeyValuePair<string, string> m = parser.Mapping;
			parser.Advance();
			
			if (!m_typeMapping.ContainsKey(m.Key))
				m_typeMapping.Add(m.Key, m.Value);
			else if (m_typeMapping[m.Key] != m.Value)
				throw new Exception(string.Format("Typedef {0} has multiple values in {1}", m.Key, m_inPath));
		}
	}
		
	private List<NativeEnum> DoEnums(string text)
	{
		List<NativeEnum> enums = new List<NativeEnum>();
		
		EnumParser parser = new EnumParser(m_inPath, text);
		
		while (!parser.AtEnd)
		{
			enums.Add(parser.Enum);
			parser.Advance();			
		}
		
		return enums;
	}
	
	private void DoProtocols(string text)
	{
		ProtocolParser pscanner = new ProtocolParser(m_inPath, text);
		
		while (!pscanner.AtEnd)
		{
			NativeProtocol protocol = pscanner.Protocol;
			m_protocols.Add(protocol.Name, protocol);
			
			pscanner.Advance();
		}
	}
	
	private List<NativeInterface> DoInterfaces(string text)
	{
		List<NativeInterface> interfaces = new List<NativeInterface>();
		
		InterfaceParser parser = new InterfaceParser(m_inPath, text);
		
		while (!parser.AtEnd)
		{
			NativeInterface ni = parser.Interface;	
			if (ni.Category == null)
				m_interfaces.Add(ni.Name, ni);
			interfaces.Add(ni);
			
			parser.Advance();
		}
		
		return interfaces;
	}
	#endregion
	
	#region Private Methods ---------------------------------------------------
	private string m_inPath;
	private Dictionary<string, string> m_typeMapping = new Dictionary<string, string>();
	private List<NativeFile> m_files = new List<NativeFile>();
	private Dictionary<string, NativeProtocol> m_protocols = new Dictionary<string, NativeProtocol>();
	private Dictionary<string, NativeInterface> m_interfaces = new Dictionary<string, NativeInterface>();
	#endregion
}
