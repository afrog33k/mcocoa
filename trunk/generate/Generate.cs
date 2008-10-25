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
	}
					
	public void Code(string outDir, Blacklist[] blacklist)
	{	
		m_blacklist = blacklist;

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
				DoWrite();
		
				DoWrite("namespace MCocoa");
				DoWrite("{");
							
				DoEnums(buffer, file);
				DoInterfaces(buffer, file);
		
				m_buffer = buffer;
				DoWrite("}");
		
				string outPath = Path.Combine(outDir, hfile + ".cs");
				File.WriteAllText(outPath, buffer.ToString());
			}
		}
	}
	
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
		
	private void DoInterfaces(StringBuilder buffer, NativeFile file)
	{
		for (int i = 0; i < file.Interfaces.Count; ++i)
		{			
			m_buffer = new StringBuilder();
			if (i > 0)	
				DoWrite();

			m_interface = file.Interfaces[i];
			
			DoWriteInterfaceHeader();	
			DoGenerateMethods1();
			DoWriteInterfaceTrailer();
			
			if (m_interface.Category != null)
			{
				if (m_interface.Methods.Any(m => m.IsClass))
				{
					if (m_interface.Name != "NSObject")
					{
						NativeInterface ni = m_objects.FindInterface(m_interface.Name);
						
						DoWrite();
						DoWrite("	public partial class {0} : {1}", ni.Name, ni.BaseName);
						DoWrite("	{");
						DoGenerateMethods2();
						DoWrite("	}");
					}
					else
					{
						for (int j = 0; j < m_interface.Methods.Count; ++j)
						{
							NativeMethod method = m_interface.Methods[j];
							if (method.IsClass)
							{
								DoWrite("		// skipping NSObject class category method {0}", method.Name);
								Console.Error.WriteLine("found NSObject class category method {0}::{1}", m_interface.Name, method.Name);
							}
						}
					}
				}
			}
			
			buffer.Append(m_buffer.ToString());
		}
	}
		
	private void DoWriteInterfaceHeader()
	{		
		if (m_interface.Category != null)
		{
			DoWrite("	public static class {0}For{1}Category", m_interface.Category, m_interface.Name);
			DoWrite("	{");
		}
		else
		{
			DoWrite("	[Register]");
			DoWrite("	public partial class {0} : {1}", m_interface.Name, m_interface.BaseName);
			DoWrite("	{");
			DoWrite("		public {0}() : base(ms_class.Alloc().init())", m_interface.Name);
			DoWrite("		{");
			DoWrite("			autorelease();");
			DoWrite("		}");
			DoWrite();
			DoWrite("		public {0}(IntPtr instance) : base(instance)", m_interface.Name);
			DoWrite("		{");
			DoWrite("		}");
			DoWrite();
			DoWrite("		public {0}(Untyped instance) : base(instance)", m_interface.Name);
			DoWrite("		{");
			DoWrite("		}");
			DoWrite();
			DoWrite("		public static new {0} alloc()", m_interface.Name);
			DoWrite("		{");
			DoWrite("			return new {0}(ms_class.Call(\"alloc\"));", m_interface.Name);
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
	
	private int DoGenerateMethods1()	
	{
		int numMethods = 0;
		
		if (m_interface.Methods.Count > 0 && m_interface.Category == null)
			DoWrite();

		var names = new List<string>();
		names.Add("init");
		names.Add("description");
		names.Add("isProxy");
		names.Add("zone");
		
		bool writeBlank = false;
		for (int i = 0; i < m_interface.Methods.Count; ++i)
		{
			NativeMethod method = m_interface.Methods[i];

			if (!method.IsClass || m_interface.Category == null)
			{
				if (names.IndexOf(method.Name) < 0)
				{
					if (DoGenerateMethod(method, writeBlank))
					{
						++numMethods;
						names.Add(method.Name);
						writeBlank = true;
					}
				}
				else
					DoWrite("		// skipping {0} (it's already defined)", method.Name);				
			}
		}
				
		foreach (string protocol in m_interface.Protocols)
			if (!DoHasProtocol(m_interface.BaseName, protocol))
				if (protocol != "NSObject")
					DoGenerateProtocolMethods(names, protocol);
					
		return numMethods;
	}
	
	private int DoGenerateMethods2()	
	{
		int numMethods = 0;
		
		if (m_interface.Methods.Count > 0 && m_interface.Category == null)
			DoWrite();

		var names = new List<string>();
		names.Add("init");
		names.Add("description");
		names.Add("isProxy");
		names.Add("zone");
		
		bool writeBlank = false;
		for (int i = 0; i < m_interface.Methods.Count; ++i)
		{
			NativeMethod method = m_interface.Methods[i];

			if (names.IndexOf(method.Name) < 0)
			{
				if (method.IsClass && m_interface.Category != null)
				{
					if (DoGenerateMethod(method, writeBlank))
					{
						++numMethods;
						names.Add(method.Name);
						writeBlank = true;
					}
				}
			}
			else
				DoWrite("		// skipping {0} (it's already defined)", method.Name);				
		}
									
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
			if (names.IndexOf(method.Name) < 0)
			{
				if (DoGenerateMethod(method, writeBlank))
				{
					names.Add(method.Name);
					writeBlank = true;
				}
			}
		}
			
		foreach (string p2 in protocol.Protocols)
			if (p2 != "NSObject")
				DoGenerateProtocolMethods(names, p2);
		
		DoWrite("		#endregion");
	}
	
	private bool DoGenerateMethod(NativeMethod nm, bool writeBlank)	
	{		
		bool wrote = false;
		
		if (!DoBaseHasMethod(m_interface.BaseName, nm.Name))
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
			DoWrite("		// skipping {0} (it's declared in a base class)", nm.Name);
		
		return wrote;
	}
	
	private bool DoBaseHasMethod(string iname, string mname)
	{
		bool has = false;
		
		if (iname != null && iname != "NSObject")
		{
			NativeInterface ni = m_objects.FindInterface(iname);
			if (ni.Methods.Count > 0)
				has = ni.Methods.Any(m => m.Name == mname);
			
			if (!has)
				has = DoBaseHasMethod(ni.BaseName, mname);
		}
		
		return has;
	}
	
	private void DoWriteMethod(NativeMethod method)
	{		
		// signature		
		m_buffer.Append("		public ");
		if (method.IsClass || m_interface.Category != null)
			m_buffer.Append("static ");
			
		if (method.ReturnType == "IBAction")
			method.ReturnType = "void";
			
		DoWriteType(method.ReturnType);
		m_buffer.Append(" ");
		DoWriteMethodName(method.Name);
		m_buffer.Append("(");
		if (m_interface.Category != null && !method.IsClass)
		{
			m_buffer.Append("this ");
			m_buffer.Append(m_interface.Name);
			m_buffer.Append(" _instance");
			if (method.ArgNames.Length > 0)
				m_buffer.Append(", ");
		}
		for (int i = 0; i < method.ArgNames.Length; ++i)
		{			
			DoWriteType(method.ArgTypes[i]);
			m_buffer.Append(" ");
			m_buffer.Append(DoSanitize(method.ArgNames[i]));
			
			if (i + 1 < method.ArgNames.Length)
				m_buffer.Append(", ");
		}
		m_buffer.AppendLine(")");

		DoWrite("		{");
		
		// body
		if (method.ReturnType == "void")
			m_buffer.Append("			Unused.Value = ");
		else
			m_buffer.Append("			return ");
			
		string rtype = DoMapType(method.ReturnType);
		if (DoIsCastable(rtype))
		{
			m_buffer.Append("(");
			m_buffer.Append(rtype);
			m_buffer.Append(") ");
		}
		
		if (m_interface.Category != null && !method.IsClass)
			m_buffer.Append("_instance.");
		else if (method.IsClass)
			m_buffer.Append("ms_class.");

		m_buffer.Append("Call(\"");
		m_buffer.Append(method.Name);
		m_buffer.Append("\"");
		
		for (int i = 0; i < method.ArgNames.Length; ++i)
		{
			m_buffer.Append(", ");
			m_buffer.Append(DoSanitize(method.ArgNames[i]));
		}
		m_buffer.Append(")");
		if (rtype != "void" && !DoIsCastable(rtype))
		{
			m_buffer.Append(".To<");
			m_buffer.Append(rtype);
			m_buffer.Append(">()");
		}
		m_buffer.AppendLine(";");
		
		// trailer
		DoWrite("		}");
	}
	
	private bool DoIsCastable(string type)
	{
		switch (type)
		{
			case "bool":
			case "Boolean":
			case "byte":
			case "Byte":
			case "char":
			case "Char":
			case "short":
			case "Int16":
			case "int":
			case "Int32":
			case "long":
			case "Int64":
			case "sbyte":
			case "ushort":
			case "UInt16":
			case "uint":
			case "UInt32":
			case "ulong":
			case "Uint64":
			case "float":
			case "Single":
			case "double":
			case "Double":
			case "IntPtr":
			case "Class":
			case "Selector":
			case "string":
			case "String":
				return true;
		}
		
		return false;
	}
	
	private void DoWriteMethodName(string name)
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
	}
	
	private void DoWriteType(string type)
	{
		type = DoMapType(type);
		m_buffer.Append(type);		
	}
	
	private string DoMapType(string type)
	{
		type = m_objects.MapType(type);				// note that this is word to word with no spaces in the words

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
			case "NSComparisonResult":
			case "NSInteger":
			case "OSStatus":
			case "SInt32":
			case "SRefCon":
				return "Int32";
				
			case "int64_t":
			case "long":
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
					type = m_objects.MapType(type);

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
					type = m_objects.MapType(type);
					return type;
				}					
		}		
	}
	
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
	
	private string m_inPath;
	private ObjectModel m_objects;
	private StringBuilder m_buffer;
	private NativeInterface m_interface;
	private Blacklist[] m_blacklist;
}

