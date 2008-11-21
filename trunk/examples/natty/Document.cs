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
using System.Runtime.InteropServices;

public enum State {Opened, Building, Built, Canceled};

[ExportClass("Document", "NSDocument")]
internal sealed class Document : NSDocument
{
	public Document(IntPtr instance) : base(instance)
	{
		m_flags.Add("always-make", 0);
		m_flags.Add("ignore-errors", 0);
		m_flags.Add("debug", 0);
		m_flags.Add("dry-run", 0);
		m_flags.Add("keep-going", 0);
		m_flags.Add("warn-undefined-variables", 0);
	}
	
	// May be null if there are no targets.
	public string Target
	{
		get {return m_target;}
		set {m_target = value; SavePrefs();}
	}
			
	public string[] Targets
	{
		get {return m_builder.Targets;}
	}
						
	public List<EnvVar> Variables
	{
		get {return m_vars;}
	}
						
	public Dictionary<string, int> Flags
	{
		get {return m_flags;}
	}
						
	public State State
	{
		get {return m_state;}
	}
		
	public string Path
	{
		get {return fileURL().path().ToString();}
	}
	
	public int ExitCode
	{
		get {return m_exitCode;}
	}
	
	public string Editor()
	{
		NSUserDefaults defaults = NSUserDefaults.standardUserDefaults();

		string editor = defaults.stringForKey(NSString.Create("editor")).To<NSString>().ToString();
		if (editor == null)
			editor = "bbedit {0}:{1}";
			
		return editor;
	}
						
	public string IgnoredTargets()
	{
		NSUserDefaults defaults = NSUserDefaults.standardUserDefaults();

		string key = fileURL().absoluteString() + "-ignored";
		string ignored = defaults.stringForKey(NSString.Create(key)).To<NSString>().ToString();
			
		return ignored ?? string.Empty;
	}
						
	public EventHandler StateChanged;
	public delegate void DataHandler(Document doc, string data);
	public event DataHandler CommandData;
	public event DataHandler StdoutData;
	public event DataHandler StderrData;
	
	public void Build()
	{
		m_state = State.Building;
		if (StateChanged != null)
			StateChanged(this, EventArgs.Empty); 
			
		m_exitCode = 0;
		NSApplication app = NSApplication.sharedApplication();
		
		m_process = m_builder.Build(fileURL().path().ToString(), m_target, m_vars, m_flags);
		m_process.EnableRaisingEvents = true;
		m_process.Exited += (s, e) => {app.BeginInvoke(this.DoProcessExited);};
		m_process.StartInfo.RedirectStandardOutput = true;
		m_process.StartInfo.RedirectStandardError = true;
		m_process.OutputDataReceived += this.DoGotStdoutData;
		m_process.ErrorDataReceived += this.DoGotStderrData;
		
		if (CommandData != null)
			CommandData(this, m_builder.Command);

		m_process.Start();
		
		m_process.BeginOutputReadLine();
		m_process.BeginErrorReadLine();
	}

	public void Cancel()
	{
		m_state = State.Canceled;		
		m_process.Kill();
		
		if (StateChanged != null)
			StateChanged(this, EventArgs.Empty);
	}
	
	public void SavePrefs()
	{
		// environment variables
		string key = fileURL().absoluteString() + "-variables";
		
		NSMutableDictionary dict = NSMutableDictionary.Create();
		foreach (var entry in m_vars)
		{
			if (entry.Value.Length > 0 && entry.Value != entry.DefaultValue)
				dict.setObjectForKey(NSString.Create(entry.Value), NSString.Create(entry.Name));
		}
		
		NSUserDefaults defaults = NSUserDefaults.standardUserDefaults();
		defaults.setObjectForKey(dict, NSString.Create(key));
		
		// default target
		key = fileURL().absoluteString() + "-defaultTarget";
		defaults.setObjectForKey(NSString.Create(m_target), NSString.Create(key));
	}
	
