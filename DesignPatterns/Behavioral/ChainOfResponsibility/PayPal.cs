namespace DesignPatterns.Behavioral.ChainOfResponsibility;

class PayPal : Account
{
    public PayPal(decimal balance)
    {
        this.mBalance = balance;
    }
}