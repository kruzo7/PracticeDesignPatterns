namespace DesignPatterns.Structural.Flyweight;

class FlyweightMain
{
    public static void Run()
    {
        var teaMaker = new TeaMaker();
        var teaShop = new TeaShop(teaMaker);

        teaShop.TakOrder("less suger", 1);
        teaShop.TakOrder("more milk", 2);
        teaShop.TakOrder("without sugar", 5);

        teaShop.Serve();
    }
}