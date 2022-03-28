namespace DesignPatterns.Structural.Decorator;

class VanillaCoffee : ICoffee
{
    private ICoffee mCoffee;

    public VanillaCoffee(ICoffee coffee)
    {
        mCoffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");
    }

    public int GetCost()
    {
        return mCoffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return String.Concat(mCoffee.GetDescription(), ", vanilla");
    }
}