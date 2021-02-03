using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos?");
            int n = int.Parse(Console.ReadLine());
            Estudantes[] vec = new Estudantes[10];
            int quarto;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Numero: ");
                double email = double.Parse(Console.ReadLine());

                Console.Write("Qual quarto?: ");
                quarto = int.Parse(Console.ReadLine());

                if (vec[quarto] != null)
                {
                    Console.WriteLine("Quarto ocupado pelo " + vec[quarto]);
                    Console.WriteLine("Deseja alterar");
                    string resposta = Console.ReadLine();

                    if (resposta == "s")
                    {
                        vec[quarto] = new Estudantes(nome, email);
                    }
                    else if (resposta == "t")
                    {
                        Console.Write("Qual quarto?: ");
                        quarto = int.Parse(Console.ReadLine());

                        vec[quarto] = new Estudantes(nome, email);
                    }
                    else
                    {
                        Console.WriteLine("Pedido não aceite");
                    }
                }
                else
                {
                    vec[quarto] = new Estudantes(nome, email);
                }              
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vec[i] != null)
                {
                    Console.WriteLine(i + ": " + vec[i]);
                }
            }
        }
    }
}