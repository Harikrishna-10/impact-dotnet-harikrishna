using System;

public delegate void NotificationSender(Notification notification);

public class NotificationService
{
    public event EventHandler<string> OnNotificationSent;

    public void Send(Notification notification, NotificationSender sender)
    {
        sender(notification);

        OnNotificationSent?.Invoke(
            this,
            $"Notification sent successfully to {notification.Recipient} at {DateTime.Now:T}");
    }

    public static void SendEmail(Notification notification)
    {
        Console.WriteLine($"Email sent to {notification.Recipient}");
        Console.WriteLine($"Message : {notification.Message}");
    }

    public static void SendSms(Notification notification)
    {
        Console.WriteLine($"SMS sent to {notification.Recipient}");
        Console.WriteLine($"Message : {notification.Message}");
    }

    public static void SendPush(Notification notification)
    {
        Console.WriteLine($"Push notification sent to {notification.Recipient}");
        Console.WriteLine($"Message : {notification.Message}");
    }
}