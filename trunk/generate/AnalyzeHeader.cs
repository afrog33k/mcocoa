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
using System.Xml;

// Iterates over the XmlNodes from a parsed header and populates the ObjectModel.
internal sealed class AnalyzeHeader
{
	public AnalyzeHeader(ObjectModel objects)
	{
		m_objects = objects;
	}
	
//	private bool m_emitting;	// TODO: temp
	
	// Header := S (ForwardReference / Enum / Extern / Inline / Interface / Protocol / Struct / Typedef)*;
	public void Header(XmlNode node, string path, bool emitting)
	{
//		m_emitting = emitting;
//if (m_emitting)
//	Console.WriteLine("\n{0}", path);
		
		m_enums = new List<NativeEnum>();
		m_interfaces = new List<NativeInterface>();
		
		foreach (XmlNode child in node.ChildNodes)
		{
			// TODO: Would be nice to also handle extern and struct (here and in DoAnalyzeInterface).
			if ("Enum" == child.Name)
			{
				DoAnalyzeEnum(child);
			}
			else if ("Interface" == child.Name)
			{
				DoAnalyzeInterface(child);
			}
			else if ("Preprocessor" == child.Name && child.Attributes["alternative"].Value == "1")
			{
				DoAnalyzePreprocessor(child);
			}
			else if ("Protocol" == child.Name)
			{
				DoAnalyzeProtocol(child);
			}
			else if ("Struct" == child.Name)
			{
				DoAnalyzeStruct(child);
			}
			else if ("Typedef" == child.Name)
			{
				DoAnalyzeTypedef(child);
			}
		}
		
		var file = new NativeFile(path, m_enums, m_interfaces);
		if (m_knownFiles.Exists(f => f.Path == path))
			throw new Exception(path + " has already been parsed.");
			
		m_knownFiles.Add(file);
		if (emitting)
			m_objects.AddFile(file, m_interfaces);
	}
	
	public void PostParse()
	{
		// Note that we have to do this after parsing all files because we need to
		// add category methods to interfaces which may be parsed after the category.
		foreach (NativeFile file in m_knownFiles)
		{
			DoAddMethods(file);
		}
	}
	
	#region Private Methods
	// Enum := 'enum' C Identifier? '{' C EnumEntries (',' S)? '}' C Deprecated? ';' C;
	// Enum := 'typedef' C 'enum' C Identifier? '{' C EnumEntries (',' C)? '}' C Identifier Deprecated? ';' C;
	// 
	// EnumEntries := EnumEntry (',' C EnumEntry C)*;
	// 
	// EnumEntry := Identifier '=' S Expression;
	// EnumEntry := Identifier;
	private void DoAnalyzeEnum(XmlNode node)
	{
		if (DoFind(node, "Deprecated") == null)
		{
			XmlNode identifier = DoFindLast(node, "Identifier");
			string name = identifier != null ? identifier.InnerText : null;
			
			var names = new List<string>();
			var values = new List<string>();
			
			XmlNode entries = DoFind(node, "EnumEntries");
			foreach (XmlNode child in entries.ChildNodes)
			{
				if ("EnumEntry" == child.Name)
				{
					names.Add(child.ChildNodes[0].InnerText);
					
					if (child.ChildNodes.Count > 1)
					{
						values.Add(child.ChildNodes[2].InnerText);
					}
					else
					{
						values.Add(string.Empty);
					}
				}
			}
			
			m_enums.Add(new NativeEnum{Name = name, Names = names.ToArray(), Values = values.ToArray()});
		}
	}
	
	// Interface := Attribute? Deprecated? Availability? '@interface' C InterfaceSig ('{' C)? '@interface' C InterfaceSig ('{' C Fields '}' C (';' S)?)? InterfaceMember* '@end' C;	# work around for lack of preprocessing for types like NSLayoutManager
	// Interface := Attribute? Deprecated? Availability? '@interface' C InterfaceSig ('{' C Fields '}' C (';' S)?)? InterfaceMember* '@end' C;
	private void DoAnalyzeInterface(XmlNode node)
	{
		if (DoFind(node, "Deprecated") == null)
		{
			XmlNode sig = DoFind(node, "InterfaceSig");
			NativeInterface ni = DoAnalyzeInterfaceSig(sig);
			
			foreach (XmlNode child in node.ChildNodes)
			{
				if ("InterfaceMember" == child.Name)
				{
					NativeMethod method = DoAnalyzeInterfaceMember(child);
					if (method != null)
					{
						ni.Add(method);
					}
				}
			}
			
			m_interfaces.Add(ni);
			m_objects.AddInterface(ni);
		}
	}
	
