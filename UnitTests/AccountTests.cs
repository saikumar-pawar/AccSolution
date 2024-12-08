using AccConsole;

namespace UnitTests;

[TestClass]
public class AccountTests
{
    [TestMethod]
    public void Account_TransferAmount_SuccessfulMoneyTransfer()
    {
        var account1 = new Account(1, 500);
        var account2 = new Account(2, 200);

        var result = account1.TransferAmount(account2, 400);

        Assert.IsTrue(result.isScuccess);
    }
}
