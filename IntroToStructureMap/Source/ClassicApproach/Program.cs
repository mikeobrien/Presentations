using System;

namespace ClassicApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();

            notificationService.SendMeetingRescheduleNotification("gpugh", "Craftsmanship SIG", new DateTime(2010, 3, 31));

            Console.WriteLine("Notification has been sent!");
            Console.ReadKey();
        }
    }
}
