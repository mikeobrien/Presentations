using System;
using System.Net.Mail;
using IoCApproach.Logging;

namespace IoCApproach.Email
{
    public class NetEmailService : IEmailService
    {
        private ILogService _log;
        private string _smtpServer;

        //public NetEmailService(ILogService log)
        //{
        //    _log = log;
        //    _smtpServer = "mail.trinug.org";
        //}

        public NetEmailService(ILogService log, string smtpServer)
        {
            _log = log;
            _smtpServer = smtpServer;
        }

        public void Send(string email, string subject, string body)
        {
            try
            {
                Console.Write("NetEmailer: {0}, {1}, {2}\r\n", _smtpServer, email, subject); 
            }
            catch (Exception e)
            {
                _log.Log(e.Message);
                throw;
            }
        }
    }
}
