namespace AccConsole;

public class Account
{
    private int Id { get; set; }
    public decimal Balance { get; set; }

    public Account(int id, decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Initial amount cannot be less than zero.");
        }

        Id = id;
        Balance = amount;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public virtual decimal CalculateInterest(decimal interest)
    {
        return Balance * (interest / 100);
    }

    public void PrintAccountSummary()
    {
        Console.WriteLine($"The account with id {Id} has a balance of: {Balance}");
    }

    public static (bool isScuccess, string error) TransferAmount(Account fromAccount, Account toAccount, decimal amount)
    {
        if (amount <= 0)
        {
            return (false, "Transfer failed: Amount must be greater than zero.");
        }
        else if (fromAccount.Balance < amount)
        {
            return (false, $"Transfer failed: Insufficient balance in the source account {fromAccount.Id} for the requested transfer amount {amount}.");
        }

        toAccount.Balance += amount;
        fromAccount.Balance -= amount;
        return (true, string.Empty);
    }
}
