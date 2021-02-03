using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ordem da matriz: ");
            string[] matriz = Console.ReadLine().Split(" ");
            int n = int.Parse(matriz[0]);
            int m = int.Parse(matriz[1]);
            double[,] mat = new double[n, m];

            Console.WriteLine("Digite a matriz: ");

            for (int i = 0; i < n; i++)
            {
                string[] linhas = Console.ReadLine().Split(" ");
                for (int ii = 0; ii < m; ii++)
                {
                    mat[i, ii] = double.Parse(linhas[ii]);
                }
            }

            Console.WriteLine("Escolha um valor: ");
            int p = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int ii = 0; ii < m; ii++)
                {
                    if (mat[i, ii] == p)
                    {
                        Console.WriteLine("Position: " + i + "," + ii +":" );
                        try
                        { Console.WriteLine("Left: " + mat[i, ii - 1]); }
                        catch { Console.WriteLine("Não Existe"); }
                        try
                        { Console.WriteLine("Right: " + mat[i, ii + 1]); }
                        catch { Console.WriteLine("Não Existe"); }
                        try
                        { Console.WriteLine("Up: " + mat[i - 1, ii]); }
                        catch { Console.WriteLine("Não Existe"); }
                        try
                        { Console.WriteLine("Down: " + mat[i + 1, ii]); }
                        catch { Console.WriteLine("Não Existe"); }
                    }
                }
            }


        }

    }
}
