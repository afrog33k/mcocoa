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
using System.Collections.Generic;

// Function pointer and block tests.
[TestFixture]
public class BlockTest
{
	[TestFixtureSetUp]
	public void Init()
	{
		Registrar.CanInit = true;
	}
	
	[Test]
	public void FunctionPointers()
	{
		NSAutoreleasePool pool = NSAutoreleasePool.Create();
		
		NSMutableArray array = NSMutableArray.Alloc().initWithCapacity(4).To<NSMutableArray>();
		array.addObject(NSNumber.numberWithInt(5));
		array.addObject(NSNumber.numberWithInt(2));
		array.addObject(NSNumber.numberWithInt(8));
		array.addObject(NSNumber.numberWithInt(3));
		
		array.sortUsingFunction_context(
			(NSObject lhs, NSObject rhs, IntPtr context) =>
			{
				int l = (int) lhs.Call("intValue");
				int r = (int) rhs.Call("intValue");
				if (l < r)
					return Enums.NSOrderedAscending;
				else if (l > r)
					return Enums.NSOrderedDescending;
				else
					return Enums.NSOrderedSame;
			},
			IntPtr.Zero);
		
		Assert.AreEqual(2, (int) array.objectAtIndex(0).Call("intValue"));
		Assert.AreEqual(3, (int) array.objectAtIndex(1).Call("intValue"));
		Assert.AreEqual(5, (int) array.objectAtIndex(2).Call("intValue"));
		Assert.AreEqual(8, (int) array.objectAtIndex(3).Call("intValue"));
		
		pool.release();
	}
	
	[Test]
	public void Block()
	{
		NSAutoreleasePool pool = NSAutoreleasePool.Create();
		
		NSString s = NSString.Create("hello\nthere");
		
		var lines = new List<string>();
		s.enumerateLinesUsingBlock(line =>
		{
			lines.Add(line.description().ToString());
			return false;
		});
		
		Assert.AreEqual(2, lines.Count);
		Assert.AreEqual("hello", lines[0]);
		Assert.AreEqual("there", lines[1]);
		
		pool.release();
	}
	
}
