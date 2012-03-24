// Copyright (C) 2012 Jesse Jones
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
using MObjc.Helpers;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int kCFCalendarUnitEra = 1 << 1;
		public const int kCFCalendarUnitYear = 1 << 2;
		public const int kCFCalendarUnitMonth = 1 << 3;
		public const int kCFCalendarUnitDay = 1 << 4;
		public const int kCFCalendarUnitHour = 1 << 5;
		public const int kCFCalendarUnitMinute = 1 << 6;
		public const int kCFCalendarUnitSecond = 1 << 7;
		public const int kCFCalendarUnitWeek = 1 << 8;
		public const int kCFCalendarUnitWeekday = 1 << 9;
		public const int kCFCalendarUnitWeekdayOrdinal = 1 << 10;
		public const int kCFCalendarUnitQuarter = 1 << 11;
		public const int kCFCalendarUnitWeekOfMonth = 1 << 12;
		public const int kCFCalendarUnitWeekOfYear = 1 << 13;
		public const int kCFCalendarUnitYearForWeekOfYear = 1 << 14;
	}
}
