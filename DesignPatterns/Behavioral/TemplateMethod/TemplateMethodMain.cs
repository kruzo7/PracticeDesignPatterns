namespace DesignPatterns.Behavioral.TemplateMethod;

class TemplateMethodMain
{
    public static void Run()
    {
        var androidBuilder = new AndroidBuilder();
        androidBuilder.Build();

        var iosBuilder = new IosBuilder();
        iosBuilder.Build();
    }
}