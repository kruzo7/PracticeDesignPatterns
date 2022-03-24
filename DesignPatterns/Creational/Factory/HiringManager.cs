namespace DesignPatterns.Creational.Factory;
abstract class HiringManager
{
    abstract protected IInterviewer MakeInterviewer();
    public void TakeInterview()
    {
        var interviewer = this.MakeInterviewer();
        interviewer.AskQuestions();
    }
}