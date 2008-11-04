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

using MCocoa;
using MObjc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

internal class MakeBuilder
{
	public MakeBuilder(string contents)
	{
		m_scanner = NSScanner.scannerWithString(contents);
		m_scanner.setCharactersToBeSkipped(NSCharacterSet.whitespaceCharacterSet());	// does not include new lines
		m_scanner.setCaseSensitive(true);
		
		m_nameChars = NSMutableCharacterSet.Create();
		m_nameChars.formUnionWithCharacterSet(NSCharacterSet.alphanumericCharacterSet());		
		m_nameChars.addCharactersInString("_-");		

		m_eolChars = NSMutableCharacterSet.Create();
		m_eolChars.addCharactersInString("\r\n#");		// lines are ended by comments or new line characters
		
		DoParse();
	}
	
	public Process Build(string buildFile, string target, List<EnvVar> vars, Dictionary<string, int> flags)
	{	
		string args = string.Empty;

		foreach (KeyValuePair<string, int> f in flags)
			if (f.Value == 1)
				args += string.Format("--{0} ", f.Key);

		foreach (EnvVar v in vars)
			if (v.Value.Length > 0 && v.Value != v.DefaultValue)
				if (v.Value.IndexOf(" ") >= 0)
					args += string.Format("{0}=\"{1}\" ", v.Name, v.Value);
				else
					args += string.Format("{0}={1} ", v.Name, v.Value);
		args += target;
		
		m_command = "make " + args + Environment.NewLine;
		
		Process process = new Process();
		
		process.StartInfo.FileName               = "make";
		process.StartInfo.Arguments              = args;
		process.StartInfo.RedirectStandardError  = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute        = false;
		process.StartInfo.WorkingDirectory       = Path.GetDirectoryName(buildFile);
		
		return process;
	}
	
	public string[] Targets
	{
		get {return m_targets.ToArray();}
	}
	
	public EnvVar[] Variables
	{
		get {return m_variables.ToArray();}
	}
	
	public string Default
	{
		get {return m_default;}
	}
	
	public string Command
	{
		get {return m_command;}
	}
	
	#region Private Methods ---------------------------------------------------
	public void DoParse()
	{		
		while (!m_scanner.isAtEnd())
		{
			string name, token;
			if (m_scanner.scanCharactersFromSetIntoString(m_nameChars, out name))
			{
				if (name == "ifdef" || name == "ifndef")
				{
					EnvVar v = DoParseDefine();
					if (v != null)
						if (!m_variables.Any(x => x.Name == v.Name))
							m_variables.Add(v);
				}
				else if (m_scanner.scanStringIntoString(":", out token))
				{
					if (!m_scanner.scanStringIntoString("=", out token))
						if (m_ignore.IndexOf(name) < 0)
							m_targets.Add(name);
				}
				else
				{
					EnvVar v = DoParseVariable(name);
					if (v != null)
					{
						EnvVar old = m_variables.SingleOrDefault(x => x.Name == v.Name);
						if (old != null)
							old.DefaultValue = v.DefaultValue;
						else
							m_variables.Add(v);
					}
				}
			}
			else
				DoParseCommand();
			
			DoSkipToNextLine();
		}
	}
		
	// # natty-ignore: install uninstall keys
	// # natty-default: lib
	private void DoParseCommand()
	{
		string token;
		if (m_scanner.scanStringIntoString("#", out token))
		{
			if (m_scanner.scanStringIntoString("natty-ignore:", out token))
			{
				if (m_scanner.scanUpToCharactersFromSetIntoString(m_eolChars, out token))
				{
					string[] names = token.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
					m_ignore.AddRange(names);
				}
			}

			if (m_scanner.scanStringIntoString("natty-default:", out token))
			{
				if (m_scanner.scanUpToCharactersFromSetIntoString(m_eolChars, out token))
				{
					m_default = token;
				}
			}
		}
	}
	
	// Target := Name '?=' .+
	private EnvVar DoParseVariable(string name)
	{
		EnvVar variable = null;
				
		string token;
		if (m_scanner.scanStringIntoString("?=", out token))
		{
			string value;
			if (m_scanner.scanUpToCharactersFromSetIntoString(m_eolChars, out value))
			{
				variable = new EnvVar(name, value.Trim());
			}
		}
		
		return variable;	
	}
	
	// Target := ('ifdef' | 'ifndef')  Name
	private EnvVar DoParseDefine()
	{
		EnvVar variable = null;
		
		string name;
		if (m_scanner.scanCharactersFromSetIntoString(m_nameChars, out name))
		{
			variable = new EnvVar(name, string.Empty);
		}
		
		return variable;
	}
			
	private void DoSkipToNextLine()
	{
		string token;
		Unused.Value = m_scanner.scanUpToCharactersFromSetIntoString(NSCharacterSet.newlineCharacterSet(), out token);
		Unused.Value = m_scanner.scanCharactersFromSetIntoString(NSCharacterSet.newlineCharacterSet(), out token);
	}
	#endregion
	
	#region Fields ------------------------------------------------------------
	private List<string> m_targets = new List<string>();
	private List<EnvVar> m_variables = new List<EnvVar>();
	private List<string> m_ignore = new List<string>();
	private string m_default;
	private string m_command;
	private NSScanner m_scanner;
	private NSMutableCharacterSet m_nameChars;
	private NSMutableCharacterSet m_eolChars;
	#endregion
}
 