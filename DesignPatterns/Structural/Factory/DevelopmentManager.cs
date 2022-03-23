namespace DesignPatterns.Structural.Factory;

class DevelopmentManager :HiringManager 
{
    protected override IInterviewer MakeInterviewer()
    {
        return new Developer();
    }
}