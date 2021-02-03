using System;
using System.Globalization;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());
            List<Empregados> list = new List<Empregados>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" +n);
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string nome = Console.ReadLine();
                Console.Write("Salary:");
                double salario = double.Parse(Console.ReadLine());
                Empregados c = new Empregados(id, nome, salario);
                list.Add(c);
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee Id that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Empregados emp = list.Find(x => x.Id == searchID);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.Aumento(percentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees");

            foreach (Empregados obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
