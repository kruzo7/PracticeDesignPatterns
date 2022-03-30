namespace DesignPatterns.Behavioral.Visitor;

public class Monkey : IAnimal
{
    public void Shout()
    {
        Console.WriteLine("Oooh o aa aa!");
    }

    public void Accepet(IAnimalOpertion operation)
    {
        operation.VisitMonkey(this);
    }
}
