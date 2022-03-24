namespace DesignPatterns.Creational.AbstractFactory;

class Welder : IDoorFittingExpert
{
    public void GetDescription()
    {
        Console.WriteLine("I can only fit iron doors.");
    
    }
}