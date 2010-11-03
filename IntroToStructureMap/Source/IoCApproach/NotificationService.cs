using System;
using IoCApproach.Email;

namespace IoCApproach
{
    public class NotificationService
    {
        private IEmailService _emailService;

        public NotificationService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void SendMeetingRescheduleNotification(string username, string meeting, DateTime date)
        {
            _emailService.Send(
                username + "@trinug.org",
                username + ", this is a very important notification!",
                string.Format("{0}, this is to inform you that the {1} has been rescheduled to {2}.", username, meeting, date));
        }
    }
}
