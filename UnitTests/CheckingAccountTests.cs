using AccConsole;

namespace UnitTests;

[TestClass]
public sealed class CheckingAccountTests
{
    [TestMethod]
    public void CheckingAccount_Deposit_Balance1000ForInitial500AndDeposit500()
    {
        var checkingAccount = new CheckingAccount(1, 500);

        checkingAccount.Deposit(500);

        Assert.AreEqual(1000, checkingAccount.Balance);
    }

    [TestMethod]
    public void CheckingAccount_CalculateInterest_Returns50ForBalance1000AndInterest5Percent()
    {
        var checkingAccount = new CheckingAccount(1, 1000);

        var interest = checkingAccount.CalculateInterest(5);

        Assert.AreEqual(50, interest);
    }
}
