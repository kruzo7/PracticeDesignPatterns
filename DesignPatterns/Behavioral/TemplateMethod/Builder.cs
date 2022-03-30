namespace DesignPatterns.Behavioral.TemplateMethod;

abstract class Builder
{
    public void Build()
    {
        Test();
        Lint();
        Assemble();
        Deploy();
    }
    abstract public void Deploy();
    abstract public void Assemble();
    abstract public void Lint();
    abstract public void Test();
}