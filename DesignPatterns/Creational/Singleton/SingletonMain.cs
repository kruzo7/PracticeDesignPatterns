namespace DesignPatterns.Creational.Singleton;

class SingletonMain
{
    public static void Main()    
    {
        President a = President.GetInstance();
        President b = President.GetInstance();

        Console.WriteLine(a == b);
    }
}