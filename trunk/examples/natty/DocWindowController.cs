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

[ExportClass("DocWindowController", "NSWindowController", Outlets = "flagsSheet prefSheet envSheet targets build cancel status output outputWindow errorWindow errors")]
internal sealed class DocWindowController : NSWindowController
{
	public DocWindowController(Document doc) : base(NSObject.AllocInstance("DocWindowController"))
	{
		m_doc = doc;
		
		Unused.Value = NSBundle.loadNibNamed_owner(NSString.Create("Document"), this);
		
		m_errorWindow = this["errorWindow"].To<NSWindow>();
		m_transcriptWindow = this["outputWindow"].To<NSWindow>();
		m_errorTable = this["errors"].To<ErrorTable>();
		m_statusLabel = this["status"].To<NSTextField>();
		m_buildBtn = this["build"].To<NSButton>();
		m_cancelBtn = this["cancel"].To<NSButton>();
		m_outputView = this["output"].To<NSTextView>();
		
		m_outputView.textStorage().mutableString().setString(NSString.Empty);
		m_errorTable.setDataSource(this);
		
		setShouldCascadeWindows(false);
		m_transcriptWindow.windowController().setShouldCascadeWindows(false);
		m_errorWindow.windowController().setShouldCascadeWindows(false);
		
		window().setFrameAutosaveName(NSString.Create(m_doc.Path + "-build window"));
		m_transcriptWindow.setFrameAutosaveName(NSString.Create(m_doc.Path + "-transcript window"));
		m_errorWindow.setFrameAutosaveName(NSString.Create(m_doc.Path + "-error window"));
		
		m_transcriptWindow.windowController().setNextResponder(this);
		m_errorWindow.windowController().setNextResponder(this);
		
		m_doc.StateChanged += this.DoDocChanged;
		m_doc.CommandData += this.DoGotCommand;
		m_doc.StdoutData += this.DoGotStdout;
		m_doc.StderrData += this.DoGotStderr;
		
		rebuildTargets();
	}
	
	#region Action Handlers
	public void targetChanged(NSPopUpButton sender)
	{
		m_doc.Target = sender.titleOfSelectedItem().ToString();
	}
	
	public void build(NSObject sender)
	{
		m_doc.Build();
	}
	
	public void cancel(NSObject sender)
	{
		m_doc.Cancel();
	}
	
	public void clearTranscript(NSObject sender)
	{
		m_outputView.textStorage().mutableString().setString(NSString.Empty);
	}
	
	public void environment(NSObject sender)
	{
		if (NSObject.IsNullOrNil(m_env))
		{
			NSBundle.loadNibNamed_owner(NSString.Create("Environment"), this);
			m_env = this["envSheet"].To<EnvController>();
		}
		Contract.Assert(!NSObject.IsNullOrNil(m_env), "nib didn't set envSheet");
		
		m_env.Open(m_doc, window());
	}
	
	public void flags(NSObject sender)
	{
		if (NSObject.IsNullOrNil(m_flags))
		{
			NSBundle.loadNibNamed_owner(NSString.Create("Flags"), this);
			m_flags = this["flagsSheet"].To<FlagsController>();
		}
		Contract.Assert(!NSObject.IsNullOrNil(m_flags), "nib didn't set flagsSheet");
		
		m_flags.Open(m_doc, window());
	}
	
	public void showPrefs(NSObject sender)
	{
		NSBundle.loadNibNamed_owner(NSString.Create("Preferences"), this);
		m_prefs = this["prefSheet"].To<NSWindow>();
		Contract.Assert(!NSObject.IsNullOrNil(m_prefs), "nib didn't set prefSheet");
		
		m_prefs.makeKeyAndOrderFront(this);
	}
	
	public void rebuildTargets()
	{
		string[] ignored = m_doc.IgnoredTargets().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
		var targets = m_doc.Targets.Except(ignored);
		
		NSPopUpButton popup = new NSPopUpButton(this["targets"]);
		popup.removeAllItems();	
		popup.addItemsWithTitles(NSArray.Create(targets.ToArray()));
		
		m_buildBtn.setEnabled(targets.Any());
		
		if (m_doc.Target != null && targets.Contains(m_doc.Target))
			popup.selectItemWithTitle(NSString.Create(m_doc.Target));
	}	
	#endregion
	
	#region Errors Data Source
	public int numberOfRowsInTableView(NSTableView table)
	{
		return m_errors.Count;
	}
	
