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
using System.Linq;

// Parses all the native headers and records the information that Generate will
// use to emit the C# wrappers.
internal sealed class ObjectModel
{
	public void Parse(string inPath, bool emitting)
	{
		m_inPath = inPath;
		
		string text = File.ReadAllText(m_inPath);
		
		DoTypedefs(text);
		DoProtocols(text);
		
		List<NativeEnum> enums = DoEnums(text);
		List<NativeInterface> interfaces = DoInterfaces(text);
//		Console.WriteLine("{0}", inPath);
//		foreach (NativeInterface nn in interfaces)
//			Console.WriteLine("    {0}", nn);
		m_known.AddRange(from i in interfaces where i.Category == null select i.Name);
		
		var file = new NativeFile(inPath, enums, interfaces);
		m_knownFiles.Add(file);
		
		if (emitting)
		{
			m_emitted.AddRange(from i in interfaces where i.Category == null select i.Name);
			m_files.Add(file);
		}
	}
	
	public void PostParse()
	{
		foreach (NativeFile file in m_knownFiles)
		{
			DoAddMethods(file);
		}
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
		
		if (type == "unichar")
			result = "char";
		
		else if (!m_typeMapping.TryGetValue(type, out result))
			result = type;
		
		return result;
	}
	
	// Returns true if the type is one we've seen.
	public bool KnownType(string name)
	{
		return m_known.Contains(name);
	}
	
	// Returns true if the type is one for which we emit code.
	public bool EmittedType(string name)
	{
		// NSObject is part of mobjc so we never emit a class for it.
		if (name == "NSObject")
			return false;
		
		return m_emitted.Contains(name);
	}
	
	public string MapResult(string iname, string mname, string rtype)
	{
		string result;
	
		if (m_resultMap.TryGetValue(mname, out result))
		{
			if (result == null)
				result = iname;
		}
		else if (rtype == "id" && (mname.StartsWith("init") || mname.StartsWith("copyWithZone:")))
		{
			result = iname;
		}
		else
			result = rtype;
		
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
	
	public void AddResultMapping(string method, string type)
	{
		if (!m_resultMap.ContainsKey(method))
			m_resultMap.Add(method, type);
		else
			Console.Error.WriteLine("{0} TypeResult was listed twice", method);
	}
	
	public bool TryGetMethods(NativeInterface ni, out List<NativeMethod> methods)
	{
		return m_methods.TryGetValue(ni, out methods);
	}
	
	#region Private Methods
	private void DoAddMethods(NativeFile file)
	{
		foreach (NativeInterface ni in file.Interfaces)
		{
			NativeInterface ri = ni;
			
			if (ni.Category == null)
			{
				DoAddMethods(ri, ni.Methods);
			}
			else
			{
				if (KnownType(ni.Name))
				{
					ri = FindInterface(ni.Name);
					DoAddMethods(ri, ni.Methods);
				}
				else
					Console.Error.WriteLine("Ignoring the {0} category for interface {1} (can't find the interface).", ni.Category, ni.Name);
			}
			
			foreach (string p in ni.Protocols)
			{
				NativeProtocol pp = FindProtocol(p);
				DoAddMethods(ri, pp.Methods);
			}
		}
	}
	
	private void DoAddMethods(NativeInterface ni, List<NativeMethod> methods)
	{
		List<NativeMethod> m;
		if (!m_methods.TryGetValue(ni, out m))
		{
			m = new List<NativeMethod>();
			m_methods.Add(ni, m);
		}
		
		m.AddRange(methods);
	}
	
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
	
	#region Private Methods
	private string m_inPath;
	private Dictionary<string, string> m_typeMapping = new Dictionary<string, string>();
	private List<NativeFile> m_files = new List<NativeFile>();
	private Dictionary<string, NativeProtocol> m_protocols = new Dictionary<string, NativeProtocol>();
	private Dictionary<string, NativeInterface> m_interfaces = new Dictionary<string, NativeInterface>();
	private Dictionary<string, string> m_resultMap = new Dictionary<string, string>();
	private List<NativeFile> m_knownFiles = new List<NativeFile>();
	private List<string> m_known = new List<string>();
	private List<string> m_emitted = new List<string>();
	private Dictionary<NativeInterface, List<NativeMethod>> m_methods = new Dictionary<NativeInterface, List<NativeMethod>>();
	#endregion
}
