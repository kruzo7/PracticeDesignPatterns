namespace DesignPatterns.Behavioral.Command;

class TurnOn : ICommand
{
    private Bulb mBulb;

    public TurnOn(Bulb bulb)
    {
        mBulb = bulb ?? throw new ArgumentNullException("bulb", "bulb cannot be null");
    }

    public void Execute()
    {
        mBulb.TurnOn();
    }

    public void Undo()
    {
        mBulb.TurnOff();
    }

    public void Redo()
    {
        Execute();
    }
}
