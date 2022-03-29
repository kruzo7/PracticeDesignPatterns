namespace DesignPatterns.Behavioral.Mediator;

class MediatorMain
{
    public static void Run()
    {
        var mediator = new ChatRoom();

        var john = new User("John", mediator);
        var jane = new User("Jane", mediator);

        john.Send("Hi there!");
        jane.Send("Hey!");
    }
}