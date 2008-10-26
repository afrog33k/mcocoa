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

using NUnit.Framework;
using System;

// Verify that we can find the various forms of @interface declarations.
[TestFixture]
public class InterfacesTest 	
{
	[Test]
	public void Simple()	
	{
		InterfaceParser parser = new InterfaceParser("test", 
@"/*	NSTimer.h
	Copyright (c) 1994-2007, Apple Inc. All rights reserved.
*/

#import <Foundation/NSObject.h>
#import <Foundation/NSDate.h>

@interface NSTimer : NSObject
@end x");
		Assert.IsFalse(parser.AtEnd);
				
		NativeInterface ni = parser.Interface;
		Assert.AreEqual("NSTimer", ni.Name);
		Assert.AreEqual("NSObject", ni.BaseName);
		
		Assert.AreEqual(0, ni.Protocols.Length);
		Assert.IsNull(ni.Category);

		parser.Advance();
		Assert.IsTrue(parser.AtEnd);
	}

	[Test]
	public void Protocols()	 
	{
		InterfaceParser parser = new InterfaceParser("test", 
@"#import <limits.h>

@class NSData, NSArray, NSDictionary, NSCharacterSet, NSData, NSURL, NSError, NSLocale;

#if MAC_OS_X_VERSION_10_4 <= MAC_OS_X_VERSION_MAX_ALLOWED
enum {
    NSStringEncodingConversionAllowLossy = 1,
    NSStringEncodingConversionExternalRepresentation = 2
};
#endif

@interface NSString : NSObject <NSCopying, NSMutableCopying, NSCoding>

/* NSString primitive (funnel) methods. A minimal subclass of NSString just needs to implement these, although we also recommend getCharacters:range:. See below for the other methods.
*/
@end");				
		NativeInterface ni = parser.Interface;
		Assert.AreEqual("NSString", ni.Name);
		Assert.AreEqual("NSObject", ni.BaseName);
		
		Assert.AreEqual(3, ni.Protocols.Length);
		Assert.AreEqual("NSCopying", ni.Protocols[0]);
		Assert.AreEqual("NSMutableCopying", ni.Protocols[1]);
		Assert.AreEqual("NSCoding", ni.Protocols[2]);

		Assert.IsNull(ni.Category);
	}

	[Test]
	public void Categories()	 
	{
		InterfaceParser parser = new InterfaceParser("test", 
@"#import <limits.h>

@class NSData, NSArray, NSDictionary, NSCharacterSet, NSData, NSURL, NSError, NSLocale;

#if MAC_OS_X_VERSION_10_4 <= MAC_OS_X_VERSION_MAX_ALLOWED
enum {
    NSStringEncodingConversionAllowLossy = 1,
    NSStringEncodingConversionExternalRepresentation = 2
};
#endif

@interface NSString (NSExtendedStringPropertyListParsing)
@end
");				
				
		NativeInterface ni = parser.Interface;
		Assert.AreEqual("NSString", ni.Name);
		Assert.IsNull(ni.BaseName);
		
		Assert.AreEqual(0, ni.Protocols.Length);
		Assert.AreEqual("NSExtendedStringPropertyListParsing", ni.Category);
	}

	[Test]
	public void Methods()	 
	{
		InterfaceParser parser = new InterfaceParser("test", 
@"#import <limits.h>

@class NSData, NSArray, NSDictionary, NSCharacterSet, NSData, NSURL, NSError, NSLocale;

#if MAC_OS_X_VERSION_10_4 <= MAC_OS_X_VERSION_MAX_ALLOWED
enum {
    NSStringEncodingConversionAllowLossy = 1,
    NSStringEncodingConversionExternalRepresentation = 2
};
#endif

@interface NSString (NSStringExtensionMethods)

- (NSUInteger)length;			
- (void)getCharacters:(unichar *)buffer;
- (void)getCharacters:(unichar *)buffer range:(NSRange)aRange;
@end");				
		NativeInterface ni = parser.Interface;
		Assert.AreEqual(3, ni.Methods.Count);
		
		Assert.AreEqual("length", ni.Methods[0].Name);
		Assert.AreEqual("NSUInteger", ni.Methods[0].ReturnType);
		Assert.AreEqual(0, ni.Methods[0].ArgNames.Length);

		Assert.AreEqual("getCharacters:", ni.Methods[1].Name);
		Assert.AreEqual("void", ni.Methods[1].ReturnType);
		Assert.AreEqual(1, ni.Methods[1].ArgNames.Length);
		Assert.AreEqual("buffer", ni.Methods[1].ArgNames[0]);
		Assert.AreEqual("unichar *", ni.Methods[1].ArgTypes[0]);

		Assert.AreEqual("getCharacters:range:", ni.Methods[2].Name);
		Assert.AreEqual("void", ni.Methods[2].ReturnType);
		Assert.AreEqual(2, ni.Methods[2].ArgNames.Length);
		Assert.AreEqual("buffer", ni.Methods[2].ArgNames[0]);
		Assert.AreEqual("unichar *", ni.Methods[2].ArgTypes[0]);
		Assert.AreEqual("aRange", ni.Methods[2].ArgNames[1]);
		Assert.AreEqual("NSRange", ni.Methods[2].ArgTypes[1]);
	}

	[Test]
	public void Methods2()	 
	{
		InterfaceParser parser = new InterfaceParser("test", 
@"#import <limits.h>

@class NSData, NSArray, NSDictionary, NSCharacterSet, NSData, NSURL, NSError, NSLocale;

#if MAC_OS_X_VERSION_10_4 <= MAC_OS_X_VERSION_MAX_ALLOWED
enum {
    NSStringEncodingConversionAllowLossy = 1,
    NSStringEncodingConversionExternalRepresentation = 2
};
#endif

@interface NSString (NSStringExtensionMethods)

- (NSUInteger)length;			
#if FOO
- (void)getCharacters:(unichar *)buffer;
- (void)getCharacters:(unichar *)buffer range:(NSRange)aRange;
+ (id)arrayWithObjects:(id)firstObj, ... NS_REQUIRES_NIL_TERMINATION;
#endif
@end");				
		NativeInterface ni = parser.Interface;
		Assert.AreEqual(4, ni.Methods.Count);
		
		Assert.AreEqual("length", ni.Methods[0].Name);
		Assert.AreEqual("NSUInteger", ni.Methods[0].ReturnType);
		Assert.AreEqual(0, ni.Methods[0].ArgNames.Length);

		Assert.AreEqual("getCharacters:", ni.Methods[1].Name);
		Assert.AreEqual("void", ni.Methods[1].ReturnType);
		Assert.AreEqual(1, ni.Methods[1].ArgNames.Length);
		Assert.AreEqual("buffer", ni.Methods[1].ArgNames[0]);
		Assert.AreEqual("unichar *", ni.Methods[1].ArgTypes[0]);

		Assert.AreEqual("getCharacters:range:", ni.Methods[2].Name);
		Assert.AreEqual("void", ni.Methods[2].ReturnType);
		Assert.AreEqual(2, ni.Methods[2].ArgNames.Length);
		Assert.AreEqual("buffer", ni.Methods[2].ArgNames[0]);
		Assert.AreEqual("unichar *", ni.Methods[2].ArgTypes[0]);
		Assert.AreEqual("aRange", ni.Methods[2].ArgNames[1]);
		Assert.AreEqual("NSRange", ni.Methods[2].ArgTypes[1]);

		Assert.AreEqual("arrayWithObjects:", ni.Methods[3].Name);
		Assert.AreEqual("id", ni.Methods[3].ReturnType);
		Assert.AreEqual(2, ni.Methods[3].ArgNames.Length);
		Assert.AreEqual("firstObj", ni.Methods[3].ArgNames[0]);
		Assert.AreEqual("id", ni.Methods[3].ArgTypes[0]);
		Assert.AreEqual(string.Empty, ni.Methods[3].ArgNames[1]);
		Assert.AreEqual("...", ni.Methods[3].ArgTypes[1]);
	}

	[Test]
	public void DeprecatedMethod()	 
	{
		InterfaceParser parser = new InterfaceParser("test", 
@"#import <limits.h>

@interface NSString (NSStringExtensionMethods)

- (NSUInteger)length;			
- (void)getCharacters:(unichar *)buffer DEPRECATED_IN_MAC_OS_X_VERSION_10_4_AND_LATER;
- (void)getCharacters:(unichar *)buffer range:(NSRange)aRange DEPRECATED_IN_MAC_OS_X_VERSION_10_4_AND_LATER;
+ (id)fileURLWithPath:(NSString *)path isDirectory:(BOOL) isDir AVAILABLE_MAC_OS_X_VERSION_10_4_AND_LATER;
@end");				
		NativeInterface ni = parser.Interface;
		Assert.AreEqual(2, ni.Methods.Count);
		
		Assert.AreEqual("length", ni.Methods[0].Name);
		Assert.AreEqual("NSUInteger", ni.Methods[0].ReturnType);
		Assert.AreEqual(0, ni.Methods[0].ArgNames.Length);
		
		Assert.AreEqual("fileURLWithPath:isDirectory:", ni.Methods[1].Name);
		Assert.AreEqual("id", ni.Methods[1].ReturnType);
	}
}
