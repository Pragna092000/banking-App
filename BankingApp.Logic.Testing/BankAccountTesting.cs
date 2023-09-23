namespace BankingApp.Logic.Testing;

public class ABankAccount
{   
   [Test]
    public void ShouldSetBalanceAndAnnualInterestRateWhenConstructed()
    {
        BankAccount sut = new BankAccount(100.0m, 0.01);
        Assert.That(sut.Balance, Is.EqualTo(100.0m));
        Assert.That(sut.AnnualInterestRate, Is.EqualTo(0.01));
    }

    [Test]
    public void ShouldIncreaseTheBalanceAfterADeposit()
    {
        // AAA
        //Arrange
        var sut = new BankAccount(0.0m, 0.01);
        //Act
        sut.Deposit(100.0m);
        //Assert
        Assert.That(sut.Balance, Is.EqualTo(100.0m));
    }

    [Test]
    public void ShouldIncrementTheNumberofDepositsByoneAfterDeposit()
    {
        //Arrage
        var sut = new BankAccount(0.0m, 0.01);
        //Act
        sut.Deposit(100.0m);
        //Assert
        Assert.That(sut.NumberOfDeposits, Is.EqualTo(1));

    }


    [Test]
    public void ShouldReduceTheBalanceAfterwithdrawing()
    {
        //Arrange
        var sut = new BankAccount(100.0m, 0.01);
        //Act
        sut.Withdraw(20.0m);
        //Assert
        Assert.That(sut.Balance, Is.EqualTo(80.0m));
    }
    [Test]
    public void ShouldIncrementTheNumberOfWithdrawalsByOneAfterAWithdrawal()
    {
        //Arrange
        var sut = new BankAccount(100.0m, 0.01);
        //Act
        sut.Withdraw(20.0m);
        //Assert
        Assert.That(sut.Numberofwithdrawals, Is.EqualTo(1));
    }
    [Test]
    public void ShouldIncreaseBalanceAfterCalculatingInterest()
    {
        var sut = new BankAccount(100.0m, 0.12);
        sut.CalculateInterest();
        Assert.That(sut.Balance, Is.EqualTo(101.0m));
    }

    [Test]
    public void ShouldUpdateBalanceAfterTheMonthlyProcess()
    {
        //Arrange
        var sut = new BankAccount(100.0m, .12);
        sut.Deposit(50.0m);
        sut.Withdraw(50.0m);
        sut.MonthlyServiceCharge = 5.0m;
        //Act
        sut.MonthlyProcess();
        Assert.That(sut.Balance, Is.EqualTo(95.95m));
    }

    
}
