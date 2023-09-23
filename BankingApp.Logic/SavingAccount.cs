using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Logic
{
    internal class SavingAccount:BankAccount
    {
        public bool AccountStatus { get; set; }
        public SavingAccount(decimal balance, double annualInterestRate) : base(balance, annualInterestRate)
        {
            if (balance > 25) { AccountStatus = true; }
            else { AccountStatus = false; }
        }


    }
}
