using System;

public class PushNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Push Notification");
    }
}