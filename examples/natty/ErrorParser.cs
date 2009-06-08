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
using System.Text.RegularExpressions;

internal class Error
{
	public readonly string Message;
	public readonly string File;
	public readonly string Line;
	public readonly bool IsError;
	
	public Error(string message, string file, string line, bool isError)
	{
		Message = message;
		File = file;
		Line = line;
		IsError = isError;
	}
}

internal static class ErrorParser
{
	public static Error Parse(string line)
	{
		Error error = null;
		
		Match match = ms_gmcsRE.Match(line);
		if (match.Success)
		{
			error = new Error(
				match.Groups[4].ToString(),
				match.Groups[1].ToString(),
				match.Groups[2].ToString(),
				match.Groups[3].ToString() == "error");
		}
		
		return error;
	}
	
	//                                             1             2                   3                           4
	//                                             TheFile.cs   (5     , 19  ) :     error              CS0234 : The type...
	private static Regex ms_gmcsRE = new Regex(@"([\w\.\-\\\/]+)\((\d+) , \d+\) : \s+ (error|warning) \s+ \w+    : (.+)$", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline);
}
