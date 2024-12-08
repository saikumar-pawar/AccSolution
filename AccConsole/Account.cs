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

    public (bool isScuccess, string error) TransferAmount(Account toAccount, decimal amount)
    {
        if (amount <= 0)
        {
            return (false, "Transfer failed: Amount must be greater than zero.");
        }
        else if (this.Balance < amount)
        {
            return (false, $"Transfer failed: Insufficient balance in the source account {this.Id} for the requested transfer amount {amount}.");
        }

        this.Balance -= amount;
        toAccount.Balance += amount;
        return (true, string.Empty);
    }
}
