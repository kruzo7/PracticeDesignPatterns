namespace DesignPatterns.Structural.AbstractFactory;

class IronDoor : IDoor 
{
    public void GetDescription()
    {
        Console.WriteLine("I am iron door");
    }
}