using System;
using NUnit.Framework;

namespace ClassicApproach
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void NotificationServiceTest()
        {
            NotificationService notificationService = new NotificationService();

            notificationService.SendMeetingRescheduleNotification("test", "yada yada yada", new DateTime(2010, 3, 31));

            // So how do we test this?? Make sure there was no exception? Check the test mailbox and parse the email? 
            // What if the SMTP server is down, that doesent mean the code is bad, but the test will fail.... This sucks!
        }
    }
}
