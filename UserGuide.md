# Introduction #

Writing an mcocoa application is much like writing a Cocoa application in Objective-C so you should be familiar with the material in the [Cocoa Application Tutorial](http://developer.apple.com/documentation/Cocoa/Conceptual/ObjCTutorial/04Model/04Model.html) and the [Cocoa Fundamentals Guide](http://developer.apple.com/documentation/Cocoa/Conceptual/CocoaFundamentals/Introduction/Introduction.html). There are some differences however which will be explained below.

# Overview #

A Cocoa application normally consists of one or more executables (which in our case are assemblies), one or more nib files, and an Info.plist file. These are all bundled together into a package with an .app extension.

In our case the executables are typically built with gmcs. The nib files are created normally (except that Interface Builder won't find IBActions in the code so they need to be manually added to the appropriate targets in Interface Builder). The Info.plist file can be copied from one of mcocoa's examples (you'll need to change the CFBundleIdentifier value). And the bundle is typically generated using a tool called cocoa-pack which is distributed with mobjc.

Note that manually adding outlets and actions to classes with Interface Builder has changed in Snow Leopard. Now you need to:
1) Select the Classes tab in the Library floating window
2) Find the class you are interested in and select it
3) Use the outlets or action tabs.

# Building #

In order to build your assemblies you will need to reference the mcocoa and mobjc libraries. The easiest and safest way to do this is to use the mcocoa/mobj make files to install the libraries and then use an update-libraries build target to copy the libraries to your project. If you're using make the update-libraries target would look something like this:

```
update-libraries:
    cp `pkg-config --variable=Libraries mobjc` bin
    cp `pkg-config --variable=Libraries mcocoa` bin
```

Once the libraries are in your bin directory you can reference them using gmcs's -r flag: `-r:bin/mobjc.dll,bin/mcocoa.dll`.

Building the bundle is a bit more complex. Here's an example using make syntax:

```
app: bin/cool-app.exe

bin/CoolApp.app: bin/cool-app.exe source/Info.plist source/MainMenu.nib Icon.icns bin/cool-app.exe.config
    @echo "building bin/CoolApp.app"
    @cocoa-pack \
    --app=bin/CoolApp.app \
    --exe=bin/cool-app.exe \
    --mono-flags='$(MONO_FLAGS)' \
    --resources=bin/mobjc.dll,bin/mcocoa.dll,Icon.icns,bin/cool-app.exe.config \
    --resources=English.lproj:source/MainMenu.nib \
    --plist=source/Info.plist \
    --vars=APPNAME:CoolApp,VERSION:$(version),BUILDNUM:$(build-num)
```

This will create (or overwrite) a bundle containing the executable, a config file, an icon, the two libraries, the Info.plist file, and a generated script used to launch mono. The plist is copied as is except that strings like "${APPNAME}" are expanded using the values from the --var switch.

# Application Structure #

The application's entry point should look something like this:

```
using MCocoa;
using MObjc;

internal static class Program
{
    internal static void Main(string[] args)
    {
        // This should be set once all assemblies with dependencies upon
        // mobjc are loaded. (If an NSObject is created before this is set
        // an exception will be thrown).
        Registrar.CanInit = true;
        
        // Load the main nib and run the application event loop.
        NSApplication app = NSApplication.Create("MainMenu.nib");
        app.run();
    }
}
```

Custom classes can be used for Cocoa delegates, controllers, views, etc. These are usually instantiated when their associated nib is loaded. See the mcocoa examples for more details.