using System;

namespace Sangguennald_5543
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int result = 0;
            int input;

            min = int.Parse(Console.ReadLine());
            for(int i = 0; i<2; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (min > input)
                    min = input;
            }
            result += min;

            min = 0;
            min = int.Parse(Console.ReadLine());
            for(int i = 0; i<1; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (min > input)
                    min = input;
            }
            result += (min - 50);
            Console.WriteLine(result);
        }
    }
}
