using System;
using System.Reflection;
using System.IO;

namespace ClassicApproach
{
    public static class Logger
    {
        public static void Log(string message)
        {
            string path = Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                Path.GetFileName(Assembly.GetEntryAssembly().Location) + ".log");
            Console.Write("FileLogger: {0}, {1}: {2}\r\n", path, DateTime.Now, message);
        }
    }
}
