using System;

public class SmsNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}