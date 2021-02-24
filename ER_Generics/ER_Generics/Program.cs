using System;
using System.IO;
using System.Collections.Generic;

namespace ER_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Universidade\Cursos\C#\Pratica\ER_Generics\text1.txt";
            StreamReader sr = null;
            HashSet<string> a = new HashSet<string>();
            try
            {
                sr = new StreamReader(new FileStream(path, FileMode.Open));
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(" ");
                    a.Add(line[0]);
                }
                int sum = 0;
                foreach (string client in a)
                {
                    Console.WriteLine(client);
                    sum += 1;
                }
                Console.WriteLine();
                Console.WriteLine("Total users; " + sum);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            

        }
    }
}
