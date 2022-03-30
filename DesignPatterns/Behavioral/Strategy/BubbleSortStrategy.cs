namespace DesignPatterns.Behavioral.Strategy;

class BubbleSortStrategy : ISortStrategy
{    
    public List<int> Sort(List<int> dataSet)
    {
        Console.WriteLine("Sorting using bubble sort.");
        return dataSet;
    }
}