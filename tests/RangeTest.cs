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
using System.Diagnostics;

[TestFixture]
public class RangeTest
{
	[Test]
	public void Intersects()
	{
		// Zero length ranges never intersect.
		Assert.IsFalse(NSRange.Empty.Intersects(NSRange.Empty));
		Assert.IsFalse(new NSRange(10, 100).Intersects(new NSRange(11, 0)));
		Assert.IsFalse(new NSRange(11, 0).Intersects(new NSRange(10, 100)));
		
		// Disjunct ranges don't intersect.
		Assert.IsFalse(new NSRange(10, 100).Intersects(new NSRange(200, 100)));
		Assert.IsFalse(new NSRange(200, 100).Intersects(new NSRange(10, 100)));
		Assert.IsFalse(new NSRange(10, 1).Intersects(new NSRange(9, 1)));
		Assert.IsFalse(new NSRange(9, 1).Intersects(new NSRange(0, 1)));
		
		// Overlapping ranges intersect.
		Assert.IsTrue(new NSRange(9, 2).Intersects(new NSRange(10, 1)));
		Assert.IsTrue(new NSRange(10, 1).Intersects(new NSRange(9, 2)));
		
		// Interior ranges also intersect.
		Assert.IsTrue(new NSRange(10, 100).Intersects(new NSRange(20, 50)));
		Assert.IsTrue(new NSRange(20, 50).Intersects(new NSRange(10, 100)));
	}
}
