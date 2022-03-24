namespace DesignPatterns.Creational.Factory;

class MarketingManager : HiringManager 
{
    protected override IInterviewer MakeInterviewer()
    {
        return new CommunityExecutive();
    }
}