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
using NUnit.Framework;
using System;

// Simple smoke test to verify that the wrappers are not completely hosed.
[TestFixture]
public class FoundationTest 	
{
	[Test]
	public void Array()	
	{
		Registrar.CanInit = true;
		NSObject pool = (NSObject) new Class("NSAutoreleasePool").Call("alloc").Call("init");
		
		NSMutableArray array = NSMutableArray.alloc().initWithCapacity(3).To<NSMutableArray>();
		array.addObject(NSNumber.numberWithInt(100));
		array.addObject(NSNumber.numberWithBool(true));
		array.addObject(NSString.Create("hmm"));

		Assert.AreEqual(3, array.count());
		Assert.AreEqual(100, (int) array.objectAtIndex(0).Call("intValue"));
		Assert.AreEqual(1, (sbyte) array.objectAtIndex(1).Call("boolValue"));
		Assert.AreEqual("hmm", array.objectAtIndex(2).ToString());

		pool.release();
	}
}
