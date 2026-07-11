using System;

class Program
{
    static void Main()
    {
        AlarmClock alarm = new AlarmClock();

        Person person = new Person();
        CoffeeMachine coffee = new CoffeeMachine();

        alarm.OnAlarmRing += person.WakeUp;
        alarm.OnAlarmRing += coffee.MakeCoffee;

        alarm.RingAlarm();
    }
}