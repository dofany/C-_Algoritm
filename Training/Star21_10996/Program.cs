using System;

namespace Star21_10996
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n*2; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}