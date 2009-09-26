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
using System.Linq;

// Parses all the native headers and records the information that Generate will
// use to emit the C# wrappers.
internal sealed class ObjectModel
{
	public IEnumerable<NativeFile> Files
	{
		get {return m_files;}
	}
	
	public string ExpandDefines(string text)
	{
		foreach (var entry in m_defineMapping)
		{
			if (text.Contains(entry.Key))
				if (entry.Value != "*")
					text = text.Replace(entry.Key, entry.Value);	// this is kind of scary...
				else
					throw new Exception(string.Format("Define {0} has an ambiguous value", entry.Key));
		}
		
		return text;
	}
	
	public string MapType(string type)
	{
		string result;
		
		switch (type)
		{
			case "unichar":
				result = "char";
				break;
				
			case "NSInteger":
			case "WebNSInteger":
				result = "Int32";
				break;
			
			case "AudioUnit":
			case "AuthorizationEngineRef":
			case "AuthorizationRef":
			case "Component":
			case "ComponentInstance":
			case "CSIdentityAuthorityRef":
			case "CSIdentityRef":
			case "CVOpenGLBufferRef":
			case "CVPixelBufferRef":
			case "Handle":
			case "jobject":
			case "JSGlobalContextRef":
			case "JSObjectRef":
			case "Media":
			case "MovieController":
			case "QTDataReference":
			case "QTVisualContextRef":
			case "SecCertificateRef":
			case "SecIdentityRef":
			case "SecKeychainRef":
			case "SecTrustRef":
			case "TISInputSourceRef":
			case "Track":
				result = "IntPtr";
				break;
			
			case "AuthorizationString":
				result = "string";
				break;
			
			case "gid_t":
			case "NSUInteger":
			case "uid_t":
			case "WebNSUInteger":
				result = "UInt32";
				break;
			
			default:
				if (m_typeMapping.TryGetValue(type, out result))
				{
					if (result == "*")
						throw new Exception(string.Format("Typedef {0} has an ambiguous value", type));
				}
				else
				{
					result = type;
				}
				break;
		}
		
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
	
	// Used to map a method result type to something saner (typically id
	// to the interface type).
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
			throw new ArgumentException("Couldn't find protocol " + name);
			
		return result;
	}
	
	public NativeInterface FindInterface(string name)
	{
		NativeInterface result;
		
		if (!m_interfaces.TryGetValue(name, out result))
			throw new Exception("Couldn't find interface " + name);
			
		return result;
	}
	
	public bool TryGetMethods(NativeInterface ni, out List<NativeMethod> methods)
	{
		return m_methods.TryGetValue(ni, out methods);
	}
	
	public void Reset()
	{
		m_files.Clear();
	}
	
	#region Populate Methods
	public void AddDefine(string name, string value)
	{
//Console.WriteLine("{0} = {1}", name, value);
		if (!m_defineMapping.ContainsKey(name))
			m_defineMapping.Add(name, value);
		else if (m_defineMapping[name] != value)
			m_defineMapping[name] = "*";					// this is a problem, but only if we need the value
	}
	
	public void AddTypedef(string name, string value)
	{
		if (!m_typeMapping.ContainsKey(name))
			m_typeMapping.Add(name, value);
		else if (m_typeMapping[name] != value)
			m_typeMapping[name] = "*";					// this is a problem, but only if we need the value
	}
	
	public void AddProtocol(NativeProtocol protocol)
	{
		m_protocols.Add(protocol.Name, protocol);
	}
	
	public void AddFile(NativeFile file, IEnumerable<NativeInterface> interfaces)
	{
		if (m_files.Exists(f => f.Path == file.Path))
			throw new Exception(file.Path + " has already been queued up.");
			
		m_emitted.AddRange(from i in interfaces where i.Category == null select i.Name);
		m_files.Add(file);
	}
	
	public void AddInterface(NativeInterface ni)
	{
		if (ni.Category == null)
		{
			m_known.Add(ni.Name);
			m_interfaces.Add(ni.Name, ni);
		}
	}
	
	public void AddMethods(NativeInterface ni, IEnumerable<NativeMethod> methods)
	{
		List<NativeMethod> m;
		if (!m_methods.TryGetValue(ni, out m))
		{
			m = new List<NativeMethod>();
			m_methods.Add(ni, m);
		}
		
		m.AddRange(methods);
	}
	
	public void AddResultMapping(string method, string type)
	{
		if (!m_resultMap.ContainsKey(method))
			m_resultMap.Add(method, type);
		else
			Console.Error.WriteLine("{0} TypeResult was listed twice", method);
	}
	#endregion
	
	#region Private Methods
	private Dictionary<string, string> m_typeMapping = new Dictionary<string, string>();
	private Dictionary<string, string> m_defineMapping = new Dictionary<string, string>();
	private List<NativeFile> m_files = new List<NativeFile>();
	private Dictionary<string, NativeProtocol> m_protocols = new Dictionary<string, NativeProtocol>();
	private Dictionary<string, NativeInterface> m_interfaces = new Dictionary<string, NativeInterface>();
	private Dictionary<string, string> m_resultMap = new Dictionary<string, string>();
	private List<string> m_known = new List<string>();
	private List<string> m_emitted = new List<string>();	// more properly the types we are going to emit
	private Dictionary<NativeInterface, List<NativeMethod>> m_methods = new Dictionary<NativeInterface, List<NativeMethod>>();
	#endregion
}
