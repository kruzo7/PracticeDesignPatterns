namespace DesignPatterns.Creational.Factory;
class CommunityExecutive : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine("Asking about community.");
    }
}