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
using System.Text;

internal sealed class Generate	
{
	public Generate(ObjectModel objects)
	{
		m_objects = objects;

		foreach (NativeFile file in m_objects.Files)
		{
			foreach (NativeInterface ni in file.Interfaces)
			{
				NativeInterface ri = ni;
				
				if (ni.Category == null)
				{
					DoAddMethods(ri, ni.Methods);
				}
				else if (ni.Name != "CIColor" && ni.Name != "CIImage")
				{
					ri = m_objects.FindInterface(ni.Name);
					DoAddMethods(ri, ni.Methods);
				}
									
				foreach (string p in ni.Protocols)
				{
					NativeProtocol pp = m_objects.FindProtocol(p);
					DoAddMethods(ri, pp.Methods);
				}
			}
		}
	}
					
	public void Code(string outDir, Blacklist[] blacklist)
	{	
		m_blacklist = blacklist;
		m_fastCalls = 0;
		m_slowCalls = 0;

		foreach (NativeFile file in m_objects.Files)
		{
			string hfile = Path.GetFileNameWithoutExtension(file.Path);
			if (hfile != "NSObjCRuntime" && hfile != "NSObject" && hfile != "NSProxy" && hfile != "NSDistantObject" && hfile != "NSProtocolChecker")
			{
				m_inPath = file.Path;
					
				StringBuilder buffer = new StringBuilder();
				m_buffer = buffer;
				
				DoWrite("// machine generated on {0} using {1}", DateTime.Now, Path.GetFullPath(m_inPath));
				DoWrite();
				DoWrite("using MObjc;");
				DoWrite("using System;");
				DoWrite("using System.Runtime.InteropServices;");
				DoWrite();
		
				DoWrite("namespace MCocoa");
				DoWrite("{");
							
				DoEnums(buffer, file);
				DoInterfaces(buffer, file);
		
				m_buffer = buffer;
				DoWrite("}");
		
				string outPath = Path.Combine(outDir, hfile + ".cs");
				File.WriteAllText(outPath, buffer.ToString());
		
				// These files should not normally be hand edited so we'll lock them.
				File.SetAttributes(outPath, FileAttributes.ReadOnly);
			}
		}
		
		string[] components = outDir.Split('/');
		Console.WriteLine("{0:0.0}% of {1} {2} methods are fast path", 100.0*m_fastCalls/(m_fastCalls+m_slowCalls), m_fastCalls+m_slowCalls, components[components.Length - 2]);
	}
	
	#region Private Methods ---------------------------------------------------
	private void DoEnums(StringBuilder buffer, NativeFile file)
	{
		m_buffer = buffer;
		
		for (int k = 0; k < file.Enums.Count; ++k)
		{
			NativeEnum value = file.Enums[k];
				
			if (value.Name != null)
			{
				DoWrite("	public enum {0}", value.Name);
				DoWrite("	{");
				for (int i = 0; i < value.Names.Length; ++i)
				{	
					if (value.Values[i].Length > 0)
						DoWrite("		{0} = {1},", value.Names[i], DoMapEnumValue(value.Values[i]));
					else
						DoWrite("		{0},", value.Names[i]);
				}
			}
			else
			{
				DoWrite("	public partial class Enums");
				DoWrite("	{");
				
				int? v = 0;
				for (int i = 0; i < value.Names.Length; ++i)
				{	
					if (value.Values[i].Length > 0)
					{
						string vv = DoMapEnumValue(value.Values[i].Trim());

						int tmp;
						if (vv.StartsWith("0x") && vv.Length >= 10 && vv[2] >= '8')
						{
							if (vv.EndsWith("UL"))
								vv = vv.Substring(0, vv.Length - 2);
								
							DoWrite("		public const uint {0} = {1};", value.Names[i], vv);
							v = null;
						}
						else if (vv == "NSUIntegerMax")
						{
							DoWrite("		public const uint {0} = uint.MaxValue;", value.Names[i]);
							v = null;
						}
						else if (value.Names[i] == "NSXMLNodePreserveAll")
						{
							DoWrite("		public const uint {0} = {1};", value.Names[i], vv);
							v = null;
						}
						else
						{
							DoWrite("		public const int {0} = {1};", value.Names[i], vv);
							
							if (int.TryParse(vv, out tmp))
								v = tmp + 1;
							else
								v = null;
						}
					}
					else if (v.HasValue)
					{
						DoWrite("		public const int {0} = {1};", value.Names[i], v.Value);
						v = v.Value + 1;
					}
					else
						throw new Exception(string.Format("Couldn't compute a value for {0} in {1}", value.Names[i], m_inPath));
				}
			}
			
			DoWrite("	}");	
			DoWrite();
		}
	}
	
	private void DoInterfaces(StringBuilder buffer, NativeFile file)
	{
		for (int i = 0; i < file.Interfaces.Count; ++i)
		{			
			m_interface = file.Interfaces[i];
			
			if (m_interface.Category == null || m_interface.Category != "NSDeprecated")
			{
				m_buffer = new StringBuilder();
				if (i > 0)	
					DoWrite();

				DoWriteInterfaceHeader();	
				DoGenerateMethods();
				DoWriteInterfaceTrailer();
						
				buffer.Append(m_buffer.ToString());
			}
		}
	}
		
