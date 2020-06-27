using System;

namespace AB_sub7_11021
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 1; i <= t; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                Console.WriteLine("Case #{0}: {1}", i,int.Parse(a[0])+int.Parse(a[1]));
            }
            
        }
    }
}
