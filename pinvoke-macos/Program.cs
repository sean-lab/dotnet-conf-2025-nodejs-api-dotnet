using System.Runtime.InteropServices;

class Program
{
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

    [DllImport("libc")]
    public static extern int uname(out Utsname buf);

    static void Main()
    {
        Utsname uts;
        if (uname(out uts) == 0)
        {
            Console.WriteLine($"System Name: {uts.sysname}");
            Console.WriteLine($"Node Name: {uts.nodename}");
            Console.WriteLine($"Release: {uts.release}");
            Console.WriteLine($"Version: {uts.version}");
            Console.WriteLine($"Machine: {uts.machine}");
        }
        else
        {
            Console.WriteLine("uname call failed");
        }
    }
}