using AccConsole;

namespace UnitTests;

[TestClass]
public class PremiumAccountTests
{
    [TestMethod]
    public void PremiumAccount_CalculateInterest_Returns60ForBalance1000AndInterest5Percent()
    {
        var premiumAccount = new PremiumAccount(1, 1000);

        var interest = premiumAccount.CalculateInterest(5);

        Assert.AreEqual(60, interest);
    }
}
