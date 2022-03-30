namespace DesignPatterns.Behavioral.Visitor;

public class Dolphin : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Tuut tittu tuutt!");
    }

    public void Accepet(IAnimalOpertion operation)
    {
        operation.VisitDolphin(this);
    }
}
