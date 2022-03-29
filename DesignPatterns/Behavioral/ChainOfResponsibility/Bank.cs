namespace DesignPatterns.Behavioral.ChainOfResponsibility;

class Bank : Account
{
    public Bank(decimal balance)
    {
        this.mBalance = balance;
    }
}