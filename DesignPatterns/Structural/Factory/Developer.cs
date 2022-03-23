namespace DesignPatterns.Structural.Factory;
class Developer : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine("Asking about design patterns.");
    }
}