namespace DesignPatterns.Structural.Proxy;

class LabDoobr : IDoor
{
    public void Close()
    {
        Console.WriteLine("Closing lab door.");
    }

    public void Open()
    {
        Console.WriteLine("Opening lab door.");
    }
}