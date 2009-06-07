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

using MObjc;
using System;

namespace MCocoa
{
	/// <summary>Custom methods added to all generated classes.</summary>
	/// <remarks>Note that this class is not intended to be used: it's just a placeholder to
	/// allow the generated methods to be conveniently documented.</remarks>
	public sealed class GeneratedCode : NSObject
	{
		/// <summary>Creates a managed instance using an associated unmanaged instance.</summary>
		/// <remarks>This will not affect the retain code and may be called automagically when nibs are loaded.</remarks>
		public GeneratedCode(IntPtr instance) : base(instance)
		{
		}
		
		/// <summary>Allocates a new uninitialized object.</summary>
		/// <remarks>Unlike <c>alloc</c> this will have a reasonable return type. The retain
		/// count will be one.</remarks>
		public static GeneratedCode Alloc()
		{
			throw new NotImplementedException();
		}
		
		/// <summary>Allocates a new default initialized object.</summary>
		/// <remarks>The object is added to the autorelease pool.</remarks>
		public static GeneratedCode Create()
		{
			throw new NotImplementedException();
		}
		
		/// <summary>Increments the object's retain count.</summary>
		/// <remarks>Unlike <c>retain</c> this has a reasonable return type.</remarks>
		public new GeneratedCode Retain()
		{
			throw new NotImplementedException();
		}
		
		/// <summary>Returns the class for the type.</summary>
		/// <remarks>To get the dynamic class of an instance use <c>class_</c>.</remarks>
		public static new Class Class
		{
			get {throw new NotImplementedException();}
		}
	}
}
