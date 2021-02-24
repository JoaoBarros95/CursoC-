using System;
using System.Collections.Generic;

namespace EF_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> students = new HashSet<int>();

            for (int i = 0; i < 3; i++)
            {
                string nn = "ABC";
                string n = nn.Substring(i,1);
                Console.Write($"How many students for course {n}?");
                int number = int.Parse(Console.ReadLine());

                for (int ii = 0; ii < number; ii++)
                {
                    students.Add(int.Parse(Console.ReadLine()));
                }
            }
            Console.WriteLine("Total sudents: " + students.Count);
        }
    }
}
