namespace DesignPatterns.Structural.Facade;

class Computer
{
    public void GetElectricShock()
    {
        Console.Write("Ouch!");
    }

    public void MakeSound()
    {
        Console.Write("Beep beep!");
    }

    public void ShowLoadingScreen()
    {
        Console.Write("Loading...");
    }

    public void Bam()
    {
        Console.Write("Ready to be used!");
    }

    public void CloseEverithing()
    {
        Console.Write("Bup bup bup buzzzz!");
    }

    public void Sooth()
    {
        Console.Write("Zzzz");
    }

    public void PullCurrent()
    {
        Console.Write("Haaah!");
    }

}