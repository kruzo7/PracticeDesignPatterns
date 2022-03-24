namespace DesignPatterns.Creational.Factory;

class DevelopmentManager :HiringManager 
{
    protected override IInterviewer MakeInterviewer()
    {
        return new Developer();
    }
}