	private void DoWriteInterfaceHeader()
	{		
		if (m_interface.Category != null)
		{
			if (m_interface.Name == "CIColor" || m_interface.Name == "CIImage")
			{
				DoWrite("	// {0} category", m_interface.Category);
				DoWrite("	public partial class {0} : {1}", m_interface.Name, "NSObject");
				DoWrite("	{");
			}
			else if (m_interface.Name == "NSObject")
			{
				DoWrite("	// {0} category", m_interface.Category);
				DoWrite("	public static class {0}ForNSObject", m_interface.Category);
				DoWrite("	{");
			}
			else
			{
				NativeInterface ri = m_objects.FindInterface(m_interface.Name);
	
				DoWrite("	// {0} category", m_interface.Category);
				DoWrite("	public partial class {0} : {1}", m_interface.Name, ri.BaseName);
				DoWrite("	{");
			}
		}
		else
		{
			DoWrite("	[Register]");
			DoWrite("	public partial class {0} : {1}", m_interface.Name, m_interface.BaseName);
			DoWrite("	{");
			DoWrite("		public {0}(IntPtr instance) : base(instance)", m_interface.Name);
			DoWrite("		{");
			DoWrite("		}");
			DoWrite();
			DoWrite("		public static new {0} Create()", m_interface.Name);
			DoWrite("		{");
			DoWrite("			{0} result = ({0}) ms_class.Alloc().init();", m_interface.Name);
			DoWrite("			result.autorelease();");
			DoWrite("			return result;");
			DoWrite("		}");
			DoWrite();
			DoWrite("		public static new {0} alloc()", m_interface.Name);
			DoWrite("		{");
			DoWrite("			return ({0}) ms_class.Call(\"alloc\");", m_interface.Name);
			DoWrite("		}");
			DoWrite();
			DoWrite("		public new {0} retain()", m_interface.Name);
			DoWrite("		{");
			DoWrite("			base.retain();");
			DoWrite("			return this;");
			DoWrite("		}");
			DoWrite();
			DoWrite("		public static new Class Class");
			DoWrite("		{");
			DoWrite("			get {return ms_class;}");
			DoWrite("		}");
		}
	}
	
	private void DoWriteInterfaceTrailer()
	{
		if (m_interface.Category == null)
		{
			DoWrite();
			DoWrite("		private static Class ms_class = new Class(\"{0}\");", m_interface.Name);
		}
		
		DoWrite("	}");
	}
	
	private int DoGenerateMethods()	
	{
		int numMethods = 0;
		
		if (m_interface.Methods.Count > 0 && m_interface.Category == null)
			DoWrite();
		
		bool writeBlank = false;
		List<string> names = new List<string>();
		for (int i = 0; i < m_interface.Methods.Count; ++i)
		{
			NativeMethod method = m_interface.Methods[i];

			if (names.IndexOf(method.Name) < 0)
			{
				if (DoGenerateMethod(method, writeBlank, null))
				{
					++numMethods;
					writeBlank = true;
					
					if (method.Name == "layoutControlGlyphForLineFragment:")	// these are declared twice in NSSimpleHorizontalTypesetter.h
						names.Add(method.Name);
					else if (method.Name == "layoutTab")	
						names.Add(method.Name);
					else if (method.Name == "QTMovie")							// these are also declared twice but under two different defines
						names.Add(method.Name);
					else if (method.Name == "initWithMovie:")	
						names.Add(method.Name);
				}
			}
		}
		
		foreach (string protocol in m_interface.Protocols)
			if (!DoHasProtocol(m_interface.BaseName, protocol))
				if (protocol != "NSObject")
					DoGenerateProtocolMethods(names, protocol);
					
		return numMethods;
	}
		
	private bool DoHasProtocol(string iname, string pname)
	{
		bool has = false;
		
		if (iname != null && iname != "NSObject")
		{
			NativeInterface ni = m_objects.FindInterface(iname);
			has = Array.IndexOf(ni.Protocols, pname) >= 0;
			
			if (!has)
				has = DoHasProtocol(ni.BaseName, pname);
		}
		
		return has;
	}
		
	private void DoGenerateProtocolMethods(List<string> names, string pname)
	{
		DoWrite();
		DoWrite("		#region {0} Methods", pname);
		
		bool writeBlank = false;
		NativeProtocol protocol = m_objects.FindProtocol(pname);		
		for (int i = 0; i < protocol.Methods.Count; ++i)
		{
			NativeMethod method = protocol.Methods[i];
			if (names.IndexOf(method.Name + method.IsClass) < 0 && !DoInterfaceHasMethod(method.Name, method.IsClass))
			{
				if (DoGenerateMethod(method, writeBlank, protocol))
				{
					names.Add(method.Name + method.IsClass);
					writeBlank = true;
				}
			}
			else
				DoWrite("		// skipping {0} (it's already defined)", method.Name);
		}
			
		foreach (string p2 in protocol.Protocols)
			if (p2 != "NSObject")
				DoGenerateProtocolMethods(names, p2);
		
		DoWrite("		#endregion");
	}
	
	private bool DoGenerateMethod(NativeMethod nm, bool writeBlank, NativeProtocol protocol)	
	{		
		bool wrote = false;
		
		bool defined = false;
		if (protocol != null)
		{
			defined = DoPriorProtocolHasMethod(protocol, nm.Name, nm.IsClass);

			if (!defined)
				defined = DoInterfaceHasMethod(nm.Name, nm.IsClass);

			if (!defined)
				defined = DoBaseHasMethod(m_interface.BaseName, nm.Name, nm.IsClass);
		}
		else if (m_interface.Category != null)
		{
			defined = DoInterfaceHasMethod(nm.Name, nm.IsClass);

			if (!defined && m_interface.Name != "NSOject" && m_interface.Name != "CIColor" && m_interface.Name != "CIImage")
			{
				NativeInterface ri = m_objects.FindInterface(m_interface.Name);
				defined = DoBaseHasMethod(ri.BaseName, nm.Name, nm.IsClass);
			}
		}
		else
		{
			defined = DoBaseHasMethod(m_interface.BaseName, nm.Name, nm.IsClass);
		}
		
		if (!defined)
		{
			Blacklist black = m_blacklist.SingleOrDefault(b => b.Interface == m_interface.Name && b.Method == nm.Name);
			if (black == null)
			{
				if (nm.ArgTypes.Length > 0 && nm.ArgTypes[nm.ArgTypes.Length - 1] == "...")
				{
					DoWrite("		// skipping variadic {0}", nm.Name);
					Console.Error.WriteLine("found variadic {0}::{1}", m_interface.Name, nm.Name);
				}
				else if (nm.ArgTypes.Length > 0 && nm.ArgTypes.Any(t => t.Contains("( * )")))
				{
					DoWrite("		// skipping function pointer {0}", nm.Name);
					Console.Error.WriteLine("found function pointer {0}::{1}", m_interface.Name, nm.Name);
				}
				else if (m_interface.Category != null && m_interface.Name == "NSObject" && nm.IsClass)
				{
					DoWrite("		// skipping {0} (can't have NSObject class category methods)", nm.Name);
					Console.Error.WriteLine("found NSObject class category {0}::{1}", m_interface.Name, nm.Name);
				}
				else
				{
					if (writeBlank)
						DoWrite();
					
					DoWriteMethod(nm);
					wrote = true;
				}
			}
			else
			{
				DoWrite("		// skipping {0} {1}", black.Method, black.Reason);
			}
		}
		else
			DoWrite("		// skipping {0} (it's already defined)", nm.Name);
		
		return wrote;
	}
	
