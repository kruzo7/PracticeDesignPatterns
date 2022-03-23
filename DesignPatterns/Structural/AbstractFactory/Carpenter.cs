namespace DesignPatterns.Structural.AbstractFactory;

class Carpenter : IDoorFittingExpert
{
    public void GetDescription()
    {
        Console.WtireLine("I can only fit wooden doors.");
    }
}