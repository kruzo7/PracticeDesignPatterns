namespace DesignPatterns.Behavioral.ChainOfResponsibility;

class Account
{
    private Account? mSuccessor;
    protected decimal mBalance;

    public void SetNext(Account account)
    {
        mSuccessor = account;        
    }

    public void Pay(decimal amountTopay)
    {
        if(CanPay(amountTopay))
        {
            Console.WriteLine($"Paid {amountTopay:c} using {this.GetType().Name}.");
        }
        else if (this.mSuccessor != null)
        {
            Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding...");
            mSuccessor.Pay(amountTopay);
        }
        else
        {
            throw new Exception("None fo the accounts have enough balance");
        }
    }

    private bool CanPay(decimal amount)
    {
        return mBalance >= amount;
    }
}