	private void DoWriteMethod(NativeMethod method)
	{		
		MethodInfo minfo = new MethodInfo(m_objects, m_interface, method);
		
		// signature		
		m_buffer.Append("		public ");
		if (method.IsClass || (m_interface.Category != null && m_interface.Name == "NSObject"))
			m_buffer.Append("static ");
								
		m_buffer.Append(minfo.ResultType.Managed);
		m_buffer.Append(" ");
		DoWriteMethodName(method.Name, DoGetMethodSuffix(method));
		m_buffer.Append("(");
		if (m_interface.Category != null && m_interface.Name == "NSObject")
		{
			m_buffer.Append("this NSObject _instance");
			if (method.ArgNames.Length > 0)
				m_buffer.Append(", ");
		}
		for (int i = 0; i < minfo.ArgNames.Length; ++i)
		{			
			m_buffer.Append(minfo.ArgTypes[i].Managed);
			m_buffer.Append(" ");
			m_buffer.Append(minfo.ArgNames[i].Managed);
			
			if (i + 1 < minfo.ArgNames.Length)
				m_buffer.Append(", ");
		}
		m_buffer.AppendLine(")");

		DoWrite("		{");
		
		// body
		DoWriteProlog(minfo);
		if (DoTryFastCall(method, minfo))
		{
			++m_fastCalls;
		}
		else
		{	
			++m_slowCalls;
			DoWriteCall(method, minfo);
		}
		DoWriteEpilog(minfo);
		
		// trailer
		DoWrite("		}");
	}
	
	private int m_fastCalls;
	private int m_slowCalls;
	
	private void DoWriteProlog(MethodInfo minfo)
	{		
		if (minfo.HasOutArgs)
		{
			for (int i = 0; i < minfo.ArgNames.Length; ++i)
			{
				if (minfo.ArgTypes[i].ManagedOut.Length > 0)
				{
					if (minfo.ArgTypes[i].ManagedOut == "string")
						m_buffer.AppendFormat("			byte[] {0}Buffer = new byte[4];{1}", minfo.ArgNames[i].Managed, Environment.NewLine);
					else
						m_buffer.AppendFormat("			byte[] {0}Buffer = new byte[Marshal.SizeOf(typeof({1}))];{2}", minfo.ArgNames[i].Managed, minfo.ArgTypes[i].ManagedOut, Environment.NewLine);
					m_buffer.AppendFormat("			GCHandle {0}Handle = GCHandle.Alloc({0}Buffer, GCHandleType.Pinned);{1}", minfo.ArgNames[i].Managed, Environment.NewLine);
					m_buffer.AppendFormat("			IntPtr {0}Ptr = {0}Handle.AddrOfPinnedObject();{1}", minfo.ArgNames[i].Managed, Environment.NewLine);
					m_buffer.AppendLine();
				}
			}
		}
	}
	
	private void DoWriteCall(NativeMethod method, MethodInfo minfo)
	{
		string rtype = minfo.ResultType.Managed;
		
		if (rtype == "void")
			m_buffer.Append("			Unused.Value = ");
		else
			if (minfo.HasOutArgs)
				m_buffer.Append("			" + rtype + " result_ = ");
			else
				m_buffer.Append("			return ");
		
		if (rtype != "void")
		{
			if (rtype != "string" || minfo.ResultType.Native != "NSString *")
			{
				m_buffer.Append("(");
				m_buffer.Append(rtype == "bool" ? "sbyte" : rtype);
				m_buffer.Append(") ");
			}
		}
		
		if (m_interface.Category != null && m_interface.Name == "NSObject")
			m_buffer.Append("_instance.");
		else if (method.IsClass)
			m_buffer.Append("ms_class.");

		m_buffer.Append("Call(\"");
		m_buffer.Append(method.Name);
		m_buffer.Append("\"");
		
		for (int i = 0; i < minfo.ArgNames.Length; ++i)
		{
			m_buffer.Append(", ");
			if (minfo.ArgTypes[i].Native == "NSString *")
			{
				m_buffer.Append("NSString.Create(");
				m_buffer.Append(minfo.ArgNames[i].Managed);
				m_buffer.Append(")");
			}
			else if (minfo.ArgTypes[i].Native == "SEL")
			{
				string aname = minfo.ArgNames[i].Managed;
				m_buffer.Append(aname + " != null ? new Selector(");
				m_buffer.Append(aname);
				m_buffer.Append(") : null");
			}
			else if (minfo.ArgTypes[i].ManagedOut.Length > 0)
			{
				m_buffer.Append(minfo.ArgNames[i].Managed);
				m_buffer.Append("Ptr");
			}
			else
				m_buffer.Append(minfo.ArgNames[i].Managed);
		}
		m_buffer.Append(")");
		if (minfo.ResultType.Managed == "string" && minfo.ResultType.Native == "NSString *")
		{
			m_buffer.Append(".To<NSString>().ToString()");
		}
		else if (minfo.ResultType.Managed == "bool")
		{
			m_buffer.Append(" != 0");
		}
		m_buffer.AppendLine(";");
	}
	
	private bool DoTryFastCall(NativeMethod method, MethodInfo minfo)
	{
		if (!minfo.HasOutArgs)
		{
			if (minfo.ArgNames.Length == 0)
				return DoTryFastCall0(method, minfo);

			else if (minfo.ArgNames.Length == 1)
				return DoTryFastCall1(method, minfo);

			else if (minfo.ArgNames.Length == 2)
				return DoTryFastCall2(method, minfo);
		}
		
		return false;
	}
	
