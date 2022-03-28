namespace DesignPatterns.Structural.Facade;

class ComputerFacade
{
    private Computer mComputer;

    public ComputerFacade(Computer computer)
    {
        this.mComputer = computer ?? throw new ArgumentNullException("computer", "computer should not be null");
    }

    public void TurnOn()
    {
        mComputer.GetElectricShock();
        mComputer.MakeSound();
        mComputer.ShowLoadingScreen();
        mComputer.Bam();
    }

    public void TurnOff()
    {
        mComputer.CloseEverithing();
        mComputer.PullCurrent();
        mComputer.Sooth();
    }
}