using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            int[,] matriz;

            n = int.Parse(Console.ReadLine());
            matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();

            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
            Console.ReadLine();

        }
    }
}