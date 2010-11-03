using System;

namespace IoCApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = Registry.Current.Resolve<NotificationService>();

            notificationService.SendMeetingRescheduleNotification("gpugh", "Craftsmanship SIG", new DateTime(2010, 3, 31));

            Console.WriteLine("Notification has been sent!");
            Console.ReadKey();
        }
    }
}
