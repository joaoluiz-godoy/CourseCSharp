using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_UpcastingDowncasting.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            this.InterestRate = interestRate;
        }

        public void updateBalance()
        {
            this.Balance *= InterestRate;
        }
    }
}
