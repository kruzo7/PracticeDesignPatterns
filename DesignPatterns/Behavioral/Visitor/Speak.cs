namespace DesignPatterns.Behavioral.Visitor;

class Speak : IAnimalOpertion
{
    public void VisitDolphin(Dolphin dolphin)
    {
        dolphin.Speak();
    }

    public void VisitLion(Lion lion)
    {
        lion.Roar();
    }

    public void VisitMonkey(Monkey monkey)
    {
        monkey.Shout();
    }
}