// Copyright (C) 2009 Jesse Jones
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
using System.IO;
using System.Reflection;
using System.Xml;

[ExportClass("AppDelegate", Outlets = "palettesMenu")]
internal sealed class AppDelegate : NSObject
{
	private AppDelegate(IntPtr instance) : base(instance)
	{
		DoInitPalettes();
		
		m_docInfoController = new DocumentInfoController();
		m_fractalInfoController = new FractalInfoController();
		m_paletteController = new PaletteController();
	}
	
	// This is called before our first document is created (applicationDidFinishLaunching
	// is called after it is created).
	public void applicationWillFinishLaunching(NSObject notification)
	{
		DoInitPalettesMenu();
	}
	
	public void applicationWillTerminate(NSObject notification)
	{
#if DEBUG
		// These are fairly expensive to create and it's easy to mess up and
		// create tons inside loops so we'll print the count here.
		Console.WriteLine("{0} BigFloat instances were created.", BigFloat.InstanceCount);
#endif
	}
	
	public void showDocInfo(NSObject sender)
	{
		m_docInfoController.window().orderFront(this);
	}
	
	public void showFractalInfo(NSObject sender)
	{
		m_fractalInfoController.window().orderFront(this);
	}
	
	public void showPalette(NSObject sender)
	{
		m_paletteController.window().orderFront(this);
	}
	
	public Palette GetPalette(string name)
	{
		return m_palettes[name];
	}
	
	public Palette DefaultPalette
	{
		get {return m_defaultPalette;}
	}
	
	#region Private Methods
	private void DoInitPalettesMenu()
	{
		NSMenu menu = this["palettesMenu"].To<NSMenu>();
		int i = 0;
		foreach (string name in m_palettes.Keys)
		{
			menu.insertItemWithTitle_action_keyEquivalent_atIndex(
				NSString.Create(name),
				"changePalette:",
				NSString.Empty,
				i++);
		}
	}
	
	private void DoInitPalettes()
	{
		string path = Assembly.GetExecutingAssembly().Location;
		path = Path.GetDirectoryName(path);
		path = Path.Combine(path, "palettes");
		
		DoLoadPalettes(path);
		DoReadDefault(path);
	}
	
	private void DoReadDefault(string path)
	{
		if (m_palettes.ContainsKey("Default"))
		{
			m_defaultPalette = m_palettes["Default"];
		}
		else
		{
			NSString title = NSString.Create("Couldn't use the default palette.");
			NSString message = NSString.Create("There is no palette named 'Default'.");
			Unused.Value = Functions.NSRunAlertPanel(title, message);
		}
	}
	
	private void DoLoadPalettes(string path)
	{
		foreach (string file in Directory.GetFiles(path, "*.xml"))
		{
			string name = Path.GetFileNameWithoutExtension(file);
			
			try
			{
				m_defaultPalette = DoCreatePalette(file);	// note that we need to set m_defaultPalette to something, but we don't care what
				m_palettes.Add(name, m_defaultPalette);
			}
			catch (Exception e)
			{
				NSString title = NSString.Create("Couldn't read {0}.", name);
				NSString message = NSString.Create(e.Message);
				Unused.Value = Functions.NSRunAlertPanel(title, message);
			}
		}
	}
	
	private Palette DoCreatePalette(string file)
	{
		Palette palette;
		
		using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
		{
			using (XmlReader reader = XmlReader.Create(stream))
			{
				var xml = new XmlDocument();
				xml.Load(reader);
				
				string name = Path.GetFileNameWithoutExtension(file);
				palette = new Palette(name, xml);
			}
		}
		
		return palette;
	}
	#endregion
	
	#region Fields
	private DocumentInfoController m_docInfoController;
	private FractalInfoController m_fractalInfoController;
	private PaletteController m_paletteController;
	private SortedDictionary<string, Palette> m_palettes = new SortedDictionary<string, Palette>();
	private Palette m_defaultPalette;
	#endregion
}
