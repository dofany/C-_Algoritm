using System;

namespace Compare_1330
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b)
                Console.WriteLine("<");
            else if (a > b)
                Console.WriteLine(">");
            else
                Console.WriteLine("==");
        }
    }
}
