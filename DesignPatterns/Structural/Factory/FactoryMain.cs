namespace DesignPatterns.Structural.Factory;

class FactoryMain
{
    public static void Main()
    {
        var devManager = new DevelopmentManager();
        devManager.TakeInterview();

        var MarketingManager = new MarketingManager();
        MarketingManager.TakeInterview();
    }
    
}