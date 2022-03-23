namespace DesignPatterns.Structural.AbstractFactory;

class welder : IDoorFittingExpert
{
    public void GetDescription()
    {
        Console.WriteLine("I can only fit iron doors.");
    
    }
}