	public NSObject tableView_objectValueForTableColumn_row(NSTableView table, NSTableColumn column, int row)
	{
		Error error = m_errors[row];
		if (column.identifier().ToString() == "1")
			return NSString.Create(error.Message);
		else if (column.identifier().ToString() == "2")
			return NSString.Create(error.File);
		else
			return NSString.Create(error.Line);
	}
	
	public void openSelection(NSObject sender)
	{
		bool opened = false;
		
		NSRange range = m_outputView.selectedRange();
		if (range.location != Enums.NSNotFound)
		{
			string text = m_outputView.textStorage().ToString();
			range = DoExtendSelection(text, range);
			string file = text.Substring(range.location, range.length);
			
			string line = "0";
			if (range.location + range.length < text.Length && (text[range.location + range.length] == '(' || text[range.location + range.length] == ':'))
			{
				int i = range.location + range.length + 1;
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
			Functions.NSBeep();
	}
	
	private NSRange DoExtendSelection(string text, NSRange range)
	{
		while (DoIsFileChar(text, range.location - 1))
		{
			--range.location;
			++range.length;
		}
		
		while (DoIsFileChar(text, range.location + range.length))
			++range.length;
			
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
	
	public void openFile(int row)
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
			string command = m_doc.Editor();
			string args = null;
			
			int i = command.IndexOf(' ');
			if (i >= 0)
			{
				args = command.Substring(i + 1);
				command = command.Substring(0, i);
			}
			
			try
			{
				ProcessStartInfo info = new ProcessStartInfo();
				info.FileName = command;
				info.UseShellExecute = false;
				
				if (args != null)
					info.Arguments = string.Format(args, path, line);
				
				Process.Start(info);
			}
			catch (Exception e)
			{
				NSAlert alert = NSAlert.Create();
				alert.setMessageText(NSString.Create("Couldn't open the file."));
				alert.setInformativeText(NSString.Create(e.Message));
				alert.runModal();
			}
		}
		
		return File.Exists(path);
	}
	#endregion
	
	public bool validateMenuItem(NSMenuItem item)
	{
		if (item.action().Name == "build:")
			return m_doc.State != State.Building;
		
		return true;
	}
	
	#region Overrides
	public new NSString windowTitleForDocumentDisplayName(NSString displayName)
	{
		return NSString.Create(DoGetTitle());
	}
	#endregion
	
	private void DoDocChanged(object sender, EventArgs e)
	{
		switch (m_doc.State)
		{
			case State.Building:
				m_startTime = DateTime.Now;
				m_statusLabel.setStringValue(NSString.Create("building..."));
				m_statusLabel.setTextColor(NSColor.controlTextColor());
				m_buildBtn.setEnabled(false);
				m_cancelBtn.setEnabled(true);
				DoShowOutput();
				m_errors.Clear();
				m_errorTable.noteNumberOfRowsChanged();
				m_errorWindow.orderOut(this);
				break;
			
			case State.Built:
				DoSetBuiltStatus();
				m_buildBtn.setEnabled(true);
				m_cancelBtn.setEnabled(false);
				DoShowOutput();
				m_outputView.textStorage().appendAttributedString(NSAttributedString.Create(Environment.NewLine, ms_stdoutAttrs));
				if (m_doc.ExitCode != 0 && m_errors.Count > 0)
					m_errorWindow.makeKeyAndOrderFront(this);
				break;
			
			case State.Canceled:
				m_statusLabel.setStringValue(NSString.Create("canceled"));
				m_statusLabel.setTextColor(NSColor.orangeColor());
				m_buildBtn.setEnabled(true);
				m_cancelBtn.setEnabled(false);
				m_outputView.textStorage().appendAttributedString(NSAttributedString.Create(Environment.NewLine, ms_stdoutAttrs));
				m_errorWindow.orderOut(this);
				m_errors.Clear();
				m_errorTable.noteNumberOfRowsChanged();
				break;
				
			default:
				Contract.Assert(false, string.Format("unknown state: {0}", m_doc.State));
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
				m_statusLabel.setStringValue(NSString.Create("one error"));
			else if (numErrors == 0 && numWarnings == 1)
				m_statusLabel.setStringValue(NSString.Create("one warning"));
			else if (numErrors > 0 && numWarnings == 0)
				m_statusLabel.setStringValue(NSString.Create(string.Format("{0} errors", numErrors)));
			else if (numErrors == 0 && numWarnings > 0)
				m_statusLabel.setStringValue(NSString.Create(string.Format("{0} warnings", numWarnings)));
			else
				m_statusLabel.setStringValue(NSString.Create(string.Format("{0} errors, {1} warnings", numErrors, numWarnings)));
			
			if (numErrors > 0)
				m_statusLabel.setTextColor(NSColor.redColor());
			else
				m_statusLabel.setTextColor(NSColor.orangeColor());
		}
		else if (m_doc.ExitCode == 0)
		{
			TimeSpan elapsed = DateTime.Now - m_startTime;
			m_statusLabel.setStringValue(NSString.Create(string.Format("built in {0:0.0} secs", elapsed.TotalSeconds)));
			m_statusLabel.setTextColor(NSColor.controlTextColor());
		}
		else
		{
			m_statusLabel.setStringValue(NSString.Create("failed with with exit code " + m_doc.ExitCode));
			m_statusLabel.setTextColor(NSColor.redColor());
		}
	}
	
	private void DoGotCommand(object sender, string data)
	{
		m_outputView.textStorage().appendAttributedString(NSAttributedString.Create(data, ms_commandAttrs));
		DoScrollOutputToEnd();
	}
	
	private void DoGotStdout(object sender, string data)
	{
		m_outputView.textStorage().appendAttributedString(NSAttributedString.Create(data, ms_stdoutAttrs));
		DoScrollOutputToEnd();
	}
	
	private void DoGotStderr(object sender, string data)
	{
		Error error = ErrorParser.Parse(data);
		if (error != null)
		{
			m_errors.Add(error);
			m_errorTable.noteNumberOfRowsChanged();
			
			if (!m_errorWindow.isVisible())
			{
				m_errorWindow.setTitle(NSString.Create(string.Format("{0} {1} Errors", DoGetTitle(), m_doc.Target)));
				m_errorWindow.makeKeyAndOrderFront(this);
				m_errorTable.selectRowIndexes_byExtendingSelection(NSIndexSet.indexSetWithIndex(0), false);
			}
		}
		
		m_outputView.textStorage().appendAttributedString(NSAttributedString.Create(data, ms_stderrAttrs));
		DoScrollOutputToEnd();
	}
	
	private void DoScrollOutputToEnd()
	{
		int len = (int) m_outputView.string_().length();
		NSRange range = new NSRange(len, 0);
		m_outputView.scrollRangeToVisible(range);
	}
	
	private void DoShowOutput()
	{
		m_transcriptWindow.makeKeyAndOrderFront(this);
		m_transcriptWindow.setTitle(NSString.Create(DoGetTitle() + " Transcript"));
	}
	
	private string DoGetTitle()
	{
		NSURL url = m_doc.fileURL();
		string path = url.path().ToString();
		
		string s = Path.GetDirectoryName(path);
		s = Path.GetFileName(s);
		
		return s;
	}
	
	private static NSDictionary DoCreateCommandAttrs()
	{
		NSMutableDictionary dict = NSMutableDictionary.Create();
		dict.setObject_forKey(NSFont.fontWithName_size(NSString.Create(ms_fontName + "-Bold"), 12.0f), Externs.NSFontAttributeName);
		dict.retain();
		return dict;
	}
	
	private static NSDictionary DoCreateStdoutAttrs()
	{
		NSMutableDictionary dict = NSMutableDictionary.Create();
		dict.setObject_forKey(NSFont.fontWithName_size(NSString.Create(ms_fontName), 12.0f), Externs.NSFontAttributeName);
		dict.retain();
		return dict;
	}
	
	private static NSDictionary DoCreateStderrAttrs()
	{
		NSMutableDictionary dict = NSMutableDictionary.Create();
		dict.setObject_forKey(NSFont.fontWithName_size(NSString.Create(ms_fontName), 12.0f), Externs.NSFontAttributeName);
		dict.setObject_forKey(NSColor.redColor(), Externs.NSForegroundColorAttributeName);
		dict.retain();
		return dict;
	}
	
	#region Fields
	private Document m_doc;
	private EnvController m_env;
	private FlagsController m_flags;
	private NSWindow m_prefs;
	private NSTextField m_statusLabel;
	private NSButton m_buildBtn;
	private NSButton m_cancelBtn;
	private NSTextView m_outputView;
	private ErrorTable m_errorTable;
	private NSWindow m_transcriptWindow;
	private NSWindow m_errorWindow;
	private List<Error> m_errors = new List<Error>();
	private DateTime m_startTime;
	
	private static string ms_fontName = "Verdana";
	private static readonly NSDictionary ms_commandAttrs = DoCreateCommandAttrs();
	private static readonly NSDictionary ms_stdoutAttrs = DoCreateStdoutAttrs();
	private static readonly NSDictionary ms_stderrAttrs = DoCreateStderrAttrs();
	#endregion
}
