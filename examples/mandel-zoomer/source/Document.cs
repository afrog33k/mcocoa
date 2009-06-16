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
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;

// Cocoa will instantiate these using the NSDocumentClass entry from Info.plist. 
[ExportClass("Document", "NSDocument")]
internal sealed class Document : NSDocument
{
	// Value is a DocChange instance.
	public static readonly NSString StateChanged = NSString.Create("document state changed").Retain();
	
	private Document(IntPtr instance) : base(instance)
	{
		m_settings.Area = 400*400;
		m_settings.MaxDwell = 200;
		m_settings.Extent = new Rect(
			new Complex(BigFloat.DefaultLeft, BigFloat.DefaultTop),
			new Complex(BigFloat.DefaultRight, BigFloat.DefaultBottom));
		
		AppDelegate app = NSApplication.sharedApplication().delegate_().To<AppDelegate>();
		
		m_engine = new ComputeEngine(m_settings);
		m_palette = app.DefaultPalette;
	}
	
	public Document(FractalSettings settings) : base(NSObject.AllocAndInitInstance("Document"))
	{
		m_settings = settings;
		
		AppDelegate app = NSApplication.sharedApplication().delegate_().To<AppDelegate>();
		
		m_engine = new ComputeEngine(m_settings);
		m_palette = app.DefaultPalette;
	}
	
	public new void makeWindowControllers()
	{
		var controller = new FractalController(this);
		addWindowController(controller);
		controller.autorelease();
	}
	
	public bool readFromData_ofType_error(NSData data, NSString typeName, IntPtr outError)
	{
		bool read = false;
		
		try
		{
			using (MemoryStream stream = new MemoryStream(data.bytes()))
			{
				var doc = new XmlDocument();
				doc.Load(stream);
				
				DoParseXml(doc);
				m_engine = new ComputeEngine(m_settings);
				
				Marshal.WriteIntPtr(outError, IntPtr.Zero);
				read = true;
				
				NSNotificationCenter.defaultCenter().postNotificationName_object(
					StateChanged, DocChange.Create(this, ChangeType.All));
			}
		}
		catch (Exception e)
		{
			Console.Error.WriteLine("{0}", e);
			
			NSMutableDictionary userInfo = NSMutableDictionary.Create();
			userInfo.setObject_forKey(NSString.Create("Couldn't read the document."), Externs.NSLocalizedDescriptionKey);
			userInfo.setObject_forKey(NSString.Create(e.Message), Externs.NSLocalizedFailureReasonErrorKey);
			
			NSObject error = NSError.errorWithDomain_code_userInfo(Externs.Cocoa3Domain, 1, userInfo);
			Marshal.WriteIntPtr(outError, error);
		}
		
		return read;
	}
	
	// Used to write the document.
	public NSData dataOfType_error(NSString typeName, IntPtr outError)
	{
		NSData data = null;
		
		try
		{
			XmlDocument doc = DoGetXml();
			using (MemoryStream stream = new MemoryStream())
			{
				doc.Save(stream);
				data = NSData.Create(stream.ToArray());
			}
		}
		catch (Exception e)
		{
			NSMutableDictionary userInfo = NSMutableDictionary.Create();
			userInfo.setObject_forKey(NSString.Create("Couldn't save the document."), Externs.NSLocalizedDescriptionKey);
			userInfo.setObject_forKey(NSString.Create(e.Message), Externs.NSLocalizedFailureReasonErrorKey);
			
			NSObject error = NSError.errorWithDomain_code_userInfo(Externs.Cocoa3Domain, 1, userInfo);
			Marshal.WriteIntPtr(outError, error);
		}
		
		return data;
	}
	
	public FractalSettings Settings
	{
		get {return m_settings;}
	}
	
