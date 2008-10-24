// machine generated on 10/24/2008 3:54:04 PM using /System/Library/Frameworks/Foundation.framework/Versions/Current/Headers/NSXMLNodeOptions.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSXMLNodeOptionsNone = 0;
		public const int NSXMLNodeIsCDATA = 1 << 0;
		public const int NSXMLNodeExpandEmptyElement = 1 << 1;
		public const int NSXMLNodeCompactEmptyElement = 1 << 2;
		public const int NSXMLNodeUseSingleQuotes = 1 << 3;
		public const int NSXMLNodeUseDoubleQuotes = 1 << 4;
		public const int NSXMLDocumentTidyHTML = 1 << 9;
		public const int NSXMLDocumentTidyXML = 1 << 10;
		public const int NSXMLDocumentValidate = 1 << 13;
		public const int NSXMLDocumentXInclude = 1 << 16;
		public const int NSXMLNodePrettyPrint = 1 << 17;
		public const int NSXMLDocumentIncludeContentTypeDeclaration = 1 << 18;
		public const int NSXMLNodePreserveNamespaceOrder = 1 << 20;
		public const int NSXMLNodePreserveAttributeOrder = 1 << 21;
		public const int NSXMLNodePreserveEntities = 1 << 22;
		public const int NSXMLNodePreservePrefixes = 1 << 23;
		public const int NSXMLNodePreserveCDATA = 1 << 24;
		public const int NSXMLNodePreserveWhitespace = 1 << 25;
		public const int NSXMLNodePreserveDTD = 1 << 26;
		public const int NSXMLNodePreserveCharacterReferences = 1 << 27;
		public const int NSXMLNodePreserveEmptyElements = ( NSXMLNodeExpandEmptyElement | NSXMLNodeCompactEmptyElement );
		public const int NSXMLNodePreserveQuotes = ( NSXMLNodeUseSingleQuotes | NSXMLNodeUseDoubleQuotes );
		public const uint NSXMLNodePreserveAll = ( NSXMLNodePreserveNamespaceOrder | NSXMLNodePreserveAttributeOrder | NSXMLNodePreserveEntities | NSXMLNodePreservePrefixes | NSXMLNodePreserveCDATA | NSXMLNodePreserveEmptyElements | NSXMLNodePreserveQuotes | NSXMLNodePreserveWhitespace | NSXMLNodePreserveDTD | NSXMLNodePreserveCharacterReferences | 0xFFF00000 );
	}

}
