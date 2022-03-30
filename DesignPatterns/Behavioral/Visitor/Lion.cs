namespace DesignPatterns.Behavioral.Visitor;

public class Lion : IAnimal
{
    public void Roar()
    {
        Console.WriteLine("Roaar!");
    }
    public void Accepet(IAnimalOpertion operation)
    {
        operation.VisitLion(this);
    }
}