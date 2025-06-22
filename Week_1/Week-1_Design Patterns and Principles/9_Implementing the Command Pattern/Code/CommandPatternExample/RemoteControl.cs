public class RemoteControl
{
    private Command _command;

    public void SetCommand(Command command)
    {
        _command = command;
    }

    public void PressButton()
    {
        if (_command != null)
        {
            _command.Execute();
        }
        else
        {
            Console.WriteLine("No command set.");
        }
    }
}
