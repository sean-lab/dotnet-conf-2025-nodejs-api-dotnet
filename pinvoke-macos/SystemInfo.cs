using System.Runtime.InteropServices;
using Microsoft.JavaScript.NodeApi;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct Utsname
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string sysname;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string nodename;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string release;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string version;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string machine;
}

[JSExport]
public class SystemInfo
{
    public string? sysname { get; set; }
    public string? nodename { get; set; }
    public string? release { get; set; }
    public string? version { get; set; }
    public string? machine { get; set; }
}

[JSExport]
public static class LibcWrapper
{
    [DllImport("libc")]
    private static extern int uname(out Utsname buf);

    public static SystemInfo Uname()
    {
        Utsname uts;
        if (uname(out uts) == 0)
        {
            return new SystemInfo
            {
                sysname = uts.sysname,
                nodename = uts.nodename,
                release = uts.release,
                version = uts.version,
                machine = uts.machine
            };
        }
        else
        {
            throw new JSException("uname call failed");
        }
    }
}
