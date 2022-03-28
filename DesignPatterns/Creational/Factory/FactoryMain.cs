namespace DesignPatterns.Creational.Factory;

class FactoryMain
{
    public static void Run()
    {
        var devManager = new DevelopmentManager();
        devManager.TakeInterview();

        var MarketingManager = new MarketingManager();
        MarketingManager.TakeInterview();
    }
    
}