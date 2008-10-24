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
using System.Diagnostics;
using System.IO;

internal class MakeBuilder
{
	public MakeBuilder(string contents)
	{
		m_contents = contents;
		m_index = 0;
		
		DoParse();
	}
	
	public Process Build(string buildFile, string target, List<KeyValuePair<string, string>> vars, Dictionary<string, int> flags)
	{	
		string args = string.Empty;

		foreach (KeyValuePair<string, int> f in flags)
			if (f.Value == 1)
				args += string.Format("--{0} ", f.Key);

		foreach (KeyValuePair<string, string> v in vars)
			if (v.Value.Length > 0)
				args += string.Format("{0}={1} ", v.Key, v.Value);
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
	
	public string[] Variables
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
	
	#region Private Methods
	public void DoParse()
	{		
		while (!AtEnd)
		{
			do
			{
				string target = DoParseTarget();
				if (target != null)
				{
					if (m_ignore.IndexOf(target) < 0)
						m_targets.Add(target);
					break;
				}
				
				string v = DoParseVariable();
				if (v != null)
				{
					if (m_variables.IndexOf(v) < 0)
						m_variables.Add(v);
					break;
				}

				v = DoParseDefine();
				if (v != null)
				{
					if (m_variables.IndexOf(v) < 0)
						m_variables.Add(v);
					break;
				}

				DoParseCommand();
			}
			while (false);
			
			DoSkipToNextLine();
		}
	}
	
	private bool AtEnd
	{
		get {return m_index == m_contents.Length;}
	}
	
	// natty-ignore: install uninstall keys
	// natty-default: lib
	private void DoParseCommand()
	{
		string command = "# natty-ignore:";
		if (string.Compare(m_contents, m_index, command, 0, command.Length) == 0)
		{
			int k = m_index + command.Length;
			int j = k;
			while (j < m_contents.Length && m_contents[j] != '\n' && m_contents[j] != '\r')
				++j;
				
			string ignore = m_contents.Substring(k, j - k);
			m_ignore.AddRange(ignore.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries));
			
			m_index = j;
		}

		command = "# natty-default:";
		if (string.Compare(m_contents, m_index, command, 0, command.Length) == 0)
		{
			int j = m_index + command.Length;
			while (j < m_contents.Length && m_contents[j] == ' ')
				++j;
			
			int k = j;
			while (j < m_contents.Length && IsNameChar(m_contents[j]))
				++j;
				
			m_default = m_contents.Substring(k, j - k);
			
			m_index = j;
		}
	}
	
	// Target := Letter NameChar* ' '+ '?=' ' '+ .+
	private string DoParseVariable()
	{
		string variable = null;
		
		int j = m_index;
		while (j < m_contents.Length && (m_contents[j] == ' ' || m_contents[j] == '\t'))
			++j;
			
		int l = j;

		// Letter
		if (char.IsLetter(m_contents[j]))
		{
			// NameChar*
			while (j < m_contents.Length && IsNameChar(m_contents[j]))
				++j;
				
			int k = j;
			
			// ' '+
			if (j < m_contents.Length && m_contents[j] == ' ')
			{
				while (j < m_contents.Length && m_contents[j] == ' ')
					++j;
				
				// '?=' ' '+ .+
				if (j + 1 < m_contents.Length && m_contents[j] == '?' && m_contents[j+1] == '=')
				{
					j += 2;
					
					if (j < m_contents.Length && m_contents[j] == ' ')
					{
						variable = m_contents.Substring(l, k - l);
						m_index = j;
					}
				}
			}
		}
		
		return variable;
	}
	
	// Target := ('ifdef' | 'ifndef') ' '+ Letter NameChar* 
	private string DoParseDefine()
	{
		string variable = null;
		
		int j = m_index;
		while (j < m_contents.Length && (m_contents[j] == ' ' || m_contents[j] == '\t'))
			++j;
		
		// 'ifdef' | 'ifndef'
		if (j + 4 < m_contents.Length && 
			m_contents[j+0] == 'i' && 
			m_contents[j+1] == 'f' &&
			m_contents[j+2] == 'd' &&
			m_contents[j+3] == 'e' &&
			m_contents[j+4] == 'f')
			j += 5;
		else if (j + 5 < m_contents.Length && 
			m_contents[j+0] == 'i' && 
			m_contents[j+1] == 'f' &&
			m_contents[j+2] == 'n' &&
			m_contents[j+3] == 'd' &&
			m_contents[j+4] == 'e' &&
			m_contents[j+5] == 'f')
			j += 6;
		else
			return null;
			
		// ' '+
		if (j < m_contents.Length && m_contents[j] == ' ')
		{
			while (j < m_contents.Length && m_contents[j] == ' ')
				++j;
				
			int l = j;
			
			// Letter
			if (char.IsLetter(m_contents[j]))
			{
				// NameChar*
				while (j < m_contents.Length && IsNameChar(m_contents[j]))
					++j;
									
				variable = m_contents.Substring(l, j - l);
				m_index = j;
			}
		}
		
		return variable;
	}
	
	// Target := Letter NameChar* ' '* ':' (' ' | Letter | NewLine)
	private string DoParseTarget()
	{
		string target = null;
		
		// Letter
		if (char.IsLetter(m_contents[m_index]))
		{
			// NameChar*
			int j = m_index;
			while (j < m_contents.Length && IsNameChar(m_contents[j]))
				++j;
			
			// ' '*
			while (j < m_contents.Length && m_contents[j] == ' ')
				++j;
			
			// ':' (' ' | Letter | NewLine)
			if (j < m_contents.Length && m_contents[j] == ':')
			{
				int k = j++;
				if (j < m_contents.Length && (
					m_contents[j] == ' ' || 
					char.IsLetter(m_contents[j]) || 
					m_contents[j] == '\n' || 
					m_contents[j] == '\r'))
				{
					target = m_contents.Substring(m_index, k - m_index);
					m_index = j;
				}
			}
		}
		
		return target;
	}
	
	// NameChar := Letter | [0-9_-\.]
	private bool IsNameChar(char ch)
	{
		return char.IsLetterOrDigit(ch) || ch == '_' || ch == '-' || ch == '.';
	}
	
	private void DoSkipToNextLine()
	{
		while (m_index < m_contents.Length && m_contents[m_index] != '\n' && m_contents[m_index] != '\r')
			++m_index;

		while (m_index < m_contents.Length && (m_contents[m_index] == '\n' || m_contents[m_index] == '\r'))
			++m_index;
	}
	#endregion
	
	#region Fields
	private List<string> m_targets = new List<string>();
	private List<string> m_variables = new List<string>();
	private List<string> m_ignore = new List<string>();
	private string m_default;
	private string m_command;
	private string m_contents;
	private int m_index;
	#endregion
}
 