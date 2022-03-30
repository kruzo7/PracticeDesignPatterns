namespace DesignPatterns.Behavioral.Observer;

class JobSeeker : IObserver<JobPost>
{
    public string Name {get; private set;} 

    public JobSeeker(string name)
    {
        Name = name;        
    }

    public void OnCompleted()
    {
        //No implementation.
    }

    public void OnError(Exception error)
    {
        //No implementation.
    }

    public void OnNext(JobPost value)
    {
        Console.WriteLine($"Hi {Name} ! New job posted: {value.Title}");                
    }
}