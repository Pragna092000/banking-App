namespace BankingApp.Logic;

public class BankAccount
{
    

    public BankAccount(decimal balance,double annualInterestRate)
    {
        Balance = balance;
        AnnualInterestRate = annualInterestRate;
        NumberOfDeposits = 0;
        Numberofwithdrawals = 0;

    }

    public decimal Balance { get; private set; }
    public double AnnualInterestRate { get; }
    public int NumberOfDeposits { get; private set; }
    public int Numberofwithdrawals { get; private set; }
    public decimal MonthlyServiceCharge { get; internal set; }

    public void Deposit(decimal depositAmount)
    {
        Balance += depositAmount;
        NumberOfDeposits++;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
        Numberofwithdrawals++;
    }

    public void CalculateInterest()
    {
        var monthlyInterestRate = AnnualInterestRate / 12;
        var monthlyInterest = Balance * (decimal)monthlyInterestRate;
        Balance = Balance + monthlyInterest;
    }

    public void MonthlyProcess()
    {
        Balance -= MonthlyServiceCharge;
        CalculateInterest();
        NumberOfDeposits = Numberofwithdrawals = 0;
        MonthlyServiceCharge = 0;
    }
}


