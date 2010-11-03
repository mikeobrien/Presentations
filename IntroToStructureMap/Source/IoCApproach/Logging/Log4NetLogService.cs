using System;

namespace IoCApproach.Logging
{
    public class Log4NetLogService : ILogService
    {
        public void Log(string message)
        {
            Console.Write("Log4Net: {0}, {1}\r\n", DateTime.Now, message);
        }
    }
}
