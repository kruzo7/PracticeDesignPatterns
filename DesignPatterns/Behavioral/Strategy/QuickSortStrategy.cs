namespace DesignPatterns.Behavioral.Strategy;

class QuickSortStrategy : ISortStrategy
{
    public List<int> Sort(List<int> dataSet)
    {
        Console.WriteLine("Sorting using quick sort.");
        return dataSet;
    }
}