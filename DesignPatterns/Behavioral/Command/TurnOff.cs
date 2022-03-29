namespace DesignPatterns.Behavioral.Command;

class TurnOff : ICommand
{
    private Bulb mBulb;

    public TurnOff(Bulb bulb)
    {
        mBulb = bulb ?? throw new ArgumentNullException("bulb", "bulb should not be null");
    }

    public void Execute()
    {
        mBulb.TurnOff();
    }

    public void Redo()
    {
        Execute();
    }

    public void Undo()
    {
        mBulb.TurnOff();
    }
}