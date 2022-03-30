namespace DesignPatterns.Behavioral.TemplateMethod;

class AndroidBuilder : Builder
{
    public override void Assemble()
    {
        Console.WriteLine("Assembling the andorid build.");
    }

    public override void Deploy()
    {
        Console.WriteLine("Deployng android build to server.");
    }

    public override void Lint()
    {
        Console.WriteLine("Linting the android code.");
    }

    public override void Test()
    {
        Console.WriteLine("Running android tests.");
    }
}