	public void LoadPrefs()
	{
		// environment variables
		string key = fileURL().absoluteString() + "-variables";
		string value;
				
		NSUserDefaults defaults = NSUserDefaults.standardUserDefaults();
		NSObject pref = defaults.objectForKey(NSString.Create(key));
		if (!NSObject.IsNullOrNil(pref))
		{
			NSMutableDictionary dict = pref.To<NSMutableDictionary>();

			foreach (var entry in dict)
			{
				string name = entry.Key.ToString();
				value = entry.Value.ToString();
		
				int i = m_vars.FindIndex(e => e.Name == name);
				if (i >= 0)
				{
					m_vars[i].Value = value;
				}
				else
				{
					EnvVar v = new EnvVar(name, string.Empty);
					v.Value = value;
					i = m_vars.FindIndex(e => e.Name.Length == 0);
					if (i >= 0)
						m_vars.Insert(i, v);
					else
						m_vars.Add(v);
				}
			}
		}
		
		// default target
		key = fileURL().absoluteString() + "-defaultTarget";
		value = defaults.stringForKey(NSString.Create(key)).To<NSString>().ToString();
		if (value != null && Array.IndexOf(m_builder.Targets, value) >= 0)
			m_target = value;
		else
			m_target = m_builder.Targets[0];
	}
	
	#region Overrides ---------------------------------------------------------
	[Register("readFromData:ofType:error:")]		
	public bool ReadFromDataOfTypeError(NSData data, NSString typeName, IntPtr outError)
	{
		bool read = true;
		
		try
		{
			IntPtr buffer = data.bytes();
			string contents = Marshal.PtrToStringAuto(buffer);
			
			m_builder = new MakeBuilder(contents);
			
			m_vars.Clear();
			m_vars.AddRange(m_builder.Variables);
			LoadPrefs();
		}
		catch (Exception e)
		{
			NSMutableDictionary userInfo = NSMutableDictionary.Create();
			userInfo.setObjectForKey(NSString.Create("Couldn't read the document."), NSString.Create(Externs.NSLocalizedDescriptionKey));
			userInfo.setObjectForKey(NSString.Create(e.Message), NSString.Create(Externs.NSLocalizedFailureReasonErrorKey));
			
			NSError error = new NSError(NSError.alloc().initWithDomainCodeUserInfo(
				NSString.Create(Externs.Cocoa3Domain), 1, userInfo));
			Marshal.WriteIntPtr(outError, (IntPtr) error);

			read = false;
		}
		
		return read;
	}

	public new void makeWindowControllers()
	{
		DocWindowController controller = DocWindowController.Create("Document");
		addWindowController(controller);
	}
	#endregion	

	#region Private Methods ---------------------------------------------------
	private void DoGotStdoutData(object sender, DataReceivedEventArgs e)
	{
		if (StdoutData != null)
		{
			NSApplication app = NSApplication.sharedApplication();
			app.BeginInvoke(() => StdoutData(this, e.Data + Environment.NewLine));
		}
	}

	private void DoGotStderrData(object sender, DataReceivedEventArgs e)
	{
		if (StderrData != null)
		{
			NSApplication app = NSApplication.sharedApplication();
			app.BeginInvoke(() => StderrData(this, e.Data + Environment.NewLine));
		}
	}

	private void DoProcessExited()
	{
		m_exitCode = m_process.ExitCode;
		
		m_process = null;
		
		if (m_state != State.Canceled)
			m_state = State.Built;
		
		if (StateChanged != null)
			StateChanged(this, EventArgs.Empty);
	}
	#endregion	
	
	#region Fields ------------------------------------------------------------
	private MakeBuilder m_builder;
	private string m_target;
	private State m_state;
	private Process m_process;
	private List<EnvVar> m_vars = new List<EnvVar>();
	private Dictionary<string, int> m_flags = new Dictionary<string, int>();
	
	private int m_exitCode;
	#endregion
}
