using System;


namespace Ex_UpcastingDowncasting.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }
        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