	// managed type name => method name label
	private Dictionary<string, string> m_labels = new Dictionary<string, string>
	{
		{"*", "p"},				
		{"bool", "C"},
		{"byte", "C"},
		{"char", "s"},
		{"Class", "p"},
		{"Int16", "s"},
		{"Int32", "i"},
		{"IntPtr", "p"},
		{"NSObject", "p"},
		{"sbyte", "C"},
		{"Selector", "p"},
		{"string", "p"},
		{"UInt16", "s"},
		{"UInt32", "i"},
		{"void", "v"},
	};
	
	// managed type name => direct call return type
	private Dictionary<string, string> m_dtypes = new Dictionary<string, string>
	{
		{"*", "IntPtr"},
		{"bool", "Byte"},
		{"byte", "Byte"},
		{"char", "Int16"},
		{"Class", "IntPtr"},
		{"Int16", "Int16"},
		{"Int32", "Int32"},
		{"IntPtr", "IntPtr"},
		{"NSObject", "IntPtr"},
		{"sbyte", "Byte"},
		{"Selector", "IntPtr"},
		{"string", "IntPtr"},
		{"UInt16", "Int16"},
		{"UInt32", "Int32"},
		{"void", "void"},
	};
	
	private string DoGetKey(TypeInfo type)
	{
		if (type.Native.EndsWith("*"))
			return "*";
		
		else if (type.Native == "id")
			return "*";
			
		else
			return type.Managed;
	}
	
	private bool DoTryFastCall0(NativeMethod method, MethodInfo minfo)
	{
		bool done = false;
		
		string rtype = minfo.ResultType.Managed;
		string rlabel;

		string rkey = DoGetKey(minfo.ResultType);
		if (m_labels.TryGetValue(rkey, out rlabel))
		{
			string thisPtr;
			if (m_interface.Category != null && m_interface.Name == "NSObject")
				thisPtr = "_instance";
			else if (method.IsClass)
				thisPtr = "ms_class";
			else
				thisPtr = "this";
				
			m_buffer.AppendLine("			IntPtr exception_ = IntPtr.Zero;");

			m_buffer.Append("			");
			if (rkey != "void")
				m_buffer.AppendFormat("{0} result_ = ", m_dtypes[rkey]);
			m_buffer.AppendFormat("DirectCalls.Call{0}({1}, new Selector(\"{2}\"), ", rlabel, thisPtr, method.Name);
			m_buffer.AppendLine("ref exception_);");

			m_buffer.AppendLine("			if (exception_ != IntPtr.Zero)");
			m_buffer.AppendLine("				CocoaException.Raise(exception_);");
			DoAppendFastResult(rkey, rtype, minfo);
			
			done = true;
		}
		
		return done;
	}
	
	private bool DoTryFastCall1(NativeMethod method, MethodInfo minfo)
	{
		bool done = false;
		
		string rtype = minfo.ResultType.Managed;
		string rlabel, a0label;

		string rkey = DoGetKey(minfo.ResultType);
		string a0key = DoGetKey(minfo.ArgTypes[0]);
		
		if (m_labels.TryGetValue(rkey, out rlabel) && m_labels.TryGetValue(a0key, out a0label))
		{
			string thisPtr;
			if (m_interface.Category != null && m_interface.Name == "NSObject")
				thisPtr = "_instance";
			else if (method.IsClass)
				thisPtr = "ms_class";
			else
				thisPtr = "this";
			
			m_buffer.AppendLine("			IntPtr exception_ = IntPtr.Zero;");
			DoAppendFastArgProlog(minfo, 0);
			
			m_buffer.Append("			");
			if (rkey != "void")
				m_buffer.AppendFormat("{0} result_ = ", m_dtypes[rkey]);
			m_buffer.AppendFormat("DirectCalls.Call{0}{1}({2}, new Selector(\"{3}\"), ", rlabel, a0label, thisPtr, method.Name);
			DoAppendFastArg(minfo, 0);
			m_buffer.AppendLine("ref exception_);");
			
			DoAppendFastArgEpilog(minfo, 0);
			m_buffer.AppendLine("			if (exception_ != IntPtr.Zero)");
			m_buffer.AppendLine("				CocoaException.Raise(exception_);");
			DoAppendFastResult(rkey, rtype, minfo);			

			done = true;
		}
		
		return done;
	}
	
	private bool DoTryFastCall2(NativeMethod method, MethodInfo minfo)
	{
		bool done = false;
		
		string rtype = minfo.ResultType.Managed;
		string rlabel, a0label, a1label;

		string rkey = DoGetKey(minfo.ResultType);
		string a0key = DoGetKey(minfo.ArgTypes[0]);
		string a1key = DoGetKey(minfo.ArgTypes[1]);
		
		if (m_labels.TryGetValue(rkey, out rlabel) && m_labels.TryGetValue(a0key, out a0label) && m_labels.TryGetValue(a1key, out a1label))
		{
			string thisPtr;
			if (m_interface.Category != null && m_interface.Name == "NSObject")
				thisPtr = "_instance";
			else if (method.IsClass)
				thisPtr = "ms_class";
			else
				thisPtr = "this";
			
			m_buffer.AppendLine("			IntPtr exception_ = IntPtr.Zero;");
			DoAppendFastArgProlog(minfo, 0);
			DoAppendFastArgProlog(minfo, 1);
			
			m_buffer.Append("			");
			if (rkey != "void")
				m_buffer.AppendFormat("{0} result_ = ", m_dtypes[rkey]);
			m_buffer.AppendFormat("DirectCalls.Call{0}{1}{2}({3}, new Selector(\"{4}\"), ", rlabel, a0label, a1label, thisPtr, method.Name);
			DoAppendFastArg(minfo, 0);
			DoAppendFastArg(minfo, 1);
			m_buffer.AppendLine("ref exception_);");
			
			DoAppendFastArgEpilog(minfo, 0);
			DoAppendFastArgEpilog(minfo, 1);
			m_buffer.AppendLine("			if (exception_ != IntPtr.Zero)");
			m_buffer.AppendLine("				CocoaException.Raise(exception_);");
			DoAppendFastResult(rkey, rtype, minfo);			

			done = true;
		}
		
		return done;
	}
	
