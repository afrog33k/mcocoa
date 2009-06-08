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
using MObjc.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

internal class MakeBuilder
{
	public MakeBuilder(string contents)
	{
		Contract.Requires(contents != null, "contents is null, is the file ascii?");
		
		try
		{
			m_scanner = NSScanner.scannerWithString(NSString.Create(contents));
			m_scanner.setCharactersToBeSkipped(NSCharacterSet.whitespaceCharacterSet());	// does not include new lines
			m_scanner.setCaseSensitive(true);
			
			m_nameChars = NSMutableCharacterSet.Create();
			m_nameChars.formUnionWithCharacterSet(NSCharacterSet.alphanumericCharacterSet());		
			m_nameChars.addCharactersInString(NSString.Create("_-"));
			
			m_eolChars = NSMutableCharacterSet.Create();
			m_eolChars.addCharactersInString(NSString.Create("\r\n#"));		// lines are ended by comments or new line characters
			
			DoParse();
			
			for (int i = 0; i < 4; ++i)			// add some blank lines so the user can define new variables that we couldn't pull out of the make file
				m_variables.Add(new EnvVar(string.Empty, string.Empty));
		}
		catch (Exception e)
		{
			Console.Error.WriteLine("MakeBuilder raised an exception:");
			Console.Error.WriteLine("{0}", e);
			throw;
		}
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
		
	public string Command
	{
		get {return m_command;}
	}
	
	#region Private Methods
	public void DoParse()
	{
		while (!m_scanner.isAtEnd())
		{
			NSString name, token;
			if (m_scanner.scanCharactersFromSet_intoString(m_nameChars, out name))
			{
				if (name.ToString() == "ifdef" || name.ToString() == "ifndef")
				{
					EnvVar v = DoParseDefine();
					if (v != null)
						if (!m_variables.Any(x => x.Name == v.Name))
							m_variables.Add(v);
				}
				else if (m_scanner.scanString_intoString(NSString.Create(":"), out token))
				{
					if (!m_scanner.scanString_intoString(NSString.Create("="), out token))
						if (name.ToString() != "else" && !DoIsAutomake(name.ToString()))
							m_targets.Add(name.ToString());
				}
				else
				{
					EnvVar v = DoParseVariable(name.ToString());
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
			
			DoSkipToNextLine();
		}
	}
	
	// Target := Name '?=' .+
	private EnvVar DoParseVariable(string name)
	{
		EnvVar variable = null;
		
		NSString token;
		if (m_scanner.scanString_intoString(NSString.Create("?="), out token))
		{
			NSString value;
			if (m_scanner.scanUpToCharactersFromSet_intoString(m_eolChars, out value))
			{
				variable = new EnvVar(name, value.ToString().Trim());
			}
		}
		
		return variable;
	}
	
	// Target := ('ifdef' | 'ifndef')  Name
	private EnvVar DoParseDefine()
	{
		EnvVar variable = null;
		
		NSString name;
		if (m_scanner.scanCharactersFromSet_intoString(m_nameChars, out name))
		{
			variable = new EnvVar(name.ToString(), string.Empty);
		}
		
		return variable;
	}
			
	private void DoSkipToNextLine()
	{
		NSString token;
		m_scanner.scanUpToCharactersFromSet_intoString(NSCharacterSet.newlineCharacterSet(), out token);
		m_scanner.scanCharactersFromSet_intoString(NSCharacterSet.newlineCharacterSet(), out token);
	}
	
	private bool DoIsAutomake(string name)
	{
		switch (name)
		{
			case "all-am":
			case "check-am":
			case "check":
			case "clean-am":
			case "clean-generic":
			case "ctags-recursive":
			case "ctags":
			case "CTAGS":
			case "distclean-am":
			case "distclean-generic":
			case "distclean-tags":
			case "distclean":
			case "distdir":
			case "dvi-am":
			case "dvi":
			case "extra-bin":
			case "GTAGS":
			case "html":
			case "ID":
			case "info-am":
			case "info":
			case "install-am":
			case "install-binSCRIPTS":
			case "install-data-am":
			case "install-data":
			case "install-exec-am":
			case "install-exec":
			case "install-info":
			case "install-man":
			case "install-pixmapDATA":
			case "install-strip":
			case "installcheck-am":
			case "installcheck":
			case "installdirs-am":
			case "installdirs":
			case "maintainer-clean-am":
			case "maintainer-clean-generic":
			case "maintainer-clean-recursive":
			case "maintainer-clean":
			case "Makefile":
			case "mostlyclean-am":
			case "mostlyclean-generic":
			case "mostlyclean":
			case "pdf-am":
			case "pdf":
			case "ps-am":
			case "ps":
			case "push":
			case "tags-recursive":
			case "tags":
			case "TAGS":
			case "uninstall-am":
			case "uninstall-binSCRIPTS":
			case "uninstall-info-am":
			case "uninstall-info":
			case "uninstall-pixmapDATA":
			case "zip-bin":
				return true;
		}
		
		return false;
	}
	#endregion
	
	#region Fields
	private List<string> m_targets = new List<string>();
	private List<EnvVar> m_variables = new List<EnvVar>();
	private string m_command;
	private NSScanner m_scanner;
	private NSMutableCharacterSet m_nameChars;
	private NSMutableCharacterSet m_eolChars;
	#endregion
}
