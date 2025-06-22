using System;

public class SMSNotifierDecorator : NotifierDecorator
{
    public SMSNotifierDecorator(Notifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SMS sent: {message}");
    }
}

