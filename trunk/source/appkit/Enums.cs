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

using System;

namespace MCocoa
{
	/// <exclude/>
	public partial class Enums
	{
		public const int NX_TABLET_POINTER_UNKNOWN = 0;
		public const int NX_TABLET_POINTER_PEN = 1;
		public const int NX_TABLET_POINTER_CURSOR = 2;
		public const int NX_TABLET_POINTER_ERASER = 3;
		
		public const int NX_TABLET_BUTTON_PENTIPMASK = 0x0001;
		public const int NX_TABLET_BUTTON_PENLOWERSIDEMASK = 0x0002;
		public const int NX_TABLET_BUTTON_PENUPPERSIDEMASK = 0x0004;
		
		public const int NX_SUBTYPE_DEFAULT = 0;
		public const int NX_SUBTYPE_TABLET_POINT = 1;
		public const int NX_SUBTYPE_TABLET_PROXIMITY = 2;
		
		public const int CFByteOrderUnknown = 0;
		public const int CFByteOrderLittleEndian =1;
		public const int CFByteOrderBigEndian = 2;
		
		public const int kCFCalendarUnitEra = (1 << 1);
		public const int kCFCalendarUnitYear = (1 << 2);
		public const int kCFCalendarUnitMonth = (1 << 3);
		public const int kCFCalendarUnitDay = (1 << 4);
		public const int kCFCalendarUnitHour = (1 << 5);
		public const int kCFCalendarUnitMinute = (1 << 6);
		public const int kCFCalendarUnitSecond = (1 << 7);
		public const int kCFCalendarUnitWeek = (1 << 8);
		public const int kCFCalendarUnitWeekday = (1 << 9);
		public const int kCFCalendarUnitWeekdayOrdinal = (1 << 10);
		
		public const int kCFCalendarComponentsWrap = (1 << 0);  // option for adding
		
		public const int kCFDateFormatterNoStyle = 0;
		public const int kCFDateFormatterShortStyle = 1;
		public const int kCFDateFormatterMediumStyle = 2;
		public const int kCFDateFormatterLongStyle = 3;
		public const int kCFDateFormatterFullStyle = 4;
		
		public const int kCFNumberFormatterNoStyle = 0;
		public const int kCFNumberFormatterDecimalStyle = 1;
		public const int kCFNumberFormatterCurrencyStyle = 2;
		public const int kCFNumberFormatterPercentStyle = 3;
		public const int kCFNumberFormatterScientificStyle = 4;
		public const int kCFNumberFormatterSpellOutStyle = 5;
		
		public const int kCFNumberFormatterRoundCeiling = 0;
		public const int kCFNumberFormatterRoundFloor = 1;
		public const int kCFNumberFormatterRoundDown = 2;
		public const int kCFNumberFormatterRoundUp = 3;
		public const int kCFNumberFormatterRoundHalfEven = 4;
		public const int kCFNumberFormatterRoundHalfDown = 5;
		public const int kCFNumberFormatterRoundHalfUp = 6;
		
		public const int kCFNumberFormatterPadBeforePrefix = 0;
		public const int kCFNumberFormatterPadAfterPrefix = 1;
		public const int kCFNumberFormatterPadBeforeSuffix = 2;
		public const int kCFNumberFormatterPadAfterSuffix = 3;
		
		public const int kCFPropertyListImmutable = 0;
		public const int kCFPropertyListMutableContainers = 1;
		public const int kCFPropertyListMutableContainersAndLeaves = 2;
		
		public const int kCFPropertyListOpenStepFormat = 1;
		public const int kCFPropertyListXMLFormat_v1_0 = 100;
		public const int kCFPropertyListBinaryFormat_v1_0 = 200;
	}
}
