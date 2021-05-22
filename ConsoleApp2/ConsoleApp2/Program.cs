using System;

namespace ConsoleApp2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] Y = MatrRandom(N, N, -10, 10);
            MatrPrint(Y);
            Console.WriteLine(GetMaxFromMD(Y));
            Console.ReadLine();
        }
        static int GetMaxFromMD(int[,] Matr)
        {
            int max = Matr[0, 0];
            for (int i = 1; i < Matr.GetLength(0); i++)
                if (Matr[i, i] > max) max = Matr[i, i];
            return max;
        }
        static int[,] MatrRandom(int m, int n, int a, int b)
        {
            Random rnd = new Random();
            int[,] Matr = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    Matr[i, j] = rnd.Next(a, b);
            return Matr;
        }
        static void MatrPrint(int[,] Matr)
        {
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                    Console.Write(string.Format($"{Matr[i, j],4} "));
                Console.WriteLine();
               
            }
        }
    }
}
