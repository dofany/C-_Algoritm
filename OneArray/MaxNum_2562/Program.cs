using System;
using System.Text;

namespace MaxNum_2562
{
    class Program
    {
        static int[] numbers;
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int max = 0;
            int index = 0;

            for (int i = 0; i < 9; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (max < a)
                {
                    max = a;
                    index = i + 1;
                }

            }
            sb.Append(max).Append('\n').Append(index);
            Console.Write(sb);
        }
    }
}
