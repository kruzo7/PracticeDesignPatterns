namespace DesignPatterns.Behavioral.ChainOfResponsibility;

class BitCoin : Account
{
    public BitCoin(decimal balance)
    {
        this.mBalance = balance;
    }
}