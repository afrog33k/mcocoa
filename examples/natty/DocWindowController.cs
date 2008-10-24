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

using Cocoa3;
using Objc3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

[ExportClass("DocWindowController", "NSWindowController", IVars = "flagsSheet envSheet targets build cancel status output outputWindow errorWindow errors")]
internal sealed class DocWindowController : NSWindowController
{
	public DocWindowController(string nibName) : base(new Class("DocWindowController"), nibName)
	{
		m_env = new IVar<EnvController>(this, "envSheet");
		m_flags = new IVar<FlagsController>(this, "flagsSheet");

		m_errorWindow = new IVar<NSWindow>(this, "errorWindow");
		m_transcriptWindow = new IVar<NSWindow>(this, "outputWindow");
		m_errorTable = new IVar<ErrorTable>(this, "errors");
		m_statusLabel = new IVar<NSTextField>(this, "status");
		m_buildBtn = new IVar<NSButton>(this, "build");
		m_cancelBtn = new IVar<NSButton>(this, "cancel");
		m_outputView = new IVar<NSTextView>(this, "output");
	}
						
	#region Action Handlers
	[NewMethod("targetChanged:")]		
	public void TargetChanged(NSPopUpButton sender)
	{
		m_doc.Target = sender.SelectedTitle;
	}

	[NewMethod("build:")]		
	public void Build(NSObject sender)
	{
		m_doc.Build();
	}

	[NewMethod("cancel:")]		
	public void Cancel(NSObject sender)
	{
		m_doc.Cancel();
	}

	[NewMethod("environment:")]		
	public void EnvironmentSheet(NSObject sender)
	{
		if (NSObject.IsNullOrNil(m_env.Value))
			NSBundle.LoadNibNamed("Environment", this);
		DBC.Assert(!NSObject.IsNullOrNil(m_env.Value), "nib didn't set envSheet");
	
		m_env.Value.Open(m_doc, Window);
    }

	[NewMethod("flags:")]		
	public void Flags(NSObject sender)
	{
		if (NSObject.IsNullOrNil(m_flags.Value))
			NSBundle.LoadNibNamed("Flags", this);
		DBC.Assert(!NSObject.IsNullOrNil(m_flags.Value), "nib didn't set flagsSheet");
	
		m_flags.Value.Open(m_doc, Window);
    }
	#endregion
	
	#region Errors Data Source
	[NewMethod("numberOfRowsInTableView:")]		
	public int NumberOfRowsInTableView(NSTableView table)
	{
		return m_errors.Count;
	}

	[NewMethod("tableView:objectValueForTableColumn:row:")]		
	public NSObject TableObjectForCell(NSTableView table, NSTableColumn column, int row)
	{
		Error error = m_errors[row];
		if (column.Identifier == "1")
			return new NSString(error.Message);
		else if (column.Identifier == "2")
			return new NSString(error.File);
		else
			return new NSString(error.Line);
	}

	[NewMethod("openSelection:")]		
	public void OpenSelection(NSObject sender)
	{
		bool opened = false;
		
		NSRange range = m_outputView.Value.Selection;
		if (range.Location != NSRange.NSNotFound)
		{
			string text = m_outputView.Value.TextStorage.ToString();
			range = DoExtendSelection(text, range);
			string file = text.Substring(range.Location, range.Length);
			
			string line = "0";
			if (range.Location + range.Length < text.Length && (text[range.Location + range.Length] == '(' || text[range.Location + range.Length] == ':'))
			{
				int i = range.Location + range.Length + 1;
				if (i < text.Length && char.IsDigit(text[i]))
				{
					int j = i;
					while (j < text.Length && char.IsDigit(text[j]))
						++j;
					line = text.Substring(i, j - i);
				}
			}
			
			opened = DoTryOpenFile(file, line);
		}
		
		if (!opened)
			NSFunctions.Beep();
	}
	
	private NSRange DoExtendSelection(string text, NSRange range)
	{
		while (DoIsFileChar(text, range.Location - 1))
		{
			--range.Location;
			++range.Length;
		}

		while (DoIsFileChar(text, range.Location + range.Length))
			++range.Length;
			
		return range;
	}
	
	private bool DoIsFileChar(string text, int index)
	{
		if (index >= 0 && index < text.Length)
		{
			if (text[index] == '\n' ||
				text[index] == '\r' ||
				text[index] == ' ' ||
				text[index] == ':' ||
				text[index] == '\'' ||
				text[index] == '"' ||
				text[index] == '(')
				return false;
			
			return true;
		}
		
		return false;
	}

	[NewMethod("openFile:")]		
	public void OpenFile(int row)
	{
		DoTryOpenFile(m_errors[row].File, m_errors[row].Line);
	}

