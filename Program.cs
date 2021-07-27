using System;

namespace Case_study_DesginPattern_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            NotificationService notificationService = new NotificationService();

            notificationService.Subscribe(admin);

            Console.WriteLine("Events are : dance, music, photography");
            Console.WriteLine("Enter event Name and ticket booked:");


            string eventName = Console.ReadLine();
            int bookedTickets = int.Parse(Console.ReadLine());
            notificationService.ChangeState(bookedTickets, eventName);

            eventName = Console.ReadLine();
            bookedTickets = int.Parse(Console.ReadLine());
            notificationService.ChangeState(bookedTickets, eventName);

        }
    }
}
