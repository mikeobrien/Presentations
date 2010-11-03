using System;
using IoCApproach.Logging;

namespace IoCApproach.Email
{
    public class PersitsEmailService : IEmailService
    {
        private ILogService _log;

        public PersitsEmailService(ILogService log)
        {
            _log = log;
        }

        public void Send(string email, string subject, string body)
        {
            try
            {
                Console.Write("Persits: {0}, {1}\r\n", email, subject);
            }
            catch (Exception e)
            {
                _log.Log(e.Message);
                throw;
            }
        }
    }
}
