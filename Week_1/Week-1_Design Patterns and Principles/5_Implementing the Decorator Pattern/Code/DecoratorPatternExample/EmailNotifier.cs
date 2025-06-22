using System;

public class EmailNotifier : Notifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}
