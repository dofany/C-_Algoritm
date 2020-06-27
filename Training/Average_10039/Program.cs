using System;

namespace Average_10039
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] a = Console.ReadLine().Split();
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                int x = int.Parse(a[i]);
                if(x < 40)
                {
                    x = 40;
                }
                result += x;
            }
            Console.WriteLine(result/5);
        }
    }
}
