namespace DesignPatterns.Creational.Builder;

class BuilderMain
{
    public static void Run()
    {
        var burger = new BurgerBuilder(4).AddCheese().AddPepperoni().AddLettuce().AddTomato().Build();

        Console.WriteLine(burger.GetDescription());
    }
}