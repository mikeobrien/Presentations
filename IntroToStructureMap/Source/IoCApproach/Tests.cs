using System;
using IoCApproach.Email;
using NUnit.Framework;

namespace IoCApproach
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void NotificationServiceTest()
        {
            // You can use a mocking framework to create this stub. Just keeping it simple for the demo.
            EmailServiceStub emailServiceStub = new EmailServiceStub();

            NotificationService notificationService = new NotificationService(emailServiceStub);

            notificationService.SendMeetingRescheduleNotification("test", "yada yada yada", new DateTime(2010, 3, 31));

            Assert.AreEqual("test@trinug.org", emailServiceStub.Email);
            Assert.AreEqual("test, this is a very important notification!", emailServiceStub.Subject);
            Assert.AreEqual("test, this is to inform you that the yada yada yada has been rescheduled to 3/31/2010 12:00:00 AM.", emailServiceStub.Body);
        }
    }

    public class EmailServiceStub : IEmailService
    {
        public void Send(string email, string subject, string body)
        {
            Email = email;
            Subject = subject;
            Body = body;
        }

        public string Email { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }
    }
}
