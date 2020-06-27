using System;

namespace AB_sub8_11022
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i<t;i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                Console.WriteLine("Case #{0}: {1} + {2} = {3}", i, int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[0]) + int.Parse(a[1]));
            }
        }
    }
}