	// InterfaceSig := Identifier BaseClass C ProtocolList ProtocolList;	# for NSWindow
	// InterfaceSig := Identifier BaseClass C ProtocolList C;
	// InterfaceSig := Identifier BaseClass C;
	// InterfaceSig := Identifier C ProtocolList;
	// InterfaceSig := Identifier Category ProtocolList;
	// InterfaceSig := Identifier Category;
	// 
	// BaseClass := ':' S Identifier;
	// 
	// Category := '(' S Identifier ')' S;
	private NativeInterface DoAnalyzeInterfaceSig(XmlNode node)
	{
		NativeInterface ni;
		
		string name = node.ChildNodes[0].InnerText;
		
		XmlNode category = DoFind(node, "Category");
		XmlNode protocolsNode = DoFind(node, "IdentifierList");	// the ProtocolList returns the IdentifierList instead of itself
		string[] protocols = protocolsNode != null ? DoAnalyzeIdentifierList(protocolsNode) : new string[0];
			
		if (category != null)
		{
			ni = new NativeInterface{Name = name, Protocols = protocols, Category = category.ChildNodes[1].InnerText};
		}
		else
		{
			XmlNode baseNode = DoFind(node, "BaseClass");
			string baseName = baseNode != null ? baseNode.ChildNodes[1].InnerText : null;
			
			ni = new NativeInterface{Name = name, BaseName = baseName, Protocols = protocols};
		}
		
		return ni;
	}
	
	// Preprocessor := '#' S 'define' [ \t]+ IdentifierNoSpace !'(' DefineValue S
	private void DoAnalyzePreprocessor(XmlNode node)
	{
		XmlNode identifier = DoFind(node, "IdentifierNoSpace");
		XmlNode expr = DoFind(node, "DefineValue");
		
		m_objects.AddDefine(identifier.InnerText, expr.InnerText);
	}
	
	// Protocol := Deprecated? Availability? '@protocol' C Identifier ProtocolList? InterfaceMember* '@end' C;
	private void DoAnalyzeProtocol(XmlNode node)
	{
		if (DoFind(node, "Deprecated") == null)
		{
			XmlNode identifier = DoFind(node, "Identifier");
			
			XmlNode protocolsNode = DoFind(node, "IdentifierList");	// the ProtocolList returns the IdentifierList instead of itself
			string[] protocols = protocolsNode != null ? DoAnalyzeIdentifierList(protocolsNode) : new string[0];
			
			var protocol = new NativeProtocol{Name = identifier.InnerText, Protocols = protocols};
			
			foreach (XmlNode child in node.ChildNodes)
			{
				if ("InterfaceMember" == child.Name)
				{
					NativeMethod method = DoAnalyzeInterfaceMember(child);
					if (method != null)
						protocol.Add(method);
				}
			}
			m_objects.AddProtocol(protocol);
		}
	}
	
	// InterfaceMember := Comment / Preprocessor / Method / Enum / Extern / Property / Typedef / ('@optional' S) / ('@required' S);
	private NativeMethod DoAnalyzeInterfaceMember(XmlNode node)
	{
		NativeMethod method = null;
		
		XmlNode child = node.ChildNodes[0];
		if ("Enum" == child.Name)
		{
			DoAnalyzeEnum(child);
		}
		else if ("Method" == child.Name)
		{
			method = DoAnalyzeMethod(child);
		}
		else if ("Preprocessor" == child.Name && child.Attributes["alternative"].Value == "1")
		{
			DoAnalyzePreprocessor(child);
		}
		else if ("Typedef" == child.Name)
		{
			DoAnalyzeTypedef(child);
		}
		
		return method;
	}
	
