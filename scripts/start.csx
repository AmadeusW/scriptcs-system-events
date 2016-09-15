using System;
using PInvoke;

Kernel32.SYSTEMTIME time;
Kernel32.GetSystemTime(out time);
Console.WriteLine(time.wMinute.ToString());