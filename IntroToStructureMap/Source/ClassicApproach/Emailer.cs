using System;
using System.Net.Mail;

namespace ClassicApproach
{
    public static class Emailer
    {
        public static void Send(string email, string subject, string body)
        {
            try
            {
                Console.Write("NetEmailer: {0}, {1}\r\n", email, subject);        
            }
            catch (Exception e)
            {
                Logger.Log(e.Message);
                throw;
            }
        }
    }
}
