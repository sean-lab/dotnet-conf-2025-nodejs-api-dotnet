class Program
{
    static void Main()
    {
        SystemInfo si = LibcWrapper.Uname();
        Console.WriteLine($"System Name: {si.sysname}");
        Console.WriteLine($"Node Name: {si.nodename}");
        Console.WriteLine($"Release: {si.release}");
        Console.WriteLine($"Version: {si.version}");
        Console.WriteLine($"Machine: {si.machine}");
    }
}