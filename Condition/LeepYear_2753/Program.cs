using System;

namespace LeepYear_2753
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}
