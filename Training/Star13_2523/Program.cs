using System;

namespace Star13_2523
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = i + 1; j > 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
