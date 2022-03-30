namespace DesignPatterns.Behavioral.Observer;

class JobPostings : IObservable<JobPost>
{
    private List<IObserver<JobPost>> mObservers;
    private List<JobPost> mJobPostings;

    public JobPostings()
    {
        mObservers = new List<IObserver<JobPost>>();
        mJobPostings = new List<JobPost>();
    }

    public IDisposable Subscribe(IObserver<JobPost> observer)
    {
        if(!mObservers.Contains(observer))
        {
            mObservers.Add(observer);
        }

        return new Unsubscriber<JobPost>(mObservers, observer);
    }

    public void AddJob(JobPost jobPost)
    {
        mJobPostings.Add(jobPost);
        Notify(jobPost);
    }

    private void Notify(JobPost jobPost)
    {
        foreach(var observer in mObservers)
        {
            observer.OnNext(jobPost);
        }
    }
}