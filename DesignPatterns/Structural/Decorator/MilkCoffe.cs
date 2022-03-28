namespace DesignPatterns.Structural.Decorator;

class MilkCoffee : ICoffee
{
    private ICoffee mCoffee;

    public MilkCoffee(ICoffee coffee)
    {
        mCoffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");
    }

    public int GetCost()
    {
        return mCoffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return String.Concat(mCoffee.GetDescription(), ", milk");
    }
}