	private void DoAppendFastArgProlog(MethodInfo minfo, int i)
	{
		if (minfo.ArgTypes[i].Native == "NSString *")
		{
		}
		else if (minfo.ArgTypes[i].Native == "const char *")
		{
		}
		else if (minfo.ArgTypes[i].Native == "const unichar *")
		{
		}
		else if (minfo.ArgTypes[i].Native == "SEL")
		{
		}
		else if (minfo.ArgTypes[i].Managed == "Int16" || minfo.ArgTypes[i].Managed == "UInt16" || minfo.ArgTypes[i].Managed == "byte" || minfo.ArgTypes[i].Managed == "sbyte" || minfo.ArgTypes[i].Managed == "char" || minfo.ArgTypes[i].Managed == "bool" || minfo.ArgTypes[i].Managed == "Int32" || minfo.ArgTypes[i].Managed == "UInt32" || minfo.ArgTypes[i].Managed == "IntPtr")
		{
		}
		else
		{
			m_buffer.AppendFormat("			IntPtr buffer_{0} = ", minfo.ArgNames[i].Managed);
			m_buffer.AppendFormat("FastPath.CreateBuffer({0}", minfo.ArgNames[i].Managed);
			m_buffer.AppendLine(");");
		}
	}
	
	private void DoAppendFastArg(MethodInfo minfo, int i)
	{
		string aname = minfo.ArgNames[i].Managed;

		if (minfo.ArgTypes[i].Native == "NSString *")
		{
			m_buffer.Append("NSString.Create(");
			m_buffer.Append(minfo.ArgNames[i].Managed);
			m_buffer.Append(")");
		}
		else if (minfo.ArgTypes[i].Native == "const char *")
		{
			m_buffer.Append("Marshal.StringToHGlobalAnsi(");
			m_buffer.Append(minfo.ArgNames[i].Managed);
			m_buffer.Append(")");
		}
		else if (minfo.ArgTypes[i].Native == "const unichar *")
		{
			m_buffer.Append("Marshal.StringToHGlobalUni(");
			m_buffer.Append(minfo.ArgNames[i].Managed);
			m_buffer.Append(")");
		}
		else if (minfo.ArgTypes[i].Native == "SEL")
		{
			m_buffer.Append(aname + " != null ? new Selector(");
			m_buffer.Append(aname);
			m_buffer.Append(") : IntPtr.Zero");
		}
		else if (minfo.ArgTypes[i].Managed == "UInt16")
		{
			m_buffer.AppendFormat("unchecked((Int16) {0})", aname);
		}
		else if (minfo.ArgTypes[i].Managed == "UInt32")
		{
			m_buffer.AppendFormat("unchecked((Int32) {0})", aname);
		}
		else if (minfo.ArgTypes[i].Managed == "bool")
		{
			m_buffer.AppendFormat("(Byte) ({0} ? 1 : 0)", aname);
		}
		else if (minfo.ArgTypes[i].Managed == "char")
		{
			m_buffer.AppendFormat("unchecked((Int16) {0})", aname);
		}
		else if (minfo.ArgTypes[i].Managed == "sbyte")
		{
			m_buffer.AppendFormat("unchecked((SByte) {0})", aname);
		}
		else if (minfo.ArgTypes[i].Managed == "byte" || minfo.ArgTypes[i].Managed == "Int16" || minfo.ArgTypes[i].Managed == "Int32" || minfo.ArgTypes[i].Managed == "IntPtr")
		{
			m_buffer.Append(aname);
		}
		else
		{
			m_buffer.AppendFormat("buffer_{0}", minfo.ArgNames[i].Managed);
		}

		m_buffer.Append(", ");
	}
	
	private void DoAppendFastArgEpilog(MethodInfo minfo, int i)
	{
		if (minfo.ArgTypes[i].Native == "NSString *")
		{
		}
		else if (minfo.ArgTypes[i].Native == "const char *")
		{
		}
		else if (minfo.ArgTypes[i].Native == "const unichar *")
		{
		}
		else if (minfo.ArgTypes[i].Native == "SEL")
		{
		}
		else if (minfo.ArgTypes[i].Managed == "Int16" || minfo.ArgTypes[i].Managed == "UInt16" || minfo.ArgTypes[i].Managed == "byte" || minfo.ArgTypes[i].Managed == "sbyte" || minfo.ArgTypes[i].Managed == "char" || minfo.ArgTypes[i].Managed == "bool" || minfo.ArgTypes[i].Managed == "Int32" || minfo.ArgTypes[i].Managed == "UInt32" || minfo.ArgTypes[i].Managed == "IntPtr")
		{
		}
		else
		{
			m_buffer.AppendFormat("			FastPath.FreeBuffer({0}, buffer_{0}", minfo.ArgNames[i].Managed);
			m_buffer.AppendLine(");");
		}
	}
	
	private void DoAppendFastResult(string rkey, string rtype, MethodInfo minfo)
	{
		if (rtype != "void")
		{
			m_buffer.AppendLine("");
			if (rtype == "byte" || rtype == "Int16" || rtype == "Int32")
				m_buffer.AppendLine("			return result_;");

			else if (rtype == "bool")
				m_buffer.AppendLine("			return result_ != 0;");

			else if (rtype == "char")
				m_buffer.AppendLine("			return unchecked((char) result_);");

			else if (rtype == "sbyte")
				m_buffer.AppendLine("			return unchecked((SByte) result_);");

			else if (rtype == "UInt16")
				m_buffer.AppendLine("			return unchecked((UInt16) result_);");

			else if (rtype == "UInt32")
				m_buffer.AppendLine("			return unchecked((UInt32) result_);");

			else if (rtype == "string" && minfo.ResultType.Native == "NSString *")
				m_buffer.AppendLine("			return new NSString(result_).ToString();");

			else if (rtype == "IntPtr")
				m_buffer.AppendLine("			return result_;");

			else if (rtype == "Selector")
				m_buffer.AppendLine("			return new Selector(result_);");

			else if (rtype == "Class")
				m_buffer.AppendLine("			return new Class(result_);");

			else if (rtype == "NSObject")
				m_buffer.AppendLine("			return result_.To<" + rtype + ">();");

			else if (rkey == "*")
				m_buffer.AppendLine("			return result_.To<" + rtype + ">();");

			else
				m_buffer.AppendLine("			return bad_result_type;");
		}
	}
	
