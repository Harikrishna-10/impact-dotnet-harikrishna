using System;

public class EmailNotification : Notification
{
    public sealed override void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}