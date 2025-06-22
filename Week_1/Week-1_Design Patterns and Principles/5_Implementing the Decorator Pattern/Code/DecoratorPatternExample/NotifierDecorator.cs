public abstract class NotifierDecorator : Notifier
{
    protected Notifier _notifier;

    public NotifierDecorator(Notifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Send(string message)
    {
        _notifier.Send(message);
    }
}
