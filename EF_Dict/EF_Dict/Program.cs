using System;
using System.IO;
using System.Collections.Generic;

namespace EF_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Universidade\Cursos\C#\Pratica\EF_Dict\text1.csv";
            Dictionary<string, int> dict = new Dictionary<string, int>();

            try
            {
                using (StreamReader sri = File.OpenText(path))
                {
                    while (!sri.EndOfStream)
                    {
                        string[] line = sri.ReadLine().Split(",");
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);

                        if (dict.ContainsKey(candidate))
                        {
                            dict[candidate] += votes;
                        }
                        else
                        {
                            dict[candidate] = votes;
                        }
                    }

                    foreach (var item in dict)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
