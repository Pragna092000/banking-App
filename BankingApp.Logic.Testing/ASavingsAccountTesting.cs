namespace BankingApp.Logic.Testing;

public class AsavingsAccount
{
	[Test]
	public void SavingAccountIsActive()
	{
		SavingAccount sut = new SavingAccount(0, .01);
		sut.Deposit(50);
		Assert.That(sut.Status, Is.EqualTo(SavingAccount.AccountStatus.Active));
	}
	[Test]
	public void SavingAccountIsNotActive()
	{
		var sut = new SavingAccount(20, .01);
		Assert.That(sut.Status, Is.EqualTo(SavingAccount.AccountStatus.Inactive));
	}

	[Test]
	public void StatusAfterWithdrawal()
	{
		var sut = new SavingAccount(50, .01);
		sut.Withdraw(20);
		Assert.That(sut.Balance, Is.EqualTo(30));
        Assert.That(sut.Status, Is.EqualTo(SavingAccount.AccountStatus.Active));
    }

	[Test]
	public void NumberOfWithdrawalsEqualTo4()
	{
		var sut = new SavingAccount(50, .01);
		sut.WithDraw(10);
        sut.WithDraw(1);
        sut.WithDraw(5);
        sut.WithDraw(3);
        sut.MonthlyServiceCharge = 5.0m;
		sut.MonthlyProcess();
		Assert.That(sut.Status, Is.EqualTo(SavingAccount.AccountStatus.Active));
    }


}
