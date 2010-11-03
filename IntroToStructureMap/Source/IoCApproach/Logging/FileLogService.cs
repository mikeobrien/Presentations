using System;
using System.IO;
using System.Reflection;

namespace IoCApproach.Logging
{
    public class FileLogService : ILogService
    {
        private string _path;

        //public FileLogService()
        //{
        //    _path = Path.Combine(
        //        Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
        //        Path.GetFileName(Assembly.GetEntryAssembly().Location) + ".log");
        //}

        public FileLogService(string path)
        {
            _path = path;
        }

        public void Log(string message)
        {
            Console.Write("FileLogger: {0}, {1}: {2}\r\n", _path, DateTime.Now, message);
        }
    }
}
