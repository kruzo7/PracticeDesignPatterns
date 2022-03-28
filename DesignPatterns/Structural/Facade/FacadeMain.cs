namespace DesignPatterns.Structural.Facade;

class FacadeMain
{
    public static void Run()
    {
        var computer = new ComputerFacade(new Computer());
        computer.TurnOn();
        Console.WriteLine();
        computer.TurnOff();
        Console.ReadLine();
    }
}