	// document().undoManager().setActionName should be called after this is called.
	public void updateSettings(Wrapper wrapper)
	{
		FractalSettings newSettings = (FractalSettings) wrapper.Value;
		
		if (newSettings != m_settings)
		{
			Wrapper oldSettings = Wrapper.Create(m_settings);
			undoManager().registerUndoWithTarget_selector_object(this, "updateSettings:", oldSettings);
			
			m_engine.Abort();
			m_settings = newSettings;
			m_engine = new ComputeEngine(m_settings);
				
			NSNotificationCenter.defaultCenter().postNotificationName_object(
				StateChanged, DocChange.Create(this, ChangeType.Settings));
		}
	}
	
	// document().undoManager().setActionName should be called after this is called.
	public void updatePalette(Wrapper wrapper)
	{
		Palette newPalette = (Palette) wrapper.Value;
		
		Wrapper oldPalette = Wrapper.Create(m_palette);
		undoManager().registerUndoWithTarget_selector_object(this, "updatePalette:", oldPalette);
		
		m_palette = newPalette;
		
		NSNotificationCenter.defaultCenter().postNotificationName_object(
			StateChanged, DocChange.Create(this, ChangeType.Palette));
	}
	
	// document().undoManager().setActionName should be called after this is called.
	public void updatePaletteExponent(NSNumber newValue)
	{
		NSNumber oldValue = NSNumber.Create(m_paletteExponent);
		undoManager().registerUndoWithTarget_selector_object(this, "updatePaletteExponent:", oldValue);
		
		m_paletteExponent = newValue.floatValue();
		
		NSNotificationCenter.defaultCenter().postNotificationName_object(
			StateChanged, DocChange.Create(this, ChangeType.PaletteExponent));
	}
	
	public void MakeDefault()
	{
		m_palette = m_palette.SetName("Default");
	}
	
	public bool AllDone
	{
		get {return m_engine.AllDone;}
	}
	
	public float[,] Samples
	{
		get {return m_engine.Samples;}
	}
	
	public float MinDwell
	{
		get {return m_engine.MinDwell;}
	}
	
	// Max dwell we found.
	public float MaxDwell
	{
		get {return m_engine.MaxDwell;}
	}
	
	public float MinSample
	{
		get {return m_engine.MinSample;}
	}
	
	public float MaxSample
	{
		get {return m_engine.MaxSample;}
	}
	
	// In minutes.
	public double RenderTime
	{
		get {return m_engine.RenderTime;}
	}
	
	public Palette Palette
	{
		get {return m_palette;}
	}
	
	public float PaletteExponent
	{
		get {return m_paletteExponent;}
	}
	
	#region Private Methods
	private XmlDocument DoGetXml()
	{
		XmlDocument doc = new XmlDocument();
		
		XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);
		doc.InsertBefore(xmlDeclaration, doc.DocumentElement);
		
		XmlElement fractal  = doc.CreateElement("fractal");
		fractal.SetAttribute("exponent", string.Format("{0:0.00}", m_paletteExponent));
		fractal.SetAttribute("name", m_palette.Name);
		doc.AppendChild(fractal);
		
			XmlElement settings = m_settings.GetXmlNode(doc);
			fractal.AppendChild(settings);
		
			XmlElement palette = m_palette.GetXmlNode(doc);
			fractal.AppendChild(palette);
			
		return doc;
	}
	
	private void DoParseXml(XmlDocument doc)
	{
		foreach (XmlNode child in doc.ChildNodes)
		{
			if (child.Name == "fractal")
			{
				m_paletteExponent = float.Parse(child.Attributes["exponent"].Value);
				string name = child.Attributes["name"].Value;
				
				foreach (XmlNode gchild in child.ChildNodes)
				{
					if (gchild.Name == "settings")
					{
						m_settings = new FractalSettings(gchild);
					}
					else if (gchild.Name == "palette")
					{
						m_palette = new Palette(name, gchild);
					}
				}
			}
		}
	}
	#endregion
	
	#region Fields
	private FractalSettings m_settings;
	private ComputeEngine m_engine;
	private Palette m_palette;
	private float m_paletteExponent = 5.0f;
	#endregion
}
