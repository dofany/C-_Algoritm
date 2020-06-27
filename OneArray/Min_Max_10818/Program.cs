using System;
using System.Text;

namespace Min_Max_10818
{
    class Program
    {
        static int[] numbers;
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            numbers = new int[int.Parse(Console.ReadLine())];

            string[] array = Console.ReadLine().Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                int arg = int.Parse(array[i]);

                if (arg < min) 
                    min = arg;
                if (max < arg) 
                    max = arg;
            }

            Console.Write(min.ToString() + " " + max.ToString());
        }
    }
}