	private void DoWriteEpilog(MethodInfo minfo)	
	{
		if (minfo.HasOutArgs)
		{
			for (int i = 0; i < minfo.ArgNames.Length; ++i)
			{
				switch (minfo.ArgTypes[i].ManagedOut)
				{
					case "Byte":
					case "Int16":
					case "Int32":
					case "Int64":
						m_buffer.AppendFormat("			{0} = Marshal.Read{1}({0}Ptr);{2}", minfo.ArgNames[i].Managed, minfo.ArgTypes[i].ManagedOut, Environment.NewLine);
						break;
					
					case "string":
						m_buffer.AppendFormat("			{0} = new NSString(Marshal.ReadIntPtr({0}Ptr)).ToString();{1}", minfo.ArgNames[i].Managed, Environment.NewLine);
						break;
					
					default:
						if (minfo.ArgTypes[i].ManagedOut.Length > 0)
							m_buffer.AppendFormat("			{0} = ({1}) Marshal.PtrToStructure({0}Ptr, typeof({1}));{2}", minfo.ArgNames[i].Managed, minfo.ArgTypes[i].ManagedOut, Environment.NewLine);
						break;
				}
			}
			
			if (minfo.ResultType.Managed != "void")
			{
				m_buffer.AppendLine();
				m_buffer.AppendLine("			return result_;");
			}
		}
	}

	// Checks the interface methods, but not categories, protocols, or bases.
	private bool DoInterfaceHasMethod(string mname, bool isClass)
	{
		bool has = false;
		
		if (m_interface.Name != "NSObject" && m_interface.Name != "CIColor" && m_interface.Name != "CIImage")
		{
			NativeInterface ni = m_objects.FindInterface(m_interface.Name);
			if (ni.Methods.Count > 0)
				has = ni.Methods.Any(m => m.Name == mname && m.IsClass == isClass);
		}
				
		return has;
	}
	
	// Checks protocol methods before protocol.
	private bool DoPriorProtocolHasMethod(NativeProtocol protocol, string mname, bool isClass)
	{
		bool has = false;
		
		for (int i = 0; i < m_interface.Protocols.Length && m_interface.Protocols[i] != protocol.Name && !has; ++i)
		{
			NativeProtocol p = m_objects.FindProtocol(m_interface.Protocols[i]);
			if (p.Methods.Count > 0)
				has = p.Methods.Any(m => m.Name == mname && m.IsClass == isClass);
		}
		
		return has;
	}
	
	// Checks interface, category, and protocol methods for iname and its base interfaces.
	private bool DoBaseHasMethod(string iname, string mname, bool isClass)
	{
		bool has = false;
		
		if (iname != null && iname != "NSObject" && iname != "CIColor" && iname != "CIImage")
		{
			NativeInterface ni = m_objects.FindInterface(iname);
			List<NativeMethod> methods = m_methods[ni];
			if (methods.Count > 0)
				has = methods.Any(m => m.Name == mname && m.IsClass == isClass);
			
			if (!has)
				has = DoBaseHasMethod(ni.BaseName, mname, isClass);
		}
		
		if (!has)
		{
			switch (mname)
			{
				case "description":
				case "hash":
				case "init":
				case "isProxy":
				case "zone":
					has = true;
					break;
			}
		}
		
		return has;
	}
	
	private string DoGetMethodSuffix(NativeMethod method)
	{
		string suffix = string.Empty;
		
		if (m_interface.Name != "NSObject" && m_interface.Name != "CIColor" && m_interface.Name != "CIImage")
		{
			NativeInterface ri = m_objects.FindInterface(m_interface.Name);
			
			List<NativeMethod> methods;
			if (m_methods.TryGetValue(ri, out methods))
			{
				if (method.IsClass)
				{
					if (DoBaseHasMethod(ri.Name, method.Name, false))
						suffix = "_c";
				}
				else
				{
					if (DoBaseHasMethod(ri.Name, method.Name, true))
						suffix = "_i";
				}
			}
		}
		
		return suffix;
	}
	
	private void DoWriteMethodName(string name, string suffix)
	{
		if (name == "delegate")
		{
			m_buffer.Append("delegate_");
		}
		else if (name == "class")
		{
			m_buffer.Append("class_");
		}
		else if (name == "object")
		{
			m_buffer.Append("object_");
		}
		else if (name == "null")
		{
			m_buffer.Append("null_");
		}
		else if (name == "string")
		{
			m_buffer.Append("string_");
		}
		else if (name == "lock")
		{
			m_buffer.Append("lock_");
		}
		else
		{
			string[] parts = name.Split(new char[]{':'}, StringSplitOptions.RemoveEmptyEntries);
			m_buffer.Append(parts[0]);
	
			for (int i = 1; i < parts.Length; ++i)
			{
				m_buffer.Append(char.ToUpper(parts[i][0]));
				if (parts[i].Length > 1)
					m_buffer.Append(parts[i].Substring(1));
			}
		}
		m_buffer.Append(suffix);
	}
		
	private void DoWrite()
	{
		m_buffer.AppendLine();
	}
	
	private void DoWrite(string s)
	{
		m_buffer.AppendLine(s);
	}
	
