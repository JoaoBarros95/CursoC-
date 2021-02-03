using System;
using Enumeration.Entities;
using Enumeration.Entities.Enums;
using System.Globalization;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name:" );
            string department = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Level:");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary:");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(department);
            Worker worker = new Worker(name, salary, level, dept);

            Console.Write("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #{0} contract data: ", i+1);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date,value, hours);
                worker.AddContract(contract);   
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime dateSale = DateTime.Parse(Console.ReadLine());

            double income = worker.Income(dateSale.Year, dateSale.Month);
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departement:" + worker.Department.Name);
            Console.WriteLine("Income for " + dateSale.ToString("MM/yyyy") + ": " + income.ToString("F2"));
        }
    }
}
