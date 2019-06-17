using System;

namespace docker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.Is64BitOperatingSystem);
            Console.WriteLine(Environment.Is64BitProcess);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.SystemDirectory);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.Version);
        }
    }
}
