using System;

class Program
{
    static void Main()
    {
        Notification email = new EmailNotification();
        Notification sms = new SmsNotification();
        Notification push = new PushNotification();

        email.Send();
        sms.Send();
        push.Send();
    }
}