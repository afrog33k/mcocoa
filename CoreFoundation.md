Sometimes it is useful to drop down to Carbon or Core Foundation for things not
exposed by Cocoa. mcocoa won't help with this, but it's easy to do with a p/invoke
call. For example:

```
[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
private extern static IntPtr CFRunLoopGetMain();

[DllImport("/System/Library/Frameworks/Carbon.framework/Carbon")]
private extern static uint GetDblTime();
```