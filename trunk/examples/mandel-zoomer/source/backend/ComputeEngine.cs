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

using MObjc.Helpers;
using System;
using System.Linq;

// Computes dwells using Computers.
internal sealed class ComputeEngine
{
	public ComputeEngine(FractalSettings settings)
	{
		int height = settings.Height;		// note that we need to use these locals to avoid creating tens of thousands of BigFloat objects in the loop
		int width = settings.Width;
		m_samples = new float[width, height];
		for (int v = 0; v < height; ++v)
			for (int h = 0; h < width; ++h)
				m_samples[h, v] = float.NaN;
		
//		Console.WriteLine("dx: {0:F}", settings.Extent.Width/width);
		
		const int NumThreads = 4;
		m_computers = new Computer[NumThreads];
		
		int startRow = 0;
		int numRows = height/NumThreads;
		for (int i = 0; i < NumThreads; ++i)
		{
			if (i + 1 == NumThreads)
				numRows = height - startRow;
				
			m_computers[i] = new Computer(settings, startRow, numRows, m_samples);
			startRow += numRows;
		}
	}
	
	public float[,] Samples
	{
		get {return m_samples;}
	}
	
	public float MinDwell
	{
		get {return m_computers.Min(c => c.MinDwell);}
	}
	
	// Max dwell we found.
	public float MaxDwell
	{
		get {return m_computers.Max(c => c.MaxDwell);}
	}
	
	public float MinSample
	{
		get {return m_computers.Min(c => c.MinSample);}
	}
	
	public float MaxSample
	{
		get {return m_computers.Max(c => c.MaxSample);}
	}
	
	// In minutes.
	public double RenderTime
	{
		get {return m_computers.Max(c => c.ElapsedTime.TotalMinutes);}
	}
	
	public bool AllDone
	{
		get {return m_computers.All(c => c.Done);}
	}
	
	public void Abort()
	{
		foreach (Computer computer in m_computers)
		{
			computer.Abort();
		}
	}
	
	#region Fields
	private Computer[] m_computers;
	private float[,] m_samples;
	#endregion
}
