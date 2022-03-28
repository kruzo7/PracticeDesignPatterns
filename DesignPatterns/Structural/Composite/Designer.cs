namespace DesignPatterns.Structural.Composite;

class Designer : IEmployee
{
    private string mName;
    private float mSalary;

    public Designer(string name, float salary)    
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
        return "Designer";
    }

    public float GetSalary()
    {
        return this.mSalary;
    }
}