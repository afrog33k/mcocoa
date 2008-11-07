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
using NUnit.Framework;
using System;
using System.Diagnostics;

// Verify that we can find the various forms of enum declarations.
[TestFixture]
public class EnumTest 	
{
	[TestFixtureSetUp]
	public void Init()
	{
		AssertListener.Install();
	}
	
	[Test]
	public void NoName()	 
	{
		EnumParser parser = new EnumParser("test", 
@"blah
enum {
    NSASCIIStringEncoding = 1,		/* 0..127 only */
    NSSymbolStringEncoding = 6,
    NSWindowsCP1251StringEncoding = 11,    /* Cyrillic; same as AdobeStandardCyrillic */

#if MAC_OS_X_VERSION_10_4 <= MAC_OS_X_VERSION_MAX_ALLOWED
    NSUTF16BigEndianStringEncoding = 0x90000100,          /* NSUTF16StringEncoding encoding with explicit endianness specified */
#endif
}; blah blah");				
		NativeEnum native = parser.Enum;
		Assert.IsNull(native.Name);

		Assert.AreEqual(4, native.Names.Length);
		Assert.AreEqual(4, native.Values.Length);

		Assert.AreEqual("NSASCIIStringEncoding", native.Names[0]);
		Assert.AreEqual("1", native.Values[0]);

		Assert.AreEqual("NSSymbolStringEncoding", native.Names[1]);
		Assert.AreEqual("6", native.Values[1]);

		Assert.AreEqual("NSWindowsCP1251StringEncoding", native.Names[2]);
		Assert.AreEqual("11", native.Values[2]);

		Assert.AreEqual("NSUTF16BigEndianStringEncoding", native.Names[3]);
		Assert.AreEqual("0x90000100", native.Values[3]);
	}

	[Test]
	public void MissingValues()	 
	{
		EnumParser parser = new EnumParser("test", 
@"blah
enum {
    NSDirectPredicateModifier = 0, // Do a direct comparison
    NSAllPredicateModifier, // ALL toMany.x = y
    NSAnyPredicateModifier // ANY toMany.x = y
}; blah blah");				
		NativeEnum native = parser.Enum;
		Assert.IsNull(native.Name);

		Assert.AreEqual(3, native.Names.Length);
		Assert.AreEqual(3, native.Values.Length);

		Assert.AreEqual("NSDirectPredicateModifier", native.Names[0]);
		Assert.AreEqual("0", native.Values[0]);

		Assert.AreEqual("NSAllPredicateModifier", native.Names[1]);
		Assert.AreEqual(string.Empty, native.Values[1]);

		Assert.AreEqual("NSAnyPredicateModifier", native.Names[2]);
		Assert.AreEqual(string.Empty, native.Values[2]);
	}

	[Test]
	public void Named()	 
	{
		EnumParser parser = new EnumParser("test", 
@"blah
enum _NSComparisonResult {NSOrderedAscending = -1, NSOrderedSame, NSOrderedDescending};
blah blah");				
		NativeEnum native = parser.Enum;
		Assert.AreEqual("_NSComparisonResult", native.Name);

		Assert.AreEqual(3, native.Names.Length);
		Assert.AreEqual(3, native.Values.Length);

		Assert.AreEqual("NSOrderedAscending", native.Names[0]);
		Assert.AreEqual("-1", native.Values[0]);

		Assert.AreEqual("NSOrderedSame", native.Names[1]);
		Assert.AreEqual(string.Empty, native.Values[1]);

		Assert.AreEqual("NSOrderedDescending", native.Names[2]);
		Assert.AreEqual(string.Empty, native.Values[2]);
	}

	[Test]
	public void Deprecated()	 
	{
		EnumParser parser = new EnumParser("test", 
@"blah
enum _NSObjCValueType {
    NSObjCNoType = 0,
    NSObjCVoidType = 'v',
    NSObjCBitfield = 'b'
} DEPRECATED_IN_MAC_OS_X_VERSION_10_5_AND_LATER;
blah blah");
		Assert.IsTrue(parser.AtEnd);
	}
}
