namespace DesignPatterns.Structural.Factory;

class MarketingManager : HiringManager 
{
    protected override IInterviewer MakeInterviewer()
    {
        return new CommunityExecutive();
    }
}