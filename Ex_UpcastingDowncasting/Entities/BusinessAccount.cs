using System;
using System.Collections.Generic;

namespace Ex_UpcastingDowncasting.Entities
{
    class BusinessAccount : Account
    {
        double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            this.LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                this.Balance += amount;
            }
        }
    }
}
