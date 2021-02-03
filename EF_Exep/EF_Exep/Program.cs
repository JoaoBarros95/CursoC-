using System;
using EF_Exep.Entities;
using EF_Exep.Entities.Exeptions;
using System.Globalization;

namespace EF_Exep
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawlimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message );
            }
        }
    }
}
