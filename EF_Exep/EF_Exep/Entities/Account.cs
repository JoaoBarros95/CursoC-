using System;
using System.Collections.Generic;
using System.Text;
using EF_Exep.Entities.Exeptions;

namespace EF_Exep.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public double Desposit(double amount)
        {
            return Balance += amount;
        }

        public double Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new Exceptions("Not enough balance");
            }
            if (amount > WithdrawLimit)
            {
                throw new Exceptions("The amount exceeds withdraw limit");
            }
            return Balance -= amount;
        }
    }
}
