using System;

class Program
{
    static void Main()
    {
        // Base notifier
        Notifier email = new EmailNotifier();

        // Decorate with SMS
        Notifier emailAndSMS = new SMSNotifierDecorator(email);

        // Decorate further with Slack
        Notifier fullNotifier = new SlackNotifierDecorator(emailAndSMS);

        // Send notification through all channels
        fullNotifier.Send("System maintenance scheduled at 2 AM.");
    }
}
