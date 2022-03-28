namespace DesignPatterns.Structural.Composite;

class CompositeMain
{
    public static void Run()
    {
        var developer = new Developer("John", 5000);
        var designer = new Designer("Arya", 5000);

        var organization = new Organization();
        organization.AddEmployee(developer);
        organization.AddEmployee(designer);

        Console.WriteLine($"Net Salary of Employees in Organization is {organization.GetNetSalaries():c}");
    }
}