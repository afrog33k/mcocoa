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
		public const uint NSTouchPhaseTouching = NSTouchPhaseBegan | NSTouchPhaseMoved | NSTouchPhaseStationary;
		
		public const ulong NSMappedRead = NSDataReadingMapped;
		public const ulong NSUncachedRead = NSDataReadingUncached;
		public const ulong NSAtomicWrite = NSDataWritingAtomic;
		
		public const uint NSHashTableStrongMemory = 0;
		public const uint NSHashTableZeroingWeakMemory = (uint) NSPointerFunctionsZeroingWeakMemory;
		public const uint NSHashTableCopyIn = (uint) NSPointerFunctionsCopyIn;
		public const uint NSHashTableObjectPointerPersonality = (uint) NSPointerFunctionsObjectPointerPersonality;
		
		public const uint kCFLocaleLanguageDirectionUnknown = 0;
		public const uint kCFLocaleLanguageDirectionLeftToRight = 1;
		public const uint kCFLocaleLanguageDirectionRightToLeft = 2;
		public const uint kCFLocaleLanguageDirectionTopToBottom = 3;
		public const uint kCFLocaleLanguageDirectionBottomToTop = 4;
		
		public const uint NSLocaleLanguageDirectionUnknown = kCFLocaleLanguageDirectionUnknown;
		public const uint NSLocaleLanguageDirectionLeftToRight = kCFLocaleLanguageDirectionLeftToRight;
		public const uint NSLocaleLanguageDirectionRightToLeft = kCFLocaleLanguageDirectionRightToLeft;
		public const uint NSLocaleLanguageDirectionTopToBottom = kCFLocaleLanguageDirectionTopToBottom;
		public const uint NSLocaleLanguageDirectionBottomToTop = kCFLocaleLanguageDirectionBottomToTop;
		
		public const uint NSMapTableStrongMemory = 0;
		public const uint NSMapTableZeroingWeakMemory = (uint) NSPointerFunctionsZeroingWeakMemory;
		public const uint NSMapTableCopyIn = (uint) NSPointerFunctionsCopyIn;
		public const uint NSMapTableObjectPointerPersonality = (uint) NSPointerFunctionsObjectPointerPersonality;
		
		public const ulong NSXMLNodePreserveEmptyElements = (NSXMLNodeExpandEmptyElement | NSXMLNodeCompactEmptyElement);
		public const ulong NSXMLNodePreserveQuotes = (NSXMLNodeUseSingleQuotes | NSXMLNodeUseDoubleQuotes);
		public const ulong NSXMLNodePreserveAll = (
            NSXMLNodePreserveNamespaceOrder | 
            NSXMLNodePreserveAttributeOrder | 
            NSXMLNodePreserveEntities | 
            NSXMLNodePreservePrefixes | 
            NSXMLNodePreserveCDATA | 
            NSXMLNodePreserveEmptyElements | 
            NSXMLNodePreserveQuotes | 
            NSXMLNodePreserveWhitespace |
            NSXMLNodePreserveDTD |
            NSXMLNodePreserveCharacterReferences |
            0xFFF00000);
		
		public const ulong NSTextCheckingAllTypes = (NSTextCheckingAllSystemTypes | NSTextCheckingAllCustomTypes);
		
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
		public const int NX_SUBTYPE_MOUSE_TOUCH = 3;
		
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
		public const int kCFCalendarUnitQuarter = (1 << 11);
		
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
		
		public const int kCFURLErrorUnknown = -998;
		public const int kCFURLErrorCancelled = -999;
		public const int kCFURLErrorBadURL = -1000;
		public const int kCFURLErrorTimedOut = -1001;
		public const int kCFURLErrorUnsupportedURL = -1002;
		public const int kCFURLErrorCannotFindHost = -1003;
		public const int kCFURLErrorCannotConnectToHost = -1004;
		public const int kCFURLErrorNetworkConnectionLost = -1005;
		public const int kCFURLErrorDNSLookupFailed = -1006;
		public const int kCFURLErrorHTTPTooManyRedirects = -1007;
		public const int kCFURLErrorResourceUnavailable = -1008;
		public const int kCFURLErrorNotConnectedToInternet = -1009;
		public const int kCFURLErrorRedirectToNonExistentLocation = -1010;
		public const int kCFURLErrorBadServerResponse = -1011;
		public const int kCFURLErrorUserCancelledAuthentication = -1012;
		public const int kCFURLErrorUserAuthenticationRequired = -1013;
		public const int kCFURLErrorZeroByteResource = -1014;
		public const int kCFURLErrorCannotDecodeRawData = -1015;
		public const int kCFURLErrorCannotDecodeContentData = -1016;
		public const int kCFURLErrorCannotParseResponse = -1017;
		public const int kCFURLErrorInternationalRoamingOff = -1018;
		public const int kCFURLErrorCallIsActive = -1019;
		public const int kCFURLErrorDataNotAllowed = -1020;
		public const int kCFURLErrorRequestBodyStreamExhausted = -1021;
		public const int kCFURLErrorFileDoesNotExist = -1100;
		public const int kCFURLErrorFileIsDirectory = -1101;
		public const int kCFURLErrorNoPermissionsToReadFile = -1102;
		public const int kCFURLErrorDataLengthExceedsMaximum = -1103;
		
		public const int kCFURLErrorCannotCreateFile = -3000;
		public const int kCFURLErrorCannotOpenFile = -3001;
		public const int kCFURLErrorCannotCloseFile = -3002;
		public const int kCFURLErrorCannotWriteToFile = -3003;
		public const int kCFURLErrorCannotRemoveFile = -3004;
		public const int kCFURLErrorCannotMoveFile = -3005;
		public const int kCFURLErrorDownloadDecodingFailedMidStream = -3006;
		public const int kCFURLErrorDownloadDecodingFailedToComplete = -3007;
		
		public const int kCFURLErrorSecureConnectionFailed = -1200;
		public const int kCFURLErrorServerCertificateHasBadDate = -1201;
		public const int kCFURLErrorServerCertificateUntrusted = -1202;
		public const int kCFURLErrorServerCertificateHasUnknownRoot = -1203;
		public const int kCFURLErrorServerCertificateNotYetValid = -1204;
		public const int kCFURLErrorClientCertificateRejected = -1205;
		public const int kCFURLErrorClientCertificateRequired = -1206;
		public const int kCFURLErrorCannotLoadFromNetwork = -2000;
	}
}
