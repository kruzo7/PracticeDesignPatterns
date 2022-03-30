namespace DesignPatterns.Behavioral.Observer;

internal class Unsubscriber<T> : IDisposable
{
    private List<IObserver<JobPost>> mObservers;
    private IObserver<JobPost> mObserver;

    public Unsubscriber(List<IObserver<JobPost>> mObservers, IObserver<JobPost> observer)
    {
        this.mObservers = mObservers;
        this.mObserver = observer;
    }

    public void Dispose()
    {
        if (mObservers.Contains(mObserver))
        {
            mObservers.Remove(mObserver);
        }
    }
}
