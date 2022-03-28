namespace DesignPatterns.Structural.Composite;

class Developer : IEmployee
{
    private string mName;
    private float mSalary;

    public Developer(string name, float salary)
    {
        this.mName = name;
        this.mSalary = salary;
    }

    public string GetName()
    {
        return this.mName;
    }

    public string GetRole()
    {
        return "Developer";
    }

    public float GetSalary()
    {
        return this.mSalary;
    }
}