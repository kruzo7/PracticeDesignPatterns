namespace DesignPatterns.Behavioral.Command;

class CommandMain
{
    public static void Run()
    {
        var bulb = new Bulb();

        var turnOn = new TurnOn(bulb);
        var turnOff = new TurnOff(bulb);

        var remoteControl = new RemoteControl();
        remoteControl.Submit(turnOn);
        remoteControl.Submit(turnOff);
        
    }
}