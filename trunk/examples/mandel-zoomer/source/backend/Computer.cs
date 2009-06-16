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
using System.Runtime.InteropServices;
using System.Threading;

// Computes dwells for a region of the image using a thread.
internal sealed class Computer
{
	public Computer(FractalSettings settings, int startRow, int numRows, float[,] samples)
	{
		Contract.Requires(startRow >= 0, "startRow is negative");
		Contract.Requires(numRows > 0, "numRows is not positive");
		Contract.Requires(samples != null, "samples is null");
		
		m_settings = settings;
		m_startRow = startRow;
		m_numRows = numRows;
		m_samples = samples;
		
		// TODO: may want to use threads so we can lower the priority of
		// images in the background (of course mono doesn't support thread
		// priorities...)
		ThreadPool.QueueUserWorkItem(o => DoThread());	// the pool uses background threads so the app will exit even if this thread is still running
	}
	
	public bool Done
	{
		get {return m_done || m_aborted;}
	}
	
	public void Abort()
	{
		m_aborted = true;
	}
	
	public float MinSample
	{
		get {return m_minSample;}
	}
	
	public float MaxSample
	{
		get {return m_maxSample;}
	}
	
	public float MinDwell
	{
		get {return m_minDwell;}
	}
	
	// Max dwell we found.
	public float MaxDwell
	{
		get {return m_maxDwell;}
	}
	
	public TimeSpan ElapsedTime
	{
		get
		{
			if (Done)
			{
				lock (m_mutex)
				{
					return m_stopTime - m_startTime;
				}
			}
			else
			{
				return DateTime.Now - m_startTime;
			}
		}
	}
	
	// Note that doubles breakdown at about dx = 5e-16.
	public const int MaxDoubleBits = 50;
	
	#region Private Methods
	private static readonly double A = Math.Log(Math.Log((double) BigFloat.Bailout));
	private static readonly double B = Math.Log(2.0);
	
	[ThreadModel(ThreadModel.SingleThread)]
	private void DoThread()
	{
		BigFloat dy = m_settings.Extent.Height/m_settings.Height;
		BigFloat dx = m_settings.Extent.Width/m_settings.Width;
		
#if LIBGMP
		bool useSmall = Math.Max(dx.Precision, dy.Precision) < MaxDoubleBits;
#else
		bool useSmall = true;
#endif
		
		if (useSmall)
			DoComputeRows(
				(double) (m_settings.Extent.TopLeft.X),
				(double) (m_settings.Extent.TopLeft.Y),
				(double) dx,
				(double) dy,
				m_startRow,
				m_numRows,
				m_settings.Width,
				m_settings.MaxDwell);
#if LIBGMP
		else
			DoComputeRows(
				m_settings.Extent.TopLeft.X,
				m_settings.Extent.TopLeft.Y,
				dx,
				dy,
				m_startRow,
				m_numRows,
				m_settings.Width,
				m_settings.MaxDwell);
#endif
		
		lock (m_mutex)
		{
			m_stopTime = DateTime.Now;
			m_done = true;
		}
	}
	
	private struct SmallInfo
	{
		public double startX;
		public double startY;
		public double dx;
		public double dy;
		public double bailout;
		public int h;
		public int v;
		public int maxDwell;
	}
	
	private void DoComputeRows(double startX, double startY, double dx, double dy, int startRow, int numRows, int width, int maxDwell)
	{
		SmallInfo info;
		info.startX = startX;
		info.startY = startY;
		info.dx = dx;
		info.dy = dy;
		info.bailout = (double) BigFloat.Bailout;
		info.maxDwell = maxDwell;
		
		for (int v = startRow; v < startRow + numRows && !m_aborted; ++v)
		{
			info.v = v;
			
			for (int h = 0; h < width && !m_aborted; ++h)
			{
				info.h = h;
				double mag;
				ushort dwell;
				SmallCompute(info, out mag, out dwell);
				
				float sample;
				if (dwell < maxDwell)
					sample = (float) (dwell + (A - Math.Log(0.5*Math.Log(mag)))/B);	// Continuous Smoothing (see http://en.wikipedia.org/wiki/Mandelbrot_set#Continuous_.28smooth.29_coloring)
				else
					sample = float.PositiveInfinity;
				
				m_samples[h, v] = sample;
				
				m_minDwell = Math.Min(m_minDwell, dwell);
				m_maxDwell = Math.Max(m_maxDwell, dwell);
				if (!float.IsInfinity(sample))
				{
					m_minSample = Math.Min(m_minSample, sample);
					m_maxSample = Math.Max(m_maxSample, sample);
				}
			}
		}
	}
	
#if LIBGMP
	private unsafe struct BigInfo
	{
		public mpf_struct startX;
		public mpf_struct startY;
		public mpf_struct dx;
		public mpf_struct dy;
		public mpf_struct bailout;
		public int h;
		public int v;
		public int maxDwell;
	}

	private void DoComputeRows(BigFloat startX, BigFloat startY, BigFloat dx, BigFloat dy, int startRow, int numRows, int width, int maxDwell)
	{
		BigInfo info;
		info.startX = startX;
		info.startY = startY;
		info.dx = dx;
		info.dy = dy;
		info.bailout = BigFloat.Bailout;
		info.maxDwell = maxDwell;
		
		for (int v = startRow; v < startRow + numRows && !m_aborted; ++v)
		{
			info.v = v;
			
			for (int h = 0; h < width && !m_aborted; ++h)
			{
				info.h = h;
				double mag;
				ushort dwell;
				BigCompute(info, out mag, out dwell);
				
				float sample;
				if (dwell < maxDwell)
					sample = (float) (dwell + (A - Math.Log(0.5*Math.Log(mag)))/B);	// Continuous Smoothing (see http://en.wikipedia.org/wiki/Mandelbrot_set#Continuous_.28smooth.29_coloring)
				else
					sample = float.PositiveInfinity;
				
				m_samples[h, v] = sample;
				
				m_minDwell = Math.Min(m_minDwell, dwell);
				m_maxDwell = Math.Max(m_maxDwell, dwell);
				if (!float.IsInfinity(sample))
				{
					m_minSample = Math.Min(m_minSample, sample);
					m_maxSample = Math.Max(m_maxSample, sample);
				}
			}
		}
	}
#endif
	#endregion
	
	#region P/Invokes
	[DllImport("native.dylib")]
	private extern static void SmallCompute(SmallInfo info, out double outMag, out ushort dwell);
	
#if LIBGMP
	[DllImport("native.dylib")]
	private extern static void BigCompute(BigInfo info, out double outMag, out ushort dwell);
#endif
	#endregion
	
	#region Fields
	private FractalSettings m_settings;
	private int m_startRow;
	private int m_numRows;
	private float[,] m_samples;
	private volatile bool m_done;
	private volatile bool m_aborted;
	private volatile ushort m_minDwell = ushort.MaxValue;
	private volatile ushort m_maxDwell = ushort.MinValue;
	private volatile float m_minSample = float.MaxValue;
	private volatile float m_maxSample = float.MinValue;
	private DateTime m_startTime = DateTime.Now;
	
	private object m_mutex = new object();
		private DateTime m_stopTime;
	#endregion
}
