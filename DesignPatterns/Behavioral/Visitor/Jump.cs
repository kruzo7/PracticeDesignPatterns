namespace DesignPatterns.Behavioral.Visitor;

class Jump : IAnimalOpertion
{
    public void VisitDolphin(Dolphin dolphin)
    {
        Console.WriteLine("Walked on water a little and disappeared!");
    }

    public void VisitLion(Lion lion)
    {
        Console.WriteLine("Jumped 7 feet! Back on the goround!");
    }

    public void VisitMonkey(Monkey monkey)
    {
        Console.WriteLine("Jumped 20 fet high! On the tree!");
    }
}