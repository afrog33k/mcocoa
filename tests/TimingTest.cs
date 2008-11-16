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
using System.Diagnostics;

// Simple benchmark for mcocoa.
[TestFixture]
public class TimingTest 	
{
	[TestFixtureSetUp]
	public void Init()
	{
		AssertListener.Install();

		Registrar.CanInit = true;
	}
	
	private const int ArraySize = 100;
	
	[Test]
	public void Managed()	
	{
		Random rng = new Random(1);
		List<string> values = new List<string>();
		for (int i = 0; i < ArraySize; ++i)
			values.Add(rng.Next().ToString());
			
		Stopwatch timer = Stopwatch.StartNew();
		for (int i = 0; i < values.Count; ++i)
		{
			for (int j = values.Count - 1; j > i; --j)
			{
				if (string.Compare(values[j - 1], values[j]) > 0)
				{
					string temp = values[j];
					values[j] = values[j - 1];
					values[j - 1] = temp;
				}
			}
		}
		Console.WriteLine("managed {0:0.0} secs", timer.ElapsedMilliseconds/1000.0);

		for (int i = 0; i < Math.Min(values.Count - 1, 100); ++i)
		{
			Assert.IsTrue(string.Compare(values[i], values[i+1]) <= 0);
		}
	}
	
	[Test]
	public void Native()	
	{
		NSObject pool = new NSObject(NSObject.CreateNative("NSAutoreleasePool"));

		Random rng = new Random(1);
		NSMutableArray values = NSMutableArray.Create();
		for (int i = 0; i < ArraySize; ++i)
			values.addObject(NSString.Create(rng.Next().ToString()));
			
		Stopwatch timer = Stopwatch.StartNew();
		for (uint i = 0; i < values.count(); ++i)
		{
			for (uint j = values.count() - 1; j > i; --j)
			{
				NSString s1 = values.objectAtIndex(j).To<NSString>();
				NSString s2 = values.objectAtIndex(j - 1).To<NSString>();
				
				if (s2.compare(s1) > 0)
				{
					values.replaceObjectAtIndexWithObject(j, s2);
					values.replaceObjectAtIndexWithObject(j - 1, s1);
				}
			}
		}
		Console.WriteLine("native {0:0.0} secs", timer.ElapsedMilliseconds/1000.0);

		for (uint i = 0; i < Math.Min(values.count() - 1, 100); ++i)
		{
			NSString s1 = values.objectAtIndex(i).To<NSString>();
			NSString s2 = values.objectAtIndex(i + 1).To<NSString>();

			Assert.IsTrue(s1.compare(s2) <= 0);
		}

		pool.release();
	}
}
