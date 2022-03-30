namespace DesignPatterns.Behavioral.Observer;

class JobPost
{
    public string Title { get; private set;}

    public JobPost(string title)
    {
        Title = title;
    }
}