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

using MObjc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;

internal static class Program
{
	public static void Main(string[] args) 
	{	
		AssertListener.Install();

		foreach (string arg in args)
			DoProcessArg(arg);
		
		if (!m_exiting)
			DoValidateArgs();

		if (!m_exiting)
		{
			if (ms_file != null)
			{	
				ObjectModel objects = new ObjectModel();
				objects.Parse(ms_file);

				Generate generate = new Generate(objects);
				generate.Code(ms_outDir, new Blacklist[0]);
			}
			else
			{
				XmlReader reader = XmlReader.Create(ms_xml);
				XmlDocument xml = new XmlDocument();
				xml.Load(reader);
				
				ObjectModel objects = new ObjectModel();
				foreach (XmlNode child in xml.ChildNodes)	
				{
					if (child.Name == "Generate")
					{
						foreach (XmlNode gchild in child.ChildNodes)	
						{
							if (gchild.Name == "TypeResults")
							{
								DoAddResultType(objects, gchild);			
							}
						}
					}
				}

				foreach (XmlNode child in xml.ChildNodes)	
				{
					if (child.Name == "Generate")
					{
						foreach (XmlNode gchild in child.ChildNodes)	
						{
							if (gchild.Name == "Framework")
								DoGenerateFromXML(objects, gchild);			
						}
					}
				}
			}
		}
	}
	
	private static void DoAddResultType(ObjectModel objects, XmlNode tr)
	{
		if (tr.ChildNodes.Count > 0)
		{
			foreach (XmlNode child in tr.ChildNodes)
			{
				if (child.Name == "TypeResult") 
				{
					string name = child.Attributes["name"].Value;
					string type = child.Attributes["type"] != null ? child.Attributes["type"].Value : null;
					objects.AddResultMapping(name, type);
				}
			}
		}
	}
	
	private static void DoGenerateFromXML(ObjectModel objects, XmlNode framework)
	{
		string name = framework.Attributes["name"].Value;
		string dir = framework.Attributes["path"].Value;
		Blacklist[] blacklist = DoGetBlacklist(framework);
		
		string outPath = ms_outDir;
		outPath = Path.Combine(outPath, name);
		outPath = Path.Combine(outPath, "generated");
		
		string[] files;
		if (Directory.Exists(outPath))
		{
			files = Directory.GetFiles(outPath, "*.cs", SearchOption.AllDirectories);
			foreach (string file in files)
				File.SetAttributes(file, FileAttributes.Normal);	// need to unlock generated .cs files so we can delete the directory
			Directory.Delete(outPath, true);
		}
		Directory.CreateDirectory(outPath);

		objects.Reset();									// resets everything but typedefs
		files = Directory.GetFiles(dir, "*.h");
		foreach (string inFile in files)
		{
			if (!inFile.EndsWith("NSObjCRuntime.h"))
				objects.Parse(inFile);
		}

		Generate generate = new Generate(objects);
		generate.Code(outPath, blacklist);
	}
	
	private static Blacklist[] DoGetBlacklist(XmlNode framework)
	{
		List<Blacklist> black = new List<Blacklist>();
		
		if (framework.ChildNodes.Count > 0)
		{
			foreach (XmlNode child in framework.ChildNodes[0])
			{
				if (child.Name == "Method")
				{
					black.Add(new Blacklist(child.Attributes["interface"].Value, child.Attributes["method"].Value, child.Attributes["reason"].Value));
				}
			}
		}
		
		return black.ToArray();
	}
	
	private static void DoProcessArg(string arg)
	{
		if (arg.StartsWith("--file="))
		{
			ms_file = arg.Substring("--file=".Length);
		}
		else if (arg.StartsWith("--xml="))
		{
			ms_xml = arg.Substring("--xml=".Length);
		}
		else if (arg.StartsWith("--out="))
		{
			ms_outDir = arg.Substring("--out=".Length);
		}
		else 
		{
			DoHelp();
			m_exiting = true;
		}
	}
	
	private static void DoHelp()
	{
		Console.WriteLine("Generates C# wrapper classes for Cocoa frameworks.");
		Console.WriteLine("mono generate --xml=generate/Frameworks.xml --out=../source");
		Console.WriteLine("");
		
		Console.WriteLine("Options:");
		Console.WriteLine("   --xml=path   xml file describing which framework to generate");
		Console.WriteLine("   --file=path  used instead of --xml to process a single file");
		Console.WriteLine("   --out=path   the directory the generated files go into");
		Console.WriteLine("   --help       show this info and exit");
	}
	
	private static void DoValidateArgs()
	{
		if (ms_file == null && ms_xml == null)
		{
			Console.Error.WriteLine("One of --xml or --file must be used.");
			m_exiting = true;
		}

		if (ms_file != null && ms_xml != null)
		{
			Console.Error.WriteLine("Can't use both --xml and --file.");
			m_exiting = true;
		}

		if (ms_outDir == null)
		{
			Console.Error.WriteLine("Missing --out switch.");
			m_exiting = true;
		}
	}
	
	private static string ms_file;
	private static string ms_xml;
	private static string ms_outDir;
	private static bool m_exiting;
}
 