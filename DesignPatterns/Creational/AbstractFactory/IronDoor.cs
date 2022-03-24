namespace DesignPatterns.Creational.AbstractFactory;

class IronDoor : IDoor 
{
    public void GetDescription()
    {
        Console.WriteLine("I am iron door");
    }
}