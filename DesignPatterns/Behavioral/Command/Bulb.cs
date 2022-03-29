namespace DesignPatterns.Behavioral.Command;

class Bulb
{
    public void TurnOn()
    {
        Console.WriteLine("Bulb has been lit.");
    }
    public void TurnOff()
    {
        Console.WriteLine("Darkness!");
    }
}