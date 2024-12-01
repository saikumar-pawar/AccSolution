namespace AccConsole;

public class PremiumAccount : Account
{
    public PremiumAccount(int id, decimal amount) : base(id, amount)
    {
    }

    public override decimal CalculateInterest(decimal interest)
    {
        return Balance * ((interest + 1)/ 100);
    }
}
