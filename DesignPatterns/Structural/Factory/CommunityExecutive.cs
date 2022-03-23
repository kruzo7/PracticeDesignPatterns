namespace DesignPatterns.Structural.Factory;
class CommunityExecutive : IInterviewer
{
    public void AskQuestions()
    {
        Cosole.WriteLine("Asking about community.");
    }
}