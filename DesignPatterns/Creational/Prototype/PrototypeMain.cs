namespace DesignPatterns.Creational.Prototype;

class PrototypeMain
{
    public static void Run()
    {
        var orginal = new Sheep("Jolly", "Mountain Sheep");
        Console.WriteLine(orginal.Name);
        Console.WriteLine(orginal.Category);

        var cloned = orginal.Clone();
        cloned.Name = "Dolly";
        Console.WriteLine(cloned.Name);
        Console.WriteLine(cloned.Category);
        Console.WriteLine(orginal.Name);

    }
}