using System;

public class FileLogger : Logger
{
    public new void Log()
    {
        Console.WriteLine("FileLogger.Log()");
    }
}