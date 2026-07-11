using System;

public class AlarmClock
{
    public event EventHandler<AlarmEventArgs> OnAlarmRing;

    public void RingAlarm()
    {
        Console.WriteLine("Alarm Ringing...\n");

        OnAlarmRing?.Invoke(this,
            new AlarmEventArgs
            {
                AlarmTime = DateTime.Now
            });
    }
}