using System;

class Program
{
    static void Main()
    {
        Light livingRoomLight = new Light();

        Command lightOn = new LightOnCommand(livingRoomLight);
        Command lightOff = new LightOffCommand(livingRoomLight);

        RemoteControl remote = new RemoteControl();

        // Turn light on
        remote.SetCommand(lightOn);
        remote.PressButton();

        // Turn light off
        remote.SetCommand(lightOff);
        remote.PressButton();
    }
}
