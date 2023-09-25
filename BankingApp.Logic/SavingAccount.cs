using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Logic
{
    public enum AccountStatus { Active, Inactive }
  
    public class SavingAccount:BankAccount
    {
        public enum AccountStatus { Active, Inactive }
        public AccountStatus Status { get; set; }

       
        public SavingAccount(decimal balance, double annualInterestRate) : base(balance, annualInterestRate)
        {
            if (balance > 25) { Status = AccountStatus.Active; }
            else { Status = AccountStatus.Inactive; }
        }

        public void WithDraw(decimal withdrawAmount)
        {
            if (Status == AccountStatus.Inactive)
            {
                return;
            }

            if (Status == AccountStatus.Active)
            {
                base.Withdraw(withdrawAmount);
            }
        }

        public void Deposit(decimal depositAmount)
        {
            base.Deposit(depositAmount);
            if(Status == AccountStatus.Inactive && depositAmount > 25) { Status = AccountStatus.Active; }
            else { Status = AccountStatus.Inactive; }
        }


        public override void MonthlyProcess()
        {
            if (Numberofwithdrawals > 4)
            {
                MonthlyServiceCharge += Numberofwithdrawals - 4;
            }

            base.MonthlyProcess();

            if (Balance <= 25)
            {
                Status = AccountStatus.Inactive;
            }
            else
            {
                Status = AccountStatus.Active;
            }
        }


    }
}
