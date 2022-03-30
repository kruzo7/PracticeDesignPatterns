namespace DesignPatterns.Behavioral.Strategy;

class Sorter
{
    private ISortStrategy mSorter;

    public Sorter(ISortStrategy sorter)
    {
        mSorter = sorter;
    }

    public List<int> Sort(List<int> unSortedList)
    {
        return mSorter.Sort(unSortedList);
    }
}