	// Method := ('-' / '+') S ParensType? (Parameter+ VarArgs? / Identifier) Deprecated? Availability? ';' S;
	// 
	// Parameter := Identifier? ':' S ParensType? Identifier;
	// 
	// VarArgs := ',' S '...' S ('NS_REQUIRES_NIL_TERMINATION' S)?;
	// 
	// ParensType := '(' S Type ')' S;
	private NativeMethod DoAnalyzeMethod(XmlNode node)
	{
		NativeMethod result = null;
		
		if (DoFind(node, "Deprecated") == null)
		{
			var name = new System.Text.StringBuilder();
			string rtype = node.ChildNodes[1].Name == "ParensType" ? node.ChildNodes[1].InnerText : "id";
			var argNames = new List<string>();
			var argTypes = new List<string>();
			
			XmlNode identifier = DoFind(node, "Identifier");
			if (identifier != null)
			{
				name.Append(identifier.InnerText);
			}
			else
			{
				for (int i = 1; i < node.ChildNodes.Count; ++i)
				{
					XmlNode p = node.ChildNodes[i];
					if (p.Name == "Parameter")
					{
						if (p.ChildNodes[0].Name == "Identifier")
							name.Append(p.ChildNodes[0].InnerText);
						name.Append(':');
						
						XmlNode parens = DoFind(p, "ParensType");
						XmlNode aname = DoFindLast(p, "Identifier");
						if (parens != null)
							argTypes.Add(parens.InnerText);
						else
							argTypes.Add("id");
						if (argNames.Contains(aname.InnerText))
							argNames.Add(aname.InnerText + "2");		// clientAcceptedChangesForRecordWithIdentifier:formattedRecord:newRecordIdentifier: has duplicate argument names...
						else
							argNames.Add(aname.InnerText);
					}
				}
				
				XmlNode varArgs = DoFind(node, "VarArgs");
				if (varArgs != null)
				{
					argNames.Add(string.Empty);
					argTypes.Add("...");
				}
			}
			
			result = new NativeMethod{
				IsClass = node.ChildNodes[0].Value == "+",
				Name = name.ToString(),
				ReturnType = rtype,
				ArgNames = argNames.ToArray(),
				ArgTypes = argTypes.ToArray()};
		}
		
		return result;
	}
	
	// Struct := 'typedef' S 'struct' S Identifier? '{' S (Field / Union)* '}' S Identifier Deprecated? ';' S;
	// Struct := 'struct' S Identifier? '{' S (Field / Union)* '}' S Identifier Deprecated? ';' S;
	private void DoAnalyzeStruct(XmlNode node)
	{
		if (DoFind(node, "Deprecated") == null)
		{
			XmlNode child = DoFindLast(node, "Identifier");
			Console.WriteLine("Ignoring struct {0}", child.InnerText);
		}
	}
	
	// Typedef := 'typedef' S Type Identifier '(' S ArgList ')' S ';' S;
	// Typedef := 'typedef' S PrimitiveType '(' S '*' Identifier ')' S '(' S ArgList ')' S ';' S;
	// Typedef := 'typedef' S Type Identifier ';' S;
	private void DoAnalyzeTypedef(XmlNode node)
	{
		// Note that the first form is for function typedefs (not function pointer typedefs).
		// For example: typedef void NSUncaughtExceptionHandler(NSException *exception);
		if (node.ChildNodes.Count == 4)
		{
			string name = node.ChildNodes[2].InnerText;
			string value = node.ChildNodes[1].InnerText;
			m_objects.AddTypedef(name, value);
		}
	}
	
	// IdentifierList := Identifier (',' S Identifier)*;
	private string[] DoAnalyzeIdentifierList(XmlNode node)
	{
		var identifiers = new List<string>();
		
		for (int i = 0; i < node.ChildNodes.Count; i += 2)
			identifiers.Add(node.ChildNodes[i].InnerText);
		
		return identifiers.ToArray();
	}
	
	private XmlNode DoFind(XmlNode node, string name)
	{
		for (int i = 0; i < node.ChildNodes.Count; ++i)
			if (node.ChildNodes[i].Name == name)
				return node.ChildNodes[i];
				
		return null;
	}
	
	private XmlNode DoFindLast(XmlNode node, string name)
	{
		for (int i = node.ChildNodes.Count - 1; i >= 0; --i)
			if (node.ChildNodes[i].Name == name)
				return node.ChildNodes[i];
				
		return null;
	}
	
	private void DoAddMethods(NativeFile file)
	{
		foreach (NativeInterface ni in file.Interfaces)
		{
			NativeInterface ri = ni;
			
			if (ni.Category == null)
			{
				m_objects.AddMethods(ri, ni.Methods);
			}
			else
			{
				if (m_objects.KnownType(ni.Name))
				{
					ri = m_objects.FindInterface(ni.Name);
					m_objects.AddMethods(ri, ni.Methods);
				}
				else
					Console.Error.WriteLine("Ignoring the {0} category for interface {1} (can't find the interface).", ni.Category, ni.Name);
			}
			
			foreach (string p in ni.Protocols)
			{
				try
				{
					NativeProtocol pp = m_objects.FindProtocol(p);
					m_objects.AddMethods(ri, pp.Methods);
				}
				catch (ArgumentException)
				{
					Console.Error.WriteLine("Not adding the {0} protocol methods to {1} (can't find the protocol).", p.Normalize(), ni.Name);
				}
			}
		}
	}
	#endregion
	
	#region Private Methods
	private ObjectModel m_objects;
	private List<NativeEnum> m_enums;
	private List<NativeInterface> m_interfaces;
	private List<NativeFile> m_knownFiles = new List<NativeFile>();
	#endregion
}