	public bool DoTryOpenFile(string file, string line)
	{
		string path = Path.GetDirectoryName(m_doc.Path);
		if (DoOpenFile(path, file, line))
			return true;
			
		foreach (string root in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
		{
			if (!root.Contains("/.") && !root.Contains(".nib") && !root.Contains("/bin/") && !root.EndsWith("/bin"))
			{
				if (DoOpenFile(root, file, line))
					return true;
			}
		}

		return false;
	}

	public bool DoOpenFile(string root, string file, string line)
	{
		string path = Path.Combine(root, file);
		
		if (File.Exists(path))
		{
			ProcessStartInfo info = new ProcessStartInfo();
			info.Arguments        = string.Format("{0}:{1}", path, line);	// TODO: use a pref for this
			info.FileName         = "bbedit";
			info.UseShellExecute  = false;
	
			Process.Start(info);
		}
		
		return File.Exists(path);
	}
	#endregion
	
	[NewMethod("validateMenuItem:")]		
	public bool ValidateMenuItem(NSMenuItem item)
	{		
		if (item.Action.Name == "build:")
			return m_doc.State != State.Building;
		
		return true;
	}
	
	#region Overrides	
	[OverrideMethod("windowTitleForDocumentDisplayName:")]		
	public NSString WindowTitleForDocumentDisplayName(NSString displayName)
	{		
		return new NSString(DoGetTitle());
	}
	
	[OverrideMethod("windowDidLoad")]		
	public void WindowDidLoad()
	{		
		try
		{
			m_doc = Call("document").To<Document>();	
				
			m_outputView.Value.TextStorage.MutableString.Set(string.Empty);
			m_errorTable.Value.DataSource = this;
			
			ShouldCascade = false;
			m_transcriptWindow.Value.Controller.ShouldCascade = false;
			m_errorWindow.Value.Controller.ShouldCascade = false;
			
			Window.FrameAutoSaveName = m_doc.Path + "-build window";
			m_transcriptWindow.Value.FrameAutoSaveName = m_doc.Path + "-transcript window";
			m_errorWindow.Value.FrameAutoSaveName = m_doc.Path + "-error window";
			
			m_transcriptWindow.Value.Controller.NextResponder = this;
			m_errorWindow.Value.Controller.NextResponder = this;
							
			m_doc.StateChanged += this.DoDocChanged;
			m_doc.CommandData += this.DoGotCommand;
			m_doc.StdoutData += this.DoGotStdout;
			m_doc.StderrData += this.DoGotStderr;
			
			NSPopUpButton targets = new NSPopUpButton(this["targets"]);
			targets.Clear();	
			targets.AddRange(m_doc.Targets);
			
			m_buildBtn.Value.Enabled = m_doc.Targets.Length > 0;
	
			if (m_doc.Target != null)
				targets.SelectedTitle = m_doc.Target;				
		}
		catch (Exception e)
		{	
			// By default cocoa just logs a lame message to the console...
			NSAlert alert = new NSAlert();
			alert.Message = "Couldn't open the document.";
			alert.Informative = e.Message;
			alert.RunModal();
			throw;
		}
	}
	#endregion	
	
	private void DoDocChanged(object sender, EventArgs e)
	{
		switch (m_doc.State)
		{
			case State.Building:
				m_startTime = DateTime.Now;
				m_statusLabel.Value.String = "building...";
				m_statusLabel.Value.TextColor = NSColor.ControlTextColor;
				m_buildBtn.Value.Enabled = false;
				m_cancelBtn.Value.Enabled = true;
				DoShowOutput();
				m_errors.Clear();
				m_errorTable.Value.NoteNumberOfRowsChanged();
				m_errorWindow.Value.OrderOut();
				break;

			case State.Built:
				DoSetBuiltStatus();
				m_buildBtn.Value.Enabled = true;
				m_cancelBtn.Value.Enabled = false;
				DoShowOutput();
				m_outputView.Value.TextStorage.Append(Environment.NewLine, ms_stdoutAttrs);
				if (m_doc.ExitCode != 0 && m_errors.Count > 0)
					m_errorWindow.Value.MakeKeyAndOrderFront();
				break;

			case State.Canceled:
				m_statusLabel.Value.String = "canceled";
				m_statusLabel.Value.TextColor = NSColor.OrangeColor;
				m_buildBtn.Value.Enabled = true;
				m_cancelBtn.Value.Enabled = false;
				m_outputView.Value.TextStorage.Append(Environment.NewLine, ms_stdoutAttrs);
				m_errorWindow.Value.OrderOut();
				m_errors.Clear();
				m_errorTable.Value.NoteNumberOfRowsChanged();
				break;
				
			default:
				DBC.Fail("unknown state: {0}", m_doc.State);
				break;
		}
	}
	
	private void DoSetBuiltStatus()
	{
		if (m_errors.Count > 0)
		{
			int numErrors = 0, numWarnings = 0;
			foreach (Error err in m_errors)
				if (err.IsError)
					++numErrors;
				else
					++numWarnings;
			if (numErrors == 1 && numWarnings == 0)
				m_statusLabel.Value.String = "one error";
			else if (numErrors == 0 && numWarnings == 1)
				m_statusLabel.Value.String = "one warning";
			else if (numErrors > 0 && numWarnings == 0)
				m_statusLabel.Value.String = string.Format("{0} errors", numErrors);
			else if (numErrors == 0 && numWarnings > 0)
				m_statusLabel.Value.String = string.Format("{0} warnings", numWarnings);
			else
				m_statusLabel.Value.String = string.Format("{0} errors, {1} warnings", numErrors, numWarnings);

			if (numErrors > 0)
				m_statusLabel.Value.TextColor = NSColor.RedColor;
			else
				m_statusLabel.Value.TextColor = NSColor.OrangeColor;
		}
		else if (m_doc.ExitCode == 0)
		{
			TimeSpan elapsed = DateTime.Now - m_startTime;
			m_statusLabel.Value.String = string.Format("built in {0:0.0} secs", elapsed.TotalSeconds);
			m_statusLabel.Value.TextColor = NSColor.ControlTextColor;
		}
		else
		{
			m_statusLabel.Value.String = "failed with with exit code " + m_doc.ExitCode;
			m_statusLabel.Value.TextColor = NSColor.RedColor;
		}
	}
	
	private void DoGotCommand(object sender, string data)
	{
		m_outputView.Value.TextStorage.Append(data, ms_commandAttrs);
		m_outputView.Value.ScrollToEnd();
	}
	
	private void DoGotStdout(object sender, string data)
	{
		m_outputView.Value.TextStorage.Append(data, ms_stdoutAttrs);
		m_outputView.Value.ScrollToEnd();
	}
	
	private void DoGotStderr(object sender, string data)
	{
		Error error = ErrorParser.Parse(data);
		if (error != null)
		{
			m_errors.Add(error);
			m_errorTable.Value.NoteNumberOfRowsChanged();
			
			if (!m_errorWindow.Value.Visible)
			{
				m_errorWindow.Value.Title = string.Format("{0} {1} Errors", DoGetTitle(), m_doc.Target);
				m_errorWindow.Value.MakeKeyAndOrderFront();
				m_errorTable.Value.SelectedRow = 0;
			}
		}
		
		m_outputView.Value.TextStorage.Append(data, ms_stderrAttrs);
		m_outputView.Value.ScrollToEnd();
	}
	
	private void DoShowOutput()
	{
		if (!m_transcriptWindow.Value.Visible)
		{
			m_transcriptWindow.Value.MakeKeyAndOrderFront();
			m_transcriptWindow.Value.Title = DoGetTitle() + " Transcript";
		}
	}

	private string DoGetTitle()
	{
		NSUrl url = m_doc.FileUrl;
		string path = url.Path;
		
		string s = Path.GetDirectoryName(path);
		s = Path.GetFileName(s);
		
		return s;
	}
		
	private static NSDictionary DoCreateCommandAttrs()
	{
		NSMutableDictionary dict = new NSMutableDictionary();
		dict.Add(NSAttributedString.NSFontAttributeName, new NSFont(ms_fontName + "-Bold", 12.0f));
		dict.Retain();
		return dict;
	}

	private static NSDictionary DoCreateStdoutAttrs()
	{
		NSMutableDictionary dict = new NSMutableDictionary();
		dict.Add(NSAttributedString.NSFontAttributeName, new NSFont(ms_fontName, 12.0f));
		dict.Retain();
		return dict;
	}

	private static NSDictionary DoCreateStderrAttrs()
	{
		NSMutableDictionary dict = new NSMutableDictionary();
		dict.Add(NSAttributedString.NSFontAttributeName, new NSFont(ms_fontName, 12.0f));
		dict.Add(NSAttributedString.NSForegroundColorAttributeName, NSColor.RedColor);
		dict.Retain();
		return dict;
	}

	private Document m_doc;
	private IVar<EnvController> m_env;
	private IVar<FlagsController> m_flags;
	private IVar<NSTextField> m_statusLabel;
	private IVar<NSButton> m_buildBtn;
	private IVar<NSButton> m_cancelBtn;
	private IVar<NSTextView> m_outputView;
	private IVar<ErrorTable> m_errorTable;
	private IVar<NSWindow> m_transcriptWindow;
	private IVar<NSWindow> m_errorWindow;
	private List<Error> m_errors = new List<Error>();
	private DateTime m_startTime;
	
	private static string ms_fontName = "Verdana";
	private static readonly NSDictionary ms_commandAttrs = DoCreateCommandAttrs();
	private static readonly NSDictionary ms_stdoutAttrs = DoCreateStdoutAttrs();
	private static readonly NSDictionary ms_stderrAttrs = DoCreateStderrAttrs();
}
