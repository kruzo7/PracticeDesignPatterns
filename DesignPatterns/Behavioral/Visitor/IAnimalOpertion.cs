namespace DesignPatterns.Behavioral.Visitor;
public interface IAnimalOpertion
{
    void VisitMonkey(Monkey monkey);
    void VisitLion(Lion lion);
    void VisitDolphin(Dolphin dolphin);
}
