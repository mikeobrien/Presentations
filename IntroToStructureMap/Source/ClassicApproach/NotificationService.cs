using System;

namespace ClassicApproach
{
    public class NotificationService
    {
        public void SendMeetingRescheduleNotification(string username, string meeting, DateTime date)
        {
            Emailer.Send(
                username + "@trinug.org",
                username + ", this is a very important notification!",
                string.Format("{0}, this is to inform you that the {1} has been rescheduled to {2}.", username, meeting, date));
        }
    }
}