	private void DoWrite(string format, params object[] args)
	{
		m_buffer.AppendLine(string.Format(format, args));
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
		
	private string DoMapEnumValue(string value)
	{
		switch (value)
		{
			case "CFByteOrderUnknown":
				return "0";

			case "CFByteOrderLittleEndian":
				return "1";

			case "CFByteOrderBigEndian":
				return "2";

			case "kCFCalendarUnitEra":
				return "(1 << 1)";

			case "kCFCalendarUnitYear":
				return "(1 << 2)";

			case "kCFCalendarUnitMonth":
				return "(1 << 3)";

			case "kCFCalendarUnitDay":
				return "(1 << 4)";

			case "kCFCalendarUnitHour":
				return "(1 << 5)";

			case "kCFCalendarUnitMinute":
				return "(1 << 6)";

			case "kCFCalendarUnitSecond":
				return "(1 << 7)";

			case "kCFCalendarUnitWeek":
				return "(1 << 8)";

			case "kCFCalendarUnitWeekday":
				return "(1 << 9)";

			case "kCFCalendarUnitWeekdayOrdinal":
				return "(1 << 10)";

			case "kCFCalendarComponentsWrap":
				return "(1 << 0)";

			case "kCFDateFormatterNoStyle":
				return "0";

			case "kCFDateFormatterShortStyle":
				return "1";

			case "kCFDateFormatterMediumStyle":
				return "2";

			case "kCFDateFormatterLongStyle":
				return "3";

			case "kCFDateFormatterFullStyle":
				return "4";

			case "kCFNumberFormatterNoStyle":
				return "0";

			case "kCFNumberFormatterDecimalStyle":
				return "1";

			case "kCFNumberFormatterCurrencyStyle":
				return "2";

			case "kCFNumberFormatterPercentStyle":
				return "3";

			case "kCFNumberFormatterScientificStyle":
				return "4";

			case "kCFNumberFormatterSpellOutStyle":
				return "5";

			case "kCFNumberFormatterPadBeforePrefix":
				return "0";

			case "kCFNumberFormatterPadAfterPrefix":
				return "1";

			case "kCFNumberFormatterPadBeforeSuffix":
				return "2";

			case "kCFNumberFormatterPadAfterSuffix":
				return "3";

			case "kCFNumberFormatterRoundCeiling":
				return "0";

			case "kCFNumberFormatterRoundFloor":
				return "1";

			case "kCFNumberFormatterRoundDown":
				return "2";

			case "kCFNumberFormatterRoundUp":
				return "3";

			case "kCFNumberFormatterRoundHalfEven":
				return "4";

			case "kCFNumberFormatterRoundHalfDown":
				return "5";

			case "kCFNumberFormatterRoundHalfUp":
				return "6";

			case "kCFPropertyListImmutable":
				return "0";

			case "kCFPropertyListMutableContainers":
				return "1";

			case "kCFPropertyListMutableContainersAndLeaves":
				return "2";

			case "kCFPropertyListOpenStepFormat":
				return "1";

			case "kCFPropertyListXMLFormat_v1_0":
				return "100";

			case "kCFPropertyListBinaryFormat_v1_0":
				return "200";

			case "NSIntegerMax":
				return "int.MaxValue";
				
			case "NX_TABLET_POINTER_UNKNOWN":
				return "0";

			case "NX_TABLET_POINTER_PEN":
				return "1";

			case "NX_TABLET_POINTER_CURSOR":
				return "2";

			case "NX_TABLET_POINTER_ERASER":
				return "3";

			case "NX_TABLET_BUTTON_PENTIPMASK":
				return "0x0001";

			case "NX_TABLET_BUTTON_PENLOWERSIDEMASK":
				return "0x0002";

			case "NX_TABLET_BUTTON_PENUPPERSIDEMASK":
				return "0x0004";

			case "NX_SUBTYPE_DEFAULT":
				return "0";

			case "NX_SUBTYPE_TABLET_POINT":
				return "1";

			case "NX_SUBTYPE_TABLET_PROXIMITY":
				return "2";
		}
		
		return value;
	}
	#endregion
	
	#region Private Types -----------------------------------------------------
	private sealed class NameInfo
	{
		public NameInfo(string name)
		{
			Native = name;
			Managed = DoSanitize(name);
		}
		
		public string Native {get; private set;}
	
		public string Managed {get; private set;}
		
		private string DoSanitize(string name)
		{
			switch (name)
			{
				case "abstract":
				case "as":
				case "ascending":
				case "base":
				case "bool":
				case "breakby":
				case "byte":
				case "case":
				case "catch":
				case "char":
				case "checked":
				case "class":
				case "const":
				case "continue":
				case "decimal":
				case "default":
				case "delegate":
				case "descending":
				case "do":
				case "double":
				case "else":
				case "enum":
				case "event":
				case "explicit":
				case "extern":
				case "false":
				case "finally":
				case "from":
				case "fixed":
				case "float":
				case "for":
				case "foreach":
				case "get":
				case "goto":
				case "group":
				case "if":
				case "implicit":
				case "in":
				case "int":
				case "interface":
				case "internal":
				case "into":
				case "is":
				case "let":
				case "lock":
				case "long":
				case "namespace":
				case "new":
				case "null":
				case "object":
				case "operator":
				case "orderby":
				case "out":
				case "override":
				case "params":
				case "partial":
				case "private":
				case "protected":
				case "public":
				case "readonly":
				case "ref":
				case "return":
				case "sbyte":
				case "sealed":
				case "select":
				case "set":
				case "short":
				case "sizeof":
				case "stackalloc":
				case "static":
				case "string":
				case "struct":
				case "switch":
				case "this":
				case "throw":
				case "true":
				case "try":
				case "typeof":
				case "uint":
				case "ulong":
				case "unchecked":
				case "unsafe":
				case "ushort":
				case "using":
				case "var":
				case "virtual":
				case "void":
				case "volatile":
				case "while":
				case "where":
				case "yield":
					return name + "_";
			}
			
			return name;
		}
	}
	
	private class TypeInfo
	{
		public TypeInfo(ObjectModel objects, NativeInterface ni, NativeMethod method)
		{
			Native = method.ReturnType;

			string type = objects.MapResult(ni.Name, method.Name, method.ReturnType);
			Managed = MapType(objects, type);
			if (Managed == "IBAction")
				Managed = "void";
		}
			
		protected TypeInfo(string native, string managed)
		{
			Native = native;
			Managed = managed;
		}
			
		// This will be "NSObject *", "NSString *", "int *", etc.
		public string Native {get; private set;}
	
		// This will be "NSObject", "NSString", "out Int32", etc.
		public string Managed {get; private set;}
	
		protected static string MapType(ObjectModel objects, string type)
		{
			type = objects.MapType(type);				// note that this is word to word with no spaces in the words
	
			switch (type)
			{
				case "BOOL":
				case "Boolean":
					return "bool";
					
				case "unsigned char":
				case "uint8_t":
					return "byte";
					
				case "unichar":
					return "char";
					
				case "double":
					return "double";
					
				case "CGFloat":
				case "float":
					return "float";
					
				case "AEReturnID":
				case "AESendPriority":
				case "OSErr":
				case "short":
					return "Int16";
					
				case "AESendMode":
				case "AETransactionID":
				case "GLint":
				case "GLsizei":
				case "int":
				case "int32_t":
				case "long":
				case "NSComparisonResult":
				case "NSInteger":
				case "OSStatus":
				case "SInt32":
				case "SRefCon":
					return "Int32";
					
				case "int64_t":
				case "long long":
					return "Int64";
					
				case "CFRunLoopRef":
				case "CGColorSpaceRef":
				case "CGEventRef":
				case "CGImageRef":
				case "char *":
				case "const NSGlyph *":
				case "const void *":
				case "id *":
				case "IconRef":
				case "NSAppleEventManagerSuspensionID":
				case "NSDistantObject *":
				case "NSGlyph *":
				case "NSModalSession":
				case "NSPointArray":
				case "NSPointPointer":
				case "NSRangePointer":
				case "NSRectArray":
				case "NSRectPointer":
				case "NSSizeArray":
				case "NSZone *":
				case "unichar *":
				case "va_list":
				case "void *":
					return "IntPtr";
					
				case "CIColor *":
				case "CIImage *":
				case "id":
				case "NSEntityDescription *":
				case "NSFetchRequest *":
				case "NSManagedObjectContext *":
					return "NSObject";
																	
				case "CGPoint":
					return "NSPoint";
																	
				case "CGRect":
					return "NSRect";
																	
				case "CGSize":
					return "NSSize";
																	
				case "AEArrayType":
				case "signed char":
					return "sbyte";
					
				case "SEL":
					return "Selector";
					
				case "const char *":
				case "const unichar *":
				case "NSString *":
					return "string";
					
				case "uint16_t":
				case "unsigned short":
					return "UInt16";
					
				case "AEEventClass":
				case "AEEventID":
				case "AEKeyword":
				case "DescType":
				case "FourCharCode":
				case "GLbitfield":
				case "GLenum":
				case "NSAttributeType":
				case "NSGlyph":
				case "NSUInteger":
				case "OSType":
				case "ResType":
				case "uint32_t":
				case "unsigned":
				case "unsigned int":
				case "UTF32Char":
					return "UInt32";
					
				case "unsigned long":
				case "unsigned long long":
					return "UInt64";
					
				default:
					if (type.StartsWith("const "))
						type = type.Substring("const ".Length, type.Length - "const ".Length).Trim();
						
					if (type.EndsWith("**") || type.StartsWith("inout ") || type.Contains("["))
					{
						return "IntPtr";
					}
					else if (type.Contains("<") && type.Contains(">"))
					{
						return "NSObject";		// TODO: should probably add interfaces for protocols
					}
					else if (type.EndsWith("*"))
					{
						type = type.Substring(0, type.Length - 1).Trim();
						type = objects.MapType(type);
	
						if (type.StartsWith("NS") && type != "NSInteger" && type != "NSUInteger")
						{
							return type;
						}
						else
						{
							return "IntPtr";
						}
					}
					else
					{
						type = objects.MapType(type);
						return type;
					}					
			}		
		}
	}
	
	private sealed class ArgTypeInfo : TypeInfo
	{
		public ArgTypeInfo(ObjectModel objects, string name) : base(name, DoMapArgType(objects, name))
		{
		}
				
		// This will be "", "", "Int32", etc.
		public string ManagedOut 
		{
			get
			{
				if (Managed.StartsWith("out "))
					return Managed.Substring("out ".Length);
				else
					return string.Empty;
			}
		}
	
		private static string DoMapArgType(ObjectModel objects, string inType)
		{
			string type = objects.MapType(inType);				// note that this is word to word with no spaces in the words
	
			switch (type)
			{
				case "BOOL *":
				case "Boolean *":
					return "out bool";
					
				case "unsigned char *":
				case "uint8_t *":
					return "out byte";
					
				case "unichar *":
					return "out char";
					
				case "double *":
					return "out double";
					
				case "CGFloat *":
				case "float *":
					return "out float";
					
				case "short *":
					return "out Int16";
					
				case "GLint *":
				case "GLsizei *":
				case "int *":
				case "int32_t *":
				case "long *":
				case "NSInteger *":
				case "SInt32 *":
					return "out Int32";
					
				case "int64_t *":
				case "long long *":
					return "out Int64";
					
				case "signed char *":
					return "out sbyte";
					
				case "NSString **":
					return "out string";
					
				case "uint16_t *":
				case "unsigned short *":
					return "out UInt16";
					
				case "uint32_t *":
				case "unsigned *":
				case "unsigned int *":
				case "UTF32Char *":
					return "out UInt32";
					
				case "unsigned long *":
				case "unsigned long long *":
					return "out UInt64";
					
				case "SEL":
					return "string";
					
				default:
					return MapType(objects, inType);
			}		
		}
	}
	
	private sealed class MethodInfo
	{
		public MethodInfo(ObjectModel objects, NativeInterface ni, NativeMethod method)
		{
			Name = method.Name;
			ResultType = new TypeInfo(objects, ni, method);
			
			var argNames = new List<NameInfo>();
			var argTypes = new List<ArgTypeInfo>();
			
			for (int i = 0; i < method.ArgNames.Length; ++i)
			{
				argNames.Add(new NameInfo(method.ArgNames[i]));
				argTypes.Add(new ArgTypeInfo(objects, method.ArgTypes[i]));
				
				if (argTypes[argTypes.Count - 1].ManagedOut.Length > 0)
					HasOutArgs = true;
			}
			
			ArgNames = argNames.ToArray();
			ArgTypes = argTypes.ToArray();
		}
						
		public string Name {get; private set;}
	
		public TypeInfo ResultType {get; private set;}
	
		public NameInfo[] ArgNames {get; private set;}
		public ArgTypeInfo[] ArgTypes {get; private set;}

		public bool HasOutArgs {get; private set;}
	}
	#endregion

	#region Fields ------------------------------------------------------------
	private string m_inPath;
	private ObjectModel m_objects;
	private StringBuilder m_buffer;
	private NativeInterface m_interface;
	private Blacklist[] m_blacklist;
	private Dictionary<NativeInterface, List<NativeMethod>> m_methods = new Dictionary<NativeInterface, List<NativeMethod>>();
	#endregion
}

