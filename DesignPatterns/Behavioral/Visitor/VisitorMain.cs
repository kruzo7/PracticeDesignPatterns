namespace DesignPatterns.Behavioral.Visitor;

class VisitorMain
{
    public static void Run()
    {
        var monkey = new Monkey();
        var lion = new Lion();
        var dolphin = new Dolphin();

        var speak = new Speak();

        monkey.Accepet(speak);
        lion.Accepet(speak);
        dolphin.Accepet(speak);

        var jump = new Jump();

        monkey.Accepet(jump);
        lion.Accepet(jump);
        dolphin.Accepet(jump);
    }
}