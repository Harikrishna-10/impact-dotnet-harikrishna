using System;

class Program
{
    static void Main()
    {
        NotificationService service = new NotificationService();

        ConsoleLogger logger = new ConsoleLogger();

        service.OnNotificationSent += logger.Log;

        Notification notification = new Notification
        {
            Recipient = "hari@example.com",
            Message = "Welcome to the Notification Engine!"
        };

        Console.WriteLine("===== EMAIL =====");

        service.Send(
            notification,
            NotificationService.SendEmail);

        Console.WriteLine();

        Console.WriteLine("===== SMS =====");

        service.Send(
            notification,
            NotificationService.SendSms);

        Console.WriteLine();

        Console.WriteLine("===== PUSH =====");

        service.Send(
            notification,
            NotificationService.SendPush);
    }
}