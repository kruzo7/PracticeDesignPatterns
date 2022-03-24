namespace DesignPatterns.Creational.AbstractFactory;

class Carpenter : IDoorFittingExpert
{
    public void GetDescription()
    {
        Console.WriteLine("I can only fit wooden doors.");
    }
}