using AccConsole;

Console.WriteLine("***************  Welcome to the Accounting System 1.0.   ***************");
Account account1 = new CheckingAccount(100, 0);
Account account2 = new PremiumAccount(200, 0);
account1.PrintAccountSummary();
account2.PrintAccountSummary();
account1.Deposit(2000);
account2.Deposit(6000);
account1.PrintAccountSummary();
account2.PrintAccountSummary();
(bool isTransferSuccess, string error) = Account.TransferAmount(account2, account1, 2000);

if (!isTransferSuccess && string.IsNullOrWhiteSpace(error))
{
    Console.WriteLine(error);
}

account1.PrintAccountSummary();
account2.PrintAccountSummary();
decimal checkingAccountInterestAmount = account1.CalculateInterest(3);
decimal premiumAccountInterestAmount = account2.CalculateInterest(3);
Console.WriteLine($"Account1 interest: {checkingAccountInterestAmount}");
Console.WriteLine($"Account2 interest: {premiumAccountInterestAmount}");
account1.Deposit(checkingAccountInterestAmount);
account2.Deposit(premiumAccountInterestAmount);
account1.PrintAccountSummary();
account2.PrintAccountSummary();
