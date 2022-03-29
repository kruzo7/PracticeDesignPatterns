namespace DesignPatterns.Behavioral.ChainOfResponsibility;

class ChainOfResponsibilityMain 
{
    public static void Run()
    {
        var bank = new Bank(100);
        var payPal = new PayPal(200);
        var bitCoin = new BitCoin(300);

        bank.SetNext(payPal);
        payPal.SetNext(bitCoin);

        bank.Pay(259);
    }
}