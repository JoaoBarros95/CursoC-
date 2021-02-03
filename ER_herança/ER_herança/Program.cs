using System;
using System.Collections.Generic;
using ER_herança.NewFolder;

namespace ER_herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            
            List<Emlpoyee> Employees = new List<Emlpoyee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #{0} data: ", i + 1);
                Console.Write("Outsourced (y/n): ");
                string OS = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());

                if (OS == "y" || OS == "Y")
                {
                    Console.Write("Additional Charge: ");
                    double charge = double.Parse(Console.ReadLine());
                    Employees.Add(new OutsourcedEmployee(name, hours, value, charge));
                }
                else
                {
                    Employees.Add(new Emlpoyee(name, hours, value));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payment:");

            foreach (Emlpoyee emp in Employees)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString());
            }
        }
    }
}
