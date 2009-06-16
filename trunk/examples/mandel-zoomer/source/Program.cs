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
using System.Runtime.InteropServices;

internal static class Program
{
	public static void Main(string[] args)
	{
		Registrar.CanInit = true;
		
		var pool = NSAutoreleasePool.Create();
//		NSObject.SaveStackTraces = true;
		NSApplication app = NSApplication.Create("MainMenu.nib");
			
		if (Preflight())
		{
			// TODO: starting with mono 2.2 the path to the exe is part of the unmanaged command
			// line arguments, but not the managed command line arguments. So, when cocoa starts
			// up it opens the exe as a document. The following line suppresses cocoa's argument
			// processing... 
			NSUserDefaults.standardUserDefaults().setObject_forKey(NSString.Create("NO"), NSString.Create("NSTreatUnknownArgumentsAsOpen"));
			pool.release();
			
			app.run();
			
			// note that we don't actually land here when quitting...
		}
	}
	
	#region Private Methods
	private static bool Preflight()
	{
		bool ok = true;
		
#if LIBGMP
		// If libgmp is not installed the app will exit with an error message to
		// stderr which people won't see unless they have Console.app open
		// or are running the app from Terminal.app. So, to provide a better
		// error message we'll force libgmp to load here and bail if there are
		// problems. TODO: we might want to get rid of this once we distribute
		// gmp with the app.
		try
		{
			// Note that we can't catch the exceptions thrown by the static
			// BigFloat ctor...
			Unused.Value = mpf_get_default_prec();
		}
		catch (DllNotFoundException)
		{
			// Not sure why but if NSApplication isn't created we don't see the alert.
			NSString title = NSString.Create("Couldn't find libgmp (is it installed?)");
			NSString message = NSString.Empty;
			Unused.Value = Functions.NSRunAlertPanel(title, message);
			
			ok = false;
		}
		catch (Exception e)
		{
			NSString title = NSString.Create("Couldn't load libgmp.");
			NSString message = NSString.Create(e.Message);
			Unused.Value = Functions.NSRunAlertPanel(title, message);
			
			ok = false;
		}
#endif

		return ok;
	}
	
#if LIBGMP
	[DllImport("gmp", EntryPoint = "__gmpf_get_default_prec")]
	private extern static uint mpf_get_default_prec();
#endif
	#endregion
}
