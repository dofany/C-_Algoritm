using System;

namespace Grade_9498
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a <= 100 && a >= 90)
                Console.WriteLine("A");
            else if (a <= 89 && a >= 80)
                Console.WriteLine("B");
            else if (a <= 79 && a >= 70)
                Console.WriteLine("C");
            else if (a <= 69 && a >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
