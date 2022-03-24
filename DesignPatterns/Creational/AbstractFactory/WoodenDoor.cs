namespace DesignPatterns.Creational.AbstractFactory;

class WoodenDoor : IDoor
{
    public void GetDescription()
    {
        Console.WriteLine("I am a wooden door.");
    }
}