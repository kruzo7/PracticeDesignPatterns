namespace DesignPatterns.Behavioral.Command;

class RemoteControl
{
    public void Submit(ICommand command)
    {
        command.Execute();
    }    
}