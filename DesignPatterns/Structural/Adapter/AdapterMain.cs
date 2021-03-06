namespace DesignPatterns.Structural.Adapter;

class AdapterMain
{
    public static void Run()
    {
        var wildDog = new WildDog();
        var wildDogAdapter = new WildDogAdapter(wildDog);

        var hunter = new Hunter();
        hunter.Hunt(wildDogAdapter);

    }
}