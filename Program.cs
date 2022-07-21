using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("\nPosition " + i + ", " + j + ": ");
                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (j < N - 1)
                            Console.WriteLine("Rigth: " + mat[i, j + 1]);
                        if (i < M - 1)
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}