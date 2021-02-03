using System;
using EF_Abstract.Entities;
using System.Collections.Generic;

namespace EF_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> lis = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company?");
                string ch = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualinc = double.Parse(Console.ReadLine());

                if (ch == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthexp = double.Parse(Console.ReadLine());

                    lis.Add(new Individual(healthexp, name, anualinc));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nemployees = int.Parse(Console.ReadLine());

                    lis.Add(new Company(nemployees, name, anualinc));
                }
            }

            Console.WriteLine("Taxes Paid:");
            double sum = 0;

            foreach(TaxPayer tax in lis)
            {
                Console.WriteLine($"{tax.Name}: $ {tax.Tax()}");
                sum += tax.Tax();
            }

            Console.WriteLine(sum);

        }
    }
}
